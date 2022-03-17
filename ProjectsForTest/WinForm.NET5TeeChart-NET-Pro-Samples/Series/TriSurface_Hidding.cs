using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class TriSurface_Hidding : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.TriSurface triSurfaceSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Tools.Rotate rotate1;
		private System.ComponentModel.IContainer components = null;

		public TriSurface_Hidding()
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriSurface_Hidding));
			this.triSurfaceSeries1 = new Steema.TeeChart.Styles.TriSurface();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(472, 96);
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 96);
			this.panel1.Size = new System.Drawing.Size(472, 32);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.Chart3DPercent = 75;
			this.tChart1.Aspect.Elevation = 340;
			this.tChart1.Aspect.ElevationFloat = 340;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 72;
			this.tChart1.Aspect.Rotation = 319;
			this.tChart1.Aspect.RotationFloat = 319;
			this.tChart1.Aspect.ZOffset = 0;
			this.tChart1.Aspect.Zoom = 75;
			this.tChart1.Aspect.ZoomFloat = 75;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Size = 7;
			this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 7F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Font.Size = 7;
			this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 7F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Size = 7;
			this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 7F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Font.Size = 7;
			this.tChart1.Axes.Left.Labels.Font.SizeFloat = 7F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Font.Size = 7;
			this.tChart1.Axes.Right.Labels.Font.SizeFloat = 7F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Font.Size = 7;
			this.tChart1.Axes.Top.Labels.Font.SizeFloat = 7F;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.tChart1.Header.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			this.tChart1.Header.Font.Size = 9;
			this.tChart1.Header.Font.SizeFloat = 9F;
			this.tChart1.Header.Lines = new string[] {
        "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.tChart1.Legend.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			this.tChart1.Legend.Font.Size = 7;
			this.tChart1.Legend.Font.SizeFloat = 7F;
			this.tChart1.Legend.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Raised;
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(140)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
			this.tChart1.Series.Add(this.triSurfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(472, 165);
			this.tChart1.Tools.Add(this.rotate1);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Left.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Right.Brush.Gradient.UseMiddle = true;
			this.tChart1.Walls.Visible = false;
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 128);
			this.chartContainer.Size = new System.Drawing.Size(472, 165);
			// 
			// triSurfaceSeries1
			// 
			// 
			// 
			// 
			this.triSurfaceSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.triSurfaceSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.triSurfaceSeries1.ColorEach = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.triSurfaceSeries1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.triSurfaceSeries1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.triSurfaceSeries1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.triSurfaceSeries1.Marks.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			this.triSurfaceSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.triSurfaceSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.triSurfaceSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.triSurfaceSeries1.Marks.Callout.Distance = 0;
			this.triSurfaceSeries1.Marks.Callout.Draw3D = false;
			this.triSurfaceSeries1.Marks.Callout.Length = 10;
			this.triSurfaceSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.triSurfaceSeries1.Marks.Callout.Visible = false;
			this.triSurfaceSeries1.PaletteMin = 0;
			this.triSurfaceSeries1.PaletteStep = 0;
			this.triSurfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
			this.triSurfaceSeries1.Title = "triSurfaceSeries1";
			// 
			// 
			// 
			this.triSurfaceSeries1.XValues.DataMember = "X";
			// 
			// 
			// 
			this.triSurfaceSeries1.YValues.DataMember = "Y";
			// 
			// 
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
			// TriSurface_Hidding
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 293);
			this.Name = "TriSurface_Hidding";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

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

