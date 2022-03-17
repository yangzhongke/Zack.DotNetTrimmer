using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_WindRose : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.WindRose windRoseSeries1;
		private Steema.TeeChart.Styles.WindRose windRoseSeries2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_WindRose()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			this.windRoseSeries1.Clear();
			this.windRoseSeries1.Add(30,100);
			this.windRoseSeries1.Add(60, 200);
			this.windRoseSeries1.Add(90,  50);
			this.windRoseSeries1.Add(120, 150);

			this.windRoseSeries1.Clear();
			this.windRoseSeries2.Add(130, 100);
			this.windRoseSeries2.Add(160, 200);
			this.windRoseSeries2.Add(190,  50);
			this.windRoseSeries2.Add(220, 150);

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
			this.windRoseSeries1 = new Steema.TeeChart.Styles.WindRose();
			this.windRoseSeries2 = new Steema.TeeChart.Styles.WindRose();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
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
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
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
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.LogarithmicBase = 2;
			this.tChart1.BackColor = System.Drawing.Color.Gray;
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
			this.tChart1.Header.Font.Size = 7;
			this.tChart1.Header.Lines = new string[] {
																								 "Wind rose series"};
			// 
			// tChart1.Legend
			// 
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
			this.tChart1.Series.Add(this.windRoseSeries1);
			this.tChart1.Series.Add(this.windRoseSeries2);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			// 
			// windRoseSeries1
			// 
			// 
			// windRoseSeries1.Brush
			// 
			this.windRoseSeries1.Brush.Color = System.Drawing.Color.Red;
			this.windRoseSeries1.CircleLabels = true;
			// 
			// windRoseSeries1.Marks
			// 
			// 
			// windRoseSeries1.Marks.Symbol
			// 
			// 
			// windRoseSeries1.Marks.Symbol.Shadow
			// 
			this.windRoseSeries1.Marks.Symbol.Shadow.Height = 1;
			this.windRoseSeries1.Marks.Symbol.Shadow.Visible = true;
			this.windRoseSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// windRoseSeries1.Pen
			// 
			this.windRoseSeries1.Pen.Color = System.Drawing.Color.Red;
			// 
			// windRoseSeries1.Pointer
			// 
			// 
			// windRoseSeries1.Pointer.Brush
			// 
			this.windRoseSeries1.Pointer.Brush.Color = System.Drawing.Color.Blue;
			this.windRoseSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.windRoseSeries1.RotationAngle = 90;
			this.windRoseSeries1.Title = "windRoseSeries1";
			// 
			// windRoseSeries1.XValues
			// 
			this.windRoseSeries1.XValues.DataMember = "Angle";
			this.windRoseSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// windRoseSeries1.YValues
			// 
			this.windRoseSeries1.YValues.DataMember = "Y";
			// 
			// windRoseSeries2
			// 
			// 
			// windRoseSeries2.Brush
			// 
			this.windRoseSeries2.Brush.Color = System.Drawing.Color.Green;
			this.windRoseSeries2.CircleLabels = true;
			// 
			// windRoseSeries2.Marks
			// 
			// 
			// windRoseSeries2.Marks.Symbol
			// 
			// 
			// windRoseSeries2.Marks.Symbol.Shadow
			// 
			this.windRoseSeries2.Marks.Symbol.Shadow.Height = 1;
			this.windRoseSeries2.Marks.Symbol.Shadow.Visible = true;
			this.windRoseSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// windRoseSeries2.Pen
			// 
			this.windRoseSeries2.Pen.Color = System.Drawing.Color.Green;
			// 
			// windRoseSeries2.Pointer
			// 
			// 
			// windRoseSeries2.Pointer.Brush
			// 
			this.windRoseSeries2.Pointer.Brush.Color = System.Drawing.Color.Green;
			this.windRoseSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle;
			this.windRoseSeries2.RotationAngle = 90;
			this.windRoseSeries2.Title = "windRoseSeries2";
			// 
			// windRoseSeries2.XValues
			// 
			this.windRoseSeries2.XValues.DataMember = "Angle";
			this.windRoseSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// windRoseSeries2.YValues
			// 
			this.windRoseSeries2.YValues.DataMember = "Y";
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
			// SeriesType_WindRose
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_WindRose";
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
			this.windRoseSeries1.Circled = checkBox2.Checked;
			this.windRoseSeries2.Circled = checkBox2.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.windRoseSeries1);
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : this.windRoseSeries1.AngleIncrement =15; break;
				case 1 : this.windRoseSeries1.AngleIncrement =30; break;
				case 2 : this.windRoseSeries1.AngleIncrement =45; break;
				case 3 : this.windRoseSeries1.AngleIncrement =90; break;
			}
		}

		private void SeriesType_WindRose_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 1;
		}
	}
}

