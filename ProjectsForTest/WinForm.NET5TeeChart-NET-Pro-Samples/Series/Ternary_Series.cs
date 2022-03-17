using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Editors.Series;
using Steema.TeeChart.Editors;

namespace Steema.TeeChart.Samples
{
  public class Ternary_Series : BaseForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ternary_Series));
      this.bEdit = new System.Windows.Forms.Button();
      this.marksTip1 = new Steema.TeeChart.Tools.MarksTip();
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
      this.panel1.Controls.Add(this.bEdit);
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
      this.tChart1.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.RightValue;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Bold = false;
      this.tChart1.Legend.Title.Font.Size = 6;
      this.tChart1.Legend.Title.Font.SizeFloat = 6F;
      this.tChart1.Legend.Title.Transparent = true;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      this.tChart1.Tools.Add(this.marksTip1);
      this.tChart1.BeforeDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_BeforeDraw);
      // 
      // bEdit
      // 
      this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.bEdit.Location = new System.Drawing.Point(12, 10);
      this.bEdit.Name = "bEdit";
      this.bEdit.Size = new System.Drawing.Size(75, 23);
      this.bEdit.TabIndex = 0;
      this.bEdit.Text = "Edit...";
#if VS2005
      this.bEdit.UseVisualStyleBackColor = true;
#endif
      this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
#if VS2005
      // 
      // marksTip1
      // 
      //this.marksTip1.BackColor = System.Drawing.SystemColors.Info;
      //this.marksTip1.ForeColor = System.Drawing.SystemColors.InfoText;
#endif
      // 
      // Ternary_Series
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Ternary_Series";
      this.Text = "Ternary_Series";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public Ternary_Series()
    {
      InitializeComponent();

      InitializeChart();
    }

    private Button bEdit;
    private Steema.TeeChart.Tools.MarksTip marksTip1;

    private Steema.TeeChart.Styles.Ternary ternary1;

    private void InitializeChart()
    {
      tChart1.Header.Text = "Ternay Series Example";
      tChart1.Series.Add(ternary1 = new Steema.TeeChart.Styles.Ternary());

      ternary1.FillSampleValues(10);
      ternary1.MarkStyle = Steema.TeeChart.Styles.TernaryMarkStyle.LongLabelled;
      ternary1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere;
      ternary1.TernaryStyle = Steema.TeeChart.Styles.TernaryStyle.Bubble;
      ternary1.Pointer.Transparency = 20;
      ternary1.TernaryLegendStyle = Steema.TeeChart.Styles.TernaryLegendStyle.BubbleWeight;
      tChart1.Legend.Title.Text = Texts.TernaryMarkRadius + ", " + Texts.TernaryMarkWeight;
      ternary1.Marks.MultiLine = true;

      ternary1.EndColor = Color.LightGreen; //for use when range palette active (ColorEach false)
      tChart1.Legend.Title.Visible = true;
    }

    private void bEdit_Click(object sender, EventArgs e)
    {
      TernarySeries editor = new TernarySeries(ternary1);
      Steema.TeeChart.Editors.EditorUtils.Translate(editor);
      EditorUtils.ShowFormModal(editor);
    }

    private void tChart1_BeforeDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      tChart1.Legend.Title.Visible = ternary1.ColorEach;
    }
  }
}
