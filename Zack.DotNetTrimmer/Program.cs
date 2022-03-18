//https://docs.microsoft.com/en-us/dotnet/core/diagnostics/eventpipe
//https://docs.microsoft.com/en-us/dotnet/core/diagnostics/diagnostics-client-library
//https://docs.microsoft.com/en-us/dotnet/core/dependency-loading/collect-details

using System.Reflection;
using Zack.DotNetTrimmer;
using Zack.DotNetTrimmerLib;
using static Zack.DotNetTrimmerLib.ConsoleHelpers;

var asmVer = Assembly.GetExecutingAssembly().GetName().Version;
WriteInfo($"Version:{asmVer}({Environment.OSVersion})");

var options = CmdLineArgsParser.Parse(args);
var startupFile = options.StartupFile;
if (startupFile == null)
{
    WriteError($"Error: Please specify the full path of the application");
    PrintUsage();
    return;
}

if (!Path.IsPathRooted(startupFile))
{
    WriteError($"Error: Please specify the full path instead of {startupFile}");
    PrintUsage();
    return;
}

if(!File.Exists(startupFile))
{
    WriteError($"Error: File not found:{startupFile}");
    WriteError("If the filepath contains whitespaces or other special characters, please use double quotation marks around it.");
    PrintUsage();
    return;
}

if (PEHelpers.IsNetFrameworkApp(startupFile))
{
    WriteError("Error: Application based on .NET Framework isn't supported, only .NET Core Application is.");
    return;
}
if (!PEHelpers.IsSelfContainedApp(startupFile))
{
    WriteError("Error: Only self-contained applications are supported, and framework-dependent ones aren't.");
    return;
}
if (PEHelpers.IsBuiltWithProduce_SingleFile(startupFile))
{
    WriteWarning($"Warning! It looks like {Path.GetFileName(startupFile)} is generated using 'Produce single file', which is not supported. ");
}
if(options.Mode == TrimmingMode.Apply)
{
    if(!File.Exists(options.RecordFileName))
    {
        WriteError($"Error: File not found:{options.RecordFileName}");
        WriteError("If the filepath contains whitespaces or other special characters, please use double quotation marks around it.");
        PrintUsage();
        return;
    }
}

string backupDir = BackupHelper.BackupProject(startupFile);
Trimmer trimmer = new Trimmer(options);
trimmer.Run();
WriteInfo($"Original files have been backup into {backupDir}");

void PrintUsage()
{
    WriteInfo("Usage:");
    WriteInfo("--greedy --record d:/1.json --file d:/1.exe ");
    WriteInfo("--record d:/1.json --greedy --file d:/1.exe a b");
    WriteInfo("--greedy --file d:/1.exe  a b");
    WriteInfo("--file d:/1.exe ");
    WriteInfo("--file \"d:/a  b/1.exe\" ");
    WriteInfo("--apply d:/1.json --greedy --file d:/1.exe");
}
