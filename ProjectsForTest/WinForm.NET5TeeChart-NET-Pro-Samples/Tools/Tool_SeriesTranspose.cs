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
    public class Tool_SeriesTranspose : Steema.TeeChart.Samples.BaseForm
    {
        public Tool_SeriesTranspose()
        {
            InitializeComponent();
            bar1.FillSampleValues(6);
            bar2.FillSampleValues(6);
            bar3.FillSampleValues(6);

            bar3.SetNull(5);
            bar3.Delete(5);
        }

        private Button button1;
        private Steema.TeeChart.Styles.Bar bar1;
        private Steema.TeeChart.Styles.Bar bar2;
        private Steema.TeeChart.Styles.Bar bar3;
        private Steema.TeeChart.Tools.SeriesTranspose seriesTranspose1;
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_SeriesTranspose));
          this.bar1 = new Steema.TeeChart.Styles.Bar();
          this.bar2 = new Steema.TeeChart.Styles.Bar();
          this.bar3 = new Steema.TeeChart.Styles.Bar();
          this.button1 = new System.Windows.Forms.Button();
          this.seriesTranspose1 = new Steema.TeeChart.Tools.SeriesTranspose();
          this.panel1.SuspendLayout();
          this.chartContainer.SuspendLayout();
          this.SuspendLayout();
          // 
          // textBox1
          // 
          this.textBox1.Text = "Interchange the Series Valuelists to display different planes of the data.";
          // 
          // panel1
          // 
          this.panel1.Controls.Add(this.button1);
          // 
          // tChart1
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
          // 
          // 
          // 
          // 
          // 
          // 
          // 
          this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
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
          this.tChart1.Series.Add(this.bar1);
          this.tChart1.Series.Add(this.bar2);
          this.tChart1.Series.Add(this.bar3);
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
          this.tChart1.Tools.Add(this.seriesTranspose1);
          // 
          // bar1
          // 
          // 
          // 
          // 
          this.bar1.Brush.Color = System.Drawing.Color.Red;
          this.bar1.ColorEach = false;
          // 
          // 
          // 
          this.bar1.Gradient.ExtendedColorPalette = null;
          this.bar1.Gradient.StartColor = System.Drawing.Color.Red;
          // 
          // 
          // 
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
          // 
          // 
          // 
          this.bar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
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
          // bar2
          // 
          // 
          // 
          // 
          this.bar2.Brush.Color = System.Drawing.Color.Green;
          this.bar2.ColorEach = false;
          // 
          // 
          // 
          this.bar2.Gradient.ExtendedColorPalette = null;
          this.bar2.Gradient.StartColor = System.Drawing.Color.Green;
          // 
          // 
          // 
          // 
          // 
          // 
          this.bar2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
          this.bar2.Marks.Callout.ArrowHeadSize = 8;
          // 
          // 
          // 
          this.bar2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
          this.bar2.Marks.Callout.Distance = 0;
          this.bar2.Marks.Callout.Draw3D = false;
          this.bar2.Marks.Callout.Length = 20;
          this.bar2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
          // 
          // 
          // 
          this.bar2.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
          this.bar2.Title = "bar2";
          // 
          // 
          // 
          this.bar2.XValues.DataMember = "X";
          this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
          // 
          // 
          // 
          this.bar2.YValues.DataMember = "Bar";
          // 
          // bar3
          // 
          // 
          // 
          // 
          this.bar3.Brush.Color = System.Drawing.Color.Yellow;
          this.bar3.ColorEach = false;
          // 
          // 
          // 
          this.bar3.Gradient.ExtendedColorPalette = null;
          this.bar3.Gradient.StartColor = System.Drawing.Color.Yellow;
          // 
          // 
          // 
          // 
          // 
          // 
          this.bar3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
          this.bar3.Marks.Callout.ArrowHeadSize = 8;
          // 
          // 
          // 
          this.bar3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
          this.bar3.Marks.Callout.Distance = 0;
          this.bar3.Marks.Callout.Draw3D = false;
          this.bar3.Marks.Callout.Length = 20;
          this.bar3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
          // 
          // 
          // 
          this.bar3.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
          this.bar3.Title = "bar3";
          // 
          // 
          // 
          this.bar3.XValues.DataMember = "X";
          this.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
          // 
          // 
          // 
          this.bar3.YValues.DataMember = "Bar";
          // 
          // button1
          // 
          this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.button1.Location = new System.Drawing.Point(12, 10);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(75, 23);
          this.button1.TabIndex = 0;
          this.button1.Text = "Transpose";
#if VS2005
          this.button1.UseVisualStyleBackColor = true;
#endif
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // Tool_SeriesTranspose
          // 
          this.ClientSize = new System.Drawing.Size(440, 317);
          this.Name = "Tool_SeriesTranspose";
          this.panel1.ResumeLayout(false);
          this.chartContainer.ResumeLayout(false);
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            seriesTranspose1.Transpose();
        }


    }
}

