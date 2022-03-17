using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Zoom_MinPix : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.HorizLine horizLineSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.ComponentModel.IContainer components = null;

		public Zoom_MinPix()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			this.horizLineSeries1.FillSampleValues(80);
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "By default, a Chart is zoomed when the user drags a rectangle of minimum 15  pixe" +
				"ls size.\r\nNow the number of minimum pixels can be customized.\r\n\r\nExample: tChart" +
				"1.Zoom.MinPixels = 16 ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			this.panel1.TabIndex = 1;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			//
			//
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.horizLineSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
			this.tChart1.TabIndex = 2;
			// 
			// horizLineSeries1
			// 
			// 
			// horizLineSeries1.Brush
			// 
			this.horizLineSeries1.Brush.Color = System.Drawing.Color.Red;
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
			this.horizLineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.horizLineSeries1.Title = "horizLineSeries1";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Drag to zoom";
			this.label1.UseMnemonic = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "&Min. pixels:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(180, 6);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 16,
																																 0,
																																 0,
																																 0});
			this.numericUpDown1.TextChanged += new System.EventHandler(this.numericUpDown1_TextChanged);
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(247, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mouse &button:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Left",
																									 "Right",
																									 "Middle"});
			this.comboBox1.Location = new System.Drawing.Point(324, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Zoom_MinPix
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Zoom_MinPix";
			this.Load += new System.EventHandler(this.Zoom_MinPix_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Zoom.MinPixels = (int)this.numericUpDown1.Value;
		}

		private void numericUpDown1_TextChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Zoom.MinPixels = (int)this.numericUpDown1.Value;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (this.comboBox1.SelectedIndex)
			{
				case 0: this.tChart1.Zoom.MouseButton = Drawing.MouseButtons.Left; break;
				case 1: this.tChart1.Zoom.MouseButton = Drawing.MouseButtons.Right; break;
				case 2: this.tChart1.Zoom.MouseButton = Drawing.MouseButtons.Middle; break;
			}
		}

		private void Zoom_MinPix_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
		}
	}
}

