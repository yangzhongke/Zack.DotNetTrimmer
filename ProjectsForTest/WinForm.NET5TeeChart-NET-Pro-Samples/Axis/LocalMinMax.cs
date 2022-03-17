using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
	public class Axis_LocalMinMax : Steema.TeeChart.Samples.BaseForm
	{
    private System.Windows.Forms.CheckBox checkBox1;
    private Steema.TeeChart.Tools.PageNumber pageNumber1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private Steema.TeeChart.Styles.Candle candle1;
		private System.ComponentModel.IContainer components = null;

		public Axis_LocalMinMax()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

		  candle1.FillSampleValues(100);
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
			this.pageNumber1 = new Steema.TeeChart.Tools.PageNumber();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.candle1 = new Steema.TeeChart.Styles.Candle();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "It\'s easy to use the Series Value lists to find the minimum and maximum of a \"win" +
				"dow\" of series points.";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
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
			this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Axes.Bottom.AxisPen.Visible = false;
			this.tChart1.Axes.Bottom.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Visible = false;
			this.tChart1.Axes.Left.AxisPen.Width = 1;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
														 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Page
			// 
			this.tChart1.Page.MaxPointsPerPage = 25;
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
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Panel.MarginTop = 10;
			this.tChart1.Series.Add(this.candle1);
			this.tChart1.Tools.Add(this.pageNumber1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Adjust vertical axis";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// pageNumber1
			// 
			this.pageNumber1.Cursor = Drawing.Cursors.Default;
			this.pageNumber1.Format = "Page {0} of {1}";
			this.pageNumber1.Left = 6;
			// 
			// pageNumber1.Shape
			// 
			this.pageNumber1.Shape.Bottom = 25;
			// 
			// pageNumber1.Shape.Brush
			// 
			this.pageNumber1.Shape.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(240)), ((System.Byte)(240)), ((System.Byte)(255)));
			this.pageNumber1.Shape.CustomPosition = true;
			this.pageNumber1.Shape.Left = 6;
			this.pageNumber1.Shape.Lines = new string[] {
															"Page {0} of {1}"};
			// 
			// pageNumber1.Shape.Pen
			// 
			this.pageNumber1.Shape.Pen.Visible = false;
			this.pageNumber1.Shape.Right = 86;
			// 
			// pageNumber1.Shape.Shadow
			// 
			this.pageNumber1.Shape.Shadow.Visible = true;
			this.pageNumber1.Shape.Top = 8;
			this.pageNumber1.Text = "Page {0} of {1}";
			this.pageNumber1.Top = 8;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(160, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "<";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(192, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(24, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = ">";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// candle1
			// 
			// 
			// candle1.Brush
			// 
			this.candle1.Brush.Color = System.Drawing.Color.Red;
			this.candle1.CloseValues = this.candle1.YValues;
			this.candle1.DateValues = this.candle1.XValues;
			this.candle1.DownCloseColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// candle1.Pointer
			// 
			this.candle1.Pointer.Draw3D = false;
			this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Title = "candle1";
			this.candle1.UpCloseColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			// 
			// candle1.XValues
			// 
			this.candle1.XValues.DataMember = "Date";
			this.candle1.XValues.DateTime = true;
			this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// candle1.YValues
			// 
			this.candle1.YValues.DataMember = "Close";
			// 
			// Axis_LocalMinMax
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Axis_LocalMinMax";
			this.Load += new System.EventHandler(this.Axis_LocalMinMax_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void FindMinMax(ValueList v, int firstPoint, int lastPoint, out double min, out double max)
    {
      min = v[firstPoint];
      max = v[lastPoint];
      for (int t=firstPoint; t<=lastPoint; t++)
      {
        if (v.Value[t] < min) min = v[t];
        else if (v.Value[t] > max) max = v[t];
      }
    }

    private void AdjustAxisScale(Steema.TeeChart.Styles.Series s, int firstPoint, int lastPoint, bool vertical)
    {
      double min, max;
      if (vertical)
      {
        FindMinMax(s.YValues,firstPoint,lastPoint,out min, out max);
        s.GetVertAxis.Automatic = false;
        s.GetVertAxis.SetMinMax(min,max);
      }
      else
      {
        FindMinMax(s.XValues,firstPoint,lastPoint, out min, out max);
        s.GetHorizAxis.Automatic = false;
        s.GetHorizAxis.SetMinMax(min,max);
      }
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      tChart1.Page.Previous();
      if (checkBox1.Checked) AdjustAxisScale(candle1,candle1.FirstVisibleIndex,candle1.LastVisibleIndex,true);
      else candle1.GetVertAxis.Automatic = true;
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      tChart1.Page.Next();
      if (checkBox1.Checked) AdjustAxisScale(candle1,candle1.FirstVisibleIndex,candle1.LastVisibleIndex,true);
      else candle1.GetVertAxis.Automatic = true;
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      candle1.Repaint();
    }

    private void Axis_LocalMinMax_Load(object sender, System.EventArgs e)
    {
    }
	}
}

