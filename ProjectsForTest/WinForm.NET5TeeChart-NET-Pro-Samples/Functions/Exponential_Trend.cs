using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Exponential_Trend : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private Steema.TeeChart.Styles.FastLine fastLine2;
		private Steema.TeeChart.Styles.FastLine fastLine3;
		private Steema.TeeChart.Functions.ExpTrendFunction expTrendFunction1;
		private Steema.TeeChart.Functions.TrendFunction trendFunction1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Exponential_Trend()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			fastLine1.FillSampleValues(100);

			// TODO: Add any initialization after the InitializeComponent call
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
						System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exponential_Trend));
						this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
						this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
						this.expTrendFunction1 = new Steema.TeeChart.Functions.ExpTrendFunction();
						this.fastLine3 = new Steema.TeeChart.Styles.FastLine();
						this.trendFunction1 = new Steema.TeeChart.Functions.TrendFunction();
						this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
						this.chartContainer.SuspendLayout();
						this.SuspendLayout();
						// 
						// textBox1
						// 
						this.textBox1.Text = "The Exponential Trend function is similar to Trend, except\r\nthe calculation fits " +
								"values using their exponential (e) weights.\r\nCompare it to the normal Trend clic" +
								"king the legend green series.";
						// 
						// tChart1
						// 
						// 
						// 
						// 
						this.tChart1.Aspect.ThemeIndex = 4;
						this.tChart1.Aspect.View3D = false;
						this.tChart1.Aspect.ZOffset = 0;
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
						this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
						this.tChart1.Axes.Bottom.Grid.Visible = false;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console";
						this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
						this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 10F;
						// 
						// 
						// 
						this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Bottom.MinorTicks.Length = -3;
						// 
						// 
						// 
						this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Bottom.Ticks.Length = 0;
						// 
						// 
						// 
						this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Bottom.TicksInner.Length = 6;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
						this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Depth.Labels.Font.Name = "Lucida Console";
						this.tChart1.Axes.Depth.Labels.Font.Size = 10;
						this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 10F;
						// 
						// 
						// 
						this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Depth.MinorTicks.Length = -3;
						// 
						// 
						// 
						this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Depth.Ticks.Length = 0;
						// 
						// 
						// 
						this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Depth.TicksInner.Length = 6;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
						this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Left.Labels.Font.Name = "Lucida Console";
						this.tChart1.Axes.Left.Labels.Font.Size = 10;
						this.tChart1.Axes.Left.Labels.Font.SizeFloat = 10F;
						// 
						// 
						// 
						this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Left.MinorTicks.Length = -3;
						// 
						// 
						// 
						this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Left.Ticks.Length = 0;
						// 
						// 
						// 
						this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Left.TicksInner.Length = 6;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
						this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Right.Labels.Font.Name = "Lucida Console";
						this.tChart1.Axes.Right.Labels.Font.Size = 10;
						this.tChart1.Axes.Right.Labels.Font.SizeFloat = 10F;
						// 
						// 
						// 
						this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Right.MinorTicks.Length = -3;
						// 
						// 
						// 
						this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Right.Ticks.Length = 0;
						// 
						// 
						// 
						this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Right.TicksInner.Length = 6;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
						this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
						this.tChart1.Axes.Top.Grid.Visible = false;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Axes.Top.Labels.Font.Name = "Lucida Console";
						this.tChart1.Axes.Top.Labels.Font.Size = 10;
						this.tChart1.Axes.Top.Labels.Font.SizeFloat = 10F;
						// 
						// 
						// 
						this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Top.MinorTicks.Length = -3;
						// 
						// 
						// 
						this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Top.Ticks.Length = 0;
						// 
						// 
						// 
						this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black;
						this.tChart1.Axes.Top.TicksInner.Length = 6;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Header.Font.Bold = true;
						// 
						// 
						// 
						this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
						this.tChart1.Header.Font.Name = "Lucida Console";
						this.tChart1.Header.Font.Size = 10;
						this.tChart1.Header.Font.SizeFloat = 10F;
						this.tChart1.Header.Visible = false;
						// 
						// 
						// 
						this.tChart1.Legend.CheckBoxes = true;
						// 
						// 
						// 
						this.tChart1.Legend.Font.Name = "Lucida Console";
						this.tChart1.Legend.Font.Size = 9;
						this.tChart1.Legend.Font.SizeFloat = 9F;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
						this.tChart1.Legend.Transparent = true;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
						// 
						// 
						// 
						this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
						// 
						// 
						// 
						this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
						this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
						this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
						this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
						// 
						// 
						// 
						this.tChart1.Panel.Pen.Visible = true;
						this.tChart1.Series.Add(this.fastLine1);
						this.tChart1.Series.Add(this.fastLine2);
						this.tChart1.Series.Add(this.fastLine3);
						this.tChart1.Size = new System.Drawing.Size(440, 205);
						this.tChart1.Tools.Add(this.gridBand1);
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
						// 
						// 
						// 
						// 
						// 
						// 
						this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
						// 
						// fastLine1
						// 
						this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(165)))), ((int)(((byte)(161)))));
						this.fastLine1.ColorEach = false;
						// 
						// 
						// 
						this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(165)))), ((int)(((byte)(161)))));
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						this.fastLine1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
						this.fastLine1.Marks.Brush.Gradient.Visible = true;
						// 
						// 
						// 
						this.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
						this.fastLine1.Marks.Callout.ArrowHeadSize = 8;
						// 
						// 
						// 
						this.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
						this.fastLine1.Marks.Callout.Distance = 0;
						this.fastLine1.Marks.Callout.Draw3D = false;
						this.fastLine1.Marks.Callout.Length = 10;
						this.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						this.fastLine1.Marks.Callout.Visible = false;
						// 
						// 
						// 
						this.fastLine1.Marks.Font.Name = "Lucida Console";
						this.fastLine1.Title = "Source";
						this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
						// 
						// 
						// 
						this.fastLine1.XValues.DataMember = "X";
						this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
						// 
						// 
						// 
						this.fastLine1.YValues.DataMember = "Y";
						// 
						// fastLine2
						// 
						this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(83)))), ((int)(((byte)(49)))));
						this.fastLine2.ColorEach = false;
						this.fastLine2.DataSource = this.fastLine1;
						this.fastLine2.Function = this.expTrendFunction1;
						// 
						// 
						// 
						this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(83)))), ((int)(((byte)(49)))));
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						this.fastLine2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
						this.fastLine2.Marks.Brush.Gradient.Visible = true;
						// 
						// 
						// 
						this.fastLine2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
						this.fastLine2.Marks.Callout.ArrowHeadSize = 8;
						// 
						// 
						// 
						this.fastLine2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
						this.fastLine2.Marks.Callout.Distance = 0;
						this.fastLine2.Marks.Callout.Draw3D = false;
						this.fastLine2.Marks.Callout.Length = 10;
						this.fastLine2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						this.fastLine2.Marks.Callout.Visible = false;
						// 
						// 
						// 
						this.fastLine2.Marks.Font.Name = "Lucida Console";
						this.fastLine2.Title = "Exp. Trend";
						this.fastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
						// 
						// 
						// 
						this.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
						// 
						// expTrendFunction1
						// 
						this.expTrendFunction1.TrendStyle = Steema.TeeChart.Functions.TrendStyles.Exponential;
						// 
						// fastLine3
						// 
						this.fastLine3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
						this.fastLine3.ColorEach = false;
						this.fastLine3.DataSource = this.fastLine1;
						this.fastLine3.Function = this.trendFunction1;
						// 
						// 
						// 
						this.fastLine3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						// 
						this.fastLine3.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
						this.fastLine3.Marks.Brush.Gradient.Visible = true;
						// 
						// 
						// 
						this.fastLine3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
						this.fastLine3.Marks.Callout.ArrowHeadSize = 8;
						// 
						// 
						// 
						this.fastLine3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
						this.fastLine3.Marks.Callout.Distance = 0;
						this.fastLine3.Marks.Callout.Draw3D = false;
						this.fastLine3.Marks.Callout.Length = 10;
						this.fastLine3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						this.fastLine3.Marks.Callout.Visible = false;
						// 
						// 
						// 
						this.fastLine3.Marks.Font.Name = "Lucida Console";
						this.fastLine3.Title = "Trend";
						this.fastLine3.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
						this.fastLine3.Visible = false;
						// 
						// 
						// 
						this.fastLine3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
						// 
						// gridBand1
						// 
						this.gridBand1.Axis = this.tChart1.Axes.Left;
						// 
						// 
						// 
						this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
						// 
						// 
						// 
						this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
						// 
						// ExpTrend
						// 
						this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
						this.ClientSize = new System.Drawing.Size(440, 317);
						this.Name = "ExpTrend";
						this.chartContainer.ResumeLayout(false);
						this.ResumeLayout(false);
						this.PerformLayout();

		}
		#endregion
	}
}

