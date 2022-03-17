using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class AxisDrawBevels : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.ComboBox comboBox1;
		private Steema.TeeChart.Styles.Bar bar1;
		private System.ComponentModel.IContainer components = null;

		public AxisDrawBevels()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "A small routine to display \"bevels\" around the 4 default Chart axes.\r\n\r\nprivate v" +
				"oid tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)\r\n{\r\n " +
				" DrawBevelsAroundAxis(g, Steema.TeeChart.Drawing.BevelStyles.Lowered, 2);\r\n}";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
														 "TeeChart"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(144, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Draw Bevel around axis";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(176, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Size:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(208, 12);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(59, 20);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "Lowered",
														   "Raised"});
			this.comboBox1.Location = new System.Drawing.Point(288, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// bar1
			// 
			this.bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Ellipse;
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			this.bar1.ColorEach = true;
			// 
			// bar1.Marks
			// 
			this.bar1.Marks.Visible = false;
			// 
			// bar1.Pen
			// 
			this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(61)), ((System.Byte)(92)), ((System.Byte)(153)));
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// AxisDrawBevels
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "AxisDrawBevels";
			this.Load += new System.EventHandler(this.AxisDrawBevels_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void AxisDrawBevels_Load(object sender, System.EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
			tChart1[0].FillSampleValues();
		}

		private void AdjustAxisOffsets() 
		{
			int tmpSize;
			if(this.checkBox1.Checked) 
				tmpSize = Convert.ToInt32(this.numericUpDown1.Value);
			else
				tmpSize = 0;

			for(int t=0; t < tChart1.Axes.Count; ++t) 
			{
				tChart1.Axes[t].MinimumOffset = tmpSize+1;
				tChart1.Axes[t].MaximumOffset = tmpSize+1;

			}
				
			tChart1.Refresh();

		}

		private void DrawBevelsAroundAxis(Steema.TeeChart.Drawing.IGraphics3D e, Steema.TeeChart.Drawing.BevelStyles style, int size) 
		{
			Steema.TeeChart.Drawing.Bevel bevel = new Steema.TeeChart.Drawing.Bevel(tChart1.Chart);
			bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
			bevel.Outer = style;
			bevel.Width = size;

			bevel.Draw(e, e.Chart.ChartRect);

		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			if(checkBox1.Checked)
			{
				switch(comboBox1.SelectedIndex)
				{
					case 0:
						DrawBevelsAroundAxis(g, Steema.TeeChart.Drawing.BevelStyles.Lowered, Convert.ToInt32(numericUpDown1.Value));
						break;
					case 1:
						DrawBevelsAroundAxis(g, Steema.TeeChart.Drawing.BevelStyles.Raised, Convert.ToInt32(numericUpDown1.Value));
						break;
				}
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			comboBox1.Enabled = checkBox1.Checked;
			numericUpDown1.Enabled = checkBox1.Checked;
			AdjustAxisOffsets();
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			AdjustAxisOffsets();
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			AdjustAxisOffsets();
		}
	}
}

