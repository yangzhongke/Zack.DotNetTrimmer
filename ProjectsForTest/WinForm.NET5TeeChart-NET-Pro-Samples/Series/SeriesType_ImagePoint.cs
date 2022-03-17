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
    public class SeriesType_ImagePoint : Steema.TeeChart.Samples.BaseForm
    {
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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriesType_ImagePoint));
				this.imagePoint1 = new Steema.TeeChart.Styles.ImagePoint();
				this.label1 = new System.Windows.Forms.Label();
				this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
				this.label2 = new System.Windows.Forms.Label();
				this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
				this.pictureBox1 = new System.Windows.Forms.PictureBox();
				this.label3 = new System.Windows.Forms.Label();
				this.panel1.SuspendLayout();
				this.chartContainer.SuspendLayout();
				((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
				((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
#if VS2005
				((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
#endif
				this.SuspendLayout();
				// 
				// textBox1
				// 
				this.textBox1.Text = "The ImagePoint style uses custom image to paint individual points.\r\nSize is contr" +
						"olled using the ImagePoint.Pointer properties.";
				// 
				// panel1
				// 
				this.panel1.Controls.Add(this.label3);
				this.panel1.Controls.Add(this.pictureBox1);
				this.panel1.Controls.Add(this.numericUpDown2);
				this.panel1.Controls.Add(this.label2);
				this.panel1.Controls.Add(this.numericUpDown1);
				this.panel1.Controls.Add(this.label1);
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
				this.tChart1.Series.Add(this.imagePoint1);
				this.tChart1.Size = new System.Drawing.Size(440, 205);
				// 
				// imagePoint1
				// 
				this.imagePoint1.ColorEach = false;
				// 
				// 
				// 
				// 
				// 
				// 
				this.imagePoint1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
				this.imagePoint1.Marks.Callout.ArrowHeadSize = 8;
				// 
				// 
				// 
				this.imagePoint1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
				this.imagePoint1.Marks.Callout.Distance = 0;
				this.imagePoint1.Marks.Callout.Draw3D = false;
				this.imagePoint1.Marks.Callout.Length = 0;
				this.imagePoint1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
				// 
				// 
				// 
				this.imagePoint1.Pointer.HorizSize = 8;
				this.imagePoint1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
				this.imagePoint1.Pointer.VertSize = 8;
				this.imagePoint1.Pointer.Visible = true;
				//this.imagePoint1.PointImage = ((System.Drawing.Image)(resources.GetObject("imagePoint1.PointImage")));
				this.imagePoint1.Title = "point1";
				this.imagePoint1.Transparent = true;
				// 
				// 
				// 
				this.imagePoint1.XValues.DataMember = "X";
				this.imagePoint1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
				// 
				// 
				// 
				this.imagePoint1.YValues.DataMember = "Y";
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(119, 14);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(35, 13);
				this.label1.TabIndex = 0;
				this.label1.Text = "Width";
				// 
				// numericUpDown1
				// 
				this.numericUpDown1.Location = new System.Drawing.Point(160, 12);
				this.numericUpDown1.Name = "numericUpDown1";
				this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
				this.numericUpDown1.TabIndex = 1;
				this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
				this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(221, 14);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(38, 13);
				this.label2.TabIndex = 2;
				this.label2.Text = "Height";
				// 
				// numericUpDown2
				// 
				this.numericUpDown2.Location = new System.Drawing.Point(265, 12);
				this.numericUpDown2.Name = "numericUpDown2";
				this.numericUpDown2.Size = new System.Drawing.Size(42, 20);
				this.numericUpDown2.TabIndex = 3;
				this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
				this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
				// 
				// pictureBox1
				// 
				this.pictureBox1.Location = new System.Drawing.Point(52, 6);
				this.pictureBox1.Name = "pictureBox1";
				this.pictureBox1.Size = new System.Drawing.Size(34, 30);
				this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				this.pictureBox1.TabIndex = 4;
				this.pictureBox1.TabStop = false;
				this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(10, 11);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(36, 13);
				this.label3.TabIndex = 5;
				this.label3.Text = "Image";
				// 
				// SeriesType_ImagePoint
				// 
				this.ClientSize = new System.Drawing.Size(440, 317);
				this.Name = "SeriesType_ImagePoint";
				this.Load += new System.EventHandler(this.SeriesType_ImagePoint_Load);
				this.panel1.ResumeLayout(false);
				this.panel1.PerformLayout();
				this.chartContainer.ResumeLayout(false);
				((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
				((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
#if VS2005
				((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
#endif
				this.ResumeLayout(false);
				this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private Steema.TeeChart.Styles.ImagePoint imagePoint1;
      private System.Windows.Forms.NumericUpDown numericUpDown2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label3;
      
        public SeriesType_ImagePoint()
        {
            InitializeComponent();

						string s = "Steema.TeeChart.Samples.Utilities.images.point-image.bmp";
						System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
						//if(stream != null)
						//	imagePoint1.PointImage = Image.FromStream(stream);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            imagePoint1.Pointer.HorizSize = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            imagePoint1.Pointer.VertSize = (int)numericUpDown2.Value;
        }

        private void SeriesType_ImagePoint_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = imagePoint1.PointImage;
            imagePoint1.FillSampleValues();
            numericUpDown1.Value = imagePoint1.Pointer.HorizSize;
            numericUpDown2.Value = imagePoint1.Pointer.VertSize;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string filename = Steema.TeeChart.Editors.PictureDialog.FileName(this);
            if (filename.Length != 0)
            {
                //imagePoint1.PointImage = Image.FromFile(filename);
                //pictureBox1.Image = imagePoint1.PointImage;
                numericUpDown1.Value = imagePoint1.Pointer.HorizSize;
                numericUpDown2.Value = imagePoint1.Pointer.VertSize;
            } 

        }
    }
}

