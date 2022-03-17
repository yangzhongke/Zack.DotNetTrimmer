using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
	public class Gantt_MultipleNextTasks : Steema.TeeChart.Samples.BaseForm
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
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "Gantt MultipleNextTasks property enables more than one NextTask to be assigned\r\nt" +
    "o any given Gantt bar.";
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
			this.tChart1.Axes.Bottom.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Bottom.Labels.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
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
			this.tChart1.Axes.Depth.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Depth.Labels.Bevel.StringColorTwo = "FF808080";
			this.tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
			// 
			// 
			// 
			// 
			// 
			// 
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
			this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorTwo = "FF808080";
			this.tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
			// 
			// 
			// 
			// 
			// 
			// 
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
			this.tChart1.Axes.Left.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Left.Labels.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
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
			this.tChart1.Axes.Right.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Right.Labels.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
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
			this.tChart1.Axes.Top.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Top.Labels.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Top.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Footer.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Footer.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Header.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Legend.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Legend.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Panel.Bevel.StringColorTwo = "FF808080";
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubFooter.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.SubFooter.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
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
			this.tChart1.Walls.Back.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Walls.Back.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Walls.Bottom.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Walls.Left.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Right.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Walls.Right.Bevel.StringColorTwo = "FF808080";
			// 
			// Gantt_MultipleNextTasks
			// 
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Gantt_MultipleNextTasks";
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Gantt_MultipleNextTasks()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Gantt gantt;

		private void InitializeChart()
		{
			tChart1.Aspect.View3D = false;
			tChart1.Header.Text = "Gantt MultipleNextTasks";
      tChart1.Legend.Visible = false;

			gantt = new Gantt(tChart1.Chart);

			DateTime date = DateTime.Today;

			gantt.Add(date, date.AddDays(3), 1, "Plan");
			gantt.Add(date.AddDays(6), date.AddDays(8), 2, "Proof of concept");
			gantt.Add(date.AddDays(5), date.AddDays(7), 3, "Documentation");

			gantt.AddMultipleNextTasks(0, 1);
			gantt.AddMultipleNextTasks(0, 2);

			gantt.ConnectingPen.Color = Color.Red;
		}
	}
}
