using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class RSI_Function : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private Steema.TeeChart.Styles.Candle candle1;
		private Steema.TeeChart.Axis axis1;
		private Steema.TeeChart.Functions.RSIFunction rsiFunction1;
		private Steema.TeeChart.Styles.Line line1;
		private System.ComponentModel.IContainer components = null;

		public RSI_Function()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSI_Function));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.candle1 = new Steema.TeeChart.Styles.Candle();
			this.axis1 = new Steema.TeeChart.Axis(this.components);
			this.rsiFunction1 = new Steema.TeeChart.Functions.RSIFunction();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox1);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Aspect.ZOffset = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Angle = 90;
			this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "dd/MM/yyyy";
			this.tChart1.Axes.Bottom.MaximumOffset = 5;
			this.tChart1.Axes.Bottom.MinimumOffset = 5;
			this.tChart1.Axes.Custom.Add(this.axis1);
			// 
			// 
			// 
			this.tChart1.Axes.Left.EndPosition = 58;
			this.tChart1.Axes.Left.MaximumOffset = 5;
			this.tChart1.Axes.Left.MinimumOffset = 5;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Caption = "Stock Sample";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.Red;
			this.tChart1.Axes.Left.Title.Font.Size = 9;
			this.tChart1.Axes.Left.Title.Font.SizeFloat = 9F;
			this.tChart1.Axes.Left.Title.Lines = new string[] {
        "Stock Sample"};
			this.tChart1.Cursor = Cursors.Default;
			// 
			// 
			// 
			this.tChart1.Header.Visible = false;
			// 
			// 
			// 
			this.tChart1.Legend.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Panel.MarginRight = 12;
			this.tChart1.Series.Add(this.candle1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Size = new System.Drawing.Size(440, 205);
            this.tChart1.AllowScroll += tChart1_AllowScroll; 
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "Open and Close",
            "Close only"});
			this.comboBox1.Location = new System.Drawing.Point(84, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Calc. Method:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(256, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Period:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(298, 12);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// candle1
			// 
			// 
			// 
			// 
			this.candle1.Brush.Color = System.Drawing.Color.White;
			this.candle1.CloseValues = this.candle1.YValues;
			this.candle1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
			this.candle1.ColorEach = false;
			this.candle1.DateValues = this.candle1.XValues;
			// 
			// 
			// 
			this.candle1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.candle1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.candle1.Marks.Callout.Distance = 0;
			this.candle1.Marks.Callout.Draw3D = false;
			this.candle1.Marks.Callout.Length = 10;
			this.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.candle1.Pointer.Draw3D = false;
			this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Title = "candle1";
			// 
			// 
			// 
			this.candle1.XValues.DataMember = "Date";
			this.candle1.XValues.DateTime = true;
			this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.candle1.YValues.DataMember = "Close";
			// 
			// axis1
			// 
			this.axis1.Horizontal = false;
			this.axis1.OtherSide = true;
			this.axis1.StartPosition = 60;
			// 
			// 
			// 
			this.axis1.Title.Angle = 90;
			this.axis1.Title.Caption = "R.S.I";
			// 
			// 
			// 
			// 
			// 
			// 
			this.axis1.Title.Font.Brush.Color = System.Drawing.Color.Green;
			this.axis1.Title.Font.Size = 9;
			this.axis1.Title.Font.SizeFloat = 9F;
			this.axis1.Title.Lines = new string[] {
        "R.S.I"};
			this.axis1.ZPosition = 0;
			// 
			// rsiFunction1
			// 
			this.rsiFunction1.Period = 1;
			// 
			// line1
			// 
			// 
			// 
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
			this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
			this.line1.ColorEach = false;
			this.line1.CustomVertAxis = this.axis1;
			this.line1.DataSource = this.candle1;
			this.line1.Function = this.rsiFunction1;
			// 
			// 
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.line1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.line1.Marks.Callout.Distance = 0;
			this.line1.Marks.Callout.Draw3D = false;
			this.line1.Marks.Callout.Length = 10;
			this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "line1";
			this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.line1.XValues.DateTime = true;
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.line1.YValues.DataMember = "Close";
			// 
			// RSI_Function
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "RSI_Function";
			this.Load += new System.EventHandler(this.RSIFunction_Load);
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void RSIFunction_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
			candle1.FillSampleValues(100);

			rsiFunction1.Period=10;  /* take 10 prices */
			rsiFunction1.Style=Steema.TeeChart.Functions.RSIStyle.OpenClose;  /* default calc method */
		}

        void tChart1_AllowScroll(Axis a, AllowScrollEventArgs e)
        {         
			e.AllowScroll = a != axis1;
		}

		private void comboBox1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			rsiFunction1.Period = Convert.ToDouble(numericUpDown1.Value);						
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			rsiFunction1.Style = (Steema.TeeChart.Functions.RSIStyle)this.comboBox1.SelectedIndex;
		}
	}
}

