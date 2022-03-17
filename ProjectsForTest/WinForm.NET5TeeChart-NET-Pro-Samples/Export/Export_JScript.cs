using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Export_JScript : Steema.TeeChart.Samples.BaseForm
	{
    private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

    public Export_JScript()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();


      tChart1.Aspect.View3D = false;
      tChart1.Header.Text = "TeeChart Javascript on HTML5 Cnvas";
      Steema.TeeChart.Styles.Bar bar1 = new Steema.TeeChart.Styles.Bar(tChart1.Chart);
      bar1.FillSampleValues();

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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_JScript));
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(16, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(112, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Export to JScript...";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Export_JScript
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Export_JScript";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }
		#endregion

    private void button1_Click(object sender, System.EventArgs e)
    {
      string path = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + @"\chartjscript.html";
      tChart1.Export.Image.JScript.Save(path);
      System.Diagnostics.Process.Start(path);
    }
	}
}

