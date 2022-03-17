using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class MarksSymbols : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar bar1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public MarksSymbols()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bar1.FillSampleValues();
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
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Series marks can display symbols next to each mark.\r\n\r\nbar1.Marks.Symbols.Visible" +
				" = true ;\r\n\r\nThe symbol color is the same as in the chart legend.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.ThemeIndex = 5;
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
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Header.Brush.Gradient.Visible = true;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Header.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Header.Gradient.Visible = true;
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Legend.Brush.Gradient.Transparency = 80;
			this.tChart1.Legend.Brush.Gradient.Visible = true;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Legend.Gradient.Transparency = 80;
			this.tChart1.Legend.Gradient.Visible = true;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			this.tChart1.Panel.BorderRound = 10;
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.DarkGray;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.DarkGray;
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Pen
			// 
			this.tChart1.Panel.Pen.Color = System.Drawing.Color.Navy;
			this.tChart1.Panel.Pen.Visible = true;
			this.tChart1.Panel.Pen.Width = 6;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.bar1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Walls.Left.Size = 5;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver;
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.Red;
			this.bar1.ColorEach = true;
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
			// bar1.Marks.Gradient
			// 
			this.bar1.Marks.Gradient.StartColor = System.Drawing.Color.Silver;
			this.bar1.Marks.Gradient.Visible = true;
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Brush
			// 
			this.bar1.Marks.Symbol.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(153)), ((System.Byte)(153)), ((System.Byte)(0)));
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			this.bar1.Marks.Symbol.Visible = true;
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
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "View Symbols";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(184, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Edit Symbols...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MarksSymbols
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "MarksSymbols";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			bar1.Marks.Symbol.Visible = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Editors.MarkSymbolEditor marksSymbol = new Steema.TeeChart.Editors.MarkSymbolEditor(tChart1[0].Marks.Symbol);
      Steema.TeeChart.Editors.EditorUtils.Translate(marksSymbol);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(marksSymbol);	
		}
	}
}

