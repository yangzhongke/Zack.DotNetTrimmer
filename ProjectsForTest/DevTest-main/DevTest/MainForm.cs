using DevTest.HttpServer;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace DevTest
{
    public partial class MainForm : Form
    {
        MyHttpServer myHttpServer = null;
        List<UrlMap> maps = new List<UrlMap>();
        const string mapFile = "config.ini";

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            maps = UrlMap.Load(mapFile);
            foreach (var item in maps) {
                this.listBox1.Items.Add(item);
            }
            myHttpServer = new MyHttpServer();
            myHttpServer.SetUrlMap(maps);
            myHttpServer.Start();
            //°ó¶¨Host
            button4_Click(null, null);
        }
        // ´°¿Ú¹Ø±Õ
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //½â³ý°ó¶¨
            button5_Click(null, null);
        }

        /// <summary>
        /// Ìí¼ÓÅäÖÃ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            UrlMap map = new UrlMap();
            map.Used = true;
            map.NewIp = "127.0.0.1:8080";
            UrlMapForm form = new UrlMapForm();
            form.UrlMap = map;
            form.Render();
            if (form.ShowDialog() == DialogResult.OK) {
                maps.Add(map);
                UrlMap.Save(maps, mapFile);
                this.listBox1.Items.Clear();
                foreach (var item in maps) {
                    this.listBox1.Items.Add(item);
                }
                myHttpServer.SetUrlMap(maps);
                //°ó¶¨Host
                button4_Click(null, null);
            }
        }
        /// <summary>
        /// Ë«»÷±à¼­
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            button2_Click(null, null);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ÐÞ¸ÄÅäÖÃ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0) {
                var map = this.listBox1.SelectedItem as UrlMap;
                UrlMapForm form = new UrlMapForm();
                form.UrlMap = map;
                form.Render();
                if (form.ShowDialog() == DialogResult.OK) {
                    UrlMap.Save(maps, mapFile);
                    this.listBox1.Items.Clear();
                    foreach (var item in maps) {
                        this.listBox1.Items.Add(item);
                    }
                    myHttpServer.SetUrlMap(maps);
                    //°ó¶¨Host
                    button4_Click(null, null);
                }
            }

        }
        /// <summary>
        /// É¾³ýÅäÖÃ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0) {
                var map = this.listBox1.SelectedItem as UrlMap;
                if (MessageBox.Show("ÊÇ·ñÉ¾³ý" + map.Host, "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    maps.Remove(map);
                    UrlMap.Save(maps, mapFile);
                    this.listBox1.Items.Clear();
                    foreach (var item in maps) {
                        this.listBox1.Items.Add(item);
                    }
                    myHttpServer.SetUrlMap(maps);
                    //°ó¶¨Host
                    button4_Click(null, null);
                }
            }
        }
        /// <summary>
        /// °ó¶¨Host
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            var hostFile = @"C:\windows\system32\drivers\etc\hosts";
            var list = File.ReadAllLines(hostFile).ToList();

            foreach (var item in maps) {
                Regex regex = new Regex(@$"^{item.NewIp.Split(':')[0].Replace(".", "\\.")}[ \t]+{item.Host.Replace(".", "\\.")}[ \t]*$", RegexOptions.IgnoreCase);
                for (int i = list.Count - 1; i >= 0; i--) {
                    var str = list[i];
                    if (regex.IsMatch(str)) {
                        list.RemoveAt(i);
                    }
                }
            }
            foreach (var item in maps) {
                if (item.Used) {
                    list.Insert(0, $"{item.NewIp.Split(':')[0]} {item.Host}");
                }
            }
            File.WriteAllLines(hostFile, list.ToArray());
        }

        /// <summary>
        /// ½â°óHost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            var hostFile = @"C:\windows\system32\drivers\etc\hosts";
            var list = File.ReadAllLines(hostFile).ToList();

            foreach (var item in maps) {
                Regex regex = new Regex(@$"^{item.NewIp.Split(':')[0].Replace(".", "\\.")}[ \t]+{item.Host.Replace(".", "\\.")}[ \t]*$", RegexOptions.IgnoreCase);
                for (int i = list.Count - 1; i >= 0; i--) {
                    var str = list[i];
                    if (regex.IsMatch(str)) {
                        list.RemoveAt(i);
                    }
                }
            }
            File.WriteAllLines(hostFile, list.ToArray());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var exePath = GetDefaultWebBrowserFilePath();
            System.Diagnostics.Process.Start(exePath, "https://github.com/toolgood/DevTest");
        }
        public static String GetDefaultWebBrowserFilePath()
        {
            string _BrowserKey1 = @"Software\Clients\StartmenuInternet\";
            string _BrowserKey2 = @"shell\open\command";
            string outPath;

            RegistryKey localKey;
            if (Environment.Is64BitOperatingSystem) {
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            } else {
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            }

            RegistryKey _RegistryKey = localKey.OpenSubKey(_BrowserKey1, false);
            var names = _RegistryKey.GetSubKeyNames();
            if (names.Contains("Google Chrome")) {
                var key = _RegistryKey.OpenSubKey("Google Chrome").OpenSubKey(_BrowserKey2);
                outPath = key.GetValue("").ToString();
            } else if (names.Any(q => q.StartsWith("Firefox"))) {
                var name = names.Where(q => q.StartsWith("Firefox")).FirstOrDefault();
                var key = _RegistryKey.OpenSubKey(name).OpenSubKey(_BrowserKey2);
                outPath = key.GetValue("").ToString();
            } else {
                String name = _RegistryKey.GetValue("").ToString();
                var key = _RegistryKey.OpenSubKey(name).OpenSubKey(_BrowserKey2);
                outPath = key.GetValue("").ToString();
            }
            _RegistryKey.Close();

            if (outPath.Contains("\"")) {
                outPath = outPath.TrimStart('"');
                outPath = outPath.Substring(0, outPath.IndexOf('"'));
            }
            return outPath;
        }
    }
}