using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Axis_MultiScroll : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.FastLine fastLineSeries1;
		private Steema.TeeChart.Styles.FastLine fastLineSeries2;
		private Steema.TeeChart.Styles.Volume volumeSeries1;
		private Steema.TeeChart.Styles.Candle candleSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.ComponentModel.IContainer components = null;

		private Steema.TeeChart.Axis Green;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private Steema.TeeChart.Tools.GridBand gridBand2;
		private Steema.TeeChart.Axis Blue;

		public Axis_MultiScroll()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			
			tChart1.Series.Add(fastLineSeries1);
			tChart1.Series.Add(fastLineSeries2);
			tChart1.Series.Add(candleSeries1);
			tChart1.Series.Add(volumeSeries1);

			foreach (TeeChart.Styles.Series s in this.tChart1.Series)
				s.FillSampleValues(100);

			// change the Left axis properties
			Steema.TeeChart.Axis axis = this.tChart1.Axes.Left;
			
			axis.AxisPen.Color = Color.Red;
			axis.StartPosition = 0;
			axis.EndPosition = 32;
  
			// create custom axes. This can be done at design-time
			Green = new TeeChart.Axis(tChart1.Chart);
			this.tChart1.Axes.Custom.Add(Green);
			Green.AxisPen.Color = Color.Green;
			Green.StartPosition = 34;
			Green.EndPosition = 65;

            Blue = new TeeChart.Axis(tChart1.Chart);
			this.tChart1.Axes.Custom.Add(Blue);
			Blue.AxisPen.Color = Color.Blue;
			Blue.StartPosition = 67;   
			Blue.EndPosition = 100;
			
			// associate series
			this.fastLineSeries1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Left;
			this.fastLineSeries2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Left;
			this.candleSeries1.CustomVertAxis = Green;
			this.volumeSeries1.CustomVertAxis = Blue;

			tChart1.Tools.Add(gridBand1);
			tChart1.Tools.Add(gridBand2);

			gridBand1.Axis=tChart1.Axes.Left;
			gridBand2.Axis=Blue;
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
			this.fastLineSeries1 = new Steema.TeeChart.Styles.FastLine();
			this.fastLineSeries2 = new Steema.TeeChart.Styles.FastLine();
			this.volumeSeries1 = new Steema.TeeChart.Styles.Volume();
			this.candleSeries1 = new Steema.TeeChart.Styles.Candle();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.gridBand2 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(592, 73);
			this.textBox1.Text = "This chart contains 3 custom axes and several series associated to all axes.  The" +
				" example shows how to restrict scroll to some axes only. Most of the code can be" +
				" done visually at design-time.\r\n\r\nTry to scroll vertically using the right mouse" +
				" button.";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(592, 31);
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
														 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
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
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Size = new System.Drawing.Size(592, 264);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			this.tChart1.Scroll += new System.EventHandler(this.tChart1_Scroll);
			// 
			// fastLineSeries1
			// 
			this.fastLineSeries1.Cursor = Drawing.Cursors.Cross;
			// 
			// fastLineSeries1.LinePen
			// 
			this.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red;
			this.fastLineSeries1.Title = "fastLineSeries1";
			// 
			// fastLineSeries1.XValues
			// 
			this.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// fastLineSeries2
			// 
			this.fastLineSeries2.Cursor = Drawing.Cursors.Cross;
			// 
			// fastLineSeries2.LinePen
			// 
			this.fastLineSeries2.LinePen.Color = System.Drawing.Color.Green;
			this.fastLineSeries2.Title = "fastLineSeries2";
			// 
			// fastLineSeries2.XValues
			// 
			this.fastLineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// volumeSeries1
			// 
			// 
			// volumeSeries1.Brush
			// 
			this.volumeSeries1.Brush.Color = System.Drawing.Color.Blue;
			this.volumeSeries1.ClickableLine = false;
			this.volumeSeries1.Cursor = Drawing.Cursors.Cross;
			// 
			// volumeSeries1.LinePen
			// 
			this.volumeSeries1.LinePen.Color = System.Drawing.Color.Blue;
			// 
			// volumeSeries1.Pointer
			// 
			this.volumeSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.volumeSeries1.Title = "volumeSeries1";
			// 
			// volumeSeries1.XValues
			// 
			this.volumeSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// candleSeries1
			// 
			// 
			// candleSeries1.Brush
			// 
			this.candleSeries1.Brush.Color = System.Drawing.Color.Yellow;
			this.candleSeries1.CloseValues = this.candleSeries1.YValues;
			this.candleSeries1.Cursor = Drawing.Cursors.Cross;
			this.candleSeries1.DateValues = this.candleSeries1.XValues;
			// 
			// candleSeries1.Pointer
			// 
			this.candleSeries1.Pointer.Draw3D = false;
			this.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candleSeries1.Title = "candleSeries1";
			// 
			// candleSeries1.XValues
			// 
			this.candleSeries1.XValues.DateTime = true;
			this.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enable vertical scroll on axis :";
			this.label1.UseMnemonic = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(200, 2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(56, 24);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "&Red";
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(256, 2);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(56, 24);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "&Blue";
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(320, 2);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(64, 24);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "&Green";
			// 
			// gridBand1
			// 
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(211)), ((System.Byte)(211)), ((System.Byte)(211)));
			this.gridBand1.Band1.ForegroundColor = System.Drawing.Color.White;
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// gridBand2
			// 
			// 
			// gridBand2.Band1
			// 
			this.gridBand2.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(211)), ((System.Byte)(211)), ((System.Byte)(211)));
			this.gridBand2.Band1.ForegroundColor = System.Drawing.Color.White;
			// 
			// gridBand2.Band2
			// 
			this.gridBand2.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// Axis_MultiScroll
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 368);
			this.Name = "Axis_MultiScroll";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void tChart1_Scroll(object sender, System.EventArgs e)
		{
			double tmpMin, tmpMax;  
			if(!this.checkBox1.Checked)
			{
				tmpMin = Math.Min(this.fastLineSeries1.YValues.Minimum,this.fastLineSeries2.YValues.Minimum);
				tmpMax = Math.Max(this.fastLineSeries1.YValues.Maximum,this.fastLineSeries2.YValues.Maximum);
				this.tChart1.Axes.Left.SetMinMax(tmpMin,tmpMax);
			}

			if(!this.checkBox2.Checked)
			{
				Blue.SetMinMax(this.volumeSeries1.YValues.Minimum,this.volumeSeries1.YValues.Maximum);
			}
			if(!this.checkBox3.Checked)
			{
				Green.SetMinMax(this.candleSeries1.YValues.Minimum,this.candleSeries1.YValues.Maximum);
			}
		}
	}
}

