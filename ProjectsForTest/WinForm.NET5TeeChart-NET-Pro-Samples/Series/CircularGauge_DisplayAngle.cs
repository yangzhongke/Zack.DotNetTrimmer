using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public class CircularGauge_DisplayAngle : BaseForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.upDisplayTotalAngle = new System.Windows.Forms.NumericUpDown();
      this.udDisplayRotationAngle = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.udTotalAngle = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.udRotationAngle = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.upDisplayTotalAngle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.udDisplayRotationAngle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.udTotalAngle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.udRotationAngle)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "The new CircularGauge Properties, DisplayTotalAngle and DisplayRotationAngle, ena" +
          "ble\r\n\"semi-circular\" or \"partial\" Circular Gauge series to be displayed.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.udRotationAngle);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.udTotalAngle);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.udDisplayRotationAngle);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.upDisplayTotalAngle);
      this.panel1.Controls.Add(this.label1);
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "DisplayTotalAngle:";
      // 
      // upDisplayTotalAngle
      // 
      this.upDisplayTotalAngle.Location = new System.Drawing.Point(43, 19);
      this.upDisplayTotalAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
      this.upDisplayTotalAngle.Name = "upDisplayTotalAngle";
      this.upDisplayTotalAngle.Size = new System.Drawing.Size(55, 20);
      this.upDisplayTotalAngle.TabIndex = 1;
      this.upDisplayTotalAngle.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
      this.upDisplayTotalAngle.ValueChanged += new System.EventHandler(this.upDisplayTotalAngle_ValueChanged);
      // 
      // udDisplayRotationAngle
      // 
      this.udDisplayRotationAngle.Location = new System.Drawing.Point(181, 19);
      this.udDisplayRotationAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
      this.udDisplayRotationAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
      this.udDisplayRotationAngle.Name = "udDisplayRotationAngle";
      this.udDisplayRotationAngle.Size = new System.Drawing.Size(55, 20);
      this.udDisplayRotationAngle.TabIndex = 3;
      this.udDisplayRotationAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
      this.udDisplayRotationAngle.ValueChanged += new System.EventHandler(this.udDisplayRotationAngle_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(125, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(111, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "DisplayRotationAngle:";
      // 
      // udTotalAngle
      // 
      this.udTotalAngle.Location = new System.Drawing.Point(285, 19);
      this.udTotalAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
      this.udTotalAngle.Name = "udTotalAngle";
      this.udTotalAngle.Size = new System.Drawing.Size(55, 20);
      this.udTotalAngle.TabIndex = 5;
      this.udTotalAngle.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
      this.udTotalAngle.ValueChanged += new System.EventHandler(this.udTotalAngle_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(259, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "TotalAngle:";
      // 
      // udRotationAngle
      // 
      this.udRotationAngle.Location = new System.Drawing.Point(373, 19);
      this.udRotationAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
      this.udRotationAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
      this.udRotationAngle.Name = "udRotationAngle";
      this.udRotationAngle.Size = new System.Drawing.Size(55, 20);
      this.udRotationAngle.TabIndex = 7;
      this.udRotationAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
      this.udRotationAngle.ValueChanged += new System.EventHandler(this.udRotationAngle_ValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(347, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "RotationAngle:";
      // 
      // timer1
      // 
      this.timer1.Interval = 10;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // CircularGauge_DisplayAngle
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "CircularGauge_DisplayAngle";
      this.Text = "CircularGauge_DisplayAngle";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.upDisplayTotalAngle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.udDisplayRotationAngle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.udTotalAngle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.udRotationAngle)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public CircularGauge_DisplayAngle()
    {
      InitializeComponent();
      InitializeChart();
    }

    private Label label1;
    private NumericUpDown udDisplayRotationAngle;
    private Label label2;
    private NumericUpDown upDisplayTotalAngle;
    private NumericUpDown udTotalAngle;
    private Label label3;
    private NumericUpDown udRotationAngle;
    private Label label4;
    private Timer timer1;

    private CircularGauge cGauge;
    private void InitializeChart()
    {
      tChart1.Series.Add(cGauge = new CircularGauge());
      cGauge.DisplayTotalAngle = 180;
      cGauge.DisplayRotationAngle = -90;
      cGauge.TotalAngle = 150;
      cGauge.RotationAngle = 90;
      cGauge.Value = 1;
      cGauge.Axis.Labels.Font.Size = 7;
      cGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, cGauge.GaugeColorPalette);
      cGauge.FaceBrush.Color = Color.FromArgb(255,255,192);
      cGauge.FaceBrush.Gradient.Visible = false;
      timer1.Enabled = true;
    }

    private void upDisplayTotalAngle_ValueChanged(object sender, EventArgs e)
    {
      cGauge.DisplayTotalAngle = (int)upDisplayTotalAngle.Value;
    }

    private void udDisplayRotationAngle_ValueChanged(object sender, EventArgs e)
    {
      cGauge.DisplayRotationAngle = (int)udDisplayRotationAngle.Value;
    }

    private void udTotalAngle_ValueChanged(object sender, EventArgs e)
    {
      cGauge.TotalAngle = (int)udTotalAngle.Value;
    }

    private void udRotationAngle_ValueChanged(object sender, EventArgs e)
    {
      cGauge.RotationAngle = (int)udRotationAngle.Value;
    }

    private bool up = true;

    private void timer1_Tick(object sender, EventArgs e)
    {
      if ((int)cGauge.Value == 100 || (int)cGauge.Value == 0.0)
      {
        up = !up;
      }

      if (up)
      {
        cGauge.Value += 1;
      }
      else
      {
        cGauge.Value -= 1;
      }
    }
  }
}
