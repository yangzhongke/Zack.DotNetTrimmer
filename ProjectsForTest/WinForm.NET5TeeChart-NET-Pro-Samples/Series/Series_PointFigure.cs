using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Series_PointFigure : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.PointFigure pointFigure1;
    private Label label3;
    private Label label2;
    private NumericUpDown numericUpDown1;
    private ComboBox comboBox2;
    private Label label1;
    private ComboBox comboBox1;
    private CheckBox cBoxMarks;
    private CheckBox cboxMonths;
		private System.ComponentModel.IContainer components = null;

		public Series_PointFigure()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

      tChart1.Aspect.View3D = false;
      tChart1.Axes.Left.Grid.Centered = true;
      tChart1.Axes.Bottom.Grid.Centered = true;
      tChart1.Legend.Visible = false;
      tChart1.Axes.Left.Labels.Font.Size = 12;

      tChart1.Axes.Left.Labels.ValueFormat = "0.00";

			//this.pointFigure1.FillSampleValues(30);
      loadDemoData();
			this.pointFigure1.BoxSize = 1;
      this.pointFigure1.ReversalAmount = 2;

      pointFigure1.ShowMonths = true;
      pointFigure1.MonthFont.Color = Color.GreenYellow;
      pointFigure1.Marks.Visible = true;
      pointFigure1.BoxType = Styles.PointFigure.BoxTypes.Standard;
      pointFigure1.PricingMethod = Steema.TeeChart.Styles.PointFigure.PricingMethods.Close;
      comboBox1.SelectedIndex = 1;
      pointFigure1.Period = 14;

      this.pointFigure1.UpSymbol.Pen.Color = Color.White;
      this.pointFigure1.UpSymbol.Pen.Width = 2;
      this.pointFigure1.UpSymbol.Color = Color.White;
      this.pointFigure1.DownSymbol.Pen.Color = Color.White;
      this.pointFigure1.DownSymbol.Pen.Width = 2;
      this.pointFigure1.DownSymbol.VertSize = 3;
      this.pointFigure1.UpSymbol.VertSize = 3;
      this.pointFigure1.DownSymbol.HorizSize = 3;
      this.pointFigure1.UpSymbol.HorizSize = 3;
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
      this.pointFigure1 = new Steema.TeeChart.Styles.PointFigure();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.cBoxMarks = new System.Windows.Forms.CheckBox();
      this.cboxMonths = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(630, 63);
      this.textBox1.Text = "Point & Figure series is a financial chart style. Point & Figure is made of X\'s a" +
    "nd O\'s symbols representing over time filtered price movements.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.numericUpDown1);
      this.panel1.Controls.Add(this.comboBox2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.comboBox1);
      this.panel1.Controls.Add(this.cBoxMarks);
      this.panel1.Controls.Add(this.cboxMonths);
      this.panel1.Location = new System.Drawing.Point(0, 63);
      this.panel1.Size = new System.Drawing.Size(630, 34);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Grid.Centered = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Bottom.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Bottom.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Font.Size = 7;
      this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 7F;
      this.tChart1.Axes.Bottom.Labels.GridIgnoresLabelSize = true;
      this.tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
      this.tChart1.Axes.Bottom.MaximumOffset = 20;
      this.tChart1.Axes.Bottom.MinimumOffset = 20;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Bottom.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Bottom.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Depth.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Depth.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Depth.Labels.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Axes.Depth.Labels.GridIgnoresLabelSize = false;
      this.tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Depth.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Depth.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Depth.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.DepthTop.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Axes.DepthTop.Labels.GridIgnoresLabelSize = false;
      this.tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.DepthTop.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.DepthTop.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.DepthTop.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.Centered = true;
      this.tChart1.Axes.Left.Increment = 1D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Left.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Left.Labels.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Axes.Left.Labels.GridIgnoresLabelSize = true;
      this.tChart1.Axes.Left.MaximumOffset = 20;
      this.tChart1.Axes.Left.MinimumOffset = 20;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Left.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Left.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Right.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Right.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Right.Labels.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Axes.Right.Labels.GridIgnoresLabelSize = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Right.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Right.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Right.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Top.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Top.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Top.Labels.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Axes.Top.Labels.GridIgnoresLabelSize = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Axes.Top.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Top.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Top.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Footer.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Footer.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Footer.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Header.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Header.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Header.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Header.Lines = new string[] {
        "Point and figure chart"};
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Legend.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Legend.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Legend.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Legend.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Legend.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Legend.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Panel.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Panel.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Series.Add(this.pointFigure1);
      this.tChart1.Size = new System.Drawing.Size(630, 296);
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.SubFooter.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.SubFooter.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.SubFooter.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.SubHeader.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.SubHeader.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.SubHeader.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Back.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Back.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Back.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Bottom.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Bottom.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Bottom.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Left.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Left.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Left.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Right.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Right.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Right.Bevel.StringColorTwo = "FF808080";
      // 
      // chartContainer
      // 
      this.chartContainer.Location = new System.Drawing.Point(0, 97);
      this.chartContainer.Size = new System.Drawing.Size(630, 296);
      // 
      // pointFigure1
      // 
      // 
      // 
      // 
      this.pointFigure1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.pointFigure1.CloseValues = this.pointFigure1.YValues;
      this.pointFigure1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.pointFigure1.ColorEach = false;
      this.pointFigure1.DateValues = this.pointFigure1.XValues;
      // 
      // 
      // 
      this.pointFigure1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.pointFigure1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.pointFigure1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.pointFigure1.PricingMethod = Steema.TeeChart.Styles.PointFigure.PricingMethods.HighLow;
      this.pointFigure1.Title = "pointFigure1";
      // 
      // 
      // 
      this.pointFigure1.XValues.DataMember = "Date";
      this.pointFigure1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.pointFigure1.YValues.DataMember = "Close";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(503, 10);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 13);
      this.label3.TabIndex = 18;
      this.label3.Text = "ATR Period:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(363, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 17;
      this.label2.Text = "BoxType:";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(574, 7);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
      this.numericUpDown1.TabIndex = 16;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
      // 
      // comboBox2
      // 
#if VS2005
      this.comboBox2.FormattingEnabled = true;
