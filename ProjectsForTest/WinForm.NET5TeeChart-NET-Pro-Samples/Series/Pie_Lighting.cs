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
	public class Pie_Lighting : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pie_Lighting));
            this.cbEdgeStyles = new System.Windows.Forms.ComboBox();
            this.lEdgeStyle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upTransparency = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upTransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.upTransparency);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lEdgeStyle);
            this.panel1.Controls.Add(this.cbEdgeStyles);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.FontSeriesColor = true;
            this.tChart1.Legend.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(75)))), ((int)(((byte)(191)))));
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Visible = false;
            // 
            // cbEdgeStyles
            // 
#if VS2005
            this.cbEdgeStyles.FormattingEnabled = true;
#endif
            this.cbEdgeStyles.Location = new System.Drawing.Point(341, 12);
            this.cbEdgeStyles.Name = "cbEdgeStyles";
            this.cbEdgeStyles.Size = new System.Drawing.Size(87, 21);
            this.cbEdgeStyles.TabIndex = 0;
            this.cbEdgeStyles.SelectedIndexChanged += new System.EventHandler(this.cbEdgeStyles_SelectedIndexChanged);
            // 
            // lEdgeStyle
            // 
            this.lEdgeStyle.AutoSize = true;
            this.lEdgeStyle.Location = new System.Drawing.Point(277, 15);
            this.lEdgeStyle.Name = "lEdgeStyle";
            this.lEdgeStyle.Size = new System.Drawing.Size(58, 13);
            this.lEdgeStyle.TabIndex = 1;
            this.lEdgeStyle.Text = "EdgeStyle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transparency:";
            // 
            // upTransparency
            // 
            this.upTransparency.Location = new System.Drawing.Point(93, 12);
            this.upTransparency.Name = "upTransparency";
            this.upTransparency.Size = new System.Drawing.Size(48, 20);
            this.upTransparency.TabIndex = 3;
            this.upTransparency.ValueChanged += new System.EventHandler(this.upTransparency_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(223, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BevelPercent:";
            // 
            // Pie_Lighting
            // 
#if VS2005
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Pie_Lighting";
            this.Text = "Pie_Lighting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upTransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lEdgeStyle;
		private System.Windows.Forms.ComboBox cbEdgeStyles;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown upTransparency;
		private System.Windows.Forms.Label label1;

		public Pie_Lighting()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Steema.TeeChart.Styles.Pie pie1;
		private void InitializeChart()
		{
			tChart1.DoubleClick += new EventHandler(tChart1_DoubleClick);			
			tChart1.Series.Add(pie1 = new Steema.TeeChart.Styles.Pie());            
			pie1.FillSampleValues();
			pie1.Pen.Visible = false;
			pie1.BevelPercent = 15;
			pie1.ExplodeBiggest = 10;
			pie1.EdgeStyle = Steema.TeeChart.Drawing.EdgeStyles.Curved;
            pie1.Marks.Transparent = true;
            pie1.Marks.ArrowLength = 15;
            pie1.Marks.FontSeriesColor = true;
			cbEdgeStyles.Items.Add(Steema.TeeChart.Drawing.EdgeStyles.Curved);
			cbEdgeStyles.Items.Add(Steema.TeeChart.Drawing.EdgeStyles.Flat);
			cbEdgeStyles.Items.Add(Steema.TeeChart.Drawing.EdgeStyles.None);

			cbEdgeStyles.SelectedIndex = 0;
			numericUpDown1.Value = 15;
			upTransparency.Value = 0;
		}

		void tChart1_DoubleClick(object sender, EventArgs e)
		{
			pie1.FillSampleValues();
		}

		private void upTransparency_ValueChanged(object sender, EventArgs e)
		{
			pie1.Transparency = (int)upTransparency.Value;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			pie1.BevelPercent = (int)numericUpDown1.Value;
		}

		private void cbEdgeStyles_SelectedIndexChanged(object sender, EventArgs e)
		{
			pie1.EdgeStyle = (Steema.TeeChart.Drawing.EdgeStyles)cbEdgeStyles.SelectedItem;
		}
	}
}