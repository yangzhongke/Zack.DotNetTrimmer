using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Volume_Origin : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Volume volumeSeries1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Volume_Origin()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO : add the YOrigin boolean to true when it's available
			volumeSeries1.FillSampleValues(60);
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
			this.volumeSeries1 = new Steema.TeeChart.Styles.Volume();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = @"Volume Series introduces two properties: bool UseOrigin double Origin.
When UseOrigin is true, lines are displayed starting at Origin value. When false, lines start at minimum value.

volumeSeries1.Origin = 33 ;                
volumeSeries1.UseOrigin = true ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
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
																								 "Volume Series - using a Y Origin value"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
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
			this.tChart1.Series.Add(this.volumeSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(107, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Y Origin:";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// volumeSeries1
			// 
			// 
			// volumeSeries1.Brush
			// 
			this.volumeSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.volumeSeries1.ClickableLine = false;
			// 
			// volumeSeries1.LinePen
			// 
			this.volumeSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// volumeSeries1.Marks
			// 
			// 
			// volumeSeries1.Marks.Symbol
			// 
			// 
			// volumeSeries1.Marks.Symbol.Shadow
			// 
			this.volumeSeries1.Marks.Symbol.Shadow.Height = 1;
			this.volumeSeries1.Marks.Symbol.Shadow.Visible = true;
			this.volumeSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// volumeSeries1.Pointer
			// 
			this.volumeSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.volumeSeries1.Title = "volume1";
			this.volumeSeries1.UseOrigin = true;
			// 
			// volumeSeries1.XValues
			// 
			this.volumeSeries1.XValues.DataMember = "X";
			this.volumeSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// volumeSeries1.YValues
			// 
			this.volumeSeries1.YValues.DataMember = "Y";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(128, 7);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																																	 20000,
																																	 0,
																																	 0,
																																	 0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																																	 20000,
																																	 0,
																																	 0,
																																	 -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 33,
																																 0,
																																 0,
																																 0});
			this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
			// Volume_Origin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Volume_Origin";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			volumeSeries1.UseOrigin = checkBox1.Checked;
			this.numericUpDown1.Enabled = checkBox1.Checked;
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			volumeSeries1.Origin =(double)numericUpDown1.Value;
		}
	}
}

