using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Export_Metafile : Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private Steema.TeeChart.Styles.Pie pieSeries1;
		private System.ComponentModel.IContainer components = null;

		public Export_Metafile()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.pieSeries1.FillSampleValues(5);
			this.pieSeries1.ExplodeBiggest = 15;
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pieSeries1 = new Steema.TeeChart.Styles.Pie();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 48);
			this.textBox1.Text = "Exporting to Metafile and Enhanced Metafile graphic formats is available using th" +
				"e Export Dialog or by code at run-time. ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			this.tChart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Exporting to Metafile and Enhanced Metafile"};
			this.tChart1.Location = new System.Drawing.Point(0, 89);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pieSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 197);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(13, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Copy to Clipboard";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(133, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "&Save to file...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(256, 9);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(139, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Show &Export Dialog...";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "doc1";
			this.saveFileDialog1.Title = "Save Image (Metafile)";
			// 
			// pieSeries1
			// 
			// 
			// pieSeries1.Brush
			// 
			this.pieSeries1.Brush.Color = System.Drawing.Color.White;
			this.pieSeries1.LabelMember = "Labels";
			// 
			// pieSeries1.Marks
			// 
			// 
			// pieSeries1.Marks.Symbol
			// 
			// 
			// pieSeries1.Marks.Symbol.Shadow
			// 
			this.pieSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries1.Shadow
			// 
			this.pieSeries1.Shadow.Height = 20;
			this.pieSeries1.Shadow.Width = 20;
			this.pieSeries1.Title = "pieSeries1";
			// 
			// pieSeries1.XValues
			// 
			this.pieSeries1.XValues.DataMember = "Angle";
			this.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries1.YValues
			// 
			this.pieSeries1.YValues.DataMember = "Pie";
			// 
			// Export_Metafile
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Export_Metafile";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button3_Click(object sender, System.EventArgs e)
		{
			tChart1.Export.ShowExportDialog(tChart1.Export.Image.Metafile);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.DefaultExt = tChart1.Export.Image.Metafile.FileExtension ;
			saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter=Texts.EMFFilter;
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tChart1.Export.Image.Metafile.Save( saveFileDialog1.FileName );
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//tChart1.Export.Image.Metafile.Enhanced = false;
			tChart1.Export.Image.Metafile.CopyToClipboard();
		}
	}
}

