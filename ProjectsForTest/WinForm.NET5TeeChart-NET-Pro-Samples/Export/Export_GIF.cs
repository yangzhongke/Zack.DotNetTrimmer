using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Export_GIF : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bubble bubbleSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Export_GIF()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.bubbleSeries1.FillSampleValues(8);
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
			this.bubbleSeries1 = new Steema.TeeChart.Styles.Bubble();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 56);
			this.textBox1.Text = "Exporting to GIF graphic format is available using the Export Dialog or by code a" +
				"t run-time. \r\n\r\nNOTE : Check the LZW compression patent issues.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 34);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[0];
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 90);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.bubbleSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 196);
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
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// bubbleSeries1
			// 
			this.bubbleSeries1.LabelMember = "Labels";
			// 
			// bubbleSeries1.Marks
			// 
			// 
			// bubbleSeries1.Marks.Symbol
			// 
			// 
			// bubbleSeries1.Marks.Symbol.Shadow
			// 
			this.bubbleSeries1.Marks.Symbol.Shadow.Height = 1;
			this.bubbleSeries1.Marks.Symbol.Shadow.Visible = true;
			this.bubbleSeries1.Marks.Symbol.Shadow.Width = 1;
			this.bubbleSeries1.Marks.Transparent = true;
			// 
			// bubbleSeries1.Pointer
			// 
			// 
			// bubbleSeries1.Pointer.Brush
			// 
			this.bubbleSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.bubbleSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			this.bubbleSeries1.Pointer.HorizSize = 19;
			this.bubbleSeries1.Pointer.InflateMargins = false;
			this.bubbleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.bubbleSeries1.Pointer.VertSize = 19;
			this.bubbleSeries1.Title = "bubbleSeries1";
			// 
			// bubbleSeries1.XValues
			// 
			this.bubbleSeries1.XValues.DataMember = "X";
			this.bubbleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bubbleSeries1.YValues
			// 
			this.bubbleSeries1.YValues.DataMember = "Y";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(13, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Save to GIF...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(144, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(147, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Show &export dialog...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "doc1";
			this.saveFileDialog1.Title = "Save Image (GIF)";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Export_GIF
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Export_GIF";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			tChart1.Export.ShowExportDialog(tChart1.Export.Image.GIF);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.DefaultExt = tChart1.Export.Image.GIF.FileExtension ;
			saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter=Texts.GIFFilter;
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// set gif image properties, then save.
				tChart1.Export.Image.GIF.Save( saveFileDialog1.FileName );
			}
		}
	}
}

