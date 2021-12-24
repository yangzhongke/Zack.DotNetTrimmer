using Microsoft.Diagnostics.NETCore.Client;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using static Zack.DotNetTrimmer.PEHelpers;

namespace Zack.DotNetTrimmer;
class Trimmer
{
    private CommandLineOptions options;

    public Trimmer(CommandLineOptions options)
    {
        this.options = options;
    }

    public void Run()
    {
        string startupFile = options.StartupFile;
        string startupDir;

        var dir = Path.GetDirectoryName(startupFile);
        if (dir == null)
        {
            Console.WriteLine($"GetDirectoryName() of {startupFile} is empty");
            return;
        }
        else
        {
            startupDir = dir;
        }

        ProcessStartInfo psInfo = new ProcessStartInfo(startupFile);
        psInfo.UseShellExecute = true;
        psInfo.WorkingDirectory = startupDir;
        foreach(var a in options.Arguments)
        {
            psInfo.ArgumentList.Add(a);
        }
        Process? p = Process.Start(psInfo);
        if (p == null)
        {
            Console.WriteLine("Error: Starting process failed!");
            return;
        }
        Console.CancelKeyPress += (_, ck) => {
            //when the user pressed Ctrl+C, the trimmed process will be terminated first.
            if (p != null)
            {
                p.CloseMainWindow();
                p.WaitForExit();
                p = null;
                ck.Cancel = true;//prevent the current Trimmer process from being terminated by Ctrl+C
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
            else
            {
                string typeName = obj.GetType().Name;
                if(!typeName.StartsWith("GC")&&!typeName.Contains("GCHandle")
                    &&!typeName.Contains("ILStub"))
                {
                    string logFilePath = Path.Combine(startupDir, "Zack.DotNetTrimmer.log");
                    File.AppendAllText(logFilePath, $"{typeName} {obj}\r\n");
                }                
            }
        };

        try
        {
            source.Process();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error encountered while processing events");
            Console.WriteLine(e.ToString());
            return;
        }
        var allDllFiles = Directory.GetFiles(startupDir, "*.dll", SearchOption.AllDirectories)
            .Where(asmPath => IsManagedAssembly(asmPath));
        var unloadedAssemblies = allDllFiles.Except(loadedAssemblies);
        var totalSize = unloadedAssemblies.Select(f => new FileInfo(f).Length).Sum() * 1.0 / (1024 * 1024);
        foreach (string asmFile in unloadedAssemblies)
        {
            File.Delete(asmFile);
            Console.WriteLine($"Removed: {asmFile}");
        }
        //Delete *.deps.json and *.runtimeconfig.json when using WinForm on .NET 5
        foreach (var file in Directory.GetFiles(startupDir, "*.deps.json"))
        {
            File.Delete(file);
            Console.WriteLine($"Removed: {file}");
        }
        foreach (var file in Directory.GetFiles(startupDir, "*.runtimeconfig.json"))
        {
            File.Delete(file);
            Console.WriteLine($"Removed: {file}");
        }

        Console.WriteLine($"done, reduced file size:{totalSize:0.00} MB");
        Console.WriteLine("Waiting for exit.");
        if (p!=null)p.Dispose();
    }
}