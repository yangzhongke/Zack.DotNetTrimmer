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
            }
        }
    }
}
