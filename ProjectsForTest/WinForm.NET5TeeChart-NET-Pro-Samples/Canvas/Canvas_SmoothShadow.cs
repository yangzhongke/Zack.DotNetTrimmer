using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
	public class Canvas_SmoothShadow : Samples.BaseForm
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
			this.textBox1.Text = "New for .NET Framework 2.0 are smooth shadows!";
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
			this.tChart1.Legend.Title.Pen.Visible = false;
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(12, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Edit...";
#if VS2005
			this.button1.UseVisualStyleBackColor = true;
#endif
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Canvas_SmoothShadow
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Canvas_SmoothShadow";
			this.Text = "Canvas_SmoothShadow";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Canvas_SmoothShadow()
		{
			InitializeComponent();
#if VS2005
			InitializeChart();
#endif
		}

		private Button button1;

		private Bar bar1;
		private void InitializeChart()
		{
#if VS2005
			tChart1.Series.Add(bar1 = new Steema.TeeChart.Styles.Bar());
			bar1.FillSampleValues();

			tChart1.Legend.Shadow.Width = 16;
			tChart1.Legend.Shadow.Height = 16;
			tChart1.Legend.Shadow.Smooth = true;
#endif
		}

		private void button1_Click(object sender, EventArgs e)
		{
#if VS2005
			Steema.TeeChart.Editors.ShadowEditor shadow = new Steema.TeeChart.Editors.ShadowEditor(tChart1.Legend.Shadow);
      Steema.TeeChart.Editors.EditorUtils.Translate(shadow);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(shadow);
#endif

		}
	}
}