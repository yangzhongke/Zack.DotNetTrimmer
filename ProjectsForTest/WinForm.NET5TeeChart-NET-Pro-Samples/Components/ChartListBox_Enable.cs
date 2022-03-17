using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ChartListBoxEnable : Steema.TeeChart.Samples.BaseNoChart
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox CBColor;
		private System.Windows.Forms.CheckBox CBType;
		private System.Windows.Forms.CheckBox CBInsert;
		private System.Windows.Forms.CheckBox CBDelete;
		private System.Windows.Forms.CheckBox CBDrag;
		private System.Windows.Forms.Panel pLeft;
		private System.Windows.Forms.Panel pRight;
		private System.Windows.Forms.Splitter splitter1;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.ChartListBox chartListBox1;
		private Steema.TeeChart.Styles.Area area1;
		private Steema.TeeChart.Styles.Bar bar1;
		private Steema.TeeChart.Styles.Bubble bubble1;
		private Steema.TeeChart.Styles.Line line1;
		private System.ComponentModel.IContainer components = null;

		public ChartListBoxEnable()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach(Steema.TeeChart.Styles.Series s in tChart1.Series) {
				s.FillSampleValues();
			}
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CBDrag = new System.Windows.Forms.CheckBox();
			this.CBDelete = new System.Windows.Forms.CheckBox();
			this.CBInsert = new System.Windows.Forms.CheckBox();
			this.CBType = new System.Windows.Forms.CheckBox();
			this.CBColor = new System.Windows.Forms.CheckBox();
			this.pLeft = new System.Windows.Forms.Panel();
			this.chartListBox1 = new Steema.TeeChart.ChartListBox(this.components);
			this.tChart1 = new Steema.TeeChart.TChart();
			this.area1 = new Steema.TeeChart.Styles.Area();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.bubble1 = new Steema.TeeChart.Styles.Bubble();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.pRight = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pLeft.SuspendLayout();
			this.pRight.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = @"The ChartListBox component now has additional properties to control if the
end-user can change a Series type or Series color, if Series can be
re-ordered by dragging, and if Series can be deleted pressing the Del key.

Example: chartListBox1.EnableChangeColor=false;

