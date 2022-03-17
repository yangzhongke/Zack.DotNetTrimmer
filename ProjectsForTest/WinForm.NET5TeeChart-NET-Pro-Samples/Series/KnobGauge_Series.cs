using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Drawing;

namespace Steema.TeeChart.Samples
{
  public class KnobGauge_Series : BaseForm
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
      this.components = new System.ComponentModel.Container();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.cBAnimate = new System.Windows.Forms.CheckBox();
      this.cBActiveCenter = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "New in this version is the KnobGauge series type. With ActiveCenter true, you can" +
          " change the Knobgauge value by mousedragging on the centre hub.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cBActiveCenter);
      this.panel1.Controls.Add(this.cBAnimate);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ZOffset = 0;
      // 
      // 
      // 
      this.tChart1.Legend.TextSymbolGap = 0;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // timer1
      // 
      this.timer1.Interval = 10;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // timer2
      // 
      this.timer2.Interval = 10;
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // cBAnimate
      // 
      this.cBAnimate.Checked = true;
      this.cBAnimate.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cBAnimate.Location = new System.Drawing.Point(31, 10);
      this.cBAnimate.Name = "cBAnimate";
      this.cBAnimate.Size = new System.Drawing.Size(80, 17);
      this.cBAnimate.TabIndex = 0;
      this.cBAnimate.Text = "Animate";
#if VS2005
      this.cBAnimate.AutoSize = true;
      this.cBAnimate.UseVisualStyleBackColor = true;
#endif
      this.cBAnimate.CheckedChanged += new System.EventHandler(this.cBAnimate_CheckedChanged);
      // 
      // cBActiveCenter
      // 
      this.cBActiveCenter.Enabled = false;
      this.cBActiveCenter.Location = new System.Drawing.Point(180, 11);
      this.cBActiveCenter.Name = "cBActiveCenter";
      this.cBActiveCenter.Size = new System.Drawing.Size(100, 17);
      this.cBActiveCenter.TabIndex = 1;
      this.cBActiveCenter.Text = "ActiveCenter";
#if VS2005
      this.cBActiveCenter.AutoSize = true;
      this.cBActiveCenter.UseVisualStyleBackColor = true;
#endif
      this.cBActiveCenter.CheckedChanged += new System.EventHandler(this.cBActiveCenter_CheckedChanged);
      // 
      // KnobGauge_Series
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "KnobGauge_Series";
      this.Text = "KnobGauge_Series";
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public KnobGauge_Series()
    {
      InitializeComponent();
      InitializeChart();
    }

    private Timer timer1;

    private KnobGauge kGauge1, kGauge2;
    private NumericGauge nGauge1, nGauge2;
    private CheckBox cBActiveCenter;
    private CheckBox cBAnimate;
    private Timer timer2;
  
    private void InitializeChart()
    {
      tChart1.Series.Add(kGauge1 = new KnobGauge());
      kGauge1.Value = 1;

      tChart1.Series.Add(kGauge2 = new KnobGauge());
      kGauge2.Value = 99;

      timer1.Enabled = true;
      timer2.Enabled = true;

      SetUpNGauge1();
      SetUpNGauge2();

      tChart1.AfterDraw += new PaintChartEventHandler(tChart1_AfterDraw);
    }

    void tChart1_AfterDraw(object sender, IGraphics3D g)
    {
      DrawNGauge1(g);
      DrawNGauge2(g);
    }

    private void SetUpNGauge1()
    {
      Axis axis = new Axis();
      axis.Horizontal = true;
      nGauge1 = new NumericGauge();
      nGauge1.HorizAxis = HorizontalAxis.Custom;
      nGauge1.CustomHorizAxis = axis;
      nGauge1.Visible = false;
      nGauge1.TextMarker.Active = false;
      nGauge1.UnitsMarker.Active = false;
      nGauge1.Horizontal = true;
      nGauge1.ValueFormat = "###.0";
      nGauge1.ValueMarker.Active = true;
      nGauge1.ValueMarker.Shape.Font.Size = 10;
      nGauge1.GaugeColorPalette = NumericGauge.LEDPalette;
    }

    private void SetUpNGauge2()
    {
      Axis axis = new Axis();
      axis.Horizontal = true;
      nGauge2 = new NumericGauge();
      nGauge2.HorizAxis = HorizontalAxis.Custom;
      nGauge2.CustomHorizAxis = axis;
      nGauge2.Visible = false;
      nGauge2.TextMarker.Active = false;
      nGauge2.UnitsMarker.Active = false;
      nGauge2.Horizontal = true;
      nGauge2.ValueFormat = "###.0";
      nGauge2.ValueMarker.Active = true;
      nGauge2.ValueMarker.Shape.Font.Size = 10;
      nGauge2.GaugeColorPalette = NumericGauge.LEDPalette;
    }

    private void DrawNGauge1(IGraphics3D g)
    {
      nGauge1.Value = kGauge1.Value;
      nGauge1.CustomBounds = CalcNGauge1Bounds();
      nGauge1.Draw(g);
    }

    private void DrawNGauge2(IGraphics3D g)
    {
      nGauge2.Value = kGauge2.Value;
      nGauge2.CustomBounds = CalcNGauge2Bounds();
      nGauge2.Draw(g);
    }

    private Rectangle CalcNGauge1Bounds()
    {
      Rectangle result = Steema.TeeChart.Utils.FromLTRB(kGauge1.CircleXCenter - 30, kGauge1.CircleRect.Bottom + 10,
        kGauge1.CircleXCenter + 30, kGauge1.CircleRect.Bottom + 40);
      return result;
    }

    private Rectangle CalcNGauge2Bounds()
    {
      Rectangle result = Steema.TeeChart.Utils.FromLTRB(kGauge2.CircleXCenter - 30, kGauge2.CircleRect.Bottom + 10,
        kGauge2.CircleXCenter + 30, kGauge2.CircleRect.Bottom + 40);
      return result;
    }


    private bool up1 = true, up2 = true;

    private void timer1_Tick(object sender, EventArgs e)
    {
      if ((int)kGauge1.Value == 100 || (int)kGauge1.Value == 0.0)
      {
        up1 = !up1;
      }

      if (up1)
      {
        kGauge1.Value += 1;
      }
      else
      {
        kGauge1.Value -= 1;
      }
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      if ((int)kGauge2.Value == 100 || (int)kGauge2.Value == 0.0)
      {
        up2 = !up2;
      }

      if (up2)
      {
        kGauge2.Value += 1;
      }
      else
      {
        kGauge2.Value -= 1;
      }
    }

    private void cBAnimate_CheckedChanged(object sender, EventArgs e)
    {
      timer1.Enabled = cBAnimate.Checked;
      timer2.Enabled = cBAnimate.Checked;
      cBActiveCenter.Enabled = !cBAnimate.Checked;
    }

    private void cBActiveCenter_CheckedChanged(object sender, EventArgs e)
    {
      kGauge1.ActiveCenter = cBActiveCenter.Checked;
      kGauge2.ActiveCenter = cBActiveCenter.Checked;
    }
  }
}
