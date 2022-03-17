using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Shape : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Shape shapeSeries1;
		private Steema.TeeChart.Styles.Shape shapeSeries2;
		private Steema.TeeChart.Styles.Shape shapeSeries3;
		private Steema.TeeChart.Styles.Shape shapeSeries4;
    private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Shape()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			this.shapeSeries2.Color = Color.Orange;

			this.shapeSeries1.FillSampleValues();
			this.shapeSeries2.FillSampleValues();
			this.shapeSeries3.FillSampleValues();
			this.shapeSeries4.FillSampleValues();
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.shapeSeries1 = new Steema.TeeChart.Styles.Shape();
			this.shapeSeries2 = new Steema.TeeChart.Styles.Shape();
			this.shapeSeries3 = new Steema.TeeChart.Styles.Shape();
			this.shapeSeries4 = new Steema.TeeChart.Styles.Shape();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(511, 64);
			this.textBox1.Text = "The Shape series allows displaying text on any Chart position with optional text," +
				" style and visual attributes.\r\nClick on a shape to edit its properties.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(511, 40);
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
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Visible = false;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Header.Brush.Gradient.Visible = true;
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			this.tChart1.Header.Font.Size = 7;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			this.tChart1.Header.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Header.Gradient.Visible = true;
			this.tChart1.Header.Lines = new string[] {
																								 "Different Shape Styles"};
			// 
			// tChart1.Header.Pen
			// 
			this.tChart1.Header.Pen.Style = Drawing.DashStyle.Dot;
			this.tChart1.Header.Pen.Width = 2;
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.shapeSeries1);
			this.tChart1.Series.Add(this.shapeSeries2);
			this.tChart1.Series.Add(this.shapeSeries3);
			this.tChart1.Series.Add(this.shapeSeries4);
			this.tChart1.Size = new System.Drawing.Size(511, 208);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 80;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 80;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(15, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(87, 23);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Transparent";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// shapeSeries1
			// 
			// 
			// shapeSeries1.Brush
			// 
			// 
			// shapeSeries1.Gradient
			// 
			this.shapeSeries1.Brush.Gradient.Direction = Drawing.LinearGradientMode.BackwardDiagonal;
			this.shapeSeries1.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.shapeSeries1.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.shapeSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.shapeSeries1.Brush.Gradient.UseMiddle = true;
			this.shapeSeries1.Brush.Gradient.Visible = true;
			// 
			// shapeSeries1.Gradient
			// 
			this.shapeSeries1.Gradient.Direction = Drawing.LinearGradientMode.BackwardDiagonal;
			this.shapeSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.shapeSeries1.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.shapeSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.shapeSeries1.Gradient.UseMiddle = true;
			this.shapeSeries1.Gradient.Visible = true;
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
			this.shapeSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.shapeSeries1.Style = Steema.TeeChart.Styles.ShapeStyles.Circle;
			this.shapeSeries1.Text = new string[] {
																							"This is an ellipse."};
			this.shapeSeries1.Title = "shapeSeries1";
			this.shapeSeries1.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Center;
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
			this.shapeSeries2.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(77)), ((System.Byte)(0)));
			this.shapeSeries2.Pen.Width = 2;
			this.shapeSeries2.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle;
			this.shapeSeries2.Text = new string[] {
																							"This is a round ",
																							"rectangle."};
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
			// shapeSeries3.Font
			// 
			this.shapeSeries3.Font.Bold = true;
			// 
			// shapeSeries3.Font.Brush
			// 
			this.shapeSeries3.Font.Brush.Color = System.Drawing.Color.Green;
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
			this.shapeSeries3.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(153)), ((System.Byte)(0)));
			this.shapeSeries3.Style = Steema.TeeChart.Styles.ShapeStyles.InvertTriangle;
			this.shapeSeries3.Text = new string[] {
																							"A triangle shape."};
			this.shapeSeries3.Title = "shapeSeries3";
			this.shapeSeries3.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Center;
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
			// shapeSeries4
			// 
			this.shapeSeries4.HorizAlignment = Steema.TeeChart.Styles.ShapeTextHorizAlign.Center;
			// 
			// shapeSeries4.Marks
			// 
			// 
			// shapeSeries4.Marks.Symbol
			// 
			// 
			// shapeSeries4.Marks.Symbol.Shadow
			// 
			this.shapeSeries4.Marks.Symbol.Shadow.Height = 1;
			this.shapeSeries4.Marks.Symbol.Shadow.Visible = true;
			this.shapeSeries4.Marks.Symbol.Shadow.Width = 1;
			// 
			// shapeSeries4.Pen
			// 
			this.shapeSeries4.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(153)));
			this.shapeSeries4.Style = Steema.TeeChart.Styles.ShapeStyles.Diamond;
			this.shapeSeries4.Text = new string[] {
																							"Diamond shape"};
			this.shapeSeries4.Title = "shapeSeries4";
			this.shapeSeries4.VertAlignment = Steema.TeeChart.Styles.ShapeTextVertAlign.Center;
			// 
			// shapeSeries4.XValues
			// 
			this.shapeSeries4.XValues.DataMember = "X";
			this.shapeSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			this.shapeSeries4.XYStyle = Steema.TeeChart.Styles.ShapeXYStyles.Axis;
			// 
			// shapeSeries4.YValues
			// 
			this.shapeSeries4.YValues.DataMember = "Y";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(136, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SeriesType_Shape
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(511, 312);
			this.Name = "SeriesType_Shape";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				if (s is Steema.TeeChart.Styles.Shape)
					((Steema.TeeChart.Styles.Shape)s).Transparent=checkBox1.Checked;
		}

    private void button1_Click(object sender, System.EventArgs e)
    {
      Steema.TeeChart.Editors.SeriesEditor.ShowModal(tChart1[0]);
    }
	}
}

