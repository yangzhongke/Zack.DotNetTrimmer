using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Tool_Rectangle : BaseForm
  {
    public Tool_Rectangle()
    {
      InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      tChart1[0].FillSampleValues();

      rectangleTool1 = new Steema.TeeChart.Tools.RectangleTool(tChart1.Chart);
      rectangleTool1.AutoSize = true;
      rectangleTool1.Text = "Rectangle";
      rectangleTool1.Click += rectangleTool1_Click;
      rectangleTool1.Dragged +=new Steema.TeeChart.Tools.RectangleToolDraggedEventHandler(rectangleTool1_Dragged);
      rectangleTool1.Dragging +=new Steema.TeeChart.Tools.RectangleToolDraggingEventHandler(rectangleTool1_Dragging);
      rectangleTool1.Resized +=new Steema.TeeChart.Tools.RectangleToolResizedEventHandler(rectangleTool1_Resized);
      rectangleTool1.Resizing +=new Steema.TeeChart.Tools.RectangleToolResizingEventHandler(rectangleTool1_Resizing);
    }

    private Steema.TeeChart.Styles.Points points1;
    private Steema.TeeChart.Tools.RectangleTool rectangleTool1;
    private Button bEditRectangleTool;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_Rectangle));
        this.points1 = new Steema.TeeChart.Styles.Points();
        this.bEditRectangleTool = new System.Windows.Forms.Button();
        this.panel1.SuspendLayout();
        this.chartContainer.SuspendLayout();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Text = "Rectangle Tool defines a fully configurable shape with text which can be dragged " +
            "and resized at runtime.\r\n\r\nClick on the \'Rectangle\' to drag and resize it.";
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.bEditRectangleTool);
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
        this.tChart1.Axes.Bottom.MaximumOffset = 5;
        this.tChart1.Axes.Bottom.MinimumOffset = 5;
        // 
        // 
        // 
        this.tChart1.Axes.Bottom.TicksInner.Visible = true;
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Depth.TicksInner.Visible = true;
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.DepthTop.TicksInner.Visible = true;
        // 
        // 
        // 
        this.tChart1.Axes.Left.MaximumOffset = 5;
        this.tChart1.Axes.Left.MinimumOffset = 5;
        // 
        // 
        // 
        this.tChart1.Axes.Left.TicksInner.Visible = true;
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Right.TicksInner.Visible = true;
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Top.TicksInner.Visible = true;
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
        this.tChart1.Header.Lines = new string[] {
        "Rectangle Tool"};
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
        this.tChart1.Series.Add(this.points1);
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
        // points1
        // 
        this.points1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.points1.ColorEach = false;
        // 
        // 
        // 
        // 
        // 
        // 
        this.points1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
        this.points1.Marks.Callout.ArrowHeadSize = 8;
        // 
        // 
        // 
        this.points1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
        this.points1.Marks.Callout.Distance = 0;
        this.points1.Marks.Callout.Draw3D = false;
        this.points1.Marks.Callout.Length = 0;
        this.points1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        this.points1.Marks.Callout.Visible = false;
        // 
        // 
        // 
        this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        this.points1.Title = "point1";
        // 
        // 
        // 
        this.points1.XValues.DataMember = "X";
        this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
        // 
        // 
        // 
        this.points1.YValues.DataMember = "Y";
        // 
        // bEditRectangleTool
        // 
        this.bEditRectangleTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.bEditRectangleTool.Location = new System.Drawing.Point(12, 6);
        this.bEditRectangleTool.Name = "bEditRectangleTool";
        this.bEditRectangleTool.Size = new System.Drawing.Size(134, 23);
        this.bEditRectangleTool.TabIndex = 0;
        this.bEditRectangleTool.Text = "Edit RectangleTool...";
#if VS2005
        this.bEditRectangleTool.UseVisualStyleBackColor = true;
#endif
        this.bEditRectangleTool.Click += new System.EventHandler(this.bEditRectangleTool_Click);
        // 
        // Tool_Rectangle
        // 
#if VS2005
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
        this.ClientSize = new System.Drawing.Size(440, 317);
        this.Name = "Tool_Rectangle";
        this.Text = "Tool_Rectangle";
        this.panel1.ResumeLayout(false);
        this.chartContainer.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private void bEditRectangleTool_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.Tools.AnnotationEditor rect = new Steema.TeeChart.Editors.Tools.AnnotationEditor(rectangleTool1);
      Steema.TeeChart.Editors.EditorUtils.Translate(rect);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(rect);
    }

    private void rectangleTool1_Click(object sender, Drawing.MouseEventArgs e)
    {
      rectangleTool1.AutoSize = false;
      rectangleTool1.Text = "Click";
    }

    private void rectangleTool1_Dragged(object sender, EventArgs e)
    {
      rectangleTool1.Text = "Dragged";
    }

    private void rectangleTool1_Dragging(object sender, EventArgs e)
    {
      rectangleTool1.Text = "Dragging";
    }

    private void rectangleTool1_Resized(object sender, EventArgs e)
    {
      rectangleTool1.Text = "Resized";
    }

    private void rectangleTool1_Resizing(object sender, EventArgs e)
    {
      rectangleTool1.Text = "Resizing";
    }
  }
}
