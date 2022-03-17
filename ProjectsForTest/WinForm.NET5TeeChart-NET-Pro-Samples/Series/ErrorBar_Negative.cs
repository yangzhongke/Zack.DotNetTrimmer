using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class ErrorBar_Negative : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.ErrorBar errorBarSeries1;
		private System.ComponentModel.IContainer components = null;

		public ErrorBar_Negative()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.errorBarSeries1.Add(0,-123,23);
			this.errorBarSeries1.Add(1,432,65);
			this.errorBarSeries1.Add(2,-88,13);
			this.errorBarSeries1.Add(3,222,44);
			this.errorBarSeries1.Add(4,-321,49);
			// custom properties for error pen
			this.errorBarSeries1.ErrorPen.Color = Color.Blue;
			this.errorBarSeries1.ErrorPen.Width = 2;
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
			this.errorBarSeries1 = new Steema.TeeChart.Styles.ErrorBar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 32);
			this.textBox1.Text = "Error Bar Series and Error Series accept negative values.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 32);
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
																								 "Error bar series with negative values"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 66);
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.errorBarSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 220);
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(115, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&View 3D";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// errorBarSeries1
			// 
			// 
			// errorBarSeries1.Brush
			// 
			this.errorBarSeries1.Brush.Color = System.Drawing.Color.Red;
			this.errorBarSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Top;
			// 
			// errorBarSeries1.ErrorValues
			// 
			this.errorBarSeries1.ErrorValues.DataMember = "StdError";
			this.errorBarSeries1.LabelMember = "Labels";
			// 
			// errorBarSeries1.Marks
			// 
			// 
			// errorBarSeries1.Marks.Symbol
			// 
			// 
			// errorBarSeries1.Marks.Symbol.Shadow
			// 
			this.errorBarSeries1.Marks.Symbol.Shadow.Height = 1;
			this.errorBarSeries1.Marks.Symbol.Shadow.Visible = true;
			this.errorBarSeries1.Marks.Symbol.Shadow.Width = 1;
			this.errorBarSeries1.Marks.Visible = false;
			this.errorBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
			this.errorBarSeries1.Title = "errorBar1";
			// 
			// errorBarSeries1.XValues
			// 
			this.errorBarSeries1.XValues.DataMember = "X";
			this.errorBarSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// errorBarSeries1.YValues
			// 
			this.errorBarSeries1.YValues.DataMember = "Bar";
			// 
			// ErrorBar_Negative
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "ErrorBar_Negative";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = checkBox1.Checked;
		}
	}
}

