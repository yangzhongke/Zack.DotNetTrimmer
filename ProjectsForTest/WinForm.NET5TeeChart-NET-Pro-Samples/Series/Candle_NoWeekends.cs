using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Candle_NoWeekends : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Candle candleSeries1;
		private System.ComponentModel.IContainer components = null;
		
		public Candle_NoWeekends()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			Random  r = new Random();
			candleSeries1.Clear();

			TeeChart.Styles.StringList labels = new TeeChart.Styles.StringList(10);
			labels.Add("07/02/2003");
			labels.Add("10/02/2003");
			labels.Add("11/02/2003");
			labels.Add("12/02/2003");
			labels.Add("13/02/2003");
			labels.Add("14/02/2003");
			labels.Add("17/02/2003");
			labels.Add("18/02/2003");
			labels.Add("19/02/2003");

			candleSeries1.XValues.DateTime = false;
			candleSeries1.GetHorizAxis.Labels.Angle = 90;

			double tmpOpen = r.Next(1000);
			double tmpClose;
			int count = 0;
			DateTime dt = DateTime.Parse("07/02/2003");
			TimeSpan ts = TimeSpan.FromDays(1);
			for (int t=0;t<13;t++) 
			{
				tmpOpen += r.Next(100) - 50.0;
				tmpClose = tmpOpen - r.Next(100) + 50.0;
				if(dt.DayOfWeek != DayOfWeek.Saturday & dt.DayOfWeek !=
					DayOfWeek.Sunday) 
				{
					++count;
					candleSeries1.Add(count,tmpOpen,tmpOpen + r.Next(10),
						tmpClose -r.Next(10),tmpClose);
				}
				dt += ts;
			}
			candleSeries1.Labels = labels;
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
			this.candleSeries1 = new Steema.TeeChart.Styles.Candle();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = @"When using Candle series with intraday data (default), the bottom axis automatically shows time labels.  But, when adding Candle points that have ""weekends"", it's necessary some code to display day / month labels correctly, without showing the weekend days.";
			// 
			// panel1
			// 
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
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy";
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(220)), ((System.Byte)(220)), ((System.Byte)(226)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(220)), ((System.Byte)(220)), ((System.Byte)(226)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.candleSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			// 
			// candleSeries1
			// 
			// 
			// candleSeries1.Brush
			// 
			this.candleSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.candleSeries1.CloseValues = this.candleSeries1.YValues;
			this.candleSeries1.DateValues = this.candleSeries1.XValues;
			this.candleSeries1.DownCloseColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// candleSeries1.LinePen
			// 
			this.candleSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// candleSeries1.Marks
			// 
			// 
			// candleSeries1.Marks.Symbol
			// 
			// 
			// candleSeries1.Marks.Symbol.Shadow
			// 
			this.candleSeries1.Marks.Symbol.Shadow.Height = 1;
			this.candleSeries1.Marks.Symbol.Shadow.Visible = true;
			this.candleSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// candleSeries1.Pointer
			// 
			// 
			// candleSeries1.Pointer.Brush
			// 
			this.candleSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.candleSeries1.Pointer.Draw3D = false;
			this.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candleSeries1.Title = "candle1";
			this.candleSeries1.UpCloseColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// candleSeries1.XValues
			// 
			this.candleSeries1.XValues.DataMember = "Date";
			this.candleSeries1.XValues.DateTime = true;
			this.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// candleSeries1.YValues
			// 
			this.candleSeries1.YValues.DataMember = "Close";
			// 
			// Candle_NoWeekends
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Candle_NoWeekends";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

