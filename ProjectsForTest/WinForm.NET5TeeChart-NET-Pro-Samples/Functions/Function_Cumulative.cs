using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Function_Cumulative : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Functions.Cumulative cumulative1;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.ComponentModel.IContainer components = null;

		public Function_Cumulative()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			this.barSeries1.Add(new int[10] {7,5,6,8,2,1,9,3,4,1});
			this.lineSeries1.CheckDataSource();

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_Cumulative));
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.cumulative1 = new Steema.TeeChart.Functions.Cumulative();
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(388, 55);
			this.textBox1.Text = "The Cumulative function calculates the incremental sum of the data source point v" +
					"alues.\r\n\r\nExample: Source is 7,5,6  - Cumulative is 7, 7+5, 7+5+6  (7,12 and 18)" +
					"";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 55);
			this.panel1.Size = new System.Drawing.Size(388, 25);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.ZOffset = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.MaximumOffset = 18;
			this.tChart1.Axes.Bottom.MinimumOffset = 18;
			// 
			// 
			// 
			this.tChart1.Axes.Left.MaximumOffset = 37;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "Cumulative function"};
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(388, 175);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Visible = false;
			this.tChart1.Walls.Back.Transparent = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 80);
			this.chartContainer.Size = new System.Drawing.Size(388, 175);
			// 
			// barSeries1
			// 
			// 
			// 
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.barSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.barSeries1.ColorEach = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.barSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.barSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.barSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.barSeries1.Marks.Callout.Distance = 0;
			this.barSeries1.Marks.Callout.Draw3D = false;
			this.barSeries1.Marks.Callout.Length = 20;
			this.barSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.barSeries1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			this.barSeries1.Title = "Source";
			// 
			// 
			// 
			this.barSeries1.XValues.DataMember = "X";
			this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.barSeries1.YValues.DataMember = "Bar";
			// 
			// cumulative1
			// 
			this.cumulative1.Period = 1;
			// 
			// lineSeries1
			// 
			// 
			// 
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.lineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.lineSeries1.ColorEach = false;
			this.lineSeries1.DataSource = this.barSeries1;
			this.lineSeries1.Function = this.cumulative1;
			// 
			// 
			// 
			this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.lineSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			// 
			// 
			// 
			this.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.lineSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.lineSeries1.Marks.Callout.Distance = 0;
			this.lineSeries1.Marks.Callout.Draw3D = false;
			this.lineSeries1.Marks.Callout.Length = 10;
			this.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.lineSeries1.Marks.Font.Brush.Color = System.Drawing.Color.White;
			this.lineSeries1.Marks.Visible = true;
			// 
			// 
			// 
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "Cumulative";
			// 
			// 
			// 
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// Function_Cumulative
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(388, 255);
			this.Name = "Function_Cumulative";
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}

