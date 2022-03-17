using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Zoom_Pen : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.FastLine fastLineSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private Steema.TeeChart.ButtonPen buttonPen1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
    private CheckBox CBHistory;
		private System.ComponentModel.IContainer components = null;

		public Zoom_Pen()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.fastLineSeries1.FillSampleValues(50);

			this.tChart1.Zoom.Pen.Color = Color.LightSteelBlue;
			this.tChart1.Zoom.Brush.Color = Color.DarkGray;
			this.tChart1.Zoom.Pen.Width = 2;
      tChart1.Zoom.History = true;

			// connect pen, brush to appropriate buttons
			this.buttonPen1.Pen = this.tChart1.Zoom.Pen;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zoom_Pen));
      this.fastLineSeries1 = new Steema.TeeChart.Styles.FastLine();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonPen1 = new Steema.TeeChart.ButtonPen();
      this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
      this.CBHistory = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(544, 68);
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.CBHistory);
      this.panel1.Controls.Add(this.buttonPen1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Location = new System.Drawing.Point(0, 68);
      this.panel1.Size = new System.Drawing.Size(544, 36);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Aspect.ZOffset = 0;
      this.tChart1.Cursor = Cursors.Default;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Font.Size = 11;
      this.tChart1.Header.Font.SizeFloat = 11F;
      this.tChart1.Header.Lines = new string[] {
        "Zoom history, brush & pen"};
      // 
      // 
      // 
      this.tChart1.Legend.TextSymbolGap = 0;
      this.tChart1.Legend.Visible = false;
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
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Series.Add(this.fastLineSeries1);
      this.tChart1.Size = new System.Drawing.Size(544, 228);
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
      this.tChart1.Walls.Back.Pen.Visible = false;
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
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      // 
      // chartContainer
      // 
      this.chartContainer.Location = new System.Drawing.Point(0, 104);
      this.chartContainer.Size = new System.Drawing.Size(544, 228);
      // 
      // fastLineSeries1
      // 
      this.fastLineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.fastLineSeries1.ColorEach = false;
      // 
      // 
      // 
      this.fastLineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.fastLineSeries1.LinePen.Width = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      this.fastLineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.fastLineSeries1.Marks.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.fastLineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
      this.fastLineSeries1.Marks.Callout.Distance = 0;
      this.fastLineSeries1.Marks.Callout.Draw3D = false;
      this.fastLineSeries1.Marks.Callout.Length = 10;
      this.fastLineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.fastLineSeries1.Marks.Callout.Visible = false;
      this.fastLineSeries1.Title = "fastLineSeries1";
      this.fastLineSeries1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
      // 
      // 
      // 
      this.fastLineSeries1.XValues.DataMember = "X";
      this.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.fastLineSeries1.YValues.DataMember = "Y";
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(233, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(87, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Zoom &brush...";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(7, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Drag to zoom";
      this.label1.UseMnemonic = false;
      // 
      // buttonPen1
      // 
      this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonPen1.Location = new System.Drawing.Point(133, 5);
      this.buttonPen1.Name = "buttonPen1";
      this.buttonPen1.Size = new System.Drawing.Size(87, 23);
      this.buttonPen1.TabIndex = 3;
      this.buttonPen1.Text = "Zoom &pen...";
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
      // CBHistory
      // 
      this.CBHistory.Checked = true;
      this.CBHistory.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CBHistory.Location = new System.Drawing.Point(361, 9);
      this.CBHistory.Name = "CBHistory";
      this.CBHistory.Size = new System.Drawing.Size(137, 17);
      this.CBHistory.TabIndex = 5;
      this.CBHistory.Text = "Historical unzoom steps";
      this.CBHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
#if VS2005
      this.CBHistory.AutoSize = true;
      this.CBHistory.UseVisualStyleBackColor = true;
#endif
      this.CBHistory.CheckedChanged += new System.EventHandler(this.CBHistory_CheckedChanged);
      // 
      // Zoom_Pen
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(544, 332);
      this.Name = "Zoom_Pen";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Editors.BrushEditor br = new Steema.TeeChart.Editors.BrushEditor(this.tChart1.Zoom.Brush);
			try
			{
				br.ShowDialog();
			}
			finally
			{
				br.Dispose();
			}
		}

    private void CBHistory_CheckedChanged(object sender, EventArgs e)
    {
      tChart1.Zoom.History = CBHistory.Checked;
    }
	}
}

