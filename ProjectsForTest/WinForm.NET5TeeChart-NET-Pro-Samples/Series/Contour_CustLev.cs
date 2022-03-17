using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Contour_CustLev : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Contour contourSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		private void AddCustomLevels()
		{
			this.contourSeries1.NumLevels = 10;
			// TODO : this.contourSeries1.CreateAutoLevels(); still private ?
			(this.contourSeries1.Levels[0] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -1;
			(this.contourSeries1.Levels[1] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -0.8;
			(this.contourSeries1.Levels[2] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -0.6;
			(this.contourSeries1.Levels[3] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -0.4;
			(this.contourSeries1.Levels[4] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -0.2;
			(this.contourSeries1.Levels[5] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.0;
			(this.contourSeries1.Levels[6] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.2;
			(this.contourSeries1.Levels[7] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.4;
			(this.contourSeries1.Levels[8] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.6;
			(this.contourSeries1.Levels[9] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.8;
		}
		
		public Contour_CustLev()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.contourSeries1.FillSampleValues(20);
			this.contourSeries1.ColorEach = false;
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
			this.contourSeries1 = new Steema.TeeChart.Styles.Contour();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Contour levels can be customized at design-time or run-time.\r\nThe number of level" +
				"s and each level value and color are properties.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 34);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Contour series : custom levels"};
			this.tChart1.Location = new System.Drawing.Point(0, 97);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.contourSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			// 
			// contourSeries1
			// 
			// 
			// contourSeries1.Brush
			// 
			this.contourSeries1.Brush.Color = System.Drawing.Color.Red;
			this.contourSeries1.ColorEach = true;
			// 
			// contourSeries1.Marks
			// 
			// 
			// contourSeries1.Marks.Symbol
			// 
			// 
			// contourSeries1.Marks.Symbol.Shadow
			// 
			this.contourSeries1.Marks.Symbol.Shadow.Height = 1;
			this.contourSeries1.Marks.Symbol.Shadow.Visible = true;
			this.contourSeries1.Marks.Symbol.Shadow.Width = 1;
			this.contourSeries1.NumXValues = 25;
			this.contourSeries1.NumZValues = 25;
			this.contourSeries1.PaletteMin = 0;
			this.contourSeries1.PaletteStep = 0;
			this.contourSeries1.Title = "contourSeries1";
			// 
			// contourSeries1.XValues
			// 
			this.contourSeries1.XValues.DataMember = "X";
			this.contourSeries1.YPosition = 0.20290816683830415;
			// 
			// contourSeries1.YValues
			// 
			this.contourSeries1.YValues.DataMember = "Y";
			// 
			// contourSeries1.ZValues
			// 
			this.contourSeries1.ZValues.DataMember = "Z";
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(100, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Custom levels";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Contour_CustLev
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Contour_CustLev";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.contourSeries1.AutomaticLevels = !this.checkBox1.Checked;
			if (!this.contourSeries1.AutomaticLevels) this.AddCustomLevels();
		}
	}
}

