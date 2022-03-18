using Microsoft.Diagnostics.NETCore.Client;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using static Zack.DotNetTrimmerLib.ConsoleHelpers;
using static Zack.DotNetTrimmerLib.PEHelpers;

namespace Zack.DotNetTrimmerLib;
public class Trimmer
{
    private TimmerOptions options;

    public Trimmer(TimmerOptions options)
    {
        this.options = options;
    }

    public void Run()
    {
        string startupFile = options.StartupFile;
        string startupDir;

        WriteInfo($"Entering {options.Mode} Mode.");

        var dir = Path.GetDirectoryName(startupFile);
        if (dir == null)
        {
            WriteError($"GetDirectoryName() of {startupFile} is empty");
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
                recordFileInfo = JsonHelper.LoadFromFile<RecordFileInfo>(recordFileName);
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
                JsonHelper.SaveAsFile(recordFileName, recordFileInfo);
            }
        }
        else if (options.Mode == TrimmingMode.Apply)
        {
            string recordFileName = options.RecordFileName;
            if (!File.Exists(recordFileName))
            {
                throw new Exception($"{recordFileName} not found!");
            }
            recordFileInfo = JsonHelper.LoadFromFile<RecordFileInfo>(recordFileName);
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
            WriteInfo($"Recording completes. {options.RecordFileName}");
        }
        else
        {
            long sizeBefore = IOHelpers.GetFolderSize(startupDir);

            var allDllFiles = Directory.GetFiles(startupDir, "*.dll", SearchOption.AllDirectories)
            .Where(asmPath => !IsFileIgnored(asmPath) && IsManagedAssembly(asmPath)).ToArray();
            var assembliesNotLoaded = allDllFiles.Where(d => !recordFileInfo.LoadedAssemblies.Contains(Path.GetFileName(d)));
            foreach (var file in assembliesNotLoaded)
            {
                File.Delete(file);
            }
            if (options.Greedy)
            {
                AssemblyTrimmer.TrimAssemblies(startupDir, recordFileInfo.LoadedTypes);
            }
            IOHelpers.RemoveFiles(startupDir, "*.pdb");
            IOHelpers.RemoveFiles(startupDir, "*.runtimeconfig.json");
            IOHelpers.RemoveFiles(startupDir, "*.deps.json");
            long sizeAfter = IOHelpers.GetFolderSize(startupDir);
            double sizeReduced = (sizeBefore - sizeAfter) * 1.0 / (1024 * 1024);
            WriteInfo($"Done! ");
            WriteInfo($"Size before: {sizeBefore * 1.0 / (1024 * 1024):0.00} MB, size after:{sizeAfter * 1.0 / (1024 * 1024):0.00} MB.");
            WriteInfo($"Reduced size:{sizeReduced:0.00} MB");
            WriteInfo("Waiting for exit.");
        }
    }

    private bool RunApp(string startupFile, RecordFileInfo recordFileInfo)
    {
        string startupDir = Path.GetDirectoryName(startupFile);

        ProcessStartInfo psInfo = new ProcessStartInfo(startupFile);
        psInfo.UseShellExecute = true;
        psInfo.WorkingDirectory = startupDir;
        psInfo.Arguments = string.Join(" ", options.Arguments);

        WriteInfo("Press Ctrl+C or Ctrl+Break to terminate the application to be trimmed.");
        using Process? p = Process.Start(psInfo);
        if (p == null)
        {
            WriteError("Error: Starting process failed!");
            return false;
        }
        Console.CancelKeyPress += (_, ck) =>
        {
            //when the user pressed Ctrl+C, the trimmed process will be terminated first.
            if (p != null)
            {
                WriteInfo($"Application shutting down.");
                p.CloseMainWindow();
                p.WaitForExit();
                ck.Cancel = true;//prevent the current Trimmer process from being terminated by Ctrl+C
                WriteInfo($"Application shut down, waiting for to be trimmed.");
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
            WriteError($"Error encountered while processing events:{e}");
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