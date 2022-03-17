using System;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    /// <summary>
    /// Summary description for WelcomeForm.
    /// </summary>
    public class WelcomeForm : System.Windows.Forms.Form
    {
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Pie pieSeries1;
        private Steema.TeeChart.Styles.Line lineSeries1;
        private Steema.TeeChart.Styles.Line lineSeries2;
        private Steema.TeeChart.Styles.FastLine fastLineSeries1;
        private System.Timers.Timer timer1;

        private bool scaled = false;

        private struct BannerText
        {
            public int tmpSize;
            public int DeltaSize;
            public int tmpSizeCount;
            public int tmpX, tmpY;
            public int DeltaX, DeltaY;
            public string SomeText;
        }

        private Steema.TeeChart.Styles.Series TheSeries;
        private readonly BannerText[] bt = new BannerText[3];
        private int Delta, DeltaRot, DeltaElev;
        private readonly System.Random r;


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly System.ComponentModel.Container components = null;

        public WelcomeForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            // constants to rotate...
            // fill the series
            pieSeries1.FillSampleValues(7);

            //Color set with transparency
            pieSeries1.Colors[0] = Color.FromArgb(120, 224, 77, 44);
            pieSeries1.Colors[1] = Color.FromArgb(120, 244, 158, 54);
            pieSeries1.Colors[2] = Color.FromArgb(120, 251, 197, 65);
            pieSeries1.Colors[3] = Color.FromArgb(120, 254, 236, 58);
            pieSeries1.Colors[4] = Color.FromArgb(120, 154, 183, 194);
            pieSeries1.Colors[5] = Color.FromArgb(120, 50, 99, 125);
            pieSeries1.Colors[6] = Color.FromArgb(120, 28, 63, 95);
            pieSeries1.Colors[7] = Color.FromArgb(120, 170, 155, 51);

            lineSeries1.FillSampleValues(30);
            lineSeries2.FillSampleValues(30);
            fastLineSeries1.FillSampleValues(50);
            Delta = 1;
            DeltaElev = 1;
            DeltaRot = 1;
            TheSeries = pieSeries1;
            tChart1.Aspect.Zoom = 1;
            tChart1.Aspect.Orthogonal = false;
            tChart1.Aspect.Elevation = 315;
            tChart1.Aspect.Rotation = 360;
            tChart1.Aspect.Perspective = 0;
            tChart1.Aspect.Chart3DPercent = 40;

            r = new Random();

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            tChart1 = new Steema.TeeChart.TChart();
            pieSeries1 = new Steema.TeeChart.Styles.Pie();
            lineSeries1 = new Steema.TeeChart.Styles.Line();
            lineSeries2 = new Steema.TeeChart.Styles.Line();
            fastLineSeries1 = new Steema.TeeChart.Styles.FastLine();
            timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(timer1)).BeginInit();
            SuspendLayout();
            // 
            // tChart1
            // 
            // 
            // tChart1.Aspect
            // 
            tChart1.Aspect.Elevation = 315;
            tChart1.Aspect.Orthogonal = false;
            tChart1.Aspect.Perspective = 0;
            tChart1.Aspect.Rotation = 360;


            tChart1.BackColor = System.Drawing.Color.White;
            tChart1.Cursor = Cursors.Default;
            tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // tChart1.Header
            // 
            tChart1.Header.Lines = new string[] {
                                                                                                 "tChart1"};
            tChart1.Header.Visible = false;
            // 
            // tChart1.Legend
            // 
            tChart1.Legend.Visible = false;
            tChart1.Location = new System.Drawing.Point(0, 0);
            tChart1.Name = "tChart1";
            // 
            // tChart1.Panel
            // 
            // 
            // tChart1.Panel.Bevel
            // 
            tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // tChart1.Panel.Brush
            // 
            tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(254, 255, 255, 255);
            // 
            // tChart1.Panel.Gradient
            // 
            //this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(21)), ((System.Byte)(60)), ((System.Byte)(89)));
            //this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
            //this.tChart1.Panel.Gradient.Sigma = true;
            //this.tChart1.Panel.Gradient.SigmaFocus = 1F;
            //this.tChart1.Panel.Gradient.SigmaScale = 0.8F;
            //this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
            tChart1.Panel.Gradient.UseMiddle = true;
            tChart1.Panel.Gradient.Visible = true;
            tChart1.Series.Add(pieSeries1);
            tChart1.Series.Add(lineSeries1);
            tChart1.Series.Add(lineSeries2);
            tChart1.Series.Add(fastLineSeries1);
            tChart1.Size = new System.Drawing.Size(393, 279);
            tChart1.TabIndex = 0;
            tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(tChart1_AfterDraw);
            tChart1.BeforeDraw += new Steema.TeeChart.PaintChartEventHandler(tChart1_BeforeDraw);
            // 
            // pieSeries1
            // 
            // 
            // pieSeries1.Brush
            // 
            pieSeries1.Brush.Color = System.Drawing.Color.Red;
            pieSeries1.CircleBackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pieSeries1.ExplodeBiggest = 30;
            pieSeries1.LabelMember = "Labels";
            // 
            // pieSeries1.Marks
            // 
            // 
            // pieSeries1.Marks.Symbol
            // 
            // 
            // pieSeries1.Marks.Symbol.Shadow
            // 
            pieSeries1.Marks.Symbol.Shadow.Height = 1;
            pieSeries1.Marks.Symbol.Shadow.Visible = true;
            pieSeries1.Marks.Symbol.Shadow.Width = 1;
            // 
            // pieSeries1.Pen
            // 
            pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(254, 192, 192, 192);
            // 
            // pieSeries1.Shadow
            // 
            pieSeries1.Shadow.Height = 20;
            pieSeries1.Shadow.Width = 20;
            pieSeries1.Title = "pie1";
            // 
            // pieSeries1.XValues
            // 
            pieSeries1.XValues.DataMember = "Angle";
            pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // pieSeries1.YValues
            // 
            pieSeries1.YValues.DataMember = "Pie";
            // 
            // lineSeries1
            // 
            // 
            // lineSeries1.Brush
            // 
            lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(198, 255, 199, 26);
            // 
            // lineSeries1.Gradient
            // 
            lineSeries1.Brush.Gradient.Transparency = 25;
            // 
            // lineSeries1.Gradient
            // 
            lineSeries1.Gradient.Transparency = 25;
            // 
            // lineSeries1.LinePen
            // 
            lineSeries1.LinePen.Visible = false;
            // 
            // lineSeries1.Marks
            // 
            // 
            // lineSeries1.Marks.Symbol
            // 
            // 
            // lineSeries1.Marks.Symbol.Shadow
            // 
            lineSeries1.Marks.Symbol.Shadow.Height = 1;
            lineSeries1.Marks.Symbol.Shadow.Visible = true;
            lineSeries1.Marks.Symbol.Shadow.Width = 1;
            // 
            // lineSeries1.Pointer
            // 
            lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            lineSeries1.Title = "line2";
            lineSeries1.Visible = false;
            // 
            // lineSeries1.XValues
            // 
            lineSeries1.XValues.DataMember = "X";
            lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // lineSeries1.YValues
            // 
            lineSeries1.YValues.DataMember = "Y";
            // 
            // lineSeries2
            // 
            // 
            // lineSeries2.Brush
            // 
            lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(198, 106, 106, 255);
            // 
            // lineSeries2.Gradient
            // 
            lineSeries2.Brush.Gradient.Transparency = 35;
            // 
            // lineSeries2.Gradient
            // 
            lineSeries2.Gradient.Transparency = 35;
            // 
            // lineSeries2.LinePen
            // 
            lineSeries2.LinePen.Visible = false;
            // 
            // lineSeries2.Marks
            // 
            // 
            // lineSeries2.Marks.Symbol
            // 
            // 
            // lineSeries2.Marks.Symbol.Shadow
            // 
            lineSeries2.Marks.Symbol.Shadow.Height = 1;
            lineSeries2.Marks.Symbol.Shadow.Visible = true;
            lineSeries2.Marks.Symbol.Shadow.Width = 1;
            // 
            // lineSeries2.Pointer
            // 
            lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            lineSeries2.Title = "line3";
            lineSeries2.Visible = false;
            // 
            // lineSeries2.XValues
            // 
            lineSeries2.XValues.DataMember = "X";
            lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // lineSeries2.YValues
            // 
            lineSeries2.YValues.DataMember = "Y";
            // 
            // fastLineSeries1
            // 
            // 
            // fastLineSeries1.LinePen
            // 
            fastLineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(255, 255, 204);
            // 
            // fastLineSeries1.Marks
            // 
            // 
            // fastLineSeries1.Marks.Symbol
            // 
            // 
            // fastLineSeries1.Marks.Symbol.Shadow
            // 
            fastLineSeries1.Marks.Symbol.Shadow.Height = 1;
            fastLineSeries1.Marks.Symbol.Shadow.Visible = true;
            fastLineSeries1.Marks.Symbol.Shadow.Width = 1;
            fastLineSeries1.Title = "fast Line4";
            fastLineSeries1.Visible = false;
            // 
            // fastLineSeries1.XValues
            // 
            fastLineSeries1.XValues.DataMember = "X";
            fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // fastLineSeries1.YValues
            // 
            fastLineSeries1.YValues.DataMember = "Y";
            // 
            // timer1
            // 
            timer1.SynchronizingObject = this;
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Elapsed);
            // 
            // WelcomeForm
            // 
            AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(393, 279);
            Controls.Add(tChart1);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += new System.EventHandler(WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(timer1)).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void tChart1_Click(object sender, System.EventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, System.EventArgs e)
        {
            bt[0].tmpSizeCount = 0;
            bt[0].tmpSize = 4;
            bt[0].DeltaSize = 1;
            bt[0].tmpX = 0;
            bt[0].tmpY = 0;
            bt[0].DeltaX = 2;
            bt[0].DeltaY = 4;
            bt[0].SomeText = "100% Source Code";

            bt[1].tmpSizeCount = 1;
            bt[1].tmpSize = 12;
            bt[1].DeltaSize = -1;
            bt[1].tmpX = 0;
            bt[1].tmpY = tChart1.Height - 30;
            bt[1].DeltaX = 1;
            bt[1].DeltaY = -3;
            bt[1].SomeText = "For all .NET developers";

            bt[2].tmpSizeCount = 3;
            bt[2].tmpSize = 2;
            bt[2].DeltaSize = 1;
            bt[2].tmpX = tChart1.Width - 50;
            bt[2].tmpY = tChart1.Height - 30;
            bt[2].DeltaX = -2;
            bt[2].DeltaY = -2;
            bt[2].SomeText = "Visit our Web Site !";

            timer1.Interval = 50;
            timer1.Start();
        }

        private void DrawBannerText()
        {
            Steema.TeeChart.Drawing.IGraphics3D c = tChart1.Graphics3D;
            c.Font.Color = Color.Gray;
            c.Font.Shadow.Height = 1;
            c.Font.Shadow.Width = 1;
            for (var i = 0; i < bt.Length; i++)
            {
                bt[i].tmpSizeCount += 1;
                if (bt[i].tmpSizeCount >= 1)
                {
                    bt[i].tmpSizeCount = 0;
                    bt[i].tmpSize += bt[i].DeltaSize;
                    if (bt[i].tmpSize < 2)
                    {
                        bt[i].DeltaSize = 1;
                    }
                    else if (bt[i].tmpSize > 22)
                    {
                        bt[i].DeltaSize = -1;
                    }
                }

                if (bt[i].tmpSize > 0)
                {
                    c.Font.Size = bt[i].tmpSize;
                    bt[i].tmpX += bt[i].DeltaX;

                    if ((bt[i].tmpX < -30) || (bt[i].tmpX > tChart1.Width))
                    {
                        bt[i].DeltaX = -bt[i].DeltaX;
                    }

                    bt[i].tmpY += bt[i].DeltaY;
                    if ((bt[i].tmpY < 0) || (bt[i].tmpY > tChart1.Height))
                    {
                        bt[i].DeltaY = -bt[i].DeltaY;
                    }

                    c.TextOut(bt[i].tmpX, bt[i].tmpY, bt[i].SomeText);
                }
            }
        }

        private void AddPoint(Steema.TeeChart.Styles.Series s)
        {
            s.Add(s.XValues.Last + 1, s.YValues.Last + r.Next(40) - 20.0);
            s.Delete(0);
        }
        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer1.Stop();
            var asp = tChart1.Aspect;
            // Pie series, do rotation...
            if (TheSeries is Steema.TeeChart.Styles.Pie)
            {
                (TheSeries as Steema.TeeChart.Styles.Pie).RotationAngle += 2;
            }
            else
            {
                if (!scaled)
                {
                    //Axis
                    tChart1.Axes.Left.Increment = (tChart1.Axes.Left.Maximum - tChart1.Axes.Left.Minimum) / 10;
                    scaled = true;
                }


                // scroll points...
                AddPoint(lineSeries1);
                AddPoint(lineSeries2);
                AddPoint(fastLineSeries1);
                // change 3D view (rotation / elevation) ...
                asp.Elevation += DeltaElev;
                if ((asp.Elevation > 320) || (asp.Elevation < 280))
                {
                    DeltaElev = -DeltaElev;
                }

                asp.Rotation += DeltaRot;
                if ((asp.Rotation > 355) || (asp.Rotation < 272))
                {
                    DeltaRot = -DeltaRot;
                }
            }
            // change view Zoom...
            asp.Zoom += Delta;
            // reverse zoom-in / zoom-out
            if ((asp.Zoom > 200) || (asp.Zoom < 2))
            {
                Delta = -Delta;
            }

            //	change from Pie to Lines..,
            if (asp.Zoom > 200)
            {
                pieSeries1.Active = false;
                lineSeries1.Active = false;
                lineSeries2.Active = false;
                fastLineSeries1.Active = false;
                if (TheSeries == pieSeries1)
                {
                    TheSeries = lineSeries1;
                    lineSeries1.Active = true;
                    lineSeries2.Active = true;
                    fastLineSeries1.Active = true;
                    asp.Perspective = 85;
                    asp.Rotation = 300;
                }
                else
                {
                    TheSeries = pieSeries1;
                    asp.Rotation = 360;
                    TheSeries.Active = true;
                }
            }
            // re-start the timer...
            timer1.Start();
        }

        private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            if (TheSeries is Steema.TeeChart.Styles.Pie)
            {
                DrawBannerText();
            }
        }

        private void tChart1_BeforeDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            if (!(TheSeries is Steema.TeeChart.Styles.Pie))
            {
                DrawBannerText();
            }
        }
    }
}
