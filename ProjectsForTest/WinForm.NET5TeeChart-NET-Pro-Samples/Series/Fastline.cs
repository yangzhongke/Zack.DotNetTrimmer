using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class SeriesType_Fastline : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.FastLine fastLineSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.FastLine fastLineSeries2;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Fastline()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Make the chart flicker by default, only for this demo
            tChart1.Graphics3D.BufferStyle = Drawing.BufferStyle.None;

            // hide things for better speed
            tChart1.Aspect.View3D = false;
			tChart1.Legend.Visible = false;
			tChart1.Header.Visible = false;
			tChart1.Footer.Visible = false;
			
			// 1000 random points each series
			Random r = new Random();
			int tmprandom;
			for (int t=1;t<1000;t++)
			{
				tmprandom = r.Next(Math.Abs(500-t))-(Math.Abs(500-t) / 2);
				fastLineSeries1.Add(1000-t+tmprandom);
				fastLineSeries2.Add(t+tmprandom);
			}
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
			this.fastLineSeries1 = new Steema.TeeChart.Styles.FastLine();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.fastLineSeries2 = new Steema.TeeChart.Styles.FastLine();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(511, 64);
			this.textBox1.Text = @"The Fast-Line chart style is, at it's name implies, the fastest way to plot many points.  It simply draws a thin line connecting all points.
Some optimizations (like not drawing repeated values) are performed. It can be used in real-time applications to plot new added points.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(511, 40);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.fastLineSeries1);
			this.tChart1.Series.Add(this.fastLineSeries2);
			this.tChart1.Size = new System.Drawing.Size(511, 208);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 30;
			// 
			// fastLineSeries1
			// 
			this.fastLineSeries1.Cursor = Drawing.Cursors.Cross;
			// 
			// fastLineSeries1.LinePen
			// 
			this.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red;
			// 
			// fastLineSeries1.Marks
			// 
			// 
			// fastLineSeries1.Marks.Symbol
			// 
			// 
			// fastLineSeries1.Marks.Symbol.Shadow
			// 
			this.fastLineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.fastLineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.fastLineSeries1.Marks.Symbol.Shadow.Width = 1;
			this.fastLineSeries1.Title = "fastLine2";
			// 
			// fastLineSeries1.XValues
			// 
			this.fastLineSeries1.XValues.DataMember = "X";
			this.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// fastLineSeries1.YValues
			// 
			this.fastLineSeries1.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(14, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(73, 22);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Buffered";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(95, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(89, 22);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Draw Axes";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(182, 8);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(81, 22);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "&Clip points";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(292, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "&Test speed";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// fastLineSeries2
			// 
			this.fastLineSeries2.Cursor = Drawing.Cursors.Cross;
			// 
			// fastLineSeries2.LinePen
			// 
			this.fastLineSeries2.LinePen.Color = System.Drawing.Color.Green;
			// 
			// fastLineSeries2.Marks
			// 
			// 
			// fastLineSeries2.Marks.Symbol
			// 
			// 
			// fastLineSeries2.Marks.Symbol.Shadow
			// 
			this.fastLineSeries2.Marks.Symbol.Shadow.Height = 1;
			this.fastLineSeries2.Marks.Symbol.Shadow.Visible = true;
			this.fastLineSeries2.Marks.Symbol.Shadow.Width = 1;
			this.fastLineSeries2.Title = "fastLine2";
			// 
			// fastLineSeries2.XValues
			// 
			this.fastLineSeries2.XValues.DataMember = "X";
			this.fastLineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// fastLineSeries2.YValues
			// 
			this.fastLineSeries2.YValues.DataMember = "Y";
			// 
			// SeriesType_Fastline
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(511, 312);
			this.Name = "SeriesType_Fastline";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
            tChart1.Graphics3D.BufferStyle = checkBox1.Checked ? Drawing.BufferStyle.OptimizedBuffer : Drawing.BufferStyle.None;
        }

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Axes.Visible = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.ClipPoints = checkBox3.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			int MarkTime;
			try
			{
				tChart1.Zoom.Animated = false;
				MarkTime = Environment.TickCount;
				int t;
				for (t=1;t<30;t++) 
				{
					tChart1.Zoom.ZoomPercent(105);
					tChart1.Refresh(); 
				}
				for (t=1;t<30;t++)
				{
					tChart1.Zoom.ZoomPercent(95);
					tChart1.Refresh(); 
				}
				MarkTime = Environment.TickCount - MarkTime;
				tChart1.Zoom.Animated = true;
				tChart1.Zoom.Undo();
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
			MessageBox.Show("Time to plot 2000 points \n 61 times : \n "+
				MarkTime.ToString()+" milliseconds.");
			}
	}
}
