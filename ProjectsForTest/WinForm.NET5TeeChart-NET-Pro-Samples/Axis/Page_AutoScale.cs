using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Page_AutoScale : BaseForm
  {
    private CheckBox cbAutoScale;
    private Button bNext;
    private Button bBack;
    private Steema.TeeChart.Styles.Line line1;
    private Label lFirstValueIndex;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_AutoScale));
      this.bBack = new System.Windows.Forms.Button();
      this.bNext = new System.Windows.Forms.Button();
      this.cbAutoScale = new System.Windows.Forms.CheckBox();
      this.line1 = new Steema.TeeChart.Styles.Line();
      this.label1 = new System.Windows.Forms.Label();
      this.lFirstValueIndex = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "Page AutoScale automatically scales the left axis to the values displayed in \r\ncu" +
          "rrent page.\r\n\r\nThe new FirstValueIndex method returns the value index of the fir" +
          "st visible point shown\r\nin each page.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lFirstValueIndex);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.cbAutoScale);
      this.panel1.Controls.Add(this.bNext);
      this.panel1.Controls.Add(this.bBack);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ElevationFloat = 345;
      this.tChart1.Aspect.RotationFloat = 345;
      
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Automatic = true;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Dash;
      this.tChart1.Axes.Bottom.Grid.ZPosition = 0;
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
      this.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Automatic = true;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Dash;
      this.tChart1.Axes.Depth.Grid.ZPosition = 0;
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
      this.tChart1.Axes.Depth.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Automatic = true;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.tChart1.Axes.DepthTop.Grid.Style = Drawing.DashStyle.Dash;
      this.tChart1.Axes.DepthTop.Grid.ZPosition = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Left.Automatic = true;
      // 
      // 
      // 
      this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Dash;
      this.tChart1.Axes.Left.Grid.ZPosition = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Right.Automatic = true;
      // 
      // 
      // 
      this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Dash;
      this.tChart1.Axes.Right.Grid.ZPosition = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Top.Automatic = true;
      // 
      // 
      // 
      this.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Dash;
      this.tChart1.Axes.Top.Grid.ZPosition = 0;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
      this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      // 
      // 
      // 
      this.tChart1.Header.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Header.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.tChart1.Header.Lines = new string[] {
        "Page AutoScale"};
      // 
      // 
      // 
      this.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Gradient.UseMiddle = true;
      // 
      // 
      // 
      this.tChart1.Legend.DividingLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Shadow.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Font.Bold = true;
      
      // 
      // 
      // 
      this.tChart1.Legend.Title.Pen.Visible = false;
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
      this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
      this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Gradient.Sigma = true;
      this.tChart1.Panel.Gradient.SigmaFocus = 1F;
      this.tChart1.Panel.Gradient.SigmaScale = 0.8F;
      this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Gradient.UseMiddle = true;
      this.tChart1.Panel.Gradient.Visible = true;
      // 
      // 
      // 
      this.tChart1.Panel.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Series.Add(this.line1);
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
      // 
      // 
      this.tChart1.Walls.Back.AutoHide = false;
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      // 
      // 
      // 
      this.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Back.Gradient.UseMiddle = true;
      this.tChart1.Walls.Back.Brush.Visible = false;
      // 
      // 
      // 
      this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.AutoHide = false;
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Bottom.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Gradient.UseMiddle = true;
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Walls.Left.AutoHide = false;
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
      // 
      // 
      // 
      this.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Left.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Gradient.UseMiddle = true;
      // 
      // 
      // 
      this.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Walls.Right.AutoHide = false;
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
      // 
      // 
      // 
      this.tChart1.Walls.Right.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Right.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Right.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Right.Gradient.UseMiddle = true;
      // 
      // 
      // 
      this.tChart1.Walls.Right.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // bBack
      // 
      this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.bBack.Location = new System.Drawing.Point(12, 10);
      this.bBack.Name = "bBack";
      this.bBack.Size = new System.Drawing.Size(75, 23);
      this.bBack.TabIndex = 0;
      this.bBack.Text = "<<";
#if VS2005
      this.bBack.UseVisualStyleBackColor = true;
#endif
      this.bBack.Click += new System.EventHandler(this.bBack_Click);
      // 
      // bNext
      // 
      this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.bNext.Location = new System.Drawing.Point(93, 10);
      this.bNext.Name = "bNext";
      this.bNext.Size = new System.Drawing.Size(75, 23);
      this.bNext.TabIndex = 1;
      this.bNext.Text = ">>";
#if VS2005
      this.bNext.UseVisualStyleBackColor = true;
#endif
      this.bNext.Click += new System.EventHandler(this.bNext_Click);
      // 
      // cbAutoScale
      // 
#if VS2005
      this.cbAutoScale.AutoSize = true;
#endif
      this.cbAutoScale.Checked = true;
      this.cbAutoScale.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbAutoScale.Location = new System.Drawing.Point(183, 14);
      this.cbAutoScale.Name = "cbAutoScale";
      this.cbAutoScale.Size = new System.Drawing.Size(75, 17);
      this.cbAutoScale.TabIndex = 2;
      this.cbAutoScale.Text = "AutoScale";
#if VS2005
      this.cbAutoScale.UseVisualStyleBackColor = true;
#endif
      this.cbAutoScale.Click += new System.EventHandler(this.cbAutoScale_Click);
      // 
      // line1
      // 
      // 
      // 
      // 
      this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
      // 
      // 
      // 
      this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(46)))), ((int)(((byte)(26)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.line1.Marks.Callout.ArrowHeadSize = 8;
      this.line1.Marks.Callout.Distance = 0;
      this.line1.Marks.Callout.Draw3D = false;
      this.line1.Marks.Callout.Length = 10;
      this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      // 
      // 
      // 
      // 
      // 
      this.line1.Marks.Shadow.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Marks.Symbol.Shadow.Visible = true;
      // 
      // 
      // 
      this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.line1.Title = "line1";
      // 
      // 
      // 
      this.line1.XValues.DataMember = "X";
      this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line1.YValues.DataMember = "Y";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(264, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "FirstValue Index:";
      // 
      // lFirstValueIndex
      // 
      this.lFirstValueIndex.AutoSize = true;
      this.lFirstValueIndex.Location = new System.Drawing.Point(346, 15);
      this.lFirstValueIndex.Name = "lFirstValueIndex";
      this.lFirstValueIndex.Size = new System.Drawing.Size(13, 13);
      this.lFirstValueIndex.TabIndex = 4;
      this.lFirstValueIndex.Text = "0";
      // 
      // Page_AutoScale
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Page_AutoScale";
      this.Text = "Page_AutoScale";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public Page_AutoScale()
    {
      InitializeComponent();
      line1.FillSampleValues(100);
      tChart1.Page.MaxPointsPerPage = 10;
      tChart1.Aspect.View3D = false;
      tChart1.Page.Current = 4;
      tChart1.Page.AutoScale = true;
      lFirstValueIndex.Text = tChart1.Page.FirstValueIndex().ToString();
    }

    private void bBack_Click(object sender, EventArgs e)
    {
      tChart1.Page.Previous();
      lFirstValueIndex.Text = tChart1.Page.FirstValueIndex().ToString();
    }

    private void bNext_Click(object sender, EventArgs e)
    {
      tChart1.Page.Next();
      lFirstValueIndex.Text = tChart1.Page.FirstValueIndex().ToString();
    }

    private void cbAutoScale_Click(object sender, EventArgs e)
    {
      tChart1.Page.AutoScale = cbAutoScale.Checked;
    }
  }
}
