using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
    public class Area_StackGroup : Steema.TeeChart.Samples.BaseForm
    {
        public Area_StackGroup()
        {
            InitializeComponent();
            foreach (Styles.Series s in tChart1.Series)
            {
                s.FillSampleValues(10);
                comboBox1.Items.Add(s.Title);
            }
            comboBox1.SelectedIndex = 0;
        }

        private Steema.TeeChart.Styles.Area area1;
        private Steema.TeeChart.Styles.Area area2;
        private Steema.TeeChart.Styles.Area area3;
        private Steema.TeeChart.Styles.Area area4;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_StackGroup));
            this.area1 = new Steema.TeeChart.Styles.Area();
            this.area2 = new Steema.TeeChart.Styles.Area();
            this.area3 = new Steema.TeeChart.Styles.Area();
            this.area4 = new Steema.TeeChart.Styles.Area();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Area  series can now be grouped. The StackGroup propertydefines the \"group\". \r\nTh" +
                "ere is no limit on how many groups exist.\r\n\r\nExample: area1.StackGroup = 0 ;  ar" +
                "ea2.StackGroup = 1 ; ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
            this.tChart1.Panel.Brush.Gradient.Visible = true;
            this.tChart1.Series.Add(this.area1);
            this.tChart1.Series.Add(this.area2);
            this.tChart1.Series.Add(this.area3);
            this.tChart1.Series.Add(this.area4);
            this.tChart1.Size = new System.Drawing.Size(440, 205);
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
            this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = null;
            this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.tChart1.Walls.Back.Brush.Gradient.Visible = true;
            this.tChart1.Walls.Back.Brush.Visible = true;
            this.tChart1.Walls.Back.Transparent = false;
            // 
            // area1
            // 
            // 
            // 
            // 
            this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            // 
            // 
            // 
            this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(46)))), ((int)(((byte)(26)))));
            // 
            // 
            // 
            this.area1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.area1.ColorEach = false;
            this.area1.DefaultNullValue = 0;
            // 
            // 
            // 
            this.area1.Gradient.ExtendedColorPalette = null;
            this.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.area1.Gradient.Transparency = 30;
            // 
            // 
            // 
            this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(46)))), ((int)(((byte)(26)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.area1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.area1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.area1.Marks.Callout.Distance = 0;
            this.area1.Marks.Callout.Draw3D = false;
            this.area1.Marks.Callout.Length = 10;
            this.area1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
            // 
            // 
            // 
            this.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area1.Stacked = Steema.TeeChart.Styles.CustomStack.Stack;
            this.area1.Title = "area1";
            // 
            // 
            // 
            this.area1.TopGradient.Direction = Drawing.LinearGradientMode.Horizontal;
            this.area1.TopGradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.area1.TopGradient.ExtendedColorPalette = null;
            this.area1.TopGradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(220)))), ((int)(((byte)(212)))));
            this.area1.TopGradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.area1.TopGradient.Transparency = 30;
            this.area1.TopGradient.UseMiddle = true;
            // 
            // 
            // 
            this.area1.XValues.DataMember = "X";
            this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.area1.YValues.DataMember = "Y";
            // 
            // area2
            // 
            // 
            // 
            // 
            this.area2.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(244)))), ((int)(((byte)(158)))), ((int)(((byte)(54)))));
            // 
            // 
            // 
            this.area2.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(95)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            this.area2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(244)))), ((int)(((byte)(158)))), ((int)(((byte)(54)))));
            this.area2.ColorEach = false;
            this.area2.DefaultNullValue = 0;
            // 
            // 
            // 
            this.area2.Gradient.ExtendedColorPalette = null;
            this.area2.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(158)))), ((int)(((byte)(54)))));
            this.area2.Gradient.Transparency = 30;
            // 
            // 
            // 
            this.area2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(95)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.area2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.area2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.area2.Marks.Callout.Distance = 0;
            this.area2.Marks.Callout.Draw3D = false;
            this.area2.Marks.Callout.Length = 10;
            this.area2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area2.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
            // 
            // 
            // 
            this.area2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area2.Stacked = Steema.TeeChart.Styles.CustomStack.Stack;
            this.area2.StackGroup = 1;
            this.area2.Title = "area2";
            // 
            // 
            // 
            this.area2.TopGradient.Direction = Drawing.LinearGradientMode.Horizontal;
            this.area2.TopGradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(158)))), ((int)(((byte)(54)))));
            this.area2.TopGradient.ExtendedColorPalette = null;
            this.area2.TopGradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(215)))));
            this.area2.TopGradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(158)))), ((int)(((byte)(54)))));
            this.area2.TopGradient.Transparency = 30;
            this.area2.TopGradient.UseMiddle = true;
            // 
            // 
            // 
            this.area2.XValues.DataMember = "X";
            this.area2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.area2.YValues.DataMember = "Y";
            // 
            // area3
            // 
            // 
            // 
            // 
            this.area3.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(65)))));
            // 
            // 
            // 
            this.area3.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(118)))), ((int)(((byte)(39)))));
            // 
            // 
            // 
            this.area3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(65)))));
            this.area3.ColorEach = false;
            this.area3.DefaultNullValue = 0;
            // 
            // 
            // 
            this.area3.Gradient.ExtendedColorPalette = null;
            this.area3.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(65)))));
            this.area3.Gradient.Transparency = 30;
            // 
            // 
            // 
            this.area3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(118)))), ((int)(((byte)(39)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.area3.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.area3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.area3.Marks.Callout.Distance = 0;
            this.area3.Marks.Callout.Draw3D = false;
            this.area3.Marks.Callout.Length = 10;
            this.area3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area3.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
            // 
            // 
            // 
            this.area3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area3.Stacked = Steema.TeeChart.Styles.CustomStack.Stack;
            this.area3.Title = "area3";
            // 
            // 
            // 
            this.area3.TopGradient.Direction = Drawing.LinearGradientMode.Horizontal;
            this.area3.TopGradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(65)))));
            this.area3.TopGradient.ExtendedColorPalette = null;
            this.area3.TopGradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            this.area3.TopGradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(65)))));
            this.area3.TopGradient.Transparency = 30;
            this.area3.TopGradient.UseMiddle = true;
            // 
            // 
            // 
            this.area3.XValues.DataMember = "X";
            this.area3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.area3.YValues.DataMember = "Y";
            // 
            // area4
            // 
            // 
            // 
            // 
            this.area4.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(58)))));
            // 
            // 
            // 
            this.area4.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            // 
            // 
            // 
            this.area4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(58)))));
            this.area4.ColorEach = false;
            this.area4.DefaultNullValue = 0;
            // 
            // 
            // 
            this.area4.Gradient.ExtendedColorPalette = null;
            this.area4.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(58)))));
            this.area4.Gradient.Transparency = 30;
            // 
            // 
            // 
            this.area4.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(142)))), ((int)(((byte)(35)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.area4.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.area4.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.area4.Marks.Callout.Distance = 0;
            this.area4.Marks.Callout.Draw3D = false;
            this.area4.Marks.Callout.Length = 10;
            this.area4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area4.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
            // 
            // 
            // 
            this.area4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area4.Stacked = Steema.TeeChart.Styles.CustomStack.Stack;
            this.area4.StackGroup = 1;
            this.area4.Title = "area4";
            // 
            // 
            // 
            this.area4.TopGradient.Direction = Drawing.LinearGradientMode.Horizontal;
            this.area4.TopGradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(58)))));
            this.area4.TopGradient.ExtendedColorPalette = null;
            this.area4.TopGradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(216)))));
            this.area4.TopGradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(58)))));
            this.area4.TopGradient.Transparency = 30;
            this.area4.TopGradient.UseMiddle = true;
            // 
            // 
            // 
            this.area4.XValues.DataMember = "X";
            this.area4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.area4.YValues.DataMember = "Y";
            // 
            // checkBox1
            // 
#if VS2005
            this.checkBox1.AutoSize = true;
#endif
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(12, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Stacked";
#if VS2005
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Series";
            // 
            // comboBox1
            // 
#if VS2005
            this.comboBox1.FormattingEnabled = true;
#endif
            this.comboBox1.Location = new System.Drawing.Point(171, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(319, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Area_StackGroup
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Area_StackGroup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
            {
                (s as Area).MultiArea = (checkBox1.Checked) ? MultiAreas.Stacked : MultiAreas.None;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = (tChart1[comboBox1.SelectedIndex] as Area).StackGroup;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            (tChart1[comboBox1.SelectedIndex] as Area).StackGroup = (int)numericUpDown1.Value;
        }

    }
}

