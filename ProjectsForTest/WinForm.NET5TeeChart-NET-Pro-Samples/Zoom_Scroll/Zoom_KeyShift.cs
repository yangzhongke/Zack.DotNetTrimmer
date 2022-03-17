using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Zoom_KeyShift : BaseForm
  {
    public Zoom_KeyShift()
    {
      InitializeComponent();
      InitializeChart();
    }

    private bool doZoom, doScroll;

    private void InitializeChart()
    {
      cbModifier.Items.Add("None");
      cbModifier.Items.Add("Shift");
      cbModifier.Items.Add("Control");
      cbModifier.Items.Add("Alt");
      cbModifier.SelectedIndex = 0;
      doZoom = true;
      doScroll = true;
      line1.FillSampleValues(100);
    }

    private Label label1;
    private ComboBox cbModifier;
    private Steema.TeeChart.Styles.Line line1;
    private CheckBox cbScroll;
    private CheckBox cbZoom;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zoom_KeyShift));
        this.line1 = new Steema.TeeChart.Styles.Line();
        this.cbModifier = new System.Windows.Forms.ComboBox();
        this.label1 = new System.Windows.Forms.Label();
        this.cbZoom = new System.Windows.Forms.CheckBox();
        this.cbScroll = new System.Windows.Forms.CheckBox();
        this.panel1.SuspendLayout();
        this.chartContainer.SuspendLayout();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Text = "Zoom and Scroll can now be controlled by a modifier key (shift, control, alt) usi" +
            "ng\r\nthe KeyShift property.\r\n\r\nZoom or scroll on the chart below using the differ" +
            "ent modifiers.";
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.cbScroll);
        this.panel1.Controls.Add(this.cbZoom);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.cbModifier);
        // 
        // tChart1
        // 
        // 
        // 
        // 
        //
        //
        this.tChart1.Aspect.View3D = false;
        this.tChart1.Aspect.ZOffset = 0;
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Axes.Bottom.MaximumOffset = 4;
        this.tChart1.Axes.Bottom.MinimumOffset = 3;
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
        this.tChart1.Axes.Left.MaximumOffset = 3;
        this.tChart1.Axes.Left.MinimumOffset = 4;
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
        this.tChart1.Cursor = Cursors.Default;
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
        this.tChart1.Header.Font.Bold = true;
        // 
        // 
        // 
        this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Header.Font.Size = 12;
        this.tChart1.Header.Font.SizeFloat = 12F;
        this.tChart1.Header.Lines = new string[] {
        "ZoomScroll Key Modifiers"};
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
        this.tChart1.Legend.TextSymbolGap = 0;
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
        this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
        this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.tChart1.Panel.Brush.Gradient.Sigma = true;
        this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
        this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
        this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
        this.tChart1.Panel.Brush.Gradient.Transparency = 2;
        this.tChart1.Series.Add(this.line1);
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
        this.tChart1.Walls.Back.Visible = false;
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
        // line1
        // 
        // 
        // 
        // 
        this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.line1.ColorEach = false;
        // 
        // 
        // 
        this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.line1.LinePen.Width = 3;
        // 
        // 
        // 
        // 
        // 
        // 
        this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
        this.line1.Marks.Callout.ArrowHeadSize = 8;
        // 
        // 
        // 
        this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
        this.line1.Marks.Callout.Distance = 0;
        this.line1.Marks.Callout.Draw3D = false;
        this.line1.Marks.Callout.Length = 10;
        this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
        this.line1.Marks.Callout.Visible = false;
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
        // cbModifier
        // 
        this.cbModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
#if VS2005
        this.cbModifier.FormattingEnabled = true;
#endif
        this.cbModifier.Location = new System.Drawing.Point(143, 10);
        this.cbModifier.Name = "cbModifier";
        this.cbModifier.Size = new System.Drawing.Size(112, 21);
        this.cbModifier.TabIndex = 0;
        this.cbModifier.SelectedIndexChanged += new System.EventHandler(this.cbModifier_SelectedIndexChanged);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(63, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(65, 13);
        this.label1.TabIndex = 1;
        this.label1.Text = "Key Modifier";
        // 
        // cbZoom
        // 
        this.cbZoom.Checked = true;
        this.cbZoom.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbZoom.Location = new System.Drawing.Point(334, 3);
        this.cbZoom.Name = "cbZoom";
        this.cbZoom.Size = new System.Drawing.Size(94, 17);
        this.cbZoom.TabIndex = 2;
        this.cbZoom.Text = "Apply to Zoom";
#if VS2005
        this.cbZoom.AutoSize = true;
        this.cbZoom.UseVisualStyleBackColor = true;
#endif
        this.cbZoom.CheckedChanged += new System.EventHandler(this.cbZoom_CheckedChanged);
        // 
        // cbScroll
        // 
        this.cbScroll.Checked = true;
        this.cbScroll.CheckState = System.Windows.Forms.CheckState.Checked;
        this.cbScroll.Location = new System.Drawing.Point(334, 19);
        this.cbScroll.Name = "cbScroll";
        this.cbScroll.Size = new System.Drawing.Size(93, 17);
        this.cbScroll.TabIndex = 3;
        this.cbScroll.Text = "Apply to Scroll";
#if VS2005
        this.cbScroll.AutoSize = true;
        this.cbScroll.UseVisualStyleBackColor = true;
#endif
        this.cbScroll.CheckedChanged += new System.EventHandler(this.cbScroll_CheckedChanged);
        // 
        // Zoom_KeyShift
        // 
#if VS2005
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
        this.ClientSize = new System.Drawing.Size(440, 317);
        this.Name = "Zoom_KeyShift";
        this.Text = "Zoom_KeyShift";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.chartContainer.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private void ApplyKeyShift()
    {
      var key = (Drawing.Keys)Enum.Parse(typeof(Drawing.Keys), cbModifier.SelectedItem.ToString());
      if (doZoom)
      {
        tChart1.Zoom.KeyShift = key;
      }
      else
      {
        tChart1.Zoom.KeyShift = Drawing.Keys.None;
      }
      if (doScroll)
      {
        tChart1.Panning.KeyShift = key;
      }
      else
      {
        tChart1.Panning.KeyShift = Drawing.Keys.None;
      }
    }

    private void cbModifier_SelectedIndexChanged(object sender, EventArgs e)
    {
      ApplyKeyShift();
    }

    private void cbZoom_CheckedChanged(object sender, EventArgs e)
    {
      doZoom = cbZoom.Checked;
      ApplyKeyShift();
    }

    private void cbScroll_CheckedChanged(object sender, EventArgs e)
    {
      doScroll = cbScroll.Checked;
      ApplyKeyShift();
    }
  }
}
