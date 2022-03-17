using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Legend_Scroll : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label2;
		private Steema.TeeChart.Tools.ColorLine colorLine1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Legend_Scroll()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.lineSeries1.FillSampleValues(100);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legend_Scroll));
            this.lineSeries1 = new Steema.TeeChart.Styles.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.colorLine1 = new Steema.TeeChart.Tools.ColorLine();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 63);
            this.textBox1.Text = "The Chart Legend can be scrolled, to show values starting from our desired point." +
                " This is done using the Legend.FirstValue property:\r\n\r\ntChart1.Legend.FirstValue" +
                " = 123;";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Size = new System.Drawing.Size(466, 41);
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
            this.tChart1.Series.Add(this.lineSeries1);
            this.tChart1.Size = new System.Drawing.Size(466, 182);
            this.tChart1.Tools.Add(this.colorLine1);
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
            this.chartContainer.Location = new System.Drawing.Point(0, 104);
            this.chartContainer.Size = new System.Drawing.Size(466, 182);
            // 
            // lineSeries1
            // 
            // 
            // 
            // 
            this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.lineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.lineSeries1.ColorEach = false;
            // 
            // 
            // 
            this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&First value : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(87, 10);
            this.trackBar1.Maximum = 99;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(133, 19);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            this.label2.UseMnemonic = false;
            // 
            // colorLine1
            // 
            this.colorLine1.Axis = this.tChart1.Axes.Bottom;
            this.colorLine1.EndDragLine += new Steema.TeeChart.Tools.ColorLineToolOnDragEventHandler(this.colorLine1_EndDragLine);
            this.colorLine1.DragLine += new System.EventHandler(this.colorLine1_DragLine);
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
            // Legend_Scroll
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Legend_Scroll";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void trackBar1_ValueChanged(object sender, System.EventArgs e)
		{
			label2.Text = trackBar1.Value.ToString();
			colorLine1.Value = trackBar1.Value;
			tChart1.Legend.FirstValue = (int)colorLine1.Value;
		}

    private void colorLine1_EndDragLine(object sender)
    {
      trackBar1.Value=(int)colorLine1.Value;
    }

    private void colorLine1_DragLine(object sender, EventArgs e)
    {
        trackBar1.Value = (int)colorLine1.Value;
    }
	}
}

