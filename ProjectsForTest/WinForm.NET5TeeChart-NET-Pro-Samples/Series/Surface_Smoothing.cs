using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class SurfaceSmoothing : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Surface surface1;
		private Steema.TeeChart.Tools.Rotate rotate1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SurfaceSmoothing()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			surface1.FillSampleValues(5);
			surface1.Pen.Visible = false;
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.surface1 = new Steema.TeeChart.Styles.Surface();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Surfaces (and any other \"grid 3D\" series like Tower, Contour, etc)\r\nthat have a s" +
				"mall number of cells can be smoothed using a simple linear algorithm\r\nthat inser" +
				"ts new cells in between existing cells by interpolating values.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 40;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 100;
			
			
			this.tChart1.Aspect.Zoom = 79;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.surface1);
			this.tChart1.Tools.Add(this.rotate1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.Size = 5;
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
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.Size = 5;
			this.tChart1.Walls.Right.Transparent = true;
			this.tChart1.Walls.Right.Visible = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Smooth Surface x 2";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(160, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Grid Size = 5 x 5";
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(332, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "More Speed";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// surface1
			// 
			// 
			// surface1.Brush
			// 
			this.surface1.Brush.Color = System.Drawing.Color.Red;
			// 
			// surface1.Marks
			// 
			// 
			// surface1.Marks.Symbol
			// 
			// 
			// surface1.Marks.Symbol.Shadow
			// 
			this.surface1.Marks.Symbol.Shadow.Height = 1;
			this.surface1.Marks.Symbol.Shadow.Visible = true;
			this.surface1.Marks.Symbol.Shadow.Width = 1;
			this.surface1.PaletteMin = 0;
			this.surface1.PaletteStep = 0;
			this.surface1.Title = "surface1";
			// 
			// surface1.XValues
			// 
			this.surface1.XValues.DataMember = "X";
			// 
			// surface1.YValues
			// 
			this.surface1.YValues.DataMember = "Y";
			// 
			// surface1.ZValues
			// 
			this.surface1.ZValues.DataMember = "Z";
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
			// SurfaceSmoothing
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "SurfaceSmoothing";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			 // Smooth the surface !	TeeSmoothGrid3D	class source in TeeSmoothGrid3D.cs
			TeeSmoothGrid3D.SmoothGrid3D(surface1);

		  // Now re-calculate NumX and NumX to display at label1.Text
			surface1.FillGridIndex();

		  // Display new grid size at label1
			label1.Text = "Grid Size: " + surface1.NumXValues.ToString() + " x " + surface1.NumZValues.ToString();
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			// For more speed, lets disable items:
			tChart1.Axes.Visible = !checkBox1.Checked;
			tChart1.Legend.Visible = !checkBox1.Checked;
			tChart1.Header.Visible = !checkBox1.Checked;

			if(checkBox1.Checked) 
				tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			else 
				tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
			
			tChart1.Aspect.ClipPoints = !checkBox1.Checked;
			tChart1.Walls.Visible = !checkBox1.Checked;
			
			// Speed trick, as we know Surface data will not be modified anymore:
			surface1.ReuseGridIndex = checkBox1.Checked;

			 //"Palette" color mode is faster than "Range" 
			surface1.UsePalette = checkBox1.Checked;
			surface1.UseColorRange = !checkBox1.Checked;

			tChart1.Refresh();
		}
	}
}

