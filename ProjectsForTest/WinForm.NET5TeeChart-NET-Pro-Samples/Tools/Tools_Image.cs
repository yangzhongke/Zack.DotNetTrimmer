using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tools_Image : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Contour contourSeries1;
		private Steema.TeeChart.Styles.Points pointSeries1;
		private Steema.TeeChart.Tools.ChartImage chartImage1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;
		
		private static int OldZoom=-1;

		public Tools_Image()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			contourSeries1.FillSampleValues(20);

      Random r = new Random();
      for (int t=1; t<50; t++)
				pointSeries1.Add(1.0+r.Next(20),1.0+r.Next(20));

      // Do not expand chart margins
      pointSeries1.Pointer.InflateMargins=false;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Tools_Image));
			this.contourSeries1 = new Steema.TeeChart.Styles.Contour();
			this.pointSeries1 = new Steema.TeeChart.Styles.Points();
			this.chartImage1 = new Steema.TeeChart.Tools.ChartImage();
			this.label1 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = @"The Image tool draws a picture (bitmap, jpeg, etc) behind chart Series. This can be used for GIS (Geographical) systems, using contours over images, or any other application using images as backgrounds.
The image does zoom and scroll, following the associated series and axes.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.contourSeries1);
			this.tChart1.Series.Add(this.pointSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			this.tChart1.Tools.Add(this.chartImage1);
            // 
            // tChart1.Legend
            // 
            this.tChart1.Legend.Symbol.Visible = false;
			// 
			// contourSeries1
			// 
			// 
			// contourSeries1.Brush
			// 
			this.contourSeries1.Brush.Color = System.Drawing.Color.Red;
			this.contourSeries1.ColorEach = true;
			// 
			// contourSeries1.Marks
			// 
			// 
			// contourSeries1.Marks.Symbol
			// 
			// 
			// contourSeries1.Marks.Symbol.Shadow
			// 
			this.contourSeries1.Marks.Symbol.Shadow.Height = 1;
			this.contourSeries1.Marks.Symbol.Shadow.Visible = true;
			this.contourSeries1.Marks.Symbol.Shadow.Width = 1;
			this.contourSeries1.NumXValues = 25;
			this.contourSeries1.NumZValues = 25;
			this.contourSeries1.PaletteMin = 0;
			this.contourSeries1.PaletteStep = 0;
			this.contourSeries1.Title = "contour1";
			// 
			// contourSeries1.XValues
			// 
			this.contourSeries1.XValues.DataMember = "X";
			this.contourSeries1.YPosition = 0.20290816683830415;
			// 
			// contourSeries1.YValues
			// 
			this.contourSeries1.YValues.DataMember = "Y";
			// 
			// contourSeries1.ZValues
			// 
			this.contourSeries1.ZValues.DataMember = "Z";
			// 
			// pointSeries1
			// 
			this.pointSeries1.ColorEach = true;
			// 
			// pointSeries1.Marks
			// 
			// 
			// pointSeries1.Marks.Symbol
			// 
			// 
			// pointSeries1.Marks.Symbol.Shadow
			// 
			this.pointSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries1.Pointer
			// 
			// 
			// pointSeries1.Pointer.Brush
			// 
			this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Green;
			this.pointSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			this.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries1.Title = "point1";
			// 
			// pointSeries1.XValues
			// 
			this.pointSeries1.XValues.DataMember = "X";
			this.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries1.YValues
			// 
			this.pointSeries1.YValues.DataMember = "Y";
			// 
			// chartImage1
			// 
			//this.chartImage1.Image = ((System.Drawing.Image)(resources.GetObject("chartImage1.Image")));
			this.chartImage1.Series = this.contourSeries1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Zoom:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(60, 9);
			this.hScrollBar1.Maximum = 200;
			this.hScrollBar1.Minimum = 50;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(113, 17);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Value = 100;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(193, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Edit tool...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(312, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(87, 21);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "&Active";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Tool_Image
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Tool_Image";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			chartImage1.Active = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.Tools.ToolsEditor.ShowEditor(chartImage1);
		}

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			if (hScrollBar1.Value > OldZoom) 
        tChart1.Zoom.ZoomPercent(105);
			else  
        if (hScrollBar1.Value < OldZoom) 
          tChart1.Zoom.ZoomPercent(95);
			
			OldZoom = hScrollBar1.Value;
		}
	}
}

