using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Contour_Levels : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Contour contourSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		private void AddCustomLevels()
		{
			this.contourSeries1.NumLevels = 10;
			// TODO : this.contourSeries1.CreateAutoLevels(); still private ?
			(this.contourSeries1.Levels[0] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -1;
			(this.contourSeries1.Levels[1] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -0.8;
			(this.contourSeries1.Levels[2] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -0.6;
			(this.contourSeries1.Levels[3] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -0.4;
			(this.contourSeries1.Levels[4] as Steema.TeeChart.Styles.ContourLevel).UpToValue = -0.2;
			(this.contourSeries1.Levels[5] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.0;
			(this.contourSeries1.Levels[6] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.2;
			(this.contourSeries1.Levels[7] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.4;
			(this.contourSeries1.Levels[8] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.6;
			(this.contourSeries1.Levels[9] as Steema.TeeChart.Styles.ContourLevel).UpToValue = 0.8;
		}
		
		public Contour_Levels()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.contourSeries1.FillSampleValues(20);
			this.contourSeries1.ColorEach = false;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contour_Levels));
			this.contourSeries1 = new Steema.TeeChart.Styles.Contour();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Contour levels can be customized at design-time or run-time.\r\nThe number of level" +
					"s and each level value and color are properties.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Size = new System.Drawing.Size(466, 34);
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
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
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
			this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
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
			this.tChart1.Axes.Depth.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Depth.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.DepthTop.Grid.Style = Drawing.DashStyle.Solid;
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
			this.tChart1.Axes.DepthTop.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
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
			this.tChart1.Axes.Left.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Left.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
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
			this.tChart1.Axes.Right.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Right.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
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
			this.tChart1.Axes.Top.MinorTicks.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			// 
			// 
			// 
			this.tChart1.Axes.Top.TicksInner.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Header.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Header.Lines = new string[] {
        "Contour series : custom levels"};
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.tChart1.Legend.Brush.Gradient.Visible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
			this.tChart1.Series.Add(this.contourSeries1);
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
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			// 
			// 
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			// 
			// 
			// 
			this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
			this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
			this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Walls.Right.Pen.Visible = false;
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 97);
			this.chartContainer.Size = new System.Drawing.Size(466, 189);
			// 
			// contourSeries1
			// 
			// 
			// 
			// 
			this.contourSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.contourSeries1.Brush.Visible = false;
			this.contourSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.contourSeries1.ColorEach = true;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.contourSeries1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.contourSeries1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.contourSeries1.Marks.Brush.Gradient.SigmaFocus = 0F;
			this.contourSeries1.Marks.Brush.Gradient.SigmaScale = 0F;
			this.contourSeries1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.contourSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.contourSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.contourSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.contourSeries1.Marks.Callout.Distance = 0;
			this.contourSeries1.Marks.Callout.Draw3D = false;
			this.contourSeries1.Marks.Callout.Length = 10;
			this.contourSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.contourSeries1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.contourSeries1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.contourSeries1.Marks.Transparent = true;
			this.contourSeries1.NumXValues = 25;
			this.contourSeries1.NumZValues = 25;
			this.contourSeries1.PaletteMin = 0;
			this.contourSeries1.PaletteStep = 0;
			this.contourSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
			// 
			// 
			// 
			this.contourSeries1.Pointer.HorizSize = 2;
			// 
			// 
			// 
			this.contourSeries1.Pointer.Pen.Visible = false;
			this.contourSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.contourSeries1.Pointer.VertSize = 2;
			this.contourSeries1.Pointer.Visible = false;
			this.contourSeries1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.contourSeries1.Title = "contourSeries1";
			// 
			// 
			// 
			this.contourSeries1.XValues.DataMember = "X";
			this.contourSeries1.YPosition = 0.20290816683830415;
			// 
			// 
			// 
			this.contourSeries1.YValues.DataMember = "Y";
			// 
			// 
			// 
			this.contourSeries1.ZValues.DataMember = "Z";
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(100, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Custom levels";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Contour_Levels
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Contour_Levels";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.contourSeries1.AutomaticLevels = !this.checkBox1.Checked;
			if (!this.contourSeries1.AutomaticLevels) this.AddCustomLevels();
		}
	}
}

