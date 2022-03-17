using Zack.DotNetTrimmerLib;

namespace Zack.DotNetTrimmer
{
    static class CmdLineArgsParser
    {
        public static TimmerOptions Parse(string[] args)
        {
            //--greedy --record d:/1.json --file d:/1.exe 
            //--record d:/1.json --greedy --file d:/1.exe a b
            //--greedy --file d:/1.exe  a b
            //--file d:/1.exe 
            //--apply d:/1.json --greedy --file d:/1.exe
            TimmerOptions options = new TimmerOptions();
            int greedyIndex = FindArgIndex(args, "--greedy");
            options.Greedy = greedyIndex >= 0;
            int recordIndex = FindArgIndex(args, "--record");
            int applyIndex = FindArgIndex(args, "--apply");
            if (recordIndex >= 0)
            {
                options.Mode = TrimmingMode.Record;
                options.RecordFileName = args[recordIndex + 1];
            }
            else if (applyIndex >= 0)
            {
                options.Mode = TrimmingMode.Apply;
                options.RecordFileName = args[applyIndex + 1];
            }
            else
            {
                options.Mode = TrimmingMode.Direct;
            }
            int fileIndex = FindArgIndex(args, "--file");
            if (fileIndex >= 0)
            {
                options.StartupFile = args[fileIndex + 1];
                options.Arguments = args.Skip(fileIndex + 1).ToArray();
            }
            return options;
        }

        static int FindArgIndex(string[] args, string value)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
