using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Steema.TeeChart.Samples
{
	public class ColorGrid_Bitmap : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
		private Steema.TeeChart.Styles.ColorGrid colorGrid1;
		private Steema.TeeChart.ButtonPen buttonPen1;
		private System.ComponentModel.IContainer components = null;

		public ColorGrid_Bitmap()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			buttonPen1.Pen = colorGrid1.Pen;
			comboBox1.SelectedIndex=0;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorGrid_Bitmap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorGrid1 = new Steema.TeeChart.Styles.ColorGrid();
            this.buttonPen1 = new Steema.TeeChart.ButtonPen();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
#if VS2005
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
#endif
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPen1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.colorGrid1);
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ Zoom";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(72, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "- Zoom";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Original Colors",
            "Color Range",
            "Color Palette"});
            this.comboBox1.Location = new System.Drawing.Point(136, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // colorGrid1
            // 
            // 
            // 
            // 
            this.colorGrid1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.colorGrid1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.colorGrid1.ColorEach = false;
            // 
            // 
            // 
            this.colorGrid1.Marks.ArrowLength = 0;
            // 
            // 
            // 
            this.colorGrid1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.colorGrid1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.colorGrid1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.colorGrid1.Marks.Callout.Distance = 0;
            this.colorGrid1.Marks.Callout.Draw3D = false;
            this.colorGrid1.Marks.Callout.Length = 0;
            this.colorGrid1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.colorGrid1.Marks.Callout.Visible = false;
            this.colorGrid1.PaletteMin = 0;
            this.colorGrid1.PaletteStep = 0;
            this.colorGrid1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            // 
            // 
            // 
            this.colorGrid1.Pen.Visible = false;
            this.colorGrid1.Title = "colorGrid1";
            this.colorGrid1.XStep = 1;
            // 
            // 
            // 
            this.colorGrid1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.colorGrid1.YValues.DataMember = "Y";
            this.colorGrid1.ZStep = 1;
            // 
            // 
            // 
            this.colorGrid1.ZValues.DataMember = "Z";
            // 
            // buttonPen1
            // 
            this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPen1.Location = new System.Drawing.Point(264, 8);
            this.buttonPen1.Name = "buttonPen1";
            this.buttonPen1.Size = new System.Drawing.Size(75, 23);
            this.buttonPen1.TabIndex = 4;
            this.buttonPen1.Text = "Grid...";
            // 
            // ColorGrid_Bitmap
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "ColorGrid_Bitmap";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
#if VS2005
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
#endif
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e) {
			tChart1.Zoom.ZoomPercent(105);
		}

		private void button2_Click(object sender, System.EventArgs e) {
			tChart1.Zoom.ZoomPercent(95);
		}

		private void SetFlower() {
			MemoryStream ms = new MemoryStream();
			Image flower = pictureBox1.Image;
			flower.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
			//Bitmap bm = new Bitmap(ms);
			//colorGrid1.Bitmap = bm;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch(comboBox1.SelectedIndex) {
				case 0:
					colorGrid1.UseColorRange=false;
					colorGrid1.UsePalette=false;
					SetFlower();
					break;
				case 1:
					colorGrid1.Colors.Clear();
					colorGrid1.UseColorRange=true;
					colorGrid1.UsePalette=false;
					break;
				case 2:
					colorGrid1.Colors.Clear();
					colorGrid1.UseColorRange=false;
					colorGrid1.UsePalette=true;
					break;
			}
		}
	}
}

