using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart.Themes;

namespace Steema.TeeChart.Samples

{
	public class ChartPalettes : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.ComboBox cbCustom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbDefault;
		private Steema.TeeChart.Styles.Bar bar1;
		private System.ComponentModel.IContainer components = null;
		private Color[] RedPalette;
		private Color[] BluePalette;
		private Color[] GreenPalette;

		public ChartPalettes()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
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
			this.cbCustom = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbDefault = new System.Windows.Forms.ComboBox();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Several pre-defined color palettes can be assigned to each chart.\r\n\r\ntmp.ApplyPal" +
				"ette(tChart1.Chart, cbDefault.SelectedIndex + 1);\r\n\r\nAdditionally, you can set y" +
				"our custom color palettes.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbDefault);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbCustom);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.ThemeIndex = 2;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.AxisPen
			// 
			this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.tChart1.Axes.Bottom.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Centered = true;
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Times New Roman";
			this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Bottom.MinorTicks
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.Ticks.Length = 2;
			// 
			// tChart1.Axes.Bottom.TicksInner
			// 
			this.tChart1.Axes.Bottom.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font
			// 
			this.tChart1.Axes.Bottom.Title.Font.Name = "Times New Roman";
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.AxisPen
			// 
			this.tChart1.Axes.Depth.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			this.tChart1.Axes.Depth.Labels.Font.Name = "Times New Roman";
			this.tChart1.Axes.Depth.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Depth.MinorTicks
			// 
			this.tChart1.Axes.Depth.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			// 
			// tChart1.Axes.Depth.TicksInner
			// 
			this.tChart1.Axes.Depth.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Depth.Title
			// 
			// 
			// tChart1.Axes.Depth.Title.Font
			// 
			this.tChart1.Axes.Depth.Title.Font.Name = "Times New Roman";
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.tChart1.Axes.Left.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			this.tChart1.Axes.Left.Labels.Font.Name = "Times New Roman";
			this.tChart1.Axes.Left.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Left.MinorTicks
			// 
			this.tChart1.Axes.Left.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.Ticks.Length = 2;
			// 
			// tChart1.Axes.Left.TicksInner
			// 
			this.tChart1.Axes.Left.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Left.Title
			// 
			// 
			// tChart1.Axes.Left.Title.Font
			// 
			this.tChart1.Axes.Left.Title.Font.Name = "Times New Roman";
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.AxisPen
			// 
			this.tChart1.Axes.Right.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			this.tChart1.Axes.Right.Labels.Font.Name = "Times New Roman";
			this.tChart1.Axes.Right.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Right.MinorTicks
			// 
			this.tChart1.Axes.Right.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Ticks.Length = 2;
			// 
			// tChart1.Axes.Right.TicksInner
			// 
			this.tChart1.Axes.Right.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Right.Title
			// 
			// 
			// tChart1.Axes.Right.Title.Font
			// 
			this.tChart1.Axes.Right.Title.Font.Name = "Times New Roman";
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.AxisPen
			// 
			this.tChart1.Axes.Top.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			this.tChart1.Axes.Top.Labels.Font.Name = "Times New Roman";
			this.tChart1.Axes.Top.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Top.MinorTicks
			// 
			this.tChart1.Axes.Top.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Ticks.Length = 2;
			// 
			// tChart1.Axes.Top.TicksInner
			// 
			this.tChart1.Axes.Top.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Top.Title
			// 
			// 
			// tChart1.Axes.Top.Title.Font
			// 
			this.tChart1.Axes.Top.Title.Font.Name = "Times New Roman";
			this.tChart1.Axes.Top.Visible = false;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Header.Font.Name = "Times New Roman";
			this.tChart1.Header.Font.Size = 12;
			this.tChart1.Header.Lines = new string[] {
																								 "TChart - Color Palettes"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Font
			// 
			this.tChart1.Legend.Font.Name = "Times New Roman";
			this.tChart1.Legend.Font.Size = 10;
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Shadow.Height = 0;
			this.tChart1.Legend.Shadow.Width = 0;
			// 
			// tChart1.Legend.Symbol
			// 
			this.tChart1.Legend.Symbol.DefaultPen = false;
			// 
			// tChart1.Legend.Symbol.Pen
			// 
			this.tChart1.Legend.Symbol.Pen.Visible = false;
			this.tChart1.Legend.Transparent = true;
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
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
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
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.bar1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.ApplyDark = false;
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Walls.Back.Size = 8;
			this.tChart1.Walls.Back.Transparent = false;
			this.tChart1.Walls.Back.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.ApplyDark = false;
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(204)), ((System.Byte)(204)), ((System.Byte)(0)));
			this.tChart1.Walls.Bottom.Size = 8;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.ApplyDark = false;
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(206)), ((System.Byte)(206)), ((System.Byte)(0)));
			this.tChart1.Walls.Left.Size = 8;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.ApplyDark = false;
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Walls.Right.Size = 8;
			// 
			// cbCustom
			// 
			this.cbCustom.Items.AddRange(new object[] {
																									"Default TeeChart",
																									"Reds",
																									"Blues",
																									"Greens"});
			this.cbCustom.Location = new System.Drawing.Point(26, 17);
			this.cbCustom.Name = "cbCustom";
			this.cbCustom.Size = new System.Drawing.Size(121, 21);
			this.cbCustom.TabIndex = 0;
			this.cbCustom.SelectedIndexChanged += new System.EventHandler(this.cbCustom_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 11);
			this.label1.TabIndex = 1;
			this.label1.Text = "Custom Palettes:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(159, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 11);
			this.label2.TabIndex = 3;
			this.label2.Text = "Default Palettes:";
			// 
			// cbDefault
			// 
			this.cbDefault.Location = new System.Drawing.Point(161, 15);
			this.cbDefault.Name = "cbDefault";
			this.cbDefault.Size = new System.Drawing.Size(121, 21);
			this.cbDefault.TabIndex = 2;
			this.cbDefault.SelectedIndexChanged += new System.EventHandler(this.cbDefault_SelectedIndexChanged);
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
			// bar1.Marks.Arrow
			// 
			this.bar1.Marks.Arrow.Color = System.Drawing.Color.Black;
			// 
			// bar1.Marks.Font
			// 
			this.bar1.Marks.Font.Name = "Times New Roman";
			this.bar1.Marks.Font.Size = 10;
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			this.bar1.Marks.Transparent = true;
			// 
			// bar1.Pen
			// 
			this.bar1.Pen.Visible = false;
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
			// ChartPalettes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "ChartPalettes";
			this.Leave += new System.EventHandler(this.ChartPalettes_Leave);
			this.Load += new System.EventHandler(this.ChartPalettes_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ChartPalettes_Load(object sender, System.EventArgs e)
		{
			int t;
			bar1.FillSampleValues(15);
			bar1.ColorEach=true;

			cbCustom.SelectedIndex=0;
			cbDefault.Items.Clear();

			
			foreach(string s in Theme.ColorPalettes) 
			{
				cbDefault.Items.Add(s);
			}

			RedPalette = new Color[15];
			for(t=0; t < 15; ++t) RedPalette[t]=Color.FromArgb(128+Convert.ToInt32(Math.Round(t*(128.0/15.0))),0,0);

			BluePalette = new Color[15];
			for(t=0; t < 15; ++t) BluePalette[t]=Color.FromArgb(0,0,128+Convert.ToInt32(Math.Round(t*(128.0/15.0))));

			GreenPalette = new Color[15];
			for(t=0; t < 15; ++t) GreenPalette[t]=Color.FromArgb(0,128+Convert.ToInt32(Math.Round(t*(128.0/15.0))),0);

		}

		private void cbCustom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(cbCustom.SelectedIndex) 
			{
				case 0:
					ColorPalettes.ApplyPalette(tChart1.Chart, Steema.TeeChart.Themes.Theme.OperaPalette);
					tChart1.Refresh();
					break;
				case 1:
					ColorPalettes.ApplyPalette(tChart1.Chart, RedPalette);
					tChart1.Refresh();
					break;
				case 2:
					ColorPalettes.ApplyPalette(tChart1.Chart, BluePalette);
					tChart1.Refresh();
					break;
				case 3:
					ColorPalettes.ApplyPalette(tChart1.Chart, GreenPalette);
					tChart1.Refresh();
					break;

			}
		}

		private void cbDefault_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ColorPalettes.ApplyPalette(tChart1.Chart, cbDefault.SelectedIndex);
		}


		private void ChartPalettes_Leave(object sender, System.EventArgs e)
		{
			ColorPalettes.ApplyPalette(tChart1.Chart, Steema.TeeChart.Themes.Theme.OperaPalette);
		}
	}
}

