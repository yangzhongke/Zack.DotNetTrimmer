using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Marks_Shadow : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Bar barSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.ComponentModel.IContainer components = null;

		public Marks_Shadow()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.FillSampleValues(5);
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
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 80);
			this.textBox1.Text = @"By default Series Marks have a shadowed border. It can be turned on / off at design and run-time, and changed its color and transparency too.

Example: 
barSeries1.Marks.Shadow.Visible = true;
barSeries1.Marks.Shadow.Width = 2 ;
barSeries1.Marks.Shadow.Color= Color.Black;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(0, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Example : Mark shadow"};
			this.tChart1.Location = new System.Drawing.Point(0, 121);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 165);
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
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 10);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(123, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Tag = "";
			this.checkBox1.Text = "&Marks Shadow";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// barSeries1.Gradient
			// 
			this.barSeries1.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.barSeries1.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.barSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.barSeries1.Brush.Gradient.UseMiddle = true;
			this.barSeries1.Brush.Gradient.Visible = true;
			// 
			// barSeries1.Gradient
			// 
			this.barSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.barSeries1.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.barSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.barSeries1.Gradient.UseMiddle = true;
			this.barSeries1.Gradient.Visible = true;
			// 
			// barSeries1.Marks
			// 
			// 
			// barSeries1.Marks.Shadow
			// 
			this.barSeries1.Marks.Shadow.Height = 3;
			this.barSeries1.Marks.Shadow.Width = 3;
			// 
			// barSeries1.Marks.Symbol
			// 
			// 
			// barSeries1.Marks.Symbol.Shadow
			// 
			this.barSeries1.Marks.Symbol.Shadow.Height = 1;
			this.barSeries1.Marks.Symbol.Shadow.Visible = true;
			this.barSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// barSeries1.Pen
			// 
			this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(77)), ((System.Byte)(0)));
			this.barSeries1.Title = "barSeries1";
			// 
			// barSeries1.XValues
			// 
			this.barSeries1.XValues.DataMember = "X";
			this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries1.YValues
			// 
			this.barSeries1.YValues.DataMember = "Bar";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(133, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Color";
			this.label1.UseMnemonic = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGray;
			this.panel2.Cursor = Cursors.Hand;
			this.panel2.Location = new System.Drawing.Point(173, 9);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(23, 23);
			this.panel2.TabIndex = 2;
			this.panel2.MouseUp += this.panel2_MouseUp;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(231, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Size:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(267, 10);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																																	 20,
																																	 0,
																																	 0,
																																	 0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																																	 1,
																																	 0,
																																	 0,
																																	 0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 3,
																																 0,
																																 0,
																																 0});
			this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_TextChanged);
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// Shadow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Shadow";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.barSeries1.Marks.Shadow.Visible = this.checkBox1.Checked;
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.barSeries1.Marks.Shadow.Width = (int)this.numericUpDown1.Value;
			this.barSeries1.Marks.Shadow.Height = (int)this.numericUpDown1.Value;
		}

		private void numericUpDown1_TextChanged(object sender, System.EventArgs e)
		{
			this.barSeries1.Marks.Shadow.Width = (int)this.numericUpDown1.Value;
			this.barSeries1.Marks.Shadow.Height = (int)this.numericUpDown1.Value;
		}

		private void panel2_MouseUp(object sender, MouseEventArgs e)
		{
			this.panel2.BackColor = Steema.TeeChart.Editors.ColorEditor.Choose(this.barSeries1.Marks.Shadow.Color,this);
			this.barSeries1.Marks.Shadow.Color = this.panel2.BackColor;
		}
	}
}

