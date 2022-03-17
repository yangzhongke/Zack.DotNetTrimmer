using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class LegendSymbolFlags : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.ButtonPen buttonPen1;
		private Steema.TeeChart.Styles.Pie pie1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components = null;

		public LegendSymbolFlags()
		{
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
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegendSymbolFlags));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonPen1 = new Steema.TeeChart.ButtonPen();
            this.pie1 = new Steema.TeeChart.Styles.Pie();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "The Legend.Symbol \"OnSymbolDraw\" event can be used to customize the display\r\nof l" +
                "egend symbols, for example to show country flags like this example.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPen1);
            this.panel1.Controls.Add(this.checkBox1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Elevation = 315;
            this.tChart1.Aspect.ElevationFloat = 315;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 0;
            this.tChart1.Aspect.Rotation = 360;
            this.tChart1.Aspect.RotationFloat = 360;
            this.tChart1.Aspect.ThemeIndex = 4;
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
            this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Bold = true;
            this.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console";
            this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.MinorTicks.Length = -3;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.Ticks.Length = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.TicksInner.Length = 6;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Name = "Lucida Console";
            this.tChart1.Axes.Depth.Labels.Font.Size = 10;
            this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.MinorTicks.Length = -3;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.Ticks.Length = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.TicksInner.Length = 6;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Bold = true;
            this.tChart1.Axes.Left.Labels.Font.Name = "Lucida Console";
            this.tChart1.Axes.Left.Labels.Font.Size = 10;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.MinorTicks.Length = -3;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.Ticks.Length = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.TicksInner.Length = 6;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Name = "Lucida Console";
            this.tChart1.Axes.Right.Labels.Font.Size = 10;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.MinorTicks.Length = -3;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.Ticks.Length = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.TicksInner.Length = 6;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
            this.tChart1.Axes.Top.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Name = "Lucida Console";
            this.tChart1.Axes.Top.Labels.Font.Size = 10;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.MinorTicks.Length = -3;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.Ticks.Length = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.TicksInner.Length = 6;
            this.tChart1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Gray;
            this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.White;
            this.tChart1.Header.Brush.Gradient.Visible = true;
            // 
            // 
            // 
            this.tChart1.Header.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart1.Header.Font.Name = "Lucida Console";
            this.tChart1.Header.Font.Size = 10;
            this.tChart1.Header.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Header.Pen.Width = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Shadow.Height = 4;
            this.tChart1.Header.Shadow.Width = 4;
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
            this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Legend.DividingLines.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Font.Name = "Lucida Console";
            this.tChart1.Legend.Font.Size = 9;
            this.tChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Squared = true;
            this.tChart1.Legend.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.Angle = 270;
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
            this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
            // 
            // 
            // 
            this.tChart1.Panel.Pen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
            this.tChart1.Panel.Shadow.Visible = true;
            this.tChart1.Series.Add(this.pie1);
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
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(122)))), ((int)(((byte)(41)))));
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(133)))), ((int)(((byte)(253)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(124)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(16, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Draw Flags";
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // buttonPen1
            // 
            this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPen1.Location = new System.Drawing.Point(176, 8);
            this.buttonPen1.Name = "buttonPen1";
            this.buttonPen1.Size = new System.Drawing.Size(80, 23);
            this.buttonPen1.TabIndex = 1;
            this.buttonPen1.Text = "Border...";
            this.buttonPen1.Click += new System.EventHandler(this.buttonPen1_Click);
            // 
            // pie1
            // 
            // 
            // 
            // 
            this.pie1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pie1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pie1.LabelMember = "Labels";
            // 
            // 
            // 
            // 
            // 
            // 
            this.pie1.Marks.Arrow.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.pie1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pie1.Marks.Brush.Gradient.Visible = true;
            // 
            // 
            // 
            this.pie1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.pie1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.pie1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.pie1.Marks.Callout.Distance = 0;
            this.pie1.Marks.Callout.Draw3D = false;
            this.pie1.Marks.Callout.Length = 8;
            this.pie1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.pie1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.pie1.Marks.Font.Name = "Microsoft Sans Serif";
            // 
            // 
            // 
            this.pie1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.pie1.MarksPie.LegSize = 0;
            this.pie1.MarksPie.VertCenter = false;
            this.pie1.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
            // 
            // 
            // 
            this.pie1.OtherSlice.Color = System.Drawing.Color.Empty;
            this.pie1.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
            this.pie1.OtherSlice.Text = "";
            this.pie1.OtherSlice.Value = 0;
            // 
            // 
            // 
            this.pie1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.pie1.Shadow.Height = 20;
            this.pie1.Shadow.Width = 20;
            this.pie1.Title = "pie1";
            this.pie1.Transparency = 0;
            // 
            // 
            // 
            this.pie1.XValues.DataMember = "Angle";
            this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.pie1.YValues.DataMember = "Pie";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
#if VS2005
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
#endif
            // 
            // LegendSymbolFlags
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "LegendSymbolFlags";
            this.Load += new System.EventHandler(this.LegendSymbolFlags_Load);
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		Random rnd = new Random();

		private void LegendSymbolFlags_Load(object sender, System.EventArgs e)
		{

			pie1.Add(rnd.Next(100),"USA");
			pie1.Add(rnd.Next(100),"France");
			pie1.Add(rnd.Next(100),"Germany");
			pie1.Add(rnd.Next(100),"India");
			pie1.Add(rnd.Next(100),"Italy");
			pie1.Add(rnd.Next(100),"Japan");
			pie1.Add(rnd.Next(100),"Portugal");
			pie1.Add(rnd.Next(100),"U.K.");

			buttonPen1.Pen = tChart1.Legend.Symbol.Pen;
			tChart1.Legend.Symbol.DefaultPen = false;
			buttonPen1.Pen.Width = 1;
			buttonPen1.Pen.Color = Color.Black;

			tChart1.Legend.Symbol.OnSymbolDraw +=new Steema.TeeChart.SymbolDrawEventHandler(Symbol_OnSymbolDraw);
			tChart1.Legend.Symbol.WidthUnits=Steema.TeeChart.LegendSymbolSize.Pixels;
			tChart1.Legend.Font.Size=12;
			tChart1.Legend.VertSpacing=8;
			tChart1.Legend.Symbol.Width=30;
			tChart1.Legend.Symbol.Squared = true;

		}

		private void Symbol_OnSymbolDraw(object sender, SymbolDrawEventArgs e) 
		{
			if(this.checkBox1.Checked) 
			{
				Rectangle tmpR = e.Rect;
				tmpR.Inflate(-1,-1);

				//System.Drawing.Bitmap bmp = new Bitmap(imageList1.Images[e.ValueIndex]);
				//tChart1.Chart.Graphics3D.Draw(tmpR, bmp, Steema.TeeChart.Drawing.ImageMode.Stretch, false);
			}
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			tChart1.Refresh();
		}

		private void buttonPen1_Click(object sender, System.EventArgs e)
		{
			tChart1.Refresh();
		}

	}
}

