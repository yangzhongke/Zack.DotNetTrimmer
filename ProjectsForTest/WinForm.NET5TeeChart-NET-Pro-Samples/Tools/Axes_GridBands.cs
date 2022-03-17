using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Axes_GridBands : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Axes_GridBands()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			line1.FillSampleValues();

			// TODO: Add any initialization after the InitializeComponent call
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
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The GridBand tool enables filling axis grid space with alternate color bands, eac" +
				"h one using a different brush.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Axes.Left.Grid.Visible = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Axes Grid Bands"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Brush
			// 
			this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.Blue;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Raised;
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Lowered;
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.line1);
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
			this.tChart1.Walls.Bottom.Size = 4;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 4;
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(114)), ((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// line1.Gradient
			// 
			this.line1.Brush.Gradient.Transparency = 55;
			// 
			// line1.Gradient
			// 
			this.line1.Gradient.Transparency = 55;
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
			// 
			// line1.Pointer.Brush
			// 
			this.line1.Pointer.Brush.Color = System.Drawing.Color.Red;
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
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
			this.gridBand1.Band1.ForegroundColor = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.gridBand1.Band2.ForegroundColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(24, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Band 1...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(120, 8);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "Band 2...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(241, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "View 3D";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// Tool_GridBand
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Tool_GridBand";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.BrushEditor.Edit(gridBand1.Band1,true);
			tChart1.Invalidate();
		}

		private void button2_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.BrushEditor.Edit(gridBand1.Band2,true);
			tChart1.Invalidate();
		}

		private void checkBox1_Click(object sender, System.EventArgs e) {
			tChart1.Aspect.View3D = checkBox1.Checked;
		}
	}
}

