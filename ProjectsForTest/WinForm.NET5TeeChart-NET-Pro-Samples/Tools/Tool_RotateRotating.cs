using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Tool_RotateRotating : BaseForm
  {
    public Tool_RotateRotating()
    {
      InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      tower1.FillSampleValues();
      label1.Text = "Rotation: " + tChart1.Aspect.Rotation.ToString();
    }

    private Label label1;
    private Steema.TeeChart.Styles.Tower tower1;
    private Steema.TeeChart.Tools.Rotate rotate1;
    private Label lRotation;
    private NumericUpDown numericUpDown1;
    private Label label2;
      private HScrollBar hScrollBar1;
      private Label label3;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_RotateRotating));
        this.tower1 = new Steema.TeeChart.Styles.Tower();
        this.rotate1 = new Steema.TeeChart.Tools.Rotate();
        this.label1 = new System.Windows.Forms.Label();
        this.lRotation = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        this.label3 = new System.Windows.Forms.Label();
        this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
        this.panel1.SuspendLayout();
        this.chartContainer.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Text = "The RotateTool has a Rotate event + Speed and Inertia properties.";
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.hScrollBar1);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.numericUpDown1);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.lRotation);
        this.panel1.Controls.Add(this.label1);
        // 
        // tChart1
        // 
        // 
        // 
        // 
        this.tChart1.Aspect.Chart3DPercent = 25;
        
        
        this.tChart1.Aspect.ZOffset = 0;
        // 
        // 
        // 
        this.tChart1.Header.Lines = new string[] {
        "RotateTool Rotate/Speed"};
        // 
        // 
        // 
        this.tChart1.Legend.MaxNumRows = 8;
        this.tChart1.Legend.Visible = false;
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
        this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Panel.Brush.Gradient.Sigma = true;
        this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
        this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
        this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Series.Add(this.tower1);
        this.tChart1.Size = new System.Drawing.Size(440, 205);
        this.tChart1.Tools.Add(this.rotate1);
        // 
        // tower1
        // 
        // 
        // 
        // 
        this.tower1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(78)))));
        this.tower1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
        this.tower1.ColorEach = false;
        // 
        // 
        // 
        // 
        // 
        // 
        this.tower1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
        this.tower1.Marks.Callout.ArrowHeadSize = 8;
        // 
        // 
        // 
        this.tower1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
        this.tower1.Marks.Callout.Distance = 0;
        this.tower1.Marks.Callout.Draw3D = false;
        this.tower1.Marks.Callout.Length = 10;
        this.tower1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        this.tower1.Marks.Callout.Visible = false;
        this.tower1.Origin = 0;
        this.tower1.PaletteMin = 0;
        this.tower1.PaletteStep = 0;
        this.tower1.Title = "tower1";
        this.tower1.UseColorRange = false;
        this.tower1.UsePalette = true;
        // 
        // 
        // 
        this.tower1.XValues.DataMember = "X";
        // 
        // 
        // 
        this.tower1.YValues.DataMember = "Y";
        // 
        // 
        // 
        this.tower1.ZValues.DataMember = "Z";
        // 
        // rotate1
        // 
        this.rotate1.Rotating += new Steema.TeeChart.Tools.RotatingEventHandler(this.rotate1_Rotating);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 14);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(50, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Rotation:";
        // 
        // lRotation
        // 
        this.lRotation.AutoSize = true;
        this.lRotation.Location = new System.Drawing.Point(62, 14);
        this.lRotation.Name = "lRotation";
        this.lRotation.Size = new System.Drawing.Size(0, 13);
        this.lRotation.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(134, 14);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(41, 13);
        this.label2.TabIndex = 2;
        this.label2.Text = "Speed:";
        // 
        // numericUpDown1
        // 
        this.numericUpDown1.Location = new System.Drawing.Point(181, 12);
        this.numericUpDown1.Name = "numericUpDown1";
        this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
        this.numericUpDown1.TabIndex = 3;
        this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
        this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(258, 14);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(36, 13);
        this.label3.TabIndex = 4;
        this.label3.Text = "Inertia";
        // 
        // hScrollBar1
        // 
        this.hScrollBar1.Location = new System.Drawing.Point(297, 10);
        this.hScrollBar1.Name = "hScrollBar1";
        this.hScrollBar1.Size = new System.Drawing.Size(118, 17);
        this.hScrollBar1.TabIndex = 5;
        this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
        // 
        // Tool_RotateRotating
        // 
#if VS2005
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
        this.ClientSize = new System.Drawing.Size(440, 317);
        this.Name = "Tool_RotateRotating";
        this.Text = "Tool_RotateRotating";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.chartContainer.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private void rotate1_Rotating(object sender, EventArgs e)
    {
      label1.Text = "Rotation: " + tChart1.Aspect.Rotation.ToString();
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      rotate1.Speed = Convert.ToInt32(numericUpDown1.Value);
    }

      private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
      {
          rotate1.Inertia = hScrollBar1.Value;
      }
  }
}