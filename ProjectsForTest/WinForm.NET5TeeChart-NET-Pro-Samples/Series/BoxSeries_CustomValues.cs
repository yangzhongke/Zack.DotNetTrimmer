using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Box_CustomValues : Samples.BaseForm
	{
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private Steema.TeeChart.Styles.Box box1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Box_CustomValues()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

      // add sample data
      box1.Clear();
      box1.Add(new double[11] {35, 36, 37, 38, 38, 39, 39, 40, 41, 44, 61});
      // the values aren't actualy calculated before series is drawn
      // so if you need them before, just call ReconstructFromData() method
      box1.ReconstructFromData(); 
    }

    private void UpdateDisplay()
    {
      label1.Text = "Median = " + box1.Median.ToString("0.00");
      label2.Text = "Inner Fences = [" + box1.InnerFence1.ToString("0.00") + " ; " + box1.InnerFence3.ToString("0.00") + "]";
      label3.Text = "Outer Fences = [" + box1.OuterFence1.ToString("0.00") + " ; " + box1.OuterFence3.ToString("0.00") + "]";
      label4.Text = "Adjacent Points = [" + box1.AdjacentPoint1.ToString("0.00") + " ; " + box1.AdjacentPoint3.ToString("0.00") + "]";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Box_CustomValues));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box1 = new Steema.TeeChart.Styles.Box();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 48);
            this.textBox1.Text = "Now you can fully customize all TBoxPlotSeries parameters. All you must do is set" +
                " UseCustomValues property to True and then pass your values to Quartile, InnerFe" +
                "nce and OuterFence properties.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Size = new System.Drawing.Size(466, 81);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.View3D = false;
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MaximumOffset = 16;
            this.tChart1.Axes.Bottom.MinimumOffset = 16;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 16;
            this.tChart1.Axes.Left.MinimumOffset = 16;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Bold = true;
            this.tChart1.Header.Font.Size = 7;
            this.tChart1.Header.Font.SizeFloat = 7F;
            this.tChart1.Header.Lines = new string[] {
        "BoxPlot series example"};
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.box1);
            this.tChart1.Size = new System.Drawing.Size(466, 157);
            this.tChart1.Tools.Add(this.gridBand1);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 129);
            this.chartContainer.Size = new System.Drawing.Size(466, 157);
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(24, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Custom values";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Median:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inner Fences = []";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Outer Fences = []";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adjacent points = []";
            // 
            // box1
            // 
            this.box1.AdjacentPoint3 = 5;
            this.box1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.box1.ExtrOut.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box1.ExtrOut.Style = Steema.TeeChart.Styles.PointerStyles.Star;
            this.box1.InnerFence1 = -3.5;
            this.box1.InnerFence3 = 8.5;
            // 
            // 
            // 
            this.box1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.box1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.box1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.box1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.box1.Marks.Callout.Distance = 0;
            this.box1.Marks.Callout.Draw3D = false;
            this.box1.Marks.Callout.Length = 0;
            this.box1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.box1.Marks.Callout.Visible = false;
            this.box1.Median = 2.5;
            // 
            // 
            // 
            this.box1.MedianPen.Style = Drawing.DashStyle.Dot;
            // 
            // 
            // 
            // 
            // 
            // 
            this.box1.MildOut.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box1.MildOut.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.box1.OuterFence1 = -8;
            this.box1.OuterFence3 = 13;
            // 
            // 
            // 
            // 
            // 
            // 
            this.box1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.box1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.White;
            this.box1.Pointer.Brush.Gradient.Transparency = 30;
            this.box1.Pointer.Draw3D = false;
            this.box1.Pointer.HorizSize = 15;
            // 
            // 
            // 
            this.box1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.box1.Pointer.VertSize = 15;
            this.box1.Quartile1 = 1;
            this.box1.Quartile3 = 4;
            this.box1.Title = "box1";
            // 
            // 
            // 
            this.box1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // Box_CustomValues
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Box_CustomValues";
            this.Load += new System.EventHandler(this.Box_CustomValues_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      box1.UseCustomValues = checkBox1.Checked;
      box1.Clear();
      if (box1.UseCustomValues)
      {
        box1.UseCustomValues = true;
        box1.Median = 38;
        box1.Quartile1 = 37.25;
        box1.Quartile3 = 40.75;
        // adjacent points are related with whisker lines
        box1.AdjacentPoint1 = 37; // lower whisker at 37
        box1.AdjacentPoint3 = 43; // upper whisker at 43
        // using this all added points will be extreme outliers
        box1.InnerFence1 = 39;
        box1.InnerFence3 = 39;
        box1.OuterFence1 = 39;
        box1.OuterFence3 = 39;
        // add outliers
        box1.Add(new float[4] {35,36,44,61});
      }  
      else 
      {
        box1.Add(new double[11] {35, 36, 37, 38, 38, 39, 39, 40, 41, 44, 61}); // re-add everything
        box1.ReconstructFromData();
      }
      UpdateDisplay();
    }

    private void Box_CustomValues_Load(object sender, System.EventArgs e)
    {
      UpdateDisplay();
    }

	}
}