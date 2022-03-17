using Microsoft.Diagnostics.NETCore.Client;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Text.Json;
using static Zack.DotNetTrimmerLib.PEHelpers;

namespace Zack.DotNetTrimmerLib;
public class Trimmer
{
    private TimmerOptions options;
    public event EventHandler<FileRemovedEventArgs> FileRemoved;
    public event EventHandler<MessageReceivedEventArgs> MessageReceived;

    public Trimmer(TimmerOptions options)
    {
        this.options = options;
    }

    private void FireFileRemoved(string fileFullPath)
    {
        if (FileRemoved != null)
        {
            FileRemoved(this, new FileRemovedEventArgs(fileFullPath));
        }
    }

    private void FireMessageReceived(string msg)
    {
        if (MessageReceived != null)
        {
            MessageReceived(this, new MessageReceivedEventArgs(msg));
        }
    }

    public void Run()
    {
        string startupFile = options.StartupFile;
        string startupDir;

        FireMessageReceived($"Entering {options.Mode} Mode.");

        var dir = Path.GetDirectoryName(startupFile);
        if (dir == null)
        {
            FireMessageReceived($"GetDirectoryName() of {startupFile} is empty");
            return;
        }
        else
        {
            startupDir = dir;
        }
        RecordFileInfo recordFileInfo;
        if (options.Mode == TrimmingMode.Record)
        {
            string recordFileName = options.RecordFileName;
            if (File.Exists(recordFileName))
            {
                using FileStream fileStream = File.OpenRead(recordFileName);
                recordFileInfo = JsonSerializer.Deserialize<RecordFileInfo>(fileStream);
            }
            else
            {
                recordFileInfo = new RecordFileInfo();
            }
            if (!RunApp(startupFile, recordFileInfo))
            {
                return;
            }
            else
            {
                JsonSerializerOptions jsonOpt = new() { WriteIndented = true };
                using FileStream fileStream = File.Open(recordFileName, FileMode.Create);
                JsonSerializer.Serialize(fileStream, recordFileInfo, jsonOpt);
            }
        }
        else if (options.Mode == TrimmingMode.Apply)
        {
            string recordFileName = options.RecordFileName;
            if (!File.Exists(recordFileName))
            {
                throw new Exception($"{recordFileName} not found!");
            }
            using FileStream fileStream = File.OpenRead(recordFileName);
            recordFileInfo = JsonSerializer.Deserialize<RecordFileInfo>(File.ReadAllText(recordFileName));
        }
        else if (options.Mode == TrimmingMode.Direct)
        {
            recordFileInfo = new RecordFileInfo();
            if (!RunApp(startupFile, recordFileInfo))
            {
                return;
            }
        }
        else
        {
            throw new NotImplementedException($"Unkown mode:{options.Mode}");
        }

        if (options.Mode == TrimmingMode.Record)
        {
            FireMessageReceived($"Recording completes. {options.RecordFileName}");
        }
        else
        {
            var allDllFiles = Directory.GetFiles(startupDir, "*.dll", SearchOption.AllDirectories)
            .Where(asmPath => !IsFileIgnored(asmPath) && IsManagedAssembly(asmPath)).ToArray();
            var assembliesNotLoaded = allDllFiles.Where(d => !recordFileInfo.LoadedAssemblies.Contains(Path.GetFileName(d)));
            var totalSize = assembliesNotLoaded.Select(f => new FileInfo(f).Length).Sum() * 1.0 / (1024 * 1024);

            /*
            foreach(var asmFile in recordFileInfo.LoadedAssemblies)
            {
                if (!File.Exists(asmFile)) return;
                AssemblyTrimmer.TrimAssembly(asmFile, recordFileInfo.LoadedTypes);
            }*/
            foreach (var file in assembliesNotLoaded)
            {
                File.Delete(file);
            }
            IOHelpers.RemoveFiles(startupDir, "*.pdb");
            IOHelpers.RemoveFiles(startupDir, "*.runtimeconfig.json");
            IOHelpers.RemoveFiles(startupDir, "*.deps.json");

            FireMessageReceived($"Done, reduced file size:{totalSize:0.00} MB");
            FireMessageReceived("Waiting for exit.");
        }
    }

    private bool RunApp(string startupFile, RecordFileInfo recordFileInfo)
    {
        string startupDir = Path.GetDirectoryName(startupFile);

        ProcessStartInfo psInfo = new ProcessStartInfo(startupFile);
        psInfo.UseShellExecute = true;
        psInfo.WorkingDirectory = startupDir;
        psInfo.Arguments = string.Join(" ", options.Arguments);

        FireMessageReceived("Press Ctrl+C or Ctrl+Break to terminate the application to be trimmed.");
        using Process? p = Process.Start(psInfo);
        if (p == null)
        {
            FireMessageReceived("Error: Starting process failed!");
            return false;
        }
        Console.CancelKeyPress += (_, ck) =>
        {
            //when the user pressed Ctrl+C, the trimmed process will be terminated first.
            if (p != null)
            {
                FireMessageReceived($"Application shutting down.");
                p.CloseMainWindow();
                p.WaitForExit();
                ck.Cancel = true;//prevent the current Trimmer process from being terminated by Ctrl+C
                FireMessageReceived($"Application shut down, waiting for to be trimmed.");
            }
        };
        var providers = new List<EventPipeProvider>()
        {
            new EventPipeProvider("Microsoft-Windows-DotNETRuntime",
                EventLevel.Informational, (long)ClrTraceEventParser.Keywords.All)
        };
        var client = new DiagnosticsClient(p.Id);
        using EventPipeSession session = client.StartEventPipeSession(providers, false);
        var source = new EventPipeEventSource(session.EventStream);
        source.Clr.All += (TraceEvent obj) =>
        {
            TraceEventProcessor.Process(recordFileInfo, obj);
        };
        try
        {
            source.Process();
        }
        catch (Exception e)
        {
            FireMessageReceived($"Error encountered while processing events:{e}");
            return false;
        }
        return true;
    }

    static bool IsFileIgnored(string fileName)
    {
        var dirNames = Path.GetDirectoryName(fileName).Split(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
        return dirNames.Contains("_framework");//ignore files under _framework, for Blazor WebAssembly Projects.
    }
}