ChartListBox now also synchronizes when Series are added or deleted programatically";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Name = "panel1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.pRight);
			this.panel2.Controls.Add(this.pLeft);
			this.panel2.Name = "panel2";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CBDrag);
			this.groupBox1.Controls.Add(this.CBDelete);
			this.groupBox1.Controls.Add(this.CBInsert);
			this.groupBox1.Controls.Add(this.CBType);
			this.groupBox1.Controls.Add(this.CBColor);
			this.groupBox1.Location = new System.Drawing.Point(2, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(421, 39);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enable";
			// 
			// CBDrag
			// 
			this.CBDrag.Checked = true;
			this.CBDrag.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CBDrag.Location = new System.Drawing.Point(331, 14);
			this.CBDrag.Name = "CBDrag";
			this.CBDrag.Size = new System.Drawing.Size(83, 19);
			this.CBDrag.TabIndex = 4;
			this.CBDrag.Text = "Drag Series";
			this.CBDrag.Click += new System.EventHandler(this.CBDrag_Click);
			// 
			// CBDelete
			// 
			this.CBDelete.Checked = true;
			this.CBDelete.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CBDelete.Location = new System.Drawing.Point(255, 14);
			this.CBDelete.Name = "CBDelete";
			this.CBDelete.Size = new System.Drawing.Size(81, 19);
			this.CBDelete.TabIndex = 3;
			this.CBDelete.Text = "Delete Key";
			this.CBDelete.Click += new System.EventHandler(this.CBDelete_Click);
			// 
			// CBInsert
			// 
			this.CBInsert.Checked = true;
			this.CBInsert.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CBInsert.Location = new System.Drawing.Point(186, 14);
			this.CBInsert.Name = "CBInsert";
			this.CBInsert.Size = new System.Drawing.Size(74, 19);
			this.CBInsert.TabIndex = 2;
			this.CBInsert.Text = "Insert Key";
			this.CBInsert.Click += new System.EventHandler(this.CBInsert_Click);
			// 
			// CBType
			// 
			this.CBType.Checked = true;
			this.CBType.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CBType.Location = new System.Drawing.Point(96, 14);
			this.CBType.Name = "CBType";
			this.CBType.Size = new System.Drawing.Size(93, 19);
			this.CBType.TabIndex = 1;
			this.CBType.Text = "Change Type";
			this.CBType.Click += new System.EventHandler(this.CBType_Click);
			// 
			// CBColor
			// 
			this.CBColor.Checked = true;
			this.CBColor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CBColor.Location = new System.Drawing.Point(8, 14);
			this.CBColor.Name = "CBColor";
			this.CBColor.Size = new System.Drawing.Size(93, 19);
			this.CBColor.TabIndex = 0;
			this.CBColor.Text = "Change Color";
			this.CBColor.Click += new System.EventHandler(this.CBColor_Click);
			// 
			// pLeft
			// 
			this.pLeft.BackColor = System.Drawing.Color.White;
			this.pLeft.Controls.Add(this.chartListBox1);
			this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pLeft.Location = new System.Drawing.Point(0, 0);
			this.pLeft.Name = "pLeft";
			this.pLeft.Size = new System.Drawing.Size(176, 154);
			this.pLeft.TabIndex = 0;
			// 
			// chartListBox1
			// 
			this.chartListBox1.AllowDrop = true;
			this.chartListBox1.Chart = this.tChart1;
			this.chartListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartListBox1.Location = new System.Drawing.Point(0, 0);
			this.chartListBox1.Name = "chartListBox1";
			this.chartListBox1.OtherItems = null;
			this.chartListBox1.Size = new System.Drawing.Size(176, 148);
			this.chartListBox1.TabIndex = 0;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.BackColor = System.Drawing.Color.Red;
			this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			this.tChart1.Location = new System.Drawing.Point(0, 0);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(225)), ((System.Byte)(225)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.area1);
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Series.Add(this.bubble1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Size = new System.Drawing.Size(250, 154);
			this.tChart1.TabIndex = 0;
			// 
			// tChart1.Walls
			// 
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
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// area1
			// 
			// 
			// area1.AreaBrush
			// 
			this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// area1.AreaLines
			// 
			this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(153)), ((System.Byte)(77)), ((System.Byte)(0)));
			// 
			// area1.Brush
			// 
			this.area1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// area1.LinePen
			// 
			this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(153)), ((System.Byte)(77)), ((System.Byte)(0)));
			// 
			// area1.Marks
			// 
			// 
			// area1.Marks.Font
			// 
			// 
			// area1.Marks.Font.Brush
			// 
			this.area1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.area1.Marks.Font.Size = 14;
			// 
			// area1.Marks.Pen
			// 
			this.area1.Marks.Pen.Visible = false;
			// 
			// area1.Marks.Symbol
			// 
			// 
			// area1.Marks.Symbol.Shadow
			// 
			this.area1.Marks.Symbol.Shadow.Height = 1;
			this.area1.Marks.Symbol.Shadow.Visible = true;
			this.area1.Marks.Symbol.Shadow.Width = 1;
			// 
			// area1.Pointer
			// 
			this.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.area1.Title = "area1";
			// 
			// area1.XValues
			// 
			this.area1.XValues.DataMember = "X";
			this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// area1.YValues
			// 
			this.area1.YValues.DataMember = "Y";
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Font
			// 
			// 
			// bar1.Marks.Font.Brush
			// 
			this.bar1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.bar1.Marks.Font.Size = 14;
			// 
			// bar1.Marks.Pen
			// 
			this.bar1.Marks.Pen.Visible = false;
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			this.bar1.Marks.Transparent = true;
			// 
			// bar1.Pen
			// 
			this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(153)), ((System.Byte)(153)), ((System.Byte)(77)));
			this.bar1.Title = "bar2";
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
			// bubble1
			// 
			this.bubble1.ColorEach = false;
			this.bubble1.LabelMember = "Labels";
			// 
			// bubble1.LinePen
			// 
			this.bubble1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(77)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// bubble1.Marks
			// 
			// 
			// bubble1.Marks.Symbol
			// 
			// 
			// bubble1.Marks.Symbol.Shadow
			// 
			this.bubble1.Marks.Symbol.Shadow.Height = 1;
			this.bubble1.Marks.Symbol.Shadow.Visible = true;
			this.bubble1.Marks.Symbol.Shadow.Width = 1;
			this.bubble1.Marks.Transparent = true;
			// 
			// bubble1.Pointer
			// 
			// 
			// bubble1.Pointer.Brush
			// 
			this.bubble1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.bubble1.Pointer.InflateMargins = false;
			// 
			// bubble1.Pointer.Pen
			// 
			this.bubble1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(77)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere;
			this.bubble1.Title = "bubble3";
			// 
			// bubble1.XValues
			// 
			this.bubble1.XValues.DataMember = "X";
			this.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bubble1.YValues
			// 
			this.bubble1.YValues.DataMember = "Y";
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(64)));
			// 
			// line1.LinePen
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(38)));
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
			this.line1.Title = "line4";
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
			// pRight
			// 
			this.pRight.BackColor = System.Drawing.Color.White;
			this.pRight.Controls.Add(this.tChart1);
			this.pRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pRight.Location = new System.Drawing.Point(176, 0);
			this.pRight.Name = "pRight";
			this.pRight.Size = new System.Drawing.Size(250, 154);
			this.pRight.TabIndex = 1;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(176, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 154);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// ChartListBoxEnable
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(426, 258);
			this.Name = "ChartListBoxEnable";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.pLeft.ResumeLayout(false);
			this.pRight.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void CBColor_Click(object sender, System.EventArgs e) {
			chartListBox1.EnableChangeColor = CBColor.Checked;
		}

		private void CBType_Click(object sender, System.EventArgs e) {
			chartListBox1.EnableChangeType = CBType.Checked;
		}

		private void CBInsert_Click(object sender, System.EventArgs e) {
			chartListBox1.AllowAddSeries = CBInsert.Checked;
		}

		private void CBDelete_Click(object sender, System.EventArgs e) {
			chartListBox1.AllowDeleteSeries = CBDelete.Checked;
		}

		private void CBDrag_Click(object sender, System.EventArgs e) {
			chartListBox1.EnableDragSeries = CBDrag.Checked;
		}

	
	}
}

