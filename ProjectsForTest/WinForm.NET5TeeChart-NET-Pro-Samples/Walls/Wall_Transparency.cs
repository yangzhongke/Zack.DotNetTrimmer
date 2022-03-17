using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Wall_Transparency : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Surface surface1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;

		public Wall_Transparency()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			for(int x=-10; x<=10; ++x)
				for(int z=-10; z<=10; ++z)
					surface1.Add(x,Calc(x,z),z);
		}

		private double Calc(double x,double y){
			const double a=3.0, b=10.0, c=5.0, d=1.0;

			x=x/3.0;
			y=y/3.0;
			double result=a*Math.Pow(d-x, 2)*Math.Exp(-(x*x)-Math.Pow(y+d,2))
														-b*(x/c-(x*x*x)-(y*y*y*y*y))*Math.Exp(-Math.Pow(x,2)-Math.Pow(y,2))
														-(d/a)*Math.Exp(-Math.Pow(x+d,2)-Math.Pow(y,2));
			return result;
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
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.surface1 = new Steema.TeeChart.Styles.Surface();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The four chart walls now support transparency, even with gradient filling.\r\n\r\ntCh" +
				"art1.Walls.Left.Transparency = 70;    // % of transparency";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 50;
			this.tChart1.Aspect.Elevation = 338;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 100;
			this.tChart1.Aspect.Rotation = 331;
			this.tChart1.Aspect.Zoom = 79;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(229)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Header.Brush.Gradient
			// 
			this.tChart1.Header.Brush.Gradient.Transparency = 10;
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Header.Font.Size = 12;
			this.tChart1.Header.Lines = new string[] {
																								 "Walls Transparency"};
			this.tChart1.Header.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
			this.tChart1.Header.Transparent = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Brush.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Brush.Gradient.Visible = true;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			// 
			// tChart1.Panel.Brush.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			this.tChart1.Series.Add(this.surface1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Back.Brush.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 50;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Brush.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Left.Brush.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Right.Brush.Gradient
			// 
			this.tChart1.Walls.Right.Brush.Gradient.Transparency = 50;
			this.tChart1.Walls.Right.Visible = true;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(97, 14);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(175, 17);
			this.hScrollBar1.TabIndex = 0;
			this.hScrollBar1.Value = 50;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Transparency:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(341, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// surface1
			// 
			// 
			// surface1.Brush
			// 
			this.surface1.Brush.Color = System.Drawing.Color.Red;
			this.surface1.PaletteMin = 0;
			this.surface1.PaletteStep = 0;
			this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong;
			this.surface1.Title = "surface1";
			this.surface1.UseColorRange = false;
			this.surface1.UsePalette = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(283, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 3;
			// 
			// Walls_Transparency
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Walls_Transparency";
			this.panel1.ResumeLayout(false);

		}
		#endregion

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
			// Set transparency to all walls
			tChart1.Walls.Left.Transparency=hScrollBar1.Value;
			tChart1.Walls.Right.Transparency=hScrollBar1.Value;
			tChart1.Walls.Bottom.Transparency=hScrollBar1.Value;
			tChart1.Walls.Back.Transparency=hScrollBar1.Value;

			label2.Text=hScrollBar1.Value.ToString();
		}

		private void button1_Click(object sender, System.EventArgs e) {
			tChart1.ShowEditor();
		}

		
	}
}

