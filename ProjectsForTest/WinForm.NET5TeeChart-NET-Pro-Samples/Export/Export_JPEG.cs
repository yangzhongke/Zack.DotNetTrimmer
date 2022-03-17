using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Export_JPEG : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Arrow arrowSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
        private CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Export_JPEG()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.arrowSeries1.FillSampleValues(8);
			this.arrowSeries1.ArrowHeight = 10;
			this.arrowSeries1.ArrowWidth = 10;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_JPEG));
            this.arrowSeries1 = new Steema.TeeChart.Styles.Arrow();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 32);
            this.textBox1.Text = "Exporting to JPEG graphic format is available using the Export Dialog or by code " +
                "at run-time.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Size = new System.Drawing.Size(466, 41);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Visible = false;
            this.tChart1.Cursor = Cursors.Default;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Pen.Transparency = 1;
            this.tChart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Height = 1;
            this.tChart1.Legend.Shadow.Visible = false;
            this.tChart1.Legend.Shadow.Width = 1;
            // 
            // 
            // 
            // 
            // 
            // 
#if VS2005
            this.tChart1.Legend.Symbol.Shadow.Smooth = true;
#endif
            this.tChart1.Legend.Symbol.Squared = true;
            this.tChart1.Legend.TextSymbolGap = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.arrowSeries1);
            this.tChart1.Size = new System.Drawing.Size(466, 213);
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
            this.tChart1.Walls.Back.Pen.Visible = false;
            this.tChart1.Walls.Back.Visible = false;
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
            this.chartContainer.Location = new System.Drawing.Point(0, 73);
            this.chartContainer.Size = new System.Drawing.Size(466, 213);
            // 
            // arrowSeries1
            // 
            this.arrowSeries1.Color = System.Drawing.Color.Red;
            this.arrowSeries1.ColorEach = true;
            this.arrowSeries1.LabelMember = "Labels";
            // 
            // 
            // 
            // 
            // 
            // 
            this.arrowSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.arrowSeries1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.arrowSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.arrowSeries1.Marks.Callout.Distance = 0;
            this.arrowSeries1.Marks.Callout.Draw3D = false;
            this.arrowSeries1.Marks.Callout.Length = 0;
            this.arrowSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.arrowSeries1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.arrowSeries1.Marks.Pen.Visible = false;
            this.arrowSeries1.Marks.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.arrowSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.arrowSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
            this.arrowSeries1.Pointer.InflateMargins = false;
            // 
            // 
            // 
            this.arrowSeries1.Pointer.Pen.Transparency = 1;
            this.arrowSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.arrowSeries1.StartXValues = this.arrowSeries1.XValues;
            this.arrowSeries1.StartYValues = this.arrowSeries1.YValues;
            this.arrowSeries1.Title = "arrowSeries1";
            // 
            // 
            // 
            this.arrowSeries1.XValues.DataMember = "X";
            this.arrowSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.arrowSeries1.YValues.DataMember = "Y";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save to &JPEG...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(127, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show &export dialog...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Title = "Save Image (JPEG)";
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // checkBox1
            // 
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.Location = new System.Drawing.Point(304, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Save Grey Scale";
            // 
            // Export_JPEG
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Export_JPEG";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.DefaultExt = tChart1.Export.Image.JPEG.FileExtension ;
			saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
            saveFileDialog1.Filter=Texts.JPEGFilter;
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // set some jpeg properties
                if (checkBox1.Checked)
                {
                    tChart1.Export.Image.JPEG.GrayScale = true;
                    tChart1.Export.Image.JPEG.Quality = 75;
                    tChart1.Export.Image.JPEG.Save(saveFileDialog1.FileName);
                }
                else
                {

                    tChart1.Export.Image.JPEG.Save(saveFileDialog1.FileName);
                }
            }
		}

    private void button2_Click(object sender, System.EventArgs e)
    {
      tChart1.Export.ShowExportDialog(tChart1.Export.Image.JPEG);
    }
	}
}

