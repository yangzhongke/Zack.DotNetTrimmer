using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Chart_Shadow : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public Chart_Shadow()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			tChart1.Panel.Shadow.Visible = true;
			tChart1.Panel.Shadow.Size = new System.Drawing.Size(6, 6);

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
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Chart Panel now includes a Shadow property.\r\n\r\ntChart1.Panel.Shadow.Height = 6;";
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
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Chart Panel Shadow"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
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
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(112, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Show Shadow";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Edit Shadow...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Panel_Shadow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Panel_Shadow";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Samples.ShadowEditor shadEdit = new Steema.TeeChart.Samples.ShadowEditor(tChart1.Panel.Shadow);
			shadEdit.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			shadEdit.ShowDialog();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) {
			if(checkBox1.Checked)
				tChart1.Panel.Shadow.Size = new System.Drawing.Size(6, 6);
			else
				tChart1.Panel.Shadow.Size = new System.Drawing.Size(0, 0);
		
		}
	}
}

