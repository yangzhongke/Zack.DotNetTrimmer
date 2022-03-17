using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class BarJoin_Series : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.BarJoin barJoinSeries1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public BarJoin_Series()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barJoinSeries1.FillSampleValues(4);
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
			this.barJoinSeries1 = new Steema.TeeChart.Styles.BarJoin();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Bar Join series draws a line between each bar point, at the top position. \r\nThe J" +
				"oinPen property controls the pen used to draw the lines.";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 34);
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
			this.tChart1.Header.Alignment = Drawing.StringAlignment.Near;
			this.tChart1.Header.Lines = new string[] {
																								 "BarJoin series"};
			this.tChart1.Location = new System.Drawing.Point(0, 97);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barJoinSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// barJoinSeries1
			// 
			// 
			// barJoinSeries1.Brush
			// 
			this.barJoinSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// barJoinSeries1.Marks
			// 
			// 
			// barJoinSeries1.Marks.Symbol
			// 
			// 
			// barJoinSeries1.Marks.Symbol.Shadow
			// 
			this.barJoinSeries1.Marks.Symbol.Shadow.Height = 1;
			this.barJoinSeries1.Marks.Symbol.Shadow.Visible = true;
			this.barJoinSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// barJoinSeries1.Pen
			// 
			this.barJoinSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.barJoinSeries1.Title = "barJoin1";
			// 
			// barJoinSeries1.XValues
			// 
			this.barJoinSeries1.XValues.DataMember = "X";
			this.barJoinSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barJoinSeries1.YValues
			// 
			this.barJoinSeries1.YValues.DataMember = "Bar";
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
			// SeriesType_BarJoin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_BarJoin";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

