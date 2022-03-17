using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using System.Runtime.InteropServices;

namespace Steema.TeeChart.Samples
{
	public class Axis_Isometric : Steema.TeeChart.Samples.BaseForm
	{
    private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Line line1;
		private System.ComponentModel.IContainer components = null;

    private void MakeIsometric(Axis vertical, Axis horizontal)
    {
      if ((vertical.Chart.Width > 0) && (vertical.Chart.Height > 0))
      {
        // setup values
        double xrange = horizontal.Maximum - horizontal.Minimum;
        double yrange = vertical.Maximum - vertical.Minimum;
        double tmpx = xrange/(double)vertical.Chart.Width;
        double tmpy = yrange/(double)vertical.Chart.Height;

        Screen screen = Screen.FromControl(this);
        Graphics g = Graphics.FromHwnd(this.Handle);        
        IntPtr hptr = g.GetHdc();
        double xyscreen = GetDeviceCaps(hptr,HORZSIZE)*screen.Bounds.Height;
        xyscreen /= (double)GetDeviceCaps(hptr,VERTSIZE)*screen.Bounds.Width;
        g.ReleaseHdc(hptr);
        g.Dispose();

        tmpy *= xyscreen;
        double offset = 0.0;
        if (tmpx > tmpy)
        {
          if (tmpy != 0.0)
          {
            offset = 0.5*(yrange*tmpx/tmpy-yrange);
            vertical.SetMinMax(vertical.Minimum-offset,vertical.Maximum+offset);
          }
        }
        else if (tmpx < tmpy)
        {
          if (tmpx != 0.0)
          {
            offset = 0.5*(xrange*tmpy/tmpx-xrange);
            horizontal.SetMinMax(horizontal.Minimum-offset,horizontal.Maximum+offset);
          }
        }
      }
    }

    private void MakeIsometric(Styles.Series series)
    {
      MakeIsometric(series.GetVertAxis,series.GetHorizAxis);
    }

    public Axis_Isometric()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
      
      tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
      tChart1.Axes.Left.Grid.Color = Color.Black;
      tChart1.Axes.Left.Increment = 50.0;
      tChart1.Axes.Left.Labels.Separation = 0;

      tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
      tChart1.Axes.Bottom.Grid.Color = Color.Black;
      tChart1.Axes.Bottom.Increment = 50.0;
      tChart1.Axes.Bottom.Labels.Separation = 0;

      Random r = new Random();
      for (int i=1; i<=100; i++)
        line1.Add(i,r.Next(1,100));

		}

    private static short HORZSIZE = 4;     // Horizontal size in millimeters 
    private static short VERTSIZE = 6;     // Vertical size in millimeters 
    [DllImport("gdi32.dll")] private static extern Int32 GetDeviceCaps(IntPtr hdc, Int32 capindex);

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
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = @"A small function lets you make two axis ""isometric"". That is, for same number of pixels, same scales according to your screen size, so grid lines form perfect ""squares"" instead of rectangle.

MakeIsoAxis(line1);

Note: Must be called after axes have recalculated min and max values. See code.";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Name = "panel1";
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
			// tChart1.Axes.Bottom.AxisPen
			// 
			this.tChart1.Axes.Bottom.AxisPen.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.AxisPen
			// 
			this.tChart1.Axes.Top.AxisPen.Visible = false;
			this.tChart1.Axes.Top.Visible = false;
			this.tChart1.BackColor = System.Drawing.Color.White;
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
			this.tChart1.Header.Font.Name = "Verdana";
			// 
			// tChart1.Header.Font.Shadow
			// 
			// 
			// tChart1.Header.Font.Shadow.Brush
			// 
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Header.Font.Shadow.Visible = true;
			this.tChart1.Header.Lines = new string[] {
														 "Isometric Axis"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Zoomed += new System.EventHandler(this.tChart1_Zoomed);
			this.tChart1.UndoneZoom += new System.EventHandler(this.tChart1_UndoneZoom);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Make isometric";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			// 
			// line1.LinePen
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(61)), ((System.Byte)(92)), ((System.Byte)(153)));
			// 
			// line1.Pointer
			// 
			// 
			// 
			// line1.Pointer.Pen
			// 
			this.line1.Pointer.Pen.Visible = false;
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Pointer.Visible = true;
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
			// Axis_Isometric
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Axis_Isometric";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void tChart1_Zoomed(object sender, System.EventArgs e)
    {
      MakeIsometric(line1);
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      MakeIsometric(line1);
    }

    private void tChart1_UndoneZoom(object sender, System.EventArgs e)
    {
      MakeIsometric(line1);   
    }
  }
}

