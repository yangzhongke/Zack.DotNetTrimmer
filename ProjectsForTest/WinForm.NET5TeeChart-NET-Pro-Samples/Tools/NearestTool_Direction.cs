using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Tools;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public class NearestTool_Direction : BaseForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cbTop = new System.Windows.Forms.ComboBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "The NearestTool Direction property enables the tool to find the nearest point eit" +
    "her on\r\nthe horizontal, vertical or both planes. ";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.comboBox2);
      this.panel1.Controls.Add(this.cbTop);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      // 
      // tChart1
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
      this.tChart1.Axes.Bottom.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Bottom.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Bottom.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Bottom.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Bottom.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Depth.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Depth.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Depth.Labels.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Depth.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Depth.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Depth.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.DepthTop.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.DepthTop.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.DepthTop.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.DepthTop.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Left.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Left.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Left.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Left.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Right.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Right.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Right.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Right.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Right.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Right.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Top.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Top.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Top.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Top.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Top.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Top.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Footer.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Footer.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Footer.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Header.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Header.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Header.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Legend.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Legend.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Legend.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Legend.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Legend.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Legend.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Panel.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Panel.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.SubFooter.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.SubFooter.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.SubFooter.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.SubHeader.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.SubHeader.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.SubHeader.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Back.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Back.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Back.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Bottom.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Bottom.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Bottom.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Left.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Left.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Left.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Right.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Right.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Right.Bevel.StringColorTwo = "FF808080";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Top NearestPoint:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(216, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(107, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Bottom NearestPoint:";
      // 
      // cbTop
      // 
#if VS2005
      this.cbTop.FormattingEnabled = true;
#endif
      this.cbTop.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Both"});
      this.cbTop.Location = new System.Drawing.Point(102, 10);
      this.cbTop.Name = "cbTop";
      this.cbTop.Size = new System.Drawing.Size(108, 21);
      this.cbTop.TabIndex = 2;
      this.cbTop.Text = "Horizontal";
      this.cbTop.SelectedIndexChanged += new System.EventHandler(this.cbTop_SelectedIndexChanged);
      // 
      // comboBox2
      // 
#if VS2005
      this.comboBox2.FormattingEnabled = true;
#endif
      this.comboBox2.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Both"});
      this.comboBox2.Location = new System.Drawing.Point(320, 10);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(108, 21);
      this.comboBox2.TabIndex = 3;
      this.comboBox2.Text = "Vertical";
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
      // 
      // NearestTool_Direction
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "NearestTool_Direction";
      this.Text = "NearestTool_Direction";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    NearestPoint tool1, tool2;
    Axis vertAxis, horizAxis;
    Line line;
    HorizLine horizLine;
    Annotation anno1, anno2;
    private ComboBox comboBox2;
    private ComboBox cbTop;
    private Label label2;
    private Label label1;

    public NearestTool_Direction()
    {
      InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      tChart1.Aspect.View3D = false;
      tChart1.Header.Text = "Nearest Tool Directions";

      tChart1.MouseMove += new MouseEventHandler(tChart1_MouseMove);

      tool1 = new NearestPoint(tChart1.Chart);
      tool2 = new NearestPoint(tChart1.Chart);

      vertAxis = new Axis(false, false, tChart1.Chart);
      horizAxis = new Axis(true, false, tChart1.Chart);
      line = new Line(tChart1.Chart);
      horizLine = new HorizLine(tChart1.Chart);

      tChart1.Axes.Custom.Add(vertAxis);
      tChart1.Axes.Custom.Add(horizAxis);

      tChart1.Axes.Left.StartPosition  = 0;
      tChart1.Axes.Left.EndPosition = 45;
      vertAxis.StartPosition = 55;
      vertAxis.EndPosition = 100;
      tChart1.Axes.Bottom.Grid.Visible = false;

      line.HorizAxis = HorizontalAxis.Custom;
      line.CustomHorizAxis = horizAxis;
      line.VertAxis = VerticalAxis.Left;
      horizAxis.PositionUnits = PositionUnits.Percent;
      horizAxis.RelativePosition = 55;
      horizAxis.Grid.Visible = false;

      horizLine.VertAxis = VerticalAxis.Custom;
      horizLine.CustomVertAxis = vertAxis;
      horizLine.HorizAxis = HorizontalAxis.Bottom;

      tool1.Series = line;
      tool1.Direction = NearestPointDirection.Horizontal;
      tool1.DrawLine = false;
      tool1.Brush.Color = horizLine.Color;
      tool1.Size = 5;
      tool1.Change += new EventHandler(tool1_Change);
      tool2.Series = horizLine;
      tool2.Direction = NearestPointDirection.Vertical;
      tool2.DrawLine = false;
      tool2.Brush.Color = line.Color;
      tool2.Size = 5;
      tool2.Change += new EventHandler(tool2_Change);

      horizLine.FillSampleValues();
      line.FillSampleValues();

      anno1 = new Annotation(tChart1.Chart);
      anno2 = new Annotation(tChart1.Chart);
      anno1.Position = AnnotationPositions.LeftTop;
      anno2.Position = AnnotationPositions.RightBottom;
      anno1.Active = false;
      anno2.Active = false;
    }

    void tool2_Change(object sender, EventArgs e)
    {
      if (tool2.Point > -1) anno2.Text = "HorizLine YValue: " + line.YValues[tool2.Point];
    }

    void tool1_Change(object sender, EventArgs e)
    {
      if (tool1.Point > -1) anno1.Text = "Line YValue: " + line.YValues[tool1.Point];
    }

    void tChart1_MouseMove(object sender, MouseEventArgs e)
    {
      tool2.Active = e.Y > vertAxis.IStartPos && e.Y < vertAxis.IEndPos;
      tool1.Active = !tool2.Active;

      anno1.Active = tool1.Active;
      anno2.Active = tool2.Active;
    }

    private void cbTop_SelectedIndexChanged(object sender, EventArgs e)
    {
      tool1.Direction = (NearestPointDirection)cbTop.SelectedIndex;
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      tool2.Direction = (NearestPointDirection)comboBox2.SelectedIndex;
    }

  }
}
