using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Contour : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private Steema.TeeChart.Styles.Contour contourSeries1;
		private Steema.TeeChart.Styles.Surface surfaceSeries1;
    private Steema.TeeChart.Tools.Rotate rotate1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Contour()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			/* 
			 * add points (21x21 = 441 points i.e 20x20 "cells" to contour series
			 * in this case x,z are integers, so setting 
			 * IrregularGrid to false makes sense
			*/
			contourSeries1.IrregularGrid = false;
			for (int x=-10;x<10;x++)
			{
				for (int z=-10;z<10;z++)
				{
					contourSeries1.Add(x,fun(x,z),z);
				}
			}

			/* 
			 * surfaceSeries1 displays the same data, 
			 * so let's connect it to contour series
			*/
			surfaceSeries1.DataSource = contourSeries1;

			// Then we specify how many "contour levels" we want 
			contourSeries1.NumLevels = 10;
			// initially, YPosition in the middle
			contourSeries1.YPosition = 0.5*(contourSeries1.YValues.Maximum + contourSeries1.YValues.Minimum);
			vScrollBar1.Value = 1000 - (int)contourSeries1.YPosition;
		}

		// auxilary functions for populating series
		private double ToAngle(double val)
		{
			return (val+10.0)*Math.PI*0.1;
		}
		private double fun(int x, int z)
		{
			return 500*(Math.Sin(ToAngle(x))+Math.Pow(Math.Cos(z),2.0));
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.contourSeries1 = new Steema.TeeChart.Styles.Contour();
			this.surfaceSeries1 = new Steema.TeeChart.Styles.Surface();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(509, 62);
			this.textBox1.Text = "The Contour Series displays lines corresponding to \"Level\" values on 3D XYZ data." +
				"\r\nThe number of levels, the Level intervals, the Levels positions, colors and Le" +
				"gend can be fully customized.  It can also be viewed in 2D, or rotated in 3D mod" +
				"e.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox5);
			this.panel1.Controls.Add(this.checkBox4);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(509, 34);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 75;
			this.tChart1.Aspect.Elevation = 334;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 57;
			this.tChart1.Aspect.Rotation = 299;
			
			
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
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Left;
			this.tChart1.Legend.FontSeriesColor = true;
			this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Values;
			this.tChart1.Legend.ResizeChart = false;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.contourSeries1);
			this.tChart1.Series.Add(this.surfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(509, 224);
			this.tChart1.Tools.Add(this.rotate1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			this.tChart1.Walls.Back.Size = 7;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 8;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 7;
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(43, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&2D";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(67, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(101, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Show &Walls";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(153, 7);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(114, 21);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Color &Each Level";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(273, 7);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(95, 21);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Levels at &Y";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkBox5
			// 
			this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox5.Location = new System.Drawing.Point(360, 7);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(60, 21);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "&Surface";
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar1.Location = new System.Drawing.Point(509, 0);
			this.vScrollBar1.Maximum = 1000;
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 320);
			this.vScrollBar1.TabIndex = 4;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// contourSeries1
			// 
			// 
			// contourSeries1.Brush
			// 
			this.contourSeries1.ColorEach = true;
            this.contourSeries1.Brush.Visible = false;
			// 
			// contourSeries1.Marks
			// 
			// 
			// contourSeries1.Marks.Symbol
			// 
			// 
			// contourSeries1.Marks.Symbol.Shadow
			// 
			this.contourSeries1.Marks.Symbol.Shadow.Height = 1;
			this.contourSeries1.Marks.Symbol.Shadow.Visible = true;
			this.contourSeries1.Marks.Symbol.Shadow.Width = 1;
			this.contourSeries1.PaletteMin = 0;
			this.contourSeries1.PaletteStep = 0;
			this.contourSeries1.Title = "contour1";
			// 
			// contourSeries1.XValues
			// 
			this.contourSeries1.XValues.DataMember = "X";
			this.contourSeries1.YPosition = 0.18959828428699516;
			// 
			// contourSeries1.YValues
			// 
			this.contourSeries1.YValues.DataMember = "Y";
			// 
			// contourSeries1.ZValues
			// 
			this.contourSeries1.ZValues.DataMember = "Z";
			// 
			// surfaceSeries1
			// 
			// 
			// surfaceSeries1.Brush
			// 
			this.surfaceSeries1.Brush.Color = System.Drawing.Color.Green;
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
			this.surfaceSeries1.PaletteMin = 0;
			this.surfaceSeries1.PaletteStep = 0;
			this.surfaceSeries1.Marks.AutoPosition = false;
			this.surfaceSeries1.Title = "surface2";
			this.surfaceSeries1.Visible = false;
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
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.Black;
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.Black;
			// 
			// SeriesType_Contour
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(526, 320);
			this.chartContainer.Controls.Add(this.vScrollBar1);
			this.Name = "SeriesType_Contour";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = !checkBox1.Checked;
			checkBox5.Enabled = tChart1.Aspect.View3D;
			this.surfaceSeries1.Active = tChart1.Aspect.View3D;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Walls.Visible = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			contourSeries1.ColorEach = checkBox3.Checked;
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			contourSeries1.YPositionLevel = checkBox4.Checked;
		}

		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			surfaceSeries1.Active = checkBox5.Checked;
		}

		private void vScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			contourSeries1.YPositionLevel  = false;
			contourSeries1.YPosition = vScrollBar1.Value;
		}
	}
}

