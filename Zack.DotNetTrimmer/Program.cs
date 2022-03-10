//https://docs.microsoft.com/en-us/dotnet/core/diagnostics/eventpipe
//https://docs.microsoft.com/en-us/dotnet/core/diagnostics/diagnostics-client-library
//https://docs.microsoft.com/en-us/dotnet/core/dependency-loading/collect-details

using Zack.DotNetTrimmerLib;

if (args.Length <= 0)
{
    Console.WriteLine("Error: Arguments: d:/a/test.exe arg1 arg2");
    return;
}
string startupFile = args[0];
if(!Path.IsPathRooted(startupFile))
{
    Console.WriteLine($"Error: Please specify the full path instead of {startupFile}");
    return;
}

string[] arguments = args.Skip(1).ToArray();
if (PEHelpers.IsManagedAssembly(startupFile))
{
    //if the file is based on .NET Framework
    var moduleDef = AsmResolver.DotNet.ModuleDefinition.FromFile(startupFile);
    if (moduleDef.OriginalTargetRuntime.Name == ".NETFramework")
    {
        Console.WriteLine("Application based on .NET Framework isn't supported, only .NET Core Application is.");
        return;
    }
}

string backupDir = BackupHelper.BackupProject(startupFile);
TimmerOptions cmdOpts = new TimmerOptions { StartupFile = startupFile, Arguments = arguments };
Trimmer trimmer = new Trimmer(cmdOpts);
trimmer.MessageReceived += (s, e) =>
{
    Console.WriteLine(e.Message);
};
trimmer.FileRemoved += (s, e) =>
{
    Console.WriteLine($"File removed:{e.FileFullPath}");
};
Console.WriteLine("Press Ctrl+C or Ctrl+Break to terminate the application to be trimmed.");
if (trimmer.Run())
{
    Console.WriteLine("Trimming done.");
}
else
{
    Console.WriteLine("Trimming failed.");
}
Console.WriteLine($"Original files have been backup into {backupDir}");