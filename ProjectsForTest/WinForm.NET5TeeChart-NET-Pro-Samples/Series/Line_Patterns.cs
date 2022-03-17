
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class Line_Patterns : Samples.BaseForm
    {
        private Steema.TeeChart.Styles.Line lineSeries1;
        private Steema.TeeChart.Styles.Line lineSeries2;
        private Steema.TeeChart.Styles.Line lineSeries3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        //private System.Windows.Forms.MainMenu mainMenu1;
        private Steema.TeeChart.Tools.GridBand gridBand1;
        private readonly System.ComponentModel.IContainer components = null;

        public Line_Patterns()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            foreach (var s in tChart1.Series)
            {
                s.FillSampleValues(10);
            }

            lineSeries1.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Tile;
            lineSeries2.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Tile;
            lineSeries3.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Tile;
            //this.lineSeries1.Brush.Image = this.pictureBox1.Image;
            //this.lineSeries2.Brush.Image = this.pictureBox2.Image;
            //this.lineSeries3.Brush.Image = this.pictureBox3.Image;
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

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new System.Resources.ResourceManager(typeof(Line_Patterns));
            lineSeries1 = new Steema.TeeChart.Styles.Line();
            lineSeries2 = new Steema.TeeChart.Styles.Line();
            lineSeries3 = new Steema.TeeChart.Styles.Line();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            //this.mainMenu1 = new System.Windows.Forms.MainMenu();
            gridBand1 = new Steema.TeeChart.Tools.GridBand();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(466, 63);
            textBox1.Text = "Small bitmap pictures can be used to fill Line series.\r\nClick the images to load " +
                "your custom small bitmaps...";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(466, 49);
            // 
            // tChart1
            // 
            // 
            // tChart1.Aspect
            // 
            //
            //
            // 
            // tChart1.Header
            // 
            tChart1.Header.Lines = new string[] {
                                                                                                 "tChart1"};
            tChart1.Header.Visible = false;
            tChart1.Name = "tChart1";
            // 
            // tChart1.Panel
            // 
            // 
            // tChart1.Panel.Brush
            // 
            tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(254, 255, 255, 255);
            tChart1.Series.Add(lineSeries1);
            tChart1.Series.Add(lineSeries2);
            tChart1.Series.Add(lineSeries3);
            tChart1.Size = new System.Drawing.Size(466, 174);
            tChart1.Tools.Add(gridBand1);
            // 
            // tChart1.Walls
            // 
            // 
            // tChart1.Walls.Bottom
            // 
            // 
            // tChart1.Walls.Bottom.Brush
            // 
            tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(254, 255, 255, 255);
            // 
            // tChart1.Walls.Bottom.Pen
            // 
            tChart1.Walls.Bottom.Pen.Visible = false;
            tChart1.Walls.Bottom.Size = 5;
            // 
            // tChart1.Walls.Left
            // 
            // 
            // tChart1.Walls.Left.Pen
            // 
            tChart1.Walls.Left.Pen.Visible = false;
            tChart1.Walls.Left.Size = 6;
            // 
            // lineSeries1
            // 
            // 
            // lineSeries1.Brush
            // 
            lineSeries1.Brush.Color = System.Drawing.Color.Red;
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
            // 
            // lineSeries1.Pointer.Brush
            // 
            lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(254, 0, 0, 0);
            lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            lineSeries1.Title = "lineSeries1";
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
            lineSeries2.Brush.Color = System.Drawing.Color.Green;
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
            // 
            // lineSeries2.Pointer.Brush
            // 
            lineSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(254, 0, 0, 0);
            lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            lineSeries2.Title = "lineSeries2";
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
            // lineSeries3
            // 
            // 
            // lineSeries3.Brush
            // 
            lineSeries3.Brush.Color = System.Drawing.Color.Yellow;
            // 
            // lineSeries3.Marks
            // 
            // 
            // lineSeries3.Marks.Symbol
            // 
            // 
            // lineSeries3.Marks.Symbol.Shadow
            // 
            lineSeries3.Marks.Symbol.Shadow.Height = 1;
            lineSeries3.Marks.Symbol.Shadow.Visible = true;
            lineSeries3.Marks.Symbol.Shadow.Width = 1;
            // 
            // lineSeries3.Pointer
            // 
            // 
            // lineSeries3.Pointer.Brush
            // 
            lineSeries3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(254, 0, 0, 0);
            lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            lineSeries3.Title = "lineSeries3";
            // 
            // lineSeries3.XValues
            // 
            lineSeries3.XValues.DataMember = "X";
            lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // lineSeries3.YValues
            // 
            lineSeries3.YValues.DataMember = "Y";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(13, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(34, 35);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "0";
            pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(60, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(33, 35);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "1";
            pictureBox2.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox3.Location = new System.Drawing.Point(107, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(33, 35);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "2";
            pictureBox3.Click += new System.EventHandler(pictureBox1_Click);
            // 
            // gridBand1
            // 
            gridBand1.Axis = tChart1.Axes.Left;
            // 
            // gridBand1.Band1
            // 
            gridBand1.Band1.Color = System.Drawing.Color.FromArgb(127, 224, 224, 224);
            // 
            // gridBand1.Band2
            // 
            gridBand1.Band2.Color = System.Drawing.Color.FromArgb(127, 255, 255, 255);
            // 
            // Line_Patterns
            // 
            AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            ClientSize = new System.Drawing.Size(466, 286);
            //this.Menu = this.mainMenu1;
            Name = "Line_Patterns";
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            var fileName = Steema.TeeChart.Editors.PictureDialog.FileName(this);

            if (fileName != "")
            {
                var pbox = sender as System.Windows.Forms.PictureBox;
                if (sender == pictureBox1)
                {
                }
                else if (sender == pictureBox2)
                {
                }
                else
                {
                }

                //    Steema.TeeChart.Styles.Line lineseries = (Steema.TeeChart.Styles.Line)this.tChart1.Series[SeriesIndex];
                //lineseries.Brush.Image = Image.FromFile(fileName);
                //pbox.Image = lineseries.Brush.Image;
            }
        }
    }
}

