using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
	public class ChartListBoxRadio : Steema.TeeChart.Samples.BaseNoChart {
		private System.Windows.Forms.Splitter splitter1;
		protected Steema.TeeChart.ChartListBox chartListBox1;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.Styles.Area area1;
		private Steema.TeeChart.Styles.Bar bar1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Styles.Points points1;
		protected System.Windows.Forms.GroupBox groupBox1;
		protected System.Windows.Forms.RadioButton radioButton1;
		protected System.Windows.Forms.RadioButton radioButton2;
		private System.ComponentModel.IContainer components = null;

		public ChartListBoxRadio() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach(Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.chartListBox1 = new Steema.TeeChart.ChartListBox(this.components);
			this.tChart1 = new Steema.TeeChart.TChart();
			this.area1 = new Steema.TeeChart.Styles.Area();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.points1 = new Steema.TeeChart.Styles.Points();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Chart ListBox control supports displaying check-boxes and radio-buttons.\r\nThe mai" +
				"n purpose of radio-buttons is to show only one series at a time.\r\n\r\nChartListBox" +
				"1.CheckStyle = CheckBoxStyle.Radio; ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Name = "panel1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tChart1);
			this.panel2.Controls.Add(this.chartListBox1);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Name = "panel2";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(120, 154);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// chartListBox1
			// 
			this.chartListBox1.AllowDrop = true;
			this.chartListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.chartListBox1.Chart = this.tChart1;
			this.chartListBox1.Location = new System.Drawing.Point(0, 0);
			this.chartListBox1.Name = "chartListBox1";
			this.chartListBox1.OtherItems = null;
			this.chartListBox1.Size = new System.Drawing.Size(120, 172);
			this.chartListBox1.TabIndex = 1;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.ThemeIndex = 2;
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
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Bold = true;
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Times New Roman";
			this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
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
			// tChart1.Axes.Bottom.Title
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font
			// 
			this.tChart1.Axes.Bottom.Title.Font.Name = "Times New Roman";
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.AxisPen
			// 
			this.tChart1.Axes.Depth.AxisPen.Width = 1;
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
			this.tChart1.Axes.Depth.Labels.Font.Name = "Times New Roman";
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
			// tChart1.Axes.Depth.Title
			// 
			// 
			// tChart1.Axes.Depth.Title.Font
			// 
			this.tChart1.Axes.Depth.Title.Font.Name = "Times New Roman";
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
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			this.tChart1.Axes.Left.Labels.Font.Bold = true;
			this.tChart1.Axes.Left.Labels.Font.Name = "Times New Roman";
			this.tChart1.Axes.Left.Labels.Font.Size = 10;
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
			// tChart1.Axes.Left.Title
			// 
			// 
			// tChart1.Axes.Left.Title.Font
			// 
			this.tChart1.Axes.Left.Title.Font.Name = "Times New Roman";
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.AxisPen
			// 
			this.tChart1.Axes.Right.AxisPen.Width = 1;
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
			this.tChart1.Axes.Right.Labels.Font.Name = "Times New Roman";
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
			// tChart1.Axes.Right.Title
			// 
			// 
			// tChart1.Axes.Right.Title.Font
			// 
			this.tChart1.Axes.Right.Title.Font.Name = "Times New Roman";
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.AxisPen
			// 
			this.tChart1.Axes.Top.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			this.tChart1.Axes.Top.Labels.Font.Name = "Times New Roman";
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
			// tChart1.Axes.Top.Title
			// 
			// 
			// tChart1.Axes.Top.Title.Font
			// 
			this.tChart1.Axes.Top.Title.Font.Name = "Times New Roman";
			this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Header.Brush.Gradient.Visible = true;
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Header.Font.Name = "Times New Roman";
			this.tChart1.Header.Font.Size = 12;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Header.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Header.Gradient.Visible = true;
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// tChart1.Header.Pen
			// 
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
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White;
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
			this.tChart1.Legend.Font.Name = "Times New Roman";
			this.tChart1.Legend.Font.Size = 10;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White;
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
			this.tChart1.Legend.Symbol.DefaultPen = false;
			// 
			// tChart1.Legend.Symbol.Pen
			// 
			this.tChart1.Legend.Symbol.Pen.Visible = false;
			this.tChart1.Legend.Symbol.Squared = true;
			this.tChart1.Legend.Transparent = true;
			this.tChart1.Location = new System.Drawing.Point(120, 0);
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
			this.tChart1.Series.Add(this.area1);
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Series.Add(this.points1);
			this.tChart1.Size = new System.Drawing.Size(306, 154);
			this.tChart1.TabIndex = 2;
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
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White;
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
			this.tChart1.Walls.Back.Size = 8;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.ApplyDark = false;
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(254)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(47)), ((System.Byte)(133)), ((System.Byte)(253)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(254)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(47)), ((System.Byte)(133)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Size = 8;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.ApplyDark = false;
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
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
			this.tChart1.Walls.Left.Size = 8;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.ApplyDark = false;
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Walls.Right.Size = 8;
			// 
			// area1
			// 
			// 
			// area1.AreaBrush
			// 
			this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// area1.Brush
			// 
			this.area1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// area1.Marks
			// 
			// 
			// area1.Marks.Arrow
			// 
			this.area1.Marks.Arrow.Color = System.Drawing.Color.Black;
			// 
			// area1.Marks.Brush
			// 
			// 
			// area1.Marks.Gradient
			// 
			this.area1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// area1.Marks.Font
			// 
			this.area1.Marks.Font.Name = "Times New Roman";
			this.area1.Marks.Font.Size = 10;
			// 
			// area1.Marks.Gradient
			// 
			this.area1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// area1.Marks.Symbol
			// 
			// 
			// area1.Marks.Symbol.Shadow
			// 
			this.area1.Marks.Symbol.Shadow.Height = 1;
			this.area1.Marks.Symbol.Shadow.Visible = true;
			this.area1.Marks.Symbol.Shadow.Width = 1;
			this.area1.Marks.Transparent = true;
			// 
			// area1.Pointer
			// 
			this.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.area1.Title = "area1";
			// 
			// area1.XValues
			// 
			this.area1.XValues.DataMember = "X";
			this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// area1.YValues
			// 
			this.area1.YValues.DataMember = "Y";
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(255)), ((System.Byte)(0)));
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Arrow
			// 
			this.bar1.Marks.Arrow.Color = System.Drawing.Color.Black;
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
			this.bar1.Marks.Font.Name = "Times New Roman";
			this.bar1.Marks.Font.Size = 10;
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
			this.bar1.Marks.Visible = false;
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
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			// 
			// line1.Marks
			// 
			// 
			// line1.Marks.Arrow
			// 
			this.line1.Marks.Arrow.Color = System.Drawing.Color.Black;
			// 
			// line1.Marks.Brush
			// 
			// 
			// line1.Marks.Gradient
			// 
			this.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// line1.Marks.Font
			// 
			this.line1.Marks.Font.Name = "Times New Roman";
			this.line1.Marks.Font.Size = 10;
			// 
			// line1.Marks.Gradient
			// 
			this.line1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// line1.Marks.Symbol
			// 
			// 
			// line1.Marks.Symbol.Shadow
			// 
			this.line1.Marks.Symbol.Shadow.Height = 1;
			this.line1.Marks.Symbol.Shadow.Visible = true;
			this.line1.Marks.Symbol.Shadow.Width = 1;
			this.line1.Marks.Transparent = true;
			// 
			// line1.Pointer
			// 
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "line1";
			// 
			// line1.XValues
			// 
			this.line1.XValues.DataMember = "X";
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line1.YValues
			// 
			this.line1.YValues.DataMember = "Y";
			// 
			// points1
			// 
			// 
			// points1.Marks
			// 
			// 
			// points1.Marks.Arrow
			// 
			this.points1.Marks.Arrow.Color = System.Drawing.Color.Black;
			// 
			// points1.Marks.Brush
			// 
			// 
			// points1.Marks.Gradient
			// 
			this.points1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// points1.Marks.Font
			// 
			this.points1.Marks.Font.Name = "Times New Roman";
			this.points1.Marks.Font.Size = 10;
			// 
			// points1.Marks.Gradient
			// 
			this.points1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// points1.Marks.Symbol
			// 
			// 
			// points1.Marks.Symbol.Shadow
			// 
			this.points1.Marks.Symbol.Shadow.Height = 1;
			this.points1.Marks.Symbol.Shadow.Visible = true;
			this.points1.Marks.Symbol.Shadow.Width = 1;
			this.points1.Marks.Transparent = true;
			// 
			// points1.Pointer
			// 
			// 
			// points1.Pointer.Brush
			// 
			this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
			this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.points1.Title = "points1";
			// 
			// points1.XValues
			// 
			this.points1.XValues.DataMember = "X";
			this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// points1.YValues
			// 
			this.points1.YValues.DataMember = "Y";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(16, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Check Style";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(80, 18);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(56, 14);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Radio";
			this.radioButton2.Click += new System.EventHandler(this.RadioButtons_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(11, 18);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(56, 14);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Check";
			this.radioButton1.Click += new System.EventHandler(this.RadioButtons_Click);
			// 
			// ChartListBoxRadio
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(426, 258);
			this.Name = "ChartListBoxRadio";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void RadioButtons_Click(object sender, System.EventArgs e) {
			switch((sender as RadioButton).Text) {
				case "Check":
					chartListBox1.CheckStyle = CheckBoxesStyle.Check;
			    break;
				case "Radio":
					chartListBox1.CheckStyle = CheckBoxesStyle.Radio;
					break;
			}
		}
	}
}

