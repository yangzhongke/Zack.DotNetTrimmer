using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Canvas_PyramidTrunc : Samples.BaseForm
	{
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;

		public Canvas_PyramidTrunc()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

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
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(536, 88);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = @"Graphics3D includes a method to draw truncated Pyramids.

Steema.TeeChart.Drawing.IGraphics3D gr = tChart1.Graphics3D;
gr.Brush.Color = Color.GreenYellow;
gr.PyramidTrunc(new System.Drawing.Rectangle(gr.ChartXCenter,gr.ChartYCenter,60,70),
		0,50,10,20);";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar2);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Location = new System.Drawing.Point(0, 88);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(536, 33);
			this.panel1.TabIndex = 1;
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
																								 "tChart1"};
			this.tChart1.Location = new System.Drawing.Point(0, 121);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Size = new System.Drawing.Size(536, 196);
			this.tChart1.TabIndex = 2;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Walls.Back.Transparent = false;
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
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(33, 10);
			this.hScrollBar1.Maximum = 50;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(134, 14);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Value = 10;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(213, 10);
			this.hScrollBar2.Maximum = 50;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(134, 14);
			this.hScrollBar2.TabIndex = 3;
			this.hScrollBar2.Value = 10;
			this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&X :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(187, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Z :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Canvas_PyramidTrunc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(536, 317);
			this.Name = "Canvas_PyramidTrunc";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			g.Brush.Visible=true;
			g.Brush.Gradient.Visible=true;
			g.Brush.Gradient.EndColor = Color.Orange;
			g.Pen.Color = Color.DarkRed;
			g.PyramidTrunc(new System.Drawing.Rectangle(g.ChartXCenter,g.ChartYCenter,60,70),
							0,50,(int)hScrollBar1.Value,(int)hScrollBar2.Value);
		}

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.tChart1.Invalidate();
		}

		private void hScrollBar2_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.tChart1.Invalidate();
		}
	}
}

