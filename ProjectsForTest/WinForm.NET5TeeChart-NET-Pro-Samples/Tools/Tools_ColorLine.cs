using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tools_ColorLine : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Tools.ColorLine colorLine1;
		private Steema.TeeChart.Tools.ColorLine colorLine2;
    private Steema.TeeChart.ButtonPen buttonPen1;
    private Steema.TeeChart.ButtonPen buttonPen2;
    private Steema.TeeChart.Styles.Points pointSeries1;
		private System.ComponentModel.IContainer components = null;

		public Tools_ColorLine()
		{
      double min, max;
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach(Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(20);

      buttonPen1.Pen=colorLine1.Pen;
      buttonPen2.Pen=colorLine2.Pen;

      if(lineSeries1.YValues.Maximum > pointSeries1.YValues.Maximum) 
        max = lineSeries1.YValues.Maximum;
      else 
        max = pointSeries1.YValues.Maximum;

      if(lineSeries1.YValues.Minimum > pointSeries1.YValues.Minimum) 
        min = pointSeries1.YValues.Minimum;
      else 
        min = lineSeries1.YValues.Minimum;

      colorLine1.Value = min + ((max - min) / 2);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools_ColorLine));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.lineSeries1 = new Steema.TeeChart.Styles.Line();
            this.colorLine1 = new Steema.TeeChart.Tools.ColorLine();
            this.colorLine2 = new Steema.TeeChart.Tools.ColorLine();
            this.buttonPen1 = new Steema.TeeChart.ButtonPen();
            this.buttonPen2 = new Steema.TeeChart.ButtonPen();
            this.pointSeries1 = new Steema.TeeChart.Styles.Points();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(485, 63);
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPen2);
            this.panel1.Controls.Add(this.buttonPen1);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Size = new System.Drawing.Size(485, 57);
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
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.pointSeries1);
            this.tChart1.Series.Add(this.lineSeries1);
            this.tChart1.Size = new System.Drawing.Size(485, 166);
            this.tChart1.Tools.Add(this.colorLine1);
            this.tChart1.Tools.Add(this.colorLine2);
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
            this.tChart1.Walls.Bottom.Size = 3;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 3;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 120);
            this.chartContainer.Size = new System.Drawing.Size(485, 166);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(13, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "&Show lines";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(13, 33);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "&Allow drag";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(100, 7);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(44, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "&3D";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Location = new System.Drawing.Point(100, 33);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Drag &repaint";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Location = new System.Drawing.Point(140, 7);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(73, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "3D &lines";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Location = new System.Drawing.Point(213, 7);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(123, 20);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "&Draw behind";
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.Location = new System.Drawing.Point(213, 33);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(107, 20);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "&No limit drag";
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
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
            // colorLine1
            // 
            this.colorLine1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.colorLine1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.colorLine1.Value = 680.46846846846847;
            // 
            // colorLine2
            // 
            this.colorLine2.Axis = this.tChart1.Axes.Bottom;
            // 
            // 
            // 
            this.colorLine2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colorLine2.Pen.Width = 2;
            this.colorLine2.Value = 10;
            // 
            // buttonPen1
            // 
            this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPen1.Location = new System.Drawing.Point(326, 16);
            this.buttonPen1.Name = "buttonPen1";
            this.buttonPen1.Size = new System.Drawing.Size(61, 23);
            this.buttonPen1.TabIndex = 7;
            this.buttonPen1.Text = "Border";
            this.buttonPen1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPen2
            // 
            this.buttonPen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPen2.Location = new System.Drawing.Point(393, 16);
            this.buttonPen2.Name = "buttonPen2";
            this.buttonPen2.Size = new System.Drawing.Size(61, 23);
            this.buttonPen2.TabIndex = 8;
            this.buttonPen2.Text = "Border";
            this.buttonPen2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // points1
            // 
            this.pointSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.pointSeries1.ColorEach = false;
            // 
            // 
            // 
            this.pointSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
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
            this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            // 
            // 
            // 
            this.pointSeries1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            // 
            // 
            // 
            this.pointSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
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
            // Tools_ColorLine
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(485, 286);
            this.Name = "Tools_ColorLine";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = checkBox3.Checked;
			checkBox5.Enabled = checkBox3.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			foreach (Steema.TeeChart.Tools.Tool tool in tChart1.Tools)
				tool.Active = checkBox1.Checked;
		}

		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorLine1.Draw3D = checkBox5.Checked;
			this.colorLine2.Draw3D = checkBox5.Checked;
		}

		private void checkBox6_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorLine1.DrawBehind = checkBox6.Checked;
			this.colorLine2.DrawBehind = checkBox6.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorLine1.AllowDrag = checkBox2.Checked;
			this.colorLine2.AllowDrag = checkBox2.Checked;	
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorLine1.DragRepaint = checkBox4.Checked;
			this.colorLine2.DragRepaint = checkBox4.Checked;			
		}

		private void checkBox7_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorLine1.NoLimitDrag = checkBox7.Checked;
			this.colorLine2.NoLimitDrag = checkBox7.Checked;			
		}
	}
}

