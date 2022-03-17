using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Series_PointAndFigure : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.PointFigure pointFigure1;
		private System.ComponentModel.IContainer components = null;

		public Series_PointAndFigure()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.pointFigure1.FillSampleValues(10);
			this.pointFigure1.BoxSize = 5;
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
			this.pointFigure1 = new Steema.TeeChart.Styles.PointFigure();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(630, 63);
			this.textBox1.Text = "Point & Figure series is a financial chart style. Point & Figure is made of X\'s a" +
				"nd O\'s symbols representing over time filtered price movements.";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(630, 34);
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
																								 "Point and figure chart"};
			this.tChart1.Location = new System.Drawing.Point(0, 97);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.pointFigure1);
			this.tChart1.Size = new System.Drawing.Size(630, 296);
			// 
			// pointFigure1
			// 
			// 
			// pointFigure1.Brush
			// 
			this.pointFigure1.Brush.Color = System.Drawing.Color.Red;
			this.pointFigure1.CloseValues = this.pointFigure1.YValues;
			this.pointFigure1.DateValues = this.pointFigure1.XValues;
			// 
			// pointFigure1.Marks
			// 
			// 
			// pointFigure1.Marks.Symbol
			// 
			// 
			// pointFigure1.Marks.Symbol.Shadow
			// 
			this.pointFigure1.Marks.Symbol.Shadow.Height = 1;
			this.pointFigure1.Marks.Symbol.Shadow.Visible = true;
			this.pointFigure1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointFigure1.Pointer
			// 
			// 
			// pointFigure1.Pointer.Brush
			// 
			this.pointFigure1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.pointFigure1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointFigure1.Title = "pointFigure1";
			// 
			// pointFigure1.XValues
			// 
			this.pointFigure1.XValues.DataMember = "Date";
			this.pointFigure1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointFigure1.YValues
			// 
			this.pointFigure1.YValues.DataMember = "Close";
			// 
			// Series_PointAndFigure
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(630, 393);
			this.Name = "Series_PointAndFigure";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

