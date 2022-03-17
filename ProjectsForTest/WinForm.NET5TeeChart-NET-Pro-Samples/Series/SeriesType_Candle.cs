using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Candle : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Candle candleSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Candle()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			candleSeries1.FillSampleValues(20);
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
			this.candleSeries1 = new Steema.TeeChart.Styles.Candle();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = @"Candle (OHLC) series displays financial data in several ways (Candle, Bar and Stick). Candle colors are calculated based on their Open and Close values. Weekend data can be removed using a sequential index for the X value.
Configuration options include border, draw 3D, open and close colors, candle style, marks, etc. Candle charts are the base for financial functions (RSI, etc).";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
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
																								 "Candle OHCL"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.candleSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			this.tChart1.Tools.Add(this.gridBand1);
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
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// candleSeries1
			// 
			// 
			// candleSeries1.Brush
			// 
			this.candleSeries1.Brush.Color = System.Drawing.Color.Red;
			this.candleSeries1.CloseValues = this.candleSeries1.YValues;
			this.candleSeries1.DateValues = this.candleSeries1.XValues;
			// 
			// candleSeries1.Marks
			// 
			// 
			// candleSeries1.Marks.Symbol
			// 
			// 
			// candleSeries1.Marks.Symbol.Shadow
			// 
			this.candleSeries1.Marks.Symbol.Shadow.Height = 1;
			this.candleSeries1.Marks.Symbol.Shadow.Visible = true;
			this.candleSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// candleSeries1.Pointer
			// 
			this.candleSeries1.Pointer.Draw3D = false;
			this.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candleSeries1.Title = "candle1";
			// 
			// candleSeries1.XValues
			// 
			this.candleSeries1.XValues.DataMember = "Date";
			this.candleSeries1.XValues.DateTime = true;
			this.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// candleSeries1.YValues
			// 
			this.candleSeries1.YValues.DataMember = "Close";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(59, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Border";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(73, 9);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(79, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Draw 3D";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(168, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "&Style :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Stick",
																									 "Bar",
																									 "Open-Close"});
			this.comboBox1.Location = new System.Drawing.Point(208, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(86, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(327, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(204)));
			this.gridBand1.Band2.ForegroundColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(244)));
			this.gridBand1.Band2.Solid = false;
			this.gridBand1.Band2.Style = Drawing.HatchStyle.NarrowHorizontal;
			// 
			// SeriesType_Candle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Candle";
			this.Load += new System.EventHandler(this.SeriesType_Candle_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.candleSeries1);
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : candleSeries1.Style = Steema.TeeChart.Styles.CandleStyles.CandleStick; break;
				case 1 : candleSeries1.Style = Steema.TeeChart.Styles.CandleStyles.CandleBar; break;
				case 2 : candleSeries1.Style = Steema.TeeChart.Styles.CandleStyles.OpenClose; break;
			}
		}

		private void SeriesType_Candle_Load(object sender, System.EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			candleSeries1.Pointer.Draw3D = checkBox2.Checked;
			tChart1.Aspect.View3D = checkBox2.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			candleSeries1.Pointer.Pen.Visible = checkBox1.Checked;
		}
	}
}

