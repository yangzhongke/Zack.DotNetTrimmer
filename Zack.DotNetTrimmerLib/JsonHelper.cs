using System.Text.Json;

namespace Zack.DotNetTrimmerLib
{
    static class JsonHelper
    {
        public static void SaveAsFile(string file, object value)
        {
            JsonSerializerOptions jsonOpt = new() { WriteIndented = true };
            using FileStream fileStream = File.Open(file, FileMode.Create);
            JsonSerializer.Serialize(fileStream, value, jsonOpt);
        }

        public static T LoadFromFile<T>(string file)
        {
            using FileStream fileStream = File.OpenRead(file);
            var obj = JsonSerializer.Deserialize<T>(File.ReadAllText(file));
            if (obj == null)
            {
                throw new IOException("loading error");
            }
            else
            {
                return obj;
            }
        }
    }
}
