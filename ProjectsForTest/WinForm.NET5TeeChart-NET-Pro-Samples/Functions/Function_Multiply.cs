using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Function_Multiply : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Styles.Bar barSeries2;
		private Steema.TeeChart.Functions.Multiply multiply1;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.ComponentModel.IContainer components = null;

		public Function_Multiply()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.Add(new double[6] {2,3,5,7,1,4});
			this.barSeries2.Add(new double[6] {1,5,9,3,8,2});
			this.lineSeries1.CheckDataSource();
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
			this.barSeries2 = new Steema.TeeChart.Styles.Bar();
			this.multiply1 = new Steema.TeeChart.Functions.Multiply();
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(354, 53);
			this.textBox1.Text = "The Multiply function calculates the product of every point of several data sourc" +
				"e series.";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 53);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(354, 11);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Multiply function"};
			this.tChart1.Location = new System.Drawing.Point(0, 64);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Series.Add(this.barSeries2);
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(354, 177);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			//this.barSeries1.Brush.Color = System.Drawing.Color.Red;
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
			this.barSeries1.Title = "Source1";
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
			// barSeries2
			// 
			// 
			// barSeries2.Brush
			// 
			//this.barSeries2.Brush.Color = System.Drawing.Color.Green;
			// 
			// barSeries2.Marks
			// 
			// 
			// barSeries2.Marks.Symbol
			// 
			// 
			// barSeries2.Marks.Symbol.Shadow
			// 
			this.barSeries2.Marks.Symbol.Shadow.Height = 1;
			this.barSeries2.Marks.Symbol.Shadow.Visible = true;
			this.barSeries2.Marks.Symbol.Shadow.Width = 1;
			this.barSeries2.Title = "Source2";
			// 
			// barSeries2.XValues
			// 
			this.barSeries2.XValues.DataMember = "X";
			this.barSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries2.YValues
			// 
			this.barSeries2.YValues.DataMember = "Bar";
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			//this.lineSeries1.Brush.Color = System.Drawing.Color.Yellow;
			this.lineSeries1.DataSource = new object[] {
																									 this.barSeries1,
																									 this.barSeries2};
			this.lineSeries1.Function = this.multiply1;
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Arrow
			// 
			this.lineSeries1.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			// 
			// lineSeries1.Marks.Brush
			// 
			this.lineSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			// 
			// lineSeries1.Marks.Font
			// 
			// 
			// lineSeries1.Marks.Font.Brush
			// 
			this.lineSeries1.Marks.Font.Brush.Color = System.Drawing.Color.Red;
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
			this.lineSeries1.Title = "Multiply";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// Function_Multiply
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(354, 241);
			this.Name = "Function_Multiply";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

