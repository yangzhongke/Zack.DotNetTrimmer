using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Function_Subtract : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Styles.Bar barSeries2;
		private Steema.TeeChart.Functions.Subtract subtract1;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.ComponentModel.IContainer components = null;

		public Function_Subtract()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.FillSampleValues(8);
			this.barSeries2.FillSampleValues(8);
			(this.subtract1.Series as Steema.TeeChart.Styles.Line).Pointer.Visible = true;
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
			this.subtract1 = new Steema.TeeChart.Functions.Subtract();
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(388, 55);
			this.textBox1.Text = "The Subtract function uses more than one series as data source. It calculates for" +
				" each point the difference between the last and first series.";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(388, 51);
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
																								 "Subtract funcion"};
			this.tChart1.Location = new System.Drawing.Point(0, 106);
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
			this.tChart1.Size = new System.Drawing.Size(388, 149);
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
			//this.barSeries2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
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
			//this.lineSeries1.Brush.Color = System.Drawing.Color.Green;
			this.lineSeries1.DataSource = new object[] {
																									 this.barSeries1,
																									 this.barSeries2};
			this.lineSeries1.Function = this.subtract1;
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
			this.lineSeries1.Title = "Subtract";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// Function_Subtract
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(388, 255);
			this.Name = "Function_Subtract";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

