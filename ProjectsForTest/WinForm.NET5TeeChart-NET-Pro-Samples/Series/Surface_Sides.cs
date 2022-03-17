using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Surface_Sides : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.Surface surface1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Button button1;
    private Steema.TeeChart.Tools.Rotate rotate1;
		private System.ComponentModel.IContainer components = null;

		public Surface_Sides()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

		  surface1.FillSampleValues(12);
      surface1.SideBrush.Style = Drawing.HatchStyle.DiagonalCross;
			surface1.SideBrush.Color = Color.FromArgb(217, 217, 255);
			surface1.SideBrush.ForegroundColor = Color.FromArgb(149, 149, 255);
      surface1.SideBrush.Visible = true;

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
			this.surface1 = new Steema.TeeChart.Styles.Surface();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Surface series can now display \"sides\", using the SideBrush property.\r\nExample: \r" +
				"\nsurface1.SideBrush.Visible = true;\r\nsurface1.SideBrush.Color = Color.Blue;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 100;
			this.tChart1.Aspect.Elevation = 348;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 330;
			
			
			this.tChart1.Aspect.Zoom = 63;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.surface1);
			this.tChart1.Tools.Add(this.rotate1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			this.tChart1.Walls.Back.Size = 5;
			this.tChart1.Walls.Back.Transparent = false;
			this.tChart1.Walls.Back.Visible = false;
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
			// surface1
			// 
			// 
			// surface1.Brush
			// 
			this.surface1.Brush.Color = System.Drawing.Color.Red;
			// 
			// surface1.Marks
			// 
			// 
			// surface1.Marks.Symbol
			// 
			// 
			// surface1.Marks.Symbol.Shadow
			// 
			this.surface1.Marks.Symbol.Shadow.Height = 1;
			this.surface1.Marks.Symbol.Shadow.Visible = true;
			this.surface1.Marks.Symbol.Shadow.Width = 1;
			this.surface1.PaletteMin = 0;
			this.surface1.PaletteStep = 0;
			this.surface1.Title = "surface1";
			// 
			// surface1.XValues
			// 
			this.surface1.XValues.DataMember = "X";
			// 
			// surface1.YValues
			// 
			this.surface1.YValues.DataMember = "Y";
			// 
			// surface1.ZValues
			// 
			this.surface1.ZValues.DataMember = "Z";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Sides visible";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(136, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Edit side brush";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Surface_Sides
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Surface_Sides";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      surface1.SideBrush.Visible = checkBox1.Checked;
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      Steema.TeeChart.Editors.BrushEditor br = new Steema.TeeChart.Editors.BrushEditor(surface1.SideBrush);
      try
      {
        br.ShowDialog();
      }
      finally
      {
        br.Dispose();
      }
    }
	}
}

