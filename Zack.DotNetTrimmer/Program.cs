//https://docs.microsoft.com/en-us/dotnet/core/diagnostics/eventpipe
//https://docs.microsoft.com/en-us/dotnet/core/diagnostics/diagnostics-client-library
//https://docs.microsoft.com/en-us/dotnet/core/dependency-loading/collect-details

using Zack.DotNetTrimmer;

if (args.Length <= 0)
{
    Console.WriteLine("Arguments: a.exe arg1 arg2");
    return;
}
string startupFile = args[0];
string[] arguments = args.Skip(1).ToArray();
CommandLineOptions cmdOpts = new CommandLineOptions { 
StartupFile=startupFile,Arguments=arguments };
Trimmer trimmer = new Trimmer(cmdOpts);
trimmer.Run();