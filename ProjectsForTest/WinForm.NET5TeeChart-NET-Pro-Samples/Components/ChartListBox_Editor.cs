using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ChartListBoxEditor : Steema.TeeChart.Samples.ChartListBoxRadio
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public ChartListBoxEditor()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.radioButton1.Visible=false;
			this.radioButton2.Visible=false;
			this.groupBox1.Visible=false;
			
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
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// chartListBox1
			// 
			this.chartListBox1.Name = "chartListBox1";
			// 
			// groupBox1
			// 
			this.groupBox1.Name = "groupBox1";
			// 
			// radioButton1
			// 
			this.radioButton1.Name = "radioButton1";
			// 
			// radioButton2
			// 
			this.radioButton2.Name = "radioButton2";
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Pressing F2 or calling a method is possible to edit the ChartListBox text\r\nof the" +
				" selected Series.\r\n\r\nPress F2 or click \"Editor\" checkbox. To hide the editor, pr" +
				"ess F2, Escape,\r\nEnter or arrows keys or click anywhere in the list.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			this.panel1.Controls.SetChildIndex(this.checkBox1, 0);
			this.panel1.Controls.SetChildIndex(this.groupBox1, 0);
			// 
			// panel2
			// 
			this.panel2.Name = "panel2";
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(192, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Editor";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// ChartListBoxEditor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(426, 258);
			this.Name = "ChartListBoxEditor";
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e) {
			if(checkBox1.Checked)
				chartListBox1.ShowEditor();
      else 
				chartListBox1.HideEditor();
		}
	}
}

