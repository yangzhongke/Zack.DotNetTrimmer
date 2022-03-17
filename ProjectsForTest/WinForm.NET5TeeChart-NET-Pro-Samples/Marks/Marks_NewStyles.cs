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
    public class Marks_NewStyles : Steema.TeeChart.Samples.BaseForm
    {
        public Marks_NewStyles()
        {
            InitializeComponent();
        }
        private Steema.TeeChart.Styles.Bar bar1;
        int ShowMark;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marks_NewStyles));
            this.bar1 = new Steema.TeeChart.Styles.Bar();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Move the mouse over the bars!";
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 25;
            this.tChart1.Aspect.Elevation = 322;
            this.tChart1.Aspect.ElevationFloat = 322;
            this.tChart1.Aspect.Perspective = 100;
            this.tChart1.Aspect.Rotation = 360;
            this.tChart1.Aspect.RotationFloat = 360;
            
            
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Aspect.Zoom = 79;
            this.tChart1.Aspect.ZoomFloat = 79;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MaximumOffset = 32;
            this.tChart1.Axes.Bottom.MinimumOffset = 32;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 37;
            // 
            // 
            // 
            this.tChart1.Header.Visible = false;
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
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Sigma = true;
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.bar1);
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // 
            // 
            this.tChart1.Walls.Visible = false;
            // 
            // bar1
            // 
            this.bar1.Marks.AutoPosition = false;
            // 
            // 
            // 
            this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.bar1.ColorEach = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Arrow.Visible = false;
            // 
            // 
            // 
            this.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bar1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bar1.Marks.Callout.Distance = 0;
            this.bar1.Marks.Callout.Draw3D = false;
            this.bar1.Marks.Callout.Length = 20;
            this.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.bar1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.bar1.Marks.Font.Size = 15;
            this.bar1.Marks.Font.SizeFloat = 15F;
            // 
            // 
            // 
            this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.bar1.Title = "bar1";
            // 
            // 
            // 
            this.bar1.XValues.DataMember = "X";
            this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bar1.YValues.DataMember = "Bar";
            // 
            // Marks_NewStyles
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Marks_NewStyles";
            this.Load += new System.EventHandler(this.Marks_NewStyles_Load);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void Marks_NewStyles_Load(object sender, EventArgs e)
        {
            bar1.FillSampleValues(6);

            ShowMark = -1;
            tChart1.MouseMove += new MouseEventHandler(tChart1_MouseMove);
            bar1.GetSeriesMark += new Steema.TeeChart.Styles.Series.GetSeriesMarkEventHandler(bar1_GetSeriesMark);
        }

        void bar1_GetSeriesMark(Steema.TeeChart.Styles.Series series, Steema.TeeChart.Styles.GetSeriesMarkEventArgs e)
        {
            if (e.ValueIndex == ShowMark)
            {
                e.MarkText = e.MarkText;
            }
            else
            {
                e.MarkText = "";
            }
        }

        void tChart1_MouseMove(object sender, MouseEventArgs e)
        {
            ShowMark = bar1.Clicked(e.X,e.Y);
            if (ShowMark != -1)
            {
                tChart1.Refresh();
            }
        }
    }
}

