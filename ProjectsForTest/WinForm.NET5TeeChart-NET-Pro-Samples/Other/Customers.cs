using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Summary description for Costomers.
	/// </summary>
	public class Customers : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Customers()
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
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(266, 248);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = @"Some of the (many tens of thousands) TeeChart Pro customers are...

-Microsoft
-CommerzBank
-Siemens
-Dell
-Compaq
-Allied Signal.
-Discovery Com.
-Disney
-Mayo Found. Rochester.
-Arthur & Andersen.
-Duracell.
-Merril Lynch.
-BASF.
-ENSCO Inc.
-Michelin.
-Barclays.
-Ericsson.
-Mitsubishi Chemical Amer. 
-Bell Helicopter Textron. 
-Flex Control.
-Motorola. 
-Benetton Formula LDT. 
-Ford. 
-The National Trust.
-BP (British Petroleum). 
-General Motors. 
-Nokia.
-B.B.C. 
-HBO. 
-Norwest Financial Inf. 
-Cannon. 
-Heinrich Hertz.
-Pinacle Automation.
-Campbell Soup. 
-Hewlett Packard. 
-Philips.
-Champion Intl. 
-Home Savings of Amer. 
-Porsche. 
-Colgate Palmolive.
-Kraft Foods 
-COSTaFAC 2001 
-C&F. 
-Lifescan. 
-Inverline.com
-Crown Intl.
-Mathoolds. 
-Tel-Aviv University

* All names are trademarks or registered trademarks of their respective owners.
 ";
			// 
			// Customers
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(266, 248);
			this.Controls.Add(this.textBox1);
			this.Name = "Customers";
			this.Text = "Customers";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
