namespace Zack.DotNetTrimmerLib
{
    class IOHelpers
    {
        public static void RemoveFiles(string path, string searchPattern)
        {
            var files = Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories);
            foreach (var file in files)
            {
                File.Delete(file);
                ConsoleHelpers.WriteInfo($"{file} removed.");
            }
        }

        public static long GetFolderSize(string dir)
        {
            var files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
            return files.Sum(f => new FileInfo(f).Length);
        }
    }
}
