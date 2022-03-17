using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Axis_OpaqueZone : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Axis axis1;
		private Steema.TeeChart.Axis axis2;
		private Steema.TeeChart.Axis axis3;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Styles.Line lineSeries3;
		private Steema.TeeChart.Styles.Line lineSeries4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.ComponentModel.IContainer components = null;

		private void DoScroll(Steema.TeeChart.Styles.Series s)
		{
			double tmp = 0.01*((int)hScrollBar1.Value -50)*(s.YValues.Maximum - s.YValues.Minimum);
			s.GetVertAxis.SetMinMax(s.YValues.Maximum + tmp, s.YValues.Minimum + tmp);
		}

		public Axis_OpaqueZone()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

      hScrollBar1.Value=50;

      // Fill random values
			foreach (TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(20);

			// Set custom axes
			lineSeries1.VertAxis = TeeChart.Styles.VerticalAxis.Left;
			lineSeries2.CustomVertAxis = axis1;
			lineSeries3.CustomVertAxis = axis2;
			lineSeries4.CustomVertAxis = axis3;

			// Disable automatic clipping
			tChart1.Aspect.ClipPoints=false;


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
                        this.axis1 = new Steema.TeeChart.Axis(this.tChart1.Chart);
                        this.axis2 = new Steema.TeeChart.Axis(this.tChart1.Chart);
                        this.axis3 = new Steema.TeeChart.Axis(this.tChart1.Chart);
						this.lineSeries1 = new Steema.TeeChart.Styles.Line();
						this.lineSeries2 = new Steema.TeeChart.Styles.Line();
						this.lineSeries3 = new Steema.TeeChart.Styles.Line();
						this.lineSeries4 = new Steema.TeeChart.Styles.Line();
						this.checkBox1 = new System.Windows.Forms.CheckBox();
						this.label1 = new System.Windows.Forms.Label();
						this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
						this.panel1.SuspendLayout();
						this.SuspendLayout();
						// 
						// textBox1
						// 
						this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
						this.textBox1.Name = "textBox1";
						this.textBox1.Size = new System.Drawing.Size(504, 68);
						this.textBox1.Text = "When using multiple axes and doing zoom or scroll, series points can display outs" +
							"ide the axes \"zones\" or limits.\r\nYou can prevent this with a small code at Serie" +
							"s events: BeforeDrawValues and AfterDrawValues.";
						// 
						// panel1
						// 
						this.panel1.BackColor = System.Drawing.SystemColors.Control;
						this.panel1.Controls.Add(this.hScrollBar1);
						this.panel1.Controls.Add(this.label1);
						this.panel1.Controls.Add(this.checkBox1);
						this.panel1.Location = new System.Drawing.Point(0, 68);
						this.panel1.Name = "panel1";
						this.panel1.Size = new System.Drawing.Size(504, 36);
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
						// tChart1.Axes.Bottom.AxisPen
						// 
						this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
						this.tChart1.Axes.Bottom.AxisPen.Width = 1;
						// 
						// tChart1.Axes.Bottom.Labels
						// 
						// 
						// tChart1.Axes.Bottom.Labels.Font
						// 
						// 
						// tChart1.Axes.Bottom.Labels.Font.Shadow
						// 
						this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Bottom.Labels.Shadow
						// 
						this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
						// 
						// tChart1.Axes.Bottom.Title
						// 
						// 
						// tChart1.Axes.Bottom.Title.Font
						// 
						// 
						// tChart1.Axes.Bottom.Title.Font.Shadow
						// 
						this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Bottom.Title.Shadow
						// 
						this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
						this.tChart1.Axes.Custom.Add(this.axis1);
						this.tChart1.Axes.Custom.Add(this.axis2);
						this.tChart1.Axes.Custom.Add(this.axis3);
						// 
						// tChart1.Axes.Depth
						// 
						// 
						// tChart1.Axes.Depth.Labels
						// 
						// 
						// tChart1.Axes.Depth.Labels.Font
						// 
						// 
						// tChart1.Axes.Depth.Labels.Font.Shadow
						// 
						this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Depth.Labels.Shadow
						// 
						this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
						// 
						// tChart1.Axes.Depth.Title
						// 
						// 
						// tChart1.Axes.Depth.Title.Font
						// 
						// 
						// tChart1.Axes.Depth.Title.Font.Shadow
						// 
						this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Depth.Title.Shadow
						// 
						this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
						// 
						// tChart1.Axes.DepthTop
						// 
						// 
						// tChart1.Axes.DepthTop.Labels
						// 
						// 
						// tChart1.Axes.DepthTop.Labels.Font
						// 
						// 
						// tChart1.Axes.DepthTop.Labels.Font.Shadow
						// 
						this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.DepthTop.Labels.Shadow
						// 
						this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
						// 
						// tChart1.Axes.DepthTop.Title
						// 
						// 
						// tChart1.Axes.DepthTop.Title.Font
						// 
						// 
						// tChart1.Axes.DepthTop.Title.Font.Shadow
						// 
						this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.DepthTop.Title.Shadow
						// 
						this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
						// 
						// tChart1.Axes.Left
						// 
						// 
						// tChart1.Axes.Left.AxisPen
						// 
						this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
						this.tChart1.Axes.Left.EndPosition = 25;
						// 
						// tChart1.Axes.Left.Labels
						// 
						// 
						// tChart1.Axes.Left.Labels.Font
						// 
						// 
						// tChart1.Axes.Left.Labels.Font.Shadow
						// 
						this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Left.Labels.Shadow
						// 
						this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
						this.tChart1.Axes.Left.LogarithmicBase = 2;
						// 
						// tChart1.Axes.Left.Title
						// 
						// 
						// tChart1.Axes.Left.Title.Font
						// 
						// 
						// tChart1.Axes.Left.Title.Font.Shadow
						// 
						this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Left.Title.Shadow
						// 
						this.tChart1.Axes.Left.Title.Shadow.Visible = false;
						// 
						// tChart1.Axes.Right
						// 
						// 
						// tChart1.Axes.Right.Labels
						// 
						// 
						// tChart1.Axes.Right.Labels.Font
						// 
						// 
						// tChart1.Axes.Right.Labels.Font.Shadow
						// 
						this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Right.Labels.Shadow
						// 
						this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
						// 
						// tChart1.Axes.Right.Title
						// 
						// 
						// tChart1.Axes.Right.Title.Font
						// 
						// 
						// tChart1.Axes.Right.Title.Font.Shadow
						// 
						this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Right.Title.Shadow
						// 
						this.tChart1.Axes.Right.Title.Shadow.Visible = false;
						// 
						// tChart1.Axes.Top
						// 
						// 
						// tChart1.Axes.Top.Labels
						// 
						// 
						// tChart1.Axes.Top.Labels.Font
						// 
						// 
						// tChart1.Axes.Top.Labels.Font.Shadow
						// 
						this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Top.Labels.Shadow
						// 
						this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
						// 
						// tChart1.Axes.Top.Title
						// 
						// 
						// tChart1.Axes.Top.Title.Font
						// 
						// 
						// tChart1.Axes.Top.Title.Font.Shadow
						// 
						this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
						// 
						// tChart1.Axes.Top.Title.Shadow
						// 
						this.tChart1.Axes.Top.Title.Shadow.Visible = false;
						// 
						// tChart1.Footer
						// 
						// 
						// tChart1.Footer.Font
						// 
						// 
						// tChart1.Footer.Font.Shadow
						// 
						this.tChart1.Footer.Font.Shadow.Visible = false;
						// 
						// tChart1.Footer.Shadow
						// 
						this.tChart1.Footer.Shadow.Visible = false;
						// 
						// tChart1.Header
						// 
						// 
						// tChart1.Header.Font
						// 
						// 
						// tChart1.Header.Font.Brush
						// 
						this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
						this.tChart1.Header.Font.Name = "Verdana";
						// 
						// tChart1.Header.Font.Shadow
						// 
						// 
						// tChart1.Header.Font.Shadow.Brush
						// 
						this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
						this.tChart1.Header.Lines = new string[] {
																											 "Opaque Zone"};
						// 
						// tChart1.Header.Shadow
						// 
						this.tChart1.Header.Shadow.Visible = false;
						// 
						// tChart1.Legend
						// 
						this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
						this.tChart1.Legend.BorderRound = 8;
						// 
						// tChart1.Legend.Font
						// 
						// 
						// tChart1.Legend.Font.Shadow
						// 
						this.tChart1.Legend.Font.Shadow.Visible = false;
						// 
						// tChart1.Legend.Shadow
						// 
						this.tChart1.Legend.Shadow.Visible = false;
						this.tChart1.Legend.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
						// 
						// tChart1.Legend.Symbol
						// 
						this.tChart1.Legend.Symbol.Visible = false;
						// 
						// tChart1.Legend.Title
						// 
						// 
						// tChart1.Legend.Title.Font
						// 
						this.tChart1.Legend.Title.Font.Bold = true;
						// 
						// tChart1.Legend.Title.Font.Shadow
						// 
						this.tChart1.Legend.Title.Font.Shadow.Visible = false;
						// 
						// tChart1.Legend.Title.Pen
						// 
						this.tChart1.Legend.Title.Pen.Visible = false;
						// 
						// tChart1.Legend.Title.Shadow
						// 
						this.tChart1.Legend.Title.Shadow.Visible = false;
						this.tChart1.Location = new System.Drawing.Point(0, 104);
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
						this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
						this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
						this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
						this.tChart1.Panel.Brush.Gradient.Visible = true;
						// 
						// tChart1.Panel.Gradient
						// 
						this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
						this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
						this.tChart1.Panel.Gradient.UseMiddle = true;
						this.tChart1.Panel.Gradient.Visible = true;
						// 
						// tChart1.Panel.Shadow
						// 
						this.tChart1.Panel.Shadow.Visible = false;
						this.tChart1.Series.Add(this.lineSeries1);
						this.tChart1.Series.Add(this.lineSeries2);
						this.tChart1.Series.Add(this.lineSeries3);
						this.tChart1.Series.Add(this.lineSeries4);
						this.tChart1.Size = new System.Drawing.Size(504, 301);
						// 
						// tChart1.SubFooter
						// 
						// 
						// tChart1.SubFooter.Font
						// 
						// 
						// tChart1.SubFooter.Font.Shadow
						// 
						this.tChart1.SubFooter.Font.Shadow.Visible = false;
						// 
						// tChart1.SubFooter.Shadow
						// 
						this.tChart1.SubFooter.Shadow.Visible = false;
						// 
						// tChart1.SubHeader
						// 
						// 
						// tChart1.SubHeader.Font
						// 
						// 
						// tChart1.SubHeader.Font.Shadow
						// 
						this.tChart1.SubHeader.Font.Shadow.Visible = false;
						// 
						// tChart1.SubHeader.Shadow
						// 
						this.tChart1.SubHeader.Shadow.Visible = false;
						// 
						// tChart1.Walls
						// 
						// 
						// tChart1.Walls.Back
						// 
						// 
						// tChart1.Walls.Back.Brush
						// 
						this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
						// 
						// tChart1.Walls.Back.Gradient
						// 
						this.tChart1.Walls.Back.Brush.Gradient.Transparency = 50;
						// 
						// tChart1.Walls.Back.Gradient
						// 
						this.tChart1.Walls.Back.Gradient.Transparency = 50;
						// 
						// tChart1.Walls.Back.Pen
						// 
						this.tChart1.Walls.Back.Pen.Visible = false;
						// 
						// tChart1.Walls.Back.Shadow
						// 
						this.tChart1.Walls.Back.Shadow.Visible = false;
						this.tChart1.Walls.Back.Transparent = false;
						// 
						// tChart1.Walls.Bottom
						// 
						// 
						// tChart1.Walls.Bottom.Shadow
						// 
						this.tChart1.Walls.Bottom.Shadow.Visible = false;
						// 
						// tChart1.Walls.Left
						// 
						// 
						// tChart1.Walls.Left.Shadow
						// 
						this.tChart1.Walls.Left.Shadow.Visible = false;
						// 
						// tChart1.Walls.Right
						// 
						// 
						// tChart1.Walls.Right.Shadow
						// 
						this.tChart1.Walls.Right.Shadow.Visible = false;
						this.tChart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseDown);
						this.tChart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseUp);
						this.tChart1.Zoomed += new System.EventHandler(this.tChart1_Zoomed);
						this.tChart1.UndoneZoom += new System.EventHandler(this.tChart1_UndoneZoom);
						// 
						// axis1
						// 
						// 
						// axis1.AxisPen
						// 
						this.axis1.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(192)), ((System.Byte)(0)));
						this.axis1.EndPosition = 50;
						this.axis1.Horizontal = false;
						// 
						// axis1.Labels
						// 
						// 
						// axis1.Labels.Font
						// 
						// 
						// axis1.Labels.Font.Shadow
						// 
						this.axis1.Labels.Font.Shadow.Visible = false;
						// 
						// axis1.Labels.Shadow
						// 
						this.axis1.Labels.Shadow.Visible = false;
						this.axis1.OtherSide = false;
						this.axis1.StartPosition = 25;
						// 
						// axis1.Title
						// 
						// 
						// axis1.Title.Font
						// 
						// 
						// axis1.Title.Font.Shadow
						// 
						this.axis1.Title.Font.Shadow.Visible = false;
						// 
						// axis1.Title.Shadow
						// 
						this.axis1.Title.Shadow.Visible = false;
						// 
						// axis2
						// 
						// 
						// axis2.AxisPen
						// 
						this.axis2.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
						this.axis2.EndPosition = 75;
						this.axis2.Horizontal = false;
						// 
						// axis2.Labels
						// 
						// 
						// axis2.Labels.Font
						// 
						// 
						// axis2.Labels.Font.Shadow
						// 
						this.axis2.Labels.Font.Shadow.Visible = false;
						// 
						// axis2.Labels.Shadow
						// 
						this.axis2.Labels.Shadow.Visible = false;
						this.axis2.OtherSide = false;
						this.axis2.StartPosition = 50;
						// 
						// axis2.Title
						// 
						// 
						// axis2.Title.Font
						// 
						// 
						// axis2.Title.Font.Shadow
						// 
						this.axis2.Title.Font.Shadow.Visible = false;
						// 
						// axis2.Title.Shadow
						// 
						this.axis2.Title.Shadow.Visible = false;
						// 
						// axis3
						// 
						// 
						// axis3.AxisPen
						// 
						this.axis3.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
						this.axis3.Horizontal = false;
						// 
						// axis3.Labels
						// 
						// 
						// axis3.Labels.Font
						// 
						// 
						// axis3.Labels.Font.Shadow
						// 
						this.axis3.Labels.Font.Shadow.Visible = false;
						// 
						// axis3.Labels.Shadow
						// 
						this.axis3.Labels.Shadow.Visible = false;
						this.axis3.OtherSide = false;
						this.axis3.StartPosition = 75;
						// 
						// axis3.Title
						// 
						// 
						// axis3.Title.Font
						// 
						// 
						// axis3.Title.Font.Shadow
						// 
						this.axis3.Title.Font.Shadow.Visible = false;
						// 
						// axis3.Title.Shadow
						// 
						this.axis3.Title.Shadow.Visible = false;
						// 
						// lineSeries1
						// 
						// 
						// lineSeries1.Brush
						// 
						this.lineSeries1.Brush.Color = System.Drawing.Color.Red;
						this.lineSeries1.Cursor = Drawing.Cursors.Cross;
						// 
						// lineSeries1.Marks
						// 
						// 
						// lineSeries1.Marks.Callout
						// 
						this.lineSeries1.Marks.Callout.Arrow = this.lineSeries1.Marks.Arrow;
						this.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
						this.lineSeries1.Marks.Callout.ArrowHeadSize = 8;
						// 
						// lineSeries1.Marks.Callout.Brush
						// 
						this.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
						this.lineSeries1.Marks.Callout.Distance = 0;
						this.lineSeries1.Marks.Callout.Draw3D = false;
						this.lineSeries1.Marks.Callout.Length = 10;
						this.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						// 
						// lineSeries1.Marks.Font
						// 
						// 
						// lineSeries1.Marks.Font.Shadow
						// 
						this.lineSeries1.Marks.Font.Shadow.Visible = false;
						// 
						// lineSeries1.Pointer
						// 
						this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						this.lineSeries1.Title = "lineSeries1";
						// 
						// lineSeries1.XValues
						// 
						this.lineSeries1.XValues.DataMember = "X";
						this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
						// 
						// lineSeries1.YValues
						// 
						this.lineSeries1.YValues.DataMember = "Y";
						this.lineSeries1.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.lineSeries1_BeforeDrawValues);
						this.lineSeries1.AfterDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.lineSeries1_AfterDrawValues);
						// 
						// lineSeries2
						// 
						// 
						// lineSeries2.Brush
						// 
						this.lineSeries2.Brush.Color = System.Drawing.Color.Green;
						this.lineSeries2.Cursor = Drawing.Cursors.Cross;
						// 
						// lineSeries2.Marks
						// 
						// 
						// lineSeries2.Marks.Callout
						// 
						this.lineSeries2.Marks.Callout.Arrow = this.lineSeries2.Marks.Arrow;
						this.lineSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
						this.lineSeries2.Marks.Callout.ArrowHeadSize = 8;
						// 
						// lineSeries2.Marks.Callout.Brush
						// 
						this.lineSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
						this.lineSeries2.Marks.Callout.Distance = 0;
						this.lineSeries2.Marks.Callout.Draw3D = false;
						this.lineSeries2.Marks.Callout.Length = 10;
						this.lineSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						// 
						// lineSeries2.Marks.Font
						// 
						// 
						// lineSeries2.Marks.Font.Shadow
						// 
						this.lineSeries2.Marks.Font.Shadow.Visible = false;
						// 
						// lineSeries2.Pointer
						// 
						this.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						this.lineSeries2.Title = "lineSeries2";
						// 
						// lineSeries2.XValues
						// 
						this.lineSeries2.XValues.DataMember = "X";
						this.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
						// 
						// lineSeries2.YValues
						// 
						this.lineSeries2.YValues.DataMember = "Y";
						this.lineSeries2.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.lineSeries1_BeforeDrawValues);
						this.lineSeries2.AfterDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.lineSeries1_AfterDrawValues);
						// 
						// lineSeries3
						// 
						// 
						// lineSeries3.Brush
						// 
						this.lineSeries3.Brush.Color = System.Drawing.Color.Yellow;
						this.lineSeries3.Cursor = Drawing.Cursors.Cross;
						// 
						// lineSeries3.Marks
						// 
						// 
						// lineSeries3.Marks.Callout
						// 
						this.lineSeries3.Marks.Callout.Arrow = this.lineSeries3.Marks.Arrow;
						this.lineSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
						this.lineSeries3.Marks.Callout.ArrowHeadSize = 8;
						// 
						// lineSeries3.Marks.Callout.Brush
						// 
						this.lineSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
						this.lineSeries3.Marks.Callout.Distance = 0;
						this.lineSeries3.Marks.Callout.Draw3D = false;
						this.lineSeries3.Marks.Callout.Length = 10;
						this.lineSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						// 
						// lineSeries3.Marks.Font
						// 
						// 
						// lineSeries3.Marks.Font.Shadow
						// 
						this.lineSeries3.Marks.Font.Shadow.Visible = false;
						// 
						// lineSeries3.Pointer
						// 
						this.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						this.lineSeries3.Title = "lineSeries3";
						// 
						// lineSeries3.XValues
						// 
						this.lineSeries3.XValues.DataMember = "X";
						this.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
						// 
						// lineSeries3.YValues
						// 
						this.lineSeries3.YValues.DataMember = "Y";
						this.lineSeries3.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.lineSeries1_BeforeDrawValues);
						this.lineSeries3.AfterDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.lineSeries1_AfterDrawValues);
						// 
						// lineSeries4
						// 
						// 
						// lineSeries4.Brush
						// 
						this.lineSeries4.Brush.Color = System.Drawing.Color.Blue;
						this.lineSeries4.Cursor = Drawing.Cursors.Cross;
						// 
						// lineSeries4.Marks
						// 
						// 
						// lineSeries4.Marks.Callout
						// 
						this.lineSeries4.Marks.Callout.Arrow = this.lineSeries4.Marks.Arrow;
						this.lineSeries4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
						this.lineSeries4.Marks.Callout.ArrowHeadSize = 8;
						// 
						// lineSeries4.Marks.Callout.Brush
						// 
						this.lineSeries4.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
						this.lineSeries4.Marks.Callout.Distance = 0;
						this.lineSeries4.Marks.Callout.Draw3D = false;
						this.lineSeries4.Marks.Callout.Length = 10;
						this.lineSeries4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						// 
						// lineSeries4.Marks.Font
						// 
						// 
						// lineSeries4.Marks.Font.Shadow
						// 
						this.lineSeries4.Marks.Font.Shadow.Visible = false;
						// 
						// lineSeries4.Pointer
						// 
						this.lineSeries4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						this.lineSeries4.Title = "lineSeries4";
						// 
						// lineSeries4.XValues
						// 
						this.lineSeries4.XValues.DataMember = "X";
						this.lineSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
						// 
						// lineSeries4.YValues
						// 
						this.lineSeries4.YValues.DataMember = "Y";
						this.lineSeries4.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.lineSeries1_BeforeDrawValues);
						this.lineSeries4.AfterDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.lineSeries1_AfterDrawValues);
						// 
						// checkBox1
						// 
						this.checkBox1.Checked = true;
						this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
						this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						this.checkBox1.Location = new System.Drawing.Point(16, 8);
						this.checkBox1.Name = "checkBox1";
						this.checkBox1.Size = new System.Drawing.Size(112, 20);
						this.checkBox1.TabIndex = 0;
						this.checkBox1.Text = "&Opaque zones";
						this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(128, 12);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(36, 16);
						this.label1.TabIndex = 1;
						this.label1.Text = "&Scroll:";
						this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
						// 
						// hScrollBar1
						// 
						this.hScrollBar1.Location = new System.Drawing.Point(168, 8);
						this.hScrollBar1.Name = "hScrollBar1";
						this.hScrollBar1.Size = new System.Drawing.Size(123, 18);
						this.hScrollBar1.TabIndex = 2;
						this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
						// 
						// Axis_OpaqueZone
						// 
						this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
						this.ClientSize = new System.Drawing.Size(504, 405);
						this.Name = "Axis_OpaqueZone";
						this.panel1.ResumeLayout(false);
						this.ResumeLayout(false);

					}
		#endregion

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			DoScroll(lineSeries1);
			DoScroll(lineSeries2);
			DoScroll(lineSeries3);
			DoScroll(lineSeries4);
		}

		private void lineSeries1_BeforeDrawValues(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			//  make opaque
			if (checkBox1.Checked)
			{
				Steema.TeeChart.Styles.Series s = sender as Steema.TeeChart.Styles.Series;

				int left = s.GetHorizAxis.IStartPos;
        int right = s.GetHorizAxis.IEndPos;
        int top = s.GetVertAxis.IStartPos;
				int bottom = s.GetVertAxis.IEndPos;
				tChart1.Graphics3D.ClipRectangle(left,top,right,bottom);
			}
		}

		private void lineSeries1_AfterDrawValues(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			if (checkBox1.Checked)
				tChart1.Graphics3D.ClearClipRegions();
		}

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      tChart1.Invalidate();
    }

    private bool zoomed=false;

    private void tChart1_Zoomed(object sender, System.EventArgs e)
    {
      zoomed=true;
    }

    private int MouseXDown;
    private int MouseYDown;
    private int MouseXUp;
    private int MouseYUp;

    private void tChart1_MouseDown(object sender, MouseEventArgs e)
    {
      MouseXDown=e.X;
      MouseYDown=e.Y;
    }

    private void tChart1_UndoneZoom(object sender, System.EventArgs e)
    {
      zoomed=false;
      lineSeries2.CustomVertAxis.Automatic=true;
      lineSeries3.CustomVertAxis.Automatic=true;
      lineSeries4.CustomVertAxis.Automatic=true;
    }

    private void tChart1_MouseUp(object sender, MouseEventArgs e)
    {
      if (zoomed)
      {
        MouseXUp=e.X;
        MouseYUp=e.Y;

        double max=lineSeries2.YScreenToValue(MouseYDown);
        double min=lineSeries2.YScreenToValue(MouseYUp);
        lineSeries2.CustomVertAxis.SetMinMax(min,max);

        max=lineSeries3.YScreenToValue(MouseYDown);
        min=lineSeries3.YScreenToValue(MouseYUp);
        lineSeries3.CustomVertAxis.SetMinMax(min,max);

        max=lineSeries4.YScreenToValue(MouseYDown);
        min=lineSeries4.YScreenToValue(MouseYUp);
        lineSeries4.CustomVertAxis.SetMinMax(min,max);
      }
    }
	}
}

