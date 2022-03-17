using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class CircularGauge_Series : BaseForm
  {

    //private Steema.TeeChart.Styles.CircularGauge cGauge;
    private System.Timers.Timer timer1;
    private double value = 0.0;
    private NumericUpDown nUPOuter;
    private Label labelOuter;
    private NumericUpDown nUPMiddle;
    private Label labelMiddle;
    private NumericUpDown nUPInner;
    private Label labelInner;
    private NumericUpDown nUPWidth;
    private Label lblWidth;
    private Label label1;
    private Steema.TeeChart.Styles.CircularGauge cGauge;
    private bool up = true;

    public CircularGauge_Series()
    {
      InitializeComponent();
      this.Load += new EventHandler(CircularGauge_Series_Load);
    }

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
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.bEdit = new System.Windows.Forms.Button();
		this.nUPOuter = new System.Windows.Forms.NumericUpDown();
		this.labelOuter = new System.Windows.Forms.Label();
		this.nUPMiddle = new System.Windows.Forms.NumericUpDown();
		this.labelMiddle = new System.Windows.Forms.Label();
		this.nUPInner = new System.Windows.Forms.NumericUpDown();
		this.labelInner = new System.Windows.Forms.Label();
		this.nUPWidth = new System.Windows.Forms.NumericUpDown();
		this.lblWidth = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.cGauge = new Steema.TeeChart.Styles.CircularGauge();
		this.panel1.SuspendLayout();
		this.chartContainer.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.nUPOuter)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.nUPMiddle)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.nUPInner)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.nUPWidth)).BeginInit();
		this.SuspendLayout();
		// 
		// textBox1
		// 
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(564, 73);
		this.textBox1.Text = "CircularGauge provides a fully configurable and quick drawing circular gauge styl" +
			"e. New in this version is the option to change the size of the different outer b" +
			"order concentric frames of the Gauge.";
		// 
		// panel1
		// 
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.nUPWidth);
		this.panel1.Controls.Add(this.lblWidth);
		this.panel1.Controls.Add(this.nUPInner);
		this.panel1.Controls.Add(this.labelInner);
		this.panel1.Controls.Add(this.nUPMiddle);
		this.panel1.Controls.Add(this.labelMiddle);
		this.panel1.Controls.Add(this.nUPOuter);
		this.panel1.Controls.Add(this.labelOuter);
		this.panel1.Controls.Add(this.bEdit);
		this.panel1.Controls.Add(this.checkBox1);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(564, 45);
		// 
		// tChart1
		// 
		this.tChart1.Name = "tChart1";
		this.tChart1.Series.Add(this.cGauge);
		this.tChart1.Size = new System.Drawing.Size(564, 372);
		// 
		// chartContainer
		// 
		this.chartContainer.Location = new System.Drawing.Point(0, 118);
		this.chartContainer.Name = "chartContainer";
		this.chartContainer.Size = new System.Drawing.Size(564, 372);
		// 
		// checkBox1
		// 
		this.checkBox1.Checked = true;
		this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBox1.Location = new System.Drawing.Point(12, 3);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(76, 17);
		this.checkBox1.TabIndex = 0;
		this.checkBox1.Text = "Animate";
		this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
		// 
		// bEdit
		// 
		this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.bEdit.Location = new System.Drawing.Point(12, 19);
		this.bEdit.Name = "bEdit";
		this.bEdit.TabIndex = 1;
		this.bEdit.Text = "Edit...";
		this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
		// 
		// nUPOuter
		// 
		this.nUPOuter.Location = new System.Drawing.Point(314, 9);
		this.nUPOuter.Name = "nUPOuter";
		this.nUPOuter.Size = new System.Drawing.Size(49, 21);
		this.nUPOuter.TabIndex = 29;
		this.nUPOuter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nUPInner_KeyUp);
		this.nUPOuter.ValueChanged += new System.EventHandler(this.numericUpDownFramePercent_ValueChanged);
		// 
		// labelOuter
		// 
		this.labelOuter.AutoSize = true;
		this.labelOuter.Location = new System.Drawing.Point(267, 12);
		this.labelOuter.Name = "labelOuter";
		this.labelOuter.Size = new System.Drawing.Size(54, 17);
		this.labelOuter.TabIndex = 28;
		this.labelOuter.Text = "Outer %:";
		// 
		// nUPMiddle
		// 
		this.nUPMiddle.Location = new System.Drawing.Point(416, 9);
		this.nUPMiddle.Name = "nUPMiddle";
		this.nUPMiddle.Size = new System.Drawing.Size(49, 21);
		this.nUPMiddle.TabIndex = 31;
		this.nUPMiddle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nUPInner_KeyUp);
		this.nUPMiddle.ValueChanged += new System.EventHandler(this.numericUpDownFramePercent_ValueChanged);
		// 
		// labelMiddle
		// 
		this.labelMiddle.AutoSize = true;
		this.labelMiddle.Location = new System.Drawing.Point(364, 12);
		this.labelMiddle.Name = "labelMiddle";
		this.labelMiddle.Size = new System.Drawing.Size(60, 17);
		this.labelMiddle.TabIndex = 30;
		this.labelMiddle.Text = "Middle %:";
		// 
		// nUPInner
		// 
		this.nUPInner.Location = new System.Drawing.Point(511, 9);
		this.nUPInner.Name = "nUPInner";
		this.nUPInner.Size = new System.Drawing.Size(49, 21);
		this.nUPInner.TabIndex = 33;
		this.nUPInner.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nUPInner_KeyUp);
		this.nUPInner.ValueChanged += new System.EventHandler(this.numericUpDownFramePercent_ValueChanged);
		// 
		// labelInner
		// 
		this.labelInner.AutoSize = true;
		this.labelInner.Location = new System.Drawing.Point(466, 12);
		this.labelInner.Name = "labelInner";
		this.labelInner.Size = new System.Drawing.Size(54, 17);
		this.labelInner.TabIndex = 32;
		this.labelInner.Text = "Inner %:";
		// 
		// nUPWidth
		// 
		this.nUPWidth.Location = new System.Drawing.Point(214, 9);
		this.nUPWidth.Name = "nUPWidth";
		this.nUPWidth.Size = new System.Drawing.Size(39, 21);
		this.nUPWidth.TabIndex = 35;
		this.nUPWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nUPWidth_KeyUp);
		this.nUPWidth.ValueChanged += new System.EventHandler(this.nUPWidth_ValueChanged);
		// 
		// lblWidth
		// 
		this.lblWidth.AutoSize = true;
		this.lblWidth.Location = new System.Drawing.Point(163, 12);
		this.lblWidth.Name = "lblWidth";
		this.lblWidth.Size = new System.Drawing.Size(54, 17);
		this.lblWidth.TabIndex = 34;
		this.lblWidth.Text = "Width %:";
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(121, 12);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(35, 17);
		this.label1.TabIndex = 36;
		this.label1.Text = "Frame";
		// 
		// cGauge
		// 
		this.cGauge.Circled = true;
		this.cGauge.Color = System.Drawing.Color.FromArgb(((System.Byte)(68)), ((System.Byte)(102)), ((System.Byte)(163)));
		this.cGauge.ColorEach = false;
		this.cGauge.CustomBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
		this.cGauge.GreenLineEndValue = 70;
		this.cGauge.GreenLineStartValue = 0;
		this.cGauge.Maximum = 100;
		this.cGauge.Minimum = 0;
		this.cGauge.RedLineEndValue = 100;
		this.cGauge.RedLineStartValue = 80;
		this.cGauge.Legend.Visible = false;
		this.cGauge.Title = "circularGauge1";
		this.cGauge.TotalAngle = 300;
		this.cGauge.Value = 96.613414630579484;
		// 
		// cGauge.XValues
		// 
		this.cGauge.XValues.DataMember = "Angle";
		this.cGauge.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
		// 
		// cGauge.YValues
		// 
		this.cGauge.YValues.DataMember = "Y";
		// 
		// CircularGauge_Series
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
		this.ClientSize = new System.Drawing.Size(564, 490);
		this.Name = "CircularGauge_Series";
		this.Text = "CircularGauge_Series";
		this.panel1.ResumeLayout(false);
		this.chartContainer.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)(this.nUPOuter)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.nUPMiddle)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.nUPInner)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.nUPWidth)).EndInit();
		this.ResumeLayout(false);

	}

    #endregion

    private System.Windows.Forms.Button bEdit;
    private System.Windows.Forms.CheckBox checkBox1;

    private void InitializeChart()
    {
      timer1 = new System.Timers.Timer(1);
      tChart1.Header.Text = "";

      nUPOuter.Value = (int)Math.Round(cGauge.Frame.FrameElementPercents[2]);
      nUPMiddle.Value = (int)Math.Round(cGauge.Frame.FrameElementPercents[1]);
      nUPInner.Value = (int)Math.Round(cGauge.Frame.FrameElementPercents[0]);
      nUPWidth.Value = cGauge.Frame.Width;

      timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Elapsed);
      timer1.Interval = 10;
      timer1.Enabled = true;
    }

    void CircularGauge_Series_Load(object sender, EventArgs e)
    {
      InitializeChart();

    }

    public void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
      if (up)
      {
        value += 1;
      }
      else
      {
        value -= 1;
      }
      if (value > 99)
      {
        up = false;
      }
      else if (value < 1)
      {
        up = true;
      }
      cGauge.Value = value;

      tChart1.Invalidate();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      timer1.Enabled = checkBox1.Checked;
    }

    private void bEdit_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.Series.CircularGaugeSeries cGaugeEditor = new Steema.TeeChart.Editors.Series.CircularGaugeSeries(cGauge);
      Steema.TeeChart.Editors.EditorUtils.Translate(cGaugeEditor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(cGaugeEditor);
    }


    bool isChanging = false;

    private void numericUpDownFramePercent_ValueChanged(object sender, EventArgs e)
    {
      if (!isChanging)
      {
        isChanging = true;

        int val = (int)((NumericUpDown)(sender)).Value;
        if (sender == nUPOuter)
          cGauge.Frame.FrameElementPercents[2] = val;
        else if (sender == nUPMiddle)
          cGauge.Frame.FrameElementPercents[1] = val;
        else
          cGauge.Frame.FrameElementPercents[0] = val;

        double appOuter = cGauge.Frame.FrameElementPercents[2];
        double appMiddle = cGauge.Frame.FrameElementPercents[1];
        double appInner = cGauge.Frame.FrameElementPercents[0];

        Steema.TeeChart.Utils.RationaliseValues(ref appInner, ref appMiddle, ref appOuter);

        nUPOuter.Value = (int)Math.Round(appOuter);
        nUPMiddle.Value = (int)Math.Round(appMiddle);
        nUPInner.Value = (int)Math.Round(appInner);

        isChanging = false;
      }

      if (cGauge.Chart.Parent != null)
        cGauge.Chart.Parent.RefreshControl();

    }

    private void nUPInner_KeyUp(object sender, KeyEventArgs e)
    {
      numericUpDownFramePercent_ValueChanged(sender, new EventArgs());
    }

    private void nUPWidth_ValueChanged(object sender, EventArgs e)
    {
      cGauge.Frame.Width = (int)nUPWidth.Value;
      if (cGauge.Chart.Parent != null)
        cGauge.Chart.Parent.RefreshControl();
    }

    private void nUPWidth_KeyUp(object sender, KeyEventArgs e)
    {
      nUPWidth_ValueChanged(sender, new EventArgs());
    }

  }
}
