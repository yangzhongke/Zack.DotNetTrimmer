using System;
using System.Windows.Forms;
using Steema.TeeChart.Editors;
using Steema.TeeChart.Editors.Tools;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Themes;
using Steema.TeeChart.Tools;

namespace Steema.TeeChart.Samples
{
    public class Tools_ScrollPager : BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly System.ComponentModel.IContainer components = null;

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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools_ScrollPager));
            button1 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            chartContainer.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
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
            tChart1.Axes.Bottom.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Bottom.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Bottom.Labels.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Bottom.Labels.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Bottom.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Bottom.Title.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Bottom.Title.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Depth.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Depth.Labels.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Depth.Labels.Bevel.StringColorTwo = "FF808080";
            tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Depth.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Depth.Title.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Depth.Title.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.DepthTop.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.DepthTop.Labels.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.DepthTop.Labels.Bevel.StringColorTwo = "FF808080";
            tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.DepthTop.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.DepthTop.Title.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.DepthTop.Title.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Left.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Left.Labels.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Left.Labels.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Left.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Left.Title.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Left.Title.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Right.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Right.Labels.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Right.Labels.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Right.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Right.Title.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Right.Title.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Top.Labels.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Top.Labels.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Top.Labels.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Axes.Top.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Axes.Top.Title.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Axes.Top.Title.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Footer.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Footer.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Footer.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Header.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Header.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Header.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Legend.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Legend.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Legend.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Legend.Title.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Legend.Title.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Legend.Title.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Panel.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Panel.Bevel.StringColorTwo = "FF808080";
            tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.SubFooter.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.SubFooter.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.SubFooter.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.SubHeader.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.SubHeader.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.SubHeader.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Back.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Walls.Back.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Walls.Back.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Walls.Back.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Walls.Bottom.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Walls.Bottom.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Walls.Bottom.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Walls.Left.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Walls.Left.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Walls.Left.Bevel.StringColorTwo = "FF808080";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.Bevel.ColorOne = System.Drawing.Color.FromArgb(255, 255, 255);
            tChart1.Walls.Right.Bevel.ColorTwo = System.Drawing.Color.FromArgb(128, 128, 128);
            tChart1.Walls.Right.Bevel.StringColorOne = "FFFFFFFF";
            tChart1.Walls.Right.Bevel.StringColorTwo = "FF808080";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 10);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Edit...";
#if VS2005
            button1.UseVisualStyleBackColor = true;
#endif
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // Tools_ScrollPager
            // 
#if VS2005
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
            ClientSize = new System.Drawing.Size(440, 317);
            Name = "Tools_ScrollPager";
            Text = "Tools_ScrollPager";
            SizeChanged += new System.EventHandler(Tools_ScrollPager_SizeChanged);
            panel1.ResumeLayout(false);
            chartContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public Tools_ScrollPager()
        {
            InitializeComponent();
            InitializeChart();
        }

        private FastLine series;
        private ScrollPager tool;
        private Button button1;
        private NearestPoint point;
        private Annotation annotate;

        private void InitializeChart()
        {
            tChart1.Header.Text = "Scroll Pager Tool";
            tChart1.Series.Add(series = new FastLine());
            series.FillSampleValues(1000);
            tChart1.Tools.Add(tool = new ScrollPager());
            tChart1.Tools.Add(point = new NearestPoint());
            tChart1.Tools.Add(annotate = new Annotation());

            point.Brush.Color = tool.PointerHighlightColor;
            point.DrawLine = false;
            point.Size = 6;
            point.Direction = NearestPointDirection.Horizontal;
            point.Series = series;
            point.Change += new EventHandler(point_Change);

            annotate.Position = AnnotationPositions.RightTop;
            annotate.Text = "YValue:";
            annotate.Shape.Shadow.Visible = false;
            annotate.Shape.Font.Color = tChart1.Header.Font.Color;
            annotate.Shape.Color = tool.PointerHighlightColor;
            annotate.Shape.Pen.Visible = false;
            annotate.TextAlign = Drawing.StringAlignment.Center;

            Theme.ApplyChartTheme(typeof(FlatTheme), tool.SubChartTChart.Chart);
        }

        private void point_Change(object sender, EventArgs e)
        {
            if (point.Point > -1)
            {
                annotate.Text = "YValue: " + series.YValues[point.Point];
            }
        }

        private void Tools_ScrollPager_SizeChanged(object sender, EventArgs e)
        {
            if(tool != null)
            {
                tool.Series = series;

                tool.SubChartTChart.Panel.Pen.Visible = false;
                tool.SubChartTChart.Panel.Bevel.Inner = Drawing.BevelStyles.None;
                tool.SubChartTChart.Panel.Bevel.Outer = Drawing.BevelStyles.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var editor = new ScrollPagerEditor(tool);
            Steema.TeeChart.Editors.EditorUtils.Translate(editor);
            EditorUtils.ShowFormModal(editor);
        }
    }
}
