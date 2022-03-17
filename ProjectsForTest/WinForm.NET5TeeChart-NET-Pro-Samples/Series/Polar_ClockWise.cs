using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Polar_ClockWise : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Polar polarSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Polar_ClockWise()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.polarSeries1.FillSampleValues(5);
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
			this.polarSeries1 = new Steema.TeeChart.Styles.Polar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "The Polar circle labels can be displayed in \"ClockWise\" orientation.\r\n\r\nExample: " +
				"polarSeries1.ClockWiseLabels = true ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 34);
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
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 97);
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
			this.tChart1.Series.Add(this.polarSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			// 
			// polarSeries1
			// 
			// 
			// polarSeries1.Brush
			// 
			this.polarSeries1.Brush.Color = System.Drawing.Color.Red;
			this.polarSeries1.Brush.Visible = false;
			this.polarSeries1.Circled = true;
			this.polarSeries1.CircleLabels = true;
			this.polarSeries1.ClockWiseLabels = true;
			// 
			// polarSeries1.Marks
			// 
			// 
			// polarSeries1.Marks.Symbol
			// 
			// 
			// polarSeries1.Marks.Symbol.Shadow
			// 
			this.polarSeries1.Marks.Symbol.Shadow.Height = 1;
			this.polarSeries1.Marks.Symbol.Shadow.Visible = true;
			this.polarSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// polarSeries1.Pen
			// 
			this.polarSeries1.Pen.Color = System.Drawing.Color.Red;
			// 
			// polarSeries1.Pointer
			// 
			this.polarSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polarSeries1.Title = "polarSeries1";
			// 
			// polarSeries1.XValues
			// 
			this.polarSeries1.XValues.DataMember = "Angle";
			this.polarSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// polarSeries1.YValues
			// 
			this.polarSeries1.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(144, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&ClockWise labels";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Polar_ClockWise
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Polar_ClockWise";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.polarSeries1.ClockWiseLabels = this.checkBox1.Checked;
		}
	}
}

