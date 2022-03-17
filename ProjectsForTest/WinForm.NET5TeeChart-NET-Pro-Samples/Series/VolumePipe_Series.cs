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
  public class VolumePipe_Series : BaseForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolumePipe_Series));
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.numericUpDown2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.numericUpDown1);
      this.panel1.Controls.Add(this.label2);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.Chart3DPercent = 85;
      this.tChart1.Aspect.Orthogonal = false;
      
      
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart1.Header.Lines = new string[] {
        ""};
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
      this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
      this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.Sigma = true;
      this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
      this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
      this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
      this.tChart1.Panel.Brush.Gradient.Visible = true;
      this.tChart1.Panel.MarginBottom = 10;
      this.tChart1.Panel.MarginLeft = 10;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
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
      // 
      // 
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.BackColor = System.Drawing.SystemColors.Window;
      this.numericUpDown1.Location = new System.Drawing.Point(254, 9);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.ReadOnly = true;
      this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
      this.numericUpDown1.TabIndex = 7;
      this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(174, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Cone percent:";
      this.label2.UseMnemonic = false;
      // 
      // checkBox1
      // 
      this.checkBox1.Location = new System.Drawing.Point(325, 9);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(66, 17);
      this.checkBox1.TabIndex = 8;
      this.checkBox1.Text = "View 3D";
#if VS2005
      this.checkBox1.AutoSize = true;
      this.checkBox1.UseVisualStyleBackColor = true;
#endif
      this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.BackColor = System.Drawing.SystemColors.Window;
      this.numericUpDown2.Location = new System.Drawing.Point(122, 9);
      this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.ReadOnly = true;
      this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
      this.numericUpDown2.TabIndex = 10;
      this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Segment separation:";
      this.label1.UseMnemonic = false;
      // 
      // VolumePipe_Series
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "VolumePipe_Series";
      this.Text = "VolumePipe_Series";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public VolumePipe_Series()
    {
      InitializeComponent();
      InitializeChart();
      numericUpDown1.Value = volumePipe.ConePercent;
    }

    private NumericUpDown numericUpDown1;
    private Label label2;
    private CheckBox checkBox1;
    private NumericUpDown numericUpDown2;
    private Label label1;

    private Steema.TeeChart.Styles.VolumePipe volumePipe;

    private void InitializeChart()
    {
      tChart1.Series.Add(volumePipe = new Steema.TeeChart.Styles.VolumePipe());
      volumePipe.Brush.Gradient.Visible = true;
      volumePipe.ConePercent = 60;
      volumePipe.Separation = 6;
      numericUpDown2.Value = volumePipe.Separation;
      
      //Marks
      volumePipe.Marks.Visible = true;
      volumePipe.Marks.Gradient.Visible = true;
      volumePipe.Marks.Gradient.StartColor = Color.FromArgb(255,128, 128, 255);
      volumePipe.Marks.Gradient.EndColor = Color.MidnightBlue;
      volumePipe.Marks.Font.Color = Color.White;
      
      volumePipe.FillSampleValues();
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      volumePipe.ConePercent = (int)numericUpDown1.Value;
      volumePipe.Invalidate();
    }

    private void checkBox1_Click(object sender, EventArgs e)
    {
      tChart1.Aspect.View3D = checkBox1.Checked;
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
      volumePipe.Separation = (int)numericUpDown2.Value;
      volumePipe.Invalidate();
    }
  }
}