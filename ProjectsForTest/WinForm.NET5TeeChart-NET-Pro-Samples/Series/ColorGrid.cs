using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_ColorGrid : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.ColorGrid colorGridSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_ColorGrid()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.colorGridSeries1.FillSampleValues(20);
			this.colorGridSeries1.Pen.Color = Color.White;
			this.colorGridSeries1.UsePalette = true;
			this.colorGridSeries1.UseColorRange = false;
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
			this.colorGridSeries1 = new Steema.TeeChart.Styles.ColorGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = @"ColorGrid series is a 2D surface. Each ""cell"" has a value and an optional color. The AddXYZ method is used to fill the color grid. An optional ""grid"" over cells is displayed using the Pen property.

Example: colorGridSeries1.Add( 1, 123, 1 ); // x=1, z = 1, y(x,z) =123";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
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
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.colorGridSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
			// 
			// colorGridSeries1
			// 
			// 
			// colorGridSeries1.Brush
			// 
			this.colorGridSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// colorGridSeries1.Marks
			// 
			this.colorGridSeries1.Marks.ArrowLength = 0;
			// 
			// colorGridSeries1.Marks.Symbol
			// 
			// 
			// colorGridSeries1.Marks.Symbol.Shadow
			// 
			this.colorGridSeries1.Marks.Symbol.Shadow.Height = 1;
			this.colorGridSeries1.Marks.Symbol.Shadow.Visible = true;
			this.colorGridSeries1.Marks.Symbol.Shadow.Width = 1;
			this.colorGridSeries1.NumXValues = 25;
			this.colorGridSeries1.NumZValues = 25;
			this.colorGridSeries1.PaletteMin = 0;
			this.colorGridSeries1.PaletteStep = 0;
			this.colorGridSeries1.Title = "colorGridSeries1";
			// 
			// colorGridSeries1.XValues
			// 
			this.colorGridSeries1.XValues.DataMember = "X";
			// 
			// colorGridSeries1.YValues
			// 
			this.colorGridSeries1.YValues.DataMember = "Y";
			// 
			// colorGridSeries1.ZValues
			// 
			this.colorGridSeries1.ZValues.DataMember = "Z";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Size:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(56, 7);
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																																	 2,
																																	 0,
																																	 0,
																																	 0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 20,
																																 0,
																																 0,
																																 0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(120, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(47, 21);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "&Grid";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(208, 6);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SeriesType_ColorGrid
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_ColorGrid";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorGridSeries1.FillSampleValues((int)this.numericUpDown1.Value);
			if (this.numericUpDown1.Value > 30)
			{
				this.checkBox1.Checked = false;
				this.colorGridSeries1.Pen.Visible = false;
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorGridSeries1.Pen.Visible = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.colorGridSeries1);
		}
	}
}

