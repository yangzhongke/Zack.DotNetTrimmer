using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Axis_MinorGrid : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Area areaSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
    private Steema.TeeChart.ButtonPen buttonPen1;
		private System.ComponentModel.IContainer components = null;

		public Axis_MinorGrid()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			areaSeries1.FillSampleValues(5);

			tChart1.Axes.DrawBehind = false;
			tChart1.Axes.Bottom.MinorGrid.Color = Color.White;
			tChart1.Axes.Bottom.MinorGrid.Style = Drawing.DashStyle.DashDotDot;
			tChart1.Axes.Bottom.MinorGrid.Visible = true;
			tChart1.Axes.Bottom.MinorTickCount = 3;

      buttonPen1.Pen=tChart1.Axes.Bottom.MinorGrid;
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
			this.areaSeries1 = new Steema.TeeChart.Styles.Area();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.buttonPen1 = new Steema.TeeChart.ButtonPen();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(630, 63);
			this.textBox1.Text = "All Axes can display a Minor Grid, that is, grid lines inside grid lines. The Min" +
				"orTickCount property controls the number of minor grid lines.\r\n\r\nthis.tChart1.Ax" +
				"es.Bottom.MinorGrid.Visible = true;\r\nthis.tChart1.Axes.Bottom.MinorTickCount = 3" +
				";";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.buttonPen1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(630, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.AxisPen
			// 
			this.tChart1.Axes.Bottom.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Width = 1;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Header.Font.Name = "Verdana";
			// 
			// tChart1.Header.Font.Shadow
			// 
			// 
			// tChart1.Header.Font.Shadow.Brush
			// 
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Header.Font.Shadow.Visible = true;
			this.tChart1.Header.Lines = new string[] {
														 "Minor Grid"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
			this.tChart1.Legend.Transparent = true;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
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
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.areaSeries1);
			this.tChart1.Size = new System.Drawing.Size(630, 297);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			this.tChart1.Walls.Back.Transparent = false;
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
			// areaSeries1
			// 
			// 
			// areaSeries1.AreaBrush
			// 
			this.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// areaSeries1.AreaLines
			// 
			this.areaSeries1.AreaLines.Visible = false;
			// 
			// areaSeries1.Brush
			// 
			this.areaSeries1.Brush.Color = System.Drawing.Color.Red;
			this.areaSeries1.ColorEach = true;
			// 
			// areaSeries1.LinePen
			// 
			this.areaSeries1.LinePen.Visible = false;
			// 
			// areaSeries1.Pointer
			//
			this.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries1.Title = "areaSeries1";
			this.areaSeries1.UseOrigin = true;
			// 
			// areaSeries1.XValues
			// 
			this.areaSeries1.XValues.DataMember = "X";
			this.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// areaSeries1.YValues
			// 
			this.areaSeries1.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(87, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Minor grid";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// buttonPen1
			// 
			this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPen1.Location = new System.Drawing.Point(120, 5);
			this.buttonPen1.Name = "buttonPen1";
			this.buttonPen1.TabIndex = 1;
			this.buttonPen1.Text = "&Border...";
			// 
			// Axis_MinorGrid
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(630, 393);
			this.Name = "Axis_MinorGrid";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Axes.Bottom.MinorGrid.Visible = checkBox1.Checked;
		}
	}
}

