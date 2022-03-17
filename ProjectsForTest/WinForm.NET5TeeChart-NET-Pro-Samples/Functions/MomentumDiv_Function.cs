using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class MomentumDiv_Function : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Functions.MomentumDivision momentumDivision1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Tools.ColorLine colorLine1;
		private Steema.TeeChart.Axis axis1;
		private System.ComponentModel.IContainer components = null;

		public MomentumDiv_Function()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.lineSeries1.FillSampleValues(50);
			this.lineSeries2.CheckDataSource();
			// set the correct position for the blue line...
			this.colorLine1.Value = this.lineSeries1.YValues.Minimum;
			// function is = 100 * Value / (Previous 10th value)
			this.momentumDivision1.Period = 10;
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.momentumDivision1 = new Steema.TeeChart.Functions.MomentumDivision();
			this.lineSeries2 = new Steema.TeeChart.Styles.Line();
            this.axis1 = new Steema.TeeChart.Axis(this.tChart1.Chart);
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.colorLine1 = new Steema.TeeChart.Tools.ColorLine();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(425, 64);
			this.textBox1.Text = "The Momentum Division function calculates the ratio of a point value compared to " +
				"the previous N point value.\r\n\r\nThe formula is :   Momentum = 100 * Value / Previ" +
				"ousValue";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(425, 37);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Axes
			// 
			this.tChart1.Axes.Custom.Add(this.axis1);
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.EndPosition = 80;
			this.tChart1.Axes.Left.LogarithmicBase = 2;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Momentum Div. function"};
			this.tChart1.Location = new System.Drawing.Point(0, 101);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Series.Add(this.lineSeries2);
			this.tChart1.Size = new System.Drawing.Size(425, 169);
			this.tChart1.Tools.Add(this.colorLine1);
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
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			//this.lineSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries1.Pointer
			// 
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "Source";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.DataMember = "X";
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries1.YValues
			// 
			this.lineSeries1.YValues.DataMember = "Y";
			// 
			// momentumDivision1
			// 
			this.momentumDivision1.Period = 1;
			// 
			// lineSeries2
			// 
			// 
			// lineSeries2.Brush
			// 
			//this.lineSeries2.Brush.Color = System.Drawing.Color.Green;
			this.lineSeries2.CustomVertAxis = this.axis1;
			this.lineSeries2.DataSource = this.lineSeries1;
			this.lineSeries2.Function = this.momentumDivision1;
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
			this.lineSeries2.Title = "lineSeries2";
			this.lineSeries2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// lineSeries2.XValues
			// 
			this.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// axis1
			// 
			this.axis1.Horizontal = false;
			this.axis1.LogarithmicBase = 2;
			this.axis1.OtherSide = false;
			this.axis1.StartPosition = 90;
			this.axis1.TickOnLabelsOnly = false;
			// 
			// axis1.Title
			// 
			this.axis1.Title.Angle = 90;
			this.axis1.Title.Caption = "Mom. div.";
			this.axis1.Title.Lines = new string[] {
																							"Mom. div."};
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Period:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(64, 8);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 10,
																																 0,
																																 0,
																																 0});
			this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_TextChanged);
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(160, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(117, 20);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "&Show momentum";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// colorLine1
			// 
			this.colorLine1.Axis = this.tChart1.Axes.Left;
			// 
			// Function_MomentumDiv
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(425, 270);
			this.Name = "Function_MomentumDiv";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			// show / hide the momentum series
			this.lineSeries2.Active = this.checkBox1.Checked;

			 // re-position the axis
			if (this.lineSeries2.Active) this.tChart1.Axes.Left.EndPosition = 80;
            else this.tChart1.Axes.Left.EndPosition = 100;

			// show / hide the custom right axis
			this.tChart1.Axes.Custom[0].Visible = this.lineSeries2.Active;
			// show / hide the blue color line
			this.colorLine1.Active = this.lineSeries2.Active;
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.momentumDivision1.Period = (int)this.numericUpDown1.Value;
		}

		private void numericUpDown1_TextChanged(object sender, System.EventArgs e)
		{
			this.momentumDivision1.Period = (int)this.numericUpDown1.Value;
		}
	}
}

