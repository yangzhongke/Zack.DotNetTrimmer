using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Legend_FontColor : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Points pointSeries1;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Styles.Line lineSeries3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Legend_FontColor()
		{
			// This call is required by the Windows Form Designer.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legend_FontColor));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.pointSeries1 = new Steema.TeeChart.Styles.Points();
            this.lineSeries1 = new Steema.TeeChart.Styles.Line();
            this.lineSeries2 = new Steema.TeeChart.Styles.Line();
            this.lineSeries3 = new Steema.TeeChart.Styles.Line();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 63);
            this.textBox1.Text = "Legend.FontSeriesColor property displays each Legend item using the Series Color." +
                " Applies to both single and multiple series in the same chart.\r\n\r\nExample: tChar" +
                "t1.Legend.FontSeriesColor = true ;";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(93)))));
            this.tChart1.Legend.Font.Italic = true;
            // 
            // 
            // 
            this.tChart1.Legend.Font.Shadow.Visible = true;
            this.tChart1.Legend.Font.Size = 10;
            this.tChart1.Legend.Font.SizeFloat = 10F;
            this.tChart1.Legend.FontSeriesColor = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.pointSeries1);
            this.tChart1.Series.Add(this.lineSeries1);
            this.tChart1.Series.Add(this.lineSeries2);
            this.tChart1.Series.Add(this.lineSeries3);
            this.tChart1.Size = new System.Drawing.Size(466, 189);
            this.tChart1.Tools.Add(this.gridBand1);
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
            this.chartContainer.Location = new System.Drawing.Point(0, 97);
            this.chartContainer.Size = new System.Drawing.Size(466, 189);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(13, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "&Legend font series color";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(220, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "&Multiple series";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // pointSeries1
            // 
            this.pointSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.pointSeries1.ColorEach = true;
            // 
            // 
            // 
            this.pointSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
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
            this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.pointSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.pointSeries1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
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
            // lineSeries1
            // 
            // 
            // 
            // 
            this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.lineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.lineSeries1.ColorEach = false;
            // 
            // 
            // 
            this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineSeries1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineSeries1.Marks.Callout.Distance = 0;
            this.lineSeries1.Marks.Callout.Draw3D = false;
            this.lineSeries1.Marks.Callout.Length = 10;
            this.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries1.Title = "lineSeries1";
            this.lineSeries1.Visible = false;
            // 
            // 
            // 
            this.lineSeries1.XValues.DataMember = "X";
            this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineSeries1.YValues.DataMember = "Y";
            // 
            // lineSeries2
            // 
            // 
            // 
            // 
            this.lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.lineSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.lineSeries2.ColorEach = false;
            // 
            // 
            // 
            this.lineSeries2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineSeries2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineSeries2.Marks.Callout.Distance = 0;
            this.lineSeries2.Marks.Callout.Draw3D = false;
            this.lineSeries2.Marks.Callout.Length = 10;
            this.lineSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries2.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries2.Title = "lineSeries2";
            this.lineSeries2.Visible = false;
            // 
            // 
            // 
            this.lineSeries2.XValues.DataMember = "X";
            this.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineSeries2.YValues.DataMember = "Y";
            // 
            // lineSeries3
            // 
            // 
            // 
            // 
            this.lineSeries3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
            this.lineSeries3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
            this.lineSeries3.ColorEach = false;
            // 
            // 
            // 
            this.lineSeries3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineSeries3.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineSeries3.Marks.Callout.Distance = 0;
            this.lineSeries3.Marks.Callout.Draw3D = false;
            this.lineSeries3.Marks.Callout.Length = 10;
            this.lineSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries3.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries3.Title = "lineSeries3";
            this.lineSeries3.Visible = false;
            // 
            // 
            // 
            this.lineSeries3.XValues.DataMember = "X";
            this.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineSeries3.YValues.DataMember = "Y";
            // 
            // Legend_FontColor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Legend_FontColor";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Legend.FontSeriesColor = this.checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lineSeries1.Active = this.checkBox2.Checked;
			this.lineSeries2.Active = this.checkBox2.Checked;
			this.lineSeries3.Active = this.checkBox2.Checked;

			this.pointSeries1.ColorEach= ! this.checkBox2.Checked;
		}
	}
}

