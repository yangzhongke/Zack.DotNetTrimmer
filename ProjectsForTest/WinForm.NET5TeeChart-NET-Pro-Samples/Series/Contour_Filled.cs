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
  public class Contour_Filled : Steema.TeeChart.Samples.BaseForm
  {
    public Contour_Filled()
    {
      InitializeComponent();
      buttonPen1.Pen = contour1.Frame;
      contour1.FillSampleValues(10);
    }

    private Steema.TeeChart.Styles.Contour contour1;
    private ButtonPen buttonPen1;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contour_Filled));
      this.contour1 = new Steema.TeeChart.Styles.Contour();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.buttonPen1 = new Steema.TeeChart.ButtonPen();
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
      this.panel1.Controls.Add(this.buttonPen1);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart1.Legend.MaxNumRows = 8;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Pen.Visible = false;
      this.tChart1.Series.Add(this.contour1);
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // contour1
      // 
      // 
      // 
      // 
      this.contour1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.contour1.ColorEach = false;
      this.contour1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.contour1.FillLevels = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.contour1.Marks.Brush.Visible = false;
      // 
      // 
      // 
      this.contour1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.contour1.Marks.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.contour1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
      this.contour1.Marks.Callout.Distance = 0;
      this.contour1.Marks.Callout.Draw3D = false;
      this.contour1.Marks.Callout.Length = 10;
      this.contour1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.contour1.Marks.Transparent = true;
      this.contour1.Marks.Visible = true;
      this.contour1.NumLevels = 8;
      this.contour1.PaletteMin = 0;
      this.contour1.PaletteStep = 0;
      this.contour1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
      // 
      // 
      // 
      this.contour1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.contour1.Pen.Style = Drawing.DashStyle.Dot;
      // 
      // 
      // 
      this.contour1.Pointer.HorizSize = 2;
      // 
      // 
      // 
      this.contour1.Pointer.Pen.Visible = false;
      this.contour1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.contour1.Pointer.VertSize = 2;
      this.contour1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.contour1.Title = "contour1";
      // 
      // 
      // 
      this.contour1.XValues.DataMember = "X";
      this.contour1.YPosition = 0.18959828428699516;
      // 
      // 
      // 
      this.contour1.YValues.DataMember = "Y";
      // 
      // 
      // 
      this.contour1.ZValues.DataMember = "Z";
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(25, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Edit";
#if VS2005
      this.button1.UseVisualStyleBackColor = true;
#endif
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Location = new System.Drawing.Point(106, 10);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Pattern";
#if VS2005
      this.button2.UseVisualStyleBackColor = true;
#endif
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // buttonPen1
      // 
      this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonPen1.Location = new System.Drawing.Point(187, 10);
      this.buttonPen1.Name = "buttonPen1";
      this.buttonPen1.Size = new System.Drawing.Size(75, 23);
      this.buttonPen1.TabIndex = 2;
      this.buttonPen1.Text = "Frame";
#if VS2005
      this.buttonPen1.UseVisualStyleBackColor = true;
#endif
      // 
      // Contour_Filled
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Contour_Filled";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private void button1_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.Series.ContourSeries form = new Steema.TeeChart.Editors.Series.ContourSeries(contour1);
      Steema.TeeChart.Editors.EditorUtils.Translate(form);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(form);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.BrushEditor bredit = new Steema.TeeChart.Editors.BrushEditor(contour1.Brush);
      Steema.TeeChart.Editors.EditorUtils.Translate(bredit);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(bredit);
    }

  }
}

