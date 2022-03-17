using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class FastLine_Realtime : Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
	    private System.Windows.Forms.Label label1;
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private Steema.TeeChart.Styles.FastLine fastLine2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.ComponentModel.IContainer components = null;
		private bool Stopped;
		private int MaxPoints;
		private int ScrollPoints;

		public FastLine_Realtime()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

	        // Prepare chart for maximum speed:
			//   ClipPoints:=False;
			tChart1.Header.Visible = false;
			tChart1.Legend.Visible = false;
			tChart1.Axes.Left.AxisPen.Width=1;
			tChart1.Axes.Bottom.AxisPen.Width=1;
			tChart1.Axes.Bottom.Labels.RoundFirstLabel=false;
			tChart1.Aspect.View3D=false;

			// Private variables for this demo:
			Stopped=true;
			MaxPoints=10000;
			ScrollPoints=5000;

			// Prepare series.
			// Disable AutoRepaint and X Order

			// AutoRepaint=False means "real-time" drawing mode.
			// Points are displayed just after adding them,
			// without redrawing the whole chart.
			fastLine1.AutoRepaint=false;
			fastLine2.AutoRepaint=false;

			// Set Ordering to none, to increment speed when adding points
			fastLine1.XValues.Order=Steema.TeeChart.Styles.ValueListOrder.None;
			fastLine1.XValues.Order=Steema.TeeChart.Styles.ValueListOrder.None;

			// Initialize axis scales
			tChart1.Axes.Left.SetMinMax(0,10000);
			tChart1.Axes.Bottom.SetMinMax(1,MaxPoints);

			// Speed tips:

			// For Windows NT, 2000 and XP only:
			// Speed realtime painting with solid pens of width 1.
			//fastLine1.FastPen=true;
			//fastLine2.FastPen=true;

			// Set axis calculations in "fast mode".
			// Note: For Windows Me and 98 might produce bad drawings when
			//       chart zoom is very big.
			//tChart1.Axes.FastCalc=true;
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
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
			this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = @"New Series ""Delete"" method to fast delete multiple points in a single call,
much faster than deleting multiple points using a loop.

New FastLine ""FastPen"" property to speed up drawing fastline series
in real-time mode.  ( Note: Supported only in Windows 2000 and XP )

