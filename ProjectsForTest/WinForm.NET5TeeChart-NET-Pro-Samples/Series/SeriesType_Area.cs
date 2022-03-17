using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Area : Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Styles.Area areaSeries1;
		private Steema.TeeChart.Styles.Area areaSeries2;
		private Steema.TeeChart.Styles.Area areaSeries3;
		private System.Windows.Forms.CheckBox cBMarks;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Area()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			//			areaSeries1.FillSampleValues(6);
			//			areaSeries2.FillSampleValues(6);
			//			areaSeries3.FillSampleValues(6);

			Random r=new Random();

			for (int s=0; s<tChart1.Series.Count;s++)
				for (int i=0;i<5;i++)
					tChart1[s].Add(r.Next(100-(s*20)));
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
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.areaSeries1 = new Steema.TeeChart.Styles.Area();
			this.areaSeries2 = new Steema.TeeChart.Styles.Area();
			this.areaSeries3 = new Steema.TeeChart.Styles.Area();
			this.cBMarks = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "The Area style allows single or multiple areas, with different layouts ( 3D, stac" +
				"ked, stacked 100% ).\r\nOptions include 2D and 3D, color-each-area, patterns, dark" +
				" 3D, bottom origin, stairs mode, marks, border, etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cBMarks);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Header.Font.Name = "Microsoft Sans Serif";
			this.tChart1.Header.Font.Size = 11;
			this.tChart1.Header.Lines = new string[] {
																								 "Area Series example"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			this.tChart1.Legend.Shadow.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.areaSeries1);
			this.tChart1.Series.Add(this.areaSeries2);
			this.tChart1.Series.Add(this.areaSeries3);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
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
			this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "&Layout :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "3D",
																									 "Stacked",
																									 "Stacked 100%"});
			this.comboBox1.Location = new System.Drawing.Point(53, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(94, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(368, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(160, 11);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(53, 14);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "&Stairs";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(220, 11);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(46, 14);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "&3D";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// areaSeries1
			// 
			// 
			// areaSeries1.AreaBrush
			// 
			this.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(43)), ((System.Byte)(81)));
			// 
			// areaSeries1.Gradient
			// 
			this.areaSeries1.AreaBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(11)), ((System.Byte)(49)));
			this.areaSeries1.AreaBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(43)), ((System.Byte)(81)));
			this.areaSeries1.AreaBrush.Gradient.Visible = true;
			// 
			// areaSeries1.AreaLines
			// 
			this.areaSeries1.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(2)), ((System.Byte)(9)), ((System.Byte)(32)));
			// 
			// areaSeries1.Brush
			// 
			this.areaSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(43)), ((System.Byte)(81)));
			// 
			// areaSeries1.TopGradient
			// 
			this.areaSeries1.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(43)), ((System.Byte)(81)));
			// 
			// areaSeries1.Gradient
			// 
			this.areaSeries1.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(11)), ((System.Byte)(49)));
			this.areaSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(43)), ((System.Byte)(81)));
			this.areaSeries1.Gradient.Visible = true;
			// 
			// areaSeries1.LinePen
			// 
			this.areaSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(2)), ((System.Byte)(9)), ((System.Byte)(32)));
			// 
			// areaSeries1.Marks
			// 
			// 
			// areaSeries1.Marks.Arrow
			// 
			this.areaSeries1.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// areaSeries1.Marks.Brush
			// 
			this.areaSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// areaSeries1.Marks.Gradient
			// 
			this.areaSeries1.Marks.Brush.Gradient.Transparency = 17;
			// 
			// areaSeries1.Marks.Gradient
			// 
			this.areaSeries1.Marks.Gradient.Transparency = 17;
			// 
			// areaSeries1.Marks.Pen
			// 
			this.areaSeries1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// areaSeries1.Marks.Shadow
			// 
			this.areaSeries1.Marks.Shadow.Visible = false;
			// 
			// areaSeries1.Marks.Symbol
			// 
			// 
			// areaSeries1.Marks.Symbol.Shadow
			// 
			this.areaSeries1.Marks.Symbol.Shadow.Height = 1;
			this.areaSeries1.Marks.Symbol.Shadow.Visible = true;
			this.areaSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// areaSeries1.Pointer
			// 
			this.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries1.Title = "area1";
			// 
			// areaSeries1.TopGradient
			// 
			this.areaSeries1.TopGradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(1)), ((System.Byte)(43)), ((System.Byte)(81)));
			// 
			// areaSeries1.XValues
			// 
			this.areaSeries1.XValues.DataMember = "X";
			this.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// areaSeries1.YValues
			// 
			this.areaSeries1.YValues.DataMember = "Y";
			// 
			// areaSeries2
			// 
			// 
			// areaSeries2.AreaBrush
			// 
			this.areaSeries2.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(219)), ((System.Byte)(37)), ((System.Byte)(23)));
			// 
			// areaSeries2.Gradient
			// 
			this.areaSeries2.AreaBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(187)), ((System.Byte)(5)), ((System.Byte)(0)));
			this.areaSeries2.AreaBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(219)), ((System.Byte)(37)), ((System.Byte)(23)));
			this.areaSeries2.AreaBrush.Gradient.Visible = true;
			// 
			// areaSeries2.AreaLines
			// 
			this.areaSeries2.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(148)), ((System.Byte)(26)), ((System.Byte)(16)));
			// 
			// areaSeries2.Brush
			// 
			this.areaSeries2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(219)), ((System.Byte)(37)), ((System.Byte)(23)));
			// 
			// areaSeries2.Gradient
			// 
			this.areaSeries2.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(187)), ((System.Byte)(5)), ((System.Byte)(0)));
			this.areaSeries2.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(219)), ((System.Byte)(37)), ((System.Byte)(23)));
			this.areaSeries2.Gradient.Visible = true;
			// 
			// areaSeries2.LinePen
			// 
			this.areaSeries2.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(148)), ((System.Byte)(26)), ((System.Byte)(15)));
			// 
			// areaSeries2.Marks
			// 
			// 
			// areaSeries2.Marks.Arrow
			// 
			this.areaSeries2.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// areaSeries2.Marks.Brush
			// 
			this.areaSeries2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// areaSeries2.Marks.Gradient
			// 
			this.areaSeries2.Marks.Brush.Gradient.Transparency = 17;
			// 
			// areaSeries2.Marks.Gradient
			// 
			this.areaSeries2.Marks.Gradient.Transparency = 17;
			// 
			// areaSeries2.Marks.Pen
			// 
			this.areaSeries2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// areaSeries2.Marks.Shadow
			// 
			this.areaSeries2.Marks.Shadow.Visible = false;
			// 
			// areaSeries2.Marks.Symbol
			// 
			// 
			// areaSeries2.Marks.Symbol.Shadow
			// 
			this.areaSeries2.Marks.Symbol.Shadow.Height = 1;
			this.areaSeries2.Marks.Symbol.Shadow.Visible = true;
			this.areaSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// areaSeries2.Pointer
			// 
			this.areaSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries2.Title = "area2";
			// 
			// areaSeries2.XValues
			// 
			this.areaSeries2.XValues.DataMember = "X";
			this.areaSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// areaSeries2.YValues
			// 
			this.areaSeries2.YValues.DataMember = "Y";
			// 
			// areaSeries3
			// 
			// 
			// areaSeries3.AreaBrush
			// 
			this.areaSeries3.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(234)), ((System.Byte)(88)));
			// 
			// areaSeries3.Gradient
			// 
			this.areaSeries3.AreaBrush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(223)), ((System.Byte)(202)), ((System.Byte)(56)));
			this.areaSeries3.AreaBrush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(234)), ((System.Byte)(88)));
			this.areaSeries3.AreaBrush.Gradient.Visible = true;
			// 
			// areaSeries3.AreaLines
			// 
			this.areaSeries3.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(206)), ((System.Byte)(186)), ((System.Byte)(0)));
			// 
			// areaSeries3.Brush
			// 
			this.areaSeries3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(234)), ((System.Byte)(88)));
			// 
			// areaSeries3.Gradient
			// 
			this.areaSeries3.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(223)), ((System.Byte)(202)), ((System.Byte)(56)));
			this.areaSeries3.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(234)), ((System.Byte)(88)));
			this.areaSeries3.Gradient.Visible = true;
			// 
			// areaSeries3.LinePen
			// 
			this.areaSeries3.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(206)), ((System.Byte)(186)), ((System.Byte)(0)));
			// 
			// areaSeries3.Marks
			// 
			// 
			// areaSeries3.Marks.Arrow
			// 
			this.areaSeries3.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// areaSeries3.Marks.Brush
			// 
			this.areaSeries3.Marks.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// areaSeries3.Marks.Gradient
			// 
			this.areaSeries3.Marks.Brush.Gradient.Transparency = 17;
			// 
			// areaSeries3.Marks.Gradient
			// 
			this.areaSeries3.Marks.Gradient.Transparency = 17;
			// 
			// areaSeries3.Marks.Pen
			// 
			this.areaSeries3.Marks.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// areaSeries3.Marks.Shadow
			// 
			this.areaSeries3.Marks.Shadow.Visible = false;
			// 
			// areaSeries3.Marks.Symbol
			// 
			// 
			// areaSeries3.Marks.Symbol.Shadow
			// 
			this.areaSeries3.Marks.Symbol.Shadow.Height = 1;
			this.areaSeries3.Marks.Symbol.Shadow.Visible = true;
			this.areaSeries3.Marks.Symbol.Shadow.Width = 1;
			// 
			// areaSeries3.Pointer
			// 
			this.areaSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries3.Title = "area3";
			// 
			// areaSeries3.XValues
			// 
			this.areaSeries3.XValues.DataMember = "X";
			this.areaSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// areaSeries3.YValues
			// 
			this.areaSeries3.YValues.DataMember = "Y";
			// 
			// cBMarks
			// 
			this.cBMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cBMarks.Location = new System.Drawing.Point(273, 10);
			this.cBMarks.Name = "cBMarks";
			this.cBMarks.Size = new System.Drawing.Size(87, 16);
			this.cBMarks.TabIndex = 8;
			this.cBMarks.Text = "Show &Marks";
			this.cBMarks.CheckedChanged += new System.EventHandler(this.cBMarks_CheckedChanged);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Area
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Area";
			this.Load += new System.EventHandler(this.SeriesType_Area_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.areaSeries1);
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = checkBox2.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			areaSeries1.Stairs = checkBox1.Checked;
			areaSeries2.Stairs = checkBox1.Checked;
			areaSeries3.Stairs = checkBox1.Checked;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : areaSeries1.MultiArea = Steema.TeeChart.Styles.MultiAreas.None; break;
				case 1 : areaSeries1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked; break;
				case 2 : areaSeries1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked100; break;
			}

			if (comboBox1.SelectedIndex==0)
			{
				areaSeries1.Marks.Visible = cBMarks.Checked;
				areaSeries2.Marks.Visible = cBMarks.Checked;
				areaSeries3.Marks.Visible = cBMarks.Checked;
			}
			else
			{
				// remove "Marks" when stacking...
				areaSeries1.Marks.Visible = (areaSeries1.MultiArea == Steema.TeeChart.Styles.MultiAreas.None);
				areaSeries2.Marks.Visible = (areaSeries2.MultiArea == Steema.TeeChart.Styles.MultiAreas.None);
				areaSeries3.Marks.Visible = (areaSeries3.MultiArea == Steema.TeeChart.Styles.MultiAreas.None);
			}
		}

		private void SeriesType_Area_Load(object sender, System.EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}

		private void cBMarks_CheckedChanged(object sender, System.EventArgs e)
		{
			comboBox1_SelectedIndexChanged(sender, e);
		}
	}
}

