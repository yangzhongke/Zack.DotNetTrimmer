using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
    public class CircularGauge_Embed : BaseForm
    {
        private Timer timer1;
        private ComboBox cbPalette;
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            cbPalette = new System.Windows.Forms.ComboBox();
            panel1.SuspendLayout();
            chartContainer.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Text = "Using a very simple technique demonstrated here, multiple Numeric Gauges\r\nand/or " +
                "LinearGauges can be embedded in a CircularGauge.";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbPalette);
            panel1.Controls.Add(label1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.PartnerAxis = null;
            tChart1.Axes.Bottom.UsePartnerAxis = false;
            // 
            // 
            // 
            tChart1.Axes.Depth.PartnerAxis = null;
            tChart1.Axes.Depth.UsePartnerAxis = false;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.PartnerAxis = null;
            tChart1.Axes.DepthTop.UsePartnerAxis = false;
            // 
            // 
            // 
            tChart1.Axes.Left.PartnerAxis = null;
            tChart1.Axes.Left.UsePartnerAxis = false;
            // 
            // 
            // 
            tChart1.Axes.Right.PartnerAxis = null;
            tChart1.Axes.Right.UsePartnerAxis = false;
            // 
            // 
            // 
            tChart1.Axes.Top.PartnerAxis = null;
            tChart1.Axes.Top.UsePartnerAxis = false;
            // 
            // 
            // 
            tChart1.Legend.TextSymbolGap = 0;
            tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 0;
            label1.Text = "Palette:";
            // 
            // cbPalette
            // 
#if VS2005
      this.cbPalette.FormattingEnabled = true;
#endif
            cbPalette.Location = new System.Drawing.Point(61, 11);
            cbPalette.Name = "cbPalette";
            cbPalette.Size = new System.Drawing.Size(217, 21);
            cbPalette.TabIndex = 1;
            cbPalette.SelectedIndexChanged += new System.EventHandler(cbPalette_SelectedIndexChanged);
            // 
            // CircularGauge_Embed
            // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
            ClientSize = new System.Drawing.Size(440, 317);
            Name = "CircularGauge_Embed";
            Text = "CircularGauge_Embed";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            chartContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public CircularGauge_Embed()
        {
            InitializeComponent();
            FillComboBox();
            InitializeChart();
        }

        private void FillComboBox()
        {
            cbPalette.Items.Add("Current");
            cbPalette.Items.Add("BlackPalette");
            cbPalette.Items.Add("BluesPalette");
            cbPalette.Items.AddRange(Steema.TeeChart.Themes.Theme.ColorPalettes.ToArray());
            cbPalette.SelectedIndex = 0;
        }

        private CircularGauge cGauge;
        private NumericGauge nGauge;
        private LinearGauge lGauge;

        private void InitializeChart()
        {
            tChart1.Series.Add(cGauge = new CircularGauge());
            cGauge.RotationAngle = 270;
            cGauge.TotalAngle = 180;
            cGauge.Axis.Labels.Font.Size = 7;
            cGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, cGauge.GaugeColorPalette);
            cGauge.RedLine.Visible = false;
            cGauge.GreenLine.Visible = false;
            cGauge.BeforeDrawHand += new PaintChartEventHandler(cGauge_BeforeDrawHand);
            cGauge.Value = 1;

            timer1.Enabled = true;

            SetUpNGauge();
            SetUpLGauge();
        }

        private void SetUpLGauge()
        {
            var axisH = new Axis
            {
                Horizontal = true
            };
            var axisV = new Axis
            {
                Horizontal = false
            };
            lGauge = new LinearGauge
            {
                HorizAxis = HorizontalAxis.Custom,
                VertAxis = VerticalAxis.Custom,
                Horizontal = false,
                Visible = false,
                CustomHorizAxis = axisH,
                CustomVertAxis = axisV
            };
            lGauge.Axis.Title.Font.Size = 7;
            lGauge.Axis.Title.Font.Color = CustomGauge.GetGaugePaletteColor(20, lGauge.GaugeColorPalette);
            lGauge.Axis.Title.Caption = "Independent value";
            lGauge.Axis.Labels.Font.Size = 6;
            lGauge.Axis.Labels.Font.Color = CustomGauge.GetGaugePaletteColor(20, lGauge.GaugeColorPalette);
            lGauge.Axis.Increment = 20;
            lGauge.RedLine.Visible = false;
            lGauge.GreenLine.Visible = false;
            lGauge.Frame.Visible = false;
            lGauge.FaceBrush.Visible = false;
        }

        private void SetUpNGauge()
        {
            var axis = new Axis
            {
                Horizontal = true
            };
            nGauge = new NumericGauge
            {
                HorizAxis = HorizontalAxis.Custom,
                CustomHorizAxis = axis,
                Visible = false
            };
            nGauge.TextMarker.Active = false;
            nGauge.UnitsMarker.Active = false;
            nGauge.Horizontal = true;
            nGauge.ValueFormat = "###.0";
            nGauge.ValueMarker.Active = true;
            nGauge.ValueMarker.Shape.Font.Size = 14;
        }


        private Rectangle CalcLGaugeBounds()
        {
            var result = Steema.TeeChart.Utils.FromLTRB(cGauge.CircleXCenter + (cGauge.CircleWidth / 7),
              cGauge.CircleYCenter - (cGauge.CircleHeight / 3), cGauge.CircleXCenter + (cGauge.CircleWidth / 4),
              cGauge.CircleYCenter + (cGauge.CircleHeight / 3));
            return result;
        }

        private Rectangle CalcNGaugeBounds()
        {
            var result = Steema.TeeChart.Utils.FromLTRB(cGauge.CircleXCenter - Steema.TeeChart.Utils.Round(cGauge.CircleWidth / 3.75),
              cGauge.CircleYCenter - (cGauge.CircleHeight / 10), cGauge.CircleXCenter - (cGauge.CircleWidth / 12),
              cGauge.CircleYCenter + (cGauge.CircleHeight / 10));
            return result;
        }

        private void DrawNGauge(IGraphics3D g)
        {
            nGauge.Value = cGauge.Value;
            nGauge.CustomBounds = CalcNGaugeBounds();
            nGauge.Draw(g);
        }

        private readonly Random rnd = new Random();

        private void DrawLGauge(IGraphics3D g)
        {
            lGauge.Value = rnd.Next(0, 100);
            lGauge.CustomBounds = CalcLGaugeBounds();
            lGauge.Draw(g);
        }

        private void cGauge_BeforeDrawHand(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            DrawNGauge(g);
            DrawLGauge(g);
        }


        private bool up = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((int)cGauge.Value == 100 || (int)cGauge.Value == 0.0)
            {
                up = !up;
            }

            if (up)
            {
                cGauge.Value += 0.1;
            }
            else
            {
                cGauge.Value -= 0.1;
            }
        }

        private void ApplyPalette(Color[] palette)
        {
            cGauge.GaugeColorPalette = palette;
            cGauge.GreenLine.Visible = false;
            cGauge.RedLine.Visible = false;
            lGauge.GaugeColorPalette = palette;
            lGauge.GreenLine.Visible = false;
            lGauge.RedLine.Visible = false;
            lGauge.FaceBrush.Visible = false;
            lGauge.Hand.Pen.Visible = false;
        }

        private void cbPalette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPalette.SelectedIndex > 2)
            {
                ApplyPalette(Steema.TeeChart.Themes.ColorPalettes.GetPalette(cbPalette.SelectedIndex - 3));
            }
            else if (cbPalette.SelectedIndex == 1)
            {
                ApplyPalette(Steema.TeeChart.Styles.CustomGauge.BlackPalette);
            }
            else if (cbPalette.SelectedIndex == 2)
            {
                ApplyPalette(Steema.TeeChart.Styles.CustomGauge.BluesPalette);
            }
        }
    }
}
