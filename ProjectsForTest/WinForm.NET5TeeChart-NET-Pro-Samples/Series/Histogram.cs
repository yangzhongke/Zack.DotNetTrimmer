using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Histogram : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Histogram histogramSeries1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Histogram()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.histogramSeries1.FillSampleValues(20);
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
			this.button1 = new System.Windows.Forms.Button();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Histogram Series draws points side-to-side with no gaps.\r\nIncludes Border and Lin" +
				"es pen objects.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
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
																								 "Histogram series"};
			this.tChart1.Location = new System.Drawing.Point(0, 97);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.histogramSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// histogramSeries1
			// 
			// 
			// histogramSeries1.Brush
			// 
			this.histogramSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
			// 
			// histogramSeries1.LinePen
			// 
			this.histogramSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(153)));
			// 
			// histogramSeries1.LinesPen
			// 
			this.histogramSeries1.LinesPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(153)));
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
			this.histogramSeries1.Title = "histogram1";
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
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(20, 6);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Histogram
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Histogram";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.histogramSeries1);
		}
	}
}

