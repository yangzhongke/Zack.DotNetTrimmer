using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Export_VML : Samples.BaseForm
	{
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private Steema.TeeChart.Styles.Bar bar1;
		private System.ComponentModel.IContainer components = null;

		public Export_VML()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bar1.FillSampleValues(5);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_VML));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bar1 = new Steema.TeeChart.Styles.Bar();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "TeeCharts can be exported to Microsoft VML (Vector Markup Language) format. VML i" +
                "s a \"vector graphic\" text format that can be read by Internet Explorer.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
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
            this.tChart1.Axes.Bottom.MaximumOffset = 30;
            this.tChart1.Axes.Bottom.MinimumOffset = 30;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 37;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Header.Font.Shadow.Height = 2;
            this.tChart1.Header.Font.Shadow.Visible = true;
            this.tChart1.Header.Font.Shadow.Width = 2;
            this.tChart1.Header.Lines = new string[] {
        "TeeChart does VML"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.bar1);
            this.tChart1.Size = new System.Drawing.Size(440, 205);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save to VML";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(144, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show export dialog";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bar1
            // 
            // 
            // 
            // 
            this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.bar1.ColorEach = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bar1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bar1.Marks.Callout.Distance = 0;
            this.bar1.Marks.Callout.Draw3D = false;
            this.bar1.Marks.Callout.Length = 20;
            this.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.bar1.Marks.Callout.Visible = false;
            this.bar1.Title = "bar1";
            // 
            // 
            // 
            this.bar1.XValues.DataMember = "X";
            this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bar1.YValues.DataMember = "Bar";
            // 
            // Export_VML
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Export_VML";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

    private void button2_Click(object sender, System.EventArgs e)
    {
      tChart1.Export.ShowExportDialog(tChart1.Export.Image.VML);
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      saveFileDialog1.DefaultExt = tChart1.Export.Image.VML.FileExtension;
      saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter=Texts.VMLFilter;
      if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        tChart1.Export.Image.VML.Save( saveFileDialog1.FileName );
      }
    }
	}
}

