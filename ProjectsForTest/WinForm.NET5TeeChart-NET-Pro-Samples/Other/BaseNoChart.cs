using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Summary description for BaseNoChart.
	/// </summary>
	public class BaseNoChart : System.Windows.Forms.Form
	{
		protected internal System.Windows.Forms.TextBox textBox1;
		protected System.Windows.Forms.Panel panel1;
		protected internal System.Windows.Forms.Panel panel2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BaseNoChart()
		{
			//
			// Required for Windows Form Designer support
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBox1.Location = new System.Drawing.Point(0, 0);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(426, 62);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "";
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 62);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(426, 42);
      this.panel1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 104);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(426, 154);
      this.panel2.TabIndex = 4;
      // 
      // BaseNoChart
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(426, 258);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.textBox1);
      this.Name = "BaseNoChart";
      this.Text = "BaseNoChart";
      this.ResumeLayout(false);

    }
		#endregion
	}
}
