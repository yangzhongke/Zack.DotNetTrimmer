using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Legend_AddText : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Legend_AddText()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.FillSampleValues(6);
			this.barSeries1.Labels[0] = "one";
			this.barSeries1.Labels[1] = "two";
			this.barSeries1.Labels[2] = "three";
			this.barSeries1.Labels[3] = "four";
			this.barSeries1.Labels[4] = "five";
			this.barSeries1.Labels[5] = "six";
			this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Auto;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legend_AddText));
      this.barSeries1 = new Steema.TeeChart.Styles.Bar();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(425, 64);
      this.textBox1.Text = "Using the Chart canvas it is possible to display additional text on the Legend.\r\n" +
    "\r\nThe TChart GetLegendRect and GetLegendPos events are used to make the legend r" +
    "ectangle bigger.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Location = new System.Drawing.Point(0, 64);
      this.panel1.Size = new System.Drawing.Size(425, 37);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ColorPaletteIndex = 20;
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart1.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Grid.DrawEvery = 2;
      this.tChart1.Axes.Bottom.Grid.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Bottom.Title.Font.Size = 11;
      this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.DrawEvery = 2;
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
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Axes.Left.Labels.Font.Size = 9;
      this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Ticks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Left.Title.Font.Size = 11;
      this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.AxisPen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Right.Labels.Font.Size = 9;
      this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
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
      this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Top.Labels.Font.Size = 9;
      this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.tChart1.Header.Font.Size = 14;
      this.tChart1.Header.Font.SizeFloat = 14F;
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
      this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Legend.Font.Size = 9;
      this.tChart1.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.tChart1.Legend.Pen.Visible = false;
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.Transparent = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
      this.tChart1.Series.Add(this.barSeries1);
      this.tChart1.Size = new System.Drawing.Size(425, 169);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Visible = false;
      this.tChart1.Walls.Back.Transparent = true;
      this.tChart1.Walls.Back.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Pen.Visible = false;
      this.tChart1.Walls.Bottom.Size = 5;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Pen.Visible = false;
      this.tChart1.Walls.Left.Size = 5;
      this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
      this.tChart1.GetLegendRect += new Steema.TeeChart.GetLegendRectEventHandler(this.tChart1_GetLegendRect);
      this.tChart1.GetLegendPos += new Steema.TeeChart.GetLegendPosEventHandler(this.tChart1_GetLegendPos);
      // 
      // chartContainer
      // 
      this.chartContainer.Location = new System.Drawing.Point(0, 101);
      this.chartContainer.Size = new System.Drawing.Size(425, 169);
      // 
      // barSeries1
      // 
      this.barSeries1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
      // 
      // 
      // 
      this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.barSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.barSeries1.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.barSeries1.Marks.Arrow.Visible = false;
      this.barSeries1.Marks.ArrowLength = 0;
      // 
      // 
      // 
      this.barSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.barSeries1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.barSeries1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.barSeries1.Marks.Brush.Gradient.SigmaFocus = 0F;
      this.barSeries1.Marks.Brush.Gradient.SigmaScale = 0F;
      this.barSeries1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.barSeries1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.barSeries1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.barSeries1.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.barSeries1.OriginalCursor = null;
      // 
      // 
      // 
      this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(55)))), ((int)(((byte)(3)))));
      this.barSeries1.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
      this.barSeries1.Title = "barSeries1";
      // 
      // 
      // 
      this.barSeries1.XValues.DataMember = "X";
      this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.barSeries1.YValues.DataMember = "Bar";
      // 
      // checkBox1
      // 
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox1.Location = new System.Drawing.Point(8, 8);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(122, 19);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "&Draw text on legend";
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // Legend_AddText
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(425, 270);
      this.Name = "Legend_AddText";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Refresh();
		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			if (this.checkBox1.Checked)
			{
				if (this.checkBox1.Checked)
				{
					System.Drawing.Rectangle legRect = this.tChart1.Legend.ShapeBounds;
					Steema.TeeChart.Drawing.IGraphics3D gr = tChart1.Graphics3D;
					gr.HorizontalLine(legRect.Left,legRect.Right,legRect.Bottom - 30);
					gr.TextAlign = Drawing.StringAlignment.Near;
					gr.Font.Size = 8;
					gr.Font.Color = Color.Navy;
					gr.TextOut(legRect.Left+8,legRect.Bottom-28,"Additional text");
					gr.TextOut(legRect.Left+8,legRect.Bottom-16,"displayed here.");
				}
			}
		}

		private void tChart1_GetLegendPos(object sender, Steema.TeeChart.GetLegendPosEventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				e.X -= 40;
				e.XColor -= 40;
			}
		}

		private void tChart1_GetLegendRect(object sender, Steema.TeeChart.GetLegendRectEventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				e.Rectangle = new Rectangle(e.Rectangle.Left-40,
                                     e.Rectangle.Top,
                                     e.Rectangle.Width+10,
                                     e.Rectangle.Height+30);
			}
		}
	}
}

