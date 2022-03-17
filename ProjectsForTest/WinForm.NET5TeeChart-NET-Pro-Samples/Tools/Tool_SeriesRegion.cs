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
    public class Tool_SeriesRegion : Steema.TeeChart.Samples.BaseForm
    {
        public Tool_SeriesRegion()
        {
            InitializeComponent();
            line1.FillSampleValues(20);
            seriesRegionTool1.AutoBound = false;
            seriesRegionTool1.Origin = 250.0;
            seriesRegionTool1.LowerBound = line1.XValues[2];
            seriesRegionTool1.UpperBound = line1.XValues[15];
        }

        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Tools.SeriesRegionTool seriesRegionTool1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_SeriesRegion));
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.seriesRegionTool1 = new Steema.TeeChart.Tools.SeriesRegionTool();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "The SeriesRegionTool can be used to identify area under specific curve (series). " +
                "All parts are fully configurable.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(440, 76);
            // 
            // tChart1
            // 
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
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Sigma = true;
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
            this.tChart1.Panel.Brush.Gradient.Visible = true;
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Size = new System.Drawing.Size(440, 168);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Tools.Add(this.seriesRegionTool1);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 149);
            this.chartContainer.Size = new System.Drawing.Size(440, 168);
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.Red;
            this.line1.ColorEach = false;
            // 
            // 
            // 
            this.line1.Gradient.ExtendedColorPalette = null;
            this.line1.Gradient.StartColor = System.Drawing.Color.Red;
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
            // 
            // 
            // 
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
            // seriesRegionTool1
            // 
            this.seriesRegionTool1.AutoBound = true;
            // 
            // 
            // 
            this.seriesRegionTool1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(203)))));
            this.seriesRegionTool1.DrawBehindSeries = true;
            this.seriesRegionTool1.LowerBound = 0;
            this.seriesRegionTool1.Origin = 0;
            this.seriesRegionTool1.Series = this.line1;
            this.seriesRegionTool1.UpperBound = 0;
            this.seriesRegionTool1.UseOrigin = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upper";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(54, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(54, 43);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(134, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Use origin";
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Origin";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(253, 16);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(134, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Draw behind";
#if VS2005
            this.checkBox2.AutoSize = true;
            this.checkBox2.UseVisualStyleBackColor = true;
#endif
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(342, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Edit tool";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tool_SeriesRegion
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Tool_SeriesRegion";
            this.Load += new System.EventHandler(this.Tool_SeriesRegion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            seriesRegionTool1.LowerBound = line1.XValues[(int)numericUpDown1.Value];
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            seriesRegionTool1.UpperBound = line1.XValues[(int)numericUpDown2.Value];
        }

        private void Tool_SeriesRegion_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = line1.Count - 1;
            numericUpDown2.Maximum = line1.Count - 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            seriesRegionTool1.UseOrigin = checkBox1.Checked;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            seriesRegionTool1.Origin = (int)numericUpDown3.Value;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            seriesRegionTool1.DrawBehindSeries = checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editors.Tools.ToolsEditor.ShowEditor(seriesRegionTool1);
        }

    }
}

