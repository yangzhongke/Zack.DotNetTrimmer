namespace Zack.DotNetTrimmerLib
{
    public class TimmerOptions
    {
        /// <summary>
        /// Remove unused code from loaded assemblies
        /// </summary>
        public bool Greedy { get; set; }
        public TrimmingMode Mode { get; set; }
        public string? RecordFileName { get; set; }
        public string? StartupFile { get; set; }
        public string[] Arguments { get; set; } = new string[0];
    }
}
