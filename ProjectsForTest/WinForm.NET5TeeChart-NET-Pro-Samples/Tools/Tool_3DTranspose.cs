using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_3DTranspose : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Surface surfaceSeries1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.GridTranspose gridTranspose1;
		private Steema.TeeChart.Tools.Rotate rotate1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Tool_3DTranspose()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// add sample values		
			double y;
			for (int x=0; x<20; x++)
				for (int z=0; z<30; z++)
				{
					y= 0.5*Math.Pow(Math.Cos(x*0.25),2)+
						Math.Pow(Math.Cos(z/15.0),2)-
						Math.Cos(z/15.0);
					this.surfaceSeries1.Add(x,y,z);
				}
			// setup chart properties
			this.tChart1.Axes.Depth.Visible = true;
			this.tChart1.Legend.Visible = false;
			this.surfaceSeries1.UseColorRange = false;
			this.surfaceSeries1.UsePalette = true;
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
			this.surfaceSeries1 = new Steema.TeeChart.Styles.Surface();
			this.button1 = new System.Windows.Forms.Button();
			this.gridTranspose1 = new Steema.TeeChart.Tools.GridTranspose();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(432, 63);
			this.textBox1.Text = "3D Transpose tool \"rotates\" a 3D series 90 degrees. It will exchange x with z val" +
				"ues.  Works with any Grid3D series (surface, etc).\r\nA similar effect can be obta" +
				"ined setting the Bottom and Depth axes Inverted property to true.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 50;
			this.tChart1.Aspect.Elevation = 339;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 100;
			this.tChart1.Aspect.Rotation = 324;
			
			
			this.tChart1.Aspect.Zoom = 66;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.surfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(432, 213);
			this.tChart1.Tools.Add(this.gridTranspose1);
			this.tChart1.Tools.Add(this.rotate1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 40;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// surfaceSeries1
			// 
			// 
			// surfaceSeries1.Brush
			// 
			this.surfaceSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// surfaceSeries1.Marks
			// 
			// 
			// surfaceSeries1.Marks.Symbol
			// 
			// 
			// surfaceSeries1.Marks.Symbol.Shadow
			// 
			this.surfaceSeries1.Marks.Symbol.Shadow.Height = 1;
			this.surfaceSeries1.Marks.Symbol.Shadow.Visible = true;
			this.surfaceSeries1.Marks.Symbol.Shadow.Width = 1;
			this.surfaceSeries1.MidColor = System.Drawing.Color.FromArgb(((System.Byte)(204)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.surfaceSeries1.NumXValues = 25;
			this.surfaceSeries1.NumZValues = 25;
			this.surfaceSeries1.PaletteMin = 0;
			this.surfaceSeries1.PaletteStep = 0;
			this.surfaceSeries1.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.surfaceSeries1.Title = "surfaceSeries1";
			// 
			// surfaceSeries1.XValues
			// 
			this.surfaceSeries1.XValues.DataMember = "X";
			// 
			// surfaceSeries1.YValues
			// 
			this.surfaceSeries1.YValues.DataMember = "Y";
			// 
			// surfaceSeries1.ZValues
			// 
			this.surfaceSeries1.ZValues.DataMember = "Z";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(14, 6);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Transpose";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridTranspose1
			// 
			this.gridTranspose1.Series = this.surfaceSeries1;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(114, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(86, 21);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "&Rotate tool";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Tool_3DTranspose
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 317);
			this.Name = "Tool_3DTranspose";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.gridTranspose1.Transpose();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.rotate1.Active = this.checkBox1.Checked;
		}
	}
}

