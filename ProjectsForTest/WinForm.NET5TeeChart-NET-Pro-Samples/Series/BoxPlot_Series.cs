using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class BoxPlot_Series : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Box boxSeries1;
		private Steema.TeeChart.Styles.Box boxSeries2;
		private Steema.TeeChart.Styles.Box boxSeries3;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public BoxPlot_Series()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			boxSeries1.Add(new double[6] {3,6,8,15,19,21});
			boxSeries2.Add(new double[4] {5,7,12,21});
			boxSeries3.Add(new double[5] {6,7,8,15,21});

      // A simple trick to force custom axis labels on bottom axis.
      // In this case, series titles
      Steema.TeeChart.AxisLabelsItems labels = tChart1.Axes.Bottom.Labels.Items;
      labels.Clear();
      foreach (Styles.Box b in tChart1.Series)
        labels.Add(b.Position,b.Title);       
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
			this.boxSeries1 = new Steema.TeeChart.Styles.Box();
			this.boxSeries2 = new Steema.TeeChart.Styles.Box();
			this.boxSeries3 = new Steema.TeeChart.Styles.Box();
			this.button1 = new System.Windows.Forms.Button();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Box series (also called Box & Whisker or Box-Plot) draws a \"box\" and  calculates " +
				"the Median and Whisker quantities.\r\nAll visual parts are fully configurable.";
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
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			this.tChart1.Header.Font.Size = 7;
			this.tChart1.Header.Lines = new string[] {
																								 "BoxPlot series example"};
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
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(215)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.Transparency = 40;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(215)), ((System.Byte)(0)));
			this.tChart1.Panel.Gradient.Transparency = 40;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.boxSeries1);
			this.tChart1.Series.Add(this.boxSeries2);
			this.tChart1.Series.Add(this.boxSeries3);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			this.tChart1.Tools.Add(this.gridBand1);
			this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
			// 
			// boxSeries1
			// 
			this.boxSeries1.AdjacentPoint1 = 1;
			this.boxSeries1.AdjacentPoint3 = 12;
			// 
			// boxSeries1.ExtrOut
			// 
			// 
			// boxSeries1.ExtrOut.Brush
			// 
			this.boxSeries1.ExtrOut.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.boxSeries1.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star;
			this.boxSeries1.ExtrOut.Visible = false;
			this.boxSeries1.InnerFence1 = -7.5;
			this.boxSeries1.InnerFence3 = 20.5;
			// 
			// boxSeries1.LinePen
			// 
			this.boxSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(124)), ((System.Byte)(21)), ((System.Byte)(10)));
			// 
			// boxSeries1.Marks
			// 
			// 
			// boxSeries1.Marks.Symbol
			// 
			// 
			// boxSeries1.Marks.Symbol.Shadow
			// 
			this.boxSeries1.Marks.Symbol.Shadow.Height = 1;
			this.boxSeries1.Marks.Symbol.Shadow.Visible = true;
			this.boxSeries1.Marks.Symbol.Shadow.Width = 1;
			this.boxSeries1.Median = 6.5;
			// 
			// boxSeries1.MedianPen
			// 
			this.boxSeries1.MedianPen.Style = Drawing.DashStyle.Dot;
			// 
			// boxSeries1.MildOut
			// 
			// 
			// boxSeries1.MildOut.Brush
			// 
			this.boxSeries1.MildOut.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.boxSeries1.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.boxSeries1.MildOut.Visible = false;
			this.boxSeries1.OuterFence1 = -18;
			this.boxSeries1.OuterFence3 = 31;
			// 
			// boxSeries1.Pointer
			// 
			// 
			// boxSeries1.Pointer.Brush
			// 
			this.boxSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(207)), ((System.Byte)(35)), ((System.Byte)(16)));
			this.boxSeries1.Pointer.Draw3D = false;
			this.boxSeries1.Pointer.HorizSize = 15;
			// 
			// boxSeries1.Pointer.Pen
			// 
			this.boxSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(124)), ((System.Byte)(21)), ((System.Byte)(10)));
			this.boxSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.boxSeries1.Pointer.VertSize = 15;
			this.boxSeries1.Quartile1 = 3;
			this.boxSeries1.Quartile3 = 10;
			this.boxSeries1.Title = "Dataset 1";
			// 
			// boxSeries1.XValues
			// 
			this.boxSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// boxSeries2
			// 
			this.boxSeries2.AdjacentPoint1 = 1;
			this.boxSeries2.AdjacentPoint3 = 19;
			// 
			// boxSeries2.ExtrOut
			// 
			// 
			// boxSeries2.ExtrOut.Brush
			// 
			this.boxSeries2.ExtrOut.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.boxSeries2.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star;
			this.boxSeries2.ExtrOut.Visible = false;
			this.boxSeries2.InnerFence1 = -10;
			this.boxSeries2.InnerFence3 = 30;
			// 
			// boxSeries2.LinePen
			// 
			this.boxSeries2.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(67)), ((System.Byte)(0)));
			// 
			// boxSeries2.Marks
			// 
			// 
			// boxSeries2.Marks.Symbol
			// 
			// 
			// boxSeries2.Marks.Symbol.Shadow
			// 
			this.boxSeries2.Marks.Symbol.Shadow.Height = 1;
			this.boxSeries2.Marks.Symbol.Shadow.Visible = true;
			this.boxSeries2.Marks.Symbol.Shadow.Width = 1;
			this.boxSeries2.Median = 10;
			// 
			// boxSeries2.MedianPen
			// 
			this.boxSeries2.MedianPen.Style = Drawing.DashStyle.Dot;
			// 
			// boxSeries2.MildOut
			// 
			// 
			// boxSeries2.MildOut.Brush
			// 
			this.boxSeries2.MildOut.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.boxSeries2.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.boxSeries2.MildOut.Visible = false;
			this.boxSeries2.OuterFence1 = -25;
			this.boxSeries2.OuterFence3 = 45;
			// 
			// boxSeries2.Pointer
			// 
			// 
			// boxSeries2.Pointer.Brush
			// 
			this.boxSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(111)), ((System.Byte)(0)));
			this.boxSeries2.Pointer.Draw3D = false;
			this.boxSeries2.Pointer.HorizSize = 15;
			// 
			// boxSeries2.Pointer.Pen
			// 
			this.boxSeries2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(67)), ((System.Byte)(0)));
			this.boxSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.boxSeries2.Pointer.VertSize = 15;
			this.boxSeries2.Position = 1;
			this.boxSeries2.Quartile1 = 5;
			this.boxSeries2.Quartile3 = 15;
			this.boxSeries2.Title = "Dataset 2";
			// 
			// boxSeries2.XValues
			// 
			this.boxSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// boxSeries3
			// 
			this.boxSeries3.AdjacentPoint1 = 2;
			this.boxSeries3.AdjacentPoint3 = 25;
			// 
			// boxSeries3.ExtrOut
			// 
			// 
			// boxSeries3.ExtrOut.Brush
			// 
			this.boxSeries3.ExtrOut.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.boxSeries3.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star;
			this.boxSeries3.ExtrOut.Visible = false;
			this.boxSeries3.InnerFence1 = -14.5;
			this.boxSeries3.InnerFence3 = 41.5;
			// 
			// boxSeries3.LinePen
			// 
			this.boxSeries3.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(134)), ((System.Byte)(134)), ((System.Byte)(0)));
			// 
			// boxSeries3.Marks
			// 
			// 
			// boxSeries3.Marks.Symbol
			// 
			// 
			// boxSeries3.Marks.Symbol.Shadow
			// 
			this.boxSeries3.Marks.Symbol.Shadow.Height = 1;
			this.boxSeries3.Marks.Symbol.Shadow.Visible = true;
			this.boxSeries3.Marks.Symbol.Shadow.Width = 1;
			this.boxSeries3.Median = 13.5;
			// 
			// boxSeries3.MedianPen
			// 
			this.boxSeries3.MedianPen.Style = Drawing.DashStyle.Dot;
			// 
			// boxSeries3.MildOut
			// 
			// 
			// boxSeries3.MildOut.Brush
			// 
			this.boxSeries3.MildOut.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.boxSeries3.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.boxSeries3.MildOut.Visible = false;
			this.boxSeries3.OuterFence1 = -35.5;
			this.boxSeries3.OuterFence3 = 62.5;
			// 
			// boxSeries3.Pointer
			// 
			// 
			// boxSeries3.Pointer.Brush
			// 
			this.boxSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(223)), ((System.Byte)(223)), ((System.Byte)(0)));
			this.boxSeries3.Pointer.Draw3D = false;
			this.boxSeries3.Pointer.HorizSize = 15;
			// 
			// boxSeries3.Pointer.Pen
			// 
			this.boxSeries3.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(134)), ((System.Byte)(134)), ((System.Byte)(0)));
			this.boxSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.boxSeries3.Pointer.VertSize = 15;
			this.boxSeries3.Position = 2;
			this.boxSeries3.Quartile1 = 6.5;
			this.boxSeries3.Quartile3 = 20.5;
			this.boxSeries3.Title = "Dataset 3";
			// 
			// boxSeries3.XValues
			// 
			this.boxSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 7);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_BoxPlot
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_BoxPlot";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			tChart1.ShowEditor();
		}

		private void tChart1_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}