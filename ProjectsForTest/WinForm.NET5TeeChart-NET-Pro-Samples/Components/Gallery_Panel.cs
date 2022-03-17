using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class Gallery_Panel : Steema.TeeChart.Samples.BaseNoChart
    {
        private Steema.TeeChart.GalleryPanel galleryPanel1;
        private Steema.TeeChart.TChart tChart1;
        private System.ComponentModel.IContainer components = null;
        private Steema.TeeChart.Styles.Line lineSeries1;

        public Gallery_Panel()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            tChart1.Series.Add(lineSeries1 = new Steema.TeeChart.Styles.Line());
            lineSeries1.FillSampleValues(10);

            galleryPanel1.NumRows = 3;
            galleryPanel1.NumCols = 2;

            galleryPanel1.CreateGallerySeries(typeof(TeeChart.Styles.Line));
            galleryPanel1.CreateGallerySeries(typeof(TeeChart.Styles.Bar));
            galleryPanel1.CreateGallerySeries(typeof(TeeChart.Styles.Points));
            galleryPanel1.CreateGallerySeries(typeof(TeeChart.Styles.Area));
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
            this.galleryPanel1 = new Steema.TeeChart.GalleryPanel();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(426, 40);
            this.textBox1.Text = "GalleryPanel control displays chart styles.";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Size = new System.Drawing.Size(426, 36);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tChart1);
            this.panel2.Controls.Add(this.galleryPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Size = new System.Drawing.Size(426, 182);
            // 
            // galleryPanel1
            // 
            this.galleryPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.galleryPanel1.Location = new System.Drawing.Point(0, 0);
            this.galleryPanel1.Name = "galleryPanel1";
            this.galleryPanel1.Size = new System.Drawing.Size(167, 182);
            this.galleryPanel1.TabIndex = 0;
            this.galleryPanel1.OnSubSelected += new System.EventHandler(this.galleryPanel1_OnSubSelected);
            this.galleryPanel1.OnChangeChart += new System.EventHandler(this.galleryPanel1_OnChangeChart);
            // 
            // tChart1
            // 
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tChart1.Location = new System.Drawing.Point(167, 0);
            this.tChart1.Name = "tChart1";
            this.tChart1.Size = new System.Drawing.Size(259, 182);
            this.tChart1.TabIndex = 1;
            // 
            // Gallery_Panel
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(426, 258);
            this.Name = "Gallery_Panel";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void galleryPanel1_OnChangeChart(object sender, System.EventArgs e)
        {
            TeeChart.Styles.Series s = tChart1[0];

            TeeChart.Styles.Series.ChangeType(ref s,galleryPanel1.SelectedChart[0].GetType());
        }

        private void galleryPanel1_OnSubSelected(object sender, System.EventArgs e)
        {
            galleryPanel1.SetSubSelected(tChart1[0],(int)galleryPanel1.SelectedChart.Tag);
        }
    }
}

