using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class SeriesType_HorizBar : Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.HorizBar horizBarSeries1;
		private Steema.TeeChart.Styles.HorizBar horizBarSeries2;
		private Steema.TeeChart.Styles.HorizBar horizBarSeries3;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_HorizBar()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (TeeChart.Styles.HorizBar hb in tChart1.Series)
			{
				hb.FillSampleValues(4);
				hb.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
			}
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.horizBarSeries1 = new Steema.TeeChart.Styles.HorizBar();
			this.horizBarSeries2 = new Steema.TeeChart.Styles.HorizBar();
			this.horizBarSeries3 = new Steema.TeeChart.Styles.HorizBar();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(560, 80);
			this.textBox1.Text = @"The Horizontal Bar style allows single or multiple bars, with different layouts ( 3D, side-to-side, side-all, stacked, stacked 100% ).

Options include 2D and 3D, color-each-bar, bar style, patterns, dark 3D, bottom origin, auto-mark positions, stacking groups, marks, border, etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(560, 36);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Location = new System.Drawing.Point(0, 116);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.horizBarSeries1);
			this.tChart1.Series.Add(this.horizBarSeries2);
			this.tChart1.Series.Add(this.horizBarSeries3);
			this.tChart1.Size = new System.Drawing.Size(560, 214);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "&Layout :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "3D",
																									 "Side-to-side",
																									 "Stacked",
																									 "Stacked 100%",
																									 "Side All"});
			this.comboBox1.Location = new System.Drawing.Point(64, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(112, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(202, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "&Style Bar 1:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
																									 "Rectangle",
																									 "Pyramid",
																									 "Invert. Pyramid",
																									 "Cylinder",
																									 "Ellipse",
																									 "Arrow",
																									 "Rect. Gradient",
																									 "Cone"});
			this.comboBox2.Location = new System.Drawing.Point(272, 8);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(104, 21);
			this.comboBox2.TabIndex = 5;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(400, 6);
			this.button1.Name = "button1";
			this.button1.TabIndex = 6;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// horizBarSeries1
			// 
			// 
			// horizBarSeries1.Brush
			// 
			this.horizBarSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// horizBarSeries1.Gradient
			// 
			this.horizBarSeries1.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizBarSeries1.Gradient
			// 
			this.horizBarSeries1.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizBarSeries1.Marks
			// 
			// 
			// horizBarSeries1.Marks.Symbol
			// 
			// 
			// horizBarSeries1.Marks.Symbol.Shadow
			// 
			this.horizBarSeries1.Marks.Symbol.Shadow.Height = 1;
			this.horizBarSeries1.Marks.Symbol.Shadow.Visible = true;
			this.horizBarSeries1.Marks.Symbol.Shadow.Width = 1;
			this.horizBarSeries1.Title = "horizBarSeries1";
			// 
			// horizBarSeries1.XValues
			// 
			this.horizBarSeries1.XValues.DataMember = "X";
			// 
			// horizBarSeries1.YValues
			// 
			this.horizBarSeries1.YValues.DataMember = "Bar";
			this.horizBarSeries1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// horizBarSeries2
			// 
			// 
			// horizBarSeries2.Brush
			// 
			this.horizBarSeries2.Brush.Color = System.Drawing.Color.Green;
			// 
			// horizBarSeries2.Gradient
			// 
			this.horizBarSeries2.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizBarSeries2.Gradient
			// 
			this.horizBarSeries2.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizBarSeries2.Marks
			// 
			// 
			// horizBarSeries2.Marks.Symbol
			// 
			// 
			// horizBarSeries2.Marks.Symbol.Shadow
			// 
			this.horizBarSeries2.Marks.Symbol.Shadow.Height = 1;
			this.horizBarSeries2.Marks.Symbol.Shadow.Visible = true;
			this.horizBarSeries2.Marks.Symbol.Shadow.Width = 1;
			this.horizBarSeries2.Title = "horizBarSeries2";
			// 
			// horizBarSeries2.XValues
			// 
			this.horizBarSeries2.XValues.DataMember = "X";
			// 
			// horizBarSeries2.YValues
			// 
			this.horizBarSeries2.YValues.DataMember = "Bar";
			this.horizBarSeries2.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// horizBarSeries3
			// 
			// 
			// horizBarSeries3.Brush
			// 
			this.horizBarSeries3.Brush.Color = System.Drawing.Color.Yellow;
			// 
			// horizBarSeries3.Gradient
			// 
			this.horizBarSeries3.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizBarSeries3.Gradient
			// 
			this.horizBarSeries3.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizBarSeries3.Marks
			// 
			// 
			// horizBarSeries3.Marks.Symbol
			// 
			// 
			// horizBarSeries3.Marks.Symbol.Shadow
			// 
			this.horizBarSeries3.Marks.Symbol.Shadow.Height = 1;
			this.horizBarSeries3.Marks.Symbol.Shadow.Visible = true;
			this.horizBarSeries3.Marks.Symbol.Shadow.Width = 1;
			this.horizBarSeries3.Title = "horizBarSeries3";
			// 
			// horizBarSeries3.XValues
			// 
			this.horizBarSeries3.XValues.DataMember = "X";
			// 
			// horizBarSeries3.YValues
			// 
			this.horizBarSeries3.YValues.DataMember = "Bar";
			this.horizBarSeries3.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
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
			// SeriesType_HorizBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 330);
			this.Name = "SeriesType_HorizBar";
			this.Load += new System.EventHandler(this.SeriesType_HorizBar_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.None; break;
				case 1 : horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Side; break;
				case 2 : horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked; break;
				case 3 : horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked100; break;
				case 4 : horizBarSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.SideAll; break;
			}

			// remove "Marks" when stacking...
			horizBarSeries1.Marks.Visible = ((horizBarSeries1.MultiBar != Steema.TeeChart.Styles.MultiBars.Stacked) && (horizBarSeries1.MultiBar != Steema.TeeChart.Styles.MultiBars.Stacked100));
			horizBarSeries2.Marks.Visible = horizBarSeries1.Marks.Visible;
			horizBarSeries3.Marks.Visible = horizBarSeries1.Marks.Visible;
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox2.SelectedIndex)
			{
				case 0 : horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Rectangle; break;
				case 1 : horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Pyramid; break;
				case 2 : horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.InvPyramid; break;
				case 3 : horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder; break;
				case 4 : horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Ellipse; break;
				case 5 : horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Arrow; break;
				case 6 : horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.RectGradient; break;
				case 7 : horizBarSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cone; break;
			}
		}

		private void SeriesType_HorizBar_Load(object sender, System.EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 0;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(horizBarSeries1);
		}
	}
}