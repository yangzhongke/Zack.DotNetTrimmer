using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Welcome_All dialogue.
	/// </summary>
	public class Welcome_All : System.Windows.Forms.Form
	{
		protected Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.Timers.Timer timer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label4;
		private Random r= new Random(45);
		private bool deltaUp=false;
		private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.Windows.Forms.Label label8;

    private int idx1 = -1;
    private Label label9;
    private Label label10;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Welcome_All()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
            tChart1.Zoom.Direction = ZoomDirections.None;

        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_All));
      this.timer1 = new System.Timers.Timer();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.pictureBox5 = new System.Windows.Forms.PictureBox();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.lineSeries1 = new Steema.TeeChart.Styles.Line();
      this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
      this.panel1.SuspendLayout();
#if VS2005
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
#endif
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Interval = 50;
      this.timer1.SynchronizingObject = this;
      this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.label10);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.pictureBox4);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 15);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(489, 222);
      this.panel1.TabIndex = 6;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.BackColor = System.Drawing.Color.Transparent;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(12, 54);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(219, 15);
      this.label8.TabIndex = 11;
      this.label8.Text = "WPF, Silverlight and Flex/Flash support";
      this.label8.UseMnemonic = false;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.BackColor = System.Drawing.Color.Transparent;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(12, 108);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(120, 15);
      this.label7.TabIndex = 10;
      this.label7.Text = "OpenGL Component";
      this.label7.UseMnemonic = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(12, 144);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(121, 15);
      this.label6.TabIndex = 9;
      this.label6.Text = "Extensive User Tools";
      this.label6.UseMnemonic = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(12, 126);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(342, 15);
      this.label5.TabIndex = 8;
      this.label5.Text = "Data aware. Supports SQLDataAdapter, Dataviews and tables";
      this.label5.UseMnemonic = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.Transparent;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 90);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(252, 15);
      this.label4.TabIndex = 7;
      this.label4.Text = "ASP.NET & Ajax support with WebForm Chart";
      this.label4.UseMnemonic = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(315, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "Run-time Editor, Print-Preview, Gallery and Navigator bar";
      this.label3.UseMnemonic = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 36);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(255, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "41 Functions (Standard, Financial, Statistical).";
      this.label2.UseMnemonic = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(322, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "57 Chart styles (in 2D and 3D plus multiple combinations).";
      this.label1.UseMnemonic = false;
      // 
      // pictureBox4
      // 
      this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
      this.pictureBox4.Location = new System.Drawing.Point(0, 61);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(489, 161);
      this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox4.TabIndex = 6;
      this.pictureBox4.TabStop = false;
      // 
      // pictureBox5
      // 
      this.pictureBox5.BackColor = System.Drawing.Color.White;
      this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox5.Location = new System.Drawing.Point(0, 0);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new System.Drawing.Size(489, 15);
      this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox5.TabIndex = 7;
      this.pictureBox5.TabStop = false;
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.Chart3DPercent = 10;
      this.tChart1.Aspect.Elevation = 360;
      this.tChart1.Aspect.ElevationFloat = 360;
      this.tChart1.Aspect.Perspective = 50;
      this.tChart1.Aspect.Rotation = 315;
      this.tChart1.Aspect.RotationFloat = 315;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Aspect.ZOffset = 0;
      this.tChart1.Aspect.Zoom = 102;
      this.tChart1.Aspect.ZoomFloat = 102;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.None;
      this.tChart1.Axes.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.CustomSize = 1;
      this.tChart1.Axes.Left.LogarithmicBase = 2;
      this.tChart1.Cursor = Cursors.Default;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Bottom;
      // 
      // 
      // 
      this.tChart1.Header.Lines = new string[] {
        "tChart1"};
      this.tChart1.Header.Visible = false;
      // 
      // 
      // 
      this.tChart1.Legend.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(0, 237);
      this.tChart1.Name = "tChart1";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(126)))), ((int)(((byte)(100)))));
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Panel.MarginLeft = 0;
      this.tChart1.Panel.MarginRight = 2;
      this.tChart1.Series.Add(this.lineSeries1);
      this.tChart1.Size = new System.Drawing.Size(489, 113);
      this.tChart1.TabIndex = 4;
      this.tChart1.Tools.Add(this.gridBand1);
      this.tChart1.GetAxisLabel += new Steema.TeeChart.GetAxisLabelEventHandler(this.tChart1_GetAxisLabel);
      this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
      // 
      // lineSeries1
      // 
      // 
      // 
      // 
      this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.lineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.lineSeries1.ColorEach = false;
      // 
      // 
      // 
      this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.lineSeries1.LinePen.Width = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      this.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.lineSeries1.Marks.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
      this.lineSeries1.Marks.Callout.Distance = 0;
      this.lineSeries1.Marks.Callout.Draw3D = false;
      this.lineSeries1.Marks.Callout.Length = 10;
      this.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.lineSeries1.Marks.Callout.Visible = false;
      // 
      // 
      // 
      this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.lineSeries1.Title = "line1";
      // 
      // 
      // 
      this.lineSeries1.XValues.DataMember = "X";
      this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.lineSeries1.YValues.DataMember = "Y";
      // 
      // gridBand1
      // 
      this.gridBand1.Axis = this.tChart1.Axes.Left;
      // 
      // 
      // 
      this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BackColor = System.Drawing.Color.Transparent;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(12, 18);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(194, 15);
      this.label9.TabIndex = 12;
      this.label9.Text = "6 Gauge and Knob template styles";
      this.label9.UseMnemonic = false;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.BackColor = System.Drawing.Color.Transparent;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(12, 162);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(184, 15);
      this.label10.TabIndex = 13;
      this.label10.Text = "PocketPC and WebMatrix Charts";
      this.label10.UseMnemonic = false;
      // 
      // Welcome_All
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(489, 350);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tChart1);
      this.Controls.Add(this.pictureBox5);
      this.Name = "Welcome_All";
      this.Text = "Welcome_All";
      this.Load += new System.EventHandler(this.Welcome_All_Load);
      ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
