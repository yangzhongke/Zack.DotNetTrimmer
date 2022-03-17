using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Surface_XYZFloat : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Surface surfaceSeries1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Surface_XYZFloat()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.surfaceSeries1.IrregularGrid = true; // <-- IMPORTANT ! means X and Z are float
			for (int x=1; x<=10;x++)
				for (int z=1; z<=10; z++)
					this.surfaceSeries1.Add(x/10.0,Math.Sqrt(x*z),z/5.0);

			// set palette colors to "10, strong" ...
			this.surfaceSeries1.UseColorRange = false;
			this.surfaceSeries1.UsePalette = true;
			this.surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong;
			this.surfaceSeries1.PaletteSteps = 10;
			// adjust some axes properties...
			this.tChart1.Axes.Depth.Visible = true;
			this.tChart1.Axes.Depth.Labels.ValueFormat = "0.#";
			this.tChart1.Axes.Depth.Increment = 0.2;
			this.tChart1.Axes.Bottom.Labels.ValueFormat = "0.#";
			this.tChart1.Axes.Bottom.Increment = 0.1;

			// visual properties...
			this.tChart1.Aspect.Chart3DPercent = 100;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 50;
			this.tChart1.Aspect.Rotation = 327;
			this.tChart1.Aspect.Elevation = 352;
			this.tChart1.Aspect.Zoom = 70;
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
			this.surfaceSeries1 = new Steema.TeeChart.Styles.Surface();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Another example of using Surface series with XYZ floating point numbers (double)." +
				"";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 34);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Surface Series : float x,z and y(x,z)"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 97);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.surfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			this.tChart1.Tools.Add(this.gridBand1);
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
			// surfaceSeries1
			// 
			// 
			// surfaceSeries1.Brush
			// 
			this.surfaceSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// surfaceSeries1.Marks
			// 
			// 
			// surfaceSeries1.Marks.Symbol
			// 
			// 
			// surfaceSeries1.Marks.Symbol.Shadow
			// 
			this.surfaceSeries1.Marks.Symbol.Shadow.Height = 1;
			this.surfaceSeries1.Marks.Symbol.Shadow.Visible = true;
			this.surfaceSeries1.Marks.Symbol.Shadow.Width = 1;
			this.surfaceSeries1.NumXValues = 25;
			this.surfaceSeries1.NumZValues = 25;
			this.surfaceSeries1.PaletteMin = 0;
			this.surfaceSeries1.PaletteStep = 0;
			this.surfaceSeries1.Title = "surfaceSeries1";
			this.surfaceSeries1.UseColorRange = false;
			this.surfaceSeries1.UsePalette = true;
			// 
			// surfaceSeries1.XValues
			// 
			this.surfaceSeries1.XValues.DataMember = "X";
			// 
			// surfaceSeries1.YValues
			// 
			this.surfaceSeries1.YValues.DataMember = "Y";
			// 
			// surfaceSeries1.ZValues
			// 
			this.surfaceSeries1.ZValues.DataMember = "Z";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// Surface_XYZFloat
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Surface_XYZFloat";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

