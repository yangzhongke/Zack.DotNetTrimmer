using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Line_ColorEach : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Line_ColorEach()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			this.lineSeries1.FillSampleValues(25);
			this.lineSeries1.Pointer.Visible = true;
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 96);
			this.textBox1.Text = "Line Series in 2D mode can now display points with different colors while drawing" +
				" Line segments with a single color.\r\n\r\nExample: \r\nlineSeries1.ColorEach =true; \r" +
				"\nlineSeries1.ColorEachLine = false; ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 96);
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
			this.tChart1.Location = new System.Drawing.Point(0, 129);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 157);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.Red;
			this.lineSeries1.ColorEach = true;
			this.lineSeries1.ColorEachLine = false;
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries1.Pointer
			// 
			// 
			// lineSeries1.Pointer.Brush
			// 
			this.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Pointer.Visible = true;
			this.lineSeries1.Title = "lineSeries1";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.DataMember = "X";
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries1.YValues
			// 
			this.lineSeries1.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(112, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Color each line";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(127, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(113, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Color &each point";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
			// Line_ColorEach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Line_ColorEach";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lineSeries1.ColorEachLine = this.checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lineSeries1.ColorEach = this.checkBox2.Checked;
		}
	}
}

