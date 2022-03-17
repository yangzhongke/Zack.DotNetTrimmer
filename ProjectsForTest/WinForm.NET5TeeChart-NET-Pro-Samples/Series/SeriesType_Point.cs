using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Point : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Timer timer1;
		private Steema.TeeChart.Styles.Points pointSeries1;
		private Steema.TeeChart.Styles.Points pointSeries2;
		private Steema.TeeChart.Styles.Points pointSeries3;
		private Steema.TeeChart.Styles.Points pointSeries4;
		private Steema.TeeChart.Styles.Points pointSeries5;
		private Steema.TeeChart.Styles.Points pointSeries6;
		private System.ComponentModel.IContainer components = null;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private Random r;
		public SeriesType_Point()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			foreach(Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(20);

			r = new Random();
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pointSeries1 = new Steema.TeeChart.Styles.Points();
			this.pointSeries2 = new Steema.TeeChart.Styles.Points();
			this.pointSeries3 = new Steema.TeeChart.Styles.Points();
			this.pointSeries4 = new Steema.TeeChart.Styles.Points();
			this.pointSeries5 = new Steema.TeeChart.Styles.Points();
			this.pointSeries6 = new Steema.TeeChart.Styles.Points();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Point series displays XY values using a Pointer.\r\n\r\nEach pointer has many differe" +
				"nt properties, like color, 3D, shadow, style, marks, pattern, border, width, hei" +
				"ght, etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 35;
			this.tChart1.Aspect.Elevation = 350;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 55;
			this.tChart1.Aspect.Rotation = 322;
			
			
			this.tChart1.Aspect.Zoom = 72;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Bottom = 26;
			this.tChart1.Header.CustomPosition = true;
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Teal;
			this.tChart1.Header.Font.Size = 10;
			this.tChart1.Header.Left = 10;
			this.tChart1.Header.Lines = new string[] {
																								 "Point series"};
			this.tChart1.Header.Right = 110;
			this.tChart1.Header.Top = 9;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Legend.Shadow.Height = 4;
			this.tChart1.Legend.Shadow.Width = 4;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pointSeries1);
			this.tChart1.Series.Add(this.pointSeries2);
			this.tChart1.Series.Add(this.pointSeries3);
			this.tChart1.Series.Add(this.pointSeries4);
			this.tChart1.Series.Add(this.pointSeries5);
			this.tChart1.Series.Add(this.pointSeries6);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
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
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(40, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&3D";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(93, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(67, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Animate";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pointSeries1
			// 
			// 
			// pointSeries1.Marks
			// 
			// 
			// pointSeries1.Marks.Symbol
			// 
			// 
			// pointSeries1.Marks.Symbol.Shadow
			// 
			this.pointSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries1.Pointer
			// 
			// 
			// pointSeries1.Pointer.Brush
			// 
			this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries1.Title = "point6";
			// 
			// pointSeries1.XValues
			// 
			this.pointSeries1.XValues.DataMember = "X";
			this.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries1.YValues
			// 
			this.pointSeries1.YValues.DataMember = "Y";
			// 
			// pointSeries2
			// 
			// 
			// pointSeries2.Marks
			// 
			// 
			// pointSeries2.Marks.Symbol
			// 
			// 
			// pointSeries2.Marks.Symbol.Shadow
			// 
			this.pointSeries2.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries2.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries2.Pointer
			// 
			// 
			// pointSeries2.Pointer.Brush
			// 
			this.pointSeries2.Pointer.Brush.Color = System.Drawing.Color.Green;
			this.pointSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries2.Title = "point6";
			// 
			// pointSeries2.XValues
			// 
			this.pointSeries2.XValues.DataMember = "X";
			this.pointSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries2.YValues
			// 
			this.pointSeries2.YValues.DataMember = "Y";
			// 
			// pointSeries3
			// 
			// 
			// pointSeries3.Marks
			// 
			// 
			// pointSeries3.Marks.Symbol
			// 
			// 
			// pointSeries3.Marks.Symbol.Shadow
			// 
			this.pointSeries3.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries3.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries3.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries3.Pointer
			// 
			// 
			// pointSeries3.Pointer.Brush
			// 
			this.pointSeries3.Pointer.Brush.Color = System.Drawing.Color.Yellow;
			this.pointSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries3.Title = "point6";
			// 
			// pointSeries3.XValues
			// 
			this.pointSeries3.XValues.DataMember = "X";
			this.pointSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries3.YValues
			// 
			this.pointSeries3.YValues.DataMember = "Y";
			// 
			// pointSeries4
			// 
			// 
			// pointSeries4.Marks
			// 
			// 
			// pointSeries4.Marks.Symbol
			// 
			// 
			// pointSeries4.Marks.Symbol.Shadow
			// 
			this.pointSeries4.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries4.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries4.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries4.Pointer
			// 
			// 
			// pointSeries4.Pointer.Brush
			// 
			this.pointSeries4.Pointer.Brush.Color = System.Drawing.Color.Blue;
			this.pointSeries4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries4.Title = "point6";
			// 
			// pointSeries4.XValues
			// 
			this.pointSeries4.XValues.DataMember = "X";
			this.pointSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries4.YValues
			// 
			this.pointSeries4.YValues.DataMember = "Y";
			// 
			// pointSeries5
			// 
			// 
			// pointSeries5.LinePen
			// 
			this.pointSeries5.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(153)), ((System.Byte)(122)));
			// 
			// pointSeries5.Marks
			// 
			// 
			// pointSeries5.Marks.Symbol
			// 
			// 
			// pointSeries5.Marks.Symbol.Shadow
			// 
			this.pointSeries5.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries5.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries5.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries5.Pointer
			// 
			// 
			// pointSeries5.Pointer.Brush
			// 
			this.pointSeries5.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(204)));
			// 
			// pointSeries5.Pointer.Pen
			// 
			this.pointSeries5.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(153)), ((System.Byte)(122)));
			this.pointSeries5.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries5.Title = "point6";
			// 
			// pointSeries5.XValues
			// 
			this.pointSeries5.XValues.DataMember = "X";
			this.pointSeries5.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries5.YValues
			// 
			this.pointSeries5.YValues.DataMember = "Y";
			// 
			// pointSeries6
			// 
			// 
			// pointSeries6.Marks
			// 
			// 
			// pointSeries6.Marks.Symbol
			// 
			// 
			// pointSeries6.Marks.Symbol.Shadow
			// 
			this.pointSeries6.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries6.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries6.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries6.Pointer
			// 
			// 
			// pointSeries6.Pointer.Brush
			// 
			this.pointSeries6.Pointer.Brush.Color = System.Drawing.Color.Gray;
			this.pointSeries6.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries6.Title = "point6";
			// 
			// pointSeries6.XValues
			// 
			this.pointSeries6.XValues.DataMember = "X";
			this.pointSeries6.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries6.YValues
			// 
			this.pointSeries6.YValues.DataMember = "Y";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Point
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Point";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{	
			timer1.Enabled = checkBox2.Checked;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Stop();
			try
			{
				double tmpX;
				foreach(Steema.TeeChart.Styles.Series s in tChart1.Series)
				{
					// add a new point to each series
					tmpX = s.XValues[1] - s.XValues[0];
					s.Delete(0);
					s.Add(s.XValues.Last + tmpX, s.YValues.Last + r.Next(100)-50);
				}
			}
			finally
			{
				timer1.Start();
			}
		
		}
	}
}

