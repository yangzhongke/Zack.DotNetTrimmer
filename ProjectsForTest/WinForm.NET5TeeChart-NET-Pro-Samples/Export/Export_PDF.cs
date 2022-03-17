using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Export_PDF : Steema.TeeChart.Samples.BaseForm
	{
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private Steema.TeeChart.Styles.Candle candle1;
    private Steema.TeeChart.Styles.Line line1;
    private System.Windows.Forms.Button button2;
    private Steema.TeeChart.Tools.ChartImage chartImage1;
		private System.ComponentModel.IContainer components = null;

		public Export_PDF()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

		  candle1.FillSampleValues();
      line1.FillSampleValues();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Export_PDF));
			this.button1 = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.candle1 = new Steema.TeeChart.Styles.Candle();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.button2 = new System.Windows.Forms.Button();
			this.chartImage1 = new Steema.TeeChart.Tools.ChartImage();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(480, 56);
			this.textBox1.Text = "Easy export to PDF format. Export filter generates all pdf page elements.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 39);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "d.M.yyyy";
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Courier New";
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			this.tChart1.Axes.Left.Labels.Font.Name = "Courier New";
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Red;
			this.tChart1.Header.Font.Size = 9;
			this.tChart1.Header.Lines = new string[] {
																								 "PDF Export"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 95);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.ImageMode = Steema.TeeChart.Drawing.ImageMode.Normal;
			this.tChart1.Panel.ImageMode = Steema.TeeChart.Drawing.ImageMode.Normal;
			this.tChart1.Series.Add(this.candle1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Size = new System.Drawing.Size(480, 254);
			this.tChart1.Tools.Add(this.chartImage1);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Save to PDF";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// candle1
			// 
			// 
			// candle1.Brush
			// 
			this.candle1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(192)));
			this.candle1.CloseValues = this.candle1.YValues;
			this.candle1.DateValues = this.candle1.XValues;
			// 
			// candle1.Marks
			// 
			// 
			// candle1.Marks.Symbol
			// 
			// 
			// candle1.Marks.Symbol.Shadow
			// 
			this.candle1.Marks.Symbol.Shadow.Height = 1;
			this.candle1.Marks.Symbol.Shadow.Visible = true;
			this.candle1.Marks.Symbol.Shadow.Width = 1;
			// 
			// candle1.Pointer
			// 
			this.candle1.Pointer.Draw3D = false;
			this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Title = "candle1";
			// 
			// candle1.XValues
			// 
			this.candle1.XValues.DataMember = "Date";
			this.candle1.XValues.DateTime = true;
			this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// candle1.YValues
			// 
			this.candle1.YValues.DataMember = "Close";
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(192)));
			this.line1.ColorEach = true;
			this.line1.ColorEachLine = false;
			// 
			// line1.Marks
			// 
			// 
			// line1.Marks.Symbol
			// 
			// 
			// line1.Marks.Symbol.Shadow
			// 
			this.line1.Marks.Symbol.Shadow.Height = 1;
			this.line1.Marks.Symbol.Shadow.Visible = true;
			this.line1.Marks.Symbol.Shadow.Width = 1;
			// 
			// line1.Pointer
			// 
			this.line1.Pointer.HorizSize = 3;
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle;
			this.line1.Pointer.VertSize = 3;
			this.line1.Pointer.Visible = true;
			this.line1.Title = "line1";
			// 
			// line1.XValues
			// 
			this.line1.XValues.DataMember = "X";
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line1.YValues
			// 
			this.line1.YValues.DataMember = "Y";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(152, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Show export dialog";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// chartImage1
			// 
			//this.chartImage1.Image = ((System.Drawing.Image)(resources.GetObject("chartImage1.Image")));
			this.chartImage1.ImageMode = Steema.TeeChart.Drawing.ImageMode.Center;
			// 
			// Export_PDF
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 349);
			this.Name = "Export_PDF";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void button1_Click(object sender, System.EventArgs e)
    {
      saveFileDialog1.DefaultExt = tChart1.Export.Image.PDF.FileExtension;
      saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter=Texts.PDFFilter;
      if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        tChart1.Export.Image.PDF.Save( saveFileDialog1.FileName );
      }
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      tChart1.Export.ShowExportDialog(tChart1.Export.Image.PDF);
    }

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      g.Brush.Visible = true;
      g.Brush.Color = Color.White;
      g.Pie(100,100,150,300,150,100,200,200);
    }
	}
}

