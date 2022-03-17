using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Commander_Editor : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.ChartController commander1;
		private Steema.TeeChart.Editor editor1;
		private System.ComponentModel.IContainer components = null;

		public Commander_Editor()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

				// This can be done at design-time.
			// This code is how to do it programatically

			editor1.Chart = tChart1;
			commander1.Chart = tChart1;
			commander1.Editor = editor1;

			editor1.HighLightTabs = true;
			editor1.HideTabs = new Steema.TeeChart.Editors.ChartEditorTabs[] {
				Steema.TeeChart.Editors.ChartEditorTabs.Axes,
				Steema.TeeChart.Editors.ChartEditorTabs.Export,
				Steema.TeeChart.Editors.ChartEditorTabs.Legend,
				Steema.TeeChart.Editors.ChartEditorTabs.Main,
				Steema.TeeChart.Editors.ChartEditorTabs.Page,
				Steema.TeeChart.Editors.ChartEditorTabs.Panel,
				Steema.TeeChart.Editors.ChartEditorTabs.Print,
				Steema.TeeChart.Editors.ChartEditorTabs.SeriesDataSource,
				Steema.TeeChart.Editors.ChartEditorTabs.Tools,
				Steema.TeeChart.Editors.ChartEditorTabs.Walls
			};
			editor1.Options = new Steema.TeeChart.Editors.ChartEditorOptions[] {
				Steema.TeeChart.Editors.ChartEditorOptions.Add
			};
			editor1.DefaultTab = Steema.TeeChart.Editors.ChartEditorTabs.Aspect;
			editor1.Title = "Insert your Custom Title here";
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
			this.components = new System.ComponentModel.Container();
			this.commander1 = new Steema.TeeChart.ChartController();
			this.editor1 = new Steema.TeeChart.Editor(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "ChartController has a new property to customize which chart editor to use.\r\n\r\nClick " +
				"on the Edit icon to show a custom dialog.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.commander1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			//
			//
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// commander1
			// 
			this.commander1.Location = new System.Drawing.Point(0, 0);
			this.commander1.Name = "commander1";
			this.commander1.Size = new System.Drawing.Size(440, 37);
			this.commander1.TabIndex = 0;
			// 
			// editor1
			// 
			this.editor1.HighLightTabs = false;
			this.editor1.Location = new System.Drawing.Point(17, 17);
			this.editor1.Name = "editor1";
			this.editor1.Options = null;
			this.editor1.TabIndex = 0;
			// 
			// TCommanderCustomEditor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "TCommanderCustomEditor";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}

