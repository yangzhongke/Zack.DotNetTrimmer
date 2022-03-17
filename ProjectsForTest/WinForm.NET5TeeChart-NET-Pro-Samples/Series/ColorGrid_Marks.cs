using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ColorGrid_Marks : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.ColorGrid colorGrid1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.ComponentModel.IContainer components = null;

		public ColorGrid_Marks()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			colorGrid1.FillSampleValues(5);
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
			this.colorGrid1 = new Steema.TeeChart.Styles.ColorGrid();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "ColorGrid series can now display Marks. \r\n\r\ncolorGrid1.Marks.Visible = true; ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.colorGrid1);
			// 
			// colorGrid1
			// 
			// 
			// colorGrid1.Brush
			// 
			this.colorGrid1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.colorGrid1.CenteredPoints = true;
			// 
			// colorGrid1.Marks
			// 
			this.colorGrid1.Marks.ArrowLength = 0;
			// 
			// colorGrid1.Marks.Symbol
			// 
			// 
			// colorGrid1.Marks.Symbol.Shadow
			// 
			this.colorGrid1.Marks.Symbol.Shadow.Height = 1;
			this.colorGrid1.Marks.Symbol.Shadow.Visible = true;
			this.colorGrid1.Marks.Symbol.Shadow.Width = 1;
			this.colorGrid1.Marks.Visible = true;
			this.colorGrid1.PaletteMin = 0;
			this.colorGrid1.PaletteStep = 0;
			this.colorGrid1.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(206)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.colorGrid1.Title = "colorGrid1";
			// 
			// colorGrid1.XValues
			// 
			this.colorGrid1.XValues.DataMember = "X";
			// 
			// colorGrid1.YValues
			// 
			this.colorGrid1.YValues.DataMember = "Y";
			// 
			// colorGrid1.ZValues
			// 
			this.colorGrid1.ZValues.DataMember = "Z";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "View Marks";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(144, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(76, 25);
			this.button1.TabIndex = 1;
			this.button1.Text = "Edit Marks...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(288, 13);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 19);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Centered Points";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// ColorGrid_Marks
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "ColorGrid_Marks";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e) {
			colorGrid1.Marks.Visible = checkBox1.Checked;
		}

		private void checkBox2_Click(object sender, System.EventArgs e) {
			colorGrid1.CenteredPoints = checkBox2.Checked;
		
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.SeriesMarksEditor marksEditor = new Steema.TeeChart.Editors.SeriesMarksEditor(colorGrid1.Marks, null);
      Steema.TeeChart.Editors.EditorUtils.Translate(marksEditor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(marksEditor);
		}
	}
}

