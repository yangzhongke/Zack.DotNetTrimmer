using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class AlternateAxisLabels : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line line1;
		private System.Windows.Forms.CheckBox cbAlternate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbLeft;
		private System.Windows.Forms.RadioButton rbTop;
		private System.Windows.Forms.RadioButton rbRight;
		private System.Windows.Forms.RadioButton rbBottom;
		private System.ComponentModel.IContainer components = null;
		private string itemIndex;

		public AlternateAxisLabels()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			line1.FillSampleValues();
			line1.Pointer.Brush.Gradient.Visible=true;
			line1.Pointer.Brush.Gradient.EndColor=Color.Red;

			for(int i=0; i<tChart1.Axes.Count; ++i) 
			{
				tChart1.Axes[i].Labels.Alternate = cbAlternate.Checked;
			}

			itemIndex = "rbBottom";
			HighLight();
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
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.cbAlternate = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbBottom = new System.Windows.Forms.RadioButton();
			this.rbRight = new System.Windows.Forms.RadioButton();
			this.rbTop = new System.Windows.Forms.RadioButton();
			this.rbLeft = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Axis labels can be displayed in \"alternate\" mode. \r\nThis shows two rows or two co" +
				"lumns of axis labels.\r\n\r\n  tChart1.Axes.Left.Labels.Alternate = true; ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.cbAlternate);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.ThemeIndex = 4;
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
			this.tChart1.Axes.Bottom.Grid.Visible = false;
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Bottom.MinorTicks
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.Ticks.Length = 0;
			// 
			// tChart1.Axes.Bottom.TicksInner
			// 
			this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			this.tChart1.Axes.Depth.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Depth.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Depth.MinorTicks
			// 
			this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Ticks.Length = 0;
			// 
			// tChart1.Axes.Depth.TicksInner
			// 
			this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			this.tChart1.Axes.Left.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Left.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Left.MinorTicks
			// 
			this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.Ticks.Length = 0;
			// 
			// tChart1.Axes.Left.TicksInner
			// 
			this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			this.tChart1.Axes.Right.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Right.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Right.MinorTicks
			// 
			this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Ticks.Length = 0;
			// 
			// tChart1.Axes.Right.TicksInner
			// 
			this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			this.tChart1.Axes.Top.Grid.Visible = false;
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			this.tChart1.Axes.Top.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Top.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Top.MinorTicks
			// 
			this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Ticks.Length = 0;
			// 
			// tChart1.Axes.Top.TicksInner
			// 
			this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.TicksInner.Length = 6;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Header.Font.Name = "Lucida Console";
			this.tChart1.Header.Font.Size = 10;
			this.tChart1.Header.Lines = new string[] {
														 "tChart1"};
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
			// tChart1.Legend.Font
			// 
			this.tChart1.Legend.Font.Name = "Lucida Console";
			this.tChart1.Legend.Font.Size = 9;
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
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			this.tChart1.Legend.Shadow.Height = -1;
			// 
			// tChart1.Legend.Symbol
			// 
			// 
			// tChart1.Legend.Symbol.Pen
			// 
			this.tChart1.Legend.Symbol.Pen.Visible = false;
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
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
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
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
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
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
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
			// 
			// tChart1.Walls.Left
			// 
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
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(165)), ((System.Byte)(255)));
			this.line1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both;
			// 
			// line1.Marks
			// 
			// 
			// line1.Marks.Brush
			// 
			// 
			// line1.Marks.Gradient
			// 
			this.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			this.line1.Marks.Brush.Gradient.Visible = true;
			// 
			// line1.Marks.Font
			// 
			this.line1.Marks.Font.Name = "Lucida Console";
			// 
			// line1.Marks.Gradient
			// 
			this.line1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			this.line1.Marks.Gradient.Visible = true;
			// 
			// line1.Pointer
			// 
			// 
			// line1.Pointer.Brush
			// 
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Pointer.Visible = true;
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
			// cbAlternate
			// 
			this.cbAlternate.Checked = true;
			this.cbAlternate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAlternate.Location = new System.Drawing.Point(304, 8);
			this.cbAlternate.Name = "cbAlternate";
			this.cbAlternate.Size = new System.Drawing.Size(112, 24);
			this.cbAlternate.TabIndex = 0;
			this.cbAlternate.Text = "Alternate Labels";
			this.cbAlternate.CheckedChanged += new System.EventHandler(this.cbAlternate_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbBottom);
			this.groupBox1.Controls.Add(this.rbRight);
			this.groupBox1.Controls.Add(this.rbTop);
			this.groupBox1.Controls.Add(this.rbLeft);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 40);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Axis";
			// 
			// rbBottom
			// 
			this.rbBottom.Checked = true;
			this.rbBottom.Location = new System.Drawing.Point(190, 18);
			this.rbBottom.Name = "rbBottom";
			this.rbBottom.Size = new System.Drawing.Size(64, 14);
			this.rbBottom.TabIndex = 3;
			this.rbBottom.TabStop = true;
			this.rbBottom.Text = "Bottom";
			this.rbBottom.CheckedChanged += new System.EventHandler(this.RBAxis_CheckedChanged);
			// 
			// rbRight
			// 
			this.rbRight.Location = new System.Drawing.Point(126, 17);
			this.rbRight.Name = "rbRight";
			this.rbRight.Size = new System.Drawing.Size(51, 16);
			this.rbRight.TabIndex = 2;
			this.rbRight.Text = "Right";
			this.rbRight.CheckedChanged += new System.EventHandler(this.RBAxis_CheckedChanged);
			// 
			// rbTop
			// 
			this.rbTop.Location = new System.Drawing.Point(67, 16);
			this.rbTop.Name = "rbTop";
			this.rbTop.Size = new System.Drawing.Size(42, 17);
			this.rbTop.TabIndex = 1;
			this.rbTop.Text = "Top";
			this.rbTop.CheckedChanged += new System.EventHandler(this.RBAxis_CheckedChanged);
			// 
			// rbLeft
			// 
			this.rbLeft.Location = new System.Drawing.Point(10, 17);
			this.rbLeft.Name = "rbLeft";
			this.rbLeft.Size = new System.Drawing.Size(42, 14);
			this.rbLeft.TabIndex = 0;
			this.rbLeft.Text = "Left";
			this.rbLeft.CheckedChanged += new System.EventHandler(this.RBAxis_CheckedChanged);
			// 
			// AlternateAxisLabels
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "AlternateAxisLabels";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void cbAlternate_CheckedChanged(object sender, System.EventArgs e)
		{
			TheAxis().Labels.Alternate=cbAlternate.Checked;
			HighLight();
		}

		private void HighLightAxis(Steema.TeeChart.Axis Axis) 
		{
		   Axis.Labels.Font.Bold=TheAxis()==Axis;
		}

		private void HighLight() 
		{
			HighLightAxis(tChart1.Axes.Left);
			HighLightAxis(tChart1.Axes.Right);
			HighLightAxis(tChart1.Axes.Top);
			HighLightAxis(tChart1.Axes.Bottom);
		}

		private Steema.TeeChart.Axis TheAxis() 
		{
			Steema.TeeChart.Axis result=null;
			switch(itemIndex) 
			{
				case "rbLeft":
					result = tChart1.Axes.Left;
					break;
				case "rbRight":
					result = tChart1.Axes.Right;
					break;
				case "rbTop":
					result = tChart1.Axes.Top;
					break;
				case "rbBottom":
					result = tChart1.Axes.Bottom;
					break;
			}
			return result;
			
		}

		private void RBAxis_CheckedChanged(object sender, System.EventArgs e)
		{
			itemIndex = ((RadioButton)sender).Name;
			cbAlternate.Checked=TheAxis().Labels.Alternate;
			HighLight();
		}
	}
}

