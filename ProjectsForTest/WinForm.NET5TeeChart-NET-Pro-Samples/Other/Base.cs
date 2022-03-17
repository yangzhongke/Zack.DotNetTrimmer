using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Steema.TeeChart;

namespace Steema.TeeChart.Samples
{
  /// <summary>
  /// Summary description for BaseForm.
  /// </summary>
  public class BaseForm : System.Windows.Forms.Form
  {
    protected internal System.Windows.Forms.TextBox textBox1;
    protected System.Windows.Forms.Panel panel1;
    protected Steema.TeeChart.TChart tChart1;
    protected System.Windows.Forms.Panel chartContainer;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public BaseForm()
    {
      this.tChart1 = new Steema.TeeChart.TChart();
      InitializeComponent();

      bool old3D = tChart1.Aspect.View3D;
      Themes.Theme.ApplyChartTheme(typeof(Themes.ReportTheme), tChart1.Chart);
      tChart1.Aspect.View3D = old3D;
      tChart1.Header.Font.Size = 14;
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.chartContainer = new System.Windows.Forms.Panel();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBox1.Location = new System.Drawing.Point(0, 0);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(440, 73);
      this.textBox1.TabIndex = 1;
      this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 73);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(440, 39);
      this.panel1.TabIndex = 2;
      // 
      // chartContainer
      // 
      this.chartContainer.Controls.Add(this.tChart1);
      this.chartContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.chartContainer.Location = new System.Drawing.Point(0, 112);
      this.chartContainer.Name = "chartContainer";
      this.chartContainer.Size = new System.Drawing.Size(440, 205);
      this.chartContainer.TabIndex = 3;
      // 
      // tChart1
      // 
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
      this.tChart1.Name = "tChart1";
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      this.tChart1.TabIndex = 0;
      // 
      // BaseForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Controls.Add(this.chartContainer);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.textBox1);
      this.Name = "BaseForm";
      this.Load += new System.EventHandler(this.BaseForm_Load);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    private void textBox1_DoubleClick(object sender, System.EventArgs e)
    {
      tChart1.ShowEditor();
    }

    public void ChangeCanvas(CanvasType canvas)
    {
      switch (canvas)
      {
        //case CanvasType.GDI:
        //  tChart1.Graphics3D = new Steema.TeeChart.Drawing.Graphics3DGdi(tChart1.Chart);
        //  tChart1.Invalidate();
        //  break;
        case CanvasType.GDIPlus:
          tChart1.Graphics3D = new Steema.TeeChart.Drawing.Graphics3DGdiPlus(tChart1.Chart);
          tChart1.Invalidate();
          break;
          //case CanvasType.OpenGL:
          //  Steema.TeeChart.Drawing.GL.TeeOpenGL openGL = new Steema.TeeChart.Drawing.GL.TeeOpenGL(tChart1);
          //  tChart1.Graphics3D = new Steema.TeeChart.Drawing.GL.GraphicsGL(tChart1.Chart, openGL);
          //  openGL.Chart = tChart1;
          //  openGL.Active = true;
          //  tChart1.Invalidate();
          //  break;
      }
    }

    private void BaseForm_Load(object sender, EventArgs e)
    {
      /*if(tChart1.Series.Count == 0)
      {
        Themes.Theme.ApplyChartTheme(typeof(Themes.ReportTheme), tChart1.Chart);
      }*/
    }
  }
}
