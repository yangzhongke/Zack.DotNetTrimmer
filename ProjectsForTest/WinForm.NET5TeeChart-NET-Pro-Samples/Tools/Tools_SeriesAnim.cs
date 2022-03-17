using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tools_SeriesAnim : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelSteps;
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Tools.SeriesAnimation seriesAnimation1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button2;
		private System.ComponentModel.IContainer components = null;

		public Tools_SeriesAnim()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.FillSampleValues(6);
			this.tChart1.Legend.Visible = false;
			this.barSeries1.ValueFormat = "000";

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools_SeriesAnim));
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.barSeries1 = new Steema.TeeChart.Styles.Bar();
            this.seriesAnimation1 = new Steema.TeeChart.Tools.SeriesAnimation();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(488, 63);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "The series animation tool displays an animated growing chart.\r\n\r\nExample: seriesA" +
                "nimation1.Execute(); ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.labelSteps);
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Size = new System.Drawing.Size(488, 41);
            this.panel1.TabIndex = 1;
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
            this.tChart1.Axes.Bottom.MaximumOffset = 34;
            this.tChart1.Axes.Bottom.MinimumOffset = 34;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 37;
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
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tChart1.Series.Add(this.barSeries1);
            this.tChart1.Size = new System.Drawing.Size(488, 269);
            this.tChart1.TabIndex = 2;
            this.tChart1.Tools.Add(this.seriesAnimation1);
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
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 104);
            this.chartContainer.Size = new System.Drawing.Size(488, 269);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Animate...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(140, 11);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(100, 17);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Value = 100;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Steps:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(247, 11);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(25, 13);
            this.labelSteps.TabIndex = 3;
            this.labelSteps.Text = "100";
            this.labelSteps.UseMnemonic = false;
            // 
            // barSeries1
            // 
            // 
            // 
            // 
            this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.ColorEach = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.barSeries1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.barSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.barSeries1.Marks.Callout.Distance = 0;
            this.barSeries1.Marks.Callout.Draw3D = false;
            this.barSeries1.Marks.Callout.Length = 20;
            this.barSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.barSeries1.Marks.Callout.Visible = false;
            this.barSeries1.Title = "barSeries1";
            // 
            // 
            // 
            this.barSeries1.XValues.DataMember = "X";
            this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.barSeries1.YValues.DataMember = "Bar";
            // 
            // seriesAnimation1
            // 
            this.seriesAnimation1.Series = this.barSeries1;
            this.seriesAnimation1.StartAtMin = false;
            this.seriesAnimation1.StartValue = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(280, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "&One by one";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(387, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Edit...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tools_SeriesAnim
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(488, 373);
            this.Name = "Tools_SeriesAnim";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.seriesAnimation1.Steps = (int)this.hScrollBar1.Value;
			this.labelSteps.Text = this.seriesAnimation1.Steps.ToString();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.hScrollBar1.Enabled = false;
			this.button1.Enabled = false;
			try
			{
				// animate
				this.seriesAnimation1.Execute();
			}
			finally
			{
				this.hScrollBar1.Enabled = true;
				this.button1.Enabled = true;
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked) this.seriesAnimation1.DrawEvery = 1;
			else this.seriesAnimation1.DrawEvery = 0;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.Tools.ToolsEditor.ShowEditor(this.seriesAnimation1);
		}
	}
}

