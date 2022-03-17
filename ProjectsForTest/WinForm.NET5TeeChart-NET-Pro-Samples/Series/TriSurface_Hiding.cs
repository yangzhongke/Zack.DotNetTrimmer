using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class TriSurface_Hiding : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.TriSurface triSurfaceSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Tools.Rotate rotate1;
		private System.ComponentModel.IContainer components = null;

		public TriSurface_Hiding()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			// fill sample data
			this.triSurfaceSeries1.Clear();
			double n = 0.5;
			int m = 10;
			for (int x=-m; x<m; x++)
				for (int z =-m; z<m; z++)
					this.triSurfaceSeries1.Add(
						x,
						4*Math.Cos(3*Math.Sqrt(x*x/9)+ z*z/9)*Math.Exp(-n*Math.Sqrt(x*x/9+z*z/9)),
						z);

			// setup series properties
			this.triSurfaceSeries1.Pen.Visible = false;
			this.triSurfaceSeries1.HideTriangles = true;
			this.triSurfaceSeries1.CacheTriangles = false;
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
			this.triSurfaceSeries1 = new Steema.TeeChart.Styles.TriSurface();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(472, 96);
			this.textBox1.Text = @"Tri-Surface boolean properties:

triSurfaceSeries.HideTriangles ( default true )
Constructed triangles behind other triangles are hidden before displaying them.

triSurfaceSeries.CacheTriangles ( default false )
When true, Triangles are preserved on consecutive displays (ie: rotating or zooming) (this gives much better speed when repainting the series without modifying values)";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(472, 32);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 75;
			this.tChart1.Aspect.Elevation = 340;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 72;
			this.tChart1.Aspect.Rotation = 319;
			
			
			this.tChart1.Aspect.Zoom = 75;
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
			this.tChart1.Location = new System.Drawing.Point(0, 128);
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.triSurfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(472, 165);
			this.tChart1.Tools.Add(this.rotate1);
			// 
			// tChart1.Walls
			// 
			this.tChart1.Walls.Visible = false;
			// 
			// triSurfaceSeries1
			// 
			// 
			// triSurfaceSeries1.Brush
			// 
			this.triSurfaceSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// triSurfaceSeries1.Marks
			// 
			// 
			// triSurfaceSeries1.Marks.Symbol
			// 
			// 
			// triSurfaceSeries1.Marks.Symbol.Shadow
			// 
			this.triSurfaceSeries1.Marks.Symbol.Shadow.Height = 1;
			this.triSurfaceSeries1.Marks.Symbol.Shadow.Visible = true;
			this.triSurfaceSeries1.Marks.Symbol.Shadow.Width = 1;
			this.triSurfaceSeries1.PaletteMin = 0;
			this.triSurfaceSeries1.PaletteStep = 0;
			this.triSurfaceSeries1.Title = "triSurfaceSeries1";
			// 
			// triSurfaceSeries1.XValues
			// 
			this.triSurfaceSeries1.XValues.DataMember = "X";
			// 
			// triSurfaceSeries1.YValues
			// 
			this.triSurfaceSeries1.YValues.DataMember = "Y";
			// 
			// triSurfaceSeries1.ZValues
			// 
			this.triSurfaceSeries1.ZValues.DataMember = "Z";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(107, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Hide triangles";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(145, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(116, 17);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Cache triangles";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// TriSurface_Hiding
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 293);
			this.Name = "TriSurface_Hiding";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.triSurfaceSeries1.HideTriangles = this.checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.triSurfaceSeries1.CacheTriangles = this.checkBox2.Checked;
		}
	}
}

