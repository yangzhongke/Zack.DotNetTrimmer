using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;


using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Arrow : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Timer timer1;
		private Steema.TeeChart.Styles.Arrow arrowSeries1;
		private System.ComponentModel.IContainer components = null;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		
		private Random r;
		
		private void AddRandomArrows()
		{
			double x0,y0,x1,y1;
			arrowSeries1.Clear();
			for (int t=1;t<40;t++)
			{
				x0 = r.Next(1000);
				y0 = r.Next(1000);
				x1 = r.Next(300) - 150;
				if (x1<50) x1=50;
				x1 += x0;
				y1 = r.Next(300) - 150;
				if (y1<50) y1=50;
				y1 += y0;
				arrowSeries1.Add(x0,y0,x1,y1);
			}
			
		}
	
		public SeriesType_Arrow()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			r = new Random();	
			
			// first, setup tChart
			Steema.TeeChart.Drawing.Aspect asp = tChart1.Aspect;
			asp.Orthogonal = false;
			asp.Perspective = 55;
			asp.Rotation =341;
			asp.Elevation = 353;
			asp.Zoom = 93;
			tChart1.Legend.Visible = false;

			// now the series
			arrowSeries1.ArrowWidth = 32;
			arrowSeries1.ArrowHeight = 24;
			arrowSeries1.ColorEach = true;
			AddRandomArrows();
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.arrowSeries1 = new Steema.TeeChart.Styles.Arrow();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Each Arrow is represented as a point with Starting and  Ending coordinates. This " +
				"demo changes arrow positions randomly.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(0)));
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.arrowSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.Size = 5;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(91, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Color each";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(112, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(66, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Animate";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(184, 8);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(40, 21);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "&3D";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// arrowSeries1
			// 
			this.arrowSeries1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both;
			this.arrowSeries1.LabelMember = "Labels";
			// 
			// arrowSeries1.Marks
			// 
			// 
			// arrowSeries1.Marks.Pen
			// 
			this.arrowSeries1.Marks.Pen.Visible = false;
			// 
			// arrowSeries1.Marks.Symbol
			// 
			// 
			// arrowSeries1.Marks.Symbol.Shadow
			// 
			this.arrowSeries1.Marks.Symbol.Shadow.Height = 1;
			this.arrowSeries1.Marks.Symbol.Shadow.Visible = true;
			this.arrowSeries1.Marks.Symbol.Shadow.Width = 1;
			this.arrowSeries1.Marks.Transparent = true;
			// 
			// arrowSeries1.Pointer
			// 
			// 
			// arrowSeries1.Pointer.Brush
			// 
			this.arrowSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.arrowSeries1.Pointer.InflateMargins = false;
			// 
			// arrowSeries1.Pointer.Pen
			// 
			this.arrowSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.arrowSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.arrowSeries1.StartXValues = this.arrowSeries1.XValues;
			this.arrowSeries1.StartYValues = this.arrowSeries1.YValues;
			this.arrowSeries1.Title = "arrow1";
			this.arrowSeries1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both;
			// 
			// arrowSeries1.XValues
			// 
			this.arrowSeries1.XValues.DataMember = "X";
			this.arrowSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// arrowSeries1.YValues
			// 
			this.arrowSeries1.YValues.DataMember = "Y";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Arrow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Arrow";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			arrowSeries1.ColorEach = checkBox1.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = checkBox3.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			timer1.Enabled = checkBox2.Checked;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Stop();
			for (int t=0;t<arrowSeries1.Count;t++)
			{
				arrowSeries1.StartXValues[t] = arrowSeries1.StartXValues[t] +r.Next(100) - 50;
				arrowSeries1.StartYValues[t] = arrowSeries1.StartYValues[t] +r.Next(100) - 50;
				arrowSeries1.EndXValues[t] = arrowSeries1.EndXValues[t] +r.Next(100) - 50;
				arrowSeries1.EndYValues[t] = arrowSeries1.EndYValues[t] +r.Next(100) - 50;
			}
			arrowSeries1.Repaint();
			
			timer1.Start();
		}
	}
}

