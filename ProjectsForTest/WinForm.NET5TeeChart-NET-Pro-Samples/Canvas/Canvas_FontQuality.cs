using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Canvas_FontQuality : Steema.TeeChart.Samples.BaseForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Canvas_FontQuality));
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = resources.GetString("textBox1.Text");
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
      // Canvas_FontQuality
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Canvas_FontQuality";
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public Canvas_FontQuality()
    {
      InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      tChart1.Aspect.View3D = false;
      tChart1.Panel.Gradient.Visible = false;
      tChart1.Panel.Color = Color.Black;
      tChart1.Walls.Back.Gradient.Visible = false;
      tChart1.Walls.Back.Color = Color.Black;
      tChart1.AfterDraw += tChart1_AfterDraw;
    }

    void tChart1_AfterDraw(object sender, Drawing.IGraphics3D g)
    {
      int yValue = 75, xValue = 30;
      g.Font.Size = 20;
      g.Font.Color = Color.Yellow;
            //g.Font.Quality = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //g.TextOut(xValue, yValue, "The quick brown fox jumped over the lazy dog.");
            //g.Font.Quality = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            //g.TextOut(xValue, yValue += 50, "The quick brown fox jumped over the lazy dog.");
            //g.Font.Quality = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            //g.TextOut(xValue, yValue += 50, "The quick brown fox jumped over the lazy dog.");
            //g.Font.Quality = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            //g.TextOut(xValue, yValue += 50, "The quick brown fox jumped over the lazy dog.");
            //g.Font.Quality = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            //g.TextOut(xValue, yValue += 50, "The quick brown fox jumped over the lazy dog.");
            //g.Font.Quality = System.Drawing.Text.TextRenderingHint.SystemDefault;
            //g.TextOut(xValue, yValue += 50, "The quick brown fox jumped over the lazy dog.");
        }
  }
}
