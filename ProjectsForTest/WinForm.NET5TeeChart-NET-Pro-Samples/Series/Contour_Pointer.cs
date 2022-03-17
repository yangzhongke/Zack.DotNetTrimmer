using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart;

namespace Steema.TeeChart.Samples
{
    public class Contour_Pointer : Steema.TeeChart.Samples.BaseForm
    {

        public Contour_Pointer()
        {
            InitializeComponent();
            // Pointer is supported only when segments are used, so ...
            contour1.FillSampleValues(20);
            contour1.UseColorRange = false;
            contour1.UsePalette = true;
            contour1.Pointer.Visible = true;
            contour1.Pen.Visible = false;
            contour1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Rainbow;
            contour1.ColorEach = false;
            buttonPen1.Pen = contour1.Pen;
        }

        private CheckBox checkBox1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private ButtonPen buttonPen1;
        private Steema.TeeChart.Styles.Contour contour1;
        private int index = -1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contour_Pointer));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.buttonPen1 = new Steema.TeeChart.ButtonPen();
            this.contour1 = new Steema.TeeChart.Styles.Contour();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Contour series now supports different pointer styles for level lines.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPen1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
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
            this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Legend.MaxNumRows = 8;
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
            this.tChart1.Series.Add(this.contour1);
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
            this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
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
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Pointer visible";
#if VS2005
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(162, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(276, 16);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // buttonPen1
            // 
            this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPen1.Location = new System.Drawing.Point(347, 14);
            this.buttonPen1.Name = "buttonPen1";
            this.buttonPen1.Size = new System.Drawing.Size(81, 21);
            this.buttonPen1.TabIndex = 5;
            this.buttonPen1.Text = "Pen ...";
#if VS2005
            this.buttonPen1.UseVisualStyleBackColor = true;
#endif
            // 
            // contour1
            // 
            // 
            // 
            // 
            this.contour1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.contour1.ColorEach = false;
            this.contour1.DefaultNullValue = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.contour1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.contour1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.contour1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.contour1.Marks.Callout.Distance = 0;
            this.contour1.Marks.Callout.Draw3D = false;
            this.contour1.Marks.Callout.Length = 10;
            this.contour1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.contour1.Marks.Transparent = true;
            this.contour1.PaletteMin = 0;
            this.contour1.PaletteStep = 0;
            this.contour1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            // 
            // 
            // 
            this.contour1.Pointer.HorizSize = 2;
            // 
            // 
            // 
            this.contour1.Pointer.Pen.Visible = false;
            this.contour1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.contour1.Pointer.VertSize = 2;
            this.contour1.Title = "contour1";
            // 
            // 
            // 
            this.contour1.XValues.DataMember = "X";
            this.contour1.YPosition = 0.18959828428699516;
            // 
            // 
            // 
            this.contour1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.contour1.ZValues.DataMember = "Z";
            // 
            // Contour_Pointer
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Contour_Pointer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            contour1.Pointer.HorizSize = (int)numericUpDown2.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            contour1.Pointer.Visible = checkBox1.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            contour1.Pointer.VertSize = (int)numericUpDown1.Value;
        }

        private void tChart1_MouseMove(object sender, MouseEventArgs e)
        {
            index = contour1.Clicked(e.X, e.Y);
        }

    }
}

