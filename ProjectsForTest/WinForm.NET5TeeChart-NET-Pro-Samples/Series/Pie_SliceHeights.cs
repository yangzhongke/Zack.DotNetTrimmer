using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class PieSliceHeights : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Donut donut1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public PieSliceHeights()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			donut1.FillSampleValues();
		  checkBox1.Checked=true;
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
			this.donut1 = new Steema.TeeChart.Styles.Donut();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Each pie or donut series slice can be displayed using a different height, \r\nas pe" +
				"rcentage of Chart1.Chart3DPercent.  Default is 100 %.\r\n\r\ndonut1.SliceHeight[3] =" +
				" 50;   // slice index 3, using a 50% of 3D height.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 55;
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			this.tChart1.Aspect.ThemeIndex = 4;
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
			this.tChart1.Axes.Bottom.Labels.Font.Bold = true;
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Bottom.MinorGrid
			// 
			this.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(((System.Byte)(229)), ((System.Byte)(229)), ((System.Byte)(229)));
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
			this.tChart1.Axes.Left.Labels.Font.Bold = true;
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
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Header.Font.Name = "Lucida Console";
			this.tChart1.Header.Font.Size = 10;
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
			// 
			// tChart1.Legend.Symbol
			// 
			// 
			// tChart1.Legend.Symbol.Pen
			// 
			this.tChart1.Legend.Symbol.Pen.Visible = false;
			this.tChart1.Legend.Symbol.Squared = true;
			this.tChart1.Legend.Transparent = true;
			this.tChart1.Legend.Visible = false;
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
			this.tChart1.Series.Add(this.donut1);
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
			// donut1
			// 
			// 
			// donut1.Brush
			// 
			this.donut1.Brush.Color = System.Drawing.Color.Red;
			this.donut1.LabelMember = "Labels";
			// 
			// donut1.Marks
			// 
			// 
			// donut1.Marks.Arrow
			// 
			this.donut1.Marks.Arrow.Color = System.Drawing.Color.White;
			// 
			// donut1.Marks.Brush
			// 
			// 
			// donut1.Marks.Gradient
			// 
			this.donut1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			this.donut1.Marks.Brush.Gradient.Visible = true;
			// 
			// donut1.Marks.Font
			// 
			this.donut1.Marks.Font.Name = "Lucida Console";
			// 
			// donut1.Marks.Gradient
			// 
			this.donut1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			this.donut1.Marks.Gradient.Visible = true;
			// 
			// donut1.Marks.Symbol
			// 
			// 
			// donut1.Marks.Symbol.Shadow
			// 
			this.donut1.Marks.Symbol.Shadow.Height = 1;
			this.donut1.Marks.Symbol.Shadow.Visible = true;
			this.donut1.Marks.Symbol.Shadow.Width = 1;
			// 
			// donut1.Pen
			// 
			this.donut1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// donut1.Shadow
			// 
			this.donut1.Shadow.Height = 20;
			this.donut1.Shadow.Width = 20;
			this.donut1.Title = "donut1";
			// 
			// donut1.XValues
			// 
			this.donut1.XValues.DataMember = "Angle";
			this.donut1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// donut1.YValues
			// 
			this.donut1.YValues.DataMember = "Pie";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(120, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Vary Slice Heights";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(247, 12);
			this.hScrollBar1.Maximum = 360;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(128, 17);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(198, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Rotate:";
			// 
			// PieSliceHeights
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "PieSliceHeights";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
			for(int t=0; t < donut1.Count; ++t) {
				if(checkBox1.Checked) 
					donut1.SliceHeight[t]= Convert.ToInt32( (t + 1)*100 / donut1.Count );// vary height
				else
					donut1.SliceHeight[t]=100;  // total height for all slices
			}
		}

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
			donut1.RotationAngle=hScrollBar1.Value;
		}
	}
}

