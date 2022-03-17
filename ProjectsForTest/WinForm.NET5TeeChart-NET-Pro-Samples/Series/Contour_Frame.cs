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
    public class Contour_Frame : Steema.TeeChart.Samples.BaseForm
    {
        public Contour_Frame()
        {
            InitializeComponent();
            contour1.FillSampleValues(25);
            buttonPen1.Pen = contour1.Frame;
        }

        private Steema.TeeChart.Styles.Contour contour1;
        private ButtonPen buttonPen1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contour_Frame));
            this.contour1 = new Steema.TeeChart.Styles.Contour();
            this.buttonPen1 = new Steema.TeeChart.ButtonPen();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Contour series now has a Frame pen.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPen1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 50;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 100;
            this.tChart1.Aspect.Rotation = 321;
            this.tChart1.Aspect.RotationFloat = 321;
            this.tChart1.Aspect.Zoom = 95;
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
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Visible = false;
            // 
            // contour1
            // 
            // 
            // 
            // 
            this.contour1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(44)))));
            this.contour1.ColorEach = false;
            this.contour1.DefaultNullValue = 0;
            this.contour1.DrawingAlgorithm = Steema.TeeChart.Styles.ContourConstruction.Fast;
            // 
            // 
            // 
            this.contour1.Frame.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.contour1.Frame.Style = Drawing.DashStyle.Dot;
            this.contour1.Frame.Visible = true;
            this.contour1.Frame.Width = 3;
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
            // buttonPen1
            // 
            this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPen1.Location = new System.Drawing.Point(12, 10);
            this.buttonPen1.Name = "buttonPen1";
            this.buttonPen1.Size = new System.Drawing.Size(75, 23);
            this.buttonPen1.TabIndex = 1;
            this.buttonPen1.Text = "Frame...";
#if VS2005
            this.buttonPen1.UseVisualStyleBackColor = true;
#endif
            // 
            // Contour_Frame
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Contour_Frame";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


    }
}

