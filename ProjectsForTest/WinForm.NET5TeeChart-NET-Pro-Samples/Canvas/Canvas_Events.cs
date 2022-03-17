using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Canvas_Events : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar bar1;
		private System.ComponentModel.IContainer components = null;
		private bool BeforeChart, BeforeAxes, BeforeSeries, AfterDraw;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.Windows.Forms.RadioButton radioButton4;

		public Canvas_Events()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bar1.FillSampleValues();
			BeforeChart=true;
			BeforeAxes=false;
			BeforeSeries=false;
			AfterDraw=false;
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
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "TeeChart\'s events can be used to draw Graphics objects onto the Chart at differen" +
				"t times of rendering.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
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
																								 "TeeChart Canvas Events"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.bar1);
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
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			this.tChart1.BeforeDrawAxes += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_BeforeDrawAxes);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			this.tChart1.BeforeDrawSeries += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_BeforeDrawSeries);
			this.tChart1.BeforeDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_BeforeDraw);
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.Red;
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(2, -3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(435, 41);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(328, 16);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(91, 17);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.Text = "After Chart";
			this.radioButton4.Click += new System.EventHandler(this.radioButtons_Click);
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(214, 16);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(91, 17);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "Before Series";
			this.radioButton3.Click += new System.EventHandler(this.radioButtons_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(111, 17);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(91, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Before Axes";
			this.radioButton2.Click += new System.EventHandler(this.radioButtons_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(8, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Before Chart";
			this.radioButton1.Click += new System.EventHandler(this.radioButtons_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Canvas_Events
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Canvas_Events";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void DrawShape() {
			tChart1.Graphics3D.Pen.Style = Drawing.DashStyle.Dot;
			tChart1.Graphics3D.Brush.Visible=true;
			tChart1.Graphics3D.Brush.Color = Color.Yellow;
			tChart1.Graphics3D.Ellipse(1,1,tChart1.Graphics3D.Chart.Width - 1, tChart1.Graphics3D.Chart.Height - 1);
		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g) {
			if(AfterDraw) DrawShape();
			BeforeChart=false;
			BeforeAxes=false;
			BeforeSeries=false;
			AfterDraw=false;
		}

		private void tChart1_BeforeDrawAxes(object sender, Steema.TeeChart.Drawing.IGraphics3D g) {
			if(BeforeAxes) DrawShape();
		}

		private void tChart1_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.IGraphics3D g) {
			if(BeforeSeries) DrawShape();
		}

		private void tChart1_BeforeDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g) {
			if(BeforeChart) DrawShape();
		}

		private void radioButtons_Click(object sender, System.EventArgs e) {
			string endsWith = ((RadioButton)sender).Name.Substring(11,1);
			switch (endsWith) {
				case "1":
					BeforeChart=true;
					break;
				case "2":
					BeforeAxes=true;
					break;
				case "3":
					BeforeSeries=true;
					break;
				case "4":
					AfterDraw=true;
					break;
			}
			tChart1.Invalidate();
		}
	}
}

