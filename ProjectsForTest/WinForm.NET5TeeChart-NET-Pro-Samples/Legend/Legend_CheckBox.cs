using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Legend_CheckBox : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Styles.Area areaSeries1;
		private Steema.TeeChart.Styles.Points pointSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Legend_CheckBox()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(6);
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.areaSeries1 = new Steema.TeeChart.Styles.Area();
			this.pointSeries1 = new Steema.TeeChart.Styles.Points();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Legend can show CheckBoxes, one for each active Series in the Chart. Clicking the" +
				" CheckBox shows / hides the Series.\r\n\r\nExample: tChart1.Legend.CheckBoxes = true" +
				" ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
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
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Length = 2;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Axes.Left.Ticks.Length = 2;
			this.tChart1.Axes.Left.Ticks.Style = Drawing.DashStyle.Dot;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Length = 2;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Length = 2;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.CheckBoxes = true;
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Location = new System.Drawing.Point(0, 96);
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Series.Add(this.areaSeries1);
			this.tChart1.Series.Add(this.pointSeries1);
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
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
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver;
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(204)));
			// 
			// lineSeries1.LinePen
			// 
			this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(153)), ((System.Byte)(122)));
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries1.Pointer
			// 
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "lineSeries1";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.DataMember = "X";
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries1.YValues
			// 
			this.lineSeries1.YValues.DataMember = "Y";
			// 
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(153)), ((System.Byte)(153)));
			// 
			// barSeries1.Gradient
			// 
			this.barSeries1.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(153)), ((System.Byte)(153)));
			// 
			// barSeries1.Gradient
			// 
			this.barSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(153)), ((System.Byte)(153)));
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
			this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(92)), ((System.Byte)(92)));
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
			// areaSeries1
			// 
			// 
			// areaSeries1.AreaBrush
			// 
			this.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(102)), ((System.Byte)(51)), ((System.Byte)(153)));
			// 
			// areaSeries1.AreaLines
			// 
			this.areaSeries1.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(61)), ((System.Byte)(31)), ((System.Byte)(92)));
			// 
			// areaSeries1.Brush
			// 
			this.areaSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(51)), ((System.Byte)(153)));
			// 
			// areaSeries1.LinePen
			// 
			this.areaSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(61)), ((System.Byte)(31)), ((System.Byte)(92)));
			// 
			// areaSeries1.Marks
			// 
			// 
			// areaSeries1.Marks.Symbol
			// 
			// 
			// areaSeries1.Marks.Symbol.Shadow
			// 
			this.areaSeries1.Marks.Symbol.Shadow.Height = 1;
			this.areaSeries1.Marks.Symbol.Shadow.Visible = true;
			this.areaSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// areaSeries1.Pointer
			// 
			this.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries1.Title = "areaSeries1";
			// 
			// areaSeries1.XValues
			// 
			this.areaSeries1.XValues.DataMember = "X";
			this.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// areaSeries1.YValues
			// 
			this.areaSeries1.YValues.DataMember = "Y";
			// 
			// pointSeries1
			// 
			// 
			// pointSeries1.LinePen
			// 
			this.pointSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(122)), ((System.Byte)(153)), ((System.Byte)(153)));
			// 
			// pointSeries1.Marks
			// 
			// 
			// pointSeries1.Marks.Symbol
			// 
			// 
			// pointSeries1.Marks.Symbol.Shadow
			// 
			this.pointSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries1.Pointer
			// 
			// 
			// pointSeries1.Pointer.Brush
			// 
			this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(204)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// pointSeries1.Pointer.Pen
			// 
			this.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(122)), ((System.Byte)(153)), ((System.Byte)(153)));
			this.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries1.Title = "pointSeries1";
			// 
			// pointSeries1.XValues
			// 
			this.pointSeries1.XValues.DataMember = "X";
			this.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries1.YValues
			// 
			this.pointSeries1.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(160, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Legend check boxes";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Legend_CheckBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Legend_CheckBox";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Legend.CheckBoxes = this.checkBox1.Checked;
		}
	}
}

