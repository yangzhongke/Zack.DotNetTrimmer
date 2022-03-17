using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Candle_GetPointerStyle : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Candle candleSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Candle_GetPointerStyle()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			candleSeries1.FillSampleValues(20);
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
			this.candleSeries1 = new Steema.TeeChart.Styles.Candle();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(425, 32);
			this.textBox1.Text = "Candle series provide an event to customize point styles.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(425, 32);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			//
			//
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Candle series - OnGetPointerStyle event example"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.Transparency = 80;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.Transparency = 80;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Location = new System.Drawing.Point(0, 64);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.candleSeries1);
			this.tChart1.Size = new System.Drawing.Size(425, 206);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// candleSeries1
			// 
			// 
			// candleSeries1.Brush
			// 
			this.candleSeries1.Brush.Color = System.Drawing.Color.Red;
			this.candleSeries1.CloseValues = this.candleSeries1.YValues;
			this.candleSeries1.DateValues = this.candleSeries1.XValues;
			// 
			// candleSeries1.Marks
			// 
			// 
			// candleSeries1.Marks.Symbol
			// 
			// 
			// candleSeries1.Marks.Symbol.Shadow
			// 
			this.candleSeries1.Marks.Symbol.Shadow.Height = 1;
			this.candleSeries1.Marks.Symbol.Shadow.Visible = true;
			this.candleSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// candleSeries1.Pointer
			// 
			// 
			// candleSeries1.Pointer.Brush
			// 
			this.candleSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.candleSeries1.Pointer.Draw3D = false;
			this.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candleSeries1.Title = "candle1";
			// 
			// candleSeries1.XValues
			// 
			this.candleSeries1.XValues.DataMember = "Date";
			this.candleSeries1.XValues.DateTime = true;
			this.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// candleSeries1.YValues
			// 
			this.candleSeries1.YValues.DataMember = "Close";
			this.candleSeries1.GetPointerStyle += new Steema.TeeChart.Styles.CustomPoint.GetPointerStyleEventHandler(this.candleSeries1_GetPointerStyle);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(292, 19);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Use the event to change Candle border colors";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Candle_GetPointerStyle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(425, 270);
			this.Name = "Candle_GetPointerStyle";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			candleSeries1.Repaint();
		}

		private void candleSeries1_GetPointerStyle(Steema.TeeChart.Styles.CustomPoint series, Steema.TeeChart.Styles.GetPointerStyleEventArgs e)
		{
			if (checkBox1.Checked) // custom
			{
				// change some candle colors...
				if (e.ValueIndex % 2 == 0) 
				{
					e.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
					candleSeries1.Pointer.Pen.Color = Color.Yellow;
				}
				else
				{
					e.Style = Steema.TeeChart.Styles.PointerStyles.Diamond;
					candleSeries1.Pointer.Pen.Color = Color.Blue;
				}
			}
			else // default 
			{
				e.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
				candleSeries1.Pointer.Pen.Color = Color.Black;
			}		
		}
	}
}
