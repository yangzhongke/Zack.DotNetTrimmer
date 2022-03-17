using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Margins_Units : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.ComponentModel.IContainer components = null;

		public Margins_Units()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			comboBox1.SelectedIndex = 0;
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Chart Margins can be expressed as percentage or pixels.\r\n\r\ntChart1.Panel.MarginUn" +
                "its = Steema.TeeChart.PanelMarginUnits.Pixels;\r\ntChart1.Panel.MarginLeft = 10; /" +
                "/ <--- 10 pixels";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Cursor = Cursors.Default;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "Margin Pixels"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Visible = false;
            this.tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Percentage",
            "Pixels"});
            this.comboBox1.Location = new System.Drawing.Point(99, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Margin Units:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(321, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(267, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Margins_Units
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Margins_Units";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(comboBox1.SelectedIndex == 0) {
				tChart1.Panel.MarginUnits = Steema.TeeChart.PanelMarginUnits.Percent;
				label3.Text = "%";
			}
			else {
				tChart1.Panel.MarginUnits = Steema.TeeChart.PanelMarginUnits.Pixels;
				label3.Text = "Pixels";
			}
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e) {
			tChart1.Panel.MarginLeft=(double)numericUpDown1.Value;
      tChart1.Panel.MarginTop=(double)numericUpDown1.Value;
      tChart1.Panel.MarginRight=(double)numericUpDown1.Value;
      tChart1.Panel.MarginBottom=(double)numericUpDown1.Value;
		}
	}
}

