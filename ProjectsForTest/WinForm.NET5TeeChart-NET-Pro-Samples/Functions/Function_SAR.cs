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
    public class Function_SAR : Steema.TeeChart.Samples.BaseForm
    {
        private bool setting = true;
        
        public Function_SAR()
        {
            InitializeComponent();
            candle1.FillSampleValues(10);
        }

        private Steema.TeeChart.Styles.Candle candle1;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Functions.SARFunction sarFunction1;
        private TextBox textBox2;
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
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_SAR));
					this.candle1 = new Steema.TeeChart.Styles.Candle();
					this.line1 = new Steema.TeeChart.Styles.Line();
					this.sarFunction1 = new Steema.TeeChart.Functions.SARFunction();
					this.label1 = new System.Windows.Forms.Label();
					this.textBox2 = new System.Windows.Forms.TextBox();
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
					this.panel1.Controls.Add(this.textBox2);
					this.panel1.Controls.Add(this.label1);
					// 
					// tChart1
					// 
					// 
					// 
					// 
					
					
					this.tChart1.Aspect.View3D = false;
					this.tChart1.Aspect.ZOffset = 0;
					// 
					// 
					// 
					// 
					// 
					// 
					this.tChart1.Axes.Bottom.MaximumOffset = 5;
					this.tChart1.Axes.Bottom.MinimumOffset = 5;
					// 
					// 
					// 
					this.tChart1.Axes.Left.MaximumOffset = 5;
					this.tChart1.Axes.Left.MinimumOffset = 5;
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
					this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
					this.tChart1.Panel.Brush.Gradient.Sigma = true;
					this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
					this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
					this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
					this.tChart1.Series.Add(this.candle1);
					this.tChart1.Series.Add(this.line1);
					this.tChart1.Size = new System.Drawing.Size(440, 205);
					// 
					// candle1
					// 
					// 
					// 
					// 
					this.candle1.Brush.Color = System.Drawing.Color.White;
					this.candle1.CloseValues = this.candle1.YValues;
					this.candle1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
					this.candle1.ColorEach = false;
					this.candle1.DateValues = this.candle1.XValues;
					// 
					// 
					// 
					this.candle1.HighLowPen.Color = System.Drawing.Color.Black;
					// 
					// 
					// 
					this.candle1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
					// 
					// 
					// 
					// 
					// 
					// 
					this.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
					this.candle1.Marks.Callout.ArrowHeadSize = 8;
					// 
					// 
					// 
					this.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
					this.candle1.Marks.Callout.Distance = 0;
					this.candle1.Marks.Callout.Draw3D = false;
					this.candle1.Marks.Callout.Length = 10;
					this.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
					this.candle1.Marks.Callout.Visible = false;
					// 
					// 
					// 
					this.candle1.Pointer.Draw3D = false;
					// 
					// 
					// 
					this.candle1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
					this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
					this.candle1.Title = "Data";
					// 
					// 
					// 
					this.candle1.XValues.DataMember = "Date";
					this.candle1.XValues.DateTime = true;
					this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
					// 
					// 
					// 
					this.candle1.YValues.DataMember = "Close";
					// 
					// line1
					// 
					// 
					// 
					// 
					this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
					// 
					// 
					// 
					this.line1.Gradient.Visible = true;
					this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
					this.line1.ColorEach = false;
					this.line1.DataSource = this.candle1;
					this.line1.Function = this.sarFunction1;
					// 
					// 
					// 
					this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
					// 
					// 
					// 
					// 
					// 
					// 
					this.line1.Marks.Brush.Visible = false;
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
					this.line1.Marks.Callout.Visible = false;
					this.line1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;
					this.line1.Marks.Transparent = true;
					this.line1.Marks.Visible = true;
					// 
					// 
					// 
					this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
					this.line1.Pointer.Visible = true;
					this.line1.Title = "SAR";
					// 
					// 
					// 
					this.line1.XValues.DateTime = true;
					this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
					// 
					// 
					// 
					this.line1.YValues.DataMember = "Close";
					// 
					// sarFunction1
					// 
					this.sarFunction1.AccelerationFactor = 0.019999999552965164;
					this.sarFunction1.MaxStep = 0.30000001192092896;
					// 
					// label1
					// 
					this.label1.AutoSize = true;
					this.label1.Location = new System.Drawing.Point(12, 13);
					this.label1.Name = "label1";
					this.label1.Size = new System.Drawing.Size(96, 13);
					this.label1.TabIndex = 0;
					this.label1.Text = "Acceleration factor";
					// 
					// textBox2
					// 
					this.textBox2.Location = new System.Drawing.Point(114, 10);
					this.textBox2.Name = "textBox2";
					this.textBox2.Size = new System.Drawing.Size(100, 20);
					this.textBox2.TabIndex = 1;
					this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
					// 
					// Function_SAR
					// 
					this.ClientSize = new System.Drawing.Size(440, 317);
					this.Name = "Function_SAR";
					this.Load += new System.EventHandler(this.Function_SAR_Load);
					this.panel1.ResumeLayout(false);
					this.panel1.PerformLayout();
					this.chartContainer.ResumeLayout(false);
					this.ResumeLayout(false);
					this.PerformLayout();

        }

        #endregion

        private void Function_SAR_Load(object sender, EventArgs e)
        {
            textBox2.Text = sarFunction1.AccelerationFactor.ToString("0.00");
            setting = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!setting)
                sarFunction1.AccelerationFactor = Convert.ToDouble(textBox2.Text);
        }
    }
}

