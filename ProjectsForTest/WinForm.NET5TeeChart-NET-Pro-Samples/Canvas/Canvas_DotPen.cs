using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Canvas_DotPen : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.FastLine fastLineSeries1;
		private Steema.TeeChart.Styles.FastLine fastLineSeries2;
		private Steema.TeeChart.Styles.FastLine fastLineSeries3;
		private Steema.TeeChart.Styles.FastLine fastLineSeries4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.ComponentModel.IContainer components = null;

		public Canvas_DotPen()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(10);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Canvas_DotPen));
			this.fastLineSeries1 = new Steema.TeeChart.Styles.FastLine();
			this.fastLineSeries2 = new Steema.TeeChart.Styles.FastLine();
			this.fastLineSeries3 = new Steema.TeeChart.Styles.FastLine();
			this.fastLineSeries4 = new Steema.TeeChart.Styles.FastLine();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(466, 64);
			this.textBox1.Text = "Lines with dotted styles can draw widths bigger than 1. \r\n\r\nlineSeries1.LinePen.S" +
					"tyle = Drawing.DashStyle.Dot;\r\nlineSeries1.LinePen.Width = 3;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Size = new System.Drawing.Size(466, 33);
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
			this.tChart1.Header.Lines = new string[] {
        "tChart1"};
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.Series.Add(this.fastLineSeries1);
			this.tChart1.Series.Add(this.fastLineSeries2);
			this.tChart1.Series.Add(this.fastLineSeries3);
			this.tChart1.Series.Add(this.fastLineSeries4);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 97);
			this.chartContainer.Size = new System.Drawing.Size(466, 189);
			// 
			// fastLineSeries1
			// 
			this.fastLineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.fastLineSeries1.ColorEach = false;
			// 
			// 
			// 
			this.fastLineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.fastLineSeries1.LinePen.Style = Drawing.DashStyle.DashDot;
			this.fastLineSeries1.LinePen.Width = 2;
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLineSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLineSeries1.Marks.Callout.Distance = 0;
			this.fastLineSeries1.Marks.Callout.Draw3D = false;
			this.fastLineSeries1.Marks.Callout.Length = 10;
			this.fastLineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLineSeries1.Marks.Callout.Visible = false;
			this.fastLineSeries1.Title = "fastLineSeries1";
			this.fastLineSeries1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLineSeries1.XValues.DataMember = "X";
			this.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.fastLineSeries1.YValues.DataMember = "Y";
			// 
			// fastLineSeries2
			// 
			this.fastLineSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.fastLineSeries2.ColorEach = false;
			// 
			// 
			// 
			this.fastLineSeries2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.fastLineSeries2.LinePen.Style = Drawing.DashStyle.Dash;
			this.fastLineSeries2.LinePen.Width = 2;
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLineSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLineSeries2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLineSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLineSeries2.Marks.Callout.Distance = 0;
			this.fastLineSeries2.Marks.Callout.Draw3D = false;
			this.fastLineSeries2.Marks.Callout.Length = 10;
			this.fastLineSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLineSeries2.Marks.Callout.Visible = false;
			this.fastLineSeries2.Title = "fastLineSeries2";
			this.fastLineSeries2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLineSeries2.XValues.DataMember = "X";
			this.fastLineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.fastLineSeries2.YValues.DataMember = "Y";
			// 
			// fastLineSeries3
			// 
			this.fastLineSeries3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			this.fastLineSeries3.ColorEach = false;
			// 
			// 
			// 
			this.fastLineSeries3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			this.fastLineSeries3.LinePen.Style = Drawing.DashStyle.DashDotDot;
			this.fastLineSeries3.LinePen.Width = 2;
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLineSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLineSeries3.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLineSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLineSeries3.Marks.Callout.Distance = 0;
			this.fastLineSeries3.Marks.Callout.Draw3D = false;
			this.fastLineSeries3.Marks.Callout.Length = 10;
			this.fastLineSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLineSeries3.Marks.Callout.Visible = false;
			this.fastLineSeries3.Title = "fastLineSeries3";
			this.fastLineSeries3.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLineSeries3.XValues.DataMember = "X";
			this.fastLineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.fastLineSeries3.YValues.DataMember = "Y";
			// 
			// fastLineSeries4
			// 
			this.fastLineSeries4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
			this.fastLineSeries4.ColorEach = false;
			// 
			// 
			// 
			this.fastLineSeries4.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
			this.fastLineSeries4.LinePen.Style = Drawing.DashStyle.Dot;
			this.fastLineSeries4.LinePen.Width = 2;
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLineSeries4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLineSeries4.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLineSeries4.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLineSeries4.Marks.Callout.Distance = 0;
			this.fastLineSeries4.Marks.Callout.Draw3D = false;
			this.fastLineSeries4.Marks.Callout.Length = 10;
			this.fastLineSeries4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLineSeries4.Marks.Callout.Visible = false;
			this.fastLineSeries4.Title = "fastLineSeries4";
			this.fastLineSeries4.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLineSeries4.XValues.DataMember = "X";
			this.fastLineSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.fastLineSeries4.YValues.DataMember = "Y";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Pen width:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(72, 8);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// Canvas_DotPen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Canvas_DotPen";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			foreach (Steema.TeeChart.Styles.FastLine s in tChart1.Series)
				s.LinePen.Width = (int)this.numericUpDown1.Value;
		}
	}
}

