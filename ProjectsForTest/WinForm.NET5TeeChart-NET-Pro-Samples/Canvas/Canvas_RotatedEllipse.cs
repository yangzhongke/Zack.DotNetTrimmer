using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Canvas_RotatedEllipse : Samples.BaseForm
	{
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Canvas_RotatedEllipse()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Canvas_RotatedEllipse));
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(432, 72);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Ellipses can now be rotated 360 degrees around vertical axis.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar2);
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 33);
			this.panel1.TabIndex = 1;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 65;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 71;
			this.tChart1.Aspect.Rotation = 341;
			
			
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "New Canvas methods"};
			this.tChart1.Location = new System.Drawing.Point(0, 105);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.Transparent;
			//this.tChart1.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("tChart1.Panel.Brush.Image")));
			this.tChart1.Panel.Brush.Solid = false;
			//this.tChart1.Panel.Image = ((System.Drawing.Image)(resources.GetObject("tChart1.Panel.Image")));
			this.tChart1.Size = new System.Drawing.Size(432, 212);
			this.tChart1.TabIndex = 2;
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
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.tChart1.Walls.Left.Size = 5;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.LargeChange = 1;
			this.hScrollBar2.Location = new System.Drawing.Point(96, 10);
			this.hScrollBar2.Maximum = 360;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(134, 14);
			this.hScrollBar2.TabIndex = 3;
			this.hScrollBar2.Value = 60;
			this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Ellipse angle:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(240, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "60";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(288, 10);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(40, 16);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "3D";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Canvas_RotatedEllipse
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 317);
			this.Name = "Canvas_RotatedEllipse";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void hScrollBar2_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
    {
      label2.Text=hScrollBar2.Value.ToString();
      tChart1.Invalidate();
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      tChart1.Aspect.View3D=checkBox1.Checked;
    }

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      g.Pen.Style = Drawing.DashStyle.Solid;
      g.Pen.Color = Color.Blue;
      g.Brush.Visible = true;
      g.Brush.Color = Color.Azure;
      g.Ellipse(50,90,250,160,0,hScrollBar2.Value);
    }
	}
}

