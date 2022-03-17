using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Bar_StackGroup : Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Styles.Bar barSeries2;
		private Steema.TeeChart.Styles.Bar barSeries3;
		private Steema.TeeChart.Styles.Bar barSeries4;
		private Steema.TeeChart.Styles.Bar barSeries5;
		private System.Windows.Forms.Label label2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Bar_StackGroup()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(5);
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.barSeries2 = new Steema.TeeChart.Styles.Bar();
			this.barSeries3 = new Steema.TeeChart.Styles.Bar();
			this.barSeries4 = new Steema.TeeChart.Styles.Bar();
			this.barSeries5 = new Steema.TeeChart.Styles.Bar();
			this.label2 = new System.Windows.Forms.Label();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 96);
			this.textBox1.Text = @"Stacked Bar and Horiz. Bar series can be grouped. 
The StackGroup property defines the ""group"". There is no limit on how many groups exist.

barSeries1.MultiBar = Steema.TeeChart.Multibars.Stacked;
barSeries1.StackGroup = 0 ;  
barSeries2.StackGroup = 1 ; ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Location = new System.Drawing.Point(0, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(244)), ((System.Byte)(244)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			this.tChart1.Legend.Shadow.Visible = false;
			// 
			// tChart1.Legend.Symbol
			// 
			this.tChart1.Legend.Symbol.Continous = true;
			// 
			// tChart1.Legend.Symbol.Pen
			// 
			this.tChart1.Legend.Symbol.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Symbol.Pen.Style = Drawing.DashStyle.Dash;
			this.tChart1.Location = new System.Drawing.Point(0, 129);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Series.Add(this.barSeries2);
			this.tChart1.Series.Add(this.barSeries3);
			this.tChart1.Series.Add(this.barSeries4);
			this.tChart1.Series.Add(this.barSeries5);
			this.tChart1.Size = new System.Drawing.Size(466, 157);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 6;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Stack has ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "1",
																									 "2",
																									 "3",
																									 "4",
																									 "5"});
			this.comboBox1.Location = new System.Drawing.Point(80, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(47, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// barSeries1.Marks
			// 
			// 
			// barSeries1.Marks.Symbol
			// 
			// 
			// barSeries1.Marks.Symbol.Shadow
			// 
			this.barSeries1.Marks.Symbol.Shadow.Height = 1;
			this.barSeries1.Marks.Symbol.Shadow.Visible = true;
			this.barSeries1.Marks.Symbol.Shadow.Width = 1;
			this.barSeries1.Marks.Visible = false;
			this.barSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
			// 
			// barSeries1.Pen
			// 
			this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.barSeries1.Title = "barSeries1";
			// 
			// barSeries1.XValues
			// 
			this.barSeries1.XValues.DataMember = "X";
			this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries1.YValues
			// 
			this.barSeries1.YValues.DataMember = "Bar";
			// 
			// barSeries2
			// 
			// 
			// barSeries2.Brush
			// 
			this.barSeries2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// barSeries2.Marks
			// 
			// 
			// barSeries2.Marks.Symbol
			// 
			// 
			// barSeries2.Marks.Symbol.Shadow
			// 
			this.barSeries2.Marks.Symbol.Shadow.Height = 1;
			this.barSeries2.Marks.Symbol.Shadow.Visible = true;
			this.barSeries2.Marks.Symbol.Shadow.Width = 1;
			this.barSeries2.Marks.Visible = false;
			this.barSeries2.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
			// 
			// barSeries2.Pen
			// 
			this.barSeries2.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this.barSeries2.Title = "barSeries2";
			// 
			// barSeries2.XValues
			// 
			this.barSeries2.XValues.DataMember = "X";
			this.barSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries2.YValues
			// 
			this.barSeries2.YValues.DataMember = "Bar";
			// 
			// barSeries3
			// 
			// 
			// barSeries3.Brush
			// 
			this.barSeries3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			// 
			// barSeries3.Marks
			// 
			// 
			// barSeries3.Marks.Symbol
			// 
			// 
			// barSeries3.Marks.Symbol.Shadow
			// 
			this.barSeries3.Marks.Symbol.Shadow.Height = 1;
			this.barSeries3.Marks.Symbol.Shadow.Visible = true;
			this.barSeries3.Marks.Symbol.Shadow.Width = 1;
			this.barSeries3.Marks.Visible = false;
			this.barSeries3.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
			// 
			// barSeries3.Pen
			// 
			this.barSeries3.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.barSeries3.Title = "barSeries3";
			// 
			// barSeries3.XValues
			// 
			this.barSeries3.XValues.DataMember = "X";
			this.barSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries3.YValues
			// 
			this.barSeries3.YValues.DataMember = "Bar";
			// 
			// barSeries4
			// 
			// 
			// barSeries4.Brush
			// 
			this.barSeries4.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
			// 
			// barSeries4.Marks
			// 
			// 
			// barSeries4.Marks.Symbol
			// 
			// 
			// barSeries4.Marks.Symbol.Shadow
			// 
			this.barSeries4.Marks.Symbol.Shadow.Height = 1;
			this.barSeries4.Marks.Symbol.Shadow.Visible = true;
			this.barSeries4.Marks.Symbol.Shadow.Width = 1;
			this.barSeries4.Marks.Visible = false;
			this.barSeries4.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
			// 
			// barSeries4.Pen
			// 
			this.barSeries4.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(64)));
			this.barSeries4.StackGroup = 1;
			this.barSeries4.Title = "barSeries4";
			// 
			// barSeries4.XValues
			// 
			this.barSeries4.XValues.DataMember = "X";
			this.barSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries4.YValues
			// 
			this.barSeries4.YValues.DataMember = "Bar";
			// 
			// barSeries5
			// 
			// 
			// barSeries5.Brush
			// 
			this.barSeries5.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// barSeries5.Marks
			// 
			// 
			// barSeries5.Marks.Symbol
			// 
			// 
			// barSeries5.Marks.Symbol.Shadow
			// 
			this.barSeries5.Marks.Symbol.Shadow.Height = 1;
			this.barSeries5.Marks.Symbol.Shadow.Visible = true;
			this.barSeries5.Marks.Symbol.Shadow.Width = 1;
			this.barSeries5.Marks.Visible = false;
			this.barSeries5.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
			// 
			// barSeries5.Pen
			// 
			this.barSeries5.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.barSeries5.StackGroup = 1;
			this.barSeries5.Title = "barSeries5";
			// 
			// barSeries5.XValues
			// 
			this.barSeries5.XValues.DataMember = "X";
			this.barSeries5.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries5.YValues
			// 
			this.barSeries5.YValues.DataMember = "Bar";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(133, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "series";
			this.label2.UseMnemonic = false;
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			// 
			// Bar_GroupStack
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Bar_GroupStack";
			this.Load += new System.EventHandler(this.Bar_GroupStack_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Bar_GroupStack_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 2;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int t;
			for (t=0; t<=(int)this.comboBox1.SelectedIndex; t++)
				(tChart1.Series[t] as Steema.TeeChart.Styles.Bar).StackGroup = 0;
			for (t=(int)this.comboBox1.SelectedIndex+1; t<tChart1.Series.Count; t++)
				(tChart1.Series[t] as Steema.TeeChart.Styles.Bar).StackGroup = 1;
		}
	}
}

