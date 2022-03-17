using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Polar : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Timer timer1;
		private Steema.TeeChart.Styles.Polar polarSeries1;
		private Steema.TeeChart.Styles.Polar polarSeries2;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Polar()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			polarSeries1.FillSampleValues(15);
			polarSeries2.FillSampleValues(20);
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.polarSeries1 = new Steema.TeeChart.Styles.Polar();
			this.polarSeries2 = new Steema.TeeChart.Styles.Polar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 40);
			this.textBox1.Text = "Polar Series";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			this.tChart1.Axes.Bottom.Automatic = false;
			this.tChart1.Axes.Bottom.AutomaticMaximum = false;
			this.tChart1.Axes.Bottom.AutomaticMinimum = false;
			this.tChart1.Axes.Bottom.Increment = 30;
			this.tChart1.Axes.Bottom.Maximum = 992;
			this.tChart1.Axes.Bottom.Minimum = 3;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Alignment = Drawing.StringAlignment.Near;
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			this.tChart1.Header.Font.Italic = true;
			this.tChart1.Header.Font.Size = 10;
			this.tChart1.Header.Lines = new string[] {
																								 "Wind direction and speed"};
			this.tChart1.Location = new System.Drawing.Point(0, 73);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.polarSeries1);
			this.tChart1.Series.Add(this.polarSeries2);
			this.tChart1.Size = new System.Drawing.Size(466, 213);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(60, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Circled";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(80, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(87, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Transparent";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(200, 8);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(96, 21);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "&Animate";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// polarSeries1
			// 
			// 
			// polarSeries1.Brush
			// 
			this.polarSeries1.Brush.Color = System.Drawing.Color.Red;
			this.polarSeries1.Circled = true;
			this.polarSeries1.CircleLabels = true;
			this.polarSeries1.CircleLabelsInside = true;
			this.polarSeries1.ClockWiseLabels = true;
			this.polarSeries1.ColorEach = true;
			// 
			// polarSeries1.Marks
			// 
			// 
			// polarSeries1.Marks.Symbol
			// 
			// 
			// polarSeries1.Marks.Symbol.Shadow
			// 
			this.polarSeries1.Marks.Symbol.Shadow.Height = 1;
			this.polarSeries1.Marks.Symbol.Shadow.Visible = true;
			this.polarSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// polarSeries1.Pen
			// 
			this.polarSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// polarSeries1.Pointer
			// 
			this.polarSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polarSeries1.Title = "polar2";
			// 
			// polarSeries1.XValues
			// 
			this.polarSeries1.XValues.DataMember = "Angle";
			this.polarSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// polarSeries1.YValues
			// 
			this.polarSeries1.YValues.DataMember = "Y";
			// 
			// polarSeries2
			// 
			// 
			// polarSeries2.Brush
			// 
			this.polarSeries2.Brush.Color = System.Drawing.Color.Green;
			this.polarSeries2.Circled = true;
			this.polarSeries2.CircleLabels = true;
			this.polarSeries2.CircleLabelsInside = true;
			this.polarSeries2.ClockWiseLabels = true;
			this.polarSeries2.ColorEach = true;
			// 
			// polarSeries2.Marks
			// 
			// 
			// polarSeries2.Marks.Symbol
			// 
			// 
			// polarSeries2.Marks.Symbol.Shadow
			// 
			this.polarSeries2.Marks.Symbol.Shadow.Height = 1;
			this.polarSeries2.Marks.Symbol.Shadow.Visible = true;
			this.polarSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// polarSeries2.Pen
			// 
			this.polarSeries2.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// polarSeries2.Pointer
			// 
			this.polarSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polarSeries2.Title = "polar2";
			// 
			// polarSeries2.XValues
			// 
			this.polarSeries2.XValues.DataMember = "Angle";
			this.polarSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// polarSeries2.YValues
			// 
			this.polarSeries2.YValues.DataMember = "Y";
			// 
			// SeriesType_Polar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Polar";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.polarSeries1.Circled = checkBox1.Checked;
			this.polarSeries2.Circled = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			polarSeries1.Brush.Transparency = (checkBox2.Checked) ? 100 : 0;
			polarSeries2.Brush.Transparency = polarSeries1.Brush.Transparency;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Stop();
			
			polarSeries1.Rotate(5);
			polarSeries2.Rotate(25);
			// Change Grid Lines and Horizontal Axis Labels
			Steema.TeeChart.Axis axis; 
			axis = tChart1.Axes.Bottom;
			if ((axis.Increment ==0) || (axis.Increment >= 90)) axis.Increment = 1.0;
			else axis.Increment += 2;
			//  Change Grid RINGS and Vertical Axis Labels }
			axis = tChart1.Axes.Left;
			if ((axis.Increment ==0) ||( axis.Increment >= 0.5*(axis.Maximum-axis.Minimum))) axis.Increment = 0.05*(axis.Maximum-axis.Minimum);
			else axis.Increment = 2*(axis.Maximum-axis.Minimum);

			timer1.Start();
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			timer1.Enabled = checkBox3.Checked;
		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			Steema.TeeChart.Drawing.IGraphics3D canvas = tChart1.Graphics3D;
			canvas.Brush.Solid = true; // <-- IMPORTANT (Try without) !!!

			canvas.Pen.Width = 2;
			
      // Draw a blue ring passing over the 3rd PolarSeries1 Point
			canvas.Pen.Color = Color.Blue;
			// polarSeries1.DrawRing( polarSeries1.YValues[2], polarSeries1.EndZ );

			// Draw a green ring passing over the 6th Polar #2 Point
			canvas.Pen.Color=Color.Green;
			// polarSeries2.DrawRing( polarSeries2.YValues[5], polarSeries2.EndZ );
		}
	}
}

