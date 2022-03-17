using Steema.TeeChart.Functions;
using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Steema.TeeChart.Samples
{
  public class Function_Kurtosis : BaseForm
  {
    private System.Windows.Forms.Button button1;
  
    public Function_Kurtosis()
      : base()
    {
      InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      tChart1.Aspect.View3D = false;

      Area area = new Area(tChart1.Chart);
      area.FillSampleValues();
      area.Smoothed = true;

      Line line = new Line(tChart1.Chart);
      line.Function = new KurtosisFunction(tChart1.Chart);
      line.DataSource = area;
      line.LinePen.Width = 4;
      line.VertAxis = VerticalAxis.Right;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      tChart1[0].FillSampleValues();
    }


    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "Kurtosis is a measure of the \"peakedness\" of the probability distribution of a re" +
    "al-valued random variable.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Header.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Header.Shadow.Height = 0;
      this.tChart1.Header.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Random!";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Function_Kurtosis
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Function_Kurtosis";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

  }
}
