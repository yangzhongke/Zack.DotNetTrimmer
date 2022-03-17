using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class Function_Histogram : Steema.TeeChart.Samples.BaseNoChart
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_Histogram));
            this.tChart1 = new Steema.TeeChart.TChart();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.histogram1 = new Steema.TeeChart.Styles.Histogram();
            this.histogramFunction1 = new Steema.TeeChart.Functions.HistogramFunction();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(540, 62);
            this.textBox1.Text = "The HistogramFunction does exactly what it\'s name suggests: It creates a histogra" +
                "m from single series X or Y values.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(540, 42);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tChart2);
            this.panel2.Controls.Add(this.tChart1);
            this.panel2.Size = new System.Drawing.Size(540, 230);
            // 
            // tChart1
            // 
            this.tChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Axes.Depth.MinorGrid.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.MinorGrid.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Axes.Right.MinorGrid.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Axes.Top.MinorGrid.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "Data"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.DividingLines.Visible = true;
            this.tChart1.Legend.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(3, 6);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Pen.Visible = true;
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Size = new System.Drawing.Size(276, 212);
            this.tChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.line1.ColorEach = false;
            // 
            // 
            // 
            this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // 
            // 
            // 
            this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line1.Title = "line1";
            // 
            // 
            // 
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line1.YValues.DataMember = "Y";
            // 
            // tChart2
            // 
            this.tChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tChart2.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Ticks.Length = 2;
            this.tChart2.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart2.Axes.Depth.MinorGrid.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.MinorGrid.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Left.Increment = 1;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart2.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart2.Axes.Right.MinorGrid.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart2.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart2.Axes.Top.MinorGrid.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart2.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.tChart2.Header.Lines = new string[] {
        "Histogram"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.DividingLines.Visible = true;
            this.tChart2.Legend.Visible = false;
            this.tChart2.Location = new System.Drawing.Point(285, 6);
            this.tChart2.Name = "tChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.Pen.Visible = true;
            this.tChart2.Series.Add(this.histogram1);
            this.tChart2.Size = new System.Drawing.Size(255, 212);
            this.tChart2.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // histogram1
            // 
            // 
            // 
            // 
            this.histogram1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.histogram1.ColorEach = false;
            this.histogram1.Function = this.histogramFunction1;
            // 
            // 
            // 
            this.histogram1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.histogram1.LinePen.Visible = false;
            // 
            // 
            // 
            this.histogram1.LinesPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.histogram1.LinesPen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.histogram1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.histogram1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.histogram1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.histogram1.Marks.Callout.Distance = 0;
            this.histogram1.Marks.Callout.Draw3D = false;
            this.histogram1.Marks.Callout.Length = 10;
            this.histogram1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.histogram1.Title = "histogram1";
            // 
            // 
            // 
            this.histogram1.XValues.DataMember = "X";
            this.histogram1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.histogram1.YValues.DataMember = "Y";
            // 
            // histogramFunction1
            // 
            this.histogramFunction1.Cumulative = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of bins";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(96, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox1
            // 
#if VS2005
            this.checkBox1.AutoSize = true;
#endif
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(170, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Cumulative histogram";
#if VS2005
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(317, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Recreate data";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Function_Histogram
            // 
            this.ClientSize = new System.Drawing.Size(540, 334);
            this.Name = "Function_Histogram";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TChart tChart1;
        private TChart tChart2;
        private Steema.TeeChart.Styles.Histogram histogram1;
        private Steema.TeeChart.Functions.HistogramFunction histogramFunction1;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button1;
        private Steema.TeeChart.Styles.Line line1;


        public Function_Histogram()
        {
            InitializeComponent();
            line1.FillSampleValues(500);
            // connect line to histogram series
            histogram1.DataSource = line1;
            histogram1.RefreshSeries();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            histogramFunction1.NumBins = (int)numericUpDown1.Value;
            histogramFunction1.Recalculate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            histogramFunction1.Cumulative = checkBox1.Checked;
            if (histogramFunction1.Cumulative) tChart2.Header.Text = "Cumulative Histogram"; else tChart2.Header.Text = "Histogram";
            histogramFunction1.Recalculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line1.FillSampleValues(500);
            histogramFunction1.Recalculate();
        }
    }
}

