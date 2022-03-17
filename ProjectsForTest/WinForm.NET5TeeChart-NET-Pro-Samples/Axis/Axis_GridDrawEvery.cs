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
    public class Axis_GridDrawEvery : Steema.TeeChart.Samples.BaseForm
    {
        private Steema.TeeChart.Axis axis;
        
        public Axis_GridDrawEvery()
        {
            InitializeComponent();
            bubble1.FillSampleValues(6);
            axis = bubble1.GetVertAxis;
        }

        private Steema.TeeChart.Styles.Bubble bubble1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Axis_GridDrawEvery));
            this.bubble1 = new Steema.TeeChart.Styles.Bubble();
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
            this.textBox1.Text = "Axis.Grid now has a DrawEvery property. Setting DrawEvery to value greater than 1" +
                " forces the axis to display only every n-th gridline.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(440, 54);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            
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
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Sigma = true;
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.bubble1);
            this.tChart1.Size = new System.Drawing.Size(440, 190);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 127);
            this.chartContainer.Size = new System.Drawing.Size(440, 190);
            // 
            // bubble1
            // 
            this.bubble1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            // 
            // 
            // 
            this.bubble1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(46)))), ((int)(((byte)(26)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.bubble1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bubble1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bubble1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bubble1.Marks.Callout.Distance = 0;
            this.bubble1.Marks.Callout.Draw3D = false;
            this.bubble1.Marks.Callout.Length = 0;
            this.bubble1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.bubble1.Marks.Callout.Visible = false;
            this.bubble1.Marks.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bubble1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
            this.bubble1.Pointer.HorizSize = 18;
            this.bubble1.Pointer.InflateMargins = false;
            // 
            // 
            // 
            this.bubble1.Pointer.Pen.Visible = false;
            this.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.PolishedSphere;
            this.bubble1.Pointer.VertSize = 18;
            this.bubble1.Title = "bubble1";
            // 
            // 
            // 
            this.bubble1.XValues.DataMember = "X";
            this.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bubble1.YValues.DataMember = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Axis";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBox1.Location = new System.Drawing.Point(44, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Draw every";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(252, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Axis_GridDrawEvery
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Axis_GridDrawEvery";
            this.Load += new System.EventHandler(this.Axis_GridDrawEvery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void Axis_GridDrawEvery_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; // vertical axis
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0 : axis = bubble1.GetVertAxis; break;
                case 1: axis = bubble1.GetHorizAxis; break;
            }
            numericUpDown1_ValueChanged(sender, e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            axis.Grid.DrawEvery = (int)numericUpDown1.Value;        
        }
    }
}

