using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Realtime : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Styles.Line lineSeries3;
		private Steema.TeeChart.Styles.Line lineSeries4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.CheckBox checkBox3;
		private System.ComponentModel.IContainer components = null;

		public Realtime()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realtime));
      this.lineSeries1 = new Steema.TeeChart.Styles.Line();
      this.lineSeries2 = new Steema.TeeChart.Styles.Line();
      this.lineSeries3 = new Steema.TeeChart.Styles.Line();
      this.lineSeries4 = new Steema.TeeChart.Styles.Line();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(488, 48);
      this.textBox1.Text = "Using series Delete method you can easily do realtime charting. \r\nScrolling and a" +
    "xis range scaling is done automatically.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.checkBox3);
      this.panel1.Controls.Add(this.checkBox2);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Location = new System.Drawing.Point(0, 48);
      this.panel1.Size = new System.Drawing.Size(488, 32);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.View3D = false;
      // 
      // 
      // 
      this.tChart1.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Separation = 40;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Header.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Header.Lines = new string[] {
        "tChart1"};
      // 
      // 
      // 
      this.tChart1.Header.Shadow.Height = 0;
      this.tChart1.Header.Shadow.Width = 0;
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
      this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.LastValues;
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
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(225)))));
      this.tChart1.Series.Add(this.lineSeries1);
      this.tChart1.Series.Add(this.lineSeries2);
      this.tChart1.Series.Add(this.lineSeries3);
      this.tChart1.Series.Add(this.lineSeries4);
      this.tChart1.Size = new System.Drawing.Size(488, 237);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Back.Brush.Visible = false;
      this.tChart1.Walls.Back.Transparent = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
      this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // chartContainer
      // 
      this.chartContainer.Location = new System.Drawing.Point(0, 80);
      this.chartContainer.Size = new System.Drawing.Size(488, 237);
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
      this.lineSeries1.LinePen.Width = 2;
      this.lineSeries1.OriginalCursor = null;
      // 
      // 
      // 
      this.lineSeries1.Pointer.SizeDouble = 0D;
      this.lineSeries1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.lineSeries1.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
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
      // lineSeries2
      // 
      // 
      // 
      // 
      this.lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.lineSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.lineSeries2.ColorEach = false;
      // 
      // 
      // 
      this.lineSeries2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.lineSeries2.LinePen.Width = 2;
      this.lineSeries2.OriginalCursor = null;
      // 
      // 
      // 
      this.lineSeries2.Pointer.SizeDouble = 0D;
      this.lineSeries2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.lineSeries2.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
      this.lineSeries2.Title = "lineSeries2";
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
      this.lineSeries3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.lineSeries3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.lineSeries3.ColorEach = false;
      // 
      // 
      // 
      this.lineSeries3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
      this.lineSeries3.LinePen.Width = 2;
      this.lineSeries3.OriginalCursor = null;
      // 
      // 
      // 
      this.lineSeries3.Pointer.SizeDouble = 0D;
      this.lineSeries3.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.lineSeries3.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
      this.lineSeries3.Title = "lineSeries3";
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
      // lineSeries4
      // 
      // 
      // 
      // 
      this.lineSeries4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
      this.lineSeries4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
      this.lineSeries4.ColorEach = false;
      // 
      // 
      // 
      this.lineSeries4.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
      this.lineSeries4.LinePen.Width = 2;
      this.lineSeries4.OriginalCursor = null;
      // 
      // 
      // 
      this.lineSeries4.Pointer.SizeDouble = 0D;
      this.lineSeries4.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.lineSeries4.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
      this.lineSeries4.Title = "lineSeries4";
      // 
      // 
      // 
      this.lineSeries4.XValues.DataMember = "X";
      this.lineSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.lineSeries4.YValues.DataMember = "Y";
      // 
      // checkBox1
      // 
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox1.Location = new System.Drawing.Point(16, 7);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(67, 21);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "&Animate";
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // checkBox2
      // 
      this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox2.Location = new System.Drawing.Point(112, 7);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(46, 21);
      this.checkBox2.TabIndex = 1;
      this.checkBox2.Text = "&3D";
      this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 50;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // checkBox3
      // 
      this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox3.Location = new System.Drawing.Point(192, 5);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(104, 24);
      this.checkBox3.TabIndex = 2;
      this.checkBox3.Text = "&Legend";
      this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
      // 
      // Realtime
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(488, 317);
      this.Name = "Realtime";
      this.Load += new System.EventHandler(this.Realtime_Load);
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion

		private void AnimateSeries(Steema.TeeChart.TChart chart)
		{
			Random rnd = new Random();
			double newX, newY;
			chart.AutoRepaint = false;

			foreach (TeeChart.Styles.Series s in chart.Series)
			{
				// show only 50 points - delete the rest
				while (s.Count > 50) s.Delete(0);
				if(s.Count > 50) s.Delete(0);  
				newX = s.XValues.Last + 1;
				newY = s.YValues.Last + 1000*rnd.Next(2) - 500;
				if (Math.Abs(newY)>1.0e+4) newY = 0.0;
				s.Add(newX,newY);
			}

			chart.AutoRepaint = true;
			chart.Refresh();
		}
		
		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Aspect.View3D = this.checkBox2.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.timer1.Enabled = this.checkBox1.Checked;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			AnimateSeries(this.tChart1);
		}

		private void Realtime_Load(object sender, System.EventArgs e)
		{
			tChart1.Axes.Bottom.Increment = 5;

			// add one sample value to each Series
			lineSeries1.Add (1000);
			lineSeries2.Add (1000);
			lineSeries3.Add (1000);
			lineSeries4.Add (1000);
		}

    private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
    {
      tChart1.Legend.Visible=checkBox3.Checked;
    }
	}
}

