using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Surface : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Surface surfaceSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Timer timer1;
		private Steema.TeeChart.Tools.Rotate rotate1;
		private System.ComponentModel.IContainer components = null;
		private Steema.TeeChart.Tools.GridBand gridBand1;

		Random r;
		public SeriesType_Surface()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			r = new Random();
			surfaceSeries1.FillSampleValues(30);
			this.numericUpDown1.Value = 1;
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
			this.components = new System.ComponentModel.Container();
			this.surfaceSeries1 = new Steema.TeeChart.Styles.Surface();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(399, 56);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Surface displays a grid of XYZ floating point values.\r\nOptions include palette, b" +
				"order, pattern, null values, wire-frame, dots, surface sides, marks, gradients, " +
				"inverted axes, etc.\r\n\r\nThings to try: Click and drag mouse to rotate chart.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(399, 35);
			this.panel1.TabIndex = 1;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 90;
			this.tChart1.Aspect.Elevation = 348;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 62;
			this.tChart1.Aspect.Rotation = 329;
			
			
			this.tChart1.Aspect.VertOffset = -20;
			this.tChart1.Aspect.Zoom = 66;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.ZPosition = 0;
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Labels.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font.Shadow
			// 
			this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title.Shadow
			// 
			this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.ZPosition = 0;
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Labels.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Title
			// 
			// 
			// tChart1.Axes.Depth.Title.Font
			// 
			// 
			// tChart1.Axes.Depth.Title.Font.Shadow
			// 
			this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Title.Shadow
			// 
			this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
			this.tChart1.Axes.Depth.Visible = true;
			// 
			// tChart1.Axes.DepthTop
			// 
			// 
			// tChart1.Axes.DepthTop.Grid
			// 
			this.tChart1.Axes.DepthTop.Grid.ZPosition = 0;
			// 
			// tChart1.Axes.DepthTop.Labels
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Font
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Font.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Labels.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Title
			// 
			// 
			// tChart1.Axes.DepthTop.Title.Font
			// 
			// 
			// tChart1.Axes.DepthTop.Title.Font.Shadow
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Title.Shadow
			// 
			this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.ZPosition = 0;
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			// 
			// tChart1.Axes.Left.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Labels.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Title
			// 
			// 
			// tChart1.Axes.Left.Title.Font
			// 
			// 
			// tChart1.Axes.Left.Title.Font.Shadow
			// 
			this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Title.Shadow
			// 
			this.tChart1.Axes.Left.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.ZPosition = 0;
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			// 
			// tChart1.Axes.Right.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Labels.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Title
			// 
			// 
			// tChart1.Axes.Right.Title.Font
			// 
			// 
			// tChart1.Axes.Right.Title.Font.Shadow
			// 
			this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Title.Shadow
			// 
			this.tChart1.Axes.Right.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.ZPosition = 0;
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			// 
			// tChart1.Axes.Top.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Labels.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Title
			// 
			// 
			// tChart1.Axes.Top.Title.Font
			// 
			// 
			// tChart1.Axes.Top.Title.Font.Shadow
			// 
			this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Title.Shadow
			// 
			this.tChart1.Axes.Top.Title.Shadow.Visible = false;
			// 
			// tChart1.Footer
			// 
			// 
			// tChart1.Footer.Font
			// 
			// 
			// tChart1.Footer.Font.Shadow
			// 
			this.tChart1.Footer.Font.Shadow.Visible = false;
			// 
			// tChart1.Footer.Shadow
			// 
			this.tChart1.Footer.Shadow.Visible = false;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Shadow
			// 
			this.tChart1.Header.Font.Shadow.Visible = false;
			this.tChart1.Header.Lines = new string[] {
														 "tChart1"};
			// 
			// tChart1.Header.Shadow
			// 
			this.tChart1.Header.Shadow.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Shadow
			// 
			this.tChart1.Legend.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Title
			// 
			// 
			// tChart1.Legend.Title.Font
			// 
			this.tChart1.Legend.Title.Font.Bold = true;
			// 
			// tChart1.Legend.Title.Font.Shadow
			// 
			this.tChart1.Legend.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Title.Pen
			// 
			this.tChart1.Legend.Title.Pen.Visible = false;
			// 
			// tChart1.Legend.Title.Shadow
			// 
			this.tChart1.Legend.Title.Shadow.Visible = false;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 91);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Visible = false;
			this.tChart1.Series.Add(this.surfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(399, 165);
			// 
			// tChart1.SubFooter
			// 
			// 
			// tChart1.SubFooter.Font
			// 
			// 
			// tChart1.SubFooter.Font.Shadow
			// 
			this.tChart1.SubFooter.Font.Shadow.Visible = false;
			// 
			// tChart1.SubFooter.Shadow
			// 
			this.tChart1.SubFooter.Shadow.Visible = false;
			// 
			// tChart1.SubHeader
			// 
			// 
			// tChart1.SubHeader.Font
			// 
			// 
			// tChart1.SubHeader.Font.Shadow
			// 
			this.tChart1.SubHeader.Font.Shadow.Visible = false;
			// 
			// tChart1.SubHeader.Shadow
			// 
			this.tChart1.SubHeader.Shadow.Visible = false;
			this.tChart1.TabIndex = 2;
			this.tChart1.Tools.Add(this.rotate1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.AutoHide = false;
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			// 
			// tChart1.Walls.Back.Shadow
			// 
			this.tChart1.Walls.Back.Shadow.Visible = false;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.AutoHide = false;
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			// 
			// tChart1.Walls.Bottom.Shadow
			// 
			this.tChart1.Walls.Bottom.Shadow.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.AutoHide = false;
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			// 
			// tChart1.Walls.Left.Shadow
			// 
			this.tChart1.Walls.Left.Shadow.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.AutoHide = false;
			// 
			// tChart1.Walls.Right.Shadow
			// 
			this.tChart1.Walls.Right.Shadow.Visible = false;
			// 
			// surfaceSeries1
			// 
			// 
			// surfaceSeries1.Brush
			// 
			this.surfaceSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// surfaceSeries1.Marks
			// 
			// 
			// surfaceSeries1.Marks.Callout
			// 
			this.surfaceSeries1.Marks.Callout.Arrow = this.surfaceSeries1.Marks.Arrow;
			this.surfaceSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.surfaceSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// surfaceSeries1.Marks.Callout.Brush
			// 
			this.surfaceSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.surfaceSeries1.Marks.Callout.Distance = 0;
			this.surfaceSeries1.Marks.Callout.Draw3D = false;
			this.surfaceSeries1.Marks.Callout.Length = 10;
			this.surfaceSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// surfaceSeries1.Marks.Font
			// 
			// 
			// surfaceSeries1.Marks.Font.Shadow
			// 
			this.surfaceSeries1.Marks.Font.Shadow.Visible = false;
			this.surfaceSeries1.NumXValues = 25;
			this.surfaceSeries1.NumZValues = 25;
			this.surfaceSeries1.PaletteMin = 0;
			this.surfaceSeries1.PaletteStep = 0;
			this.surfaceSeries1.Title = "surface1";
			// 
			// surfaceSeries1.XValues
			// 
			this.surfaceSeries1.XValues.DataMember = "X";
			// 
			// surfaceSeries1.YValues
			// 
			this.surfaceSeries1.YValues.DataMember = "Y";
			// 
			// surfaceSeries1.ZValues
			// 
			this.surfaceSeries1.ZValues.DataMember = "Z";
			this.surfaceSeries1.GetYValue += new Steema.TeeChart.Styles.Custom3DGrid.GetYValueEventHandler(this.surfaceSeries1_GetYValue);
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(8, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Animate";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(175, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "&Style :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "Single Color",
														   "Color Range",
														   "Color Palette",
														   "Strong Palette",
														   "Gray scale",
														   "Inverted Gray",
														   "Rainbow"});
			this.comboBox1.Location = new System.Drawing.Point(78, 7);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(88, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
														   "Solid and Grid",
														   "Solid",
														   "Wireframe",
														   "Dots"});
			this.comboBox2.Location = new System.Drawing.Point(212, 7);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(73, 21);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(295, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Sample:";
			this.label2.UseMnemonic = false;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(348, 8);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   8,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ReadOnly = true;
			this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Surface
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(399, 256);
			this.Name = "SeriesType_Surface";
			this.Load += new System.EventHandler(this.SeriesType_Surface_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();

		}
		#endregion

		private void SeriesType_Surface_Load(object sender, System.EventArgs e)
		{
			comboBox1.SelectedIndex = 3;
			comboBox2.SelectedIndex = 0;
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox2.SelectedIndex)
			{
				case 0 : 
				{
					surfaceSeries1.WireFrame = false; 
					surfaceSeries1.DotFrame = false; 
					surfaceSeries1.Pen.Visible = true;
					break;
				}
				case 1 : 
				{
					surfaceSeries1.WireFrame = false; 
					surfaceSeries1.DotFrame = false; 
					surfaceSeries1.Pen.Visible = false;
					break;
				}
				case 2 : 
				{
					surfaceSeries1.WireFrame = true; 
					surfaceSeries1.Pen.Visible = true;
					break;
				}
				case 3 : surfaceSeries1.DotFrame = true; break;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : 
				{	
					surfaceSeries1.UseColorRange = false;
					surfaceSeries1.UsePalette = false;
					break;
				}
				case 1 : 
				{
					surfaceSeries1.UseColorRange = true;
					surfaceSeries1.UsePalette = false;
					break;
				}
				case 2 : 
				{
					surfaceSeries1.UseColorRange = false;
					surfaceSeries1.UsePalette = true;
					surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
					break;
				}
				case 3 : 
				{
					surfaceSeries1.UseColorRange = false;
					surfaceSeries1.UsePalette = true;
					surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong;
					break;
				}
				case 4 : 
				{
					surfaceSeries1.UseColorRange = false;
					surfaceSeries1.UsePalette = true;
					surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.GrayScale;
					break;
				}
				case 5 : 
				{
					surfaceSeries1.UseColorRange = false;
					surfaceSeries1.UsePalette = true;
					surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.InvertedGray;
					break;
				}
				case 6 : 
				{
					surfaceSeries1.UseColorRange = false;
					surfaceSeries1.UsePalette = true;
					surfaceSeries1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Rainbow;
					break;
				}
			}
		}

		private void surfaceSeries1_GetYValue(Steema.TeeChart.Styles.Series sender, Steema.TeeChart.Styles.Custom3DGrid.GetYValueEventArgs e)
		{
			double piPortion = Math.PI / this.surfaceSeries1.NumXValues;
			const double halfPI = Math.PI*0.5;
			double tmpX = e.X * piPortion;
			double tmpZ = e.Z * piPortion;
			// sample surfaces...
			switch ((int)this.numericUpDown1.Value)
			{
				case 1: e.Value =0.5*Math.Pow(Math.Cos(e.X/(this.surfaceSeries1.NumXValues*0.2)),2)+
							Math.Pow(Math.Cos(e.Z/(this.surfaceSeries1.NumXValues*0.2)),2)-
							Math.Cos(e.Z/(this.surfaceSeries1.NumXValues*0.5)); break;
				case 2: e.Value =  Math.Pow(Math.Cos(tmpX),2) * Math.Pow(Math.Sin(tmpZ),2); break;
				case 3: e.Value = Math.Cos(tmpX*tmpX)+Math.Sin(tmpZ*tmpZ); break;
				case 4: e.Value = Math.Pow(Math.Cos(tmpX),2)+Math.Pow(Math.Sin(tmpZ),2); break;
				case 5: e.Value = -tmpX+Math.Pow(tmpZ,2)*Math.Sin(tmpX*tmpZ); break;
				case 6: e.Value = Math.Sqrt(tmpX * tmpX + tmpZ * tmpZ); break;
				case 7: e.Value = Math.Cos(Math.Abs(tmpX-halfPI))*Math.Sin(tmpZ); break;
				case 8: e.Value = Math.Cos(Math.Abs(tmpX-halfPI)*Math.Abs(tmpZ-halfPI)); break;
			}
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.surfaceSeries1.Clear();
			this.surfaceSeries1.CreateValues(this.surfaceSeries1.NumXValues,this.surfaceSeries1.NumZValues);
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.timer1.Stop();  // stop animation timer
			
			// Invert Left axis randomly
			if (r.Next(100)<2) this.tChart1.Axes.Left.Inverted = ! this.tChart1.Axes.Left.Inverted;
			// Invert Bottom axis randomly
			if (r.Next(100)<2) this.tChart1.Axes.Bottom.Inverted = ! this.tChart1.Axes.Bottom.Inverted;
			// Invert Depth axis randomly
			if (r.Next(100)<2) this.tChart1.Axes.Depth.Inverted = ! this.tChart1.Axes.Depth.Inverted;

			// Change Color Mode (Single, Range, Palette or Grayscale) randomly
			if (r.Next(100)<2)
			{
				if (this.comboBox1.SelectedIndex < this.comboBox1.Items.Count-2)
					this.comboBox1.SelectedIndex += 1;
				else this.comboBox1.SelectedIndex = 0;
				this.comboBox1_SelectedIndexChanged(this.comboBox1,new System.EventArgs());
			}

  			// Change Surface Example:
			if (this.numericUpDown1.Value < this.numericUpDown1.Maximum) this.numericUpDown1.Value += 1;
			else this.numericUpDown1.Value = this.numericUpDown1.Minimum;

			this.timer1.Start();  //  re-start animation timer

		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.timer1.Enabled = this.checkBox1.Checked;
		}
	}
}

