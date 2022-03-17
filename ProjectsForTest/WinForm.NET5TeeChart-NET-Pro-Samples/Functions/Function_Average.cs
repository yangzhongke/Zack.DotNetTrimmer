using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Function_Average : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Functions.Average average1;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Functions.High high1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Functions.Low low1;
		private Steema.TeeChart.Styles.Line lineSeries3;
		private System.ComponentModel.IContainer components = null;

		public Function_Average()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.FillSampleValues(8);
			(this.average1.Series as Steema.TeeChart.Styles.Line).Pointer.Visible = true;
			(this.high1.Series as Steema.TeeChart.Styles.Line).Pointer.Visible = true;
			(this.low1.Series as Steema.TeeChart.Styles.Line).Pointer.Visible = true;
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
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.average1 = new Steema.TeeChart.Functions.Average();
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.high1 = new Steema.TeeChart.Functions.High();
			this.lineSeries2 = new Steema.TeeChart.Styles.Line();
			this.low1 = new Steema.TeeChart.Functions.Low();
			this.lineSeries3 = new Steema.TeeChart.Styles.Line();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 104);
			this.textBox1.Text = @"+ The Average function calculates the sum of all points in the data source and divides the result by number of points. It can also be used to calculate averages by every ""n"" number of points.
+ The High function calculates the greatest of all points in the data source. It can also be used to calculate the highest value by every ""n"" number of points.
+ The Low function calculates the smallest of all points in the data source. It can also be used to calculate the lowest value by every ""n"" number of points.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 104);
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
																								 "Average function"};
			this.tChart1.Location = new System.Drawing.Point(0, 138);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Series.Add(this.lineSeries2);
			this.tChart1.Series.Add(this.lineSeries3);
			this.tChart1.Size = new System.Drawing.Size(466, 148);
			// 
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// barSeries1.Marks
			// 
			// 
			// barSeries1.Marks.Symbol
			// 
			// 
			// barSeries1.Marks.Symbol.Shadow
			// 
			this.barSeries1.Marks.Symbol.Shadow.Height = 1;
			this.barSeries1.Marks.Symbol.Shadow.Visible = true;
			this.barSeries1.Marks.Symbol.Shadow.Width = 1;
			this.barSeries1.Title = "Data";
			// 
			// barSeries1.XValues
			// 
			this.barSeries1.XValues.DataMember = "X";
			this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries1.YValues
			// 
			this.barSeries1.YValues.DataMember = "Bar";
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.Green;
			this.lineSeries1.DataSource = this.barSeries1;
			this.lineSeries1.Function = this.average1;
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Brush
			// 
			this.lineSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// lineSeries1.Marks.Font
			// 
			// 
			// lineSeries1.Marks.Font.Brush
			// 
			this.lineSeries1.Marks.Font.Brush.Color = System.Drawing.Color.White;
			this.lineSeries1.Marks.Font.Size = 7;
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			this.lineSeries1.Marks.Visible = true;
			// 
			// lineSeries1.Pointer
			// 
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "Average";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(127, 21);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "&By every 2 points";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// lineSeries2
			// 
			// 
			// lineSeries2.Brush
			// 
			this.lineSeries2.Brush.Color = System.Drawing.Color.Yellow;
			this.lineSeries2.DataSource = this.barSeries1;
			this.lineSeries2.Function = this.high1;
			// 
			// lineSeries2.Marks
			// 
			// 
			// lineSeries2.Marks.Symbol
			// 
			// 
			// lineSeries2.Marks.Symbol.Shadow
			// 
			this.lineSeries2.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries2.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries2.Pointer
			// 
			this.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries2.Title = "High";
			// 
			// lineSeries2.XValues
			// 
			this.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries3
			// 
			// 
			// lineSeries3.Brush
			// 
			this.lineSeries3.Brush.Color = System.Drawing.Color.Blue;
			this.lineSeries3.DataSource = this.barSeries1;
			this.lineSeries3.Function = this.low1;
			// 
			// lineSeries3.Marks
			// 
			// 
			// lineSeries3.Marks.Symbol
			// 
			// 
			// lineSeries3.Marks.Symbol.Shadow
			// 
			this.lineSeries3.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries3.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries3.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries3.Pointer
			// 
			this.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries3.Title = "Low";
			// 
			// lineSeries3.XValues
			// 
			this.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// Function_Average
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Function_Average";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked) 
			{
				this.average1.Period = 2;
				this.high1.Period = 2;
				this.low1.Period = 2;
			}
			else 
			{
				this.average1.Period = 0; // all points
				this.high1.Period = 0; // all points
				this.low1.Period = 0; // all points
			}
		}
	}
}

