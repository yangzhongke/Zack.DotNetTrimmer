using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Pie : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Pie pie1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Pie()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			pie1.Shadow.Width = 40;
			pie1.Shadow.Height = 40;
			pie1.FillSampleValues(6);
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
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pie1 = new Steema.TeeChart.Styles.Pie();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 56);
			this.textBox1.Text = "Pie series draw values as portions (slices) of a full solid circle.\r\nSlices can b" +
				"e \"exploded\" and grouped if they are very small.\r\nOther options include formatti" +
				"ng, shadow, marks and semi-pie styles.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox5);
			this.panel1.Controls.Add(this.checkBox4);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 40);
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
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.Transparency = 50;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pie1);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(40, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&3D";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(53, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(75, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Exploded";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(127, 8);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(53, 21);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "&Marks";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(187, 8);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(61, 21);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "&Shadow";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkBox5
			// 
			this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox5.Location = new System.Drawing.Point(253, 8);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(54, 21);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "&Partial";
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(392, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 24);
			this.button1.TabIndex = 6;
			this.button1.Text = "&Edit";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pie1
			// 
			// 
			// pie1.Brush
			// 
			this.pie1.Brush.Color = System.Drawing.Color.Red;
			this.pie1.LabelMember = "Labels";
			// 
			// pie1.Marks
			// 
			// 
			// pie1.Marks.Symbol
			// 
			// 
			// pie1.Marks.Symbol.Shadow
			// 
			this.pie1.Marks.Symbol.Shadow.Height = 1;
			this.pie1.Marks.Symbol.Shadow.Visible = true;
			this.pie1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pie1.Pen
			// 
			this.pie1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pie1.Shadow
			// 
			this.pie1.Shadow.Height = 20;
			this.pie1.Shadow.Width = 20;
			this.pie1.Title = "pie1";
			// 
			// pie1.XValues
			// 
			this.pie1.XValues.DataMember = "Angle";
			this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pie1.YValues
			// 
			this.pie1.YValues.DataMember = "Pie";
			// 
			// SeriesType_Pie
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Pie";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
						TeeChart.Editors.SeriesEditor.ShowEditor(this.pie1);
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox2.Checked) pie1.ExplodeBiggest = 30;
			else pie1.ExplodeBiggest = 0;

		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			  pie1.Marks.Visible = checkBox3.Checked;
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			pie1.Shadow.Visible = checkBox4.Checked;
		}

		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox5.Checked)
			{
				pie1.AngleSize =180;
				checkBox4.Checked = false;
				this.checkBox4_CheckedChanged(checkBox4,new System.EventArgs());
			}
			else pie1.AngleSize = 360;
		}
	}
}

