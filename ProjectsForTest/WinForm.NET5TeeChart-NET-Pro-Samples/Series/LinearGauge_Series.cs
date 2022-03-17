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
	public class LinearGauge_Series : BaseForm
	{
		private Button bEditSeries;
		private Timer timer1;
		private CheckBox cbAnimate;
		private Steema.TeeChart.Styles.LinearGauge linearGauge1;
		private Steema.TeeChart.Styles.LinearGauge linearGauge2;

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
			this.components = new System.ComponentModel.Container();
			this.bEditSeries = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.cbAnimate = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "The Linear Gauge series provides a fast and fully configurable Linear Gauge.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbAnimate);
			this.panel1.Controls.Add(this.bEditSeries);
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
			// bEditSeries
			// 
			this.bEditSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bEditSeries.Location = new System.Drawing.Point(12, 10);
			this.bEditSeries.Name = "bEditSeries";
			this.bEditSeries.Size = new System.Drawing.Size(116, 23);
			this.bEditSeries.TabIndex = 0;
			this.bEditSeries.Text = "Edit Top Series...";
#if VS2005
			this.bEditSeries.UseVisualStyleBackColor = true;
#endif
			this.bEditSeries.Click += new System.EventHandler(this.bEditSeries_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// cbAnimate
			// 
			this.cbAnimate.Checked = true;
			this.cbAnimate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAnimate.Location = new System.Drawing.Point(143, 14);
			this.cbAnimate.Name = "cbAnimate";
			this.cbAnimate.Size = new System.Drawing.Size(67, 17);
			this.cbAnimate.TabIndex = 1;
			this.cbAnimate.Text = "Animate!";
#if VS2005
			this.cbAnimate.AutoSize = true;
			this.cbAnimate.UseVisualStyleBackColor = true;
#endif
			this.cbAnimate.CheckedChanged += new System.EventHandler(this.cbAnimate_CheckedChanged);
			// 
			// LinearGauge_Series
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "LinearGauge_Series";
			this.Text = "LinearGauge_Series";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public LinearGauge_Series()
		{
			InitializeComponent();

			InitializeChart();
		}

		private void InitializeChart()
		{
			tChart1.Aspect.View3D = false;
			tChart1.Series.Add(linearGauge1 = new Steema.TeeChart.Styles.LinearGauge());
			tChart1.Series.Add(linearGauge2 = new Steema.TeeChart.Styles.LinearGauge());
			linearGauge1.UseValueColorPalette = true;
		}

		private void bEditSeries_Click(object sender, EventArgs e)
		{
			Steema.TeeChart.Editors.Series.LinearGaugeSeries editor = new Steema.TeeChart.Editors.Series.LinearGaugeSeries(linearGauge1);
      Steema.TeeChart.Editors.EditorUtils.Translate(editor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor);
		}

		private void cbAnimate_CheckedChanged(object sender, EventArgs e)
		{
			timer1.Enabled = cbAnimate.Checked;
		}

		Random rnd = new Random();
		private void timer1_Tick(object sender, EventArgs e)
		{
			double value = rnd.Next(0, 100);
			linearGauge1.Value = value;
			while(value == linearGauge1.Value)
			{
				value = rnd.Next(0, 100);
			}

			linearGauge2.Value = value;
		}
	}
}