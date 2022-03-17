using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public class Legend_DrawBehind : Steema.TeeChart.Samples.BaseForm
  {
    private CheckBox cbDrawBehind;
    private CheckBox cbWallTransparent;
    private CheckBox cbResizeChart;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legend_DrawBehind));
      this.cbDrawBehind = new System.Windows.Forms.CheckBox();
      this.cbResizeChart = new System.Windows.Forms.CheckBox();
      this.cbWallTransparent = new System.Windows.Forms.CheckBox();
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
      this.panel1.Controls.Add(this.cbWallTransparent);
      this.panel1.Controls.Add(this.cbResizeChart);
      this.panel1.Controls.Add(this.cbDrawBehind);
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
      // cbDrawBehind
      // 
#if VS2005
      this.cbDrawBehind.AutoSize = true;
      this.cbDrawBehind.UseVisualStyleBackColor = true;
#endif
      this.cbDrawBehind.Checked = true;
      this.cbDrawBehind.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbDrawBehind.Location = new System.Drawing.Point(12, 11);
      this.cbDrawBehind.Name = "cbDrawBehind";
      this.cbDrawBehind.Size = new System.Drawing.Size(123, 17);
      this.cbDrawBehind.TabIndex = 0;
      this.cbDrawBehind.Text = "Legend DrawBehind";
      this.cbDrawBehind.CheckedChanged += new System.EventHandler(this.cbDrawBehind_CheckedChanged);
      // 
      // cbResizeChart
      // 
#if VS2005
      this.cbResizeChart.AutoSize = true;
      this.cbResizeChart.UseVisualStyleBackColor = true;
#endif
      this.cbResizeChart.Location = new System.Drawing.Point(141, 11);
      this.cbResizeChart.Name = "cbResizeChart";
      this.cbResizeChart.Size = new System.Drawing.Size(83, 17);
      this.cbResizeChart.TabIndex = 1;
      this.cbResizeChart.Text = "ResizeChart";
      this.cbResizeChart.CheckedChanged += new System.EventHandler(this.cbResizeChart_CheckedChanged);
      // 
      // cbWallTransparent
      // 
#if VS2005
      this.cbWallTransparent.AutoSize = true;
      this.cbWallTransparent.UseVisualStyleBackColor = true;
#endif
      this.cbWallTransparent.Checked = true;
      this.cbWallTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbWallTransparent.Location = new System.Drawing.Point(230, 11);
      this.cbWallTransparent.Name = "cbWallTransparent";
      this.cbWallTransparent.Size = new System.Drawing.Size(135, 17);
      this.cbWallTransparent.TabIndex = 2;
      this.cbWallTransparent.Text = "Back Wall Transparent";
      this.cbWallTransparent.CheckedChanged += new System.EventHandler(this.cbWallTransparent_CheckedChanged);
      // 
      // Legend_DrawBehind
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Legend_DrawBehind";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    public Legend_DrawBehind()
    {
      InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      tChart1.Series.Add(typeof(Bar)).FillSampleValues();
      tChart1.Legend.ResizeChart = false;
      tChart1.Walls.Back.Transparent = true;
    }

    private void cbDrawBehind_CheckedChanged(object sender, EventArgs e)
    {
      tChart1.Legend.DrawBehind = cbDrawBehind.Checked;
    }

    private void cbResizeChart_CheckedChanged(object sender, EventArgs e)
    {
      tChart1.Legend.ResizeChart = cbResizeChart.Checked;
    }

    private void cbWallTransparent_CheckedChanged(object sender, EventArgs e)
    {
      tChart1.Walls.Back.Transparent = cbWallTransparent.Checked;
    }
  }
}