#if VS2005
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
#endif
      this.ResumeLayout(false);

		}
		#endregion

		private void Welcome_All_Load(object sender, System.EventArgs e)
		{
      lineSeries1.Color = Color.FromArgb(135, 63, 83);
			//  Set axis...
			tChart1.Axes.Left.SetMinMax(-100,100);
			tChart1.Axes.Bottom.SetMinMax(0,360);
			// Start animation
  		timer1.Start();
		}

		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			timer1.Stop();

      Random rIdx = new Random(lineSeries1.Count);
      int rnd = 0;

      if ((idx1 < 1) && ((lineSeries1.LastVisibleIndex - lineSeries1.FirstVisibleIndex) > 40))
      {
        rnd = rIdx.Next((int)((lineSeries1.LastVisibleIndex - lineSeries1.FirstVisibleIndex)));
        idx1 = lineSeries1.FirstVisibleIndex + rnd;
              
      }

			if (lineSeries1.Count > 360) { 
				if (lineSeries1.XValues.Last>540)
				{
					if (deltaUp)
					{
						lineSeries1.Add(lineSeries1.XValues.Last+1,lineSeries1.YValues.Last+r.Next(-5,45));
						if (lineSeries1.YValues.Last>54) deltaUp=false;
					}
					else
					{
						lineSeries1.Add(lineSeries1.XValues.Last+1,lineSeries1.YValues.Last+r.Next(-45,5));
						if (lineSeries1.YValues.Last<-54) deltaUp=true;
					}
				}
				else
					lineSeries1.Add(lineSeries1.XValues.Last+1,100.0*Math.Sin((lineSeries1.XValues.Last-360)*Math.PI/180));
				lineSeries1.Delete(0,1);
        idx1--;
				tChart1.Axes.Bottom.Scroll(1,false);
			}
			else lineSeries1.Add(100.0*Math.Sin(lineSeries1.Count*Math.PI/180));

      if (idx1 < lineSeries1.FirstVisibleIndex) idx1 = -1;

			timer1.Start();
		}

		private void tChart1_GetAxisLabel(object sender, Steema.TeeChart.GetAxisLabelEventArgs e)
		{
			e.LabelText="";
		}

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      if (idx1 != -1)
      {
        int adjustY = 0;
        if (((lineSeries1.CalcYPos(idx1) - 5) - tChart1.Axes.Left.CalcYPosValue(tChart1.Axes.Left.Maximum)) < (g.FontHeight + 2))
          adjustY = g.FontHeight;
        else if ((tChart1.Axes.Bottom.Position - lineSeries1.CalcYPos(idx1)) < (g.FontHeight + 2))
          adjustY = -(g.FontHeight + 2);

        g.Sphere(lineSeries1.CalcXPos(idx1), lineSeries1.CalcYPos(idx1), 0, 4);

        String msg = "Value: " + Steema.TeeChart.Utils.FormatFloat("#.00", lineSeries1.YValues[idx1]);

        g.Brush.Transparency = 50;
        g.Pen.Color = Color.DarkGray;
        g.Rectangle(lineSeries1.CalcXPos(idx1) + 5 - 1, lineSeries1.CalcYPos(idx1) + adjustY - 5,
                    lineSeries1.CalcXPos(idx1) + (int)g.TextWidth(msg) + 3 + 5 + 1,
                    lineSeries1.CalcYPos(idx1) + adjustY + g.FontHeight + 2 - 5); 
         
        g.TextOut(lineSeries1.CalcXPos(idx1) + 5, lineSeries1.CalcYPos(idx1) - 5 + adjustY, msg);
      }
    }
	}
}
