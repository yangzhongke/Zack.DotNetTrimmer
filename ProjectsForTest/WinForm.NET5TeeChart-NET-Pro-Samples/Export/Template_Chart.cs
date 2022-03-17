using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Summary description for Template.
	/// </summary>
    public class Template_Chart : System.Windows.Forms.Form
	{
		protected internal System.Windows.Forms.TextBox textBox1;
		protected System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.TChart tChart2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private Steema.TeeChart.Styles.Points pointSeries1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public Template_Chart()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
					s.FillSampleValues(10);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template_Chart));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.pointSeries1 = new Steema.TeeChart.Styles.Points();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(439, 62);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 42);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(153, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Run Example";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Edit Template...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.tChart2);
            this.panel2.Controls.Add(this.tChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 168);
            this.panel2.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(142, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 168);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // tChart2
            // 
            // 
            // 
            // 
            this.tChart2.Aspect.ZOffset = 0;
            this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.tChart2.Header.Lines = new string[] {
        "tChart2"};
            this.tChart2.Location = new System.Drawing.Point(142, 0);
            this.tChart2.Name = "tChart2";
            this.tChart2.Size = new System.Drawing.Size(297, 168);
            this.tChart2.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Bottom.Pen.Visible = false;
            this.tChart2.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Left.Pen.Visible = false;
            this.tChart2.Walls.Left.Size = 5;
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
            this.tChart1.Axes.Bottom.MaximumOffset = 5;
            this.tChart1.Axes.Bottom.MinimumOffset = 5;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 5;
            this.tChart1.Axes.Left.MinimumOffset = 5;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(0, 0);
            this.tChart1.Name = "tChart1";
            this.tChart1.Series.Add(this.pointSeries1);
            this.tChart1.Size = new System.Drawing.Size(142, 168);
            this.tChart1.TabIndex = 0;
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
            // pointSeries1
            // 
            this.pointSeries1.Color = System.Drawing.Color.Red;
            this.pointSeries1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.pointSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.pointSeries1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.pointSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.pointSeries1.Marks.Callout.Distance = 0;
            this.pointSeries1.Marks.Callout.Draw3D = false;
            this.pointSeries1.Marks.Callout.Length = 0;
            this.pointSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.pointSeries1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.pointSeries1.Title = "pointSeries1";
            // 
            // 
            // 
            this.pointSeries1.XValues.DataMember = "X";
            this.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.pointSeries1.YValues.DataMember = "Y";
            // 
            // Export_Template
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(439, 272);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Export_Template";
            this.Text = "Template";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			tChart1.ShowEditor();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//  1) Save the template into a Stream...
			System.IO.MemoryStream stream = new System.IO.MemoryStream();
			try
			{
				// save only Chart and Series formatting, NOT including data
				//tChart1.Export.Template.Save(stream);
				//// 2) Load the template into other Chart...
				//stream.Position = 0;
				//tChart2.Import.Template.Load(stream);
				// restore the chart alignment (in this example)
				this.tChart2.Dock = DockStyle.Fill;
				// repaint the Chart
				this.tChart2.Refresh();
			}
			finally
			{
				// remove the stream, it's no longer necessary...
				stream.Close();
			}
		}
	}
}
