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
	public class Legend_Items : BaseForm
	{
		private TextBox textBox2;
		private NumericUpDown numericUpDown1;
		private Label label1;
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
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "Chart Legend stores all values in a Items[]  array property.\r\n\r\ntChart1.Legend.It" +
					"em[5].Text = \"Hello\";";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Legend Item:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(87, 12);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(162, 11);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Legend_Items
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Legend_Items";
			this.Text = "Legend_Items";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Legend_Items()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Steema.TeeChart.Styles.Pie pie;
		private void InitializeChart()
		{
			tChart1.Series.Add(pie = new Steema.TeeChart.Styles.Pie());
			pie.FillSampleValues();

			tChart1.Legend.TextStyle = LegendTextStyles.Value;
			tChart1.Legend.ColumnWidthAuto = false;
			tChart1.Legend.ColumnWidths[0] = 100;

			// Force re-draw to make tChart1 recalculate all Legend Items[]
			tChart1.Draw();

			numericUpDown1.Maximum = pie.Count - 1;
			numericUpDown1_Click(this, EventArgs.Empty);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			tChart1.Legend.Items[(int)numericUpDown1.Value].Text = textBox2.Text;
		}

		private void numericUpDown1_Click(object sender, EventArgs e)
		{
			textBox2.Text = tChart1.Legend.Items[(int)numericUpDown1.Value].Text;
		}
	}
}