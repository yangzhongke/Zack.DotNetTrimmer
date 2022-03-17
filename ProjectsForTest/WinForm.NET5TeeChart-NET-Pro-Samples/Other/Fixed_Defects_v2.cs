using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Summary description for Fixed_Defects_v2.
	/// </summary>
	public class FixedDefectsv2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FixedDefectsv2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(267, 241);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = @"Release v2.0 beta

Defect		Description
-----------		--------------
TF02010076	DataSources not appearing in WebChart Chart Editor
TF02010054 	Changing Chart type at runtime/designtime disassociated 
		series from DataSource.
TF02010194 	ZoomText property not functional with rotated text
TF02010249 	Changing Scroll style in Chart Editor not functional
TF02010250 	Changing the Zoom Allow checkbox in Chart Editor not functional
TF02010297 	When deleting a line with ‘DrawLine.DeleteSelected’ the 
		DrawHandles remain
TF02010275 	Changing Chart type at runtime/designtime disassociated 
		series from Custom axes.
TF02010289 	Checking/UnChecking Series in the Legend with checkboxes set
		to true and using scroll does not work correctly.
TF02010261	Excessive memory usage when chart with Contour series
		loses focus at design or runtime.
TF02010228	Image Patterns example in the Feature Demo non-functional.
TF02010627	BarWidthPercent (Bar Series) non-functional at designtime. Fixed.";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// FixedDefectsv2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(267, 241);
			this.Controls.Add(this.textBox1);
			this.Name = "FixedDefectsv2";
			this.Text = "Fixed Defects";
			this.ResumeLayout(false);

		}
		#endregion

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
