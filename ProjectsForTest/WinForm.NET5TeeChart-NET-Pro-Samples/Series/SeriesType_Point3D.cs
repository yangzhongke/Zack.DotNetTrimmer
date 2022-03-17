using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Point3D : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private Steema.TeeChart.Styles.Points3D point3DSeries1;
		private System.ComponentModel.IContainer components = null;

		private static int DeltaRotate = -5;
		private System.Windows.Forms.Timer timer1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private static int DeltaElevate = -4;

		public SeriesType_Point3D()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			point3DSeries1.FillSampleValues(100);
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
			this.components = new System.ComponentModel.Container();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.point3DSeries1 = new Steema.TeeChart.Styles.Points3D();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "The Point 3D series draws points at any XYZ position, using a standard \"Pointer\" " +
				"object.  Lines between points can also be displayed.\r\n\r\nZoom, rotation, elevatio" +
				"n and scrolling are also supported.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox6);
			this.panel1.Controls.Add(this.checkBox5);
			this.panel1.Controls.Add(this.checkBox4);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 49);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 100;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 55;
			
			
			this.tChart1.Aspect.Zoom = 86;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Depth
			// 
			this.tChart1.Axes.Depth.Visible = true;
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.point3DSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 174);
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
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(204)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 20;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 20;
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Transparency = 20;
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 14);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(54, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Lines";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(67, 14);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(53, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Walls";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(120, 14);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(53, 21);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "&Axes";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(167, 14);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(65, 21);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "&Points";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkBox5
			// 
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox5.Location = new System.Drawing.Point(220, 14);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(92, 21);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "&Color each";
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// checkBox6
			// 
			this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox6.Location = new System.Drawing.Point(333, 14);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(91, 21);
			this.checkBox6.TabIndex = 5;
			this.checkBox6.Text = "A&nimate";
			this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// point3DSeries1
			// 
			this.point3DSeries1.ColorEach = true;
			// 
			// point3DSeries1.Marks
			// 
			// 
			// point3DSeries1.Marks.Symbol
			// 
			// 
			// point3DSeries1.Marks.Symbol.Shadow
			// 
			this.point3DSeries1.Marks.Symbol.Shadow.Height = 1;
			this.point3DSeries1.Marks.Symbol.Shadow.Visible = true;
			this.point3DSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// point3DSeries1.Pointer
			// 
			// 
			// point3DSeries1.Pointer.Brush
			// 
			this.point3DSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(204)));
			this.point3DSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.point3DSeries1.Title = "point3D1";
			// 
			// point3DSeries1.XValues
			// 
			this.point3DSeries1.XValues.DataMember = "X";
			// 
			// point3DSeries1.YValues
			// 
			this.point3DSeries1.YValues.DataMember = "Y";
			// 
			// point3DSeries1.ZValues
			// 
			this.point3DSeries1.ZValues.DataMember = "Z";
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Point3D
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Point3D";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox6_CheckedChanged(object sender, System.EventArgs e)
		{
			timer1.Enabled = checkBox6.Checked;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Stop();
			try
			{
				Steema.TeeChart.Drawing.Aspect asp = tChart1.Aspect;
				asp.Rotation += DeltaRotate;
				if ((asp.Rotation<280) || (asp.Rotation>350)) DeltaRotate = -DeltaRotate;
				asp.Elevation += DeltaElevate;
				if ((asp.Elevation<280) || (asp.Elevation > 350)) DeltaElevate = -DeltaElevate;
			}
			finally
			{ 
				timer1.Start();
			}
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Walls.Visible = checkBox2.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			point3DSeries1.LinePen.Visible = checkBox1.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Axes.Visible = checkBox3.Checked;
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			this.point3DSeries1.Pointer.Visible = checkBox4.Checked;
		}

		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			point3DSeries1.ColorEach = checkBox5.Checked;
		}
	}
}

