using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ToolAxisScroll : Steema.TeeChart.Samples.BaseForm
 {
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Tools.AxisScroll axisScroll1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.ComponentModel.IContainer components = null;

		public ToolAxisScroll () {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			line1.FillSampleValues();
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
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.axisScroll1 = new Steema.TeeChart.Tools.AxisScroll();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Axis Scroll tool enables mouse dragging of axis to scroll them.\r\n\r\nA tool can be " +
				"associated to a single axis or to all visible chart axes.\r\n\r\naxisScrolll1.Axis =" +
				" tChart1.Axes.Left ;";
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
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
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
																								 "Click and drag an axis to scroll it."};
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
			this.tChart1.Legend.DividingLines.Visible = true;
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
			this.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White;
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
			this.tChart1.Legend.Symbol.Squared = true;
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
			// 
			// tChart1.Panel.Shadow.Brush
			// 
			this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Visible = true;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Tools.Add(this.axisScroll1);
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
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			this.line1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both;
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
			this.line1.Title = "line1";
			this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both;
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
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(120, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Enable axis scroll";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(160, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(120, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Inverted Scroll";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// ToolAxisScroll
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "ToolAxisScroll";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e) {
			axisScroll1.Active = checkBox1.Checked;
		}

		private void checkBox2_Click(object sender, System.EventArgs e) {
			axisScroll1.ScrollInverted = checkBox2.Checked;
		}
	}
}

