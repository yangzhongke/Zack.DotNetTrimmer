using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Series3D_AddArray : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.ColorGrid colorGrid1;
		private System.ComponentModel.IContainer components = null;

		public Series3D_AddArray()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			Random rnd = new Random();
			double[] xValues = new double[36];
			double[] yValues = new double[36];
			double[] zValues = new double[36];
			int count=0;

			for(double x=0; x < 6; ++x) {
				for(double y=0; y < 6; ++y) {
					xValues[count] = x;
					zValues[count] = y;
					yValues[count] = rnd.Next(100);
					++count;
				}
			}

			colorGrid1.Add(xValues, yValues, zValues);
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
			this.colorGrid1 = new Steema.TeeChart.Styles.ColorGrid();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "All 3D Series (surface, contour, colorgrid, etc) include a new method to add a un" +
				"i-dimensional set of arrays (x by z grid of values). \r\n\r\ncolorGrid1.Add(xValues," +
				" yValues, zValues);";
			// 
			// panel1
			// 
			this.panel1.Name = "panel1";
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
			this.tChart1.Header.Lines = new string[0];
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.colorGrid1);
			// 
			// colorGrid1
			// 
			// 
			// colorGrid1.Brush
			// 
			this.colorGrid1.Brush.Color = System.Drawing.Color.Red;
			// 
			// colorGrid1.Marks
			// 
			this.colorGrid1.Marks.ArrowLength = 0;
			// 
			// colorGrid1.Marks.Symbol
			// 
			// 
			// colorGrid1.Marks.Symbol.Shadow
			// 
			this.colorGrid1.Marks.Symbol.Shadow.Height = 1;
			this.colorGrid1.Marks.Symbol.Shadow.Visible = true;
			this.colorGrid1.Marks.Symbol.Shadow.Width = 1;
			this.colorGrid1.PaletteMin = 0;
			this.colorGrid1.PaletteStep = 0;
			this.colorGrid1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong;
			this.colorGrid1.Title = "colorGrid1";
			this.colorGrid1.UseColorRange = false;
			this.colorGrid1.UsePalette = true;
			// 
			// colorGrid1.XValues
			// 
			this.colorGrid1.XValues.DataMember = "X";
			// 
			// colorGrid1.YValues
			// 
			this.colorGrid1.YValues.DataMember = "Y";
			// 
			// colorGrid1.ZValues
			// 
			this.colorGrid1.ZValues.DataMember = "Z";
			// 
			// Series3D_AddArray
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Series3D_AddArray";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

