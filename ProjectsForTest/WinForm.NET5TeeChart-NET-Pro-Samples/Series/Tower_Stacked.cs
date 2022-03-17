using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;

namespace Steema.TeeChart.Samples
{
	public class Tower_Stacked : BaseForm
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
			this.cbStacked = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "New Tower Series stacked property to allow Tower Series with identical (x,z) grid" +
    "s\r\nto stack on top of each other. ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbStacked);
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
			// cbStacked
			// 
#if VS2005
			this.cbStacked.AutoSize = true;
			this.cbStacked.UseVisualStyleBackColor = true;
#endif
			this.cbStacked.Checked = true;
			this.cbStacked.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbStacked.Location = new System.Drawing.Point(12, 11);
			this.cbStacked.Name = "cbStacked";
			this.cbStacked.Size = new System.Drawing.Size(66, 17);
			this.cbStacked.TabIndex = 0;
			this.cbStacked.Text = "Stacked";
			this.cbStacked.CheckedChanged += new System.EventHandler(this.cbStacked_CheckedChanged);
			// 
			// Tower_Stacked
			// 
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Tower_Stacked";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public Tower_Stacked()
		{
			InitializeComponent();
			InitializeChart();
		}

		Tower tower1, tower2, tower3, tower4;
		private CheckBox cbStacked;

		private void InitializeChart()
		{
			tChart1.Header.Text = "Tower Stacked";

			tower1 = new Tower(tChart1.Chart);
			tower2 = new Tower(tChart1.Chart);
			tower3 = new Tower(tChart1.Chart);
			tower4 = new Tower(tChart1.Chart);


			tower1.Stacked = true;
			Random rnd = new Random();
			int sign = -1;


			foreach (Tower series in tChart1.Series)
			{
				series.UseColorRange = false;
				series.UsePalette = false;
				series.UseOrigin = true;
				series.Origin = 0;

				for (int x = 0; x < 10; x++)
				{
					for (int z = 0; z < 10; z++)
					{
						sign = rnd.NextDouble() < 0.5 ? 1 : -1;
						series.Add(x, sign * rnd.NextDouble(), z);
					}
				}
			}

			tChart1.Aspect.Orthogonal = false;
			tChart1.Aspect.Chart3DPercent = 100;
			tChart1.Aspect.Zoom = 70;

			tChart1.Tools.Add(typeof(Rotate));
		}

		private void cbStacked_CheckedChanged(object sender, EventArgs e)
		{
			tower1.Stacked = cbStacked.Checked;
		}
	}
}
