using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Line_Pattern : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Styles.Line lineSeries3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		//private System.Windows.Forms.MainMenu mainMenu1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Line_Pattern()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(10);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Line_Pattern));
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.lineSeries2 = new Steema.TeeChart.Styles.Line();
			this.lineSeries3 = new Steema.TeeChart.Styles.Line();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			//this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Small bitmap pictures can be used to fill Line series.\r\nClick the images to load " +
				"your custom small bitmaps...";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 49);
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
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Series.Add(this.lineSeries2);
			this.tChart1.Series.Add(this.lineSeries3);
			this.tChart1.Size = new System.Drawing.Size(466, 174);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 6;
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries1.Pointer
			// 
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "lineSeries1";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.DataMember = "X";
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries1.YValues
			// 
			this.lineSeries1.YValues.DataMember = "Y";
			// 
			// lineSeries2
			// 
			// 
			// lineSeries2.Brush
			// 
			this.lineSeries2.Brush.Color = System.Drawing.Color.Green;
			// 
			// lineSeries2.Marks
			// 
			// 
			// lineSeries2.Marks.Symbol
			// 
			// 
			// lineSeries2.Marks.Symbol.Shadow
			// 
			this.lineSeries2.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries2.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries2.Pointer
			// 
			this.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries2.Title = "lineSeries2";
			// 
			// lineSeries2.XValues
			// 
			this.lineSeries2.XValues.DataMember = "X";
			this.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries2.YValues
			// 
			this.lineSeries2.YValues.DataMember = "Y";
			// 
			// lineSeries3
			// 
			// 
			// lineSeries3.Brush
			// 
			this.lineSeries3.Brush.Color = System.Drawing.Color.Yellow;
			// 
			// lineSeries3.Marks
			// 
			// 
			// lineSeries3.Marks.Symbol
			// 
			// 
			// lineSeries3.Marks.Symbol.Shadow
			// 
			this.lineSeries3.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries3.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries3.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries3.Pointer
			// 
			this.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries3.Title = "lineSeries3";
			// 
			// lineSeries3.XValues
			// 
			this.lineSeries3.XValues.DataMember = "X";
			this.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries3.YValues
			// 
			this.lineSeries3.YValues.DataMember = "Y";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 35);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "0";
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = Cursors.Hand;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(60, 9);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(33, 35);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "1";
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = Cursors.Hand;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(107, 9);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(33, 35);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "2";
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
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
			// Line_Patterns
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			//this.Menu = this.mainMenu1;
			this.Name = "Line_Patterns";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
      string fileName=Steema.TeeChart.Editors.PictureDialog.FileName(this);

      if (fileName!="")
      {
        System.Windows.Forms.PictureBox pbox = sender as System.Windows.Forms.PictureBox;
        int SeriesIndex;
        if (sender == this.pictureBox1) SeriesIndex = 0;
        else if (sender == this.pictureBox2) SeriesIndex = 1;
        else SeriesIndex = 2;

        Steema.TeeChart.Styles.Line lineseries = (Steema.TeeChart.Styles.Line)this.tChart1.Series[SeriesIndex];
				//lineseries.Brush.Image = Image.FromFile(fileName);
				//pbox.Image = lineseries.Brush.Image;
			}
		}
	}
}

