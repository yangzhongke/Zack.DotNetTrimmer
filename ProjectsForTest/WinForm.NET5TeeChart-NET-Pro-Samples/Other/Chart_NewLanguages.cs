using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Chart_NewLanguages : BaseForm
  {
    private ComboBox comboBox1;
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
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "Six new languages have been added to the TeeChart.Languages.dll.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.comboBox1);
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
      this.tChart1.Header.Visible = false;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // comboBox1
      //
#if VS2005
      this.comboBox1.FormattingEnabled = true;
#endif
      this.comboBox1.Items.AddRange(new object[] {
            "Croatian",
            "Czech",
            "Farsi",
            "Malaysian",
            "Romanian",
            "Urdu"});
      this.comboBox1.Location = new System.Drawing.Point(12, 12);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(207, 21);
      this.comboBox1.TabIndex = 0;
      this.comboBox1.Text = "Choose one of the new languages...";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // Chart_NewLanguages
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Chart_NewLanguages";
      this.Text = "Chart_NewLanguages";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public Chart_NewLanguages()
    {
      InitializeComponent();
      InitializeChart();
    }

    private Label label;

    private void InitializeChart()
    {
      tChart1.Panel.MarginTop = 20;
      tChart1.Panel.Gradient.Visible = false;
      label = new Label();
      label.Text = "About TeeChart for .Net 2014";
      label.Font = new Font("Verdana", 12);
      label.ForeColor = Color.Turquoise;
      label.Left = (tChart1.Width / 2) - 35;
      label.Top = 15;
      label.AutoSize = true;
      tChart1.Controls.Add(label);
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      label.Text = "About TeeChart for .Net 2014";
      switch (comboBox1.SelectedItem.ToString())
      {
        case "Croatian":
          Steema.TeeChart.Languages.Croatian.Activate();
          break;
        case "Czech":
          Steema.TeeChart.Languages.Czech.Activate();
          break;
        case "Farsi":
          Steema.TeeChart.Languages.Farsi.Activate();
          break;
        case "Malaysian":
          Steema.TeeChart.Languages.Malaysian.Activate();
          break;
        case "Romanian":
          Steema.TeeChart.Languages.Romanian.Activate();
          break;
        case "Urdu":
          Steema.TeeChart.Languages.Urdu.Activate();
          break;
      }
      Texts.Translator.Translate(tChart1);
      tChart1.ShowEditor();
    }
  }
}
