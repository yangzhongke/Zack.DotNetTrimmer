using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Steema.TeeChart.Samples
{
	public class Theme_Custom : Steema.TeeChart.Samples.BaseForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox cbBase64;
		private System.Windows.Forms.Button bApply;
		private Steema.TeeChart.TChart tChart2;

		public Theme_Custom()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

		
			tChart2 = new Steema.TeeChart.TChart();
			tChart2.Dock = DockStyle.Right;
			tChart2.Width = 400;
			chartContainer.Controls.Add(tChart2);

			CreateStyle();

			tChart1.Series.Add(new Steema.TeeChart.Styles.Points());
			tChart1[0].FillSampleValues();


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

		private void CreateStyle() 
		{
			for(int i = 0; i < tChart1.Axes.Count; ++i) 
			{
				Axis a = tChart1.Axes[i];
				a.Labels.Font.Name = "Verdana";
				a.Labels.Font.Size = 7;
			}
		
			tChart1.Aspect.View3D = false;
			tChart1.Header.Font.Name = "Verdana";
			tChart1.Header.Font.Size = 9;
			tChart1.Legend.Font.Name = "Verdana";
			tChart1.Legend.Font.Size = 7;

			tChart1.Panel.Gradient.Visible = true;
			tChart1.Panel.Gradient.StartColor = Color.AliceBlue;
			tChart1.Panel.Gradient.MiddleColor = Color.SeaShell;
			tChart1.Panel.Gradient.EndColor = Color.Khaki;

			tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Raised;
			tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
		}


		private string themeDirectory;

		private void SaveCustomTheme() 
		{
			themeDirectory = Steema.TeeChart.UtilsWF.ThemeFolder();
      if (!Directory.Exists(themeDirectory))
      {
        themeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      }
			tChart1.Export.Theme.SaveWithBase64 = this.cbBase64.Checked;
			if (!Directory.Exists(themeDirectory))
			{
				Directory.CreateDirectory(themeDirectory);
			}
			tChart1.Export.Theme.Save(themeDirectory + "\\My Theme.xml");
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbBase64 = new System.Windows.Forms.CheckBox();
			this.bApply = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = @"Custom Themes can now be easily created and visualised within the Chart Editor.
As Custom Themes are XML files they can be edited completely independently of
TeeChart.
In the example below, apply a theme to the chart on the left with or without 
'template' information, which in this case includes the series and its properties.
Double click on this textbox to view the chart editor and navigate to the Themes
tab to view the newly created custom theme, 'My Theme'!";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bApply);
			this.panel1.Controls.Add(this.cbBase64);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.ElevationFloat = 345;
			this.tChart1.Aspect.RotationFloat = 345;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			this.tChart1.Axes.Bottom.Automatic = true;
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth
			// 
			this.tChart1.Axes.Depth.Automatic = true;
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop
			// 
			this.tChart1.Axes.DepthTop.Automatic = true;
			// 
			// tChart1.Axes.DepthTop.Labels
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.Automatic = true;
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right
			// 
			this.tChart1.Axes.Right.Automatic = true;
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			this.tChart1.Axes.Top.Automatic = true;
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
			// 
			// tChart1.Footer
			// 
			// 
			// tChart1.Footer.Shadow
			// 
			this.tChart1.Footer.Shadow.Visible = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// tChart1.Header.Shadow
			// 
			this.tChart1.Header.Shadow.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Visible = false;
			// 
			// tChart1.SubFooter
			// 
			// 
			// tChart1.SubFooter.Shadow
			// 
			this.tChart1.SubFooter.Shadow.Visible = false;
			// 
			// tChart1.SubHeader
			// 
			// 
			// tChart1.SubHeader.Shadow
			// 
			this.tChart1.SubHeader.Shadow.Visible = false;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.AutoHide = false;
			// 
			// tChart1.Walls.Back.Shadow
			// 
			this.tChart1.Walls.Back.Shadow.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.AutoHide = false;
			// 
			// tChart1.Walls.Bottom.Shadow
			// 
			this.tChart1.Walls.Bottom.Shadow.Visible = false;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.AutoHide = false;
			// 
			// tChart1.Walls.Left.Shadow
			// 
			this.tChart1.Walls.Left.Shadow.Visible = false;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.AutoHide = false;
			// 
			// tChart1.Walls.Right.Shadow
			// 
			this.tChart1.Walls.Right.Shadow.Visible = false;
			// 
			// chartContainer
			// 
			this.chartContainer.Name = "chartContainer";
			// 
			// cbBase64
			// 
			this.cbBase64.Checked = true;
			this.cbBase64.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbBase64.Location = new System.Drawing.Point(16, 8);
			this.cbBase64.Name = "cbBase64";
			this.cbBase64.Size = new System.Drawing.Size(144, 24);
			this.cbBase64.TabIndex = 0;
			this.cbBase64.Text = "Save with Template";
			// 
			// bApply
			// 
			this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bApply.Location = new System.Drawing.Point(176, 8);
			this.bApply.Name = "bApply";
			this.bApply.Size = new System.Drawing.Size(88, 23);
			this.bApply.TabIndex = 1;
			this.bApply.Text = "Apply Theme";
			this.bApply.Click += new System.EventHandler(this.bApply_Click);
			// 
			// Theme_Custom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Theme_Custom";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void bApply_Click(object sender, System.EventArgs e)
		{
			SaveCustomTheme();
			tChart2.Clear();
			tChart2.Import.Theme.Load(themeDirectory + "\\My Theme.xml");

		}


	}
}

