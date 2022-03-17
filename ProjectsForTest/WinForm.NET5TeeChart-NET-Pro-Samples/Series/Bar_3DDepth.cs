using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Bar3DDepth : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar bar1;
		private Steema.TeeChart.Styles.Bar bar2;
		private Steema.TeeChart.Styles.Bar bar3;
		private Steema.TeeChart.Styles.Bar bar4;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Bar3DDepth()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			for(int i=0; i<tChart1.Series.Count; ++i) {
				tChart1.Series[i].FillSampleValues();
			}

			hScrollBar1.Value=bar1.DepthPercent;
			hScrollBar2.Value=bar1.BarWidthPercent;

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
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.bar2 = new Steema.TeeChart.Styles.Bar();
			this.bar3 = new Steema.TeeChart.Styles.Bar();
			this.bar4 = new Steema.TeeChart.Styles.Bar();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The Bar and Horizontal bar series \"DepthPercent\" property controls the\r\nsize of b" +
				"ars in 3D (Z depth) direction.\r\n\r\nbar1.DepthPercent = 50 ;   // % of 3D depth";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.hScrollBar2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 65;
			this.tChart1.Aspect.Elevation = 353;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 34;
			this.tChart1.Aspect.Rotation = 302;
			
			
			this.tChart1.Aspect.ThemeIndex = 1;
			this.tChart1.Aspect.Zoom = 79;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.AxisPen
			// 
			this.tChart1.Axes.Bottom.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Centered = true;
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
			this.tChart1.Axes.Bottom.Grid.Visible = false;
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Bold = true;
			this.tChart1.Axes.Bottom.Labels.Font.Size = 11;
			// 
			// tChart1.Axes.Bottom.MinorGrid
			// 
			this.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(((System.Byte)(229)), ((System.Byte)(229)), ((System.Byte)(229)));
			// 
			// tChart1.Axes.Bottom.MinorTicks
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.Ticks.Length = 2;
			// 
			// tChart1.Axes.Bottom.TicksInner
			// 
			this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			this.tChart1.Axes.Depth.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Depth.MinorTicks
			// 
			this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			// 
			// tChart1.Axes.Depth.TicksInner
			// 
			this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			this.tChart1.Axes.Left.Labels.Font.Bold = true;
			this.tChart1.Axes.Left.Labels.Font.Size = 11;
			// 
			// tChart1.Axes.Left.MinorTicks
			// 
			this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.Ticks.Length = 2;
			// 
			// tChart1.Axes.Left.TicksInner
			// 
			this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			this.tChart1.Axes.Right.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Right.MinorTicks
			// 
			this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Ticks.Length = 2;
			// 
			// tChart1.Axes.Right.TicksInner
			// 
			this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			this.tChart1.Axes.Top.Grid.Visible = false;
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			this.tChart1.Axes.Top.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Top.MinorTicks
			// 
			this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Ticks.Length = 2;
			// 
			// tChart1.Axes.Top.TicksInner
			// 
			this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.TicksInner.Visible = false;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.Black;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Black;
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(64)));
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Brush.Gradient.UseMiddle = true;
			this.tChart1.Header.Brush.Gradient.Visible = true;
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Header.Font.Size = 10;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Black;
			this.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(64)));
			this.tChart1.Header.Gradient.StartColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Gradient.UseMiddle = true;
			this.tChart1.Header.Gradient.Visible = true;
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Header.Pen
			// 
			this.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(221)), ((System.Byte)(251)));
			this.tChart1.Header.Pen.Width = 2;
			// 
			// tChart1.Header.Shadow
			// 
			// 
			// tChart1.Header.Shadow.Brush
			// 
			this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(169)), ((System.Byte)(169)), ((System.Byte)(169)));
			this.tChart1.Header.Shadow.Height = 4;
			this.tChart1.Header.Shadow.Width = 4;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Legend.Brush.Gradient.Visible = true;
			this.tChart1.Legend.Brush.Visible = false;
			// 
			// tChart1.Legend.DividingLines
			// 
			this.tChart1.Legend.DividingLines.Color = System.Drawing.Color.Silver;
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Brush
			// 
			this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(100)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Font.Size = 10;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Legend.Gradient.Visible = true;
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(169)), ((System.Byte)(169)), ((System.Byte)(169)));
			this.tChart1.Legend.Shadow.Height = 0;
			this.tChart1.Legend.Shadow.Width = 0;
			// 
			// tChart1.Legend.Symbol
			// 
			// 
			// tChart1.Legend.Symbol.Pen
			// 
			this.tChart1.Legend.Symbol.Pen.Visible = false;
			this.tChart1.Legend.Symbol.Squared = true;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Pen
			// 
			this.tChart1.Panel.Pen.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			// 
			// tChart1.Panel.Shadow.Brush
			// 
			this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Visible = true;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Series.Add(this.bar2);
			this.tChart1.Series.Add(this.bar3);
			this.tChart1.Series.Add(this.bar4);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.ApplyDark = false;
			// 
			// tChart1.Walls.Back.Brush
			// 
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(122)), ((System.Byte)(41)));
			this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(122)), ((System.Byte)(41)));
			this.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Walls.Back.Pen.Visible = false;
			this.tChart1.Walls.Back.Size = 9;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.ApplyDark = false;
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(254)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(147)), ((System.Byte)(133)), ((System.Byte)(153)));
			this.tChart1.Walls.Bottom.Brush.Gradient.Visible = true;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(254)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(147)), ((System.Byte)(133)), ((System.Byte)(153)));
			this.tChart1.Walls.Bottom.Gradient.Visible = true;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 8;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.ApplyDark = false;
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(36)), ((System.Byte)(209)), ((System.Byte)(252)));
			this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(13)), ((System.Byte)(188)), ((System.Byte)(124)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(36)), ((System.Byte)(209)), ((System.Byte)(252)));
			this.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(13)), ((System.Byte)(188)), ((System.Byte)(124)));
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 9;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.ApplyDark = false;
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver;
			// 
			// tChart1.Walls.Right.Pen
			// 
			this.tChart1.Walls.Right.Pen.Color = System.Drawing.Color.DarkGray;
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(165)), ((System.Byte)(255)));
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Brush
			// 
			// 
			// bar1.Marks.Gradient
			// 
			this.bar1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// bar1.Marks.Font
			// 
			this.bar1.Marks.Font.Size = 11;
			// 
			// bar1.Marks.Gradient
			// 
			this.bar1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			this.bar1.Marks.Transparent = true;
			this.bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
			// 
			// bar1.Pen
			// 
			this.bar1.Pen.Visible = false;
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// bar2
			// 
			// 
			// bar2.Brush
			// 
			this.bar2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(206)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// bar2.Marks
			// 
			// 
			// bar2.Marks.Brush
			// 
			// 
			// bar2.Marks.Gradient
			// 
			this.bar2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// bar2.Marks.Font
			// 
			this.bar2.Marks.Font.Size = 11;
			// 
			// bar2.Marks.Gradient
			// 
			this.bar2.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// bar2.Marks.Symbol
			// 
			// 
			// bar2.Marks.Symbol.Shadow
			// 
			this.bar2.Marks.Symbol.Shadow.Height = 1;
			this.bar2.Marks.Symbol.Shadow.Visible = true;
			this.bar2.Marks.Symbol.Shadow.Width = 1;
			this.bar2.Marks.Transparent = true;
			this.bar2.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
			// 
			// bar2.Pen
			// 
			this.bar2.Pen.Visible = false;
			this.bar2.Title = "bar2";
			// 
			// bar2.XValues
			// 
			this.bar2.XValues.DataMember = "X";
			this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar2.YValues
			// 
			this.bar2.YValues.DataMember = "Bar";
			// 
			// bar3
			// 
			// 
			// bar3.Brush
			// 
			this.bar3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(206)), ((System.Byte)(0)));
			// 
			// bar3.Marks
			// 
			// 
			// bar3.Marks.Brush
			// 
			// 
			// bar3.Marks.Gradient
			// 
			this.bar3.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// bar3.Marks.Font
			// 
			this.bar3.Marks.Font.Size = 11;
			// 
			// bar3.Marks.Gradient
			// 
			this.bar3.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// bar3.Marks.Symbol
			// 
			// 
			// bar3.Marks.Symbol.Shadow
			// 
			this.bar3.Marks.Symbol.Shadow.Height = 1;
			this.bar3.Marks.Symbol.Shadow.Visible = true;
			this.bar3.Marks.Symbol.Shadow.Width = 1;
			this.bar3.Marks.Transparent = true;
			this.bar3.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
			// 
			// bar3.Pen
			// 
			this.bar3.Pen.Visible = false;
			this.bar3.Title = "bar3";
			// 
			// bar3.XValues
			// 
			this.bar3.XValues.DataMember = "X";
			this.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar3.YValues
			// 
			this.bar3.YValues.DataMember = "Bar";
			// 
			// bar4
			// 
			// 
			// bar4.Brush
			// 
			this.bar4.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// bar4.Marks
			// 
			// 
			// bar4.Marks.Brush
			// 
			// 
			// bar4.Marks.Gradient
			// 
			this.bar4.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// bar4.Marks.Font
			// 
			this.bar4.Marks.Font.Size = 11;
			// 
			// bar4.Marks.Gradient
			// 
			this.bar4.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// bar4.Marks.Symbol
			// 
			// 
			// bar4.Marks.Symbol.Shadow
			// 
			this.bar4.Marks.Symbol.Shadow.Height = 1;
			this.bar4.Marks.Symbol.Shadow.Visible = true;
			this.bar4.Marks.Symbol.Shadow.Width = 1;
			this.bar4.Marks.Transparent = true;
			this.bar4.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
			// 
			// bar4.Pen
			// 
			this.bar4.Pen.Visible = false;
			this.bar4.Title = "bar4";
			// 
			// bar4.XValues
			// 
			this.bar4.XValues.DataMember = "X";
			this.bar4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar4.YValues
			// 
			this.bar4.YValues.DataMember = "Bar";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(53, 13);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(155, 17);
			this.hScrollBar1.TabIndex = 0;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Depth:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(224, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Width:";
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(268, 14);
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(155, 17);
			this.hScrollBar2.TabIndex = 2;
			this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Bar3DDepth
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Bar3DDepth";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
			for(int i=0; i<tChart1.Series.Count; ++i) {
				(tChart1.Series[i] as Steema.TeeChart.Styles.Bar).DepthPercent = hScrollBar1.Value;
			}
		}

		private void hScrollBar2_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
			for(int i=0; i<tChart1.Series.Count; ++i) {
				(tChart1.Series[i] as Steema.TeeChart.Styles.Bar).BarWidthPercent = hScrollBar2.Value;
			}
		}
	}
}

