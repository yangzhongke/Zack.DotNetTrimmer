using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class WindRose_Series : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.WindRose windRose1;
		private Steema.TeeChart.Styles.WindRose windRose2;
		private System.ComponentModel.IContainer components = null;

		public WindRose_Series()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			windRose1.Clear();
			windRose1.Add(30,100);
			windRose1.Add(60, 200);
			windRose1.Add(90,  50);
			windRose1.Add(120, 150);

			windRose2.Clear();
			windRose2.Add(130, 100);
			windRose2.Add(160, 200);
			windRose2.Add(190,  50);
			windRose2.Add(220, 150);

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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.windRose1 = new Steema.TeeChart.Styles.WindRose();
			this.windRose2 = new Steema.TeeChart.Styles.WindRose();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Wind-Rose series is a polar chart showing geographical coordinates around the cir" +
				"cle. ( N = North, S = South, W = West, E = East ).\r\n\r\nDisplays more than one ser" +
				"ies at the same time, each one with specific properties.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Labels.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font.Shadow
			// 
			this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title.Shadow
			// 
			this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Labels.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Title
			// 
			// 
			// tChart1.Axes.Depth.Title.Font
			// 
			// 
			// tChart1.Axes.Depth.Title.Font.Shadow
			// 
			this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Title.Shadow
			// 
			this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop
			// 
			// 
			// tChart1.Axes.DepthTop.Labels
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Font
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Font.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Labels.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Title
			// 
			// 
			// tChart1.Axes.DepthTop.Title.Font
			// 
			// 
			// tChart1.Axes.DepthTop.Title.Font.Shadow
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Title.Shadow
			// 
			this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			// 
			// tChart1.Axes.Left.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Labels.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
			this.tChart1.Axes.Left.LogarithmicBase = 2;
			// 
			// tChart1.Axes.Left.Title
			// 
			// 
			// tChart1.Axes.Left.Title.Font
			// 
			// 
			// tChart1.Axes.Left.Title.Font.Shadow
			// 
			this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Title.Shadow
			// 
			this.tChart1.Axes.Left.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			// 
			// tChart1.Axes.Right.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Labels.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Title
			// 
			// 
			// tChart1.Axes.Right.Title.Font
			// 
			// 
			// tChart1.Axes.Right.Title.Font.Shadow
			// 
			this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Title.Shadow
			// 
			this.tChart1.Axes.Right.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			// 
			// tChart1.Axes.Top.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Labels.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Title
			// 
			// 
			// tChart1.Axes.Top.Title.Font
			// 
			// 
			// tChart1.Axes.Top.Title.Font.Shadow
			// 
			this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Title.Shadow
			// 
			this.tChart1.Axes.Top.Title.Shadow.Visible = false;
			this.tChart1.BackColor = System.Drawing.Color.Gray;
			// 
			// tChart1.Footer
			// 
			// 
			// tChart1.Footer.Font
			// 
			// 
			// tChart1.Footer.Font.Shadow
			// 
			this.tChart1.Footer.Font.Shadow.Visible = false;
			// 
			// tChart1.Footer.Shadow
			// 
			this.tChart1.Footer.Shadow.Visible = false;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Header.Font.Shadow
			// 
			this.tChart1.Header.Font.Shadow.Visible = false;
			this.tChart1.Header.Font.Size = 7;
			this.tChart1.Header.Lines = new string[] {
																								 "Wind rose series"};
			// 
			// tChart1.Header.Shadow
			// 
			this.tChart1.Header.Shadow.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Shadow
			// 
			this.tChart1.Legend.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Title
			// 
			// 
			// tChart1.Legend.Title.Font
			// 
			this.tChart1.Legend.Title.Font.Bold = true;
			// 
			// tChart1.Legend.Title.Font.Shadow
			// 
			this.tChart1.Legend.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Title.Pen
			// 
			this.tChart1.Legend.Title.Pen.Visible = false;
			// 
			// tChart1.Legend.Title.Shadow
			// 
			this.tChart1.Legend.Title.Shadow.Visible = false;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Visible = false;
			this.tChart1.Series.Add(this.windRose1);
			this.tChart1.Series.Add(this.windRose2);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			// 
			// tChart1.SubFooter
			// 
			// 
			// tChart1.SubFooter.Font
			// 
			// 
			// tChart1.SubFooter.Font.Shadow
			// 
			this.tChart1.SubFooter.Font.Shadow.Visible = false;
			// 
			// tChart1.SubFooter.Shadow
			// 
			this.tChart1.SubFooter.Shadow.Visible = false;
			// 
			// tChart1.SubHeader
			// 
			// 
			// tChart1.SubHeader.Font
			// 
			// 
			// tChart1.SubHeader.Font.Shadow
			// 
			this.tChart1.SubHeader.Font.Shadow.Visible = false;
			// 
			// tChart1.SubHeader.Shadow
			// 
			this.tChart1.SubHeader.Shadow.Visible = false;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Shadow
			// 
			this.tChart1.Walls.Back.Shadow.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Shadow
			// 
			this.tChart1.Walls.Bottom.Shadow.Visible = false;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Shadow
			// 
			this.tChart1.Walls.Left.Shadow.Visible = false;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Shadow
			// 
			this.tChart1.Walls.Right.Shadow.Visible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(47, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Axes";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(73, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(67, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Circled";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(160, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "&Labels :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "15",
																									 "30",
																									 "45",
																									 "90"});
			this.comboBox1.Location = new System.Drawing.Point(207, 7);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(333, 6);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// windRose1
			// 
			// 
			// windRose1.Brush
			// 
			this.windRose1.Brush.Color = System.Drawing.Color.Red;
			this.windRose1.Circled = true;
			this.windRose1.CircleLabels = true;
			// 
			// windRose1.CircleLabelsFont
			// 
			// 
			// windRose1.CircleLabelsFont.Shadow
			// 
			this.windRose1.CircleLabelsFont.Shadow.Visible = false;
			// 
			// windRose1.Font
			// 
			// 
			// windRose1.Font.Shadow
			// 
			this.windRose1.Font.Shadow.Visible = false;
			// 
			// windRose1.Marks
			// 
			// 
			// windRose1.Marks.Callout
			// 
			this.windRose1.Marks.Callout.Arrow = this.windRose1.Marks.Arrow;
			this.windRose1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.windRose1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// windRose1.Marks.Callout.Brush
			// 
			this.windRose1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.windRose1.Marks.Callout.Distance = 0;
			this.windRose1.Marks.Callout.Draw3D = false;
			this.windRose1.Marks.Callout.Length = 10;
			this.windRose1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// windRose1.Marks.Font
			// 
			// 
			// windRose1.Marks.Font.Shadow
			// 
			this.windRose1.Marks.Font.Shadow.Visible = false;
			// 
			// windRose1.Pen
			// 
			this.windRose1.Pen.Color = System.Drawing.Color.Red;
			// 
			// windRose1.Pointer
			// 
			this.windRose1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.windRose1.Pointer.Visible = true;
			this.windRose1.RotationAngle = 90;
			this.windRose1.Title = "windRose1";
			// 
			// windRose1.XValues
			// 
			this.windRose1.XValues.DataMember = "Angle";
			this.windRose1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// windRose1.YValues
			// 
			this.windRose1.YValues.DataMember = "Y";
			// 
			// windRose2
			// 
			// 
			// windRose2.Brush
			// 
			this.windRose2.Brush.Color = System.Drawing.Color.Green;
			this.windRose2.Circled = true;
			this.windRose2.CircleLabels = true;
			// 
			// windRose2.CircleLabelsFont
			// 
			// 
			// windRose2.CircleLabelsFont.Shadow
			// 
			this.windRose2.CircleLabelsFont.Shadow.Visible = false;
			// 
			// windRose2.Font
			// 
			// 
			// windRose2.Font.Shadow
			// 
			this.windRose2.Font.Shadow.Visible = false;
			// 
			// windRose2.Marks
			// 
			// 
			// windRose2.Marks.Callout
			// 
			this.windRose2.Marks.Callout.Arrow = this.windRose2.Marks.Arrow;
			this.windRose2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.windRose2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// windRose2.Marks.Callout.Brush
			// 
			this.windRose2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.windRose2.Marks.Callout.Distance = 0;
			this.windRose2.Marks.Callout.Draw3D = false;
			this.windRose2.Marks.Callout.Length = 10;
			this.windRose2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// windRose2.Marks.Font
			// 
			// 
			// windRose2.Marks.Font.Shadow
			// 
			this.windRose2.Marks.Font.Shadow.Visible = false;
			// 
			// windRose2.Pen
			// 
			this.windRose2.Pen.Color = System.Drawing.Color.Green;
			// 
			// windRose2.Pointer
			// 
			this.windRose2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.windRose2.Pointer.Visible = true;
			this.windRose2.RotationAngle = 90;
			this.windRose2.Title = "windRose2";
			// 
			// windRose2.XValues
			// 
			this.windRose2.XValues.DataMember = "Angle";
			this.windRose2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// windRose2.YValues
			// 
			this.windRose2.YValues.DataMember = "Y";
			// 
			// WindRose_Series
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "WindRose_Series";
			this.Load += new System.EventHandler(this.SeriesType_WindRose_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Axes.Visible = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			windRose1.Circled = checkBox2.Checked;
			windRose2.Circled = checkBox2.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(windRose1);
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : windRose1.AngleIncrement =15; break;
				case 1 : windRose1.AngleIncrement =30; break;
				case 2 : windRose1.AngleIncrement =45; break;
				case 3 : windRose1.AngleIncrement =90; break;
			}
		}

		private void SeriesType_WindRose_Load(object sender, System.EventArgs e)
		{
			//this.comboBox1.SelectedIndex = 1;
		}
	}
}

