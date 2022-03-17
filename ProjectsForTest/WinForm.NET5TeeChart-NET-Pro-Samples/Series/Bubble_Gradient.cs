using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Bubble_Gradient : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Bubble bubble1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public Bubble_Gradient()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bubble1.FillSampleValues();
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
			this.bubble1 = new Steema.TeeChart.Styles.Bubble();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Bubble series can now fill points using a gradient. \r\n\r\nbubble1.Pointer.Gradient." +
				"Visible = true;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Name = "tChart1";
			this.tChart1.Series.Add(this.bubble1);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Use Gradient";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// bubble1
			// 
			// 
			// bubble1.Marks
			// 
			this.bubble1.Marks.Transparent = true;
			// 
			// bubble1.Pointer
			// 
			// 
			// bubble1.Pointer.Brush
			// 
			this.bubble1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			// 
			// bubble1.Pointer.Brush.Gradient
			// 
			this.bubble1.Pointer.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.bubble1.Pointer.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.bubble1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.bubble1.Pointer.Brush.Gradient.UseMiddle = true;
			this.bubble1.Pointer.Brush.Gradient.Visible = true;
			this.bubble1.Pointer.HorizSize = 15;
			this.bubble1.Pointer.InflateMargins = false;
			this.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.bubble1.Pointer.VertSize = 15;
			this.bubble1.Title = "bubble1";
			// 
			// bubble1.XValues
			// 
			this.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(141, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Edit Gradient...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Bubble_Gradient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Bubble_Gradient";
			this.panel1.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e) {
			bubble1.Pointer.Gradient.Visible = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.GradientEditor.Edit(bubble1.Pointer.Gradient);
		}
	}
}

