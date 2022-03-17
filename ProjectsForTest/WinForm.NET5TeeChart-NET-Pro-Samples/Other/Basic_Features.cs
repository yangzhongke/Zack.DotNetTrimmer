using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Summary description for Basic_Features.
	/// </summary>
	public class Basic_Features : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox2;
		private Steema.TeeChart.TChart tChart1;
    private System.Windows.Forms.Splitter splitter1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Basic_Features()
		{
			//
			// Required for Windows Form Designer support
			InitializeComponent();
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tChart1 = new Steema.TeeChart.TChart();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(496, 76);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = @"Creating charts is really easy to do. Just drop a Chart component on your form and double-click it to show the editor dialog. First steps with the editor dialog are clicking the Add button to choose a chart style (series) from the Gallery.
Adding points to a series can be done by code or at design-time, linking the series to a database or function.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 76);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(496, 36);
			this.panel1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(247, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "&Show Chart Editor";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(13, 7);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Run code";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.textBox2.Location = new System.Drawing.Point(0, 112);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(296, 277);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = @"Run-time code to create charts:

tChart1.Series.Clear();

tChart1.Series.Add(new Steema.TeeChart.Styles.Bar());
tChart1.Series[0].Clear();
tChart1.Series[0].Add(123, ""ABC"", Color.Red);
tChart1.Series[0].Add(  456, ""DEF"", Color.Blue );
tChart1.Series[0].Add(  321, ""GHI"", Color.Green );

Change the bar Marks :

tChart1.Series[0].Marks.Style = smsValue ;

To show the editor dialog, use the following code:

tChart1.ShowEditor();";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Chart Example"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
			this.tChart1.Location = new System.Drawing.Point(296, 112);
			this.tChart1.Name = "tChart1";
			this.tChart1.Size = new System.Drawing.Size(200, 277);
			this.tChart1.TabIndex = 3;
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
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(296, 112);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 277);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// Basic_Features
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 389);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.tChart1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.Name = "Basic_Features";
			this.Text = "Basic_Features";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			tChart1.ShowEditor();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			tChart1.Series.Clear();
			tChart1.Series.Add(new Steema.TeeChart.Styles.Bar());
			tChart1.Series[0].Clear();
			tChart1.Series[0].Add(123, "ABC", Color.Red);
			tChart1.Series[0].Add(456, "DEF", Color.Blue);
			tChart1.Series[0].Add(321, "GHI", Color.Green);
			
			tChart1.Series[0].Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;

      // Set Axis titles:
      tChart1.Axes.Bottom.Title.Text="Series";
      tChart1.Axes.Left.Title.Text="Values";
    }
	}
}
