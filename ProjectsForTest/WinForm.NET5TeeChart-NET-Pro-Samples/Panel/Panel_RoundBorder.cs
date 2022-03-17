using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Panel_RoundBorder : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.ButtonPen buttonPen1;
		private System.ComponentModel.IContainer components = null;

		public Panel_RoundBorder()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			tChart1.Panel.Transparent = false;
			tChart1.Panel.Transparency = 0;
			tChart1.Panel.Color = Color.SlateBlue;

			buttonPen1.Pen = tChart1.Panel.Pen;
			tChart1.Panel.BorderRound = (int)numericUpDown1.Value;
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
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.buttonPen1 = new Steema.TeeChart.ButtonPen();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = @"The Chart panel can be configured to display ""rounded"" borders. A new ""BorderRound"" property displays a line around chart panel.

tChart1.Panel.BorderRound = 50;   // <--- pixels of ""rounding""
tChart1.Panel.Pen.Visible = true; 
tChart1.Panel.Pen.Width = 2; ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonPen1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Size = 14;
			this.tChart1.Header.Lines = new string[] {
																								 "Round Borders"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.Transparency = 100;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.Transparency = 100;
			// 
			// tChart1.Panel.Pen
			// 
			this.tChart1.Panel.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Panel.Pen.Visible = true;
			this.tChart1.Panel.Pen.Width = 5;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 10);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Rounding Amount:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(104, 9);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																																	 1000,
																																	 0,
																																	 0,
																																	 0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 80,
																																 0,
																																 0,
																																 0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(165, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "No Rounding";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// buttonPen1
			// 
			this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPen1.Location = new System.Drawing.Point(303, 8);
			this.buttonPen1.Name = "buttonPen1";
			this.buttonPen1.TabIndex = 3;
			this.buttonPen1.Text = "Border...";
			// 
			// Panel_RoundBorder
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Panel_RoundBorder";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e) {
			tChart1.Panel.BorderRound = (int)numericUpDown1.Value;
			checkBox1.Enabled=numericUpDown1.Value>0;
			if(checkBox1.Enabled) checkBox1.Checked = false;
		}

		private void checkBox1_Click(object sender, System.EventArgs e) {
			numericUpDown1.Value=0;
			checkBox1.Enabled=false;
		}

	
		
	}
}

