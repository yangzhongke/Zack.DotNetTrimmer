using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Export_TIFF : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Styles.Bar barSeries2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Export_TIFF()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.FillSampleValues(4);
			this.barSeries2.FillSampleValues(4);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_TIFF));
            this.barSeries1 = new Steema.TeeChart.Styles.Bar();
            this.barSeries2 = new Steema.TeeChart.Styles.Bar();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 40);
            this.textBox1.Text = "Exporting to TIFF graphic format is available using the Export Dialog or by code " +
                "at run-time. ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Size = new System.Drawing.Size(466, 41);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 100;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 59;
            this.tChart1.Aspect.Rotation = 334;
            this.tChart1.Aspect.RotationFloat = 334;
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Aspect.Zoom = 79;
            this.tChart1.Aspect.ZoomFloat = 79;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MaximumOffset = 28;
            this.tChart1.Axes.Bottom.MinimumOffset = 28;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 37;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.barSeries1);
            this.tChart1.Series.Add(this.barSeries2);
            this.tChart1.Size = new System.Drawing.Size(466, 205);
            this.tChart1.Tools.Add(this.gridBand1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Visible = false;
            this.tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 5;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 81);
            this.chartContainer.Size = new System.Drawing.Size(466, 205);
            // 
            // barSeries1
            // 
            this.barSeries1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cone;
            // 
            // 
            // 
            this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.barSeries1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.barSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.barSeries1.Marks.Callout.Distance = 0;
            this.barSeries1.Marks.Callout.Draw3D = false;
            this.barSeries1.Marks.Callout.Length = 20;
            this.barSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.barSeries1.Marks.Callout.Visible = false;
            this.barSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
            // 
            // 
            // 
            this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.barSeries1.Title = "barSeries1";
            // 
            // 
            // 
            this.barSeries1.XValues.DataMember = "X";
            this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.barSeries1.YValues.DataMember = "Bar";
            // 
            // barSeries2
            // 
            this.barSeries2.BarStyle = Steema.TeeChart.Styles.BarStyles.Cone;
            // 
            // 
            // 
            this.barSeries2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.barSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.barSeries2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.barSeries2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.barSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.barSeries2.Marks.Callout.Distance = 0;
            this.barSeries2.Marks.Callout.Draw3D = false;
            this.barSeries2.Marks.Callout.Length = 20;
            this.barSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.barSeries2.Marks.Callout.Visible = false;
            this.barSeries2.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
            // 
            // 
            // 
            this.barSeries2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.barSeries2.Title = "barSeries2";
            // 
            // 
            // 
            this.barSeries2.XValues.DataMember = "X";
            this.barSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.barSeries2.YValues.DataMember = "Bar";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Save to TIFF...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Title = "Save Image (TIFF)";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(120, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show &export dialog...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // Export_TIFF
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Export_TIFF";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.DefaultExt = tChart1.Export.Image.TIFF.FileExtension ;
			saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter=Texts.TIFFFilter;
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tChart1.Export.Image.TIFF.Save( saveFileDialog1.FileName );
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			tChart1.Export.ShowExportDialog(tChart1.Export.Image.TIFF);
		}
	}
}

