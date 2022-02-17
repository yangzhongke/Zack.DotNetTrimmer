using Microsoft.Diagnostics.NETCore.Client;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Reflection.PortableExecutable;
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
            FileRemoved(this,new FileRemovedEventArgs(fileFullPath));
        }
    }
    
    private void FireMessageReceived(string msg)
    {
        if(MessageReceived != null)
        {
            MessageReceived(this,new MessageReceivedEventArgs(msg));
        }
    }

    public bool Run()
    {
        string startupFile = options.StartupFile;
        string startupDir;

        var dir = Path.GetDirectoryName(startupFile);
        if (dir == null)
        {
            FireMessageReceived($"GetDirectoryName() of {startupFile} is empty");
            return false;
        }
        else
        {
            startupDir = dir;
        }
        ProcessStartInfo psInfo = new ProcessStartInfo(startupFile);
        psInfo.UseShellExecute = true;
        psInfo.WorkingDirectory = startupDir;
        psInfo.Arguments = string.Join(" ", options.Arguments);
        Process? p = Process.Start(psInfo);
        if (p == null)
        {
            FireMessageReceived("Error: Starting process failed!");
            return false;
        }
        Console.CancelKeyPress += (_, ck) => {
            //when the user pressed Ctrl+C, the trimmed process will be terminated first.
            if (p != null)
            {
                FireMessageReceived($"Application shutting down.");
                p.CloseMainWindow();
                p.WaitForExit();
                p = null;
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
        HashSet<string> loadedAssemblies = new HashSet<string>();
        using EventPipeSession session = client.StartEventPipeSession(providers, false);
        var source = new EventPipeEventSource(session.EventStream);
        source.Clr.All += (TraceEvent obj) => {
            if (obj is KnownPathProbedTraceData)
            {
                var data = (KnownPathProbedTraceData)obj;
                loadedAssemblies.Add(data.FilePath);
            }
            else if (obj is ResolutionAttemptedTraceData)
            {
                var data = (ResolutionAttemptedTraceData)obj;
                string asmFullPath = data.ResultAssemblyPath;
                if (!string.IsNullOrWhiteSpace(asmFullPath))
                {
                    loadedAssemblies.Add(asmFullPath);
                }
            }
            else if (obj is ModuleLoadUnloadTraceData)
            {
                var data = (ModuleLoadUnloadTraceData)obj;
                string asmFullPath = data.ModuleILPath;
                if (!string.IsNullOrWhiteSpace(asmFullPath))
                {
                    loadedAssemblies.Add(asmFullPath);
                }
            }
            //for Linux
            else if(obj is DomainModuleLoadUnloadTraceData)
            {
                var data = (DomainModuleLoadUnloadTraceData)obj;
                string asmFullPath = data.ModuleILPath;
                loadedAssemblies.Add(asmFullPath);
            }
            /*
            else
            {
                string typeName = obj.GetType().Name;
                if(!typeName.StartsWith("GC")&&!typeName.Contains("GCHandle")
                    &&!typeName.Contains("ILStub"))
                {
                    string logFilePath = Path.Combine(startupDir, "Zack.DotNetTrimmer.log");
                    File.AppendAllText(logFilePath, $"{typeName} {obj}\r\n");
                }                
            }*/
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
        var allDllFiles = Directory.GetFiles(startupDir, "*.dll", SearchOption.AllDirectories)
            .Where(asmPath => IsManagedAssembly(asmPath));
        var unloadedAssemblies = allDllFiles.Except(loadedAssemblies);
        var totalSize = unloadedAssemblies.Select(f => new FileInfo(f).Length).Sum() * 1.0 / (1024 * 1024);
        foreach (string asmFile in unloadedAssemblies)
        {
            File.Delete(asmFile);
            FireFileRemoved(asmFile);
            string pdbFile = Path.ChangeExtension(asmFile, ".pdb");
            if(File.Exists(pdbFile))//delete related pdb files
            {
                File.Delete(pdbFile);
                FireFileRemoved(pdbFile);
            }
        }
        //Delete *.deps.json and *.runtimeconfig.json when using WinForm on .NET 5
        foreach (var file in Directory.GetFiles(startupDir, "*.deps.json"))
        {
            File.Delete(file);
            FireFileRemoved(file);
        }
        foreach (var file in Directory.GetFiles(startupDir, "*.runtimeconfig.json"))
        {
            File.Delete(file);
            FireFileRemoved(file);
        }
        FireMessageReceived($"done, reduced file size:{totalSize:0.00} MB");
        FireMessageReceived("Waiting for exit.");
        if (p!=null)p.Dispose();
        return true;
    }
}