using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ChartThemes : Steema.TeeChart.Samples.BaseNoChart
	{
		private System.Windows.Forms.Label label1;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.Styles.Bar bar1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox lbThemes;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private Steema.TeeChart.Editors.ThemeEditor themeEditor;

		public ChartThemes()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lbThemes = new System.Windows.Forms.ListBox();
			this.tChart1 = new Steema.TeeChart.TChart();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "TeeChart Themes enable rapid change of many chart properties with a single mouse " +
				"click. \r\n\r\nSeveral themes are provided through the Themes Editor and programatic" +
				"ally. \r\nCreating new themes by code is really simple.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Name = "panel1";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.tChart1);
			this.panel2.Controls.Add(this.lbThemes);
			this.panel2.Dock = System.Windows.Forms.DockStyle.None;
			this.panel2.Name = "panel2";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select Theme:";
			// 
			// lbThemes
			// 
			this.lbThemes.Location = new System.Drawing.Point(0, 0);
			this.lbThemes.Name = "lbThemes";
			this.lbThemes.Size = new System.Drawing.Size(88, 160);
			this.lbThemes.TabIndex = 0;
			this.lbThemes.SelectedIndexChanged += new System.EventHandler(this.lbThemes_SelectedIndexChanged);
			// 
			// tChart1
			// 
			this.tChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.Visible = true;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.Visible = true;
			this.tChart1.Location = new System.Drawing.Point(88, 0);
			this.tChart1.Name = "tChart1";
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Size = new System.Drawing.Size(344, 160);
			this.tChart1.TabIndex = 1;
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.Red;
			this.bar1.ColorEach = true;
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(120, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Theme Editor...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(256, 11);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Apply by code";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ChartThemes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(426, 258);
			this.Name = "ChartThemes";
			this.Text = "Chart Themes";
			this.Load += new System.EventHandler(this.ChartThemes_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ChartThemes_Load(object sender, System.EventArgs e)
		{
			bar1.FillSampleValues();
			bar1.ColorEach=true;

			// Add all available themes to ListBox1.
			themeEditor = new Steema.TeeChart.Editors.ThemeEditor(tChart1, null);

      object[] objectCollection;
      //object[] objectCollection = new object[lbThemes.Items.Count];
      //lbThemes.Items.CopyTo(objectCollection,0);
			themeEditor.AddChartThemes(out objectCollection);
			lbThemes.Items.Clear();
			lbThemes.Items.Add(Texts.Current);
			lbThemes.Items.AddRange(objectCollection);
      lbThemes.SelectedIndex=0;

		}

		private void lbThemes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lbThemes.SelectedIndex!=0) 
			{
				(lbThemes.SelectedItem as Themes.Theme).Apply();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			
			themeEditor.ShowDialog();
			lbThemes.SelectedIndex=0;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Themes.XPTheme xpTheme = new Steema.TeeChart.Themes.XPTheme(tChart1.Chart);
			xpTheme.Apply();

		}
	}
}

