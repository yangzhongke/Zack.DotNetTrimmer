using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Canvas_AntiAlias : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Pie pie1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Canvas_AntiAlias()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			pie1.FillSampleValues(8);
			
			Bitmap b = tChart1.Bitmap();
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
			this.pie1 = new Steema.TeeChart.Styles.Pie();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Global method to smooth curve and diagonal lines (Anti-Alias), and new Canvas pro" +
				"perty to zoom fonts (as percentage).";
			// 
			// panel1
			// 
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
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Anti-Aliased Pie"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pie1);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// pie1
			// 
			// 
			// pie1.Brush
			// 
			this.pie1.Brush.Color = System.Drawing.Color.Red;
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
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Anti-Alias";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Canvas_AntiAlias
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Canvas_AntiAlias";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e) {
			
		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g) {
			//if(g.SmoothingMode == System.Drawing.Drawing2D.SmoothingMode.Default)
			//	g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			//else
			//	g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
		}


		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
			tChart1.Invalidate();
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Drawing.TextShape ts;
			ts = pie1.Marks;
			ts.Font.Size = 20;
		}

	
	}
}

