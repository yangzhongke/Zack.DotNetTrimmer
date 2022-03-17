using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Clock Series class.
	/// </summary>
	public class SeriesType_Clock : System.Windows.Forms.Form
	{
		protected internal System.Windows.Forms.TextBox textBox1;
		protected System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.TChart tChart2;
		private Steema.TeeChart.TChart tChart3;
		private Steema.TeeChart.Styles.Clock clockSeries1;
		private Steema.TeeChart.Styles.Clock clockSeries2;
		private Steema.TeeChart.Styles.Clock clockSeries3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SeriesType_Clock()
		{
			//
			// Required for Windows Form Designer support
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tChart3 = new Steema.TeeChart.TChart();
      this.clockSeries3 = new Steema.TeeChart.Styles.Clock();
      this.tChart2 = new Steema.TeeChart.TChart();
      this.clockSeries2 = new Steema.TeeChart.Styles.Clock();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.clockSeries1 = new Steema.TeeChart.Styles.Clock();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBox1.Location = new System.Drawing.Point(0, 0);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(426, 48);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "The Clock series displays live watches. Multiple configuration parameters are ava" +
          "ilable, like colors, numbering style, backgrounds, gradient, font, etc.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.numericUpDown1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 48);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(426, 34);
      this.panel1.TabIndex = 3;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(224, 8);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
      this.numericUpDown1.TabIndex = 2;
      this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(133, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "&Refresh interval:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // checkBox1
      // 
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox1.Location = new System.Drawing.Point(13, 8);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(114, 21);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "&Roman numbers";
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.tChart3);
      this.panel2.Controls.Add(this.tChart2);
      this.panel2.Controls.Add(this.tChart1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 82);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(426, 190);
      this.panel2.TabIndex = 4;
      // 
      // tChart3
      // 
      // 
      // 
      // 
      this.tChart3.Aspect.Elevation = 315;
      this.tChart3.Aspect.ElevationFloat = 315D;
      this.tChart3.Aspect.Orthogonal = false;
      this.tChart3.Aspect.Perspective = 0;
      this.tChart3.Aspect.Rotation = 360;
      this.tChart3.Aspect.RotationFloat = 360D;
      this.tChart3.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Axes.Bottom.Increment = 30D;
      this.tChart3.Axes.Visible = false;
      this.tChart3.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.tChart3.Header.Lines = new string[] {
        "tChart3"};
      this.tChart3.Header.Visible = false;
      this.tChart3.Location = new System.Drawing.Point(293, 0);
      this.tChart3.Name = "tChart3";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart3.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
      this.tChart3.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart3.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
      this.tChart3.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.tChart3.Panel.Brush.Gradient.UseMiddle = true;
      this.tChart3.Series.Add(this.clockSeries3);
      this.tChart3.Size = new System.Drawing.Size(133, 190);
      this.tChart3.TabIndex = 2;
      // 
      // clockSeries3
      // 
      // 
      // 
      // 
      this.clockSeries3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.clockSeries3.Circled = true;
      this.clockSeries3.CircleLabels = true;
      this.clockSeries3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.clockSeries3.ColorEach = false;
      // 
      // 
      // 
      this.clockSeries3.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.clockSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.clockSeries3.RotationAngle = 90;
      this.clockSeries3.Legend.Visible = false;
      this.clockSeries3.Title = "clockSeries3";
      // 
      // 
      // 
      this.clockSeries3.XValues.DataMember = "Angle";
      this.clockSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.clockSeries3.YValues.DataMember = "Y";
      // 
      // tChart2
      // 
      // 
      // 
      // 
      this.tChart2.Aspect.Elevation = 315;
      this.tChart2.Aspect.ElevationFloat = 315D;
      this.tChart2.Aspect.Orthogonal = false;
      this.tChart2.Aspect.Perspective = 0;
      this.tChart2.Aspect.Rotation = 360;
      this.tChart2.Aspect.RotationFloat = 360D;
      this.tChart2.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Axes.Bottom.Increment = 30D;
      this.tChart2.Axes.Visible = false;
      this.tChart2.Dock = System.Windows.Forms.DockStyle.Left;
      // 
      // 
      // 
      this.tChart2.Header.Lines = new string[] {
        "tChart2"};
      this.tChart2.Header.Visible = false;
      this.tChart2.Location = new System.Drawing.Point(147, 0);
      this.tChart2.Name = "tChart2";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart2.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart2.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.tChart2.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart2.Panel.Brush.Gradient.UseMiddle = true;
      this.tChart2.Series.Add(this.clockSeries2);
      this.tChart2.Size = new System.Drawing.Size(146, 190);
      this.tChart2.TabIndex = 1;
      // 
      // clockSeries2
      // 
      // 
      // 
      // 
      this.clockSeries2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.clockSeries2.Circled = true;
      this.clockSeries2.CircleLabels = true;
      this.clockSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.clockSeries2.ColorEach = false;
      // 
      // 
      // 
      this.clockSeries2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.clockSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.clockSeries2.RotationAngle = 90;
      this.clockSeries2.Legend.Visible = false;
      this.clockSeries2.Title = "clockSeries2";
      // 
      // 
      // 
      this.clockSeries2.XValues.DataMember = "Angle";
      this.clockSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.clockSeries2.YValues.DataMember = "Y";
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.Elevation = 315;
      this.tChart1.Aspect.ElevationFloat = 315D;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 0;
      this.tChart1.Aspect.Rotation = 360;
      this.tChart1.Aspect.RotationFloat = 360D;
      
      
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Increment = 30D;
      this.tChart1.Axes.Visible = false;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Left;
      // 
      // 
      // 
      this.tChart1.Header.Lines = new string[] {
        "tChart1"};
      this.tChart1.Header.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.GammaCorrection = true;
      this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
      this.tChart1.Panel.Brush.Gradient.Sigma = true;
      this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.496F;
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
      this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
      this.tChart1.Series.Add(this.clockSeries1);
      this.tChart1.Size = new System.Drawing.Size(147, 190);
      this.tChart1.TabIndex = 0;
      // 
      // clockSeries1
      // 
      // 
      // 
      // 
      this.clockSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.clockSeries1.Circled = true;
      this.clockSeries1.CircleLabels = true;
      this.clockSeries1.CircleLabelsInside = true;
      // 
      // 
      // 
      this.clockSeries1.CirclePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
      this.clockSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.clockSeries1.ColorEach = false;
      // 
      // 
      // 
      this.clockSeries1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
      this.clockSeries1.Pen.Visible = false;
      // 
      // 
      // 
      this.clockSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.clockSeries1.RotationAngle = 90;
      this.clockSeries1.Legend.Visible = false;
      this.clockSeries1.Title = "clockSeries1";
      // 
      // 
      // 
      this.clockSeries1.XValues.DataMember = "Angle";
      this.clockSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.clockSeries1.YValues.DataMember = "Y";
      // 
      // SeriesType_Clock
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(426, 272);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.textBox1);
      this.Name = "SeriesType_Clock";
      this.Text = "Clock";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.clockSeries1.Style = Steema.TeeChart.Styles.ClockStyles.Roman;
				this.clockSeries2.Style = Steema.TeeChart.Styles.ClockStyles.Roman;
				this.clockSeries3.Style = Steema.TeeChart.Styles.ClockStyles.Roman;
			}
			else
			{
				this.clockSeries1.Style = Steema.TeeChart.Styles.ClockStyles.Decimal;
				this.clockSeries2.Style = Steema.TeeChart.Styles.ClockStyles.Decimal;
				this.clockSeries3.Style = Steema.TeeChart.Styles.ClockStyles.Decimal;
			}
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
//#if WPF || SILVERLIGHT
//			this.clockSeries1.Timer.Interval = new TimeSpan(0, 0, 0, 0, (int)this.numericUpDown1.Value);
//			this.clockSeries2.Timer.Interval = new TimeSpan(0, 0, 0, 0, (int)this.numericUpDown1.Value);
//			this.clockSeries3.Timer.Interval = new TimeSpan(0, 0, 0, 0, (int)this.numericUpDown1.Value);
//#else
//      this.clockSeries1.Timer.Interval = (int)this.numericUpDown1.Value;
//      this.clockSeries2.Timer.Interval = (int)this.numericUpDown1.Value;
//      this.clockSeries3.Timer.Interval = (int)this.numericUpDown1.Value;
//#endif
		}
	}
}
