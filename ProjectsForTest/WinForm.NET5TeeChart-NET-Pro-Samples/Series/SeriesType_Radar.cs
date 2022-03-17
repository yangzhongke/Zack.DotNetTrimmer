using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Radar : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Radar radarSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private Steema.TeeChart.Styles.Radar radarSeries2;
		private Steema.TeeChart.Styles.Radar radarSeries3;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Radar()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(5);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriesType_Radar));
			this.radarSeries1 = new Steema.TeeChart.Styles.Radar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.radarSeries2 = new Steema.TeeChart.Styles.Radar();
			this.radarSeries3 = new Steema.TeeChart.Styles.Radar();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "A Radar series shows each point at a different angle.  \r\nSeveral Radar series can" +
					" be displayed at the same time, each one with different configuration.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox4);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Size = new System.Drawing.Size(466, 33);
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
			this.tChart1.Axes.Bottom.Increment = 72;
			// 
			// 
			// 
			this.tChart1.Header.Alignment = Drawing.StringAlignment.Near;
			this.tChart1.Header.Lines = new string[] {
        "Radar series"};
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
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Series.Add(this.radarSeries1);
			this.tChart1.Series.Add(this.radarSeries2);
			this.tChart1.Series.Add(this.radarSeries3);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 96);
			this.chartContainer.Size = new System.Drawing.Size(466, 190);
			// 
			// radarSeries1
			// 
			// 
			// 
			// 
			this.radarSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.radarSeries1.Circled = true;
			this.radarSeries1.CircleLabels = true;
			this.radarSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.radarSeries1.ColorEach = false;
			this.radarSeries1.LabelMember = "Labels";
			// 
			// 
			// 
			// 
			// 
			// 
			this.radarSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.radarSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.radarSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.radarSeries1.Marks.Callout.Distance = 0;
			this.radarSeries1.Marks.Callout.Draw3D = false;
			this.radarSeries1.Marks.Callout.Length = 10;
			this.radarSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.radarSeries1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.radarSeries1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			// 
			// 
			// 
			this.radarSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.radarSeries1.RotationAngle = 90;
			this.radarSeries1.Title = "radar3";
			// 
			// 
			// 
			this.radarSeries1.XValues.DataMember = "Angle";
			this.radarSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.radarSeries1.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(54, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Labels";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(73, 6);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(54, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Li&nes";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(127, 6);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(53, 21);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "&Axis";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(180, 6);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(108, 21);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "&Squared";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// radarSeries2
			// 
			// 
			// 
			// 
			this.radarSeries2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.radarSeries2.Circled = true;
			this.radarSeries2.CircleLabels = true;
			this.radarSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.radarSeries2.ColorEach = false;
			this.radarSeries2.LabelMember = "Labels";
			// 
			// 
			// 
			// 
			// 
			// 
			this.radarSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.radarSeries2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.radarSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.radarSeries2.Marks.Callout.Distance = 0;
			this.radarSeries2.Marks.Callout.Draw3D = false;
			this.radarSeries2.Marks.Callout.Length = 10;
			this.radarSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.radarSeries2.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.radarSeries2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			// 
			// 
			// 
			this.radarSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.radarSeries2.RotationAngle = 90;
			this.radarSeries2.Title = "radar3";
			// 
			// 
			// 
			this.radarSeries2.XValues.DataMember = "Angle";
			this.radarSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.radarSeries2.YValues.DataMember = "Y";
			// 
			// radarSeries3
			// 
			// 
			// 
			// 
			this.radarSeries3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			this.radarSeries3.Circled = true;
			this.radarSeries3.CircleLabels = true;
			this.radarSeries3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			this.radarSeries3.ColorEach = false;
			this.radarSeries3.LabelMember = "Labels";
			// 
			// 
			// 
			// 
			// 
			// 
			this.radarSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.radarSeries3.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.radarSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.radarSeries3.Marks.Callout.Distance = 0;
			this.radarSeries3.Marks.Callout.Draw3D = false;
			this.radarSeries3.Marks.Callout.Length = 10;
			this.radarSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.radarSeries3.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.radarSeries3.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			// 
			// 
			// 
			this.radarSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.radarSeries3.RotationAngle = 90;
			this.radarSeries3.Title = "radar3";
			// 
			// 
			// 
			this.radarSeries3.XValues.DataMember = "Angle";
			this.radarSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.radarSeries3.YValues.DataMember = "Y";
			// 
			// SeriesType_Radar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Radar";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			radarSeries1.Circled = checkBox4.Checked;
			radarSeries2.Circled = checkBox4.Checked;
			radarSeries3.Circled = checkBox4.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			radarSeries1.CircleLabels = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			radarSeries1.Pen.Visible = checkBox2.Checked;
			radarSeries2.Pen.Visible = checkBox2.Checked;
			radarSeries3.Pen.Visible = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Axes.Right.Visible = checkBox3.Checked;
		}
	}
}

