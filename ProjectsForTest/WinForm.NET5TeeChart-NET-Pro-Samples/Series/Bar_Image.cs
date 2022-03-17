using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Bar_Image : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ImageList imageList1;
		private Steema.TeeChart.Styles.Bar barSeries2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Bar_Image()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (TeeChart.Styles.Series s in this.tChart1.Series)
				s.FillSampleValues(3);

			this.checkBox1_CheckedChanged(this.checkBox1,new System.EventArgs());
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Bar_Image));
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.barSeries2 = new Steema.TeeChart.Styles.Bar();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(528, 64);
			this.textBox1.Text = "Bar and Horiz.Bar series can display Images. At design-time, edit the Brush prope" +
				"rty. At run-time, you can use for example the code below.\r\n\r\nExample: barSeries1" +
				".Brush.Image.LoadFile(@\"c:\\mybitmap.bmp\");";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(528, 32);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Series.Add(this.barSeries2);
			this.tChart1.Size = new System.Drawing.Size(528, 261);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.Red;
			this.barSeries1.Cursor = Drawing.Cursors.Cross;
			// 
			// barSeries1.Marks
			// 
			// 
			// barSeries1.Marks.Symbol
			// 
			// 
			// barSeries1.Marks.Symbol.Shadow
			// 
			this.barSeries1.Marks.Symbol.Shadow.Height = 1;
			this.barSeries1.Marks.Symbol.Shadow.Visible = true;
			this.barSeries1.Marks.Symbol.Shadow.Width = 1;
			this.barSeries1.Title = "barSeries1";
			// 
			// barSeries1.XValues
			// 
			this.barSeries1.XValues.DataMember = "X";
			this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries1.YValues
			// 
			this.barSeries1.YValues.DataMember = "Bar";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 19);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Use patterns";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// barSeries2
			// 
			// 
			// barSeries2.Brush
			// 
			this.barSeries2.Brush.Color = System.Drawing.Color.Green;
			this.barSeries2.Cursor = Drawing.Cursors.Cross;
			// 
			// barSeries2.Marks
			// 
			// 
			// barSeries2.Marks.Symbol
			// 
			// 
			// barSeries2.Marks.Symbol.Shadow
			// 
			this.barSeries2.Marks.Symbol.Shadow.Height = 1;
			this.barSeries2.Marks.Symbol.Shadow.Visible = true;
			this.barSeries2.Marks.Symbol.Shadow.Width = 1;
			this.barSeries2.Title = "barSeries2";
			// 
			// barSeries2.XValues
			// 
			this.barSeries2.XValues.DataMember = "X";
			this.barSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries2.YValues
			// 
			this.barSeries2.YValues.DataMember = "Bar";
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
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// Bar_Image
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 357);
			this.Name = "Bar_Image";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				//the imageList1 contains the patterns for this example
				//this.barSeries1.Brush.Image = this.imageList1.Images[0];
				//this.barSeries2.Brush.Image = this.imageList1.Images[1];
			}
			else
			{
				this.barSeries1.Brush.Image = null;
				this.barSeries2.Brush.Image = null;
			}
		}
	}
}

