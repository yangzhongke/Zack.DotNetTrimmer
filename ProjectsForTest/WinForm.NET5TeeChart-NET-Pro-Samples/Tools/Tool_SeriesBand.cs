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
	public class Tool_SeriesBand : Samples.BaseForm
	{
		private Button button1;
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
            this.textBox1.Text = "SeriesBand tool draws a fully configurable area between two line series.";
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
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit...";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tool_SeriesBand
            // 
#if VS2005
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Tool_SeriesBand";
            this.Text = "Tool_SeriesBand";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public Tool_SeriesBand()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Styles.Line line2;
		private Steema.TeeChart.Tools.SeriesBandTool seriesBandTool1;
		private void InitializeChart()
		{
			tChart1.Aspect.View3D = false;
			tChart1.Series.Add(line1 = new Steema.TeeChart.Styles.Line());
			tChart1.Series.Add(line2 = new Steema.TeeChart.Styles.Line());

			line1.FillSampleValues();
			for (int i = 0; i < line1.Count; i++)
			{
				line2.Add(line1.XValues[i], line1.YValues[i] / 2.0);		
			}

			tChart1.Tools.Add(seriesBandTool1 = new Steema.TeeChart.Tools.SeriesBandTool());
			seriesBandTool1.Series = line1;
			seriesBandTool1.Series2 = line2;

			line1.LinePen.Width = 3;
			line2.LinePen.Width = 3;

			seriesBandTool1.Gradient.Visible = true;
			seriesBandTool1.Gradient.StartColor = Color.Silver;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Steema.TeeChart.Editors.Tools.SeriesBandToolEditor edit = new Steema.TeeChart.Editors.Tools.SeriesBandToolEditor(seriesBandTool1);
      Steema.TeeChart.Editors.EditorUtils.Translate(edit);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(edit);
		}
	}
}