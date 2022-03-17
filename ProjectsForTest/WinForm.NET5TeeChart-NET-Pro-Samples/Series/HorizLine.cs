using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class SeriesType_HorizLine : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.HorizLine horizLineSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_HorizLine()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			horizLineSeries1.Pointer.Visible = true;
			horizLineSeries1.FillSampleValues(8);
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
			this.horizLineSeries1 = new Steema.TeeChart.Styles.HorizLine();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 48);
			this.textBox1.Text = "Horizontal Line series is like a line series that draws points sorted on their Y " +
				"values instead of the X values.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 48);
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
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 81);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.horizLineSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 205);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// horizLineSeries1
			// 
			// 
			// horizLineSeries1.Brush
			// 
			this.horizLineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// horizLineSeries1.Marks
			// 
			// 
			// horizLineSeries1.Marks.Symbol
			// 
			// 
			// horizLineSeries1.Marks.Symbol.Shadow
			// 
			this.horizLineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.horizLineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.horizLineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// horizLineSeries1.Pointer
			// 
			// 
			// horizLineSeries1.Pointer.Brush
			// 
			this.horizLineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.horizLineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.horizLineSeries1.Title = "horizLine1";
			// 
			// horizLineSeries1.XValues
			// 
			this.horizLineSeries1.XValues.DataMember = "X";
			// 
			// horizLineSeries1.YValues
			// 
			this.horizLineSeries1.YValues.DataMember = "Y";
			this.horizLineSeries1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(20, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(68, 21);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "&Stairs";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Bottom;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_HorizLine
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_HorizLine";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			horizLineSeries1.Stairs = checkBox1.Checked;
		}
	}
}

