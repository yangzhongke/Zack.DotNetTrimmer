namespace Zack.DotNetTrimmerLib
{
    class RecordFileInfo
    {
        public HashSet<string> LoadedAssemblies { get; init; } = new HashSet<string>();
        public HashSet<string> LoadedTypes { get; init; } = new HashSet<string>();
    }
}
