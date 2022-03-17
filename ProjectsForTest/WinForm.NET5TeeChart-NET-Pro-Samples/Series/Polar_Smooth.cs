using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Polar_Smooth : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Polar polar1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Polar polar2;
		private Steema.TeeChart.Functions.Smoothing smoothing1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.ComponentModel.IContainer components = null;

		public Polar_Smooth()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			polar1.FillSampleValues();
			polar2.Pointer.Visible=false;
			polar2.RefreshSeries();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polar_Smooth));
			this.polar1 = new Steema.TeeChart.Styles.Polar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.polar2 = new Steema.TeeChart.Styles.Polar();
			this.smoothing1 = new Steema.TeeChart.Functions.Smoothing();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "The smoothing function can be applied to Polar charts.\r\n";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Size = new System.Drawing.Size(440, 63);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.ElevationFloat = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			this.tChart1.Aspect.RotationFloat = 360;
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Aspect.ZOffset = 0;
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
        "Smooth Polar Chart"};
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
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(92)))));
			this.tChart1.Panel.ImageBevel.Visible = true;
			this.tChart1.Panel.ImageBevel.Width = 6;
			this.tChart1.Series.Add(this.polar2);
			this.tChart1.Series.Add(this.polar1);
			this.tChart1.Size = new System.Drawing.Size(440, 181);
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
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 136);
			this.chartContainer.Size = new System.Drawing.Size(440, 181);
			// 
			// polar1
			// 
			// 
			// 
			// 
			this.polar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.polar1.Brush.Visible = false;
			// 
			// 
			// 
			this.polar1.CircleGradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.polar1.CircleGradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.polar1.CircleGradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.polar1.CircleGradient.UseMiddle = true;
			this.polar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.polar1.ColorEach = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.polar1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.polar1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.polar1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.polar1.Marks.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			this.polar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.polar1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.polar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.polar1.Marks.Callout.Distance = 0;
			this.polar1.Marks.Callout.Draw3D = false;
			this.polar1.Marks.Callout.Length = 10;
			this.polar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polar1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.polar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.polar1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.polar1.Pointer.HorizSize = 2;
			this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polar1.Pointer.VertSize = 2;
			this.polar1.Title = "Original";
			// 
			// 
			// 
			this.polar1.XValues.DataMember = "Angle";
			this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.polar1.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Show &Original Polar";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// polar2
			// 
			// 
			// 
			// 
			this.polar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			//this.polar2.Brush.Image = ((System.Drawing.Image)(resources.GetObject("polar2.Brush.Image")));
			this.polar2.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Tile;
			this.polar2.Brush.Solid = false;
			this.polar2.Brush.Style = Drawing.HatchStyle.LargeCheckerBoard;
			// 
			// 
			// 
			this.polar2.CircleGradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.polar2.CircleGradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.polar2.CircleGradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.polar2.CircleGradient.UseMiddle = true;
			this.polar2.CircleGradient.Visible = true;
			this.polar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.polar2.ColorEach = false;
			this.polar2.DataSource = this.polar1;
			this.polar2.Function = this.smoothing1;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.polar2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.polar2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.polar2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
			this.polar2.Marks.Brush.Gradient.UseMiddle = true;
			// 
			// 
			// 
			this.polar2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.polar2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.polar2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.polar2.Marks.Callout.Distance = 0;
			this.polar2.Marks.Callout.Draw3D = false;
			this.polar2.Marks.Callout.Length = 10;
			this.polar2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polar2.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.polar2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.polar2.Pen.Width = 2;
			// 
			// 
			// 
			this.polar2.Pointer.HorizSize = 3;
			this.polar2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.polar2.Pointer.VertSize = 3;
			this.polar2.Title = "Smooth";
			// 
			// 
			// 
			this.polar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// smoothing1
			// 
			this.smoothing1.Period = 1;
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(16, 32);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(136, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Show &Smooth Polar";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Location = new System.Drawing.Point(168, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 48);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Smoothing options";
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(8, 16);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(120, 24);
			this.checkBox3.TabIndex = 1;
			this.checkBox3.Text = "&Interpolate";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// Polar_Smooth
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Polar_Smooth";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			polar1.Visible = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			polar2.Visible = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			smoothing1.Interpolate = checkBox3.Checked;
		}
	}
}

