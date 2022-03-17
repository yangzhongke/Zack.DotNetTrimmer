using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Bar : Samples.BaseForm
	{
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Bar bar1;
		private Steema.TeeChart.Styles.Bar bar2;
		private Steema.TeeChart.Styles.Bar bar3;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Bar()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bar1.FillSampleValues(6);
			bar2.FillSampleValues(6);
			bar3.FillSampleValues(6);
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.bar2 = new Steema.TeeChart.Styles.Bar();
			this.bar3 = new Steema.TeeChart.Styles.Bar();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 80);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = @"The Bar style allows single or multiple bars, with different layouts ( 3D, side-to-side, side-all, stacked, stacked 100% ).

Options include 2D and 3D, color-each-bar, bar style, patterns, dark 3D, bottom origin, auto-mark positions, stacking groups, marks, border, etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Location = new System.Drawing.Point(0, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 40);
			this.panel1.TabIndex = 1;
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
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Length = 2;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Length = 2;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Length = 2;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Length = 2;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Location = new System.Drawing.Point(0, 120);
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Series.Add(this.bar2);
			this.tChart1.Series.Add(this.bar3);
			this.tChart1.Size = new System.Drawing.Size(466, 166);
			this.tChart1.TabIndex = 2;
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "3D",
																									 "Side-to-side",
																									 "Stacked",
																									 "Stacked 100%",
																									 "Side All",
																									 "Self Stacked"});
			this.comboBox1.Location = new System.Drawing.Point(53, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(94, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Layout :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 2;
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
			this.comboBox2.Location = new System.Drawing.Point(227, 8);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(86, 21);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(333, 7);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			// 
			// bar1.Pen
			// 
			this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// bar2
			// 
			// 
			// bar2.Brush
			// 
			this.bar2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// bar2.Marks
			// 
			// 
			// bar2.Marks.Symbol
			// 
			// 
			// bar2.Marks.Symbol.Shadow
			// 
			this.bar2.Marks.Symbol.Shadow.Height = 1;
			this.bar2.Marks.Symbol.Shadow.Visible = true;
			this.bar2.Marks.Symbol.Shadow.Width = 1;
			// 
			// bar2.Pen
			// 
			this.bar2.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(77)), ((System.Byte)(0)));
			this.bar2.Title = "bar2";
			// 
			// bar2.XValues
			// 
			this.bar2.XValues.DataMember = "X";
			this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar2.YValues
			// 
			this.bar2.YValues.DataMember = "Bar";
			// 
			// bar3
			// 
			// 
			// bar3.Brush
			// 
			this.bar3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			// 
			// bar3.Marks
			// 
			// 
			// bar3.Marks.Symbol
			// 
			// 
			// bar3.Marks.Symbol.Shadow
			// 
			this.bar3.Marks.Symbol.Shadow.Height = 1;
			this.bar3.Marks.Symbol.Shadow.Visible = true;
			this.bar3.Marks.Symbol.Shadow.Width = 1;
			// 
			// bar3.Pen
			// 
			this.bar3.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(153)), ((System.Byte)(153)), ((System.Byte)(0)));
			this.bar3.Title = "bar3";
			// 
			// bar3.XValues
			// 
			this.bar3.XValues.DataMember = "X";
			this.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar3.YValues
			// 
			this.bar3.YValues.DataMember = "Bar";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// SeriesType_Bar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Bar";
			this.Load += new System.EventHandler(this.SeriesType_Bar_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None; break;
				case 1 : bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.Side; break;
				case 2 : bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked; break;
				case 3 : bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked100; break;
				case 4 : bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.SideAll; break;
        case 5 :
          bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.SelfStack;
          bar1.BarWidthPercent = 40;
          bar2.BarWidthPercent = 40;
          bar3.BarWidthPercent = 40;
          break;
			}

			// remove "Marks" when stacking...
			bar1.Marks.Visible = ((bar1.MultiBar != Steema.TeeChart.Styles.MultiBars.Stacked) && (bar1.MultiBar != Steema.TeeChart.Styles.MultiBars.Stacked100) && (bar1.MultiBar != Steema.TeeChart.Styles.MultiBars.SelfStack));
			bar2.Marks.Visible = bar1.Marks.Visible;
			bar3.Marks.Visible = bar1.Marks.Visible;
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox2.SelectedIndex)
			{
				case 0 : bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Rectangle; break;
				case 1 : bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Pyramid; break;
				case 2 : bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.InvPyramid; break;
				case 3 : bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder; break;
				case 4 : bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Ellipse; break;
				case 5 : bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Arrow; break;
				case 6 : bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.RectGradient; break;
				case 7 : bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cone; break;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			tChart1.ShowEditor();
		}

		private void SeriesType_Bar_Load(object sender, System.EventArgs e)
		{
			comboBox1.SelectedIndex = 1;
			comboBox2.SelectedIndex = 0;
		}
	}
}

