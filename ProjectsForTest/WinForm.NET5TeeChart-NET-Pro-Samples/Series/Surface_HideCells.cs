using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;

namespace Steema.TeeChart.Samples
{
  public class Surface_HideCells : BaseForm
  {
    private CheckBox CBHideCells;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Surface_HideCells));
      this.CBHideCells = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(503, 73);
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.CBHideCells);
      this.panel1.Size = new System.Drawing.Size(503, 39);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ZOffset = 0;
      this.tChart1.Size = new System.Drawing.Size(503, 266);
      // 
      // chartContainer
      // 
      this.chartContainer.Size = new System.Drawing.Size(503, 266);
      // 
      // CBHideCells
      // 
      this.CBHideCells.Checked = true;
      this.CBHideCells.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CBHideCells.Location = new System.Drawing.Point(12, 6);
      this.CBHideCells.Name = "CBHideCells";
      this.CBHideCells.Size = new System.Drawing.Size(73, 17);
      this.CBHideCells.TabIndex = 0;
      this.CBHideCells.Text = "Hide Cells";
#if VS2005
      this.CBHideCells.AutoSize = true;
      this.CBHideCells.UseVisualStyleBackColor = true;
#endif
      this.CBHideCells.CheckedChanged += new System.EventHandler(this.CBHideCells_CheckedChanged);
      // 
      // Surface_HideCells
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(503, 378);
      this.Name = "Surface_HideCells";
      this.Text = "Surface_HideCells";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public Surface_HideCells()
    {
      InitializeComponent();
      InitializeChart();
    }


    private Surface surface;
    private Rotate rotate;

    private void InitializeChart()
    {
      tChart1.Series.Add(surface = new Surface());
      tChart1.Aspect.Chart3DPercent = 60;
      tChart1.Aspect.Elevation = 349;
      tChart1.Aspect.Orthogonal = false;
      tChart1.Aspect.Perspective = 123;
      tChart1.Aspect.Rotation = 350;
      tChart1.Aspect.Zoom = 80;
      surface.HideCells = true;
      surface.FillSampleValues();
      tChart1.Header.Text = "";
      tChart1.Tools.Add(rotate = new Rotate());
      rotate.Inertia = 80;
    }

    private void CBHideCells_CheckedChanged(object sender, EventArgs e)
    {
      surface.HideCells = CBHideCells.Checked;
    }
  }
}
