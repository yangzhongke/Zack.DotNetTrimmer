using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class WaterFall_Series : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Waterfall waterfallSeries1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public WaterFall_Series()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.waterfallSeries1.FillSampleValues(20);
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
			this.waterfallSeries1 = new Steema.TeeChart.Styles.Waterfall();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "WaterFall series is like a Surface series. It draws vertical \"slices\", one for ea" +
				"ch Z row in the surface.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 34);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 50;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 58;
			this.tChart1.Aspect.Rotation = 330;
			
			
			this.tChart1.Aspect.Zoom = 85;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 97);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.waterfallSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// waterfallSeries1
			// 
			// 
			// waterfallSeries1.Brush
			// 
			this.waterfallSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// waterfallSeries1.Marks
			// 
			// 
			// waterfallSeries1.Marks.Symbol
			// 
			// 
			// waterfallSeries1.Marks.Symbol.Shadow
			// 
			this.waterfallSeries1.Marks.Symbol.Shadow.Height = 1;
			this.waterfallSeries1.Marks.Symbol.Shadow.Visible = true;
			this.waterfallSeries1.Marks.Symbol.Shadow.Width = 1;
			this.waterfallSeries1.NumXValues = 25;
			this.waterfallSeries1.NumZValues = 25;
			this.waterfallSeries1.PaletteMin = 0;
			this.waterfallSeries1.PaletteStep = 0;
			this.waterfallSeries1.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.waterfallSeries1.Title = "waterfallSeries1";
			this.waterfallSeries1.WaterFall = true;
			// 
			// waterfallSeries1.XValues
			// 
			this.waterfallSeries1.XValues.DataMember = "X";
			// 
			// waterfallSeries1.YValues
			// 
			this.waterfallSeries1.YValues.DataMember = "Y";
			// 
			// waterfallSeries1.ZValues
			// 
			this.waterfallSeries1.ZValues.DataMember = "Z";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(20, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SeriesType_WaterFall
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_WaterFall";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.waterfallSeries1);
		}
	}
}

