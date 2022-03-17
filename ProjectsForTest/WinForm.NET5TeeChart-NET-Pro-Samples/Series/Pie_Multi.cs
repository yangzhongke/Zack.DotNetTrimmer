using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;
using Steema.TeeChart.Drawing;


namespace Steema.TeeChart.Samples
{
	public class Pie_Multi : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Pie pieSeries1;
		private Steema.TeeChart.Styles.Pie pieSeries2;
		private Steema.TeeChart.Styles.Pie pieSeries3;
		private Steema.TeeChart.Styles.Pie pieSeries4;
		private System.ComponentModel.IContainer components = null;

		public Pie_Multi()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(4);
			tChart1.Aspect.ApplyZOrder = false;

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
			this.pieSeries1 = new Steema.TeeChart.Styles.Pie();
			this.pieSeries2 = new Steema.TeeChart.Styles.Pie();
			this.pieSeries3 = new Steema.TeeChart.Styles.Pie();
			this.pieSeries4 = new Steema.TeeChart.Styles.Pie();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Multiple Pie series can be aligned using the BeforeDrawValues event and the Chart" +
				"Rect property.\r\n\r\nExample: tChart1.Chart.ChartRect = new Rectangle( 20, 20, 200," +
				"200 );";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 27);
			this.panel1.Visible = false;
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
																								 "Multiple pies per chart"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 90);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pieSeries1);
			this.tChart1.Series.Add(this.pieSeries2);
			this.tChart1.Series.Add(this.pieSeries3);
			this.tChart1.Series.Add(this.pieSeries4);
			this.tChart1.Size = new System.Drawing.Size(466, 196);
			// 
			// pieSeries1
			// 
			// 
			// pieSeries1.Brush
			// 
			this.pieSeries1.Brush.Color = System.Drawing.Color.Red;
			this.pieSeries1.LabelMember = "Labels";
			// 
			// pieSeries1.Marks
			// 
			// 
			// pieSeries1.Marks.Symbol
			// 
			// 
			// pieSeries1.Marks.Symbol.Shadow
			// 
			this.pieSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries1.Pen
			// 
			this.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pieSeries1.Shadow
			// 
			this.pieSeries1.Shadow.Height = 20;
			this.pieSeries1.Shadow.Width = 20;
			this.pieSeries1.Title = "pieSeries1";
			// 
			// pieSeries1.XValues
			// 
			this.pieSeries1.XValues.DataMember = "Angle";
			this.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries1.YValues
			// 
			this.pieSeries1.YValues.DataMember = "Pie";
			this.pieSeries1.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.pieSeries1_BeforeDrawValues);
			// 
			// pieSeries2
			// 
			// 
			// pieSeries2.Brush
			// 
			this.pieSeries2.Brush.Color = System.Drawing.Color.Green;
			this.pieSeries2.LabelMember = "Labels";
			// 
			// pieSeries2.Marks
			// 
			// 
			// pieSeries2.Marks.Symbol
			// 
			// 
			// pieSeries2.Marks.Symbol.Shadow
			// 
			this.pieSeries2.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries2.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries2.Pen
			// 
			this.pieSeries2.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pieSeries2.Shadow
			// 
			this.pieSeries2.Shadow.Height = 20;
			this.pieSeries2.Shadow.Width = 20;
			this.pieSeries2.Title = "pieSeries2";
			// 
			// pieSeries2.XValues
			// 
			this.pieSeries2.XValues.DataMember = "Angle";
			this.pieSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries2.YValues
			// 
			this.pieSeries2.YValues.DataMember = "Pie";
			this.pieSeries2.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.pieSeries2_BeforeDrawValues);
			// 
			// pieSeries3
			// 
			// 
			// pieSeries3.Brush
			// 
			this.pieSeries3.Brush.Color = System.Drawing.Color.Yellow;
			this.pieSeries3.LabelMember = "Labels";
			// 
			// pieSeries3.Marks
			// 
			// 
			// pieSeries3.Marks.Symbol
			// 
			// 
			// pieSeries3.Marks.Symbol.Shadow
			// 
			this.pieSeries3.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries3.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries3.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries3.Pen
			// 
			this.pieSeries3.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pieSeries3.Shadow
			// 
			this.pieSeries3.Shadow.Height = 20;
			this.pieSeries3.Shadow.Width = 20;
			this.pieSeries3.Title = "pieSeries3";
			// 
			// pieSeries3.XValues
			// 
			this.pieSeries3.XValues.DataMember = "Angle";
			this.pieSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries3.YValues
			// 
			this.pieSeries3.YValues.DataMember = "Pie";
			this.pieSeries3.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.pieSeries3_BeforeDrawValues);
			// 
			// pieSeries4
			// 
			// 
			// pieSeries4.Brush
			// 
			this.pieSeries4.Brush.Color = System.Drawing.Color.Blue;
			this.pieSeries4.LabelMember = "Labels";
			// 
			// pieSeries4.Marks
			// 
			// 
			// pieSeries4.Marks.Symbol
			// 
			// 
			// pieSeries4.Marks.Symbol.Shadow
			// 
			this.pieSeries4.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries4.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries4.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries4.Pen
			// 
			this.pieSeries4.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pieSeries4.Shadow
			// 
			this.pieSeries4.Shadow.Height = 20;
			this.pieSeries4.Shadow.Width = 20;
			this.pieSeries4.Title = "pieSeries4";
			// 
			// pieSeries4.XValues
			// 
			this.pieSeries4.XValues.DataMember = "Angle";
			this.pieSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries4.YValues
			// 
			this.pieSeries4.YValues.DataMember = "Pie";
			this.pieSeries4.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.pieSeries4_BeforeDrawValues);
			// 
			// Pie_Multi
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Pie_Multi";
			this.ResumeLayout(false);

		}
		#endregion

		private void pieSeries1_BeforeDrawValues(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			this.tChart1.Chart.ChartRect = new Rectangle(10,10,this.tChart1.Width/2-20, this.tChart1.Height/2-20);
		}

		private void pieSeries2_BeforeDrawValues(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			this.tChart1.Chart.ChartRect = new Rectangle(this.tChart1.Width/2,10,this.tChart1.Width/2-20, this.tChart1.Height/2-20);
		}

		private void pieSeries3_BeforeDrawValues(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			this.tChart1.Chart.ChartRect = new Rectangle(10,this.tChart1.Height/2, this.tChart1.Width/2-20, this.tChart1.Height/2-20);
		}

		private void pieSeries4_BeforeDrawValues(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			this.tChart1.Chart.ChartRect = new Rectangle(this.tChart1.Width/2,this.tChart1.Height/2,this.tChart1.Width/2-20, this.tChart1.Height/2-20);
		}
	}
}

