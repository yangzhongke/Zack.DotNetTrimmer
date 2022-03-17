using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public class Custom_Smoothed : Samples.BaseForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.cbSmoothed = new System.Windows.Forms.CheckBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.rbLine = new System.Windows.Forms.RadioButton();
      this.rbArea = new System.Windows.Forms.RadioButton();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "The Line Series Smoothed property smooths the lines between the series points.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.cbSmoothed);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ZOffset = 0;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // cbSmoothed
      // 
#if VS2005
      this.cbSmoothed.AutoSize = true;
      this.cbSmoothed.TabIndex = 0;
      this.cbSmoothed.UseVisualStyleBackColor = true;
#endif
      this.cbSmoothed.Location = new System.Drawing.Point(16, 11);
      this.cbSmoothed.Name = "cbSmoothed";
      this.cbSmoothed.Size = new System.Drawing.Size(74, 17);
      this.cbSmoothed.Text = "Smoothed";
      this.cbSmoothed.Click += new System.EventHandler(this.cbSmoothed_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.rbArea);
      this.panel2.Controls.Add(this.rbLine);
      this.panel2.Location = new System.Drawing.Point(96, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(194, 32);
      this.panel2.TabIndex = 1;
      // 
      // rbLine
      // 
#if VS2005
      this.rbLine.AutoSize = true;
      this.rbLine.UseVisualStyleBackColor = true;
#endif
      this.rbLine.Checked = true;
      this.rbLine.Location = new System.Drawing.Point(12, 7);
      this.rbLine.Name = "rbLine";
      this.rbLine.Size = new System.Drawing.Size(77, 17);
      this.rbLine.TabIndex = 0;
      this.rbLine.TabStop = true;
      this.rbLine.Text = "Line Series";
      this.rbLine.CheckedChanged += new System.EventHandler(this.rbLine_CheckedChanged);
      // 
      // rbArea
      //
#if VS2005
      this.rbArea.AutoSize = true;
      this.rbArea.UseVisualStyleBackColor = true;
#endif
      this.rbArea.Location = new System.Drawing.Point(105, 8);
      this.rbArea.Name = "rbArea";
      this.rbArea.Size = new System.Drawing.Size(79, 17);
      this.rbArea.TabIndex = 1;
      this.rbArea.Text = "Area Series";
      this.rbArea.CheckedChanged += new System.EventHandler(this.rbArea_CheckedChanged);
      // 
      // Custom_Smoothed
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Custom_Smoothed";
      this.Text = "Line_Smoothed";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private RadioButton rbLine;
    private RadioButton rbArea;

    private System.Windows.Forms.CheckBox cbSmoothed;

    public Custom_Smoothed()
    {
      InitializeComponent();
      InitializeChart();
    }

    Steema.TeeChart.Styles.Series series1;

    private void InitializeChart()
    {
      tChart1.Aspect.View3D = false;
      tChart1.Legend.Visible = false;
      tChart1.Header.Font.Color = Color.FromArgb(225, 225, 255);
      tChart1.Header.Text = "Euribor";
      tChart1.Panel.Bevel.Inner = BevelStyles.None;
      tChart1.Panel.Bevel.Outer = BevelStyles.None;
      tChart1.Panel.Color = Color.White;
      tChart1.Panel.Gradient.Visible = false;
      tChart1.Axes.Left.AxisPen.Color = Color.FromArgb(120, 60, 20);
      tChart1.Axes.Left.AxisPen.Width = 4;
      tChart1.Axes.Left.MinorTicks.Visible = false;
      tChart1.Axes.Left.Grid.Color = Color.FromArgb(245, 225, 170);
      tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
      tChart1.Axes.Bottom.AxisPen.Color = Color.FromArgb(120, 60, 20);
      tChart1.Axes.Bottom.Grid.Visible = false;
      tChart1.Axes.Bottom.MinorTicks.Visible = false;
      tChart1.Axes.Bottom.AxisPen.Width = 4;
      tChart1.Walls.Back.Pen.Visible = false;
      tChart1.Walls.Back.Gradient.Visible = false;
      tChart1.Walls.Back.Color = Color.White;

      tChart1.Series.Add(series1 = new Steema.TeeChart.Styles.Line());
      series1.Color = Color.FromArgb(128, 128, 128);
      ((Custom)series1).Pointer.Style = PointerStyles.Circle;
      ((Custom)series1).Pointer.Visible = true;

      series1.FillSampleValues();
    }

    private void cbSmoothed_Click(object sender, EventArgs e)
    {
      ((Custom)series1).Smoothed = cbSmoothed.Checked;
    }

    private void rbLine_CheckedChanged(object sender, EventArgs e)
    {
      if (rbLine.Checked)
      {
        tChart1.Aspect.View3D = false;
        tChart1.Series.Remove(series1);
        series1.Chart = null;
        tChart1.Series.Add(series1 = new Steema.TeeChart.Styles.Line());
        ((Custom)series1).Pointer.Style = PointerStyles.Circle;
        ((Custom)series1).Pointer.Visible = true;
        series1.Color = Color.FromArgb(128, 128, 128);
        series1.FillSampleValues();
        ((Custom)series1).Smoothed = cbSmoothed.Checked;
      }
    }

    private void rbArea_CheckedChanged(object sender, EventArgs e)
    {
      if (rbArea.Checked)
      {
        tChart1.Aspect.View3D = true;
        tChart1.Series.Remove(series1);
        series1.Chart = null;
        tChart1.Series.Add(series1 = new Steema.TeeChart.Styles.Area());
        series1.Color = Color.FromArgb(128, 128, 128);
        series1.FillSampleValues();
        ((Custom)series1).Smoothed = cbSmoothed.Checked;
      }
        
    }
  }
}
