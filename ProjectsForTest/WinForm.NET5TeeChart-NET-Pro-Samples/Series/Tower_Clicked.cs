using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public partial class Tower_Clicked : BaseForm
  {
    private Steema.TeeChart.Styles.Tower tower1;
    private Label label1;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tower_Clicked));
      this.tower1 = new Steema.TeeChart.Styles.Tower();
      this.label1 = new System.Windows.Forms.Label();
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
      this.panel1.Controls.Add(this.label1);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.Chart3DPercent = 65;
      this.tChart1.Aspect.Elevation = 326;
      this.tChart1.Aspect.ElevationFloat = 326;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 100;
      this.tChart1.Aspect.Rotation = 324;
      this.tChart1.Aspect.RotationFloat = 324;
      this.tChart1.Aspect.ZOffset = 0;
      this.tChart1.Aspect.Zoom = 71;
      this.tChart1.Aspect.ZoomFloat = 71;
      // 
      // 
      // 
      this.tChart1.Header.Visible = false;
      this.tChart1.Series.Add(this.tower1);
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      this.tChart1.ClickSeries += tChart1_ClickSeries;
      // 
      // tower1
      // 
      // 
      // 
      // 
      this.tower1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(233)))), ((int)(((byte)(198)))));
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
      this.tower1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(78, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Clicked Tower:";
      // 
      // Tower_Clicked
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Tower_Clicked";
      this.Text = "Tower_Clicked";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public Tower_Clicked()
    {
      InitializeComponent();
      InitializeChart();
    }

    private int oldIndex;
    private Color oldColor;

    private void InitializeChart()
    {
      this.tower1.FillSampleValues(5);
      oldIndex = -1;
    }

    private void tChart1_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, Drawing.MouseEventArgs e)
    {
      label1.Text = " Clicked Tower :  " + valueIndex.ToString() +
  "   X :  " + tower1.XValues[valueIndex].ToString("0.##") +
  "   Y :  " + tower1.YValues[valueIndex].ToString("0.##") +
  "   Z :  " + tower1.ZValues[valueIndex].ToString("0.##");

      if (valueIndex != oldIndex)
      {
        if (oldIndex != -1)
        {
          tower1.Colors[oldIndex] = oldColor;
        }
        oldColor = tower1[valueIndex].Color;
        oldIndex = valueIndex;

        tower1[valueIndex].Color = Color.Red;
      }
    }
  }
}
