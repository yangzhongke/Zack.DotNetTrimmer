using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using Steema.TeeChart.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Canvas_RotCenter : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Surface surfaceSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		
		private int Delta;
		public Canvas_RotCenter()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			Delta  = 1;
			this.surfaceSeries1.FillSampleValues(25);
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
			this.surfaceSeries1 = new Steema.TeeChart.Styles.Surface();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(480, 72);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Graphics3D RotationCenter property defines the offset in pixels from the Chart ce" +
				"nter to rotate around it.  \r\n\r\ntChart1.Graphics3D.RotationCenter.X =100;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.trackBar3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.trackBar2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 73);
			this.panel1.TabIndex = 1;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 100;
			this.tChart1.Aspect.Elevation = 333;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 100;
			this.tChart1.Aspect.Rotation = 333;
			
			
			this.tChart1.Aspect.Zoom = 72;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 145);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.surfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(480, 148);
			this.tChart1.TabIndex = 2;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 50;
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
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// surfaceSeries1
			// 
			// 
			// surfaceSeries1.Brush
			// 
			this.surfaceSeries1.Brush.Color = System.Drawing.Color.Red;
			this.surfaceSeries1.Brush.Visible = false;
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
			this.surfaceSeries1.WireFrame = true;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rotation center:";
			this.label1.UseMnemonic = false;
			// 
			// trackBar1
			// 
			this.trackBar1.AutoSize = false;
			this.trackBar1.Location = new System.Drawing.Point(144, 8);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Minimum = -100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(61, 35);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TickFrequency = 20;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "&X";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(212, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "&Y";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// trackBar2
			// 
			this.trackBar2.AutoSize = false;
			this.trackBar2.Location = new System.Drawing.Point(224, 8);
			this.trackBar2.Maximum = 100;
			this.trackBar2.Minimum = -100;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(60, 35);
			this.trackBar2.TabIndex = 4;
			this.trackBar2.TickFrequency = 20;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(288, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(11, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "&Z";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// trackBar3
			// 
			this.trackBar3.AutoSize = false;
			this.trackBar3.Location = new System.Drawing.Point(304, 8);
			this.trackBar3.Maximum = 100;
			this.trackBar3.Minimum = -100;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(60, 35);
			this.trackBar3.TabIndex = 6;
			this.trackBar3.TickFrequency = 20;
			this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
			// 
			// timer1
			// 
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(10, 50);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(86, 17);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "&Animate";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(136, 50);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(64, 17);
			this.checkBox2.TabIndex = 8;
			this.checkBox2.Text = "&3D axes";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(224, 50);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(80, 17);
			this.checkBox3.TabIndex = 9;
			this.checkBox3.Text = "&Surface";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// Canvas_RotCenter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 293);
			this.Name = "Canvas_RotCenter";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void trackBar1_Scroll(object sender, System.EventArgs e)
		{
			PointXYZ tmp = tChart1.Graphics3D.RotationCenter;
			tmp.X = (int)trackBar1.Value;
			tChart1.Graphics3D.RotationCenter = tmp;
      tChart1.Invalidate();
		}

		private void trackBar2_Scroll(object sender, System.EventArgs e)
		{
			PointXYZ tmp = tChart1.Graphics3D.RotationCenter;
			tmp.Y = (int)trackBar2.Value;
			tChart1.Graphics3D.RotationCenter = tmp;
      tChart1.Invalidate();
    }

		private void trackBar3_Scroll(object sender, System.EventArgs e)
		{
			PointXYZ tmp = tChart1.Graphics3D.RotationCenter;
			tmp.Z = (int)trackBar3.Value;
			tChart1.Graphics3D.RotationCenter = tmp;
      tChart1.Invalidate();
    }

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.tChart1.Aspect.Rotation += Delta;
			if (tChart1.Aspect.Rotation ==360) Delta = -1;
			else if (tChart1.Aspect.Rotation == 270) Delta = 1;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.timer1.Enabled = this.checkBox1.Checked;
		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			if (checkBox2.Checked) // draw 3D axes
			{
				Steema.TeeChart.Drawing.IGraphics3D gr = tChart1.Graphics3D;
				// set pen style
				gr.Pen.Color = Color.Blue;
				gr.Pen.Width = 1;
				gr.Pen.Style = Drawing.DashStyle.Dot;
				// center position
				int tmpY = gr.ChartYCenter + gr.RotationCenter.Y;
				int tmpX = gr.ChartXCenter + gr.RotationCenter.X;
				int tmpZ = (tChart1.Aspect.Width3D / 2) + gr.RotationCenter.Z;
				// draw axes
				Rectangle cr = tChart1.Chart.ChartRect;
				gr.HorizontalLine(cr.Left,cr.Right,tmpY,tmpZ);
				gr.VerticalLine(tmpX, cr.Top, cr.Bottom,tmpZ);
				gr.ZLine(tmpX, tmpY,0, tChart1.Aspect.Width3D);
			}
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			surfaceSeries1.Active = checkBox3.Checked;
		}

    private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
    {
      tChart1.Invalidate();
    }
	}
}

