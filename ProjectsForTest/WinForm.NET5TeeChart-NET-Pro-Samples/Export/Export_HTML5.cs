using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Export_HTML5 : Steema.TeeChart.Samples.BaseForm
	{
    private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public Export_HTML5()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();


      tChart1.Aspect.View3D = false;
      tChart1.Header.Text = "TeeChart in HTML5";
      Steema.TeeChart.Styles.HorizBar horizBar1 = new Steema.TeeChart.Styles.HorizBar(tChart1.Chart);
      horizBar1.FillSampleValues();

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
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Name = "textBox1";
      this.textBox1.Text = "Press the button to export to HTML5 and open the file in a browser instance.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      this.panel1.Name = "panel1";
      // 
      // tChart1
      // 
      this.tChart1.Name = "tChart1";
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // chartContainer
      // 
      this.chartContainer.Name = "chartContainer";
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(16, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(112, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Export to HTML5...";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Export_HTML5
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Export_HTML5";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

    private void button1_Click(object sender, System.EventArgs e)
    {
      string path = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + @"\charthtml5.html";
      tChart1.Export.Image.HTML5.Save(path);
      System.Diagnostics.Process.Start(path);
    }
	}
}

