using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Donut_Series : Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private Steema.TeeChart.Styles.Donut donutSeries1;
		private System.ComponentModel.IContainer components = null;

		public Donut_Series()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.donutSeries1.FillSampleValues(8);
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
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.donutSeries1 = new Steema.TeeChart.Styles.Donut();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 73);
			this.textBox1.Text = "Donut series draws points very similar to Pie series, with a middle hole. The hol" +
				"e dimensions can be configured as percent of circle radius.\r\n\r\nExample: donutSer" +
				"ies1.DonutPercent =75;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 31);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 20;
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			this.tChart1.Legend.Shadow.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(215)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(215)), ((System.Byte)(0)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.donutSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Hole %";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Increment = new System.Decimal(new int[] {
																																		 5,
																																		 0,
																																		 0,
																																		 0});
			this.numericUpDown1.Location = new System.Drawing.Point(67, 6);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 50,
																																 0,
																																 0,
																																 0});
			this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// donutSeries1
			// 
			// 
			// donutSeries1.Brush
			// 
			this.donutSeries1.Brush.Color = System.Drawing.Color.Red;
			this.donutSeries1.LabelMember = "Labels";
			// 
			// donutSeries1.Marks
			// 
			// 
			// donutSeries1.Marks.Symbol
			// 
			// 
			// donutSeries1.Marks.Symbol.Shadow
			// 
			this.donutSeries1.Marks.Symbol.Shadow.Height = 1;
			this.donutSeries1.Marks.Symbol.Shadow.Visible = true;
			this.donutSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// donutSeries1.Pen
			// 
			this.donutSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			// 
			// donutSeries1.Shadow
			// 
			this.donutSeries1.Shadow.Height = 20;
			this.donutSeries1.Shadow.Width = 20;
			this.donutSeries1.Title = "donutSeries1";
			// 
			// donutSeries1.XValues
			// 
			this.donutSeries1.XValues.DataMember = "Angle";
			this.donutSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// donutSeries1.YValues
			// 
			this.donutSeries1.YValues.DataMember = "Pie";
			// 
			// SeriesType_Donut
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Donut";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.donutSeries1.DonutPercent = (int)numericUpDown1.Value;
		}
	}
}

