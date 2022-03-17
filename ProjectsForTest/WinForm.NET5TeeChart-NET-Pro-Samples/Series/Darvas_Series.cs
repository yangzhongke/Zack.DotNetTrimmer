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
  public class Darvas_Series : BaseForm
  {
     // private int box = -1;
      private Tools.RectangleTool recttool;

      public Darvas_Series()
      {
          InitializeComponent();
          // Setup tool
          recttool = new Steema.TeeChart.Tools.RectangleTool(tChart1.Chart);
          recttool.Active = false;
          recttool.AllowDrag = false;
          recttool.AllowResize = false;
          tChart1.Tools.Add(recttool);
          InitializeChart();
      }

    private void InitializeChart()
    {
      candle1.FillSampleValues(100);

      for (int i = 0; i < candle1.Count; i++)
      {
        darvas1.Add(candle1.DateValues[i], candle1.OpenValues[i], candle1.HighValues[i], candle1.LowValues[i], candle1.CloseValues[i]);
      }
    }

    private Button button1;
    private Steema.TeeChart.Styles.Candle candle1;
    private Steema.TeeChart.Styles.Darvas darvas1;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Darvas_Series));
        this.button1 = new System.Windows.Forms.Button();
        this.candle1 = new Steema.TeeChart.Styles.Candle();
        this.darvas1 = new Steema.TeeChart.Styles.Darvas();
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
        this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
        this.tChart1.Header.Lines = new string[] {
        "Darvas Boxes example"};
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
        this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
        this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Panel.Brush.Gradient.Sigma = true;
        this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
        this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
        this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
        this.tChart1.Panel.Brush.Gradient.Visible = true;
        this.tChart1.Series.Add(this.candle1);
        this.tChart1.Series.Add(this.darvas1);
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
        this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = null;
        this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
        this.tChart1.Walls.Back.Brush.Gradient.Visible = true;
        this.tChart1.Walls.Back.Brush.Visible = true;
        this.tChart1.Walls.Back.Transparent = false;
        this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
        // 
        // button1
        // 
        this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.button1.Location = new System.Drawing.Point(12, 6);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 0;
        this.button1.Text = "Edit...";
#if VS2005
        this.button1.UseVisualStyleBackColor = true;
#endif
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // candle1
        // 
        // 
        // 
        // 
        this.candle1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
        this.candle1.CloseValues = this.candle1.YValues;
        this.candle1.ColorEach = false;
        this.candle1.DateValues = this.candle1.XValues;
        this.candle1.DefaultNullValue = 0;
        // 
        // 
        // 
        this.candle1.HighLowPen.Color = System.Drawing.Color.Black;
        // 
        // 
        // 
        this.candle1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(46)))), ((int)(((byte)(26)))));
        // 
        // 
        // 
        // 
        // 
        // 
        this.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
        this.candle1.Marks.Callout.ArrowHeadSize = 8;
        // 
        // 
        // 
        this.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
        this.candle1.Marks.Callout.Distance = 0;
        this.candle1.Marks.Callout.Draw3D = false;
        this.candle1.Marks.Callout.Length = 10;
        this.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        // 
        // 
        // 
        this.candle1.Pointer.Draw3D = false;
        this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        this.candle1.Pointer.Visible = true;
        this.candle1.Title = "candle1";
        // 
        // 
        // 
        this.candle1.XValues.DataMember = "Date";
        this.candle1.XValues.DateTime = true;
        this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
        // 
        // 
        // 
        this.candle1.YValues.DataMember = "Close";
        // 
        // darvas1
        // 
        // 
        // 
        // 
        this.darvas1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(244)))), ((int)(((byte)(158)))), ((int)(((byte)(54)))));
        this.darvas1.CloseValues = this.darvas1.YValues;
        this.darvas1.ColorEach = false;
        this.darvas1.DateValues = this.darvas1.XValues;
        this.darvas1.DefaultNullValue = 0;
        // 
        // 
        // 
        this.darvas1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(146)))), ((int)(((byte)(95)))), ((int)(((byte)(32)))));
        // 
        // 
        // 
        // 
        // 
        // 
        this.darvas1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
        this.darvas1.Marks.Callout.ArrowHeadSize = 8;
        // 
        // 
        // 
        this.darvas1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
        this.darvas1.Marks.Callout.Distance = 0;
        this.darvas1.Marks.Callout.Draw3D = false;
        this.darvas1.Marks.Callout.Length = 10;
        this.darvas1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        // 
        // 
        // 
        this.darvas1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        this.darvas1.Pointer.Visible = true;
        this.darvas1.Title = "darvas1";
        // 
        // 
        // 
        this.darvas1.XValues.DataMember = "Date";
        this.darvas1.XValues.DateTime = true;
        this.darvas1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
        // 
        // 
        // 
        this.darvas1.YValues.DataMember = "Close";
        // 
        // Darvas_Series
        // 
#if VS2005
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
        this.ClientSize = new System.Drawing.Size(440, 317);
        this.Name = "Darvas_Series";
        this.Text = "Darvas_Series";
        this.panel1.ResumeLayout(false);
        this.chartContainer.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private void button1_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.Series.DarvasEditor editor = new Steema.TeeChart.Editors.Series.DarvasEditor(darvas1);
      editor.SetParent(null);
      Steema.TeeChart.Editors.EditorUtils.Translate(editor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor);
    }

      private void tChart1_MouseMove(object sender, MouseEventArgs e)
      {
          int tmp = darvas1.Clicked(e.X,e.Y);
          recttool.Active = tmp!=-1;
          if (recttool.Active)
          {
              recttool.Bounds = darvas1.Boxes[tmp];
              recttool.Invalidate();
          }
      }
  }
}