using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Legend_Series : Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Styles.Points pointSeries1;
		private System.ComponentModel.IContainer components = null;

		public Legend_Series()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(6);

			this.tChart1.Legend.Series = this.barSeries1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legend_Series));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.barSeries1 = new Steema.TeeChart.Styles.Bar();
            this.pointSeries1 = new Steema.TeeChart.Styles.Points();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 63);
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Size = new System.Drawing.Size(466, 33);
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
            this.tChart1.Axes.Bottom.MaximumOffset = 32;
            this.tChart1.Axes.Bottom.MinimumOffset = 32;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 37;
            this.tChart1.Axes.Left.MinimumOffset = 5;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Values;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.barSeries1);
            this.tChart1.Series.Add(this.pointSeries1);
            this.tChart1.Size = new System.Drawing.Size(466, 190);
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
            this.chartContainer.Location = new System.Drawing.Point(0, 96);
            this.chartContainer.Size = new System.Drawing.Size(466, 190);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Series :";
            this.label1.UseMnemonic = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(113, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "&Bar";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(173, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "&Point";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // barSeries1
            // 
            // 
            // 
            // 
            this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.ColorEach = false;
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
            // 
            // 
            // 
            this.barSeries1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
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
            // pointSeries1
            // 
            this.pointSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pointSeries1.ColorEach = false;
            // 
            // 
            // 
            this.pointSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
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
            this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
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
            // Legend_Series
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Legend_Series";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.radioButton1.Checked) this.tChart1.Legend.Series = this.barSeries1;
			else this.tChart1.Legend.Series = this.pointSeries1;
		}
	}
}

