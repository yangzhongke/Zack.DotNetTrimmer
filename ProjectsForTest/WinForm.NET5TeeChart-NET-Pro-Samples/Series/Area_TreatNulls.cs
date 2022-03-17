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
    public class Area_TreatNulls : Steema.TeeChart.Samples.BaseForm
    {
        private void FillSeries()
        {
            bool done = false;
            double y;
            for (int x = 0; x <= 10; x++)
            {
                y = (x % 2 == 0) ? 10 : 20;
                if ((x >= 3) && (x <= 7))
                {
                    if (!done) area1.Add(x, 0, Color.Transparent);
                    done = true;
                }
                else area1.Add(x, y);
            }
        }
        
        public Area_TreatNulls()
        {
            InitializeComponent();
            area1.GetVertAxis.SetMinMax(-10, 30);
            FillSeries();
            area1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint;
        }

        private Label label1;
        private ComboBox comboBox1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_TreatNulls));
            this.area1 = new Steema.TeeChart.Styles.Area();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(440, 55);
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
            this.tChart1.Header.Visible = false;
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
            this.tChart1.Series.Add(this.area1);
            this.tChart1.Size = new System.Drawing.Size(440, 189);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 128);
            this.chartContainer.Size = new System.Drawing.Size(440, 189);
            // 
            // area1
            // 
            // 
            // 
            // 
            this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.area1.Gradient.StartColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.area1.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.area1.TopGradient.StartColor = System.Drawing.Color.Red;
            this.area1.ColorEach = false;
            // 
            // 
            // 
            this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // 
            // 
            // 
            this.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area1.Title = "area1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Treat nulls";
            // 
            // comboBox1
            // 
#if VS2005
            this.comboBox1.FormattingEnabled = true;
#endif
            this.comboBox1.Items.AddRange(new object[] {
            "Don\'t paint",
            "Skip",
            "As value"});
            this.comboBox1.Location = new System.Drawing.Point(74, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Area_TreatNulls
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Area_TreatNulls";
            this.Load += new System.EventHandler(this.Area_TreatNulls_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Steema.TeeChart.Styles.Area area1;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: area1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint; break;
                case 1: area1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Skip; break;
                default: area1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore; break;
            }
        }

        private void Area_TreatNulls_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}

