using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Polar_Zones : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Polar polar1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Polar_Zones()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			polar1.Add(30,100);
			polar1.Add(45,150);
			polar1.Add(60,-90);
			polar1.Add(80,300);
			polar1.Add(130,400);
			polar1.Add(170,250);
			polar1.Add(230,100);
			polar1.Add(260,120);
			polar1.Add(330,700);

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
			this.polar1 = new Steema.TeeChart.Styles.Polar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Polar Series can now fill the background using a Gradient, and provides a DrawZon" +
				"e method to fill round \"donut\" zones. \r\n\r\npolar1.DrawZone(300, 700, tChart1.Aspe" +
				"ct.Width3D);";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Polar background zones"};
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
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.polar1);
			// 
			// polar1
			// 
			// 
			// polar1.Brush
			// 
			this.polar1.Brush.Color = System.Drawing.Color.Red;
			this.polar1.Brush.Visible = false;
			this.polar1.Circled = true;
			// 
			// polar1.Marks
			// 
			// 
			// polar1.Marks.Symbol
			// 
			// 
			// polar1.Marks.Symbol.Shadow
			// 
			this.polar1.Marks.Symbol.Shadow.Height = 1;
			this.polar1.Marks.Symbol.Shadow.Visible = true;
			this.polar1.Marks.Symbol.Shadow.Width = 1;
			// 
			// polar1.Pen
			// 
			this.polar1.Pen.Color = System.Drawing.Color.Red;
			// 
			// polar1.Pointer
			// 
			// 
			// polar1.Pointer.Brush
			// 
			this.polar1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polar1.Title = "polar1";
			// 
			// polar1.XValues
			// 
			this.polar1.XValues.DataMember = "Angle";
			this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// polar1.YValues
			// 
			this.polar1.YValues.DataMember = "Y";
			this.polar1.BeforeDrawValues += new Steema.TeeChart.PaintChartEventHandler(this.polar1_BeforeDrawValues);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Draw Zones";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// Polar_Zones
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Polar_Zones";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void DrawPolarZones(Steema.TeeChart.Drawing.IGraphics3D g) {
			if(polar1.CircleXCenter!=0) {
				// Hide pen
				g.Pen.Visible = false;

				//Draw three zones (green, yellow and red)
				g.Brush.Color = Color.Red;
				polar1.DrawZone(500, 700, tChart1.Aspect.Width3D);
				
				g.Brush.Color = Color.Yellow;
				polar1.DrawZone(300, 500, tChart1.Aspect.Width3D);

				g.Brush.Visible = true;
				g.Brush.Color = Color.Green;
				polar1.DrawZone(100, 300, tChart1.Aspect.Width3D);

				// Draw "ring" at 300
				g.Brush.Visible = false;
				g.Pen.Visible = true;
				g.Pen.Color = Color.White;
				g.Pen.Width = 2;
				polar1.DrawRing(300, tChart1.Aspect.Width3D);
	
			}
		}


		private void polar1_BeforeDrawValues(object sender, Steema.TeeChart.Drawing.IGraphics3D g) {
			if(checkBox1.Checked) DrawPolarZones(g);
		}

		private void checkBox1_Click(object sender, System.EventArgs e) {
			tChart1.Refresh();
		}
	}
}

