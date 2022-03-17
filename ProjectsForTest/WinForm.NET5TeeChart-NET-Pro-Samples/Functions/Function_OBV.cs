using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Function_OBV : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Candle candle1;
		private Steema.TeeChart.Axis axis1;
		private Steema.TeeChart.Styles.Volume volume1;
		private Steema.TeeChart.Axis axis2;
		private Steema.TeeChart.Functions.OBVFunction obvFunction1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Axis axis3;
		private System.ComponentModel.IContainer components = null;

		public Function_OBV()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
      obvFunction1.Volume = volume1;
			candle1.FillSampleValues();
			volume1.FillSampleValues();
			obvFunction1.Recalculate();
			
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_OBV));
			this.candle1 = new Steema.TeeChart.Styles.Candle();
			this.axis1 = new Steema.TeeChart.Axis(this.components);
			this.volume1 = new Steema.TeeChart.Styles.Volume();
			this.axis2 = new Steema.TeeChart.Axis(this.components);
			this.obvFunction1 = new Steema.TeeChart.Functions.OBVFunction();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.axis3 = new Steema.TeeChart.Axis(this.components);
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = resources.GetString("textBox1.Text");
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
			this.tChart1.Axes.Bottom.MaximumOffset = 5;
			this.tChart1.Axes.Bottom.MinimumOffset = 5;
			this.tChart1.Axes.Custom.Add(this.axis1);
			this.tChart1.Axes.Custom.Add(this.axis2);
			this.tChart1.Axes.Custom.Add(this.axis3);
			this.tChart1.Cursor = Cursors.Default;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[0];
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Panel.MarginLeft = 8;
			this.tChart1.Series.Add(this.candle1);
			this.tChart1.Series.Add(this.volume1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// candle1
			// 
			// 
			// 
			// 
			this.candle1.Brush.Color = System.Drawing.Color.White;
			this.candle1.CloseValues = this.candle1.YValues;
			this.candle1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.candle1.ColorEach = false;
			this.candle1.CustomVertAxis = this.axis1;
			this.candle1.DateValues = this.candle1.XValues;
			// 
			// 
			// 
			this.candle1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.candle1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.candle1.Marks.Callout.Distance = 0;
			this.candle1.Marks.Callout.Draw3D = false;
			this.candle1.Marks.Callout.Length = 10;
			this.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.candle1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.candle1.Pointer.Draw3D = false;
			this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Title = "Candle";
			this.candle1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.candle1.XValues.DataMember = "Date";
			this.candle1.XValues.DateTime = true;
			this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.candle1.YValues.DataMember = "Close";
			// 
			// axis1
			// 
			this.axis1.EndPosition = 37;
			this.axis1.Horizontal = false;
			this.axis1.MaximumOffset = 5;
			this.axis1.MinimumOffset = 5;
			this.axis1.OtherSide = false;
			// 
			// volume1
			// 
			// 
			// 
			// 
			//this.volume1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.volume1.ClickableLine = false;
			this.volume1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.volume1.ColorEach = false;
			this.volume1.CustomVertAxis = this.axis2;
			// 
			// 
			// 
			this.volume1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.volume1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.volume1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.volume1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.volume1.Marks.Callout.Distance = 0;
			this.volume1.Marks.Callout.Draw3D = false;
			this.volume1.Marks.Callout.Length = 10;
			this.volume1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.volume1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.volume1.Pointer.Brush.Color = System.Drawing.Color.Green;
			this.volume1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.volume1.Title = "Volume";
			this.volume1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.volume1.XValues.DataMember = "X";
			this.volume1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.volume1.YValues.DataMember = "Y";
			// 
			// axis2
			// 
			this.axis2.EndPosition = 66;
			this.axis2.Horizontal = false;
			this.axis2.OtherSide = false;
			this.axis2.StartPosition = 40;
			// 
			// obvFunction1
			// 
			this.obvFunction1.Period = 1;
			this.obvFunction1.Volume = this.volume1;
			// 
			// line1
			// 
			// 
			// 
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			//this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			this.line1.ColorEach = false;
			this.line1.CustomVertAxis = this.axis3;
			this.line1.DataSource = this.candle1;
			this.line1.Function = this.obvFunction1;
			// 
			// 
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
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
			this.line1.Pointer.Brush.Color = System.Drawing.Color.Yellow;
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "OBV Function";
			this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.line1.XValues.DateTime = true;
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// axis3
			// 
			this.axis3.Horizontal = false;
			this.axis3.OtherSide = false;
			this.axis3.StartPosition = 68;
			// 
			// Function_OBV
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Function_OBV";
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}

