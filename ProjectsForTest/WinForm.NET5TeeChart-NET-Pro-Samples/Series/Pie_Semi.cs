using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Pie_Semi : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Pie pieSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.ComponentModel.IContainer components = null;

		public Pie_Semi()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.pieSeries1.FillSampleValues(5);
			this.pieSeries1.AngleSize = 180;
			this.pieSeries1.RotationAngle = 90;
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
			this.pieSeries1 = new Steema.TeeChart.Styles.Pie();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 64);
			this.textBox1.Text = "The AngleSize property, used with RotationAngle, can display horizontal or vertic" +
				"al partial pie series.\r\n\r\nExample: pieSeries1.AngleSize = 180 ;   pieSeries1.Rot" +
				"ationAngle = 90;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
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
			this.tChart1.Location = new System.Drawing.Point(0, 98);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pieSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 188);
			// 
			// pieSeries1
			// 
			// 
			// pieSeries1.Brush
			// 
			this.pieSeries1.Brush.Color = System.Drawing.Color.Red;
			this.pieSeries1.LabelMember = "Labels";
			// 
			// pieSeries1.Marks
			// 
			// 
			// pieSeries1.Marks.Symbol
			// 
			// 
			// pieSeries1.Marks.Symbol.Shadow
			// 
			this.pieSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries1.Pen
			// 
			this.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pieSeries1.Shadow
			// 
			this.pieSeries1.Shadow.Height = 20;
			this.pieSeries1.Shadow.Width = 20;
			this.pieSeries1.Title = "pieSeries1";
			// 
			// pieSeries1.XValues
			// 
			this.pieSeries1.XValues.DataMember = "Angle";
			this.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries1.YValues
			// 
			this.pieSeries1.YValues.DataMember = "Pie";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(20, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(87, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Semi";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(120, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(87, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Vertical";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// Pie_Semi
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Pie_Semi";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked) this.pieSeries1.AngleSize = 180;
			else this.pieSeries1.AngleSize= 360;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox2.Checked) this.pieSeries1.RotationAngle = 90;
			else this.pieSeries1.RotationAngle = 0;
		}
	}
}

