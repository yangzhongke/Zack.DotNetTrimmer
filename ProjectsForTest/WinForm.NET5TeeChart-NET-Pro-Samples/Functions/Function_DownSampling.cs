using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Function_DownSampling : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.Points points1;
    private Steema.TeeChart.Styles.Line line1;
    private Steema.TeeChart.Functions.DownSampling downsampling1;
    private System.Windows.Forms.HScrollBar hScrollBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
		private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBox1;

    public Function_DownSampling()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			points1.FillSampleValues(1000);
      // connect function to parent series 
      line1.DataSource = points1;
      // setup downnsapling function properties
      downsampling1.Tolerance = 10.0;
      line1.Function = downsampling1;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_DownSampling));
			this.points1 = new Steema.TeeChart.Styles.Points();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.downsampling1 = new Steema.TeeChart.Functions.DownSampling();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(440, 104);
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Location = new System.Drawing.Point(0, 104);
			this.panel1.Size = new System.Drawing.Size(440, 80);
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
			this.tChart1.Axes.Bottom.MaximumOffset = 3;
			this.tChart1.Axes.Bottom.MinimumOffset = 3;
			// 
			// 
			// 
			this.tChart1.Axes.Left.MaximumOffset = 3;
			this.tChart1.Axes.Left.MinimumOffset = 3;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "Downsampling function example"};
			// 
			// 
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Series.Add(this.points1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Size = new System.Drawing.Size(440, 133);
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 184);
			this.chartContainer.Size = new System.Drawing.Size(440, 133);
			// 
			// points1
			// 
			this.points1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.points1.ColorEach = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.points1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.points1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.points1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.points1.Marks.Callout.Distance = 0;
			this.points1.Marks.Callout.Draw3D = false;
			this.points1.Marks.Callout.Length = 0;
			this.points1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.points1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.points1.Pointer.HorizSize = 2;
			// 
			// 
			// 
			this.points1.Pointer.Pen.Visible = false;
			this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle;
			this.points1.Pointer.VertSize = 2;
			this.points1.Title = "Data";
			// 
			// 
			// 
			this.points1.XValues.DataMember = "X";
			this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.points1.YValues.DataMember = "Y";
			// 
			// line1
			// 
			// 
			// 
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.line1.ColorEach = false;
			// 
			// 
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.line1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.line1.Marks.Callout.Distance = 0;
			this.line1.Marks.Callout.Draw3D = false;
			this.line1.Marks.Callout.Length = 10;
			this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "Reduced data";
			// 
			// 
			// 
			this.line1.XValues.DataMember = "X";
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.line1.YValues.DataMember = "Y";
			// 
			// downsampling1
			// 
			this.downsampling1.DisplayedPointCount = 0;
			this.downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.Average;
			this.downsampling1.Period = 1;
			this.downsampling1.Tolerance = 1;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.LargeChange = 1000;
			this.hScrollBar1.Location = new System.Drawing.Point(8, 16);
			this.hScrollBar1.Maximum = 10000;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(152, 16);
			this.hScrollBar1.SmallChange = 100;
			this.hScrollBar1.TabIndex = 0;
			this.hScrollBar1.Value = 1000;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data points :  1000";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(200, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tolerance :";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(272, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox2.Size = new System.Drawing.Size(40, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "10";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(208, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Method :";
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "Average",
            "Maximum",
            "Minimum",
            "Minimum AND Maximum"});
			this.comboBox1.Location = new System.Drawing.Point(272, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "label4";
			// 
			// Function_DownSampling
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Function_DownSampling";
			this.Load += new System.EventHandler(this.Function_DownSampling_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

    private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
    {
      label1.Text = "Data points : " + hScrollBar1.Value.ToString();
      points1.Clear();
      points1.BeginUpdate();
      // repopulate
      System.Random r = new System.Random();
      double tmp = r.NextDouble()*10000;
      for (int t=0; t<hScrollBar1.Value; t++)
      {
        tmp += r.Next(100)-49.5;
        points1.Add(t,tmp);
      }
      points1.EndUpdate();     
      downsampling1.Recalculate();
      label4.Text = "Reduced data size :"+ downsampling1.ReducedSize.ToString();
    }

    private void textBox2_TextChanged(object sender, System.EventArgs e)
    {
      line1.BeginUpdate();
      double factor = Convert.ToDouble(textBox2.Text);
      line1.EndUpdate();
      downsampling1.Tolerance = factor;
      label4.Text = "Reduced data size :"+ downsampling1.ReducedSize.ToString();
    }

    private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      switch (comboBox1.SelectedIndex)
      {
        case 0 : downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.Average; break;
        case 1 : downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.Max; break;
        case 2 : downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.Min; break;
        case 3 : downsampling1.Method = Steema.TeeChart.Functions.DownSamplingMethod.MinMax; break;
      }
      label4.Text = "Reduced data size :"+ downsampling1.ReducedSize.ToString();
    }

    private void Function_DownSampling_Load(object sender, System.EventArgs e)
    {
      comboBox1.SelectedIndex = 0;
    }
	}
}

