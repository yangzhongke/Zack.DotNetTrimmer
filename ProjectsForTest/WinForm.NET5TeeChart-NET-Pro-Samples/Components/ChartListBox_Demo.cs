using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class ChartListBox_Demo : Steema.TeeChart.Samples.BaseNoChart
	{
		private Steema.TeeChart.ChartListBox chartListBox1;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.ChartController commander1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Styles.Line line2;
		private Steema.TeeChart.Styles.Points points1;
		private Steema.TeeChart.Styles.Bar bar1;
		private Steema.TeeChart.Styles.Bar bar2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.Splitter splitter1;
		private System.ComponentModel.IContainer components = null;

		public ChartListBox_Demo()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (TeeChart.Styles.Series s in tChart1.Series) s.FillSampleValues(7);
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
			this.chartListBox1 = new Steema.TeeChart.ChartListBox(this.components);
			this.tChart1 = new Steema.TeeChart.TChart();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.line2 = new Steema.TeeChart.Styles.Line();
			this.points1 = new Steema.TeeChart.Styles.Points();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.bar2 = new Steema.TeeChart.Styles.Bar();
			this.commander1 = new Steema.TeeChart.ChartController();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(513, 62);
			this.textBox1.Text = @"The ""Chart List Box"" component is a custom ListBox to display all Series inside a Chart component.
The end-user can show and hide individual Series and change the default Series color or the Series type itself.

Several properties allow customization of the Listbox. Try clicking, double-clicking and dragging on the listbox.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox4);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.commander1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(513, 77);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.tChart1);
			this.panel2.Controls.Add(this.chartListBox1);
			this.panel2.Location = new System.Drawing.Point(0, 139);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(513, 153);
			// 
			// chartListBox1
			// 
			this.chartListBox1.AllowDrop = true;
			this.chartListBox1.Chart = this.tChart1;
			this.chartListBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.chartListBox1.IntegralHeight = false;
			this.chartListBox1.Location = new System.Drawing.Point(0, 0);
			this.chartListBox1.Name = "chartListBox1";
			this.chartListBox1.OtherItems = null;
			this.chartListBox1.Size = new System.Drawing.Size(112, 153);
			this.chartListBox1.TabIndex = 0;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			//
			//
			this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(112, 0);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Series.Add(this.line2);
			this.tChart1.Series.Add(this.points1);
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Series.Add(this.bar2);
			this.tChart1.Size = new System.Drawing.Size(401, 153);
			this.tChart1.TabIndex = 1;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.Red;
			// 
			// line1.Marks
			// 
			// 
			// line1.Marks.Symbol
			// 
			// 
			// line1.Marks.Symbol.Shadow
			// 
			this.line1.Marks.Symbol.Shadow.Height = 1;
			this.line1.Marks.Symbol.Shadow.Visible = true;
			this.line1.Marks.Symbol.Shadow.Width = 1;
			// 
			// line1.Pointer
			// 
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "line1";
			// 
			// line1.XValues
			// 
			this.line1.XValues.DataMember = "X";
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line1.YValues
			// 
			this.line1.YValues.DataMember = "Y";
			// 
			// line2
			// 
			// 
			// line2.Brush
			// 
			this.line2.Brush.Color = System.Drawing.Color.Green;
			// 
			// line2.Marks
			// 
			// 
			// line2.Marks.Symbol
			// 
			// 
			// line2.Marks.Symbol.Shadow
			// 
			this.line2.Marks.Symbol.Shadow.Height = 1;
			this.line2.Marks.Symbol.Shadow.Visible = true;
			this.line2.Marks.Symbol.Shadow.Width = 1;
			// 
			// line2.Pointer
			// 
			this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line2.Title = "line2";
			// 
			// line2.XValues
			// 
			this.line2.XValues.DataMember = "X";
			this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line2.YValues
			// 
			this.line2.YValues.DataMember = "Y";
			// 
			// points1
			// 
			// 
			// points1.Marks
			// 
			// 
			// points1.Marks.Symbol
			// 
			// 
			// points1.Marks.Symbol.Shadow
			// 
			this.points1.Marks.Symbol.Shadow.Height = 1;
			this.points1.Marks.Symbol.Shadow.Visible = true;
			this.points1.Marks.Symbol.Shadow.Width = 1;
			// 
			// points1.Pointer
			// 
			// 
			// points1.Pointer.Brush
			// 
			this.points1.Pointer.Brush.Color = System.Drawing.Color.Yellow;
			this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.points1.Title = "points1";
			// 
			// points1.XValues
			// 
			this.points1.XValues.DataMember = "X";
			this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// points1.YValues
			// 
			this.points1.YValues.DataMember = "Y";
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.Blue;
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// bar2
			// 
			// 
			// bar2.Brush
			// 
			this.bar2.Brush.Color = System.Drawing.Color.White;
			// 
			// bar2.Marks
			// 
			// 
			// bar2.Marks.Symbol
			// 
			// 
			// bar2.Marks.Symbol.Shadow
			// 
			this.bar2.Marks.Symbol.Shadow.Height = 1;
			this.bar2.Marks.Symbol.Shadow.Visible = true;
			this.bar2.Marks.Symbol.Shadow.Width = 1;
			this.bar2.Title = "bar2";
			// 
			// bar2.XValues
			// 
			this.bar2.XValues.DataMember = "X";
			this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar2.YValues
			// 
			this.bar2.YValues.DataMember = "Bar";
			// 
			// commander1
			// 
			this.commander1.Chart = this.tChart1;
			this.commander1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.commander1.Location = new System.Drawing.Point(0, 40);
			this.commander1.Name = "commander1";
			this.commander1.Size = new System.Drawing.Size(513, 37);
			this.commander1.TabIndex = 0;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(147, 21);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Show &active checkbox";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(153, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(119, 21);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Show series &color";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(260, 7);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(116, 21);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "Show series &icon";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(367, 7);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(121, 21);
			this.checkBox4.TabIndex = 4;
			this.checkBox4.Text = "Show series &titles";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(112, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 153);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// Component_ChartListBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(513, 292);
			this.Name = "Component_ChartListBox";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.chartListBox1.ShowActiveCheck = this.checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.chartListBox1.ShowSeriesColor = this.checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			this.chartListBox1.ShowSeriesIcon = this.checkBox3.Checked;
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			this.chartListBox1.ShowSeriesTitle = this.checkBox4.Checked;
		}
	}
}

