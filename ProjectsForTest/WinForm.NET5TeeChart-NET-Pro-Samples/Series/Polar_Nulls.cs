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
    public class Polar_Nulls : Steema.TeeChart.Samples.BaseForm
    {
        private CheckBox checkBox1;
        private Steema.TeeChart.Styles.Polar polar1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polar_Nulls));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.polar1 = new Steema.TeeChart.Styles.Polar();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Polar and radar series now support null points (controlled via the TreatNulls pro" +
                "perty). Uncheck the \"Hide null points\" checkbox to see the difference between \"n" +
                "ormal\" and \"null\" style(s).";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
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
            this.tChart1.Header.Lines = new string[] {
        "Polar null points"};
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
            this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
            this.tChart1.Panel.Brush.Gradient.Visible = true;
            this.tChart1.Series.Add(this.polar1);
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
            this.tChart1.Walls.Back.Brush.Visible = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Hide null points";
#if VS2005
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.AutoSize = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // polar1
            // 
            // 
            // 
            // 
            this.polar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.polar1.Brush.Solid = false;
            this.polar1.Brush.Style = Drawing.HatchStyle.DarkUpwardDiagonal;
            this.polar1.ColorEach = false;
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
            this.polar1.Pen.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.polar1.Pointer.Visible = true;
            this.polar1.Title = "polar1";
            this.polar1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint;
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
            // Polar_Nulls
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Polar_Nulls";
            this.Load += new System.EventHandler(this.Polar_Nulls_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Polar_Nulls()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            polar1.TreatNulls = checkBox1.Checked ? Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint : Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
        }

        private void Polar_Nulls_Load(object sender, EventArgs e)
        {
            polar1.Add(0, 67);
            polar1.Add(30, 45);
            polar1.Add(60, 50);
            polar1.Add(75, 90);
            polar1.Add(90,90,Color.Transparent); // <- Null point .. It lies between angles of 75 and 100
            polar1.Add(100, 75);
            polar1.Add(120, 45);
            polar1.Add(150, 80);
            polar1.Add(160,80,Color.Transparent); // <- Null point .. It lies between angles of 150 and 180
            polar1.Add(180, 70);
            polar1.Add(210, 35);
            polar1.Add(240, 33);
            polar1.Add(270, 55);
            polar1.Add(300, 65);
            polar1.Add(330, 23);
        }
    }
}

