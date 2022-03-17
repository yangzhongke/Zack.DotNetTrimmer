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
	public class Series_TagCloud : BaseForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Series_TagCloud));
      this.button1 = new System.Windows.Forms.Button();
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
      this.tChart1.Axes.Bottom.Title.Transparent = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Transparent = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Transparent = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Transparent = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Transparent = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Transparent = true;
      // 
      // 
      // 
      this.tChart1.Header.Lines = new string[] {
        "TagCloud"};
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
      this.tChart1.ClickSeries += tChart1_ClickSeries;
      this.tChart1.ClickBackground += new System.Windows.Forms.MouseEventHandler(this.tChart1_ClickBackground);
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(12, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(151, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Refill with Sample Values";
#if VS2005
      this.button1.UseVisualStyleBackColor = true;
#endif
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Series_TagCloud
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Series_TagCloud";
      this.Text = "Series_TagCloud";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		public Series_TagCloud()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Button button1;

		private Steema.TeeChart.Styles.TagCloud tagCloud1;
		private void InitializeChart()
		{
			tChart1.Series.Add(tagCloud1 = new Steema.TeeChart.Styles.TagCloud());
			tagCloud1.FillSampleValues();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tagCloud1.FillSampleValues();
		}

    private int idx = -1;

    private void tChart1_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, Drawing.MouseEventArgs e)
    {
      idx = valueIndex;
      tChart1.Refresh();
    }

    private void tChart1_ClickBackground(object sender, MouseEventArgs e)
    {
      idx = -1;
      tChart1.Refresh();
    }

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      if (idx != -1)
      {
        string tmpStr = tagCloud1.Labels[idx].ToString();

        int fontSize = (int)(tagCloud1.GetTagFontSize(idx) * 1.5);

        g.Pen.Width = 2;
        g.Pen.Color = tagCloud1.ValueColor(idx);
        g.Line(new Point(tagCloud1.Positions[idx].Left, tagCloud1.Positions[idx].Top + fontSize),
               new Point(tagCloud1.Positions[idx].Right, tagCloud1.Positions[idx].Top + fontSize));
      }
    }
	}
}
