using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;

namespace Steema.TeeChart.Samples
{
  public class Rotate_Inertia : BaseForm
  {
    private ComboBox comboBox1;
    private Label label1;
    private Label label2;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rotate_Inertia));
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
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
      this.panel1.Controls.Add(this.comboBox1);
      this.panel1.Controls.Add(this.label1);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ZOffset = 0;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Inertia:";
      // 
      // comboBox1
      // 
#if VS2005
      this.comboBox1.FormattingEnabled = true;
#endif
      this.comboBox1.Items.AddRange(new object[] {
            "100",
            "80",
            "60",
            "40",
            "20",
            "0"});
      this.comboBox1.Location = new System.Drawing.Point(57, 9);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.Text = "80";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(212, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(129, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Drag the Chart to rotate it!";
      // 
      // Rotate_Inertia
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Rotate_Inertia";
      this.Text = "Rotate_Inertia";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public Rotate_Inertia()
    {
      InitializeComponent();
      InitializeChart();
    }

    private Points3D point3D;
    private Rotate rotate;

    private void InitializeChart()
    {
      tChart1.Aspect.Chart3DPercent = 75;
      tChart1.Aspect.Zoom = 75;
      tChart1.Aspect.Orthogonal = false;
      tChart1.Series.Add(point3D = new Points3D());
      point3D.FillSampleValues();

      tChart1.Tools.Add(rotate = new Rotate());
      rotate.Inertia = 80;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      rotate.Inertia = Convert.ToInt32(comboBox1.SelectedItem);
    }
  }
}
