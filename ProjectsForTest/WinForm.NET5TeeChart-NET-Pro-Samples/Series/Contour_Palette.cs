using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Contour_Palette : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Contour contourSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.ComponentModel.IContainer components = null;

		public Contour_Palette()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			contourSeries1.FillSampleValues(25);
            contourSeries1.ContourMarks.Visible = true;
			contourSeries1.ColorEach = false;

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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 40);
			this.textBox1.Text = "Contour Series uses ColorRange and Palette properties like the Surface series doe" +
				"s.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
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
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 73);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.contourSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 213);
			// 
			// contourSeries1
			// 
			// 
			// contourSeries1.Brush
			// 
			this.contourSeries1.Brush.Color = System.Drawing.Color.Red;
			this.contourSeries1.ColorEach = true;
            this.contourSeries1.Brush.Visible = false;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Colors:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Single color",
																									 "Gradient 2 colors",
																									 "Gradient 3 colors",
																									 "Palette pale",
																									 "Palette strong"});
			this.comboBox1.Location = new System.Drawing.Point(60, 7);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Contour_Palette
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Contour_Palette";
			this.Load += new System.EventHandler(this.Contour_Palette_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Contour_Palette_Load(object sender, System.EventArgs e)
		{
			comboBox1.SelectedIndex = 2;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : // single
				{
					contourSeries1.UseColorRange = false; 
					contourSeries1.UsePalette = false;
					contourSeries1.Color = Color.Coral;
                    contourSeries1.Brush.Visible = false;
					break;
				}
				case 1 : // grad two colors
				{
					contourSeries1.UseColorRange = true; 
					contourSeries1.UsePalette = false;
					contourSeries1.StartColor = Color.Blue;
                    contourSeries1.MidColor = Color.Transparent;
                    contourSeries1.EndColor = Color.Red;
					break;
				}
				case 2: // grad three colors
				{
					contourSeries1.UseColorRange = true; 
					contourSeries1.UsePalette = false;
					contourSeries1.StartColor = Color.Blue;
                    contourSeries1.MidColor = Color.Yellow; 
                    contourSeries1.EndColor = Color.Red;
					break;
				}
				case 3: // palette pale style
				{
					contourSeries1.UseColorRange = false; 
					contourSeries1.UsePalette = true;
					contourSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
					break;
				}
				case 4: // palette strong style
				{
					contourSeries1.UseColorRange = false; 
					contourSeries1.UsePalette = true;
					contourSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong;
					break;
				}
			}
		}
	}
}

