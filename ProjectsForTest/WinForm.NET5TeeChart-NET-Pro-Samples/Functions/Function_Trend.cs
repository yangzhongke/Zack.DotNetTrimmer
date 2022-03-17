using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart.Functions;

namespace Steema.TeeChart.Samples
{
	public class Function_Trend : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.Area area1;
    private Steema.TeeChart.Functions.TrendFunction trendFunction1;
    private Steema.TeeChart.Styles.Line line1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public Function_Trend()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            area1.FillSampleValues();
            for (int i = 0; i < area1.Count; i++)
                area1.XValues[i] += 1;
            trendFunction1.Recalculate();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_Trend));
			this.area1 = new Steema.TeeChart.Styles.Area();
			this.trendFunction1 = new Steema.TeeChart.Functions.TrendFunction();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(440, 56);
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
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
			this.tChart1.Header.Font.Bold = true;
			this.tChart1.Header.Font.Name = "Courier New";
			this.tChart1.Header.Lines = new string[] {
        "Trendline example"};
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
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.Series.Add(this.area1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Size = new System.Drawing.Size(440, 222);
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 95);
			this.chartContainer.Size = new System.Drawing.Size(440, 222);
			// 
			// area1
			// 
			// 
			// 
			// 
			this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			// 
			// 
			// 
			this.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.area1.Gradient.Transparency = 20;
			// 
			// 
			// 
			this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			// 
			// 
			// 
			this.area1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.area1.Brush.Visible = false;
			this.area1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.area1.ColorEach = false;
			// 
			// 
			// 
			this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.area1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.area1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.area1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.area1.Marks.Callout.Distance = 0;
			this.area1.Marks.Callout.Draw3D = false;
			this.area1.Marks.Callout.Length = 10;
			this.area1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.area1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.area1.Title = "Data";
			// 
			// 
			// 
			this.area1.XValues.DataMember = "X";
			this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.area1.YValues.DataMember = "Y";
			// 
			// line1
			// 
			// 
			// 
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.line1.ColorEach = false;
			this.line1.DataSource = this.area1;
			this.line1.Function = this.trendFunction1;
			// 
			// 
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
			this.line1.LinePen.Style = Drawing.DashStyle.DashDot;
			this.line1.LinePen.Width = 2;
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
			this.line1.Title = "Trendline";
			// 
			// 
			// 
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "New random points";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Exponential",
            "Logarithmic"});
			this.comboBox1.Location = new System.Drawing.Point(280, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "comboBox1";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(208, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Trend style:";
			// 
			// Function_Trend
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Function_Trend";
			this.Load += new System.EventHandler(this.Function_Trend_Load);
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

    private void button1_Click(object sender, System.EventArgs e)
    {
      area1.FillSampleValues();
      for (int i = 0; i < area1.Count; i++)
          area1.XValues[i] += 1;
      trendFunction1.Recalculate();
  }

    private void Function_Trend_Load(object sender, System.EventArgs e)
    {
      comboBox1.SelectedIndex = 0;
    }

    private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      switch (comboBox1.SelectedIndex)
      {
        case 0 : 
        {
          trendFunction1.TrendStyle = TrendStyles.Normal; 
          trendFunction1.Series.Title = "Trendline"; break;
        }
        case 1 : 
        {
          trendFunction1.TrendStyle = TrendStyles.Exponential;
          trendFunction1.Series.Title = "Exp.trendline"; break;
        }
        case 2 : 
        {
          trendFunction1.TrendStyle = TrendStyles.Logarithmic;
          trendFunction1.Series.Title = "Log.trendline"; break;
        }
      }
    }
	}
}

