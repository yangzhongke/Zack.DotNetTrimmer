using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Export_PNG : Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private Steema.TeeChart.Styles.Gantt ganttSeries1;
		private System.ComponentModel.IContainer components = null;

		public Export_PNG()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.ganttSeries1.FillSampleValues(6);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_PNG));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ganttSeries1 = new Steema.TeeChart.Styles.Gantt();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 40);
            this.textBox1.Text = "Exporting to PNG graphic format is available using the Export Dialog or by code a" +
                "t run-time.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Size = new System.Drawing.Size(466, 34);
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
            this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Axes.Bottom.MaximumOffset = 5;
            this.tChart1.Axes.Bottom.MinimumOffset = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Axes.Left.MaximumOffset = 5;
            this.tChart1.Axes.Left.MinimumOffset = 5;
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
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.ganttSeries1);
            this.tChart1.Size = new System.Drawing.Size(466, 212);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.chartContainer.Location = new System.Drawing.Point(0, 74);
            this.chartContainer.Size = new System.Drawing.Size(466, 212);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Save to PNG...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(128, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show &export dialog...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Title = "Save Image (PNG)";
            // 
            // ganttSeries1
            // 
            this.ganttSeries1.Color = System.Drawing.Color.Red;
            this.ganttSeries1.ColorEach = true;
            // 
            // 
            // 
            this.ganttSeries1.EndValues.DataMember = "End";
            this.ganttSeries1.EndValues.DateTime = true;
            this.ganttSeries1.LabelMember = "Labels";
            // 
            // 
            // 
            // 
            // 
            // 
            this.ganttSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.ganttSeries1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.ganttSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.ganttSeries1.Marks.Callout.Distance = 0;
            this.ganttSeries1.Marks.Callout.Draw3D = false;
            this.ganttSeries1.Marks.Callout.Length = 0;
            this.ganttSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.ganttSeries1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.ganttSeries1.NextTasks.DataMember = "NextTask";
            // 
            // 
            // 
            // 
            // 
            // 
            this.ganttSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.ganttSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
            this.ganttSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.ganttSeries1.StartValues.DataMember = "Start";
            this.ganttSeries1.StartValues.DateTime = true;
            this.ganttSeries1.Title = "ganttSeries1";
            // 
            // 
            // 
            this.ganttSeries1.YValues.DataMember = "Y";
            // 
            // Export_PNG
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Export_PNG";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			tChart1.Export.ShowExportDialog(tChart1.Export.Image.PNG);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.DefaultExt = tChart1.Export.Image.PNG.FileExtension ;
			saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter=Texts.PNGFilter;
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// set properties
				tChart1.Export.Image.PNG.GrayScale = false;
				tChart1.Export.Image.PNG.Save( saveFileDialog1.FileName );
			}		
		}
	}
}

