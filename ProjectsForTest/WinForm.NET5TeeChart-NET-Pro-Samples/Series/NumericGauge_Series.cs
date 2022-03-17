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
	public class NumericGauge_Series : BaseForm
	{
		private Button bEdit;
		private Timer timer1;
		private CheckBox cbAnimate;
		private Steema.TeeChart.Styles.NumericGauge numericGauge1;
		private Steema.TeeChart.Styles.NumericGauge numericGauge2;
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
			this.components = new System.ComponentModel.Container();
			this.bEdit = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.cbAnimate = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "A new series type, Numeric Gauge, which displays a fast, fully \r\ncustomizable num" +
					"eric and text gauge.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbAnimate);
			this.panel1.Controls.Add(this.bEdit);
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
			// bEdit
			// 
			this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bEdit.Location = new System.Drawing.Point(12, 6);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(115, 23);
			this.bEdit.TabIndex = 1;
			this.bEdit.Text = "Edit Top Series...";
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// cbAnimate
			// 
			this.cbAnimate.Checked = true;
			this.cbAnimate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAnimate.Location = new System.Drawing.Point(133, 6);
			this.cbAnimate.Name = "cbAnimate";
			this.cbAnimate.Size = new System.Drawing.Size(104, 24);
			this.cbAnimate.TabIndex = 0;
			this.cbAnimate.Text = "Animate!";
			this.cbAnimate.CheckedChanged += new System.EventHandler(this.cbAnimate_CheckedChanged);
			// 
			// NumericGauge_Series
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "NumericGauge_Series";
			this.Text = "NumericGauge_Series";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public NumericGauge_Series()
		{
			InitializeComponent();

			InitializeChart();
		}

		private void InitializeChart()
		{
			tChart1.Aspect.View3D = false;
			tChart1.Series.Add(numericGauge1 = new Steema.TeeChart.Styles.NumericGauge());
			tChart1.Series.Add(numericGauge2 = new Steema.TeeChart.Styles.NumericGauge());
			timer1.Enabled = true;
			numericGauge1.GaugeColorPalette = Steema.TeeChart.Styles.NumericGauge.LCDPalette;
			numericGauge1.DigitalFontType = Steema.TeeChart.Styles.DigitalFont.Dot;
		}

		private Random rnd = new Random();
		private void timer1_Tick(object sender, EventArgs e)
		{
			double value = rnd.NextDouble() * 1000;
			numericGauge1.Value = value;
			while(value == numericGauge1.Value)
			{
				value = rnd.NextDouble() * 1000;
			}
			numericGauge2.Value = value;
		}

		private void cbAnimate_CheckedChanged(object sender, EventArgs e)
		{
			timer1.Enabled = cbAnimate.Checked;
		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			Steema.TeeChart.Editors.Series.NumericGaugeSeries editor = new Steema.TeeChart.Editors.Series.NumericGaugeSeries(numericGauge1);
      Steema.TeeChart.Editors.EditorUtils.Translate(editor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor);
		}
	}
}