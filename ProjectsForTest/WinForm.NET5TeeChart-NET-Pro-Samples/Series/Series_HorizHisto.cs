using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Series_HorizHisto : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.HorizHistogram horizHistogram1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Series_HorizHisto()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			horizHistogram1.FillSampleValues();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Series_HorizHisto));
            this.button1 = new System.Windows.Forms.Button();
            this.horizHistogram1 = new Steema.TeeChart.Styles.HorizHistogram();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Horizontal Histogram series displays values like an horizontal area series in \"st" +
                "airs\" mode,  but centering the points at Y coordinates.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ThemeIndex = 2;
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
            this.tChart1.Axes.Bottom.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Centered = true;
            this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Bold = true;
            this.tChart1.Axes.Bottom.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 10F;
            this.tChart1.Axes.Bottom.MaximumOffset = 9;
            this.tChart1.Axes.Bottom.MinimumOffset = 8;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Name = "Times New Roman";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Depth.Labels.Font.Size = 10;
            this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Name = "Times New Roman";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Bold = true;
            this.tChart1.Axes.Left.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Left.Labels.Font.Size = 10;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 10F;
            this.tChart1.Axes.Left.MaximumOffset = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Name = "Times New Roman";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Right.Labels.Font.Size = 10;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Name = "Times New Roman";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Top.Labels.Font.Size = 10;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Name = "Times New Roman";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Black;
            this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.Gray;
            this.tChart1.Header.Brush.Gradient.UseMiddle = true;
            this.tChart1.Header.Brush.Gradient.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart1.Header.Font.Name = "Times New Roman";
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            this.tChart1.Header.Lines = new string[] {
        "Horizontal Histogram"};
            // 
            // 
            // 
            this.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(251)))));
            this.tChart1.Header.Pen.Width = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Shadow.Height = 4;
            this.tChart1.Header.Shadow.Width = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
            this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Legend.DividingLines.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Font.Name = "Times New Roman";
            this.tChart1.Legend.Font.Size = 10;
            this.tChart1.Legend.Font.SizeFloat = 10F;
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
            this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.DefaultPen = false;
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Pen.Visible = false;
            this.tChart1.Legend.Symbol.Squared = true;
            this.tChart1.Legend.Transparent = true;
            this.tChart1.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
            this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
            // 
            // 
            // 
            this.tChart1.Panel.Pen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
            this.tChart1.Panel.Shadow.Visible = true;
            this.tChart1.Series.Add(this.horizHistogram1);
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            this.tChart1.Tools.Add(this.gridBand1);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.ApplyDark = false;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(122)))), ((int)(((byte)(41)))));
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White;
            this.tChart1.Walls.Back.Size = 8;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.ApplyDark = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(133)))), ((int)(((byte)(253)))));
            this.tChart1.Walls.Bottom.Size = 8;
            // 
            // 
            // 
            this.tChart1.Walls.Left.ApplyDark = false;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(124)))));
            this.tChart1.Walls.Left.Size = 8;
            // 
            // 
            // 
            this.tChart1.Walls.Right.ApplyDark = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Walls.Right.Size = 8;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // horizHistogram1
            // 
            // 
            // 
            // 
            this.horizHistogram1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.horizHistogram1.Brush.Solid = false;
            this.horizHistogram1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.horizHistogram1.ColorEach = false;
            // 
            // 
            // 
            this.horizHistogram1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            // 
            // 
            // 
            this.horizHistogram1.LinesPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.horizHistogram1.LinesPen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizHistogram1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.horizHistogram1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.horizHistogram1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.horizHistogram1.Marks.Callout.Distance = 0;
            this.horizHistogram1.Marks.Callout.Draw3D = false;
            this.horizHistogram1.Marks.Callout.Length = 10;
            this.horizHistogram1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.horizHistogram1.Marks.Callout.Visible = false;
            this.horizHistogram1.Title = "horizHistogram1";
            // 
            // 
            // 
            this.horizHistogram1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.horizHistogram1.YValues.DataMember = "Y";
            this.horizHistogram1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Bottom;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // Series_HorizHisto
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Series_HorizHisto";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e) {
			TeeChart.Editors.SeriesEditor.ShowEditor(horizHistogram1);
		}
	}
}


