using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public class ChartBook_Demo : Steema.TeeChart.Samples.BaseNoChart
  {
    private CheckBox checkBox1;
    private ComboBox comboBox1;
    private Label label1;
    private Button button2;
    private Button button1;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartBook_Demo));
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.comboBox1);
      this.panel1.Controls.Add(this.label1);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "&Tabs position:";
      // 
      // comboBox1
      //
#if VS2005
      this.comboBox1.FormattingEnabled = true;
#endif
      this.comboBox1.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Left",
            "Right"});
      this.comboBox1.Location = new System.Drawing.Point(82, 10);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(76, 21);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.Text = "Left";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // checkBox1
      // 
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(164, 13);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(88, 17);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "&Show toolbar";
#if VS2005
      this.checkBox1.AutoSize = true;
      this.checkBox1.UseVisualStyleBackColor = true;
#endif
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(258, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "&Add...";
#if VS2005
      this.button1.UseVisualStyleBackColor = true;
#endif
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Location = new System.Drawing.Point(339, 10);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "&Delete";
#if VS2005
      this.button2.UseVisualStyleBackColor = true;
#endif
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // ChartBook_Demo
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(426, 258);
      this.Name = "ChartBook_Demo";
      this.Text = "ChartBook";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public ChartBook_Demo()
    {
      InitializeComponent();
      InitializeChart();
    }

    private ChartBook chartBook1;

    private void InitializeChart()
    {
      chartBook1 = new ChartBook();
      chartBook1.Dock = DockStyle.Fill;
      panel2.Controls.Add(chartBook1);

      chartBook1.ShowToolBar = true;
      chartBook1.HotTrack = true;
      chartBook1.AddChart().Series.Add(typeof(Line)).FillSampleValues();
      chartBook1.AddChart().Series.Add(typeof(Bar)).FillSampleValues();
      chartBook1.AddChart().Series.Add(typeof(Area)).FillSampleValues();
      chartBook1.AddChart().Series.Add(typeof(Pie)).FillSampleValues();

      chartBook1.Alignment = TabAlignment.Left;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Styles.Series tmp = chartBook1.AddChart().Series.Add(typeof(Line));
      tmp.FillSampleValues();

      tmp.Color = Themes.RandomTheme.RandomColor;

      chartBook1.SelectedIndex = chartBook1.TabCount - 1;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      chartBook1.TabPages.RemoveAt(chartBook1.SelectedIndex);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      chartBook1.ShowToolBar = checkBox1.Checked; 
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      chartBook1.Visible = false;
      chartBook1.Alignment = (TabAlignment)comboBox1.SelectedIndex;
      chartBook1.Visible = true;
    }
  }
}
