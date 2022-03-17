using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Zoom_Scroll : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button bReset;
		private System.ComponentModel.IContainer components = null;

    public Zoom_Scroll()
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();

      lineSeries1.FillSampleValues(50);		

      bReset.Enabled=false;
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.bReset = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 48);
			this.textBox1.Text = "Charts can be scrolled and zoomed using the mouse or by code at runtime.\r\nZoom an" +
				"d scroll features can be customized using chart properties and events.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bReset);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Alignment = Drawing.StringAlignment.Near;
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Red;
			this.tChart1.Header.Font.Size = 7;
			this.tChart1.Header.Lines = new string[] {
																								 "Zoom + Scroll demo"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 89);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 197);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 70;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			this.tChart1.Zoomed += new System.EventHandler(this.tChart1_Zoomed);
			this.tChart1.Scroll += new System.EventHandler(this.tChart1_Scroll);
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries1.Pointer
			// 
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "lineSeries1";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.DataMember = "X";
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries1.YValues
			// 
			this.lineSeries1.YValues.DataMember = "Y";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(13, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Zoom";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(104, 8);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "&Scroll";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// bReset
			// 
			this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bReset.Location = new System.Drawing.Point(200, 8);
			this.bReset.Name = "bReset";
			this.bReset.TabIndex = 2;
			this.bReset.Text = "&Reset";
			this.bReset.Click += new System.EventHandler(this.button3_Click);
			// 
			// Zoom_Scroll
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Zoom_Scroll";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			// 110 % = zoom in 10%
			tChart1.Zoom.ZoomPercent(110);
    }

		private void button2_Click(object sender, System.EventArgs e)
		{
			// scroll 2 to the right without checking limits
			tChart1.Axes.Bottom.Scroll(2,false);
      bReset.Enabled=true;
		}

    private void button3_Click(object sender, System.EventArgs e)
    {
      tChart1.Axes.Left.Automatic=true;
      tChart1.Axes.Bottom.Automatic=true;
      bReset.Enabled=false;
      tChart1.Refresh();
    }

    private void tChart1_Zoomed(object sender, System.EventArgs e)
    {
      bReset.Enabled=true;
    }

    private void tChart1_Scroll(object sender, System.EventArgs e)
    {
      bReset.Enabled=true;
    }
	}
}

