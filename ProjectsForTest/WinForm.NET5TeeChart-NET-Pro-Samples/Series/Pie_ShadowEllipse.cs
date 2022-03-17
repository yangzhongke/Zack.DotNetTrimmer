using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart.Drawing;

namespace Steema.TeeChart.Samples
{
	public class PieShadowEllipse : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.ButtonColor buttonColor1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private Steema.TeeChart.Styles.Pie pie1;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components = null;

		public PieShadowEllipse()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			pie1.FillSampleValues();
			pie1.Circled=false;
			tChart1.Legend.Visible=false;
			buttonColor1.Color=tChart1.Panel.Color;
			
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
			this.buttonColor1 = new Steema.TeeChart.ButtonColor();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.pie1 = new Steema.TeeChart.Styles.Pie();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "A procedure to draw elliptical shadows. \r\nUseful for circular series like Pie, at" +
				" Chart OnBeforeDrawSeries event.\r\n\r\nDrawEllipseShadow( Chart1.Canvas, Chart1.Col" +
				"or, R );";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.buttonColor1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
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
			
			
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Length = 2;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Length = 2;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Length = 2;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Length = 2;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.ImageBevel
			// 
			this.tChart1.Panel.ImageBevel.Visible = true;
			this.tChart1.Panel.ImageBevel.Width = 5;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.pie1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.BeforeDrawSeries += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_BeforeDrawSeries);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "View Shadow:";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// buttonColor1
			// 
			this.buttonColor1.Color = System.Drawing.Color.Empty;
			this.buttonColor1.Location = new System.Drawing.Point(136, 9);
			this.buttonColor1.Name = "buttonColor1";
			this.buttonColor1.TabIndex = 1;
			this.buttonColor1.Text = "Color...";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(232, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 37);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Animation";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(128, 17);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(50, 13);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "Fast";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(71, 17);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(50, 13);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Slow";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(14, 17);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(50, 13);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "None";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// pie1
			// 
			// 
			// pie1.Brush
			// 
			this.pie1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(153)), ((System.Byte)(153)));
			this.pie1.LabelMember = "Labels";
			// 
			// pie1.Marks
			// 
			// 
			// pie1.Marks.Symbol
			// 
			// 
			// pie1.Marks.Symbol.Shadow
			// 
			this.pie1.Marks.Symbol.Shadow.Height = 1;
			this.pie1.Marks.Symbol.Shadow.Visible = true;
			this.pie1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pie1.Pen
			// 
			this.pie1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pie1.Shadow
			// 
			this.pie1.Shadow.Height = 20;
			this.pie1.Shadow.Width = 20;
			this.pie1.Title = "pie1";
			// 
			// pie1.XValues
			// 
			this.pie1.XValues.DataMember = "Angle";
			this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pie1.YValues
			// 
			this.pie1.YValues.DataMember = "Pie";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// PieShadowEllipse
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "PieShadowEllipse";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void DrawEllipseShadow(Steema.TeeChart.Drawing.IGraphics3D g, Color AColor, Rectangle R) {
			int x, y, t;
			int Steps;
			double tmpW, tmpH;

			g.Pen.Visible=false;
			g.Brush.Solid = true;
			g.Brush.Visible = true;
			g.Brush.Color = AColor;
			

			x=(R.Left+R.Right) / 2;
			y=(R.Top+R.Bottom) / 2;

			Steps=Math.Min(x, y) / 10;
			tmpW=0.5*(R.Right-R.Left)/Steps;
			tmpH=0.5*(R.Bottom-R.Top)/Steps;

			for(t=Steps; t > 0; --t) {
				Graphics3D.ApplyDark(ref AColor, 8);
				g.Brush.Color=AColor;
				R=Rectangle.FromLTRB(x-Convert.ToInt32(t*tmpW),y-Convert.ToInt32(t*tmpH),x+Convert.ToInt32(t*tmpW),y+Convert.ToInt32(t*tmpH));
				g.Ellipse(R);
			}
		}

		private void tChart1_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.IGraphics3D g) {
			Rectangle R;
			if(checkBox1.Checked) {
				R=tChart1.Chart.ChartRect;
				R=Rectangle.FromLTRB(R.Left+80, R.Bottom-40, R.Right-80, R.Bottom);
				DrawEllipseShadow(g, tChart1.Panel.Color, R);
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
			tChart1.Refresh();
		}

		private void timer1_Tick(object sender, System.EventArgs e) {
			pie1.RotationAngle = pie1.RotationAngle + 1;
		}

		private void radioButton_CheckedChanged(object sender, System.EventArgs e) {
			timer1.Enabled=!radioButton1.Checked;
			if(radioButton2.Checked) timer1.Interval=200;
			else timer1.Interval=1;
		}
	}
}

