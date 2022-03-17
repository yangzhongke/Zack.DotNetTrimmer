using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms.Design;

namespace Steema.TeeChart.Samples
{
	public class DirectorySelect : FolderNameEditor 
	{
		private FolderBrowser m_fb = new FolderBrowser();
		private string m_description = "Select Folder";
		private string m_returnPath = string.Empty;

		public DirectorySelect() : base() {}

		public string Description 
		{
			get { return m_description; }
			set { m_description = value; }
		}

		public string ReturnPath 
		{
			get { return m_returnPath; }
		}

		public DialogResult RunDialog() 
		{
			m_fb.Description = m_description;
			m_fb.StartLocation = FolderBrowserFolder.Desktop;
			return m_fb.ShowDialog();
		}

		public DialogResult ShowDialog() 
		{
			DialogResult dr = RunDialog();
			if (dr == DialogResult.OK) 
				m_returnPath = m_fb.DirectoryPath;
			else 
				m_returnPath = string.Empty;
      return dr;
		} 
	}
	
	/// <summary>
	/// Loads and formats *.cs file 
	/// </summary>
	public class SourceControl : Object
	{
		private RichTextBox frtb;
		private int p,len;
		private string txt;
		private bool fFormatText;
			
		public SourceControl(RichTextBox r) 
		{
			this.frtb = r;
      this.frtb.BackColor = Color.White;
			this.fFormatText = true;
		}

		/// <summary>
		/// where to put formatted text ?
		/// </summary>
		public RichTextBox rtb
		{
			get { return frtb;}
			set { frtb = value;}
		}

		public bool FormatText
		{
			get { return fFormatText;}
			set { fFormatText = value;}
		}

		private bool IsKeyWord(string str)
		{
			string[] keywords = new string[] 
					{
							"abstract", "event", "new", "struct", "as", "explicit", "null", "switch",
						"base", "extern", "object", "this", "bool", "false", "operator", "throw", 
						"break", "finally", "out", "true", "byte", "fixed", "override", "try", 
						"case", "float", "params", "typeof", "catch", "for", "private", "uint",
						"char", "foreach", "protected", "ulong", "checked", "goto", "public", "unchecked", 
						"class", "if", "readonly", "unsafe", "const", "implicit", "ref", "ushort",
						"continue", "in", "return", "using", "decimal", "int", "sbyte", "virtual", 
						"default", "interface", "sealed", "volatile", "delegate", "internal", "short", "void",
						"do", "is", "sizeof", "while", "double", "lock", "stackalloc", "else", "long", "static",
						"enum", "namespace", "string"};

			bool res = false;
			foreach(string st in keywords)
			{
				if (st == str)
				{res = true; break;}
			}
			return res;
		}
			
		private void HighLightText(string endstring)
		{
			int sublen = endstring.Length;
			frtb.SelectionStart = p-sublen;
			while ((p<= len-sublen) && (!txt.Substring(p,sublen).Equals(endstring))) p++;
			frtb.SelectionLength = p + sublen - frtb.SelectionStart;
			frtb.SelectionColor = Color.Green;
			frtb.SelectionLength = 0;
			frtb.SelectionStart = 0;
		}
			
		private bool NextWordIsKeyword()
		{
			bool res = false;

			while (p <len)
			{
				if (Char.IsLetterOrDigit(txt[p])) break;
				else if ( (p< len -2) && (txt.Substring(p,2).Equals("//"))) HighLightText("\n");
				else if ( (p< len -2) && (txt.Substring(p,2).Equals("/*"))) HighLightText("*/");
				else p++;
			}

			int p2 = p;
			string Key;
			while ((p < len) && (Char.IsLetterOrDigit(txt[p]))) p++;

			if (p > p2)
			{
				Key = txt.Substring(p2,p-p2);
				res = IsKeyWord(Key);
				frtb.SelectionStart = p2;
				frtb.SelectionLength = p-p2;
				p++;
			}
			else res = false;
			return res;
		}

		private void FormatSourceText()
		{
			if (frtb != null)
			{
				txt = frtb.Text;
				len = frtb.Text.Length;
				p = 0;
				while (p < len)
					if (NextWordIsKeyword()) frtb.SelectionColor = Color.Blue;
				frtb.SelectionStart = 0;
				frtb.SelectionLength = 0;
			}
		}

		/// <summary>
		/// Load and format filemane.cs file
		/// </summary>
		/// <param name="filename"></param>
		public void LoadTextFromFile(string filename)
		{
			FileInfo fi = new FileInfo(filename);
			if ((fi.Exists) && (frtb != null))
			{
				frtb.Visible = false;
				frtb.SuspendLayout();
				try
				{
					frtb.Clear();
					frtb.LoadFile(filename,RichTextBoxStreamType.PlainText);
					if (fFormatText) FormatSourceText();
				}
				finally
				{
					frtb.Visible = true;
					frtb.ResumeLayout(true);
				}
			}
		}
	}
	
	public class Utils
	{
		private Utils() {}

    //public static string TeeChartRoot = @"HKEY_LOCAL_MACHINE";
    //public static string TeeChartSubKey = @"Software\Steema Software\TeeChart.NET";
    //public static string TeeChartKeyName = TeeChartRoot + "\\" + TeeChartSubKey;

    public static string DemoPath()
    {
      return (string)Steema.TeeChart.UtilsWF.Registry_GetValue(Steema.TeeChart.Utils.TeeChartKeyName, "DemoPath", @"..\..\");
			
    }

		/// <summary>
		/// Restores source code directory from registry
		/// </summary>
		/// <returns></returns>
		public static string CodePath()
		{
#if DESIGN
#if VS2005
		const string ProjectName="TeeChart Examples2005.csproj";
#else
		const string ProjectName="TeeChart Examples2003.csproj";
#endif
#else
		const string ProjectName="TeeChart Examples.csproj";
#endif
    string result = DemoPath();

      FileInfo fi = new FileInfo(result+ProjectName);
      if (!fi.Exists)
      {
        fi=new FileInfo(result+@"..\"+ProjectName);
        if (fi.Exists)
          result=result+@"..\";
        else
        {
          fi=new FileInfo(result+@"..\..\"+ProjectName);
          if (fi.Exists)
            result=result+@"..\..\";
        }
      }

      return result;
		}

		/// <summary>
		/// Stores source code directory to registry
		/// </summary>
		/// <param name="path"></param>
		public static void WriteCodePath(string path)
		{
      Steema.TeeChart.UtilsWF.Registry_SetValue(Steema.TeeChart.Utils.TeeChartKeyName, "DemoPath", path);
		}
	}
}
