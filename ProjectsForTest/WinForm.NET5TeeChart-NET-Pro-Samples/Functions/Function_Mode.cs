using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Function_Mode : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Functions.ModeFunction modeFunction1;
		private System.ComponentModel.IContainer components = null;

		public Function_Mode()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			fastLine1.Add(40);
			fastLine1.Add(86);
			fastLine1.Add(34);
			fastLine1.Add(138);
			fastLine1.Add(79);
			fastLine1.Add(76);
			fastLine1.Add(19);
			fastLine1.Add(31);
			fastLine1.Add(106);
			fastLine1.Add(31);
			fastLine1.Add(123);
			fastLine1.Add(155);
			fastLine1.Add(34);
			fastLine1.Add(31);
			fastLine1.Add(46);
			fastLine1.Add(123);
			fastLine1.Add(150);

			fastLine1.SetNull(7);
			fastLine1.SetNull(9);
			fastLine1.SetNull(14);

			line1.CheckDataSource();
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.modeFunction1 = new Steema.TeeChart.Functions.ModeFunction();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The Mode function calculates the value with highest count of duplicates inside \r\n" +
				"the source series data.\r\nIncludes the option to ignore null source values.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.ThemeIndex = 7;
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
			this.tChart1.Axes.Bottom.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Bottom.MinorTicks
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.Ticks.Length = 2;
			// 
			// tChart1.Axes.Bottom.TicksInner
			// 
			this.tChart1.Axes.Bottom.TicksInner.Visible = false;
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
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Depth.MinorTicks
			// 
			this.tChart1.Axes.Depth.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			// 
			// tChart1.Axes.Depth.TicksInner
			// 
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
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Left.MinorTicks
			// 
			this.tChart1.Axes.Left.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.Ticks.Length = 2;
			// 
			// tChart1.Axes.Left.TicksInner
			// 
			this.tChart1.Axes.Left.TicksInner.Visible = false;
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
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Right.MinorTicks
			// 
			this.tChart1.Axes.Right.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Ticks.Length = 2;
			// 
			// tChart1.Axes.Right.TicksInner
			// 
			this.tChart1.Axes.Right.TicksInner.Visible = false;
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
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Top.MinorTicks
			// 
			this.tChart1.Axes.Top.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Ticks.Length = 2;
			// 
			// tChart1.Axes.Top.TicksInner
			// 
			this.tChart1.Axes.Top.TicksInner.Visible = false;
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
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.DividingLines
			// 
			this.tChart1.Legend.DividingLines.Visible = true;
			// 
			// tChart1.Legend.Font
			// 
			this.tChart1.Legend.Font.Size = 10;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Shadow.Height = 0;
			this.tChart1.Legend.Shadow.Width = 0;
			this.tChart1.Legend.Transparent = true;
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
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.fastLine1);
			this.tChart1.Series.Add(this.line1);
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
			this.tChart1.Walls.Back.Size = 8;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.ApplyDark = false;
			this.tChart1.Walls.Bottom.Size = 8;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.ApplyDark = false;
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
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
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(24, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(184, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Include Null values in calculation";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(248, 9);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(192, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Hide Null values in Source series";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// fastLine1
			// 
			// 
			// fastLine1.LinePen
			// 
			this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// fastLine1.Marks
			// 
			// 
			// fastLine1.Marks.Arrow
			// 
			this.fastLine1.Marks.Arrow.Color = System.Drawing.Color.Black;
			// 
			// fastLine1.Marks.Brush
			// 
			// 
			// fastLine1.Marks.Gradient
			// 
			this.fastLine1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// fastLine1.Marks.Font
			// 
			this.fastLine1.Marks.Font.Size = 10;
			// 
			// fastLine1.Marks.Gradient
			// 
			this.fastLine1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			// 
			// fastLine1.Marks.Symbol
			// 
			// 
			// fastLine1.Marks.Symbol.Shadow
			// 
			this.fastLine1.Marks.Symbol.Shadow.Height = 1;
			this.fastLine1.Marks.Symbol.Shadow.Visible = true;
			this.fastLine1.Marks.Symbol.Shadow.Width = 1;
			this.fastLine1.Marks.Transparent = true;
			this.fastLine1.Title = "Source";
			// 
			// fastLine1.XValues
			// 
			this.fastLine1.XValues.DataMember = "X";
			this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// fastLine1.YValues
			// 
			this.fastLine1.YValues.DataMember = "Y";
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(49)), ((System.Byte)(83)), ((System.Byte)(196)));
			this.line1.DataSource = this.fastLine1;
			this.line1.Function = this.modeFunction1;
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
			this.line1.Title = "Mode";
			this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
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
			// Mode
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Mode";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			 modeFunction1.IncludeNulls = checkBox1.Checked;
		}

		private void checkBox2_Click(object sender, System.EventArgs e)
		{
			 fastLine1.TreatNulls = checkBox2.Checked ? Steema.TeeChart.Styles.TreatNullsStyle.Ignore : Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint;
		}
	}
}