#endif
      this.comboBox2.Items.AddRange(new object[] {
            "Standard",
            "ATR"});
      this.comboBox2.Location = new System.Drawing.Point(421, 7);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(76, 21);
      this.comboBox2.TabIndex = 15;
      this.comboBox2.Text = "Standard";
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(192, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 14;
      this.label1.Text = "Pricing Method: ";
      // 
      // comboBox1
      // 
#if VS2005
      this.comboBox1.FormattingEnabled = true;
#endif
      this.comboBox1.Items.AddRange(new object[] {
            "HighLow",
            "Close"});
      this.comboBox1.Location = new System.Drawing.Point(282, 7);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(76, 21);
      this.comboBox1.TabIndex = 13;
      this.comboBox1.Text = "HighLow";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // cBoxMarks
      // 
#if VS2005
      this.cBoxMarks.AutoSize = true;
#endif
      this.cBoxMarks.Checked = true;
      this.cBoxMarks.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cBoxMarks.Location = new System.Drawing.Point(106, 10);
      this.cBoxMarks.Name = "cBoxMarks";
      this.cBoxMarks.Size = new System.Drawing.Size(82, 17);
      this.cBoxMarks.TabIndex = 12;
      this.cBoxMarks.Text = "S&howMarks";
#if VS2005
      this.cBoxMarks.UseVisualStyleBackColor = true;
#endif
      this.cBoxMarks.CheckedChanged += new System.EventHandler(this.cBoxMarks_CheckedChanged);
      // 
      // cboxMonths
      // 
#if VS2005
      this.cboxMonths.AutoSize = true;
#endif
      this.cboxMonths.Checked = true;
      this.cboxMonths.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cboxMonths.Location = new System.Drawing.Point(12, 9);
      this.cboxMonths.Name = "cboxMonths";
      this.cboxMonths.Size = new System.Drawing.Size(88, 17);
      this.cboxMonths.TabIndex = 11;
      this.cboxMonths.Text = "&ShowMonths";
#if VS2005
      this.cboxMonths.UseVisualStyleBackColor = true;
#endif
      this.cboxMonths.CheckedChanged += new System.EventHandler(this.cboxMonths_CheckedChanged);
      // 
      // Series_PointFigure
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(630, 393);
      this.Name = "Series_PointFigure";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion

    private void cboxMonths_CheckedChanged(object sender, EventArgs e)
    {
      pointFigure1.ShowMonths = cboxMonths.Checked;
    }

    private void cBoxMarks_CheckedChanged(object sender, EventArgs e)
    {
      pointFigure1.Marks.Visible = cBoxMarks.Checked;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      pointFigure1.PricingMethod = (Steema.TeeChart.Styles.PointFigure.PricingMethods)(comboBox1.SelectedIndex);
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      pointFigure1.BoxType = (Steema.TeeChart.Styles.PointFigure.BoxTypes)(comboBox2.SelectedIndex);

      numericUpDown1.Enabled = comboBox2.SelectedIndex == 1;
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      pointFigure1.Period = (int)numericUpDown1.Value;
    }

    private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
    {
      pointFigure1.Period = (int)numericUpDown1.Value;
    }

    private void loadDemoData()
    {

      double[] pfdata = new double[] {36301,8700,7.5,7.5,7.42,7.5,
                                      36302,46100,7.5,7.5,7.3,7.37,
                                      36305,46100,7.5,7.5,7.3,7.37,
                                      36306,46100,7.5,7.5,7.3,7.37,
                                      36307,52200,7.25,7.5,6.75,6.88,
                                      36308,20700,7,7.12,6.88,6.88,
                                      36309,49500,7,7.22,6.94,7.03,
                                      36312,8200,7,7,6.88,6.88,
                                      36313,29200,7,7.25,6.92,7,
                                      36314,12100,7.06,7.06,6.88,6.88,
                                      36315,26300,7,7,6.75,6.88,
                                      36316,15900,6.81,7,6.81,6.88,
                                      36319,27900,7,7,6.81,6.88,
                                      36320,33600,6.88,7,6.75,6.75,
                                      36321,68800,7.06,7.19,6.88,6.88,
                                      36322,110200,7,7.81,7,7.37,
                                      36323,59000,7.5,7.88,7.19,7.25,
                                      36326,52000,7.5,7.67,7.25,7.42,
                                      36327,61800,7.42,7.63,6.92,7,
                                      36328,32700,7.37,7.37,6.94,7,
                                      36329,20900,7.06,7.19,6.94,6.94,
                                      36330,17500,7.12,7.12,6.94,7,
                                      36333,21600,6.88,7.06,6.88,6.88,
                                      36334,25700,7,7,6.81,6.88,
                                      36335,11200,6.88,6.88,6.69,6.88,
                                      36336,6900,6.88,6.88,6.75,6.81,
                                      36337,32600,6.88,6.88,6.67,6.67,
                                      36340,18900,6.88,6.88,6.67,6.67,
                                      36341,9300,6.62,6.62,6.19,6.38,
                                      36342,19400,6.5,6.88,6.38,6.44,
                                      36343,25400,6.55,6.55,6.38,6.38,
                                      36344,25400,6.55,6.55,6.38,6.38,
                                      36347,23600,6.42,6.42,6,6,
                                      36348,16500,5.94,6,5.5,5.81,
                                      36349,16800,5.81,5.87,5.75,5.75,
                                      36350,4800,5.87,5.94,5.81,5.81,
                                      36351,10200,6,6,5.75,5.75,
                                      36354,19400,5.81,6.13,5.81,6.06,
                                      36355,6400,6.06,6.5,6,6,
                                      36356,65000,6.34,7,6.34,7,
                                      36357,22700,7,7.12,6.75,6.75,
                                      36358,17100,7,7,6.38,6.75,
                                      36361,5900,6.38,6.75,6.38,6.5,
                                      36362,2300,6.5,6.5,6.5,6.5,
                                      36363,1600,6.5,6.62,6.5,6.62,
                                      36364,12000,6.75,6.75,6.5,6.5,
                                      36365,11800,6.69,6.69,6.5,6.5,
                                      36368,3400,6.3,6.62,6.3,6.38,
                                      36369,19500,6.44,6.5,6.13,6.31,
                                      36370,2800,6.13,6.31,6.13,6.13,
                                      36371,7600,6.06,6.19,5.75,5.75,
                                      36372,37200,5.8,6.13,5.38,5.62,
                                      36375,26000,5.69,5.75,5.5,5.62,
                                      36376,18200,5.5,5.62,5.25,5.25,
                                      36377,5800,5.5,5.5,5.03,5.25,
                                      36378,36900,5,5,4.12,4.37,
                                      36379,41500,4.37,4.37,3.62,4.12,
                                      36382,20600,4.25,4.5,3.94,4.5,
                                      36383,7400,4.5,4.5,4.41,4.44,
                                      36384,17000,4.63,4.63,4.31,4.37,
                                      36385,5200,4.5,4.5,4.37,4.5,
                                      36386,7600,4.5,4.63,4.25,4.25,
                                      36389,23900,4.5,4.63,4.37,4.37,
                                      36390,22600,4.37,4.75,4.37,4.75,
                                      36391,5000,4.75,4.75,4.44,4.63,
                                      36392,18000,4.63,5.12,4.44,4.88,
                                      36393,134700,5.25,6.05,5,5.75,
                                      36396,79500,5.75,6.25,5.75,6.13,
                                      36397,52200,6.25,6.25,6.06,6.06,
                                      36398,25300,6.06,6.25,5.5,5.5,
                                      36399,46400,5.62,5.62,4.63,4.88,
                                      36400,66200,4.63,4.63,3.88,4.42,
                                      36403,7500,4.22,4.44,4.19,4.19,
                                      36404,78300,4.17,4.37,3.75,3.95,
                                      36405,21900,3.97,4.44,3.97,4.44,
                                      36406,10300,4.5,4.5,4.12,4.12,
                                      36407,23800,4.25,4.63,4.25,4.5,
                                      36410,23800,4.25,4.63,4.25,4.5,
                                      36411,11800,4.31,4.5,4.31,4.5,
                                      36412,54400,4.44,4.69,4.44,4.5,
                                      36413,8100,4.25,4.37,4.25,4.25,
                                      36414,2500,4.25,4.25,4.25,4.25,
                                      36417,500,4.25,4.25,4.25,4.25,
                                      36418,10500,4.44,4.44,4.19,4.19,
                                      36419,15700,4.25,4.5,4.25,4.5,
                                      36420,2400,4.44,4.44,4.44,4.44,
                                      36421,3000,4.5,4.56,4.37,4.37,
                                      36424,6300,4.25,4.39,4.25,4.25,
                                      36425,7500,4.25,4.5,4.25,4.37,
                                      36426,16300,4.19,4.19,3.75,4,
                                      36427,2300,3.97,3.97,3.97,3.97,
                                      36428,10300,3.69,3.75,3.38,3.5,
                                      36431,37700,3.5,3.56,3,3.5,
                                      36432,6600,3.25,3.62,3.25,3.5,
                                      36433,12100,3.5,3.62,3.38,3.5,
                                      36434,37000,3.25,3.5,3.25,3.5,
                                      36435,10900,3.44,3.5,3.44,3.5,
                                      36438,300,3.44,3.56,3.44,3.56,
                                      36439,20600,3.56,3.56,3.25,3.5,
                                      36440,700,3.38,3.38,3.38,3.38,
                                      36441,6800,3.38,3.38,3,3.13,
                                      36442,14300,3.25,3.56,3.25,3.56,
                                      36445,500,3.31,3.38,3.31,3.38,
                                      36446,10600,3.38,3.38,3.31,3.31,
                                      36447,3000,3.31,3.31,3.06,3.25,
                                      36448,4200,3.06,3.13,2.87,2.87,
                                      36449,13200,2.87,3.38,2.87,3.38,
                                      36452,34200,3.5,3.81,3.38,3.69,
                                      36453,8500,3.62,3.62,3.5,3.56,
                                      36454,8500,3.62,3.62,3.5,3.56,
                                      36455,10700,3.56,3.78,3.56,3.78,
                                      36456,1000,3.56,3.56,3.56,3.56,
                                      36459,7400,3.59,3.81,3.59,3.59,
                                      36460,25000,3.62,3.75,3.44,3.44,
                                      36461,5500,3.44,3.44,3.25,3.25,
                                      36462,9000,3.41,3.44,3.38,3.38,
                                      36463,100,3.44,3.44,3.44,3.44,
                                      36466,17700,3.25,3.28,3,3.09,
                                      36467,25200,2.97,3.28,2.97,3.28,
                                      36468,26000,3.44,3.66,3.44,3.5,
                                      36469,20700,3.44,3.69,3.44,3.5,
                                      36470,16000,3.44,3.5,3.38,3.44,
                                      36473,8000,3.44,3.5,3.38,3.38,
                                      36474,1200,3.38,3.44,3.38,3.44,
                                      36475,2300,3.44,3.44,3.31,3.31,
                                      36476,3400,3.31,3.31,3.31,3.31,
                                      36477,11000,3.25,3.25,3.06,3.25,
                                      36480,3200,3.13,3.13,3.13,3.13,
                                      36481,35800,3.13,3.13,2.53,2.87,
                                      36482,65600,2.62,2.75,2.38,2.69,
                                      36483,44500,2.69,2.69,2.34,2.5,
                                      36484,37600,2.09,2.62,2.09,2.62,
                                      36487,4800,2.44,2.62,2.38,2.56,
                                      36488,35600,2.56,2.91,2.56,2.87,
                                      36489,29400,2.75,3.81,2.75,3.81,
                                      36490,29400,2.75,3.81,2.75,3.81,
                                      36491,129600,3.81,4.06,3.75,4,
                                      36494,50100,4.06,4.06,3.88,4,
                                      36495,14700,4.03,4.03,4,4,
                                      36496,1900,3.88,4,3.88,3.88,
                                      36497,15900,3.81,4,3.38,3.38,
                                      36498,21500,3.44,3.5,3,3,
                                      36501,500,2.94,2.94,2.94,2.94,
                                      36502,3300,2.94,2.94,2.94,2.94,
                                      36503,37800,2.94,3.5,2.94,3,
                                      36504,500,3,3,3,3,
                                      36505,9000,3.19,3.19,3,3,
                                      36508,2000,3,3.06,3,3.06,
                                      36509,500,3,3,3,3,
                                      36510,3900,3.13,3.13,3,3.06,
                                      36511,3500,3.06,3.06,3,3,
                                      36512,400,3.06,3.06,3.06,3.06,
                                      36515,22000,2.97,3,2.97,3,
                                      36516,3500,3,3,2.97,2.97,
                                      36517,16700,2.94,3.06,2.94,3.06,
                                      36518,3200,2.97,3.06,2.97,2.97,
                                      36519,3200,2.97,3.06,2.97,2.97,
                                      36522,14100,2.97,3.06,2.97,3,
                                      36523,14300,3,3.19,3,3.19,
                                      36524,14700,3,3.19,2.94,2.94,
                                      36525,12300,3,3,2.97,2.97,
                                      36526,12300,3,3,2.97,2.97,
                                      36529,14200,3,3.06,2.97,3,
                                      36530,9500,3.06,3.06,3,3.03,
                                      36531,11000,2.97,3,2.97,2.97,
                                      36532,11000,2.97,3,2.97,2.97,
                                      36533,2000,2.97,2.97,2.97,2.97,
                                      36536,11800,3.13,3.13,2.94,3.13,
                                      36537,55700,3.13,4,3.13,3.94,
                                      36538,36600,3.88,4.06,3.88,4.06,
                                      36539,17600,4.06,4.12,3.81,3.81,
                                      36540,122300,3.81,4.5,3.81,4.37,
                                      36543,122300,3.81,4.5,3.81,4.37,
                                      36544,114400,5.25,5.25,4.56,4.69,
                                      36545,100100,5.12,5.62,5.12,5.25,
                                      36546,127400,5.53,5.87,5.38,5.38,
                                      36547,174400,5.5,5.5,4.81,4.81,
                                      36550,16400,4.88,4.94,4.75,4.75,
                                      36551,25800,4.88,4.88,4.63,4.69,
                                      36552,23200,4.69,4.78,4.69,4.69,
                                      36553,42300,4.84,4.84,4.5,4.5,
                                      36554,55500,4.78,4.88,4.47,4.56,
                                      36557,18600,4.75,4.75,4.5,4.5,
                                      36558,15400,4.75,4.75,4.56,4.56,
                                      36559,33800,4.75,4.88,4.69,4.69,
                                      36560,38300,4.84,4.97,4.75,4.75,
                                      36561,78900,4.94,5,4.56,4.56,
                                      36564,39000,4.88,4.88,4.56,4.63,
                                      36565,25600,4.75,4.81,4.72,4.78,
                                      36566,22700,5,5.12,4.81,4.81,
                                      36567,72100,4.94,5,4.81,4.94,
                                      36568,64000,5.12,5.12,5,5,
                                      36571,64000,5.12,5.12,5,5,
                                      36572,40000,5.19,5.5,5.12,5.31,
                                      36573,58000,5.5,5.56,5.19,5.19,
                                      36574,43000,5.44,5.5,5.19,5.25,
                                      36575,23000,5.31,5.31,5.19,5.25,
                                      36578,29100,5.25,5.25,5.19,5.19,
                                      36579,17400,5.19,5.25,5.19,5.19,
                                      36580,21600,5.19,5.25,5.12,5.16,
                                      36581,81200,5.22,5.22,5.16,5.16,
                                      36582,106700,5.22,5.22,4.75,5.03,
                                      36585,20400,4.84,4.84,4.5,4.56,
                                      36586,9900,4.56,4.75,4.56,4.63,
                                      36587,6100,4.63,4.69,4.56,4.56,
                                      36588,28100,4.5,4.56,4.47,4.5,
                                      36589,5500,4.5,4.5,4.47,4.5,
                                      36592,14200,4.5,4.5,4.31,4.37,
                                      36593,12800,4.34,4.37,4.12,4.12,
                                      36594,10000,4.12,4.19,4.12,4.19,
                                      36595,31700,4.12,4.12,3.94,3.94,
                                      36596,1600,4,4,4,4,
                                      36599,3100,3.94,4,3.88,3.88,
                                      36600,3100,3.94,4,3.88,3.88,
                                      36601,36200,4,4.56,4,4.56,
                                      36602,4200,4.5,4.56,4.5,4.5,
                                      36603,10000,4.56,4.56,4.5,4.5,
                                      36606,8400,4.5,4.69,4.44,4.63,
                                      36607,26000,4.44,4.47,4.06,4.12,
                                      36608,17700,4.06,4.25,4.06,4.19,
                                      36609,5300,4.37,4.5,4.31,4.5,
                                      36610,11800,4.69,4.88,4.63,4.88,
                                      36613,20400,5,5.12,4.94,5.03,
                                      36614,21800,5.06,5.06,4.88,4.88,
                                      36615,41400,4.94,5.25,4.94,5,
                                      36616,6500,5.12,5.12,4.88,4.88,
                                      36617,6500,5.12,5.12,4.88,4.88,
                                      36620,11800,4.88,4.88,4.44,4.44,
                                      36621,15500,4.69,4.75,4.63,4.63,
                                      36622,11600,4.63,4.63,4.31,4.31,
                                      36623,15500,4.31,4.37,4.31,4.31,
                                      36624,11800,4.37,4.37,4.25,4.34,
                                      36627,12700,4.37,4.37,4,4,
                                      36628,8600,4.12,4.19,4.06,4.12,
                                      36629,6100,4.12,4.19,4.12,4.12,
                                      36630,32200,4.19,4.19,3.94,3.94,
                                      36631,13100,3.94,4,3.75,3.75,
                                      36634,20800,4,4,3.75,3.88,
                                      36635,16200,4,4,3.75,3.81,
                                      36636,25000,3.97,4.12,3.88,3.88,
                                      36637,11600,4.12,4.12,3.81,3.88,
                                      36638,11100,4.25,4.25,3.88,3.88,
                                      36641,1600,4,4,3.88,3.88,
                                      36642,4300,4,4,3.88,4,
                                      36643,2200,3.88,3.88,3.88,3.88,
                                      36644,14100,4.06,4.06,3.88,4,
                                      36645,24300,3.88,4,3.88,4,
                                      36648,4600,4,4,3.94,3.94,
                                      36649,7000,4,4.25,4,4.25,
                                      36650,26800,4.25,4.25,3.94,4,
                                      36651,14900,4,4,3.97,3.97,
                                      36652,12200,4,4,3.97,3.97,
                                      36655,41400,4.12,4.63,4,4.63,
                                      36656,76100,4.81,5.12,4.44,4.63,
                                      36657,27300,4.75,4.75,4.72,4.72,
                                      36658,500,4.75,4.75,4.47,4.47,
                                      36659,15400,4.75,4.75,4.5,4.59,
                                      36662,16800,4.59,4.63,4.37,4.5,
                                      36663,6000,4.5,4.5,4.28,4.28,
                                      36664,15300,4.12,4.3,4.09,4.12,
                                      36665,10300,4.12,4.19,3.94,4.06,
                                      36666,43000,4,4.12,3.94,4,
                                      36669,33600,4.06,4.06,4,4,
                                      36670,25500,4.12,4.56,3.97,4.5,
                                      36671,33400,4.56,5.06,4.5,4.81,
                                      36672,31400,4.63,5,4.56,4.56,
                                      36673,14300,4.56,4.69,4.5,4.5,
                                      36676,14300,4.56,4.69,4.5,4.5,
                                      36677,60200,4.53,4.53,4.19,4.19,
                                      36678,30600,4.19,4.25,4,4,
                                      36679,59400,4.88,4.94,3.88,4,
                                      36680,12500,4,4.25,3.94,3.94,
                                      36683,27100,4,4.25,3.94,4,
                                      36684,5400,4.16,4.16,3.97,3.97,
                                      36685,1400,3.97,4.03,3.97,4.03,
                                      36686,34100,3.97,4.12,3.97,4.12,
                                      36687,27800,4.03,4.03,3.97,3.97,
                                      36690,200,3.97,3.97,3.97,3.97,
                                      36691,6300,4.03,4.03,4,4,
                                      36692,110500,4.03,4.25,3.84,4.12,
                                      36693,31000,4.25,4.37,4.06,4.06,
                                      36694,38000,4.06,4.25,3.88,3.88,
                                      36697,56300,3.81,3.91,3.81,3.88,
                                      36698,20100,3.94,3.94,3.75,3.75,
                                      36699,20100,3.94,3.94,3.75,3.75,
                                      36700,17100,3.88,3.88,3.62,3.81,
                                      36701,1000,3.88,3.88,3.88,3.88,
                                      36704,69100,3.5,3.7,3.47,3.47,
                                      36705,24500,3.69,3.69,3.19,3.5,
                                      36706,7800,3.38,3.62,3.38,3.62,
                                      36707,4300,3.38,3.62,3.38,3.38,
                                      36708,36300,3.56,3.94,3.44,3.44,
                                      36711,36300,3.56,3.94,3.44,3.44,
                                      36712,3800,3.5,3.75,3.5,3.75,
                                      36713,5700,3.75,3.75,3.56,3.56,
                                      36714,19800,3.56,3.59,3.38,3.5,
                                      36715,9600,3.81,3.81,3.5,3.5,
                                      36718,9500,3.5,3.5,3.44,3.5,
                                      36719,9800,3.44,3.62,3.44,3.5,
                                      36720,9300,3.44,3.62,3.44,3.44,
                                      36721,21800,3.84,3.84,3.44,3.44,
                                      36722,1500,3.56,3.56,3.44,3.44,
                                      36725,10200,3.56,3.56,3.44,3.44,
                                      36726,35300,3.62,3.81,3.44,3.44,
                                      36727,15700,3.44,3.5,3.44,3.5,
                                      36728,30900,3.5,3.5,3.19,3.25,
                                      36729,1600,3.13,3.13,3.13,3.13,
                                      36732,28300,3.25,3.28,3,3.13,
                                      36733,2000,2.94,3,2.94,3,
                                      36734,300,2.94,2.94,2.94,2.94,
                                      36735,11000,3.19,3.28,3,3.25,
                                      36736,9500,3,3.34,3,3.31,
                                      36739,23700,3.25,3.31,3,3.31,
                                      36740,36800,3.13,3.25,2.94,3,
                                      36741,12000,3.13,3.19,3.06,3.19,
                                      36742,28800,3.06,3.31,2.87,3.13,
                                      36743,15400,3.13,3.19,3,3.13,
                                      36746,1800,3,3,3,3,
                                      36747,12500,2.87,3,2.87,2.94,
                                      36748,11300,2.94,3.03,2.94,3,
                                      36749,300,2.94,2.94,2.94,2.94,
                                      36750,4200,3.03,3.09,2.94,3,
                                      36753,4200,3.03,3.09,2.94,3,
                                      36754,10300,2.94,3,2.87,2.94,
                                      36755,6000,2.87,3,2.87,2.94,
                                      36756,2700,2.87,3,2.87,3,
                                      36757,75300,2.94,3.88,2.94,3.38,
                                      36760,55700,3.62,3.69,3.56,3.69,
                                      36761,43500,3.62,3.88,3.44,3.44,
                                      36762,6600,3.88,3.88,3.5,3.5,
                                      36763,3700,3.5,3.5,3.5,3.5,
                                      36764,12200,3.62,3.62,3.25,3.25,
                                      36767,2000,3.25,3.25,3.19,3.25,
                                      36768,2100,3.19,3.19,3,3.19,
                                      36769,8600,3,3,2.94,2.95,
                                      36770,6800,2.94,3,2.94,2.97,
                                      36771,33200,2.97,3,2.97,3,
                                      36774,33200,2.97,3,2.97,3,
                                      36775,36500,3.09,3.09,2.97,3,
                                      36776,3200,3,3,3,3,
                                      36777,12000,2.97,3.09,2.97,3.09,
                                      36778,4800,3.13,3.13,2.97,3.13,
                                      36781,1900,2.97,3.03,2.97,3.03,
                                      36782,4600,2.97,3.13,2.97,3.13,
                                      36783,2800,2.97,3.03,2.97,3.03,
                                      36784,9400,2.97,3.06,2.97,2.97,
                                      36785,10500,2.97,3,2.97,3,
                                      36788,70600,3.06,3.59,3.03,3.53,
                                      36789,27200,3.62,3.88,3.44,3.69,
                                      36790,29900,3.84,3.94,3.56,3.75,
                                      36791,52700,3.81,4,3.56,3.78,
                                      36792,17900,3.78,3.78,3.72,3.72,
                                      36795,27300,3.72,3.75,3.44,3.5,
                                      36796,20800,3.75,3.75,3.56,3.56,
                                      36797,6000,3.59,3.81,3.59,3.62,
                                      36798,10000,3.59,3.69,3.59,3.62,
                                      36799,13000,3.59,3.62,3.59,3.62,
                                      36802,9400,3.62,3.69,3.59,3.69,
                                      36803,5400,3.69,3.69,3.62,3.66,
                                      36804,13700,3.62,3.62,3.59,3.59,
                                      36805,145300,3.59,4.69,3.59,3.75,
                                      36806,80300,4.06,4.63,4.06,4.5,
                                      36809,39600,4.37,4.5,3.94,3.94,
                                      36810,24500,3.94,4.12,3.94,4.12,
                                      36811,43100,3.94,4.12,3.69,3.69,
                                      36812,51300,3.94,4.12,3.62,3.62,
                                      36813,32500,3.62,3.62,3.53,3.53,
                                      36816,9900,3.62,3.62,3.5,3.5,
                                      36817,50400,3.5,3.5,3.38,3.38,
                                      36818,26200,3.25,3.34,3.09,3.09,
                                      36819,6800,3.13,3.13,2.94,3.06,
                                      36820,83100,3.25,3.5,3.06,3.13,
                                      36823,22800,3.25,3.25,3.06,3.13,
                                      36824,25100,3.06,3.38,2.97,3.03,
                                      36825,24500,3.13,3.62,3.03,3.25,
                                      36826,25100,3.25,3.25,3.06,3.13,
                                      36827,64400,3.19,3.5,2.97,2.97,
                                      36830,4600,2.97,3.06,2.97,3.06,
                                      36831,38300,3,3.06,3,3,
                                      36832,17600,3.03,3.03,3,3,
                                      36833,27800,2.98,3.44,2.98,3.44,
                                      36834,44800,3.5,3.56,3.38,3.44,
                                      36837,42900,3.31,3.5,3.13,3.13,
                                      36838,22400,3.13,3.31,3,3,
                                      36839,23000,3,3.03,2.97,2.97,
                                      36840,65200,3.03,3.03,2.97,3,
                                      36841,89500,3.03,3.25,3,3,
                                      36844,18200,3.03,3.25,3.03,3.13,
                                      36845,33900,3.06,3.25,3,3.03,
                                      36846,27400,3.13,3.19,3,3,
                                      36847,66000,3.06,3.06,3,3,
                                      36848,74400,3,3.03,2.87,3,
                                      36851,35900,3,3,2.87,2.94,
                                      36852,38500,3,3,2.94,2.94,
                                      36853,30400,3,3.06,3,3.06,
                                      36854,30400,3,3.06,3,3.06,
                                      36855,99900,3.69,4.12,3.06,3.88,
                                      36858,91600,4.03,4.03,3.94,4,
                                      36859,36000,3.94,4,3.78,3.91,
                                      36860,21100,3.94,4,3.94,4,
                                      36861,57200,4,4.06,3.81,3.81,
                                      36862,57600,4,4.03,3.91,3.91,
                                      36865,32300,4,4,3.88,3.88,
                                      36866,22600,4,4,3.94,3.97,
                                      36867,61000,4.03,4.06,3.84,3.97,
                                      36868,31700,3.94,4.03,3.94,3.94,
                                      36869,25500,4,4,3.94,3.97,
                                      36872,39200,3.97,4,3.97,3.97,
                                      36873,36300,4,4.03,3.94,3.97,
                                      36874,36300,4,4.03,3.94,3.97,
                                      36875,44200,4,4.06,3.97,3.97,
                                      36876,142300,4,4.03,3.97,4.03,
                                      36879,170400,4.03,4.75,4,4.34,
                                      36880,96400,4.5,4.69,4.34,4.34,
                                      36881,161000,4.44,5,4.44,5,
                                      36882,391100,5.03,6.31,5.02,6,
                                      36883,391100,5.03,6.31,5.02,6,
                                      36886,520900,6.41,7.28,6.38,7.25,
                                      36887,499500,7.56,8.75,7.5,8.75,
                                      36888,343700,9,9.25,6.75,8,
                                      36889,106200,8,8.34,7.88,7.88,
                                      36890,23400,7.88,8.25,7.88,7.97,
                                      36893,113900,7.97,8.12,6.75,7.12,
                                      36894,148200,6.5,6.88,6.44,6.62,
                                      36895,146800,7.25,7.63,6.94,7.37,
                                      36896,301300,7.75,8.19,7.44,8,
                                      36897,139700,8.06,8.87,7.88,8.25,
                                      36900,161400,8.69,9,8.5,8.94,
                                      36901,298600,9,9.38,8.87,8.87,
                                      36902,159600,9.19,9.69,9,9.62,
                                      36903,249700,9.62,9.88,9.13,9.56,
                                      36904,174700,9.5,10,8.59,8.94,
                                      36907,174700,9.5,10,8.59,8.94,
                                      36908,136900,8.94,9.5,8.75,9.44,
                                      36909,104000,9.44,9.62,9.13,9.5,
                                      36910,272800,9.62,10.06,9.5,9.94,
                                      36911,418900,9.94,12.06,9.94,11.62,
                                      36914,367500,12.03,16.25,12.03,14.44,
                                      36915,249200,14.38,15,12.62,12.88,
                                      36916,272600,13.5,13.56,11.38,11.75,
                                      36917,193700,12.13,12.62,11.19,11.25,
                                      36918,209800,11.81,12.56,11.25,11.62,
                                      36921,117200,11.75,12.5,11.62,12.5,
                                      36922,75400,12.5,13.25,12.38,13.25,
                                      36923,148700,13.88,14.81,13.37,14.81,
                                      36924,231300,14.94,15.13,14.12,14.38,
                                      36925,287200,14.87,15.56,14.72,14.87,
                                      36928,307600,15.5,16,13.37,13.37,
                                      36929,264200,14.87,15.25,14.12,14.25,
                                      36930,212500,15.13,15.13,14.06,14.25,
                                      36931,232400,14.94,15.13,14.5,14.87,
                                      36932,167900,14.94,15.13,14.87,14.97,
                                      36935,285900,15.25,15.88,14.94,15.88,
                                      36936,421500,16.12,19.5,16.06,19.5,
                                      36937,478500,21,24,20,22.5,
                                      36938,415800,25,25.25,23,25,
                                      36939,430700,26,26,19.88,20.81,
                                      36942,430700,26,26,19.88,20.81,
                                      36943,307100,24.94,25,21.5,23,
                                      36944,307100,24.94,25,21.5,23,
                                      36945,223300,24.5,24.81,23,23,
                                      36946,179500,23.56,25.25,23.06,24.5,
                                      36949,105400,24.25,25,23.38,24,
                                      36950,117000,24,24,22.88,23.06,
                                      36951,185600,23,23.5,19.12,19.19,
                                      36952,194900,19.75,23,19.5,22.5,
                                      36953,173200,23.5,24.13,23,23.94,
                                      36956,80700,24.13,25,23.94,24.25,
                                      36957,80300,25.12,25.12,23.75,23.75,
                                      36958,82800,24.13,24.13,22.5,23,
                                      36959,86300,24,24,22.88,22.88,
                                      36960,45700,24,24.5,23.12,23.38,
                                      36963,108400,23.38,23.62,22.88,23,
                                      36964,101300,22,23.62,22,22.88,
                                      36965,78900,23.06,23.25,22.63,22.63,
                                      36966,100600,23.06,24,22.19,22.25,
                                      36967,75500,23,23.5,22,22,
                                      36970,64000,23,23,21.88,21.88,
                                      36971,82500,22.37,22.37,20.25,20.5,
                                      36972,82400,21.25,21.25,19,19.5,
                                      36973,96500,19.75,20.25,19,19.25,
                                      36974,120900,20,20.38,19,20.12,
                                      36977,76900,20.38,21.5,20,21,
                                      36978,96300,22.25,22.25,21,21.62,
                                      36979,161800,22.12,24.06,22,24,
                                      36980,318300,24.25,25.06,24,24.5,
                                      36981,213000,23.5,24.5,20,20.75,
                                      36984,157300,20.94,21.5,17.75,18,
                                      36985,191500,18,18,13,14,
                                      36986,121100,15.5,17.5,14,17.25,
                                      36987,226600,19.12,20,18.25,19.37,
                                      36988,106000,19.75,20.62,19,19.31,
                                      36991,155900,19.5,19.5,15.25,15.5,
                                      36992,55000,16.12,16.63,15,16.5,
                                      36993,296600,16.12,16.37,11,11.62,
                                      36994,170500,14.12,16.31,13.94,14.62,
                                      36995,358400,14.25,16.25,11.31,11.75,
                                      36998,144600,11,15.69,11,14.5,
                                      36999,164500,14.94,15.44,14.12,14.25,
                                      37000,93900,14.94,15.62,13,13,
                                      37001,51400,13.75,13.75,12.25,12.94,
                                      37002,51400,13.75,13.75,12.25,12.94,
                                      37005,29200,12.84,12.94,12,12.94,
                                      37006,8600,12.84,13,12.84,12.88,
                                      37007,20100,13,13.25,12.75,12.75,
                                      37008,73800,13.56,14.56,13.25,13.5,
                                      37009,17900,13.5,14.62,13.5,14.12,
                                      37012,8900,14.12,14.25,13.75,13.94,
                                      37013,21600,13.94,14,13.56,13.56,
                                      37014,15800,13.5,13.75,13.12,13.12,
                                      37015,34600,13.28,13.28,12.06,12.25,
                                      37016,51400,12.13,12.5,11.62,11.75,
                                      37019,53700,12.03,12.13,11.75,12,
                                      37020,31400,12.13,13,11.87,11.87,
                                      37021,99800,12.13,12.13,10.81,10.81,
                                      37022,38900,11.12,11.12,10.63,10.63,
                                      37023,29500,10.75,11,10.69,10.94,
                                      37026,17500,10.88,10.88,10.63,10.75,
                                      37027,82100,10.81,11.56,10.75,11.06,
                                      37028,40000,11.12,11.87,10.94,11.75,
                                      37029,25000,11.81,11.87,11.12,11.38,
                                      37030,46400,10.75,10.94,10.5,10.91,
                                      37033,29700,10.88,10.88,10.25,10.31,
                                      37034,5300,10.25,10.44,10.25,10.44,
                                      37035,34900,10.31,10.31,10,10,
                                      37036,30600,10.25,10.5,10,10.5,
                                      37037,138100,10.56,12.38,10.56,12.25,
                                      37040,138100,10.56,12.38,10.56,12.25,
                                      37041,25300,11.5,12.25,11.25,11.62,
                                      37042,61200,12,13.25,12,12.44,
                                      37043,5900,12.38,12.38,12,12.06,
                                      37044,5900,12.38,12.38,12,12.06,
                                      37047,49400,13.38,13.62,12.75,12.81,
                                      37048,55600,12.88,13.12,12.19,12.38,
                                      37049,21300,12.5,12.5,11.62,11.94,
                                      37050,14700,12.12,12.25,11.75,12.12,
                                      37051,14700,12.12,12.25,11.75,12.12,
                                      37054,15000,12.12,12.5,12,12.25,
                                      37055,6400,12.25,12.5,12.25,12.25,
                                      37056,24600,12.06,12.25,12.06,12.12,
                                      37057,47800,12.06,12.12,10.88,10.94,
                                      37058,13300,10.88,11.5,10.88,11.38,
                                      37061,13000,11.25,11.75,11.12,11.44,
                                      37062,27400,11.5,11.94,11.5,11.94,
                                      37063,19300,11.75,11.88,11.25,11.38,
                                      37064,29000,11.5,11.5,11.25,11.38,
                                      37065,21700,11.25,12,11.25,12,
                                      37068,41600,11.25,11.88,11.25,11.69,
                                      37069,29000,11.62,11.94,11.56,11.69,
                                      37070,94500,11.69,13.38,11.5,13.25,
                                      37071,129300,13.38,13.75,12.88,13.75,
                                      37072,414400,13.56,14.12,13.56,13.69,
                                      37075,49100,13.28,13.75,12.88,13.62,
                                      37076,49100,13.28,13.75,12.88,13.62,
                                      37077,52800,12.97,13.62,12.75,13.62,
                                      37078,74500,13.44,14.12,13.19,14,
                                      37079,49200,13.88,14,13.25,13.25,
                                      37082,65600,13.19,13.5,12.62,13,
                                      37083,48000,13,13.88,13,13.25,
                                      37084,30100,13.34,13.44,13,13.12,
                                      37085,88100,13.16,13.16,11.75,12.5,
                                      37086,70600,12.44,12.56,12,12.19,
                                      37089,33300,12.31,13.5,12,13.5,
                                      37090,49200,13.41,13.44,12.69,12.75,
                                      37091,55900,12.88,12.88,12.44,12.62,
                                      37092,55900,12.88,12.88,12.44,12.62,
                                      37093,77100,12.81,13,12.56,12.62,
                                      37096,45600,13.25,13.5,12.62,12.62,
                                      37097,33500,13,13,12,12.75,
                                      37098,34100,12.81,13.06,12.5,12.88,
                                      37099,30200,12.88,12.88,10.88,11,
                                      37100,26500,11.25,11.25,10.5,10.5,
                                      37103,37300,10.56,10.56,10.12,10.31,
                                      37104,13000,10.44,11,10.31,10.94,
                                      37105,27300,11.12,11.81,11,11.5,
                                      37106,20600,11.56,12,11.5,11.56,
                                      37107,26100,12.19,12.81,11.56,11.56,
                                      37110,12200,12,12.25,11.5,12.25,
                                      37111,7900,12.25,12.25,11.88,11.94,
                                      37112,16100,12.06,12.25,11.5,11.5,
                                      37113,14700,12.19,12.22,11.25,11.25,
                                      37114,8000,11.5,11.5,10.88,10.88,
                                      37117,34000,11.06,11.09,10.31,10.31,
                                      37118,10900,10.5,10.62,10.5,10.62,
                                      37119,4800,10.38,10.62,10.38,10.44,
                                      37120,12700,10.25,10.38,10.06,10.31,
                                      37121,8200,10.25,10.62,10.25,10.31,
                                      37124,9400,10.5,10.5,10.38,10.38,
                                      37125,27700,10.69,10.69,10.31,10.31,
                                      37126,56900,10.38,10.5,9.62,10,
                                      37127,9200,9.97,10.12,9.78,10,
                                      37128,25600,10,10.12,10,10,
                                      37131,25600,10,10.12,10,10,
                                      37132,25600,10,10.12,10,10,
                                      37133,8000,10,10,9.62,9.69,
                                      37134,61900,9.62,11.25,9.62,10.94,
                                      37135,29400,11.31,11.38,10.88,10.88,
                                      37138,29400,11.31,11.38,10.88,10.88,
                                      37139,41000,11.09,11.25,11,11.12,
                                      37140,14700,11.06,11.31,11.06,11.12,
                                      37141,19900,10.91,11,10.31,10.31,
                                      37142,12100,10.62,10.69,10.38,10.5,
                                      37145,10800,10.5,10.5,10.06,10.06,
                                      37146,17000,10.31,10.44,10.12,10.25,
                                      37147,51500,10.62,10.81,10.31,10.38,
                                      37148,20000,10.38,10.38,10,10,
                                      37149,25200,10.12,10.12,9.75,9.75,
                                      37152,8700,9.94,10,9.66,9.69,
                                      37153,8500,9.62,9.69,9.06,9.12,
                                      37154,86000,9.12,9.88,9.06,9.56,
                                      37155,49400,9.5,9.62,8.31,8.5,
                                      37156,79100,7.75,9,7.75,9,
                                      37159,138700,8.75,11,8.44,10.94,
                                      37160,89100,11.5,11.69,10.75,11.31,
                                      37161,58400,11.28,11.44,10.31,10.81,
                                      37162,106200,10.88,12,10.31,11.94,
                                      37163,421400,11.81,16.25,11.75,15.94,
                                      37166,146200,13.62,14.38,13.44,13.44,
                                      37167,70000,13.38,14,13,13.5,
                                      37168,54200,12.73,12.75,12,12,
                                      37169,99700,12.25,12.62,11.62,11.69,
                                      37170,39700,11.88,12.44,11.25,11.44,
                                      37173,11700,11.25,11.44,10.88,10.88,
                                      37174,17100,11.38,11.75,11.25,11.38,
                                      37175,27100,11.31,11.5,10.75,10.75,
                                      37176,29200,10.94,10.94,9.75,10,
                                      37177,32200,9.75,11,9.69,10.94,
                                      37180,60600,11.88,12.69,11.88,12,
                                      37181,23200,12.81,12.88,12,12.25,
                                      37182,30500,12,12.25,11.94,12.25,
                                      37183,54000,12.38,13.94,12.33,13.94,
                                      37184,40000,13.88,13.94,13.38,13.38,
                                      37187,33200,13.75,13.81,13,13.06,
                                      37188,31900,12.94,13,12.5,12.62,
                                      37189,64900,12.41,12.62,11.75,12.56,
                                      37190,53000,12.23,12.25,10.75,11.25,
                                      37191,13900,12.22,12.25,11.5,11.56,
                                      37194,15000,12,12.19,11.38,11.5,
                                      37195,76900,13,13.19,12.5,12.69,
                                      37196,22400,13,13.19,12.56,12.56,
                                      37197,40900,12.94,12.94,12.44,12.44,
                                      37198,30400,12.56,12.62,12.25,12.31,
                                      37201,35400,12.27,12.31,11.25,11.25,
                                      37202,23100,11.61,11.62,10.94,10.94,
                                      37203,24200,11.12,11.25,10.62,10.62,
                                      37204,48800,10.73,10.73,9.12,9.12,
                                      37205,75000,9.12,9.69,8.69,8.69,
                                      37208,147700,8.81,8.88,6.75,7.88,
                                      37209,153400,8.38,8.91,8.31,8.75,
                                     };


      for (int i = 0; i < pfdata.Length; i = i + 6)
      {
        pointFigure1.Add(pfdata[i], pfdata[i + 2], pfdata[i + 3], pfdata[i + 4], pfdata[i + 5]);
      }

      double firstPass = pointFigure1.DateValues.Last;

      for (int i = 0; i < pfdata.Length; i = i + 6)
      {
        pointFigure1.Add(i + 1 + firstPass, pfdata[i + 2], pfdata[i + 3], pfdata[i + 4], pfdata[i + 5]);
      }

    }

	}
}

