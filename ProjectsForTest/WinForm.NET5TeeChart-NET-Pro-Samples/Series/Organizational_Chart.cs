using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart;

namespace Steema.TeeChart.Samples
{
  public class Organizational_Chart : Steema.TeeChart.Samples.BaseForm
  {
    public Organizational_Chart()
    {
      InitializeComponent();
    }

    private Button button1;
    private Styles.OrgSeries s;

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
      this.textBox1.Text = "Organizational Charts display elements in hierarchical structures, such as Compan" +
          "y and  Employers.";
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
      // 
      this.tChart1.Axes.Bottom.Labels.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Footer.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Header.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.Legend.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Pen.Visible = false;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // 
      // 
      this.tChart1.SubFooter.TextAlign = Drawing.StringAlignment.Center;
      // 
      // 
      // 
      this.tChart1.SubHeader.TextAlign = Drawing.StringAlignment.Center;
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(12, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "&Edit";
#if VS2005
      this.button1.UseVisualStyleBackColor = true;
#endif
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Organizational_Chart
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Organizational_Chart";
      this.Load += new System.EventHandler(this.Organizational_Chart_Load);
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private void Organizational_Chart_Load(object sender, EventArgs e)
    {
      s = new Steema.TeeChart.Styles.OrgSeries(tChart1.Chart);
      s.Pen.Width = 2;
      s.Pen.Style = Drawing.DashStyle.Dot;
      s.FillSampleValues();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.Series.OrgChartEditor editor = new Steema.TeeChart.Editors.Series.OrgChartEditor(s);
      editor.Width = 600;
      Steema.TeeChart.Editors.EditorUtils.Translate(editor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor);
    }

  }
}

