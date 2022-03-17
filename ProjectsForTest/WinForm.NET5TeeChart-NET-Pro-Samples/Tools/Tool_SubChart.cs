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
	public class Tool_SubChart : BaseForm
	{
		private Button bEdit;
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
			if(disposing && (components != null))
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
			this.bEdit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "The SubChart Tools adds unlimited nested charts to the Chart component.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bEdit);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			
			
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
			this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Panel.Brush.Gradient.Sigma = true;
			this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
			this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// bEdit
			// 
			this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bEdit.Location = new System.Drawing.Point(12, 10);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(101, 23);
			this.bEdit.TabIndex = 0;
			this.bEdit.Text = "Edit SubCharts...";
#if VS2005
			this.bEdit.UseVisualStyleBackColor = true;
#endif
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// Tool_SubChart
			// 
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Tool_SubChart";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Tool_SubChart()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Tools.SubChartTool subChartTool1;
		private void InitializeChart()
		{
			Chart chart;
			tChart1.Series.Add(line1 = new Steema.TeeChart.Styles.Line());
			tChart1.Tools.Add(subChartTool1 = new Steema.TeeChart.Tools.SubChartTool());
			chart = subChartTool1.Charts.AddChart("Chart0");
			chart.Panel.Color = Color.Transparent;
			chart.Series.Add(new Steema.TeeChart.Styles.Bar());
			chart[0].Marks.Visible = false;
			chart[0].Color = Color.FromArgb(100, Color.Blue);
			chart = subChartTool1.Charts.AddChart("Chart1");
			chart.Panel.Color = Color.Transparent;
			chart.Series.Add(new Steema.TeeChart.Styles.Area());
			chart[0].Color = Color.FromArgb(100, Color.Yellow);
			subChartTool1.Charts[1].Left = 220;
			line1.FillSampleValues();
			
			for(int j = 0; j < subChartTool1.Charts.Count; j++)
			{
				chart = subChartTool1.Charts[j].Chart;
				for(int i = 0; i < line1.Count; i++)
				{
					chart[0].Add(line1.XValues[i], line1.YValues[i]);
				}
			}
		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			Steema.TeeChart.Editors.Tools.SubChartEditor editor = new Steema.TeeChart.Editors.Tools.SubChartEditor(subChartTool1);
      Steema.TeeChart.Editors.EditorUtils.Translate(editor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor);
		}
	}
}
