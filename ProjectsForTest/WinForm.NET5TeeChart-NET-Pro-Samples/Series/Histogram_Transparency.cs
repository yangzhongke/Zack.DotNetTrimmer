using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Histogram_Transparency : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Histogram histogramSeries1;
		private Steema.TeeChart.Styles.Histogram histogramSeries2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.ComponentModel.IContainer components = null;

		public Histogram_Transparency()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(15);
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
			this.histogramSeries1 = new Steema.TeeChart.Styles.Histogram();
			this.histogramSeries2 = new Steema.TeeChart.Styles.Histogram();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "The Histogram series includes a Transparency property (from 0 to 100 percent).\r\n\r" +
				"\nhistogramSeries1.Transparency = 50 ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 34);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Histogram series with transparency"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 97);
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.GammaCorrection = true;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Panel.Gradient.GammaCorrection = true;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.histogramSeries1);
			this.tChart1.Series.Add(this.histogramSeries2);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			// 
			// histogramSeries1
			// 
			// 
			// histogramSeries1.Brush
			// 
			this.histogramSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// histogramSeries1.LinePen
			// 
			this.histogramSeries1.LinePen.Color = System.Drawing.Color.Black;
			// 
			// histogramSeries1.Marks
			// 
			// 
			// histogramSeries1.Marks.Symbol
			// 
			// 
			// histogramSeries1.Marks.Symbol.Shadow
			// 
			this.histogramSeries1.Marks.Symbol.Shadow.Height = 1;
			this.histogramSeries1.Marks.Symbol.Shadow.Visible = true;
			this.histogramSeries1.Marks.Symbol.Shadow.Width = 1;
			this.histogramSeries1.Title = "histogramSeries1";
			// 
			// histogramSeries1.XValues
			// 
			this.histogramSeries1.XValues.DataMember = "X";
			this.histogramSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// histogramSeries1.YValues
			// 
			this.histogramSeries1.YValues.DataMember = "Y";
			// 
			// histogramSeries2
			// 
			// 
			// histogramSeries2.Brush
			// 
			this.histogramSeries2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// histogramSeries2.LinePen
			// 
			this.histogramSeries2.LinePen.Color = System.Drawing.Color.Black;
			// 
			// histogramSeries2.Marks
			// 
			// 
			// histogramSeries2.Marks.Symbol
			// 
			// 
			// histogramSeries2.Marks.Symbol.Shadow
			// 
			this.histogramSeries2.Marks.Symbol.Shadow.Height = 1;
			this.histogramSeries2.Marks.Symbol.Shadow.Visible = true;
			this.histogramSeries2.Marks.Symbol.Shadow.Width = 1;
			this.histogramSeries2.Title = "histogramSeries2";
			// 
			// histogramSeries2.XValues
			// 
			this.histogramSeries2.XValues.DataMember = "X";
			this.histogramSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// histogramSeries2.YValues
			// 
			this.histogramSeries2.YValues.DataMember = "Y";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Transparency % :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(120, 7);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 50,
																																 0,
																																 0,
																																 0});
			this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// Histogram_Transparency
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Histogram_Transparency";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.histogramSeries2.Transparency = (int)this.numericUpDown1.Value;
		}
	}
}

