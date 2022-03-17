using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_CursorProg : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Points pointSeries1;
		private Steema.TeeChart.Tools.CursorTool cursorTool1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.ComponentModel.IContainer components = null;

		public Tool_CursorProg()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			this.pointSeries1.FillSampleValues(20);
			// place cursor in the middle
			this.cursorTool1.XValue = 0.5*(this.pointSeries1.XValues.Maximum + this.pointSeries1.XValues.Minimum);
			this.cursorTool1.XValue = 0.5*(this.pointSeries1.XValues.Maximum + this.pointSeries1.XValues.Minimum);
			this.cursorTool1.YValue = 0.5*(this.pointSeries1.YValues.Maximum + this.pointSeries1.YValues.Minimum);

			this.cursorTool1.Pen.Color = Color.Navy;
			this.cursorTool1.Pen.Width = 2;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_CursorProg));
            this.pointSeries1 = new Steema.TeeChart.Styles.Points();
            this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 32);
            this.textBox1.Text = "The Cursor tool allows changing its X and Y positions programatically.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
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
            this.tChart1.Aspect.View3D = false;
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
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.pointSeries1);
            this.tChart1.Size = new System.Drawing.Size(466, 213);
            this.tChart1.Tools.Add(this.cursorTool1);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 73);
            this.chartContainer.Size = new System.Drawing.Size(466, 213);
            // 
            // pointSeries1
            // 
            this.pointSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pointSeries1.ColorEach = false;
            // 
            // 
            // 
            this.pointSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
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
            this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
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
            // cursorTool1
            // 
            this.cursorTool1.Series = this.pointSeries1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "< &Left";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(104, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Right >";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(187, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "^ &Up";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(272, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "v &Down";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tool_CursorProg
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Tool_CursorProg";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private double SomeValue()
		{
			double res = 0.1*(this.cursorTool1.Series.YValues.Maximum - 
						this.cursorTool1.Series.YValues.Minimum);
			return res;
		}		
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.cursorTool1.XValue -= 1;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.cursorTool1.XValue += 1;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.cursorTool1.YValue += SomeValue();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.cursorTool1.YValue -= SomeValue();
		}
	}
}

