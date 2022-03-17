using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Function_ADX : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown UDPeriod;
		private Steema.TeeChart.Styles.Candle candle1;
		private Steema.TeeChart.Axis axis1;
		private Steema.TeeChart.Functions.ADXFunction adxFunction1;
		private Steema.TeeChart.Styles.Line line1;
		private System.ComponentModel.IContainer components = null;

		public Function_ADX()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			UDPeriod.Value = Convert.ToDecimal(adxFunction1.Period );
			candle1.FillSampleValues(300);
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_ADX));
			this.label1 = new System.Windows.Forms.Label();
			this.UDPeriod = new System.Windows.Forms.NumericUpDown();
			this.candle1 = new Steema.TeeChart.Styles.Candle();
			this.axis1 = new Steema.TeeChart.Axis(this.components);
			this.adxFunction1 = new Steema.TeeChart.Functions.ADXFunction();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UDPeriod)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.UDPeriod);
			this.panel1.Controls.Add(this.label1);
			// 
			// tChart1
			// 
			// 
			// 
			// 
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
			this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.MaximumOffset = 5;
			this.tChart1.Axes.Bottom.MinimumOffset = 5;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.TicksInner.Visible = true;
			this.tChart1.Axes.Custom.Add(this.axis1);
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Depth.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.DepthTop.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Left.EndPosition = 55;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.MaximumOffset = 5;
			this.tChart1.Axes.Left.MinimumOffset = 5;
			// 
			// 
			// 
			this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Left.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Right.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Top.TicksInner.Visible = true;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Header.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Header.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.tChart1.Legend.Brush.Gradient.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Legend.Pen.Visible = false;
			this.tChart1.Legend.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Series.Add(this.candle1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Series.Add(this.adxFunction1.DMUp);
			this.tChart1.Series.Add(this.adxFunction1.DMDown);
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			// 
			// 
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			// 
			// 
			// 
			this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Walls.Right.Pen.Visible = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Period:";
			// 
			// UDPeriod
			// 
			this.UDPeriod.Location = new System.Drawing.Point(63, 10);
			this.UDPeriod.Name = "UDPeriod";
			this.UDPeriod.Size = new System.Drawing.Size(79, 20);
			this.UDPeriod.TabIndex = 1;
			this.UDPeriod.ValueChanged += new System.EventHandler(this.UDPeriod_ValueChanged);
			// 
			// candle1
			// 
			// 
			// 
			// 
			this.candle1.Brush.Color = System.Drawing.Color.White;
			this.candle1.CloseValues = this.candle1.YValues;
			this.candle1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.candle1.ColorEach = false;
			this.candle1.DateValues = this.candle1.XValues;
			// 
			// 
			// 
			this.candle1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.candle1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.candle1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.candle1.Marks.Brush.Gradient.SigmaFocus = 0F;
			this.candle1.Marks.Brush.Gradient.SigmaScale = 0F;
			this.candle1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.candle1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.candle1.Marks.Callout.Distance = 0;
			this.candle1.Marks.Callout.Draw3D = false;
			this.candle1.Marks.Callout.Length = 10;
			this.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.candle1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.candle1.Marks.Transparent = true;
			// 
			// 
			// 
			this.candle1.Pointer.Draw3D = false;
			this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Title = "candle1";
			// 
			// 
			// 
			this.candle1.XValues.DataMember = "Date";
			this.candle1.XValues.DateTime = true;
			this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.candle1.YValues.DataMember = "Close";
			// 
			// axis1
			// 
			// 
			// 
			// 
			this.axis1.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.axis1.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.axis1.Grid.Style = Drawing.DashStyle.Solid;
			this.axis1.Horizontal = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.axis1.MinorTicks.Color = System.Drawing.Color.Black;
			this.axis1.MinorTicks.Visible = false;
			this.axis1.OtherSide = false;
			this.axis1.StartPosition = 61;
			// 
			// 
			// 
			this.axis1.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.axis1.TicksInner.Visible = true;
			// 
			// adxFunction1
			// 
			// 
			// 
			// 
			this.adxFunction1.DMDown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
			this.adxFunction1.DMDown.ColorEach = false;
			this.adxFunction1.DMDown.CustomVertAxis = this.axis1;
			// 
			// 
			// 
			this.adxFunction1.DMDown.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.adxFunction1.DMDown.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.adxFunction1.DMDown.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.adxFunction1.DMDown.Marks.Brush.Gradient.SigmaFocus = 0F;
			this.adxFunction1.DMDown.Marks.Brush.Gradient.SigmaScale = 0F;
			this.adxFunction1.DMDown.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.adxFunction1.DMDown.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.adxFunction1.DMDown.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.adxFunction1.DMDown.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.adxFunction1.DMDown.Marks.Callout.Distance = 0;
			this.adxFunction1.DMDown.Marks.Callout.Draw3D = false;
			this.adxFunction1.DMDown.Marks.Callout.Length = 10;
			this.adxFunction1.DMDown.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.adxFunction1.DMDown.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.adxFunction1.DMDown.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.adxFunction1.DMDown.Marks.Transparent = true;
			this.adxFunction1.DMDown.Legend.Visible = false;
			this.adxFunction1.DMDown.Title = "DMDown";
			this.adxFunction1.DMDown.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			this.adxFunction1.DMDown.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.adxFunction1.DMDown.XValues.DataMember = "X";
			this.adxFunction1.DMDown.XValues.DateTime = true;
			this.adxFunction1.DMDown.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.adxFunction1.DMDown.YValues.DataMember = "Y";
			// 
			// 
			// 
			this.adxFunction1.DMUp.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			this.adxFunction1.DMUp.ColorEach = false;
			this.adxFunction1.DMUp.CustomVertAxis = this.axis1;
			// 
			// 
			// 
			this.adxFunction1.DMUp.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.adxFunction1.DMUp.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.adxFunction1.DMUp.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.adxFunction1.DMUp.Marks.Brush.Gradient.SigmaFocus = 0F;
			this.adxFunction1.DMUp.Marks.Brush.Gradient.SigmaScale = 0F;
			this.adxFunction1.DMUp.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.adxFunction1.DMUp.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.adxFunction1.DMUp.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.adxFunction1.DMUp.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.adxFunction1.DMUp.Marks.Callout.Distance = 0;
			this.adxFunction1.DMUp.Marks.Callout.Draw3D = false;
			this.adxFunction1.DMUp.Marks.Callout.Length = 10;
			this.adxFunction1.DMUp.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.adxFunction1.DMUp.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.adxFunction1.DMUp.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.adxFunction1.DMUp.Marks.Transparent = true;
			this.adxFunction1.DMUp.Legend.Visible = false;
			this.adxFunction1.DMUp.Title = "DMUp";
			this.adxFunction1.DMUp.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			this.adxFunction1.DMUp.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.adxFunction1.DMUp.XValues.DataMember = "X";
			this.adxFunction1.DMUp.XValues.DateTime = true;
			this.adxFunction1.DMUp.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.adxFunction1.DMUp.YValues.DataMember = "Y";
			this.adxFunction1.Period = 14;
			// 
			// line1
			// 
			// 
			// 
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.line1.ColorEach = false;
			this.line1.CustomVertAxis = this.axis1;
			this.line1.DataSource = this.candle1;
			this.line1.Function = this.adxFunction1;
			// 
			// 
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.line1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.line1.Marks.Brush.Gradient.SigmaFocus = 0F;
			this.line1.Marks.Brush.Gradient.SigmaScale = 0F;
			this.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.line1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.line1.Marks.Callout.Distance = 0;
			this.line1.Marks.Callout.Draw3D = false;
			this.line1.Marks.Callout.Length = 10;
			this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.line1.Marks.Transparent = true;
			// 
			// 
			// 
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "line1";
			this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.line1.XValues.DateTime = true;
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.line1.YValues.DataMember = "Close";
			// 
			// Function_ADX
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Function_ADX";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UDPeriod)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void UDPeriod_ValueChanged(object sender, System.EventArgs e)
		{
			adxFunction1.Period = Convert.ToDouble(UDPeriod.Value);
		}
	}
}

