using System.Text.Json;
using System.Text.Json.Nodes;

namespace Zack.DotNetTrimmerLib
{
    [Obsolete]
    static class JsonCleaner
    {
        static void FindNode(JsonObject jsonObject, string propertyName, List<JsonNode> runtimeNodes)
        {
            foreach (var childNode in jsonObject)
            {
                if (childNode.Key == propertyName && childNode.Value != null)
                {
                    runtimeNodes.Add(childNode.Value);
                }
                else if (childNode.Value is JsonObject)
                {
                    FindNode((JsonObject)childNode.Value, propertyName, runtimeNodes);
                }
            }
        }
        public static void TidyDeps_json(string startupFile, IEnumerable<string> unloadedAssemblies, string jsonFile)
        {
            string startupDir = Path.GetDirectoryName(startupFile);
            var unloadedFileNames = new HashSet<string>(unloadedAssemblies.Select(f => Path.GetFileName(f)));
            JsonNode jsonRoot;
            using (FileStream inStream = File.OpenRead(jsonFile))
            {
                jsonRoot = JsonNode.Parse(inStream).Root;
            }
            var targetsNode = jsonRoot["targets"];
            if (targetsNode == null) return;
            List<JsonNode> runtimeNodes = new List<JsonNode>();
            FindNode((JsonObject)targetsNode, "runtime", runtimeNodes);
            foreach (var runtimeNode in runtimeNodes)
            {
                JsonObject runtimeObject = (JsonObject)runtimeNode;
                foreach (var runtimeItem in runtimeObject.ToArray())
                {
                    string fileName = runtimeItem.Key;
                    if (unloadedFileNames.Contains(fileName) ||
                        !File.Exists(Path.Combine(startupDir, fileName)))
                    {
                        runtimeObject.Remove(fileName);
                    }
                }
            }
            JsonWriterOptions jsonWriterOptions = new JsonWriterOptions { Indented = true };
            using (FileStream outStream = File.Open(jsonFile, FileMode.Create, FileAccess.Write))
            using (Utf8JsonWriter writer = new Utf8JsonWriter(outStream, jsonWriterOptions))
            {
                jsonRoot.WriteTo(writer);
            }
        }
    }
}
