//https://docs.microsoft.com/en-us/dotnet/core/diagnostics/eventpipe
//https://docs.microsoft.com/en-us/dotnet/core/diagnostics/diagnostics-client-library
//https://docs.microsoft.com/en-us/dotnet/core/dependency-loading/collect-details

using System.Reflection;
using Zack.DotNetTrimmerLib;
using static Zack.DotNetTrimmer.ConsoleHelpers;

var asmVer = Assembly.GetExecutingAssembly().GetName().Version;
WriteInfo($"Version:{asmVer}({Environment.OSVersion})");

if (args.Length <= 0)
{
    WriteError("Usage: Zack.DotNetTrimmer.exe d:/a/test.exe arg1 arg2");
    WriteError("Usage: Zack.DotNetTrimmer.exe --record d:/1.json d:/a/test.exe arg1 arg2");
    WriteError("Usage: Zack.DotNetTrimmer.exe --apply d:/1.json d:/a/test.exe arg1 arg2");
    return;
}
//--record d:/1.json
//--apply d:/1.json
string firstParameter =args[0];
string? recordFileName=null;

string startupFile;
string[] arguments;
TrimmingMode mode;
if (firstParameter.StartsWith("--"))
{
    if(firstParameter== "--record")
    {
        mode = TrimmingMode.Record;
    }
    else if (firstParameter == "--apply")
    {
        mode = TrimmingMode.Apply;
    }
    else
    {
        WriteError("Error: Invalid mode, only --record and --apply are allowed.");
        return;
    }
    recordFileName = args[1];
    startupFile = args[2];
    arguments = args.Skip(3).ToArray();
}
else
{
    mode = TrimmingMode.Direct;
    startupFile = args[0];
    arguments = args.Skip(1).ToArray();
}

if (!Path.IsPathRooted(startupFile))
{
    WriteError($"Error: Please specify the full path instead of {startupFile}");
    return;
}

if (PEHelpers.IsManagedAssembly(startupFile))
{
    //if the file is based on .NET Framework
    var moduleDef = AsmResolver.DotNet.ModuleDefinition.FromFile(startupFile);
    if (moduleDef.OriginalTargetRuntime.Name == ".NETFramework")
    {
        WriteError("Error: Application based on .NET Framework isn't supported, only .NET Core Application is.");
        return;
    }
}
else
{
    string dir = Path.GetDirectoryName(startupFile);
    string dllFileName = Path.GetFileNameWithoutExtension(startupFile)+".dll";
    string dllFileFullPath = Path.Combine(dir, dllFileName);
    if(!File.Exists(dllFileFullPath))
    {
        WriteWarning($"Warning! It looks like {Path.GetFileName(startupFile)} is generated using 'Produce single file', which is not supported. ");
    }
}

string backupDir = BackupHelper.BackupProject(startupFile);
TimmerOptions cmdOpts = new TimmerOptions { Mode=mode, RecordFileName= recordFileName, StartupFile = startupFile, Arguments = arguments };
Trimmer trimmer = new Trimmer(cmdOpts);
trimmer.MessageReceived += (s, e) =>
{
    WriteInfo(e.Message);
};
trimmer.FileRemoved += (s, e) =>
{
    WriteInfo($"File removed:{e.FileFullPath}");
};
trimmer.Run();
if(mode== TrimmingMode.Apply||mode== TrimmingMode.Direct)
{
    WriteInfo($"Original files have been backup into {backupDir}");
}
