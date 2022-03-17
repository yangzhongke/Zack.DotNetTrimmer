using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Series_TextSource : Steema.TeeChart.Samples.BaseNoChart
	{
		protected System.Windows.Forms.TextBox textBox2;
		protected System.Windows.Forms.Button button1;
		protected Steema.TeeChart.Data.TextSource textSource1;
		protected Steema.TeeChart.TChart tChart1;
		protected Steema.TeeChart.Styles.Bar bar1;
		protected System.Windows.Forms.Button button2;
		protected System.Windows.Forms.TextBox textBox3;
		private System.ComponentModel.IContainer components = null;

		public Series_TextSource()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			int count=0;
			foreach(Steema.TeeChart.Styles.ValueList v in bar1.ValuesLists) {
				textSource1.Fields.Add(count, v.Name);
				++count;
			}
			textSource1.Fields.Add(count, "text");
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textSource1 = new Steema.TeeChart.Data.TextSource();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.tChart1 = new Steema.TeeChart.TChart();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The Series TextSource component is used to fill a Series with points\r\ncoming from" +
				" text.  Text can be loaded from Strings, File or Web URL address.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Name = "panel1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tChart1);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Name = "panel2";
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.textBox2.Location = new System.Drawing.Point(0, 0);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(112, 154);
			this.textBox2.TabIndex = 0;
			this.textBox2.Text = "This memo contains series points\r\n( format is X,Y,Text )\r\n1,123,A\r\n2,456,B\r\n3,321" +
				",C\r\n4,222,D\r\n5,90,E\r\n6,111,F\r\n7,-10,G";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 11);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Fill Series !";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textSource1
			// 
			this.textSource1.DecimalSeparator = ',';
			this.textSource1.HeaderLines = 2;
			this.textSource1.Series = this.bar1;
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(165)), ((System.Byte)(255)));
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Brush
			// 
			// 
			// bar1.Marks.Gradient
			// 
			this.bar1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
			this.bar1.Marks.Brush.Gradient.Visible = true;
			// 
			// bar1.Marks.Font
			// 
			this.bar1.Marks.Font.Name = "Lucida Console";
			// 
			// bar1.Marks.Gradient
			// 
			this.bar1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			this.bar1.Marks.Gradient.Visible = true;
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
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
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.ThemeIndex = 4;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
			this.tChart1.Axes.Bottom.Grid.Visible = false;
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Bottom.MinorTicks
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.Ticks.Length = 0;
			// 
			// tChart1.Axes.Bottom.TicksInner
			// 
			this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			this.tChart1.Axes.Depth.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Depth.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Depth.MinorTicks
			// 
			this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Ticks.Length = 0;
			// 
			// tChart1.Axes.Depth.TicksInner
			// 
			this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			this.tChart1.Axes.Left.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Left.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Left.MinorTicks
			// 
			this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.Ticks.Length = 0;
			// 
			// tChart1.Axes.Left.TicksInner
			// 
			this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			this.tChart1.Axes.Right.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Right.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Right.MinorTicks
			// 
			this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Ticks.Length = 0;
			// 
			// tChart1.Axes.Right.TicksInner
			// 
			this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			this.tChart1.Axes.Top.Grid.Visible = false;
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			this.tChart1.Axes.Top.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Top.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Top.MinorTicks
			// 
			this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Ticks.Length = 0;
			// 
			// tChart1.Axes.Top.TicksInner
			// 
			this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.TicksInner.Length = 6;
			this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Header.Font.Name = "Lucida Console";
			this.tChart1.Header.Font.Size = 10;
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Legend.Font
			// 
			this.tChart1.Legend.Font.Name = "Lucida Console";
			this.tChart1.Legend.Font.Size = 9;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			// 
			// tChart1.Legend.Symbol
			// 
			// 
			// tChart1.Legend.Symbol.Pen
			// 
			this.tChart1.Legend.Symbol.Pen.Visible = false;
			this.tChart1.Legend.Transparent = true;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(112, 0);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
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
			// tChart1.Panel.Pen
			// 
			this.tChart1.Panel.Pen.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			// 
			// tChart1.Panel.Shadow.Brush
			// 
			this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Visible = true;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Size = new System.Drawing.Size(314, 154);
			this.tChart1.TabIndex = 1;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(122)), ((System.Byte)(41)));
			this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(122)), ((System.Byte)(41)));
			this.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(254)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(47)), ((System.Byte)(133)), ((System.Byte)(253)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(254)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(47)), ((System.Byte)(133)), ((System.Byte)(253)));
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(36)), ((System.Byte)(209)), ((System.Byte)(252)));
			this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(13)), ((System.Byte)(188)), ((System.Byte)(124)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(36)), ((System.Byte)(209)), ((System.Byte)(252)));
			this.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(13)), ((System.Byte)(188)), ((System.Byte)(124)));
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(105, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Fill From Internet:";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(224, 16);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(176, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "http://www.steema.com/demo.txt";
			// 
			// SeriesTextSource
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(426, 258);
			this.Name = "SeriesTextSource";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		protected virtual void button1_Click(object sender, System.EventArgs e) {
			bar1.Clear();
			textSource1.LoadFromStrings(textBox2.Lines);
		}

		protected virtual void button2_Click(object sender, System.EventArgs e) {
			bar1.Clear();
			textSource1.LoadFromURL(textBox3.Text);
		}
	}
}

