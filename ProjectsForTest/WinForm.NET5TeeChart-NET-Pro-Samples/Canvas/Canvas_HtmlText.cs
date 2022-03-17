using System;
using System.Collections.Generic;
using System.Text;

namespace Steema.TeeChart.Samples
{
  public class Canvas_HtmlText : BaseForm
  {
    private System.Windows.Forms.CheckBox checkBox1;
    private Styles.Bar bar1;
  
    public Canvas_HtmlText() : base()
    {
      InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      bar1.FillSampleValues();
      bar1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both;
      bar1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both;

      string text = "Hello <b>World !</b>";

      tChart1.Axes.Left.Title.Caption = text;
      tChart1.Axes.Right.Title.Caption = text;
      tChart1.Axes.Top.Title.Caption = text;
      tChart1.Axes.Bottom.Title.Caption = text;

      tChart1.Axes.Left.Title.TextFormat = Steema.TeeChart.Drawing.TextFormat.Html;
      tChart1.Axes.Right.Title.TextFormat = Steema.TeeChart.Drawing.TextFormat.Html;
      tChart1.Axes.Top.Title.TextFormat = Steema.TeeChart.Drawing.TextFormat.Html;
      tChart1.Axes.Bottom.Title.TextFormat = Steema.TeeChart.Drawing.TextFormat.Html;

      tChart1.Axes.Left.Title.Transparent = false;
      tChart1.Axes.Right.Title.Transparent = false;
      tChart1.Axes.Top.Title.Transparent = false;
      tChart1.Axes.Bottom.Title.Transparent = false;
    }

    private void InitializeComponent()
    {
      this.bar1 = new Steema.TeeChart.Styles.Bar();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "The TextFormat property and enum allows for the use of some HTML tags in the text" +
    "\r\nof the base TextShape class.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.checkBox1);
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
      this.tChart1.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Header.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Header.Shadow.Height = 0;
      this.tChart1.Header.Shadow.Width = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Series.Add(this.bar1);
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
      this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // bar1
      // 
      this.bar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.ColorEach = false;
      this.bar1.OriginalCursor = null;
      // 
      // 
      // 
      this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.bar1.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
      this.bar1.Title = "bar1";
      // 
      // 
      // 
      this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(12, 6);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(71, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "Html Text";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // Canvas_HtmlText
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Canvas_HtmlText";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      tChart1.Axes.Left.Title.TextFormat = checkBox1.Checked ? Steema.TeeChart.Drawing.TextFormat.Html : Steema.TeeChart.Drawing.TextFormat.Normal;
      tChart1.Axes.Top.Title.TextFormat = checkBox1.Checked ? Steema.TeeChart.Drawing.TextFormat.Html : Steema.TeeChart.Drawing.TextFormat.Normal;
      tChart1.Axes.Right.Title.TextFormat = checkBox1.Checked ? Steema.TeeChart.Drawing.TextFormat.Html : Steema.TeeChart.Drawing.TextFormat.Normal;
      tChart1.Axes.Bottom.Title.TextFormat = checkBox1.Checked ? Steema.TeeChart.Drawing.TextFormat.Html : Steema.TeeChart.Drawing.TextFormat.Normal;
    }
  }
}
