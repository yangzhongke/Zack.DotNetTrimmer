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
    public class Pie_MarksLegSize : Steema.TeeChart.Samples.BaseForm
    {
        public Pie_MarksLegSize()
        {
            InitializeComponent();
            pie1.FillSampleValues(5);
            pie1.MarksPie.LegSize = 10;
        }

        private Steema.TeeChart.Styles.Pie pie1;
        private TrackBar trackBar1;
        private Label label1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pie_MarksLegSize));
            this.pie1 = new Steema.TeeChart.Styles.Pie();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Pie series marks can optionally display lines from the mark rectangle to the Pie " +
                "slice with a \"L\" shape of predefined size:\r\n\r\npie1.MarksPie.LegSize = 25;";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(440, 52);
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
            this.tChart1.Series.Add(this.pie1);
            this.tChart1.Size = new System.Drawing.Size(440, 192);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 125);
            this.chartContainer.Size = new System.Drawing.Size(440, 192);
            // 
            // pie1
            // 
            // 
            // 
            // 
            this.pie1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.pie1.Circled = true;
            this.pie1.LabelMember = "Labels";
            // 
            // 
            // 
            // 
            // 
            // 
            this.pie1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.pie1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.pie1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.pie1.Marks.Callout.Distance = 0;
            this.pie1.Marks.Callout.Draw3D = false;
            this.pie1.Marks.Callout.Length = 8;
            this.pie1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.pie1.MarksPie.LegSize = 0;
            this.pie1.MarksPie.VertCenter = false;
            this.pie1.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
            // 
            // 
            // 
            this.pie1.Shadow.Height = 20;
            this.pie1.Shadow.Width = 20;
            this.pie1.Title = "pie1";
            // 
            // 
            // 
            this.pie1.XValues.DataMember = "Angle";
            this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.pie1.YValues.DataMember = "Pie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leg size:";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(67, 17);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(173, 29);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Pie_MarksLegSize
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Pie_MarksLegSize";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pie1.MarksPie.LegSize = trackBar1.Value;
        }
    }
}

