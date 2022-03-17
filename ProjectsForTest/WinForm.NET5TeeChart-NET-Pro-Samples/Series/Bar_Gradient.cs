using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Bar_Gradient : Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Bar_Gradient()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.FillSampleValues(6);
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
			this.button1 = new System.Windows.Forms.Button();
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 80);
			this.textBox1.Text = "Bar and Horiz.Bar series can display gradients, with \"middle\" color.\r\n\r\nExample: " +
				"\r\nbarSeries1.Gradient.MidColor = Color.Yellow ;\r\nbarSeries1.Gradient.StartColor " +
				"= Color.Gray ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
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
																								 "Bar series gradient"};
			this.tChart1.Location = new System.Drawing.Point(0, 121);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 165);
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
			this.tChart1.Walls.Bottom.Size = 4;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 4;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(13, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit gradient...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// barSeries1.Gradient
			// 
			this.barSeries1.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(138)), ((System.Byte)(138)), ((System.Byte)(0)));
			this.barSeries1.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(236)), ((System.Byte)(236)), ((System.Byte)(0)));
			this.barSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.barSeries1.Brush.Gradient.UseMiddle = true;
			this.barSeries1.Brush.Gradient.Visible = true;
			// 
			// barSeries1.Gradient
			// 
			this.barSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(138)), ((System.Byte)(138)), ((System.Byte)(0)));
			this.barSeries1.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(236)), ((System.Byte)(236)), ((System.Byte)(0)));
			this.barSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.barSeries1.Gradient.UseMiddle = true;
			this.barSeries1.Gradient.Visible = true;
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
			// 
			// barSeries1.Pen
			// 
			this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(0)));
			this.barSeries1.Title = "barSeries1";
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
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Bar_Gradient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Bar_Gradient";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Editors.GradientEditor gradientEditor=new Steema.TeeChart.Editors.GradientEditor(this.barSeries1.Brush.Gradient);
			gradientEditor.ShowDialog();
		}
	}
}

