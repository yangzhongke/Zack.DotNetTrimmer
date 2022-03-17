using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Series_Funnel : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Funnel funnelSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Series_Funnel()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// custom setup
			this.funnelSeries1.Marks.Visible = true;
			this.funnelSeries1.Marks.Clip = true;
			// add some points to Funnnel/Pipeline
			this.funnelSeries1.Add(50,110,"1st", Color.Red);
			this.funnelSeries1.Add(200,50,"2nd", Color.Yellow);
			this.funnelSeries1.Add(100,50,"3rd", Color.Green);
			this.funnelSeries1.Add(60,55,"4th", Color.Blue);
			// recalculate appearance
			this.funnelSeries1.Recalc();
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
			this.funnelSeries1 = new Steema.TeeChart.Styles.Funnel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 40);
			this.textBox1.Text = "Funnel Series";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			this.tChart1.Axes.Bottom.Labels.Angle = 90;
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.Visible = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 81);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.funnelSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 205);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(175)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 31;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 31;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// funnelSeries1
			// 
			// 
			// funnelSeries1.Brush
			// 
			this.funnelSeries1.Brush.Color = System.Drawing.Color.Red;
			this.funnelSeries1.LabelMember = "Labels";
			// 
			// funnelSeries1.Marks
			// 
			// 
			// funnelSeries1.Marks.Symbol
			// 
			// 
			// funnelSeries1.Marks.Symbol.Shadow
			// 
			this.funnelSeries1.Marks.Symbol.Shadow.Height = 1;
			this.funnelSeries1.Marks.Symbol.Shadow.Visible = true;
			this.funnelSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// funnelSeries1.OpportunityValues
			// 
			this.funnelSeries1.OpportunityValues.DataMember = "OpportunityValues";
			this.funnelSeries1.PercentFormat = "0.00 %";
			this.funnelSeries1.Title = "funnelSeries1";
			// 
			// funnelSeries1.XValues
			// 
			this.funnelSeries1.XValues.DataMember = "X";
			// 
			// funnelSeries1.YValues
			// 
			this.funnelSeries1.YValues.DataMember = "QuoteValues";
			this.funnelSeries1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Descending;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(8, 7);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Desired tolerance for acceptance:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(288, 8);
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																																	 1,
																																	 0,
																																	 0,
																																	 0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 30,
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
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Funnel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Funnel";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.funnelSeries1);
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.funnelSeries1.DifferenceLimit = (double)numericUpDown1.Value;
			this.funnelSeries1.Recalc();
		}
	}
}

