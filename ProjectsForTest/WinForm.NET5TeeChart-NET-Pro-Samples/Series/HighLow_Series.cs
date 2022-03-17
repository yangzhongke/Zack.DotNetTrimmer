using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class HighLow_Series : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.HighLow highLowSeries1;
    private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public HighLow_Series()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			highLowSeries1.FillSampleValues(20);
			highLowSeries1.Color=Color.Red;
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
			this.highLowSeries1 = new Steema.TeeChart.Styles.HighLow();
			this.button1 = new System.Windows.Forms.Button();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 40);
			this.textBox1.Text = "High-Low series draws (and optionally fills) two lines with High and Low values f" +
				"or each point.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 40);
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
			this.tChart1.Location = new System.Drawing.Point(0, 73);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.highLowSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 213);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// highLowSeries1
			// 
			// 
			// highLowSeries1.HighBrush
			// 
			this.highLowSeries1.HighBrush.Solid = false;
			this.highLowSeries1.HighBrush.Style = Drawing.HatchStyle.Percent50;
			// 
			// highLowSeries1.YValues
			// 
			this.highLowSeries1.HighValues.DataMember = "Y";
			this.highLowSeries1.LabelMember = "Labels";
			// 
			// highLowSeries1.LowBrush
			// 
			this.highLowSeries1.LowBrush.Solid = false;
			this.highLowSeries1.LowBrush.Style = Drawing.HatchStyle.Percent50;
			// 
			// highLowSeries1.LowValues
			// 
			this.highLowSeries1.LowValues.DataMember = "Low";
			// 
			// highLowSeries1.Marks
			// 
			// 
			// highLowSeries1.Marks.Symbol
			// 
			// 
			// highLowSeries1.Marks.Symbol.Shadow
			// 
			this.highLowSeries1.Marks.Symbol.Shadow.Height = 1;
			this.highLowSeries1.Marks.Symbol.Shadow.Visible = true;
			this.highLowSeries1.Marks.Symbol.Shadow.Width = 1;
			this.highLowSeries1.Title = "high-Low1";
			// 
			// highLowSeries1.XValues
			// 
			this.highLowSeries1.XValues.DataMember = "X";
			this.highLowSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// highLowSeries1.YValues
			// 
			this.highLowSeries1.YValues.DataMember = "Y";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 5);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			// SeriesType_HighLow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_HighLow";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void button1_Click(object sender, System.EventArgs e)
    {
      TeeChart.Editors.SeriesEditor.ShowModal(highLowSeries1);
    }
	}
}

