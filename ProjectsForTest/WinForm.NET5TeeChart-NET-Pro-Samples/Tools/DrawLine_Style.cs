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
  public class DrawLine_Style : BaseForm
  {
    private Label label2;
    private ComboBox cbStyles;
    private Label label1;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawLine_Style));
      this.label1 = new System.Windows.Forms.Label();
      this.cbStyles = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.cbStyles);
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
      this.tChart1.Header.Lines = new string[] {
        "New DrawLine Styles example"};
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "New line &style:";
      // 
      // cbStyles
      // 
#if VS2005
      this.cbStyles.FormattingEnabled = true;
#endif
      this.cbStyles.Location = new System.Drawing.Point(93, 11);
      this.cbStyles.Name = "cbStyles";
      this.cbStyles.Size = new System.Drawing.Size(157, 21);
      this.cbStyles.TabIndex = 1;
      this.cbStyles.SelectedIndexChanged += new System.EventHandler(this.cbStyles_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(270, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(164, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "(click and drag left mouse button)";
      // 
      // DrawLine_Style
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "DrawLine_Style";
      this.Text = "DrawLine_Style";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public DrawLine_Style()
    {
      InitializeComponent();
      InitializeChart();
    }

    private DrawLine drawLine;
    private void InitializeChart()
    {
      FillCombo();
      tChart1.Aspect.View3D = false;
      tChart1.Series.Add(typeof(Line));
      tChart1[0].FillSampleValues();

      tChart1.Tools.Add(drawLine = new DrawLine());
      drawLine.Pen.Color = Color.Blue;
      drawLine.Pen.Width = 2;
      cbStyles.SelectedIndex = 2;
    }

    private void FillCombo()
    {
      cbStyles.Items.Add(DrawLineStyle.Ellipse);
      cbStyles.Items.Add(DrawLineStyle.HorizParallel);
      cbStyles.Items.Add(DrawLineStyle.Line);
      cbStyles.Items.Add(DrawLineStyle.Rectangle);
      cbStyles.Items.Add(DrawLineStyle.VertParallel);
    }

    private void cbStyles_SelectedIndexChanged(object sender, EventArgs e)
    {
      drawLine.Style = (DrawLineStyle)cbStyles.SelectedItem;
    }
  }
}
