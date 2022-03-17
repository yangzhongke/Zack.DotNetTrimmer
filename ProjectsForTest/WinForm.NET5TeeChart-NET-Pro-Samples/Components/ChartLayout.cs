using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class ChartLayout : BaseNoChart
  {
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.HScrollBar hScrollBar3;
    private System.Windows.Forms.HScrollBar hScrollBar2;
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.HScrollBar hScrollBar1;
    private SaveFileDialog saveFileDialog1;
    private Steema.TeeChart.Components.ChartLayout l;

    public ChartLayout() : base()
    {
      InitializeComponent();

      l = new Steema.TeeChart.Components.ChartLayout();
      l.Dock = DockStyle.Fill;
      splitContainer2.Panel2.Controls.Add(l);

      for (int t = 0; t < 9; t++)
      {
        l.Add("Chart " + t.ToString()).Series.Add(typeof(FastLine)).FillSampleValues();
      }

      hScrollBar2.Value = l.ChartWidth;
      hScrollBar3.Value = l.ChartHeight;

      for (int t = 0; t < l.Charts.Count; t++)
      {
        checkedListBox1.Items.Add(l.Charts[t].Header.Text, true);
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      l.View3D = checkBox1.Checked;
    }

    private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      l.Columns = hScrollBar1.Value;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      saveFileDialog1.ShowDialog();
    }

    private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
      l.Bitmap().Save(saveFileDialog1.FileName);
    }


    private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
    {
      l.ChartWidth = hScrollBar2.Value;
    }

    private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
    {
      l.ChartHeight = hScrollBar3.Value;
    }

    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      l.Charts[e.Index].Visible = e.NewValue == CheckState.Checked;
      l.Relayout();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (checkedListBox1.SelectedIndex > -1)
        l.Charts[checkedListBox1.SelectedIndex].ShowEditor();
    }

    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.button2 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
      this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(680, 62);
      this.textBox1.Text = "The ChartLayout component is derived from the Panel class and enables the viewing" +
    "\r\nof multiple charts in a small area.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.hScrollBar1);
      this.panel1.Size = new System.Drawing.Size(680, 42);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.splitContainer2);
      this.panel2.Size = new System.Drawing.Size(680, 346);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(320, 6);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Bimap";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(95, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Columns:";
      // 
      // hScrollBar1
      // 
      this.hScrollBar1.LargeChange = 1;
      this.hScrollBar1.Location = new System.Drawing.Point(148, 11);
      this.hScrollBar1.Maximum = 20;
      this.hScrollBar1.Name = "hScrollBar1";
      this.hScrollBar1.Size = new System.Drawing.Size(139, 17);
      this.hScrollBar1.TabIndex = 1;
      this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(12, 10);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(63, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "View3D";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.button2);
      this.splitContainer2.Panel1.Controls.Add(this.label3);
      this.splitContainer2.Panel1.Controls.Add(this.label2);
      this.splitContainer2.Panel1.Controls.Add(this.hScrollBar3);
      this.splitContainer2.Panel1.Controls.Add(this.hScrollBar2);
      this.splitContainer2.Panel1.Controls.Add(this.checkedListBox1);
      this.splitContainer2.Size = new System.Drawing.Size(680, 346);
      this.splitContainer2.SplitterDistance = 187;
      this.splitContainer2.TabIndex = 1;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 292);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 8;
      this.button2.Text = "Edit...";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 42);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Height:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Width:";
      // 
      // hScrollBar3
      // 
      this.hScrollBar3.LargeChange = 1;
      this.hScrollBar3.Location = new System.Drawing.Point(47, 42);
      this.hScrollBar3.Maximum = 1000;
      this.hScrollBar3.Name = "hScrollBar3";
      this.hScrollBar3.Size = new System.Drawing.Size(108, 17);
      this.hScrollBar3.TabIndex = 5;
      this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
      // 
      // hScrollBar2
      // 
      this.hScrollBar2.LargeChange = 1;
      this.hScrollBar2.Location = new System.Drawing.Point(44, 11);
      this.hScrollBar2.Maximum = 1000;
      this.hScrollBar2.Name = "hScrollBar2";
      this.hScrollBar2.Size = new System.Drawing.Size(111, 17);
      this.hScrollBar2.TabIndex = 4;
      this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new System.Drawing.Point(6, 79);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(157, 184);
      this.checkedListBox1.TabIndex = 0;
      this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.FileName = "ChartLayout.bmp";
      this.saveFileDialog1.Filter = "Bitmap files|*.bmp";
      this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
      // 
      // ChartLayout
      // 
      this.ClientSize = new System.Drawing.Size(680, 450);
      this.Name = "ChartLayout";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

  }
}
