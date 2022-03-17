using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Function_Performance : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar bar1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Functions.Performance performance1;
		private System.ComponentModel.IContainer components = null;

		public Function_Performance()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bar1.FillSampleValues();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_Performance));
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.performance1 = new Steema.TeeChart.Functions.Performance();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "Performance function calculate the percentage of difference between each source p" +
					"oint and the first source point. \r\n\r\nCalculation starts always at zero.";
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Aspect.ZOffset = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.MaximumOffset = 38;
			this.tChart1.Axes.Bottom.MinimumOffset = 38;
			// 
			// 
			// 
			this.tChart1.Axes.Left.MaximumOffset = 37;
			this.tChart1.Axes.Left.MinimumOffset = 5;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "Performance function"};
			// 
			// 
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// bar1
			// 
			// 
			// 
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.bar1.ColorEach = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.bar1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.bar1.Marks.Callout.Distance = 0;
			this.bar1.Marks.Callout.Draw3D = false;
			this.bar1.Marks.Callout.Length = 20;
			this.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.bar1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			this.bar1.Title = "bar1";
			// 
			// 
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// line1
			// 
			// 
			// 
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.line1.ColorEach = false;
			this.line1.DataSource = this.bar1;
			this.line1.Function = this.performance1;
			// 
			// 
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.line1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.line1.Marks.Callout.Distance = 0;
			this.line1.Marks.Callout.Draw3D = false;
			this.line1.Marks.Callout.Length = 10;
			this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Pointer.Visible = true;
			this.line1.Title = "Performance";
			// 
			// 
			// 
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// performance1
			// 
			this.performance1.Period = 1;
			// 
			// Function_Performance
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Function_Performance";
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}

