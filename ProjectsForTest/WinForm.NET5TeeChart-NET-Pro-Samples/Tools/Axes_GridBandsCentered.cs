using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Axes_GridBandsCentered: Steema.TeeChart.Samples.BaseForm
	{
        private Steema.TeeChart.Styles.HorizBar horizBar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox checkBox1;
        private CheckBox checkBox2;
        private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

        public Axes_GridBandsCentered()
		{
			// This call is required by the Windows Form Designer.
            horizBar1 = new Steema.TeeChart.Styles.HorizBar();
			InitializeComponent();
            tChart1.Series.Add(horizBar1);
            horizBar1.FillSampleValues();
            horizBar1.BarHeightPercent = 55;
            horizBar1.Gradient.Visible = true;
            horizBar1.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
            horizBar1.Marks.Transparent = true;
            horizBar1.MarksOnBar = true;
            horizBar1.Pen.Visible = false;
            tChart1.Axes.Left.Grid.Centered = true;

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Grid bands will be centered if CenteredGrid property is set to True for the Axis." +
                "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
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
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Left.Grid.Visible = false;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "Axes Grid Bands Centered"};
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.Blue;
            this.tChart1.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Raised;
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            this.tChart1.Tools.Add(this.gridBand1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Visible = false;
            this.tChart1.Walls.Bottom.Size = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(24, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Band 1...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(120, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Band 2...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(202, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "View 3D";
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(287, 9);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Axes Left grid centered";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // Axes_GridBandsCentered
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Axes_GridBandsCentered";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tChart1.Axes.Left.Grid.Centered = checkBox2.Checked;
        }
	}
}

