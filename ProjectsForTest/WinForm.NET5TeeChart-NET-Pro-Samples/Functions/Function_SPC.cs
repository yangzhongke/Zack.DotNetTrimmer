using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Function_SPC : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Tools.ColorLine colorLine1;
		private Steema.TeeChart.Tools.ColorLine colorLine2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.ComponentModel.IContainer components = null;

		private void CalcLimits(Steema.TeeChart.Styles.Series Good, Steema.TeeChart.Styles.Series Bad)
		{
			double sum,sumn, tmp, aux,
				lcp,lcn, numtotal, percent;
			int n;
			this.colorLine1.Value = 0.0;
			this.colorLine2.Value = 0.0;
			n = 0;
			sum = 0.0;
			sumn = 0.0;
			for (int i = 0;i<Good.Count;i++)
			{
				percent = (Bad.YValues[i]*Good.YValues[i]/100.0);
				numtotal = Good.YValues[i] + percent;
				if (numtotal>0)
				{
					sum += percent/numtotal;
					sumn += numtotal;
					n++;
				}
			}
			lcp = sum/n;
			lcn = sumn/n;
			tmp = (lcp*(1.0-lcp))/lcn;
			if (tmp>0)
			{
				aux = 3*Math.Sqrt(tmp); // <-- 3 by square root
				this.colorLine1.Value = 100.0*(lcp+aux);
				this.colorLine2.Value = 100.0*(lcp-aux);
			}

		}

		public Function_SPC()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			this.tChart1.Axes.Left.Title.Angle = 90;
			this.tChart1.Axes.Right.Title.Angle = 90;
			this.colorLine1.Pen.Width = 2;
			this.colorLine1.Pen.Color = Color.Green;
			this.colorLine2.Pen.Width = 2;
			this.colorLine2.Pen.Color = Color.Yellow;


			this.lineSeries1.Pointer.Visible = true;
			this.lineSeries2.Pointer.Visible = true;
			System.Random r = new System.Random();
			for (int i=1;i<19;i++)
			{
				this.lineSeries1.Add(800+r.Next(200)); // good
				this.lineSeries2.Add(4+r.Next(4)); // bad
			}
			
			CalcLimits(lineSeries1,lineSeries2);
			this.textBox2.Text = this.colorLine1.Value.ToString();			
			this.textBox3.Text = this.colorLine2.Value.ToString();			
		
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.lineSeries2 = new Steema.TeeChart.Styles.Line();
			this.colorLine1 = new Steema.TeeChart.Tools.ColorLine();
			this.colorLine2 = new Steema.TeeChart.Tools.ColorLine();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(425, 104);
			this.textBox1.Text = @"Calculating and charting the Upper and Lower limits of an SPC Quality Control series.
This example includes formulae to calculate the SPC upper and lower limits. The Chart displays 2 series, one with the number of ""good"" parts 
and another with the percent of ""bad"" parts. With these two Series, the example calculates two values: the upper and lower limits.
These limits are displayed using another two series. Correctness of calculation depends very much on your particular country rules.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 104);
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
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.Automatic = false;
			this.tChart1.Axes.Left.AutomaticMaximum = false;
			this.tChart1.Axes.Left.AutomaticMinimum = false;
			this.tChart1.Axes.Left.Maximum = 1200;
			this.tChart1.Axes.Left.Minimum = 0;
			// 
			// tChart1.Axes.Left.Title
			// 
			this.tChart1.Axes.Left.Title.Caption = "Production (number of pieces)";
			this.tChart1.Axes.Left.Title.Lines = new string[] {
																													"Production (number of pieces)"};
			// 
			// tChart1.Axes.Right
			// 
			this.tChart1.Axes.Right.Automatic = false;
			this.tChart1.Axes.Right.AutomaticMaximum = false;
			this.tChart1.Axes.Right.AutomaticMinimum = false;
			this.tChart1.Axes.Right.Maximum = 10;
			this.tChart1.Axes.Right.Minimum = 0;
			// 
			// tChart1.Axes.Right.Title
			// 
			this.tChart1.Axes.Right.Title.Caption = "SPC (%)";
			this.tChart1.Axes.Right.Title.Lines = new string[] {
																													 "SPC (%)"};
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Quality Control Chart"};
			this.tChart1.Location = new System.Drawing.Point(0, 141);
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
			this.tChart1.Size = new System.Drawing.Size(425, 129);
			this.tChart1.Tools.Add(this.colorLine1);
			this.tChart1.Tools.Add(this.colorLine2);
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
			this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.Red;
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
			this.lineSeries1.Title = "Good";
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
			// lineSeries2
			// 
			// 
			// lineSeries2.Brush
			// 
			this.lineSeries2.Brush.Color = System.Drawing.Color.Green;
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
			this.lineSeries2.Title = "Bad";
			this.lineSeries2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
			// 
			// lineSeries2.XValues
			// 
			this.lineSeries2.XValues.DataMember = "X";
			this.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries2.YValues
			// 
			this.lineSeries2.YValues.DataMember = "Y";
			// 
			// colorLine1
			// 
			this.colorLine1.Axis = this.tChart1.Axes.Right;
			this.colorLine1.DragLine += new System.EventHandler(this.colorLine1_DragLine);
			// 
			// colorLine2
			// 
			this.colorLine2.Axis = this.tChart1.Axes.Right;
			this.colorLine2.DragLine += new System.EventHandler(this.colorLine2_DragLine);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Upper limit";
			this.label1.UseMnemonic = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lower limit";
			this.label2.UseMnemonic = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(87, 11);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(48, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "0";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(232, 11);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(48, 20);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "0";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Function_SPC
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(425, 270);
			this.Name = "Function_SPC";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void colorLine1_DragLine(object sender, System.EventArgs e)
		{
			this.textBox2.Text = this.colorLine1.Value.ToString("#.00");
		}

		private void colorLine2_DragLine(object sender, System.EventArgs e)
		{
			this.textBox3.Text = this.colorLine2.Value.ToString("#.00");
		}

		private void tChart1_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}

