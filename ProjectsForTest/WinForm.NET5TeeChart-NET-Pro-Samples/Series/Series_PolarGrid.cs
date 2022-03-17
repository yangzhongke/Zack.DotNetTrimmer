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
    public class Series_PolarGrid : Steema.TeeChart.Samples.BaseForm
    {
        public Series_PolarGrid()
        {
            InitializeComponent();
            polarGrid1.FillSampleValues(10);
            polarGrid1.CircleLabels = true;
            polarGrid1.CircleLabelsInside = false;

        }
        private NumericUpDown numericUpDown2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private PolarGrid polarGrid1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Series_PolarGrid));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.polarGrid1 = new Steema.TeeChart.Styles.PolarGrid();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Displays an array of values as a circular grid of cells, very similar to a for ex" +
                "ample hard disk plate with sectors and tracks. Use the AddCell method to populat" +
                "e series with data.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(440, 64);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Elevation = 315;
            this.tChart1.Aspect.ElevationFloat = 315;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 0;
            this.tChart1.Aspect.Rotation = 360;
            this.tChart1.Aspect.RotationFloat = 360;
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Increment = 36;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Pen.Visible = false;
            this.tChart1.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
            this.tChart1.Series.Add(this.polarGrid1);
            this.tChart1.Size = new System.Drawing.Size(440, 180);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 137);
            this.chartContainer.Size = new System.Drawing.Size(440, 180);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sectors";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(61, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tracks";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(61, 38);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(177, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Clockwise";
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(254, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Axis on top";
#if VS2005
            this.checkBox2.AutoSize = true;
            this.checkBox2.UseVisualStyleBackColor = true;
#endif
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(344, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // polarGrid1
            // 
            // 
            // 
            // 
            this.polarGrid1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polarGrid1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polarGrid1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.polarGrid1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.polarGrid1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.polarGrid1.Marks.Callout.Distance = 0;
            this.polarGrid1.Marks.Callout.Draw3D = false;
            this.polarGrid1.Marks.Callout.Length = 10;
            this.polarGrid1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.polarGrid1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.polarGrid1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polarGrid1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.polarGrid1.RotationAngle = 90;
            this.polarGrid1.Title = "polarGrid1";
            // 
            // 
            // 
            this.polarGrid1.XValues.DataMember = "Sectors";
            // 
            // 
            // 
            this.polarGrid1.YValues.DataMember = "Tracks";
            // 
            // Series_PolarGrid
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Series_PolarGrid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            polarGrid1.NumSectors = (int)numericUpDown1.Value;
            polarGrid1.NumTracks = (int)numericUpDown2.Value;

            polarGrid1.Clear();
            polarGrid1.BeginUpdate();
            double tmp;

            for (int sector = 0; sector < polarGrid1.NumSectors; sector++)
                for (int track = 0; track < polarGrid1.NumTracks; track++)
                {
                    tmp = 0.5 * Math.Pow(Math.Cos(sector / (polarGrid1.NumSectors * 0.2)), 2) +
                        Math.Pow(Math.Cos(track / (polarGrid1.NumTracks * 0.2)), 2) -
                        Math.Cos(track / (polarGrid1.NumTracks * 0.5));
                    polarGrid1.AddCell(sector, track, tmp);
                }
            polarGrid1.EndUpdate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            polarGrid1.ClockWiseLabels = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tChart1.Axes.DrawBehind = !checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Steema.TeeChart.Editors.SeriesEditor.ShowEditor(polarGrid1);
        }
    }
}

