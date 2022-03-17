using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
	public class CircularGauge_ColorLines : BaseForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "The ColorLine collection for CircularGauge and LinearGauge series enables multipl" +
    "e \r\ncustom color lines. ";
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(17, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Custom Line Color...";
#if VS2005
			this.button1.UseVisualStyleBackColor = true;
#endif
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// CircularGauge_ColorLines
			// 
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "CircularGauge_ColorLines";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public CircularGauge_ColorLines()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Button button1;

		CircularGauge series1;

		private void InitializeChart()
		{
			tChart1.Aspect.View3D = false;
			series1 = new CircularGauge(tChart1.Chart);

			GaugeSeriesPointer pointer = (GaugeSeriesPointer)series1.GreenLine.Clone();
			pointer.Gradient.Visible = false;
			pointer.Color = Color.DarkGoldenrod;
			series1.ColorLines.Add(pointer);
			series1.ColorLineStartValues.Add(50);
			series1.ColorLineEndValues.Add(70);

			series1.GreenLineEndValue = 40;

			series1.FillSampleValues();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			series1.ColorLines[2].Color = Steema.TeeChart.Editors.ColorEditor.Choose(series1.ColorLines[2].Color);
		}


	}
}
