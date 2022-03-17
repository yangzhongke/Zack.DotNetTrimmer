using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_TriSurface : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.TriSurface triSurfaceSeries1;
		private Steema.TeeChart.Tools.Rotate rotate1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_TriSurface()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.triSurfaceSeries1.FillSampleValues(25);
			this.triSurfaceSeries1.Pen.Width = 2;
			this.triSurfaceSeries1.Pen.Color = Color.GreenYellow;
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
			this.triSurfaceSeries1 = new Steema.TeeChart.Styles.TriSurface();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.button1 = new System.Windows.Forms.Button();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "A TriSurface series draws triangles using all XYZ points.\r\n\r\nIncludes a pen to dr" +
				"aw a line around the point boundaries. Inherits all properties and methods from " +
				"Grid3D series (palette, AddXYZ, etc).";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 70;
			this.tChart1.Aspect.Elevation = 334;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 36;
			
			
			this.tChart1.Aspect.Zoom = 66;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Depth
			// 
			this.tChart1.Axes.Depth.Visible = true;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.triSurfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			this.tChart1.Tools.Add(this.rotate1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// triSurfaceSeries1
			// 
			// 
			// triSurfaceSeries1.Brush
			// 
			this.triSurfaceSeries1.Brush.Color = System.Drawing.Color.Red;
			this.triSurfaceSeries1.EndColor = System.Drawing.Color.LightSkyBlue;
			this.triSurfaceSeries1.HideTriangles = false;
			// 
			// triSurfaceSeries1.Marks
			// 
			// 
			// triSurfaceSeries1.Marks.Symbol
			// 
			// 
			// triSurfaceSeries1.Marks.Symbol.Shadow
			// 
			this.triSurfaceSeries1.Marks.Symbol.Shadow.Height = 1;
			this.triSurfaceSeries1.Marks.Symbol.Shadow.Visible = true;
			this.triSurfaceSeries1.Marks.Symbol.Shadow.Width = 1;
			this.triSurfaceSeries1.PaletteMin = 0;
			this.triSurfaceSeries1.PaletteStep = 0;
			this.triSurfaceSeries1.StartColor = System.Drawing.Color.Green;
			this.triSurfaceSeries1.Title = "triSurfaceSeries1";
			// 
			// triSurfaceSeries1.XValues
			// 
			this.triSurfaceSeries1.XValues.DataMember = "X";
			// 
			// triSurfaceSeries1.YValues
			// 
			this.triSurfaceSeries1.YValues.DataMember = "Y";
			// 
			// triSurfaceSeries1.ZValues
			// 
			this.triSurfaceSeries1.ZValues.DataMember = "Z";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_TriSurface
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_TriSurface";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.triSurfaceSeries1);
		}
	}
}

