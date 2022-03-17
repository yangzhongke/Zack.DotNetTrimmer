using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Polar_Transparency : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Polar polarSeries1;
		private Steema.TeeChart.Styles.Polar polarSeries2;
		private Steema.TeeChart.Styles.Polar polarSeries3;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.HScrollBar hScrollBar3;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public Polar_Transparency()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			this.polarSeries1.FillSampleValues(5);
			this.polarSeries2.FillSampleValues(7);
			this.polarSeries3.FillSampleValues(8);
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
			this.polarSeries1 = new Steema.TeeChart.Styles.Polar();
			this.polarSeries2 = new Steema.TeeChart.Styles.Polar();
			this.polarSeries3 = new Steema.TeeChart.Styles.Polar();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Polar and Radar series can be transparent (percent from 0 to 100).\r\n\r\nExample : p" +
				"olarSeries1.Transparency = 40 ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar3);
			this.panel1.Controls.Add(this.hScrollBar2);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			this.panel1.TabIndex = 1;
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
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Polar series : Transparency"};
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.polarSeries1);
			this.tChart1.Series.Add(this.polarSeries2);
			this.tChart1.Series.Add(this.polarSeries3);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			this.tChart1.TabIndex = 2;
			// 
			// polarSeries1
			// 
			// 
			// polarSeries1.Brush
			// 
			this.polarSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
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
			this.polarSeries1.Pen.Color = System.Drawing.Color.Red;
			// 
			// polarSeries1.Pointer
			// 
			// 
			// polarSeries1.Pointer.Brush
			// 
			this.polarSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.polarSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polarSeries1.Title = "polarSeries1";
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
			this.polarSeries2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
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
			this.polarSeries2.Pen.Color = System.Drawing.Color.Green;
			// 
			// polarSeries2.Pointer
			// 
			// 
			// polarSeries2.Pointer.Brush
			// 
			this.polarSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.polarSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polarSeries2.Title = "polarSeries2";
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
			// polarSeries3
			// 
			// 
			// polarSeries3.Brush
			// 
			this.polarSeries3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			// 
			// polarSeries3.Marks
			// 
			// 
			// polarSeries3.Marks.Symbol
			// 
			// 
			// polarSeries3.Marks.Symbol.Shadow
			// 
			this.polarSeries3.Marks.Symbol.Shadow.Height = 1;
			this.polarSeries3.Marks.Symbol.Shadow.Visible = true;
			this.polarSeries3.Marks.Symbol.Shadow.Width = 1;
			// 
			// polarSeries3.Pen
			// 
			this.polarSeries3.Pen.Color = System.Drawing.Color.Yellow;
			// 
			// polarSeries3.Pointer
			// 
			// 
			// polarSeries3.Pointer.Brush
			// 
			this.polarSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.polarSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polarSeries3.Title = "polarSeries3";
			// 
			// polarSeries3.XValues
			// 
			this.polarSeries3.XValues.DataMember = "Angle";
			this.polarSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// polarSeries3.YValues
			// 
			this.polarSeries3.YValues.DataMember = "Y";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(94, 12);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(100, 17);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Value = 30;
			this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(200, 12);
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(100, 17);
			this.hScrollBar2.TabIndex = 2;
			this.hScrollBar2.Value = 30;
			this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
			// 
			// hScrollBar3
			// 
			this.hScrollBar3.Location = new System.Drawing.Point(307, 12);
			this.hScrollBar3.Name = "hScrollBar3";
			this.hScrollBar3.Size = new System.Drawing.Size(100, 17);
			this.hScrollBar3.TabIndex = 3;
			this.hScrollBar3.Value = 30;
			this.hScrollBar3.ValueChanged += new System.EventHandler(this.hScrollBar3_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Transparency:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Polar_Transparency
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Polar_Transparency";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void hScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
			this.polarSeries1.Transparency = (int)this.hScrollBar1.Value;
		}

		private void hScrollBar2_ValueChanged(object sender, System.EventArgs e)
		{
			this.polarSeries2.Transparency = (int)this.hScrollBar2.Value;
		}

		private void hScrollBar3_ValueChanged(object sender, System.EventArgs e)
		{
			this.polarSeries3.Transparency = (int)this.hScrollBar3.Value;
		}
	}
}

