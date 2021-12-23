using Microsoft.Win32;
using System.Text;
using Vanara.PInvoke;

namespace YZKGameWizard
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Link_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            string url = (string)label.Tag;
            Shell32.ShellExecute(this.Handle, "open", url, null, null, ShowWindowCommand.SW_NORMAL);
        }

        private void btnBrowseProjectDir_Click(object sender, EventArgs e)
        {
            if(dirDlgProjectPath.ShowDialog(this) == DialogResult.OK)
            {
                txtProjectDir.Text = dirDlgProjectPath.SelectedPath;
            }
        }

        void WriteToFile(string content, FileInfo fName)
        {
            if (!fName.Directory.Exists)
            {
                fName.Directory.Create();
            }
            string lowerContent = content.ToLower();
            bool isUtf8 = lowerContent.Contains("encoding=\"utf-8\"") || lowerContent.Contains("encoding=\"utf8\"");//不同版本VS
            Encoding encoding;
            if(isUtf8)
            {
                encoding = Encoding.UTF8;
            }
            else
            {
                encoding=Encoding.Default;//VS2008等的文件都是ansi格式，不支持utf8
            }
            using var fileStream = fName.OpenWrite();
            using var streamWriter = new StreamWriter(fileStream, encoding);
            streamWriter.Write(content);
        }

		void CopyDir(string dirSrc,string dirDest)
        {
			CopyDir(new DirectoryInfo(dirSrc), new DirectoryInfo(dirDest));
        }

        void CopyDir(DirectoryInfo dirSrc, DirectoryInfo dirDest)
        {
            foreach (var dir in dirSrc.GetDirectories("*",SearchOption.AllDirectories))
            {
                var newDir = new DirectoryInfo(Path.Combine(dirDest.FullName,dir.FullName.Substring(dirSrc.FullName.Length+1)));
                if(!newDir.Exists)
                    newDir.Create();//> C:\sources (and not C:\E:\sources)   
            }

            foreach (var srcFile in dirSrc.GetFiles("*", SearchOption.AllDirectories))
            {
                FileInfo destFile = new FileInfo(Path.Combine(dirDest.FullName,
                    srcFile.FullName.Substring(dirSrc.FullName.Length + 1)));
				destFile.Directory.Create();
				srcFile.CopyTo(destFile.FullName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
			string projectDir = txtProjectDir.Text;
			string projectName = txtProjectName.Text;

			if (string.IsNullOrWhiteSpace(projectName))
			{
				MessageBox.Show(this,"请填写项目名称");
				txtProjectName.Focus();
				return;
			}

			var forbiddenChars = Path.GetInvalidFileNameChars().Union(Path.GetInvalidPathChars());
			foreach (char forbiddenChar in forbiddenChars)
			{
				if (projectName.Contains(forbiddenChar))
				{
					MessageBox.Show(this,"项目名称中不能包含/ ? : & \\ * \" < > | #等特殊符号");
					txtProjectName.Focus();
					return;
				}
			}

			if (string.IsNullOrWhiteSpace(projectDir))
			{
				MessageBox.Show(this,"请选择项目路径");
				txtProjectDir.Focus();
				return;
			}

			DirectoryInfo dir = new DirectoryInfo(Path.Combine(projectDir, projectName));
			if (dir.Exists)
			{
				MessageBox.Show(this,projectName + "项目已经存在，请修改项目名");
				return;
			}

			string exeDir = Application.StartupPath;
			string templateDir = exeDir + "/项目模板/";

			FileInfo slnFileNameSrc;//解决方案模板源文件
			FileInfo projFileNameSrc;//项目文件模板源文件

			FileInfo slnFileNameDest;//解决方案模板目标文件
			FileInfo projFileNameDest;//项目文件模板目标文件

			string ideVer = (string)cmbIDEVersion.SelectedItem;
			switch (ideVer)
			{
				case "VC6":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "vc6.dsw"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "vc6.dsp"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir, projectName, projectName + ".dsp"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir, projectName, projectName + ".dsw"));
					break;
				case "VS2008":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2008.sln"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2008.vcproj"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir,projectName,projectName + ".vcproj"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir,projectName ,projectName + ".sln"));
					break;
				case "VS2010":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2010.sln"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2010.vcxproj"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir,projectName,projectName + ".vcxproj"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir,projectName,projectName + ".sln"));
					break;
				case "VS2012":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2012.sln"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2012.vcxproj"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir,projectName,projectName + ".vcxproj"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir, projectName,projectName + ".sln"));
					break;
				case "VS2013":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2013.sln"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2013.vcxproj"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir, projectName,projectName + ".vcxproj"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir, projectName,projectName + ".sln"));
					break;
				case "VS2015":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2015.sln"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2015.vcxproj"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir, projectName,projectName + ".vcxproj"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir,projectName ,projectName + ".sln"));
					break;
				case "VS2017":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2017.sln"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2017.vcxproj"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir,projectName,projectName + ".vcxproj"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir, projectName,projectName + ".sln"));
					break;
				case "VS2019":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2019.sln"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2019.vcxproj"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir, projectName, projectName + ".vcxproj"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir, projectName, projectName + ".sln"));
					break;
				case "VS2022":
					slnFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2022.sln"));
					projFileNameSrc = new FileInfo(Path.Combine(templateDir, "VS2022.vcxproj"));
					projFileNameDest = new FileInfo(Path.Combine(projectDir, projectName, projectName + ".vcxproj"));
					slnFileNameDest = new FileInfo(Path.Combine(projectDir, projectName, projectName + ".sln"));
					break;
				default:
					MessageBox.Show(this,"错误的VS版本");
					return;
			}

			string slnContent=File.ReadAllText(slnFileNameSrc.FullName);
			//拷贝sln文件
			slnContent = slnContent.Replace("${ProjectName}", projectName);
			WriteToFile(slnContent, slnFileNameDest);

			string projContent=File.ReadAllText(projFileNameSrc.FullName);
			//拷贝vcproj文件
			projContent= projContent.Replace("${ProjectName}", projectName);
			//VS2015在win7下没问题，因为在win7的vs2015下也是内置win8.1 sdk的。所以写<WindowsTargetPlatformVersion>8.1</WindowsTargetPlatformVersion>没问题
			//vs2017中的vcxproj由于必须指定使用的Windows SDK的小版本号（SB微软），所以必须去注册表查询当前机器中安装的winsdk的具体版本
			if (ideVer== "VS2017")
			{
				//注意在64位系统下，这个注册表项在HKLM\SOFTWARE\\Microsoft\\Windows Kits\\Installed Roots
				//不过当前程序是32位程序，因此访问HKLM\SOFTWARE\\Microsoft\\Windows Kits\\Installed Roots的时候windows会用“注册表重定向”机制重定向到HKLM\SOFTWARE\WOW6432Node\Microsoft\\Windows Kits\\Installed Roots
				//所以我们的程序不需要处理32位、64位系统的问题
				var regWinSDK = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows Kits\\Installed Roots");
				if (regWinSDK !=null&& regWinSDK.SubKeyCount>0)
				{
					//Installed Roots下是若干个sdk的版本号，我们取第一个即可
					var firstName = regWinSDK.GetValueNames().First();
					string? sdkVer = (string?)regWinSDK.GetValue(firstName);
					if (sdkVer != null)
					{
						projContent.Replace("${WindowsTargetPlatformVersion}", sdkVer);
					}
				}
			}
			WriteToFile(projContent, projFileNameDest);

			//拷贝main.c
			File.Copy(Path.Combine(templateDir,"main.c"), Path.Combine(projectDir, projectName,"main.c"));
			CopyDir(templateDir + "/depends", projectDir + "/" + projectName + "/depends");
			CopyDir(templateDir + "/dlls", projectDir + "/" + projectName + "/dlls");

			//创建/Images等目录
			Directory.CreateDirectory(Path.Combine(projectDir,projectName, "Images"));
			Directory.CreateDirectory(Path.Combine(projectDir, projectName, "Sounds"));
			Directory.CreateDirectory(Path.Combine(projectDir, projectName, "Sprites"));

			Shell32.ShellExecute(this.Handle,"open",Path.Combine(projectDir,projectName),null,null,ShowWindowCommand.SW_NORMAL);//在资源管理器中打开
			MessageBox.Show(this,"生成成功");
			Settings.Default.LastIDEVersion = (string)cmbIDEVersion.SelectedItem;
			Settings.Default.Save();
		}

        private void FormMain_Load(object sender, EventArgs e)
        {
			string lastIDEVer = Settings.Default.LastIDEVersion;
			if(!string.IsNullOrWhiteSpace(lastIDEVer))
            {
				cmbIDEVersion.SelectedItem = lastIDEVer;
			}
		}
    }
}