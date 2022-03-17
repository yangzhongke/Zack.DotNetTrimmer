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
	public class Point3D_Nulls : BaseForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbSkip = new System.Windows.Forms.RadioButton();
			this.rbIgnore = new System.Windows.Forms.RadioButton();
			this.rbDoNotPaint = new System.Windows.Forms.RadioButton();
			this.cbView3D = new System.Windows.Forms.CheckBox();
			this.bRefresh = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "Point3D series now fully supports null values. A new Add() overload\r\nis also used" +
					" in this example which allows arrays of colors to be directly\r\nadded to a Custom" +
					"3D series.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bRefresh);
			this.panel1.Controls.Add(this.cbView3D);
			this.panel1.Controls.Add(this.groupBox1);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbSkip);
			this.groupBox1.Controls.Add(this.rbIgnore);
			this.groupBox1.Controls.Add(this.rbDoNotPaint);
			this.groupBox1.Location = new System.Drawing.Point(12, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(213, 36);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Null Style";
			// 
			// rbSkip
			// 
			this.rbSkip.Location = new System.Drawing.Point(158, 13);
			this.rbSkip.Name = "rbSkip";
			this.rbSkip.Size = new System.Drawing.Size(46, 17);
			this.rbSkip.TabIndex = 3;
			this.rbSkip.TabStop = true;
			this.rbSkip.Text = "Skip";
#if VS2005
			this.rbSkip.AutoSize = true;
			this.rbSkip.UseVisualStyleBackColor = true;
#endif
			// 
			// rbIgnore
			// 
			this.rbIgnore.Location = new System.Drawing.Point(97, 13);
			this.rbIgnore.Name = "rbIgnore";
			this.rbIgnore.Size = new System.Drawing.Size(55, 17);
			this.rbIgnore.TabIndex = 2;
			this.rbIgnore.TabStop = true;
			this.rbIgnore.Text = "Ignore";
#if VS2005
			this.rbIgnore.AutoSize = true;
			this.rbIgnore.UseVisualStyleBackColor = true;
#endif
			// 
			// rbDoNotPaint
			// 
			this.rbDoNotPaint.Checked = true;
			this.rbDoNotPaint.Location = new System.Drawing.Point(6, 13);
			this.rbDoNotPaint.Name = "rbDoNotPaint";
			this.rbDoNotPaint.Size = new System.Drawing.Size(80, 17);
			this.rbDoNotPaint.TabIndex = 1;
			this.rbDoNotPaint.TabStop = true;
			this.rbDoNotPaint.Text = "DoNotPaint";
#if VS2005
			this.rbDoNotPaint.AutoSize = true;
			this.rbDoNotPaint.UseVisualStyleBackColor = true;
#endif
			// 
			// cbView3D
			// 
			this.cbView3D.Checked = true;
			this.cbView3D.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbView3D.Location = new System.Drawing.Point(252, 16);
			this.cbView3D.Name = "cbView3D";
			this.cbView3D.Size = new System.Drawing.Size(63, 17);
			this.cbView3D.TabIndex = 1;
			this.cbView3D.Text = "View3D";
#if VS2005
			this.cbView3D.AutoSize = true;
			this.cbView3D.UseVisualStyleBackColor = true;
#endif
			this.cbView3D.CheckedChanged += new System.EventHandler(this.cbView3D_CheckedChanged);
			// 
			// bRefresh
			// 
			this.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bRefresh.Location = new System.Drawing.Point(330, 13);
			this.bRefresh.Name = "bRefresh";
			this.bRefresh.Size = new System.Drawing.Size(75, 23);
			this.bRefresh.TabIndex = 2;
			this.bRefresh.Text = "Refresh...";
#if VS2005
			this.bRefresh.UseVisualStyleBackColor = true;
#endif
			this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
			// 
			// Point3D_Nulls
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Point3D_Nulls";
			this.Text = "Point3D_Nulls";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Point3D_Nulls()
		{
			InitializeComponent();
			InitializeChart();
		}

		private GroupBox groupBox1;
		private CheckBox cbView3D;
		private RadioButton rbSkip;
		private RadioButton rbIgnore;
		private RadioButton rbDoNotPaint;
		private Button bRefresh;

		Steema.TeeChart.Styles.Points3D points3D;

		private void InitializeChart()
		{
			
			tChart1.Series.Add(points3D = new Steema.TeeChart.Styles.Points3D());
			AddPoints();

			rbDoNotPaint.CheckedChanged += new EventHandler(rbNulls_CheckedChanged);
			rbIgnore.CheckedChanged += new EventHandler(rbNulls_CheckedChanged);
			rbSkip.CheckedChanged += new EventHandler(rbNulls_CheckedChanged);
		}

		private void rbNulls_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton but = sender as RadioButton;
			switch (but.Text)
			{
				case "DoNotPaint":
					points3D.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint;
					break;
				case "Ignore":
					points3D.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
					break;
				case "Skip":
					points3D.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Skip;
					break;
			}
		}

		private void AddPoints()
		{
			int length = 55;

			double[] xValues = new double[length], yValues = new double[length], zValues = new double[length];
			Color[] colorValues = new Color[length];

			Random rnd = new Random();
			double tmp, oldTemp = 0;

			points3D.DefaultNullValue = 0;

			for (int i = 0; i < length; i++)
			{
				tmp = rnd.NextDouble();
				while (tmp == oldTemp)
				{
					tmp = rnd.NextDouble();
				}

				if ((i > 0) && (i % 5 == 0))
				{
					xValues[i] = i;
					yValues[i] = 0;
					zValues[i] = tmp;
					colorValues[i] = Color.Transparent;
				}
				else
				{
					xValues[i] = i;
					yValues[i] = tmp;
					zValues[i] = tmp;
					colorValues[i] = Color.FromArgb(255 - Steema.TeeChart.Utils.Round(255 * tmp),
						Steema.TeeChart.Utils.Round(255 * tmp), 255 - Steema.TeeChart.Utils.Round(255 * tmp));
				}

				oldTemp = tmp;
			}

			points3D.Add(xValues, yValues, zValues, colorValues);
		}


		private void cbView3D_CheckedChanged(object sender, EventArgs e)
		{
			tChart1.Aspect.View3D = cbView3D.Checked;
		}

		private void bRefresh_Click(object sender, EventArgs e)
		{
			points3D.Clear();
			AddPoints();
		}
	}
}