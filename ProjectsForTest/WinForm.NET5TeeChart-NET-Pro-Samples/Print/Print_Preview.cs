using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Print_Preview : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar bar1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Print_Preview()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bar1.FillSampleValues(6);
			bar1.ColorEach = true;
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
			this.button1 = new System.Windows.Forms.Button();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(630, 63);
			this.textBox1.Text = "The Print Preview dialog displays a tChart over a printer paper and allows custom" +
				"ization of printing parameters like choosing the printer and printer settings, c" +
				"hanging margins and chart position, paper orientation and detail resolution.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(630, 41);
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
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Size = new System.Drawing.Size(630, 289);
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
			// 
			// bar1
			// 
			this.bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder;
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
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Print Preview...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// PreviewDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(630, 393);
			this.Name = "PreviewDialog";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
      tChart1.Printer.Preview();
		}
	}
}

