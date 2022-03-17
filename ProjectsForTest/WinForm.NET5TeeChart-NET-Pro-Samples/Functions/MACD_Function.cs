using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart.Functions;

namespace Steema.TeeChart.Samples
{
	public class MACD_Function : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Candle candle1;
		private Steema.TeeChart.Axis axis1;
		private Steema.TeeChart.Styles.Line line1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.ComponentModel.IContainer components = null;

		public MACD_Function()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			candle1.FillSampleValues(200);
			line1.Function = new Steema.TeeChart.Functions.MACDFunction(tChart1.Chart);
			line1.CheckDataSource();

			numericUpDown1.Value = Convert.ToDecimal((line1.Function as Steema.TeeChart.Functions.MACDFunction).Period);
			numericUpDown2.Value = Convert.ToDecimal((line1.Function as Steema.TeeChart.Functions.MACDFunction).Period2);
		  numericUpDown3.Value = Convert.ToDecimal((line1.Function as Steema.TeeChart.Functions.MACDFunction).Period3);

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
			this.components = new System.ComponentModel.Container();
			this.candle1 = new Steema.TeeChart.Styles.Candle();
			this.axis1 = new Steema.TeeChart.Axis(this.tChart1.Chart);
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The MACD function (Moving Average Convergence Divergence) ,\r\nused in financial ch" +
				"arts. ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			this.tChart1.Axes.Custom.Add(this.axis1);
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.EndPosition = 48;
			// 
			// tChart1.Axes.Left.Title
			// 
			this.tChart1.Axes.Left.Title.Caption = "Candle";
			// 
			// tChart1.Axes.Left.Title.Font
			// 
			// 
			// tChart1.Axes.Left.Title.Font.Brush
			// 
			this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.Navy;
			// 
			// tChart1.Axes.Left.Title.Font.Shadow
			// 
			// 
			// tChart1.Axes.Left.Title.Font.Shadow.Brush
			// 
			this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(192)));
			this.tChart1.Axes.Left.Title.Font.Shadow.Height = 0;
			this.tChart1.Axes.Left.Title.Font.Shadow.Width = 0;
			this.tChart1.Axes.Left.Title.Lines = new string[] {
																													"Candle"};
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.candle1);
			this.tChart1.Series.Add(this.line1);
			// 
			// candle1
			// 
			// 
			// candle1.Brush
			// 
			this.candle1.Brush.Color = System.Drawing.Color.Red;
			this.candle1.CloseValues = this.candle1.YValues;
			this.candle1.DateValues = this.candle1.XValues;
			this.candle1.DownCloseColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
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
			this.candle1.Pointer.Draw3D = false;
			this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Style = Steema.TeeChart.Styles.CandleStyles.CandleBar;
			this.candle1.Title = "Source";
			this.candle1.UpCloseColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
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
			// axis1
			// 
			this.axis1.Horizontal = false;
			this.axis1.OtherSide = false;
			this.axis1.StartPosition = 52;
			// 
			// axis1.Title
			// 
			this.axis1.Title.Angle = 90;
			this.axis1.Title.Caption = "MACD";
			// 
			// axis1.Title.Font
			// 
			// 
			// axis1.Title.Font.Brush
			// 
			this.axis1.Title.Font.Brush.Color = System.Drawing.Color.Green;
			this.axis1.Title.Lines = new string[] {
																							"MACD"};
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.Green;
			this.line1.CustomVertAxis = this.axis1;
			this.line1.DataSource = this.candle1;
			// 
			// line1.Marks
			// 
			// 
			// line1.Marks.Symbol
			// 
			// 
			// line1.Marks.Symbol.Shadow
			// 
			this.line1.Marks.Symbol.Shadow.Height = 1;
			this.line1.Marks.Symbol.Shadow.Visible = true;
			this.line1.Marks.Symbol.Shadow.Width = 1;
			// 
			// line1.Pointer
			// 
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "MACD";
			this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// line1.XValues
			// 
			this.line1.XValues.DateTime = true;
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line1.YValues
			// 
			this.line1.YValues.DataMember = "Close";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(88, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Show MACD";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(94, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(189, 37);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Period";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(124, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "3:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(62, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "2:";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(138, 13);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(44, 20);
			this.numericUpDown3.TabIndex = 2;
			this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(77, 13);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(44, 20);
			this.numericUpDown2.TabIndex = 1;
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(15, 13);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "1:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(293, 4);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(136, 16);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Show line MACD &Exp.";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(293, 22);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(136, 16);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "Show &Histogram";
			this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
			// 
			// MACDFunction
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "MACDFunction";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			line1.Active = checkBox1.Checked;
			(line1.Function as Steema.TeeChart.Functions.MACDFunction).MACDExp.Active = line1.Active;
			(line1.Function as Steema.TeeChart.Functions.MACDFunction).Histogram.Active = line1.Active;

			tChart1.Legend.Visible = checkBox1.Checked;
			axis1.Visible = line1.Active;
			if(line1.Active) tChart1.Axes.Left.EndPosition = 50;
			else tChart1.Axes.Left.EndPosition = 100;
			
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			(line1.Function as Steema.TeeChart.Functions.MACDFunction).Period = Convert.ToDouble(numericUpDown1.Value);
		}

		private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
		{
			(line1.Function as Steema.TeeChart.Functions.MACDFunction).Period2 = Convert.ToDouble(numericUpDown2.Value);
		}

		private void numericUpDown3_ValueChanged(object sender, System.EventArgs e)
		{
			(line1.Function as Steema.TeeChart.Functions.MACDFunction).Period3= Convert.ToDouble(numericUpDown3.Value);
		}

		private void checkBox2_Click(object sender, System.EventArgs e)
		{
			(line1.Function as Steema.TeeChart.Functions.MACDFunction).MACDExp.Active = checkBox2.Checked;
		}

		private void checkBox3_Click(object sender, System.EventArgs e)
		{
			(line1.Function as Steema.TeeChart.Functions.MACDFunction).Histogram.Active = checkBox3.Checked;
		}
	}
}

