using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tools_ColorBand : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Tools.ColorBand colorBand1;
		private Steema.TeeChart.Tools.ColorBand colorBand2;
		private Steema.TeeChart.Tools.ColorBand colorBand3;
		private Steema.TeeChart.Tools.ColorBand colorBand4;
		private Steema.TeeChart.Tools.ColorBand colorBand5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.ComponentModel.IContainer components = null;

		public Tools_ColorBand()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			// alternative method to add points
			barSeries1.Add(new double[5] {30,150,75,280,600});
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
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.colorBand1 = new Steema.TeeChart.Tools.ColorBand();
			this.colorBand2 = new Steema.TeeChart.Tools.ColorBand();
			this.colorBand3 = new Steema.TeeChart.Tools.ColorBand();
			this.colorBand4 = new Steema.TeeChart.Tools.ColorBand();
			this.colorBand5 = new Steema.TeeChart.Tools.ColorBand();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "\"Color Band\" tools are small objects that define a rectangular region. They can b" +
				"e associated to any axis (Left, Right, Top, Bottom, etc) and have Pen, Pattern a" +
				"nd Gradient attributes.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox4);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
			this.tChart1.Tools.Add(this.colorBand1);
			this.tChart1.Tools.Add(this.colorBand2);
			this.tChart1.Tools.Add(this.colorBand3);
			this.tChart1.Tools.Add(this.colorBand4);
			this.tChart1.Tools.Add(this.colorBand5);
			// 
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(210)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// barSeries1.Marks
			// 
			// 
			// barSeries1.Marks.Symbol
			// 
			// 
			// barSeries1.Marks.Symbol.Shadow
			// 
			this.barSeries1.Marks.Symbol.Shadow.Height = 1;
			this.barSeries1.Marks.Symbol.Shadow.Visible = true;
			this.barSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// barSeries1.Pen
			// 
			this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(126)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.barSeries1.Title = "bar1";
			// 
			// barSeries1.XValues
			// 
			this.barSeries1.XValues.DataMember = "X";
			this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries1.YValues
			// 
			this.barSeries1.YValues.DataMember = "Bar";
			// 
			// colorBand1
			// 
			this.colorBand1.Axis = this.tChart1.Axes.Left;
			// 
			// colorBand1.Brush
			// 
			this.colorBand1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.colorBand1.End = 100;
			this.colorBand1.ResizeEnd = false;
			this.colorBand1.ResizeStart = false;
			this.colorBand1.Start = 0;
			// 
			// colorBand2
			// 
			this.colorBand2.Axis = this.tChart1.Axes.Left;
			// 
			// colorBand2.Brush
			// 
			this.colorBand2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			this.colorBand2.End = 200;
			this.colorBand2.ResizeEnd = false;
			this.colorBand2.ResizeStart = false;
			this.colorBand2.Start = 100;
			// 
			// colorBand3
			// 
			this.colorBand3.Axis = this.tChart1.Axes.Left;
			// 
			// colorBand3.Brush
			// 
			this.colorBand3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.colorBand3.Brush.Solid = false;
			this.colorBand3.End = 300;
			this.colorBand3.ResizeEnd = false;
			this.colorBand3.ResizeStart = false;
			this.colorBand3.Start = 200;
			// 
			// colorBand4
			// 
			this.colorBand4.Axis = this.tChart1.Axes.Left;
			// 
			// colorBand4.Brush
			// 
			this.colorBand4.Brush.Color = System.Drawing.Color.Aqua;
			this.colorBand4.End = 400;
			this.colorBand4.ResizeEnd = false;
			this.colorBand4.ResizeStart = false;
			this.colorBand4.Start = 300;
			// 
			// colorBand5
			// 
			this.colorBand5.Axis = this.tChart1.Axes.Left;
			// 
			// colorBand5.Brush
			// 
			this.colorBand5.Brush.Color = System.Drawing.Color.Lime;
			this.colorBand5.Brush.Solid = false;
			this.colorBand5.Brush.Style = Drawing.HatchStyle.Percent40;
			this.colorBand5.End = 700;
			this.colorBand5.ResizeEnd = false;
			this.colorBand5.ResizeStart = false;
			this.colorBand5.Start = 500;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(99, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Show bands";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(107, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(80, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Inverted";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(187, 7);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(80, 21);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "&Gradient";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(273, 7);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(103, 21);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "&Draw behind";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// Tool_ColorBand
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Tool_ColorBand";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorBand1.Active = checkBox1.Checked;
			this.colorBand2.Active = checkBox1.Checked;
			this.colorBand3.Active = checkBox1.Checked;
			this.colorBand4.Active = checkBox1.Checked;
			this.colorBand5.Active = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Axes.Left.Inverted = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorBand3.Gradient.Visible = checkBox3.Checked;
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorBand1.DrawBehind = checkBox4.Checked;
			this.colorBand2.DrawBehind = checkBox4.Checked;
			this.colorBand3.DrawBehind = checkBox4.Checked;
			this.colorBand4.DrawBehind = checkBox4.Checked;
			this.colorBand5.DrawBehind = checkBox4.Checked;
		}
	}
}

