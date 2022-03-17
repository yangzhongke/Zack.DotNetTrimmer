using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class ImageBar : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.ImageBar imageBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.ButtonColor buttonColor1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public ImageBar()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			imageBar1.FillSampleValues();
			buttonColor1.Color = imageBar1.Color;
			imageBar1.ImageTiled = true;
			string s="Steema.TeeChart.Samples.Utilities.images.euro-coin.jpg";
      System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
   //   if (stream!=null) imageBar1.Image=Image.FromStream(stream);
			//pictureBox1.Image = imageBar1.Image;
			pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImageBar));
			this.imageBar1 = new Steema.TeeChart.Styles.ImageBar();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.buttonColor1 = new Steema.TeeChart.ButtonColor();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The Image Bar series displays bar points filled with a custom image.\r\nThe image c" +
				"an be \"tiled\" or \"stretched\".";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonColor1);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Image Bar Series"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.imageBar1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// imageBar1
			// 
			// 
			// imageBar1.Brush
			// 
			this.imageBar1.Brush.Color = System.Drawing.Color.Red;
			//this.imageBar1.Image = ((System.Drawing.Image)(resources.GetObject("imageBar1.Image")));
			this.imageBar1.ImageTiled = false;
			// 
			// imageBar1.Marks
			// 
			// 
			// imageBar1.Marks.Symbol
			// 
			// 
			// imageBar1.Marks.Symbol.Shadow
			// 
			this.imageBar1.Marks.Symbol.Shadow.Height = 1;
			this.imageBar1.Marks.Symbol.Shadow.Visible = true;
			this.imageBar1.Marks.Symbol.Shadow.Width = 1;
			this.imageBar1.Title = "imageBar1";
			// 
			// imageBar1.XValues
			// 
			this.imageBar1.XValues.DataMember = "X";
			this.imageBar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// imageBar1.YValues
			// 
			this.imageBar1.YValues.DataMember = "Bar";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Image:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(56, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 24);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(104, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(56, 24);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Tiled";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(166, 9);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(80, 24);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "Color Each";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// buttonColor1
			// 
			this.buttonColor1.Color = System.Drawing.Color.Empty;
			this.buttonColor1.Location = new System.Drawing.Point(280, 8);
			this.buttonColor1.Name = "buttonColor1";
			this.buttonColor1.Size = new System.Drawing.Size(72, 23);
			this.buttonColor1.TabIndex = 4;
			this.buttonColor1.Text = "Color...";
			this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// ImageBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "ImageBar";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			imageBar1.ImageTiled = checkBox1.Checked;
		}

		private void checkBox2_Click(object sender, System.EventArgs e)
		{
			imageBar1.ColorEach = checkBox2.Checked;
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
			
			string filename=Steema.TeeChart.Editors.PictureDialog.FileName(this);
			if (filename.Length!=0) 
			{
				//imageBar1.Image = Image.FromFile(filename);
				//pictureBox1.Image=imageBar1.Image;
			
			} 
		}

		private void buttonColor1_Click(object sender, System.EventArgs e)
		{
				imageBar1.Color = buttonColor1.Color;
		}
	}
}