For maximum speed set this property:
tChart1.Axes.FastCalc=true;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			this.panel1.TabIndex = 1;
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
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.ZPosition = 0;
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
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.ZPosition = 0;
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
			// tChart1.Axes.DepthTop.Grid
			// 
			this.tChart1.Axes.DepthTop.Grid.ZPosition = 0;
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
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.ZPosition = 0;
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
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.ZPosition = 0;
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
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.ZPosition = 0;
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
			// 
			// tChart1.Header.Font.Shadow
			// 
			// 
			// tChart1.Header.Font.Shadow.Brush
			// 
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Header.Lines = new string[] {
														 "Area series gradient & transparency"};
			// 
			// tChart1.Header.Shadow
			// 
			this.tChart1.Header.Shadow.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Shadow
			// 
			this.tChart1.Legend.Font.Shadow.Visible = false;
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
			this.tChart1.Location = new System.Drawing.Point(0, 96);
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Visible = false;
			this.tChart1.Series.Add(this.fastLine1);
			this.tChart1.Series.Add(this.fastLine2);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
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
			this.tChart1.TabIndex = 2;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.AutoHide = false;
			// 
			// tChart1.Walls.Back.Shadow
			// 
			this.tChart1.Walls.Back.Shadow.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.AutoHide = false;
			// 
			// tChart1.Walls.Bottom.Shadow
			// 
			this.tChart1.Walls.Bottom.Shadow.Visible = false;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.AutoHide = false;
			// 
			// tChart1.Walls.Left.Shadow
			// 
			this.tChart1.Walls.Left.Shadow.Visible = false;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.AutoHide = false;
			// 
			// tChart1.Walls.Right.Shadow
			// 
			this.tChart1.Walls.Right.Shadow.Visible = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(8, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Start !";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(69, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(99, 16);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "&Draw All Points";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(166, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "&Total Points :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// fastLine1
			// 
			// 
			// fastLine1.LinePen
			// 
			this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(153)), ((System.Byte)(102)));
			// 
			// fastLine1.Marks
			// 
			// 
			// fastLine1.Marks.Callout
			// 
			this.fastLine1.Marks.Callout.Arrow = this.fastLine1.Marks.Arrow;
			this.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLine1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// fastLine1.Marks.Callout.Brush
			// 
			this.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLine1.Marks.Callout.Distance = 0;
			this.fastLine1.Marks.Callout.Draw3D = false;
			this.fastLine1.Marks.Callout.Length = 10;
			this.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// fastLine1.Marks.Font
			// 
			// 
			// fastLine1.Marks.Font.Shadow
			// 
			this.fastLine1.Marks.Font.Shadow.Visible = false;
			this.fastLine1.Title = "fastLine1";
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
			// fastLine2
			// 
			// 
			// fastLine2.LinePen
			// 
			this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(102)), ((System.Byte)(102)));
			// 
			// fastLine2.Marks
			// 
			// 
			// fastLine2.Marks.Callout
			// 
			this.fastLine2.Marks.Callout.Arrow = this.fastLine2.Marks.Arrow;
			this.fastLine2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLine2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// fastLine2.Marks.Callout.Brush
			// 
			this.fastLine2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLine2.Marks.Callout.Distance = 0;
			this.fastLine2.Marks.Callout.Draw3D = false;
			this.fastLine2.Marks.Callout.Length = 10;
			this.fastLine2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// fastLine2.Marks.Font
			// 
			// 
			// fastLine2.Marks.Font.Shadow
			// 
			this.fastLine2.Marks.Font.Shadow.Visible = false;
			this.fastLine2.Title = "fastLine2";
			// 
			// fastLine2.XValues
			// 
			this.fastLine2.XValues.DataMember = "X";
			this.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// fastLine2.YValues
			// 
			this.fastLine2.YValues.DataMember = "Y";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(285, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Scroll :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(384, 9);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(67, 16);
			this.checkBox2.TabIndex = 4;
			this.checkBox2.Text = "&Fast Pen";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(234, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(46, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "10000";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(326, 8);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(46, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "5000";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// FastLine_Realtime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "FastLine_Realtime";
			this.Closed += new System.EventHandler(this.FastLine_Realtime_Closed);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void RealTimeAdd(Steema.TeeChart.Styles.FastLine series)
		{
			Random rnd = new Random();
    		// Next random point
	    	series.Add(series.XValues.Last+1,series.YValues.Last+rnd.Next(10)-4.5);			
		}

		// When the chart is filled with points, this procedure
		// deletes and scrolls points to the left.
		private void DoScrollPoints()
		{
			double tmp,tmpMin,tmpMax;
			// Delete multiple points with a single call.
			// Much faster than deleting points using a loop.

			fastLine1.Delete(0,ScrollPoints);
			fastLine2.Delete(0,ScrollPoints);

			// Scroll horizontal bottom axis
			tmp=fastLine1.XValues.Last;
			tChart1.Axes.Bottom.SetMinMax(tmp-MaxPoints+ScrollPoints,tmp+ScrollPoints);

			// Scroll vertical left axis
			tmpMin=fastLine1.YValues.Minimum;
			if (fastLine2.YValues.Minimum<tmpMin)
				tmpMin=fastLine2.YValues.Minimum;

			tmpMax=fastLine1.YValues.Maximum;
			if (fastLine2.YValues.Maximum>tmpMax)
				tmpMax=fastLine2.YValues.Maximum;

			tChart1.Axes.Left.SetMinMax(tmpMin-tmpMin*0.2,tmpMax+tmpMax*0.2);

			// Do chart repaint after deleting and scrolling
            Application.DoEvents();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (Stopped)
			{
				// Start loop...
				button1.Text="&Stop";
				textBox2.Enabled=false;
				textBox3.Enabled=false;

				// Prepare variables
				MaxPoints=Convert.ToInt32(textBox2.Text);
				ScrollPoints=Convert.ToInt32(textBox3.Text);
				tChart1.Axes.Bottom.SetMinMax(1,MaxPoints);

				// Clear
				fastLine1.Clear();
				fastLine2.Clear();
                Random r = new Random();
                fastLine1.Add(r.Next(10000));
                fastLine2.Add(r.Next(5000));
                Application.DoEvents();

				Stopped=false;

				// Start loop
				while (!Stopped)
				{				
					// Add one more point
					RealTimeAdd(fastLine1);
					RealTimeAdd(fastLine2);

					// Delete and Scroll points to the left						
					if (fastLine1.Count>MaxPoints-1)
						DoScrollPoints();
				}
			}
			else
			{
				// Finish
				Stopped=true;
				button1.Text="&Start";
				textBox2.Enabled=true;
				textBox3.Enabled=true;
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			fastLine1.DrawAllPoints=checkBox1.Checked;
			fastLine2.DrawAllPoints=checkBox1.Checked;
		}

		private void FastLine_Realtime_Closed(object sender, System.EventArgs e)
		{
			  Stopped=true;  // Break loop to allow close form
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			// When FastLine series have AutoRepaint = False ,
			// setting FastPen to True increases speed.
			//fastLine1.FastPen=checkBox2.Checked;
			//fastLine2.FastPen=checkBox2.Checked;		
		}
	}
}

