using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Shape_Image : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Shape shapeSeries1;
		private Steema.TeeChart.Styles.Shape shapeSeries2;
		private System.ComponentModel.IContainer components = null;

		public Shape_Image()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.shapeSeries1.FillSampleValues();
			this.shapeSeries2.FillSampleValues();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Shape_Image));
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.shapeSeries1 = new Steema.TeeChart.Styles.Shape();
			this.shapeSeries2 = new Steema.TeeChart.Styles.Shape();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Shape series accept Images to fill the interior. The Brush.Image property is used" +
				"\r\nto set the image bitmap.\r\n\r\nExample: shapeSeries1.Brush.LoadImage(\"c:\\\\mybitma" +
				"p.bmp\");";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
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
																								 "tChart1"};
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
			this.tChart1.Size = new System.Drawing.Size(440, 237);
			// 
			// tChart1.Walls
			// 
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
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(152, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Transparent Shapes";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// shapeSeries1
			// 
			// 
			// shapeSeries1.Brush
			// 
			//this.shapeSeries1.Brush.Image = ((System.Drawing.Image)(resources.GetObject("shapeSeries1.Brush.Image")));
			this.shapeSeries1.Brush.Solid = false;
			this.shapeSeries1.Cursor = Drawing.Cursors.Cross;
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
			this.shapeSeries1.Pen.Width = 2;
			this.shapeSeries1.Style = Steema.TeeChart.Styles.ShapeStyles.Circle;
			this.shapeSeries1.Text = new string[0];
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
			// 
			// shapeSeries2.Brush
			// 
			//this.shapeSeries2.Brush.Image = ((System.Drawing.Image)(resources.GetObject("shapeSeries2.Brush.Image")));
			this.shapeSeries2.Brush.Solid = false;
			this.shapeSeries2.Cursor = Drawing.Cursors.Cross;
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
			this.shapeSeries2.Pen.Style = Drawing.DashStyle.Dash;
			this.shapeSeries2.Pen.Width = 2;
			this.shapeSeries2.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle;
			this.shapeSeries2.Text = new string[0];
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
			// Shape_Image
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 349);
			this.Name = "Shape_Image";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			foreach (TeeChart.Styles.Shape sh in this.tChart1.Series)
				sh.Transparent = this.checkBox1.Checked;
		}
	}
}

