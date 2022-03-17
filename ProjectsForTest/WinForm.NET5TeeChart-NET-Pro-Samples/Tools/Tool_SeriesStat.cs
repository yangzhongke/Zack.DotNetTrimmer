using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class Tool_SeriesStat : Steema.TeeChart.Samples.BaseForm
    {
        public Tool_SeriesStat()
        {
            InitializeComponent();
            line1.FillSampleValues(30);
        }
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private Button button1;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Styles.Line line2;
        private Steema.TeeChart.Functions.Average average1;
        private Steema.TeeChart.Tools.SeriesStats seriesStats1;
        private Steema.TeeChart.Styles.Line line3;
        private Steema.TeeChart.Functions.TrendFunction trendFunction1;
        private Steema.TeeChart.Styles.Line line4;
        private Steema.TeeChart.Functions.Low low1;
        private Steema.TeeChart.Styles.Line line5;
        private Steema.TeeChart.Functions.High high1;
        private Steema.TeeChart.Styles.Line line6;
        private Steema.TeeChart.Styles.Line line7;
        private Steema.TeeChart.Functions.CorrelationFunction correlationFunction1;
        private Steema.TeeChart.Functions.MedianFunction medianFunction1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_SeriesStat));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.line2 = new Steema.TeeChart.Styles.Line();
            this.average1 = new Steema.TeeChart.Functions.Average();
            this.button1 = new System.Windows.Forms.Button();
            this.seriesStats1 = new Steema.TeeChart.Tools.SeriesStats();
            this.trendFunction1 = new Steema.TeeChart.Functions.TrendFunction();
            this.line3 = new Steema.TeeChart.Styles.Line();
            this.low1 = new Steema.TeeChart.Functions.Low();
            this.line4 = new Steema.TeeChart.Styles.Line();
            this.high1 = new Steema.TeeChart.Functions.High();
            this.line5 = new Steema.TeeChart.Styles.Line();
            this.line6 = new Steema.TeeChart.Styles.Line();
            this.medianFunction1 = new Steema.TeeChart.Functions.MedianFunction();
            this.correlationFunction1 = new Steema.TeeChart.Functions.CorrelationFunction();
            this.line7 = new Steema.TeeChart.Styles.Line();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Use the SeriesStats tool to return and show typical data of interest about a data" +
                " Series.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Size = new System.Drawing.Size(440, 71);
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
            this.tChart1.Axes.Left.MaximumOffset = 5;
            this.tChart1.Axes.Left.MinimumOffset = 5;
            this.tChart1.Cursor = Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Sigma = true;
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Series.Add(this.line2);
            this.tChart1.Series.Add(this.line3);
            this.tChart1.Series.Add(this.line4);
            this.tChart1.Series.Add(this.line5);
            this.tChart1.Series.Add(this.line6);
            this.tChart1.Series.Add(this.line7);
            this.tChart1.Size = new System.Drawing.Size(440, 173);
            this.tChart1.Tools.Add(this.seriesStats1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tChart1.Walls.Back.Brush.Gradient.Visible = false;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 144);
            this.chartContainer.Size = new System.Drawing.Size(440, 173);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(12, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Average";
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(12, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Trend";
#if VS2005
            this.checkBox2.AutoSize = true;
            this.checkBox2.UseVisualStyleBackColor = true;
#endif
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(81, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(43, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Low";
#if VS2005
            this.checkBox3.AutoSize = true;
            this.checkBox3.UseVisualStyleBackColor = true;
#endif
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Location = new System.Drawing.Point(81, 42);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(45, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "High";
#if VS2005
            this.checkBox4.AutoSize = true;
            this.checkBox4.UseVisualStyleBackColor = true;
#endif
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Location = new System.Drawing.Point(130, 19);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(58, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Median";
#if VS2005
            this.checkBox5.AutoSize = true;
            this.checkBox5.UseVisualStyleBackColor = true;
#endif
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Location = new System.Drawing.Point(130, 42);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(73, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Correlation";
#if VS2005
            this.checkBox6.AutoSize = true;
            this.checkBox6.UseVisualStyleBackColor = true;
#endif
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.line1.ColorEach = false;
            // 
            // 
            // 
            this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.line1.Title = "Source";
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
            // line2
            // 
            // 
            // 
            // 
            this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.line2.ColorEach = false;
            this.line2.DataSource = this.line1;
            this.line2.Function = this.average1;
            // 
            // 
            // 
            this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line2.Marks.Callout.Distance = 0;
            this.line2.Marks.Callout.Draw3D = false;
            this.line2.Marks.Callout.Length = 10;
            this.line2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line2.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line2.Title = "Average";
            // 
            // 
            // 
            this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(267, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit tool";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seriesStats1
            // 
            this.seriesStats1.Series = this.line1;
            // 
            // line3
            // 
            // 
            // 
            // 
            this.line3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.line3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.line3.ColorEach = false;
            this.line3.DataSource = this.line1;
            this.line3.Function = this.trendFunction1;
            // 
            // 
            // 
            this.line3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line3.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line3.Marks.Callout.Distance = 0;
            this.line3.Marks.Callout.Draw3D = false;
            this.line3.Marks.Callout.Length = 10;
            this.line3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line3.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line3.Title = "Trend";
            this.line3.Visible = false;
            // 
            // 
            // 
            this.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // line4
            // 
            // 
            // 
            // 
            this.line4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line4.ColorEach = false;
            this.line4.DataSource = this.line1;
            this.line4.Function = this.low1;
            // 
            // 
            // 
            this.line4.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line4.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line4.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line4.Marks.Callout.Distance = 0;
            this.line4.Marks.Callout.Draw3D = false;
            this.line4.Marks.Callout.Length = 10;
            this.line4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line4.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.line4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line4.Title = "Low";
            // 
            // 
            // 
            this.line4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // line5
            // 
            // 
            // 
            // 
            this.line5.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.line5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.line5.ColorEach = false;
            this.line5.DataSource = this.line1;
            this.line5.Function = this.high1;
            // 
            // 
            // 
            this.line5.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line5.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line5.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line5.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line5.Marks.Callout.Distance = 0;
            this.line5.Marks.Callout.Draw3D = false;
            this.line5.Marks.Callout.Length = 10;
            this.line5.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line5.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.line5.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line5.Title = "High";
            this.line5.Visible = false;
            // 
            // 
            // 
            this.line5.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // line6
            // 
            // 
            // 
            // 
            this.line6.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.line6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.line6.ColorEach = false;
            this.line6.DataSource = this.line1;
            this.line6.Function = this.medianFunction1;
            // 
            // 
            // 
            this.line6.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line6.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line6.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line6.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line6.Marks.Callout.Distance = 0;
            this.line6.Marks.Callout.Draw3D = false;
            this.line6.Marks.Callout.Length = 10;
            this.line6.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line6.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.line6.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line6.Title = "Median";
            this.line6.Visible = false;
            // 
            // 
            // 
            this.line6.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // line7
            // 
            // 
            // 
            // 
            this.line7.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.line7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.line7.ColorEach = false;
            this.line7.DataSource = this.line1;
            this.line7.Function = this.correlationFunction1;
            // 
            // 
            // 
            this.line7.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line7.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line7.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line7.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line7.Marks.Callout.Distance = 0;
            this.line7.Marks.Callout.Draw3D = false;
            this.line7.Marks.Callout.Length = 10;
            this.line7.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line7.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.line7.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line7.Title = "Correlation";
            this.line7.Visible = false;
            // 
            // 
            // 
            this.line7.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // Tool_SeriesStat
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Tool_SeriesStat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Editors.Tools.ToolsEditor.ShowEditor(seriesStats1);
            // Update checkboxes
            checkBox1.Checked = line2.Active;
            checkBox2.Checked = line3.Active;
            checkBox3.Checked = line4.Active;
            checkBox4.Checked = line5.Active;
            checkBox5.Checked = line6.Active;
            checkBox6.Checked = line7.Active;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            line2.Active = checkBox1.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            line4.Active = checkBox3.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            line3.Active = checkBox2.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            line5.Active = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            line6.Active = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            line7.Active = checkBox6.Checked;
        }
    }
}

