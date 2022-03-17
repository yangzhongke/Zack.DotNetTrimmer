using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class Series_Renko : Steema.TeeChart.Samples.BaseForm
    {
        public Series_Renko()
        {
            InitializeComponent();
            candle1.FillSampleValues(20);
            
            // populate renko with closing values
            renko1.Clear();
            for (int i = 0; i < candle1.Count; i++)
                renko1.Add(candle1.CloseValues[i]);

            // box size set to 2
            renko1.BoxSize = 5;

            // link buttons to colors
            buttonColor1.Color = renko1.UpSwingColor;
            buttonColor2.Color = renko1.DownSwingColor;
        }


        private Steema.TeeChart.Styles.Candle candle1;
        private Steema.TeeChart.Styles.Renko renko1;
        private Label label1;
        private ButtonColor buttonColor2;
        private ButtonColor buttonColor1;
        private NumericUpDown numericUpDown1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Series_Renko));
            this.candle1 = new Steema.TeeChart.Styles.Candle();
            this.renko1 = new Steema.TeeChart.Styles.Renko();
            this.buttonColor1 = new Steema.TeeChart.ButtonColor();
            this.buttonColor2 = new Steema.TeeChart.ButtonColor();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonColor2);
            this.panel1.Controls.Add(this.buttonColor1);
            this.panel1.Size = new System.Drawing.Size(440, 69);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ElevationFloat = 345;
            this.tChart1.Aspect.RotationFloat = 345;
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Dash;
            this.tChart1.Axes.Bottom.Grid.ZPosition = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
            this.tChart1.Axes.Bottom.RelativePosition = 50;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
            
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Dash;
            this.tChart1.Axes.Depth.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
            
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
            
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Grid.Style = Drawing.DashStyle.Dash;
            this.tChart1.Axes.DepthTop.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Automatic = true;
            this.tChart1.Axes.Left.EndPosition = 50;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Dash;
            this.tChart1.Axes.Left.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Dash;
            this.tChart1.Axes.Right.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
            this.tChart1.Axes.Right.StartPosition = 50;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Dash;
            this.tChart1.Axes.Top.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
            this.tChart1.Axes.Top.Labels.Visible = false;
            this.tChart1.Axes.Top.RelativePosition = 100;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Shadow.Visible = false;
            
            // 
            // 
            // 
            this.tChart1.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Shadow.Visible = false;
            this.tChart1.Header.Lines = new string[] {
        "TeeChart"};
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Visible = false;
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Shadow.Visible = false;
            
            // 
            // 
            // 
            this.tChart1.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Shadow.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(0, 142);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Visible = false;
            this.tChart1.Series.Add(this.candle1);
            this.tChart1.Series.Add(this.renko1);
            this.tChart1.Size = new System.Drawing.Size(440, 175);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Shadow.Visible = false;
            
            // 
            // 
            // 
            this.tChart1.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.SubHeader.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Shadow.Visible = false;
            // 
            // candle1
            // 
            // 
            // 
            // 
            this.candle1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(165)))), ((int)(((byte)(161)))));
            this.candle1.CloseValues = this.candle1.YValues;
            this.candle1.DateValues = this.candle1.XValues;
            // 
            // 
            // 
            this.candle1.HighLowPen.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.candle1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(165)))), ((int)(((byte)(161)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.candle1.Marks.Callout.ArrowHeadSize = 8;
            this.candle1.Marks.Callout.Distance = 0;
            this.candle1.Marks.Callout.Draw3D = false;
            this.candle1.Marks.Callout.Length = 10;
            this.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.candle1.Marks.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.candle1.Pointer.Draw3D = false;
            this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.candle1.Pointer.Visible = true;
            this.candle1.Title = "Trading data";
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
            // renko1
            // 
            // 
            // 
            // 
            this.renko1.Brush.Color = System.Drawing.Color.White;
            this.renko1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Top;
            // 
            // 
            // 
            this.renko1.LinePen.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.renko1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.renko1.Marks.Callout.ArrowHeadSize = 8;
            this.renko1.Marks.Callout.Distance = 0;
            this.renko1.Marks.Callout.Draw3D = false;
            this.renko1.Marks.Callout.Length = 10;
            this.renko1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.renko1.Marks.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.renko1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.renko1.Title = "Renko (close values)";
            this.renko1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
            // 
            // 
            // 
            this.renko1.XValues.DataMember = "X";
            this.renko1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.renko1.YValues.DataMember = "Y";
            // 
            // buttonColor1
            // 
            this.buttonColor1.Color = System.Drawing.Color.Empty;
            this.buttonColor1.Location = new System.Drawing.Point(12, 6);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(105, 23);
            this.buttonColor1.TabIndex = 0;
            this.buttonColor1.Text = "Up swing";
#if VS2005
            this.buttonColor1.UseVisualStyleBackColor = true;
#endif
            this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.Color = System.Drawing.Color.Empty;
            this.buttonColor2.Location = new System.Drawing.Point(12, 35);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(105, 23);
            this.buttonColor2.TabIndex = 1;
            this.buttonColor2.Text = "Down swing";
#if VS2005
            this.buttonColor2.UseVisualStyleBackColor = true;
#endif
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Box size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(195, 9);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Series_Renko
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Series_Renko";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            renko1.BoxSize = (int)numericUpDown1.Value;
        }

        private void buttonColor1_Click(object sender, EventArgs e)
        {
            renko1.UpSwingColor = buttonColor1.Color;
        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            renko1.DownSwingColor = buttonColor2.Color;
        }
    }
}

