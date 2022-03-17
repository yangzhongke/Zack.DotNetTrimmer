using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_AxisArrow : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Tools.AxisArrow axisArrow1;
		private Steema.TeeChart.Tools.AxisArrow axisArrow2;
		private Steema.TeeChart.Tools.AxisArrow axisArrow3;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public Tool_AxisArrow()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.lineSeries1.FillSampleValues(10);
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
			this.axisArrow1 = new Steema.TeeChart.Tools.AxisArrow();
			this.axisArrow2 = new Steema.TeeChart.Tools.AxisArrow();
			this.axisArrow3 = new Steema.TeeChart.Tools.AxisArrow();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = @"The Axis Arrow tool is used to display small arrows at begin and / or end  positions of axes. Many Arrows can be added to a Chart, each one associated with a different axis. The Arrows can be customized ( pen, pattern, size ).
Clicking the arrows will optionally scroll the axis a configurable percent amount.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox2);
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
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Axis arrow tool"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 97);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			this.tChart1.Tools.Add(this.axisArrow1);
			this.tChart1.Tools.Add(this.axisArrow2);
			this.tChart1.Tools.Add(this.axisArrow3);
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(255)));
			// 
			// lineSeries1.LinePen
			// 
			this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(153)));
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
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
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
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(24, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(140, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Active left top";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(133, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(115, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Active &bottom";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// axisArrow1
			// 
			this.axisArrow1.Axis = this.tChart1.Axes.Left;
			// 
			// axisArrow1.Brush
			// 
			this.axisArrow1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.axisArrow1.Position = Steema.TeeChart.Tools.AxisArrowPosition.Start;
			// 
			// axisArrow2
			// 
			this.axisArrow2.Axis = this.tChart1.Axes.Left;
			// 
			// axisArrow2.Brush
			// 
			this.axisArrow2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.axisArrow2.Position = Steema.TeeChart.Tools.AxisArrowPosition.End;
			// 
			// axisArrow3
			// 
			this.axisArrow3.Axis = this.tChart1.Axes.Bottom;
			// 
			// axisArrow3.Brush
			// 
			this.axisArrow3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(256, 6);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Tool_AxisArrow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Tool_AxisArrow";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.axisArrow1.Active = checkBox1.Checked;
			this.axisArrow2.Active = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.axisArrow3.Active = checkBox2.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.tChart1.ShowEditor();
		}
	}
}

