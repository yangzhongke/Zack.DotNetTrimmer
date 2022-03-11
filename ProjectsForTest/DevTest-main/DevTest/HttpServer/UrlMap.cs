using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.HttpServer
{
    public class UrlMap
    {
        public string Host { get; set; }
        public string Url { get; set; }

        public string OldIp { get; set; }

        public string NewIp { get; set; }

        public bool Used { get; set; }

        public UrlMap() { }
        public UrlMap(string host, string url, string oldIp, string newIp, bool used)
        {
            Host = host;
            Url = url;
            OldIp = oldIp;
            NewIp = newIp;
            Used = used;
        }

        public static List<UrlMap> Load(string file)
        {
            var urlMap = new List<UrlMap>();
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach (var line in lines)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    var sp = line.Split('|');
                    UrlMap map = new UrlMap();
                    map.Host = sp[0];
                    map.Url = sp[1];
                    map.OldIp = sp[2];
                    map.NewIp = sp[3];
                    map.Used = sp[4] == "1";
                    urlMap.Add(map);
                }
            }
            return urlMap;
        }

        public static void Save(List<UrlMap> maps, string file)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in maps)
            {
                sb.Append(item.Host);
                sb.Append('|');
                sb.Append(item.Url);
                sb.Append('|');
                sb.Append(item.OldIp);
                sb.Append('|');
                sb.Append(item.NewIp);
                sb.Append('|');
                sb.Append(item.Used ? "1" : "0");
                sb.Append("\r\n");
            }
            File.WriteAllText(file, sb.ToString());
        }

        public override string ToString()
        {
            return $"[{(Used ? "启用" : "禁用")}] {Host} => {OldIp} => {NewIp}";
        }
    }
}
