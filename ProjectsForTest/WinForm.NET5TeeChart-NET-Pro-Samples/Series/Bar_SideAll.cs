using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Bar_SideAll : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Styles.Bar barSeries2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Bar_SideAll()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(5);
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
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 72);
			this.textBox1.Text = "Bar and Horiz.Bar series can now be aligned \"Side All\". This means all points of " +
				"each series are contiguous to the next one.\r\n\r\nExample: barSeries1.MultiBar = St" +
				"eema.TeeChart.Styles.MultiBars.SideAll;";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 9);
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Visible = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Bar series : SideAll stack type"};
			this.tChart1.Location = new System.Drawing.Point(0, 81);
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
			this.tChart1.Size = new System.Drawing.Size(466, 205);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.Visible = false;
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
			this.barSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.RectGradient;
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
			// 
			// barSeries1.Gradient
			// 
			this.barSeries1.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.barSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(250)), ((System.Byte)(228)), ((System.Byte)(83)));
			this.barSeries1.Brush.Gradient.Visible = true;
			// 
			// barSeries1.Gradient
			// 
			this.barSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.barSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(250)), ((System.Byte)(228)), ((System.Byte)(83)));
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
			this.barSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.SideAll;
			// 
			// barSeries1.Pen
			// 
			this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(206)), ((System.Byte)(186)), ((System.Byte)(0)));
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
			// barSeries2
			// 
			// 
			// barSeries2.Brush
			// 
			this.barSeries2.Brush.Color = System.Drawing.Color.Green;
			// 
			// barSeries2.Gradient
			// 
			this.barSeries2.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(39)), ((System.Byte)(73)));
			this.barSeries2.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(3)), ((System.Byte)(72)), ((System.Byte)(135)));
			this.barSeries2.Brush.Gradient.Visible = true;
			// 
			// barSeries2.Gradient
			// 
			this.barSeries2.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(39)), ((System.Byte)(73)));
			this.barSeries2.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(3)), ((System.Byte)(72)), ((System.Byte)(135)));
			this.barSeries2.Gradient.Visible = true;
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
			this.barSeries2.MultiBar = Steema.TeeChart.Styles.MultiBars.SideAll;
			// 
			// barSeries2.Pen
			// 
			this.barSeries2.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(72)), ((System.Byte)(72)), ((System.Byte)(255)));
			this.barSeries2.Title = "barSeries2";
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
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(50)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// Bar_SideAll
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Bar_SideAll";
			this.ResumeLayout(false);

		}
		#endregion

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
	}
}

