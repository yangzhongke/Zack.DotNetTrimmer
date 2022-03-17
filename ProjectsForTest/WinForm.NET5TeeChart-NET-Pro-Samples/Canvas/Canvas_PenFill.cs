using Steema.TeeChart.Editors;
using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Canvas_PenFill : Steema.TeeChart.Samples.BaseForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "The Pen Fill property defines ChartBrush characteristics of a ChartPen object,\r\n\r" +
    "\ne.g. lineSeries.LinePen.Fill.Gradient.Visible = true;";
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
      this.tChart1.Aspect.Height3D = 7;
      this.tChart1.Aspect.Width3D = 7;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.IAxisSize = 393;
      this.tChart1.Axes.Bottom.IEndPos = 413;
      this.tChart1.Axes.Bottom.IGapSize = 0;
      this.tChart1.Axes.Bottom.IsDepthAxis = false;
      this.tChart1.Axes.Bottom.IStartPos = 20;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.IAxisSize = 7;
      this.tChart1.Axes.Depth.IEndPos = 7;
      this.tChart1.Axes.Depth.IGapSize = 0;
      this.tChart1.Axes.Depth.IsDepthAxis = true;
      this.tChart1.Axes.Depth.IStartPos = 0;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.IAxisSize = 7;
      this.tChart1.Axes.DepthTop.IEndPos = 7;
      this.tChart1.Axes.DepthTop.IGapSize = 0;
      this.tChart1.Axes.DepthTop.IsDepthAxis = true;
      this.tChart1.Axes.DepthTop.IStartPos = 0;
      // 
      // 
      // 
      this.tChart1.Axes.Left.IAxisSize = 118;
      this.tChart1.Axes.Left.IEndPos = 176;
      this.tChart1.Axes.Left.IGapSize = 0;
      this.tChart1.Axes.Left.IsDepthAxis = false;
      this.tChart1.Axes.Left.IStartPos = 58;
      this.tChart1.Axes.NumFixedAxes = 6;
      // 
      // 
      // 
      this.tChart1.Axes.Right.IAxisSize = 118;
      this.tChart1.Axes.Right.IEndPos = 176;
      this.tChart1.Axes.Right.IGapSize = 0;
      this.tChart1.Axes.Right.IsDepthAxis = false;
      this.tChart1.Axes.Right.IStartPos = 58;
      // 
      // 
      // 
      this.tChart1.Axes.Top.IAxisSize = 393;
      this.tChart1.Axes.Top.IEndPos = 413;
      this.tChart1.Axes.Top.IGapSize = 0;
      this.tChart1.Axes.Top.IsDepthAxis = false;
      this.tChart1.Axes.Top.IStartPos = 20;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 6);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(116, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Edit Pen Fill...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Canvas_PenFill
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Canvas_PenFill";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;

    public Canvas_PenFill()
    {
      InitializeComponent();
      InitializeChart();
    }

    Line lineSeries;

    private void InitializeChart()
    {
      tChart1.BeforeDraw += tChart1_BeforeDraw;
      tChart1.Header.Text = "New Pen Fill property";

      lineSeries = new Line(tChart1.Chart);
      lineSeries.FillSampleValues();

      lineSeries.LinePen.Fill.Solid = false;
      lineSeries.LinePen.EndCap = Drawing.LineCap.Round;
      lineSeries.LinePen.Width = 5;
      lineSeries.LinePen.Fill.Visible = true;
      lineSeries.LinePen.Fill.Style = Drawing.HatchStyle.LargeCheckerBoard;

      lineSeries.Brush.Gradient.Visible = true;
      lineSeries.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
      lineSeries.Brush.Gradient.ExtendedColorPalette = new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
    }

    void tChart1_BeforeDraw(object sender, Drawing.IGraphics3D g)
    {
      lineSeries.Brush.Gradient.CustomTargetRectangle = tChart1.Chart.ChartRect;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      using (PenEditor editor = new PenEditor(lineSeries.LinePen))
      {
        editor.ShowDialog();
      }
    }
  }
}
