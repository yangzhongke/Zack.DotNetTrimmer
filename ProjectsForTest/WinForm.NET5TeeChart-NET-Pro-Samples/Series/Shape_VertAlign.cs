using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Shape_VertAlign : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Shape shapeSeries1;
		private Steema.TeeChart.Styles.Shape shapeSeries2;
		private Steema.TeeChart.Styles.Shape shapeSeries3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.ComponentModel.IContainer components = null;


		public Shape_VertAlign()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
	
			this.shapeSeries1.FillSampleValues();
			this.shapeSeries2.FillSampleValues();
			this.shapeSeries3.FillSampleValues();
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
			this.shapeSeries1 = new Steema.TeeChart.Styles.Shape();
			this.shapeSeries2 = new Steema.TeeChart.Styles.Shape();
			this.shapeSeries3 = new Steema.TeeChart.Styles.Shape();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(440, 56);
			this.textBox1.Text = "Shape text canbe top, center or bottom aligned.\r\n\r\nExample: shape1.VertAlignment " +
				"= Styles.ShapeTextVertAlign.Bottom;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 60);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			this.tChart1.Axes.Bottom.Automatic = false;
			this.tChart1.Axes.Bottom.AutomaticMaximum = false;
			this.tChart1.Axes.Bottom.AutomaticMinimum = false;
			this.tChart1.Axes.Bottom.Maximum = 100;
			this.tChart1.Axes.Bottom.Minimum = 0;
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.Automatic = false;
			this.tChart1.Axes.Left.AutomaticMaximum = false;
			this.tChart1.Axes.Left.AutomaticMinimum = false;
			this.tChart1.Axes.Left.LogarithmicBase = 2;
			this.tChart1.Axes.Left.Maximum = 115;
			this.tChart1.Axes.Left.Minimum = 0;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 116);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Series.Add(this.shapeSeries1);
			this.tChart1.Series.Add(this.shapeSeries2);
			this.tChart1.Series.Add(this.shapeSeries3);
			this.tChart1.Size = new System.Drawing.Size(440, 273);
			// 
			// shapeSeries1
			// 
			// 
			// shapeSeries1.Brush
			// 
			this.shapeSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.shapeSeries1.Brush.Solid = false;
			this.shapeSeries1.Brush.Style = Drawing.HatchStyle.HorizontalBrick;
			this.shapeSeries1.Cursor = Drawing.Cursors.Cross;
			// 
			// shapeSeries1.Font
			// 
			this.shapeSeries1.Font.Bold = true;
			this.shapeSeries1.Font.Size = 10;
			this.shapeSeries1.HorizAlignment = Steema.TeeChart.Styles.ShapeTextHorizAlign.Center;
			// 
			// shapeSeries1.Marks
			// 
			// 
			// shapeSeries1.Marks.Symbol
			// 
			// 
			// shapeSeries1.Marks.Symbol.Shadow
			// 
			this.shapeSeries1.Marks.Symbol.Shadow.Height = 1;
			this.shapeSeries1.Marks.Symbol.Shadow.Visible = true;
			this.shapeSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// shapeSeries1.Pen
			// 
			this.shapeSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(153)), ((System.Byte)(122)));
			this.shapeSeries1.Pen.Style = Drawing.DashStyle.Dot;
			this.shapeSeries1.Pen.Width = 2;
			this.shapeSeries1.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle;
			this.shapeSeries1.Text = new string[] {
																							"Text at bottom"};
			this.shapeSeries1.Title = "shapeSeries1";
			this.shapeSeries1.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Bottom;
			// 
			// shapeSeries1.XValues
			// 
			this.shapeSeries1.XValues.DataMember = "X";
			this.shapeSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			this.shapeSeries1.XYStyle = Steema.TeeChart.Styles.ShapeXYStyles.Axis;
			// 
			// shapeSeries1.YValues
			// 
			this.shapeSeries1.YValues.DataMember = "Y";
			// 
			// shapeSeries2
			// 
			this.shapeSeries2.Cursor = Drawing.Cursors.Cross;
			// 
			// shapeSeries2.Font
			// 
			this.shapeSeries2.Font.Bold = true;
			this.shapeSeries2.Font.Italic = true;
			this.shapeSeries2.Font.Size = 12;
			this.shapeSeries2.HorizAlignment = Steema.TeeChart.Styles.ShapeTextHorizAlign.Center;
			// 
			// shapeSeries2.Marks
			// 
			// 
			// shapeSeries2.Marks.Symbol
			// 
			// 
			// shapeSeries2.Marks.Symbol.Shadow
			// 
			this.shapeSeries2.Marks.Symbol.Shadow.Height = 1;
			this.shapeSeries2.Marks.Symbol.Shadow.Visible = true;
			this.shapeSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// shapeSeries2.Pen
			// 
			this.shapeSeries2.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(122)), ((System.Byte)(153)), ((System.Byte)(153)));
			this.shapeSeries2.Pen.Style = Drawing.DashStyle.Dash;
			this.shapeSeries2.Pen.Width = 2;
			this.shapeSeries2.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle;
			this.shapeSeries2.Text = new string[] {
																							"Text at center"};
			this.shapeSeries2.Title = "shapeSeries2";
			this.shapeSeries2.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Center;
			// 
			// shapeSeries2.XValues
			// 
			this.shapeSeries2.XValues.DataMember = "X";
			this.shapeSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			this.shapeSeries2.XYStyle = Steema.TeeChart.Styles.ShapeXYStyles.Axis;
			// 
			// shapeSeries2.YValues
			// 
			this.shapeSeries2.YValues.DataMember = "Y";
			// 
			// shapeSeries3
			// 
			// 
			// shapeSeries3.Brush
			// 
			this.shapeSeries3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			this.shapeSeries3.Brush.ForegroundColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.shapeSeries3.Brush.Solid = false;
			this.shapeSeries3.Cursor = Drawing.Cursors.Cross;
			// 
			// shapeSeries3.Font
			// 
			this.shapeSeries3.Font.Bold = true;
			this.shapeSeries3.Font.Size = 12;
			this.shapeSeries3.HorizAlignment = Steema.TeeChart.Styles.ShapeTextHorizAlign.Center;
			// 
			// shapeSeries3.Marks
			// 
			// 
			// shapeSeries3.Marks.Symbol
			// 
			// 
			// shapeSeries3.Marks.Symbol.Shadow
			// 
			this.shapeSeries3.Marks.Symbol.Shadow.Height = 1;
			this.shapeSeries3.Marks.Symbol.Shadow.Visible = true;
			this.shapeSeries3.Marks.Symbol.Shadow.Width = 1;
			// 
			// shapeSeries3.Pen
			// 
			this.shapeSeries3.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(122)), ((System.Byte)(122)));
			this.shapeSeries3.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle;
			this.shapeSeries3.Text = new string[] {
																							"Text at top"};
			this.shapeSeries3.Title = "shapeSeries3";
			this.shapeSeries3.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Top;
			// 
			// shapeSeries3.XValues
			// 
			this.shapeSeries3.XValues.DataMember = "X";
			this.shapeSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			this.shapeSeries3.XYStyle = Steema.TeeChart.Styles.ShapeXYStyles.Axis;
			// 
			// shapeSeries3.YValues
			// 
			this.shapeSeries3.YValues.DataMember = "Y";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(7, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(273, 41);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vertical align:";
			// 
			// radioButton3
			// 
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Location = new System.Drawing.Point(176, 16);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(80, 16);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "&Bottom";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Location = new System.Drawing.Point(88, 16);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(79, 16);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "&Center";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Location = new System.Drawing.Point(20, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(67, 16);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "&Top";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// Shape_VertAlign
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 389);
			this.Name = "Shape_VertAlign";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.radioButton1.Checked)
				foreach (TeeChart.Styles.Shape s in tChart1.Series)
				{
					s.VertAlignment = Styles.ShapeTextVertAlign.Top;
					s.Text[0] = "Text at Top";
				}
			else if (this.radioButton2.Checked)
				foreach (TeeChart.Styles.Shape s in tChart1.Series)
				{
					s.VertAlignment = Styles.ShapeTextVertAlign.Center;
					s.Text[0] = "Text at Center";
				}
			else foreach (TeeChart.Styles.Shape s in tChart1.Series)
				{
					s.VertAlignment = Styles.ShapeTextVertAlign.Bottom;
					s.Text[0] = "Text at Bottom";
				}
		}
	}
}

