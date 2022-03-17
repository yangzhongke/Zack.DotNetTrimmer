using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class AxisDepthDateTime : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Tower tower1;
		private System.ComponentModel.IContainer components = null;

		public AxisDepthDateTime()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			tower1.XValues.DateTime = true;
			tower1.ZValues.DateTime = true;
			tower1.FillSampleValues();	

			tChart1.Axes.DepthTop.Labels.DateTimeFormat = "MMM-dd";
			tChart1.Axes.Depth.Labels.DateTimeFormat = "MMM-dd";
			tChart1.Axes.Bottom.Labels.DateTimeFormat = "MMM-dd";

      tChart1.Axes.DepthTop.Visible = true;
      tChart1.Axes.Depth.Visible = true;
      tChart1.Axes.DepthTop.Increment = 2;
      tChart1.Axes.Depth.Increment = 2;

			for (int i=0;i<tChart1.Axes.Count;i++)
				tChart1.Axes[i].Labels.Font.Size=12;
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
			this.tower1 = new Steema.TeeChart.Styles.Tower();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Depth and Depth-Top axes can be set to display date-time labels,\r\njust like all o" +
				"ther axis.";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
														 "TeeChart"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
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
			this.tChart1.Series.Add(this.tower1);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(184, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "DateTime Depth Axes";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// tower1
			// 
			// 
			// tower1.Brush
			// 
			this.tower1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			this.tower1.Origin = 0;
			this.tower1.PaletteMin = 0;
			this.tower1.PaletteStep = 0;
			this.tower1.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			this.tower1.Title = "tower1";
			// 
			// tower1.XValues
			// 
			this.tower1.XValues.DataMember = "X";
			// 
			// tower1.YValues
			// 
			this.tower1.YValues.DataMember = "Y";
			// 
			// tower1.ZValues
			// 
			this.tower1.ZValues.DataMember = "Z";
			// 
			// AxisDepthDateTime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "AxisDepthDateTime";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			tower1.ZValues.DateTime = checkBox1.Checked;
		}
	}
}

