using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
	public class Map_Series : Steema.TeeChart.Samples.BaseForm {
		private Steema.TeeChart.Styles.Map map1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Panel panel2;
		private System.ComponentModel.IContainer components = null;

		private Random rnd = new Random();
		private Color[] Colors;

		public Map_Series() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

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
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Series));
			this.map1 = new Steema.TeeChart.Styles.Map();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "Map Series is a collection of polygon shapes. Each shape has\r\nformatting attribut" +
					"es and a Value. The shape color lookups the\r\ncolor palette for the Value.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
			this.tChart1.Axes.Bottom.MaximumOffset = 1;
			this.tChart1.Axes.Bottom.MinimumOffset = 1;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
			this.tChart1.Axes.Left.MaximumOffset = 1;
			this.tChart1.Axes.Left.MinimumOffset = 2;
			// 
			// 
			// 
			this.tChart1.Header.Visible = false;
			// 
			// 
			// 
			this.tChart1.Legend.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Series.Add(this.map1);
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 50;
			this.tChart1.Walls.Back.Brush.Gradient.UseMiddle = true;
			this.tChart1.MouseMove += this.tChart1_MouseMove;
			// 
			// map1
			// 
			// 
			// 
			// 
			this.map1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(168)))));
			this.map1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.map1.ColorEach = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.map1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.map1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.map1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.map1.Marks.Callout.Distance = 0;
			this.map1.Marks.Callout.Draw3D = false;
			this.map1.Marks.Callout.Length = 10;
			this.map1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.map1.Marks.Callout.Visible = false;
			this.map1.PaletteMin = 0;
			this.map1.PaletteStep = 0;
			this.map1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
			this.map1.Title = "map1";
			// 
			// 
			// 
			this.map1.ZValues.DataMember = "Z";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(111, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(57, 24);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "&Axes";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(185, 10);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(57, 24);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "&Marks";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(264, 10);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(60, 24);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "&Palette";
			this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(344, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(32, 24);
			this.panel2.TabIndex = 4;
			// 
			// Map_Series
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Map_Series";
			this.Load += new System.EventHandler(this.Map_Load);
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
		
		}

		private void Map_Load(object sender, System.EventArgs e) {
			map1.Clear();
			AddSampleShapes();
			map1.Marks.Visible=true;
			map1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
			map1.Color = Color.Silver;			
		}

		private void AddSampleShapes() {
			int[] AX = new int[] {1,3,4,4,5,5,6,6,4,3,2,1,2,2};
			int[] AY = new int[] {7,5,5,7,8,9,10,11,11,12,12,11,10,8};
			int[] BX = new int[] {5,7,8,8,7,6,5,4,4};
			int[] BY = new int[] {4,4,5,6,7,7,8,7,5};
			int[] CX = new int[] {9,10,11,11,12,9,8,7,6,6,5,5,6,7,8,8};
			int[] CY = new int[] {5,6,6,7,8,11,11,12,11,10,9,8,7,7,6,5};
			int[] DX = new int[] {12,14,15,14,13,12,11,11};
			int[] DY = new int[] {5,5,6,7,7,8,7,6};
			int[] EX = new int[] {4,6,7,7,6,6,5,4,3,3,2};
			int[] EY = new int[] {11,11,12,13,14,15,16,16,15,14,13};
			int[] FX = new int[] {7,8,9,11,10,8,7,6,5,5,6,6};
			int[] FY = new int[] {13,14,14,16,17,17,18,18,17,16,15,14};
			int[] GX = new int[] {10,12,12,14,13,11,9,8,7,7,8,9};
			int[] GY = new int[] {10,12,13,15,16,16,14,14,13,12,11,11};
			int[] HX = new int[] {17,19,18,18,17,15,14,13,15,16};
			int[] HY = new int[] {11,13,14,16,17,15,15,14,12,12};
			int[] IX = new int[] {15,16,17,16,15,14,14,13,12,11,10,11,12,13,14};
			int[] IY = new int[] {6,6,7,8,8,9,10,11,12,11,10,9,8,7,7};
			int[] JX = new int[] {15,16,16,17,17,16,15,13,12,12,14,14};
			int[] JY = new int[] {8,8,9,10,11,12,12,14,13,12,10,9};
			int[] KX = new int[] {17,19,20,20,19,17,16,16,17,16};
			int[] KY = new int[] {5,5,6,8,8,10,9,8,7,6};
			int[] LX = new int[] {19,20,21,21,19,17,17};
			int[] LY = new int[] {8,8,9,11,13,11,10};

			Colors = new Color[] {
				Color.Lime,
				Color.Red,
				Color.Fuchsia,
				Color.Aqua,
				Color.Silver,
				Color.Aqua,
				Color.Green,
				Color.Teal,
				Color.White,
				Color.Red,
				Color.Blue,
				Color.Yellow
			};

			
			AddShape(AX,AY,Colors[0], "A");
			AddShape(BX,BY,Colors[1], "B");
			AddShape(CX,CY,Colors[2],	"C");
			AddShape(DX,DY,Colors[3], "D");
			AddShape(EX,EY,Colors[4], "E");
			AddShape(FX,FY,Colors[5], "F");
			AddShape(GX,GY,Colors[6], "G");
			AddShape(HX,HY,Colors[7], "H");
			AddShape(IX,IY,Colors[8], "I");
			AddShape(JX,JY,Colors[9], "J");
			AddShape(KX,KY,Colors[10], "K");
			AddShape(LX,LY,Colors[11], "L");
			
		}

		private void AddShape(int[] X, int[] Y, Color AColor, string Text) {
			Polygon toAdd = new Polygon(map1.Shapes, tChart1.Chart);

			for(int t=X.GetLowerBound(0); t <= X.GetUpperBound(0); ++t) {
				toAdd.Add(X[t],Y[t]);
			}

			int i = map1.Shapes.Add(toAdd);	
			map1.Shapes[i].ParentBrush=false;
			map1.Shapes[i].Text = Text;
			map1.Shapes[i].Color = AColor;
            map1.Shapes[i].Brush.Color = AColor;
			map1.Shapes[i].Z	= rnd.Next(1000) / 1000.0;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.SeriesEditor.ShowModal(map1);
		}

		private void checkBox1_Click(object sender, System.EventArgs e) {
			for(int a=0; a < tChart1.Axes.Count; ++a)
				tChart1.Axes[a].Visible = checkBox1.Checked;
		}

		private void checkBox2_Click(object sender, System.EventArgs e) {
			map1.Marks.Visible = checkBox2.Checked;
		}

		private void checkBox3_Click(object sender, System.EventArgs e) {
			if(checkBox3.Checked) {
				map1.UseColorRange=false;
				map1.UsePalette=true;
				for(int i=0; i<map1.Shapes.Count; ++i)
					map1.Shapes[i].ParentBrush=true;

			}
			else {
				map1.UseColorRange=false;
				map1.UsePalette=false;
				for(int i=0; i<map1.Shapes.Count; ++i)	{
					map1.Shapes[i].ParentBrush=false;
					map1.Shapes[i].Color = Colors[i];
                    map1.Shapes[i].Brush.Color = Colors[i];

				}
			}
			map1.Invalidate();
		}

		private void tChart1_MouseMove(object sender, MouseEventArgs e) {
			int tmp = map1.Clicked(e.X, e.Y);
			if(tmp==-1) panel2.Visible=false;
			else {
				panel2.Visible=true;
				panel2.BackColor = map1.Shapes[tmp].Points.Color;
			}
		}

		private void map1_Click(object sender, Drawing.MouseEventArgs e) {
			MessageBox.Show("Shape: "+map1.Labels[ map1.Clicked(e.X, e.Y)]+ "  Value: "+map1.ZValues[ map1.Clicked(e.X, e.Y)].ToString());
			tChart1.Chart.CancelMouse=true;
		}

	}
}

