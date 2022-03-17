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
    public class CustomPolar_TreatNulls : Steema.TeeChart.Samples.BaseForm
    {
        public CustomPolar_TreatNulls()
        {
            InitializeComponent();
            tChart1[0].FillSampleValues(10);
            tChart1[0].SetNull(5, checkBox1.Checked);
        }

        private Steema.TeeChart.Styles.Polar polar1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPolar_TreatNulls));
            this.polar1 = new Steema.TeeChart.Styles.Polar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "All series derived from CustomPolar series now support null points. This includes" +
                " Polar, Polar Bar, Radar and Windrose series.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(440, 61);
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
            this.tChart1.Series.Add(this.polar1);
            this.tChart1.Size = new System.Drawing.Size(440, 183);
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
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 134);
            this.chartContainer.Size = new System.Drawing.Size(440, 183);
            // 
            // polar1
            // 
            // 
            // 
            // 
            this.polar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.CircleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.polar1.CircleGradient.ExtendedColorPalette = null;
            this.polar1.CircleGradient.Visible = true;
            this.polar1.ColorEach = false;
            this.polar1.DefaultNullValue = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.polar1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.polar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.polar1.Marks.Callout.Distance = 0;
            this.polar1.Marks.Callout.Draw3D = false;
            this.polar1.Marks.Callout.Length = 10;
            this.polar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.polar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.polar1.Pointer.Visible = true;
            this.polar1.Title = "polar1";
            // 
            // 
            // 
            this.polar1.XValues.DataMember = "Angle";
            this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.polar1.YValues.DataMember = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Style";
            // 
            // comboBox1
            // 
#if VS2005
            this.comboBox1.FormattingEnabled = true;
#endif
            this.comboBox1.Items.AddRange(new object[] {
            "Polar",
            "Polar Bar",
            "Radar",
            "Windrose"});
            this.comboBox1.Location = new System.Drawing.Point(48, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Treat nulls";
            // 
            // comboBox2
            // 
#if VS2005
            this.comboBox2.FormattingEnabled = true;
#endif
            this.comboBox2.Items.AddRange(new object[] {
            "Don\'t paint",
            "Skip",
            "Ignore"});
            this.comboBox2.Location = new System.Drawing.Point(230, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBox1
            // 
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(343, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Point 5 is null";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
#if VS2005
            this.checkBox2.AutoSize = true;
            this.checkBox2.UseVisualStyleBackColor = true;
#endif
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(343, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Filled";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CustomPolar_TreatNulls
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "CustomPolar_TreatNulls";
            this.Load += new System.EventHandler(this.CustomPolar_TreatNulls_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void CustomPolar_TreatNulls_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 2; // ignore
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            (tChart1[0] as CustomPolar).TreatNulls = (TreatNullsStyle)comboBox2.SelectedIndex;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            (tChart1[0] as CustomPolar).Brush.Visible = checkBox2.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Steema.TeeChart.Styles.Series s = tChart1[0];
            switch (comboBox1.SelectedIndex)
            {
                case 1: Steema.TeeChart.Styles.Series.ChangeType(ref s, typeof(PolarBar)); break;
                case 2: Steema.TeeChart.Styles.Series.ChangeType(ref s, typeof(Radar)); break;
                case 3: Steema.TeeChart.Styles.Series.ChangeType(ref s, typeof(WindRose)); break;
                default: Steema.TeeChart.Styles.Series.ChangeType(ref s, typeof(Polar)); break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tChart1[0].SetNull(5, checkBox1.Checked);
            tChart1[0].Repaint();
        }
    }
}

