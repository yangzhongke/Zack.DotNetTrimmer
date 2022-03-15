namespace Zack.DotNetTrimmerLib
{
    public class TimmerOptions
    {
        public TrimmingMode Mode { get; set; }
        public string? RecordFileName { get; set; }
        public string StartupFile { get; set; }
        public string[] Arguments { get; set; }
    }
}
