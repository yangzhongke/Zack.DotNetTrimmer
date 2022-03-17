using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Axis_MaxMinRounded : BaseForm
	{
		private Label label1;
		private ComboBox cbAxis;
		private CheckBox cbRoundMin;
		private CheckBox cbRoundMax;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Axis_MaxMinRounded));
			this.cbAxis = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbRoundMax = new System.Windows.Forms.CheckBox();
			this.cbRoundMin = new System.Windows.Forms.CheckBox();
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
			this.panel1.Controls.Add(this.cbRoundMin);
			this.panel1.Controls.Add(this.cbRoundMax);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbAxis);
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
			// cbAxis
			// 
#if VS2005
			this.cbAxis.FormattingEnabled = true;
#endif
			this.cbAxis.Items.AddRange(new object[] {
            "Left",
            "Bottom"});
			this.cbAxis.Location = new System.Drawing.Point(47, 12);
			this.cbAxis.Name = "cbAxis";
			this.cbAxis.Size = new System.Drawing.Size(78, 21);
			this.cbAxis.TabIndex = 0;
			this.cbAxis.Text = "Left";
			this.cbAxis.SelectedIndexChanged += new System.EventHandler(this.cbAxis_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Axis:";
			// 
			// cbRoundMax
			// 
			this.cbRoundMax.Checked = true;
			this.cbRoundMax.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRoundMax.Location = new System.Drawing.Point(131, 14);
			this.cbRoundMax.Name = "cbRoundMax";
			this.cbRoundMax.Size = new System.Drawing.Size(117, 17);
			this.cbRoundMax.TabIndex = 2;
			this.cbRoundMax.Text = "&Maximum Rounded";
#if VS2005
			this.cbRoundMax.AutoSize = true;
			this.cbRoundMax.UseVisualStyleBackColor = true;
#endif
			this.cbRoundMax.CheckedChanged += new System.EventHandler(this.cbRoundMax_CheckedChanged);
			// 
			// cbRoundMin
			// 
			this.cbRoundMin.Checked = true;
			this.cbRoundMin.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRoundMin.Location = new System.Drawing.Point(254, 14);
			this.cbRoundMin.Name = "cbRoundMin";
			this.cbRoundMin.Size = new System.Drawing.Size(114, 17);
			this.cbRoundMin.TabIndex = 3;
			this.cbRoundMin.Text = "Minimum &Rounded";
#if VS2005
			this.cbRoundMin.AutoSize = true;
			this.cbRoundMin.UseVisualStyleBackColor = true;
#endif
			this.cbRoundMin.CheckedChanged += new System.EventHandler(this.cbRoundMin_CheckedChanged);
			// 
			// Axis_MaxMinRounded
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Axis_MaxMinRounded";
			this.Text = "Axis_MaxMinRounded";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Axis_MaxMinRounded()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Steema.TeeChart.Styles.FastLine fastLine;

		private void InitializeChart()
		{
			tChart1.Aspect.View3D = false;
			tChart1.Legend.Visible = false;
			tChart1.Panel.Color = Color.Black;
			tChart1.Panel.Gradient.Visible = false;
			tChart1.Axes.Bottom.Labels.Font.Color = Color.White;
			tChart1.Axes.Left.Labels.Font.Color = Color.White;
			tChart1.Walls.Back.Brush.Gradient.Visible = false;
			tChart1.Walls.Back.Color = Color.Black;

			tChart1.Series.Add(fastLine = new Steema.TeeChart.Styles.FastLine());
			fastLine.FillSampleValues(200);

			tChart1.Axes.Left.MaximumRound = true;
			tChart1.Axes.Left.MinimumRound = true;
		}

		private Axis TheAxis()
		{
			if (cbAxis.SelectedIndex == 0)
			{
				return tChart1.Axes.Left;
			}
			else
			{
				return tChart1.Axes.Bottom;
			}
		}

		private void cbAxis_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbRoundMax.Checked = TheAxis().MaximumRound;
			cbRoundMin.Checked = TheAxis().MinimumRound;
		}

		private void cbRoundMax_CheckedChanged(object sender, EventArgs e)
		{
			TheAxis().MaximumRound = cbRoundMax.Checked;
		}

		private void cbRoundMin_CheckedChanged(object sender, EventArgs e)
		{
			TheAxis().MinimumRound = cbRoundMin.Checked; 
		}
	}
}