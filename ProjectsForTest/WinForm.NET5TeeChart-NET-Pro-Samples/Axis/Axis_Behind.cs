using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Axis_Behind : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Bar bar1;
		private System.ComponentModel.IContainer components = null;

		public Axis_Behind()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			bar1.FillSampleValues(6);
			//tChart1.Axes.Left.Grid.Color = Color.White;
			//tChart1.Axes.Bottom.Grid.Color = Color.Blue;
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(388, 63);
			this.textBox1.Text = "tChart1.Axes.DrawBehind property controls if axes will be displayed in front of S" +
				"eries. This is useful to display Grid lines over series.\r\n\r\nExample: tChart1.Axe" +
				"s.DrawBehind = false;";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(388, 27);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.AxisPen
			// 
			this.tChart1.Axes.Bottom.AxisPen.Visible = false;
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Bottom.MinorTicks
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Length = 2;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			this.tChart1.Axes.DrawBehind = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Visible = false;
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			// 
			// 
			// tChart1.Axes.Left.MinorTicks
			// 
			this.tChart1.Axes.Left.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Length = 2;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.AxisPen
			// 
			this.tChart1.Axes.Right.AxisPen.Visible = false;
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Length = 2;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.AxisPen
			// 
			this.tChart1.Axes.Top.AxisPen.Visible = false;
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Length = 2;
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
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Header.Font.Shadow.Visible = true;
			this.tChart1.Header.Lines = new string[] {
														 "Controlling when axes are drawn"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Transparent = true;
			this.tChart1.Location = new System.Drawing.Point(0, 90);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Size = new System.Drawing.Size(388, 157);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(169)), ((System.Byte)(169)), ((System.Byte)(169)));
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver;
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(123, 18);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Axes &Behind";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			// 
			// bar1.Marks
			// 
			this.bar1.Marks.Visible = false;
			// 
			// bar1.Pen
			// 
			this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(61)), ((System.Byte)(92)), ((System.Byte)(153)));
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// Axis_Behind
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(388, 247);
			this.Name = "Axis_Behind";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Axes.DrawBehind = checkBox1.Checked;
		}
	}
}

