using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Legend_SymbolShadow : Steema.TeeChart.Samples.BaseForm
  {
    private Button button1;
    private Steema.TeeChart.Styles.Surface surface1;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legend_SymbolShadow));
        this.button1 = new System.Windows.Forms.Button();
        this.surface1 = new Steema.TeeChart.Styles.Surface();
        this.panel1.SuspendLayout();
        this.chartContainer.SuspendLayout();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Text = "Legend Symbol Shadows.";
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
        
        this.tChart1.Aspect.ZOffset = 0;
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
        this.tChart1.Header.Brush.Gradient.UseMiddle = true;
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
        this.tChart1.Legend.Brush.Gradient.UseMiddle = true;
        this.tChart1.Legend.MaxNumRows = 8;
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.tChart1.Legend.Symbol.Shadow.Height = 3;
        this.tChart1.Legend.Symbol.Shadow.Visible = true;
        this.tChart1.Legend.Symbol.Shadow.Width = 3;
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
        // 
        // 
        // 
        this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
        this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Panel.Brush.Gradient.Sigma = true;
        this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
        this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
        this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Series.Add(this.surface1);
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
        this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
        this.tChart1.Walls.Back.Brush.Gradient.UseMiddle = true;
        this.tChart1.Walls.Back.Brush.Visible = false;
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
        this.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = true;
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
        this.tChart1.Walls.Left.Brush.Gradient.UseMiddle = true;
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
        this.tChart1.Walls.Right.Brush.Gradient.UseMiddle = true;
        // 
        // button1
        // 
        this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.button1.Location = new System.Drawing.Point(12, 6);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(188, 23);
        this.button1.TabIndex = 0;
        this.button1.Text = "Legend Symbol Shadow Editor...";
#if VS2005
        this.button1.UseVisualStyleBackColor = true;
#endif
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // surface1
        // 
        // 
        // 
        // 
        this.surface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
        this.surface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
        this.surface1.ColorEach = false;
        // 
        // 
        // 
        // 
        // 
        // 
        this.surface1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
        this.surface1.Marks.Callout.ArrowHeadSize = 8;
        // 
        // 
        // 
        this.surface1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
        this.surface1.Marks.Callout.Distance = 0;
        this.surface1.Marks.Callout.Draw3D = false;
        this.surface1.Marks.Callout.Length = 10;
        this.surface1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        this.surface1.Marks.Callout.Visible = false;
        this.surface1.PaletteMin = 0;
        this.surface1.PaletteStep = 0;
        this.surface1.Title = "surface1";
        this.surface1.UseColorRange = false;
        this.surface1.UsePalette = true;
        // 
        // 
        // 
        this.surface1.XValues.DataMember = "X";
        // 
        // 
        // 
        this.surface1.YValues.DataMember = "Y";
        // 
        // 
        // 
        this.surface1.ZValues.DataMember = "Z";
        // 
        // Legend_SymbolShadow
        // 
#if VS2005
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
        this.ClientSize = new System.Drawing.Size(440, 317);
        this.Name = "Legend_SymbolShadow";
        this.Text = "Legend_SymbolShadow";
        this.panel1.ResumeLayout(false);
        this.chartContainer.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public Legend_SymbolShadow()
    {
      InitializeComponent();
      surface1.FillSampleValues();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.ShadowEditor ediShad = new Steema.TeeChart.Editors.ShadowEditor(tChart1.Legend.Symbol.Shadow);
      Steema.TeeChart.Editors.EditorUtils.Translate(ediShad);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(ediShad);
    }
  }
}