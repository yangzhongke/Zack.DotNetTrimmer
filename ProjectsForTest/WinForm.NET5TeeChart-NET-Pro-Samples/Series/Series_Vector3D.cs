using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Series_Vector3D : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.ButtonPen BPPen;
		private Steema.TeeChart.Styles.Vector3D vector3D1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Series_Vector3D()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		
		  vector3D1.FillSampleValues();
			
			
			BPPen.Pen = vector3D1.Pen;
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
			this.BPPen = new Steema.TeeChart.ButtonPen();
			this.vector3D1 = new Steema.TeeChart.Styles.Vector3D();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Vector 3D series draws points as simple lines in 3D space. \r\nEach series point de" +
				"termines start and end xyz values. \r\n\r\nvector3D1.Add(x0,y0,z0,x1,y1,z1 );";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BPPen);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 25;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 100;
			this.tChart1.Aspect.Rotation = 360;
			
			
			this.tChart1.Aspect.Zoom = 95;
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "3D Vectors"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.vector3D1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Right.Gradient
			// 
			this.tChart1.Walls.Right.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Right.Gradient
			// 
			this.tChart1.Walls.Right.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Right.Pen
			// 
			this.tChart1.Walls.Right.Pen.Visible = false;
			this.tChart1.Walls.Right.Size = 2;
			this.tChart1.Walls.Right.Visible = true;
			// 
			// BPPen
			// 
			this.BPPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BPPen.Location = new System.Drawing.Point(24, 8);
			this.BPPen.Name = "BPPen";
			this.BPPen.TabIndex = 0;
			this.BPPen.Text = "Pen";
			// 
			// vector3D1
			// 
			// 
			// vector3D1.Brush
			// 
			this.vector3D1.Brush.Color = System.Drawing.Color.Red;
			// 
			// vector3D1.EndXValues
			// 
			this.vector3D1.EndXValues.DataMember = "EndXValues";
			// 
			// vector3D1.EndYValues
			// 
			this.vector3D1.EndYValues.DataMember = "EndYValues";
			// 
			// vector3D1.EndZValues
			// 
			this.vector3D1.EndZValues.DataMember = "EndZValues";
			// 
			// vector3D1.Marks
			// 
			// 
			// vector3D1.Marks.Symbol
			// 
			// 
			// vector3D1.Marks.Symbol.Shadow
			// 
			this.vector3D1.Marks.Symbol.Shadow.Height = 1;
			this.vector3D1.Marks.Symbol.Shadow.Visible = true;
			this.vector3D1.Marks.Symbol.Shadow.Width = 1;
			this.vector3D1.PaletteMin = 0;
			this.vector3D1.PaletteStep = 0;
			this.vector3D1.Title = "vector3D1";
			// 
			// vector3D1.XValues
			// 
			this.vector3D1.XValues.DataMember = "X";
			// 
			// vector3D1.YValues
			// 
			this.vector3D1.YValues.DataMember = "Y";
			// 
			// vector3D1.ZValues
			// 
			this.vector3D1.ZValues.DataMember = "Z";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Vector3D
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "SeriesType_Vector3D";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}

