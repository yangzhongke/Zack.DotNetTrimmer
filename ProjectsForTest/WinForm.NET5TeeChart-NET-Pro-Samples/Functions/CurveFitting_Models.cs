using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Functions;

namespace Steema.TeeChart.Samples
{
    public class CurveFitting_Models : Steema.TeeChart.Samples.BaseForm
    {
        public CurveFitting_Models()
        {
            InitializeComponent();
            points1.Add(1.1, 1);
            points1.Add(1.2, 2.5);
            points1.Add(1.25, 4);
            points1.Add(1.3, 3);
            points1.Add(1.9, 5.5);
            points1.Add(2.1, 6.2);
            points1.Add(2.2, 6.6);
            points1.Add(2.4, 7.2);
            points1.Add(3, 8);
            points1.Add(3.5, 12);
        }

        private bool FitModel(Steema.TeeChart.Styles.Series source, ref double[] yhat, out double[] coeffs, int modelindex)
        {
            double[] y = new double[source.Count];
            double[] x = new double[source.Count];
            double[] w = new double[source.Count];
            bool validmodel = true;

            switch (modelindex)
            {
                case 0:
                    // y(x)=a*Exp(b*x)
                    // linear model: ln(y) = b*x + ln(a)
                    for (int i = 0; i < source.Count; i++)
                    {
                        x[i] = source.notMandatory[i];
                        y[i] = Math.Log(source.mandatory[i]);
                        w[i] = source.mandatory[i] * source.mandatory[i];
                    }
                    Regression.LinearRegression(source.Count, x, y, w, out coeffs);
                    coeffs[0] = Math.Exp(coeffs[0]);
                    for (int i = 0; i < source.Count; i++)
                    {
                        yhat[i] = coeffs[0] * Math.Exp(coeffs[1] * x[i]);
                    }
                    break;
                case 1: 
                    // Power model y=a*x^b
                    // linear model : ln(y) = b*ln(x) + ln(a)
                    for (int i = 0; i < source.Count; i++)
                    {
                        x[i] = Math.Log(source.notMandatory[i]);
                        y[i] = Math.Log(source.mandatory[i]);
                        w[i] = source.mandatory[i] * source.mandatory[i];
                    }
                    Regression.LinearRegression(source.Count, x, y, w, out coeffs);
                    coeffs[0] = Math.Exp(coeffs[0]);
                    for (int i = 0; i < source.Count; i++)
                    {
                        yhat[i] = coeffs[0] * Math.Pow(source.notMandatory[i],coeffs[1]);
                    }
                    break;
                case 2:
                    // Logarithmic model y = b*ln(x)+a
                    for (int i = 0; i < source.Count; i++)
                    {
                        x[i] = Math.Log(source.notMandatory[i]);
                        y[i] = source.mandatory[i];
                        w[i] = source.mandatory[i] * source.mandatory[i];
                    }
                    Regression.LinearRegression(source.Count, x, y, w, out coeffs);
                    for (int i = 0; i < source.Count; i++)
                    {
                        yhat[i] = coeffs[1] * Math.Log(source.notMandatory[i])+coeffs[0];
                    }
                    break;
                default: coeffs = new double[0]; break;
            }

            return validmodel;
        }

        private double[] yhat;
        private double[] coeffs;

        private Steema.TeeChart.Styles.Points points1;
        private ComboBox comboBox1;
        private Label label1;
        private Steema.TeeChart.Styles.Line line1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurveFitting_Models));
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "By using linear regression it\'s possible to fit data to several linearizable mode" +
                "ls.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
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
            this.tChart1.Legend.Title.Pen.Visible = false;
            this.tChart1.Series.Add(this.points1);
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // points1
            // 
            this.points1.ColorEach = false;
            this.points1.DefaultNullValue = 0;
            // 
            // 
            // 
            this.points1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.points1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.points1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.points1.Marks.Callout.Distance = 0;
            this.points1.Marks.Callout.Draw3D = false;
            this.points1.Marks.Callout.Length = 0;
            this.points1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(141)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.points1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(141)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.points1.Pointer.Visible = true;
            this.points1.Title = "Source";
            // 
            // 
            // 
            this.points1.XValues.DataMember = "X";
            this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points1.YValues.DataMember = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // comboBox1
            // 
#if VS2005
            this.comboBox1.FormattingEnabled = true;
#endif
            this.comboBox1.Items.AddRange(new object[] {
            "y(x)=a*Exp[b*x]",
            "y(x)=a*x^b",
            "y(x)=a+b*Ln[x]"});
            this.comboBox1.Location = new System.Drawing.Point(48, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(50)))));
            // 
            // 
            // 
            this.line1.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
            this.line1.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(64)))), ((int)(((byte)(20)))));
            this.line1.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(173)))));
            this.line1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(50)))));
            this.line1.Gradient.UseMiddle = true;
            this.line1.ColorEach = false;
            this.line1.DefaultNullValue = 0;
            // 
            // 
            // 
            this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(80)))), ((int)(((byte)(25)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line1.Marks.Callout.Distance = 0;
            this.line1.Marks.Callout.Draw3D = false;
            this.line1.Marks.Callout.Length = 10;
            this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line1.Title = "Fitted";
            // 
            // 
            // 
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line1.YValues.DataMember = "Y";
            // 
            // CurveFitting_Models
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "CurveFitting_Models";
            this.Load += new System.EventHandler(this.CurveFitting_Models_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            yhat = new double[points1.XValues.Count];
            line1.Clear();
            if (FitModel(points1, ref yhat,out coeffs, comboBox1.SelectedIndex))
            {
                line1.XValues.Count = points1.XValues.Count;
                line1.XValues.Value = points1.XValues.Value;
                line1.YValues.Count = points1.XValues.Count;
                line1.YValues.Value = yhat;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        tChart1.Header.Text = "y=a*Exp(b*x)\r\na=" + coeffs[0].ToString("0.00")+"  b="+coeffs[1].ToString("0.00");break;
                    case 1:
                        tChart1.Header.Text = "y=ax^b\r\na=" + coeffs[0].ToString("0.00") + "  b=" + coeffs[1].ToString("0.00"); break;
                    case 2:
                        tChart1.Header.Text = "y=b*ln(x)+a\r\na=" + coeffs[0].ToString("0.00") + "  b=" + coeffs[1].ToString("0.00");break;
                }
            }
            line1.Repaint();

        }

        private void CurveFitting_Models_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}

