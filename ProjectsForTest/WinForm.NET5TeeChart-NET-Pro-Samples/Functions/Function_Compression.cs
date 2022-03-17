using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Function_Compression : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private Steema.TeeChart.Styles.Candle candle1;
		private Steema.TeeChart.Functions.CompressOHLC compressOHLC1;
		private Steema.TeeChart.Styles.Candle candle2;
		private System.ComponentModel.IContainer components = null;

		public Function_Compression()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			candle1.FillSampleValues(500);
			candle2.Visible = false;
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.candle1 = new Steema.TeeChart.Styles.Candle();
			this.compressOHLC1 = new Steema.TeeChart.Functions.CompressOHLC();
			this.candle2 = new Steema.TeeChart.Styles.Candle();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Compression function calculates high and low values for a group of points. \r\nResu" +
				"lts are plotted using a Candle series. \r\n\r\nSuitable for displaying Candle OHLC d" +
				"ata \"weekly\", \"monthly\", etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Name = "panel1";
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
																								 "tChart1"};
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
			this.tChart1.Series.Add(this.candle1);
			this.tChart1.Series.Add(this.candle2);
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
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Compression period:";
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
																									 "Daily",
																									 "Weekly",
																									 "Monthly",
																									 "Bi-monthly",
																									 "Quarterly",
																									 "Yearly"});
			this.comboBox1.Location = new System.Drawing.Point(120, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "Daily";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(246, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "View:";
			// 
			// comboBox2
			// 
			this.comboBox2.Items.AddRange(new object[] {
																									 "CandleBar",
																									 "CandleStick",
																									 "Line",
																									 "OpenClose"});
			this.comboBox2.Location = new System.Drawing.Point(287, 8);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(107, 21);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.Text = "CandleStick";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// candle1
			// 
			// 
			// candle1.Brush
			// 
			this.candle1.Brush.Color = System.Drawing.Color.Red;
			this.candle1.CloseValues = this.candle1.YValues;
			this.candle1.DateValues = this.candle1.XValues;
			// 
			// candle1.Marks
			// 
			// 
			// candle1.Marks.Symbol
			// 
			// 
			// candle1.Marks.Symbol.Shadow
			// 
			this.candle1.Marks.Symbol.Shadow.Height = 1;
			this.candle1.Marks.Symbol.Shadow.Visible = true;
			this.candle1.Marks.Symbol.Shadow.Width = 1;
			// 
			// candle1.Pointer
			// 
			// 
			// candle1.Pointer.Brush
			// 
			this.candle1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.candle1.Pointer.Draw3D = false;
			this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Title = "candle1";
			// 
			// candle1.XValues
			// 
			this.candle1.XValues.DataMember = "Date";
			this.candle1.XValues.DateTime = true;
			this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// candle1.YValues
			// 
			this.candle1.YValues.DataMember = "Close";
			// 
			// compressOHLC1
			// 
			this.compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocWeek;
			// 
			// candle2
			// 
			// 
			// candle2.Brush
			// 
			this.candle2.Brush.Color = System.Drawing.Color.Green;
			this.candle2.CloseValues = this.candle2.YValues;
			this.candle2.DataSource = this.candle1;
			this.candle2.DateValues = this.candle2.XValues;
			this.candle2.Function = this.compressOHLC1;
			// 
			// candle2.Marks
			// 
			// 
			// candle2.Marks.Symbol
			// 
			// 
			// candle2.Marks.Symbol.Shadow
			// 
			this.candle2.Marks.Symbol.Shadow.Height = 1;
			this.candle2.Marks.Symbol.Shadow.Visible = true;
			this.candle2.Marks.Symbol.Shadow.Width = 1;
			// 
			// candle2.Pointer
			// 
			// 
			// candle2.Pointer.Brush
			// 
			this.candle2.Pointer.Brush.Color = System.Drawing.Color.Green;
			this.candle2.Pointer.Draw3D = false;
			this.candle2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle2.Title = "candle2";
			// 
			// candle2.XValues
			// 
			this.candle2.XValues.DateTime = true;
			this.candle2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// Function_CompressOHLC
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Function_CompressOHLC";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			candle1.Visible = false;
			candle2.Visible = true;

			switch(comboBox1.SelectedIndex) {
				case 0:
					compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocDay;
					break;
				case 1:
					compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocWeek;
					break;
				case 2:
					compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocMonth;
					break;
				case 3:
					compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocBiMonth;
					break;
				case 4:
					compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocQuarter;
					break;
				case 5:
					compressOHLC1.Compress = Steema.TeeChart.Functions.CompressionPeriod.ocYear;
					break;
			}
		
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch(comboBox2.SelectedIndex) {
				case 0:
					candle1.Style = Steema.TeeChart.Styles.CandleStyles.CandleBar;
					break;
				case 1:
					candle1.Style = Steema.TeeChart.Styles.CandleStyles.CandleStick;
					break;
				case 2:
					candle1.Style = Steema.TeeChart.Styles.CandleStyles.Line;
					break;
				case 3:
					candle1.Style = Steema.TeeChart.Styles.CandleStyles.OpenClose;
					break;
			}
			candle2.Style = candle1.Style;
		}
	}
}

