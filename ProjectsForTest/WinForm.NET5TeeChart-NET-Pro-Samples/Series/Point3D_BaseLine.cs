using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Point3D_BaseLine : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.ButtonPen buttonPen1;
		private Steema.TeeChart.Styles.Points3D points3D1;
		private System.ComponentModel.IContainer components = null;

		public Point3D_BaseLine()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();


			points3D1.FillSampleValues();
			this.buttonPen1.Pen = points3D1.BaseLine;


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
			this.buttonPen1 = new Steema.TeeChart.ButtonPen();
			this.points3D1 = new Steema.TeeChart.Styles.Points3D();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Point3D BaseLine property is a ChartPen to draw lines from every point to \r\nthe b" +
				"ase floor specified by the series vertical axis.\r\n\r\npoints3D1.BaseLine.Visible =" +
				" true; ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonPen1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Labels.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font.Shadow
			// 
			this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title.Shadow
			// 
			this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Labels.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Title
			// 
			// 
			// tChart1.Axes.Depth.Title.Font
			// 
			// 
			// tChart1.Axes.Depth.Title.Font.Shadow
			// 
			this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Title.Shadow
			// 
			this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop
			// 
			// 
			// tChart1.Axes.DepthTop.Labels
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Font
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Font.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Labels.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Title
			// 
			// 
			// tChart1.Axes.DepthTop.Title.Font
			// 
			// 
			// tChart1.Axes.DepthTop.Title.Font.Shadow
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Title.Shadow
			// 
			this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			// 
			// tChart1.Axes.Left.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Labels.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Title
			// 
			// 
			// tChart1.Axes.Left.Title.Font
			// 
			// 
			// tChart1.Axes.Left.Title.Font.Shadow
			// 
			this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Title.Shadow
			// 
			this.tChart1.Axes.Left.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			// 
			// tChart1.Axes.Right.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Labels.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Title
			// 
			// 
			// tChart1.Axes.Right.Title.Font
			// 
			// 
			// tChart1.Axes.Right.Title.Font.Shadow
			// 
			this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Title.Shadow
			// 
			this.tChart1.Axes.Right.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			// 
			// tChart1.Axes.Top.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Labels.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Title
			// 
			// 
			// tChart1.Axes.Top.Title.Font
			// 
			// 
			// tChart1.Axes.Top.Title.Font.Shadow
			// 
			this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Title.Shadow
			// 
			this.tChart1.Axes.Top.Title.Shadow.Visible = false;
			// 
			// tChart1.Footer
			// 
			// 
			// tChart1.Footer.Font
			// 
			// 
			// tChart1.Footer.Font.Shadow
			// 
			this.tChart1.Footer.Font.Shadow.Visible = false;
			// 
			// tChart1.Footer.Shadow
			// 
			this.tChart1.Footer.Shadow.Visible = false;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Shadow
			// 
			this.tChart1.Header.Font.Shadow.Visible = false;
			this.tChart1.Header.Lines = new string[] {
																								 "Point3D BaseLine"};
			// 
			// tChart1.Header.Shadow
			// 
			this.tChart1.Header.Shadow.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Shadow
			// 
			this.tChart1.Legend.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Title
			// 
			// 
			// tChart1.Legend.Title.Font
			// 
			this.tChart1.Legend.Title.Font.Bold = true;
			// 
			// tChart1.Legend.Title.Font.Shadow
			// 
			this.tChart1.Legend.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Title.Pen
			// 
			this.tChart1.Legend.Title.Pen.Visible = false;
			// 
			// tChart1.Legend.Title.Shadow
			// 
			this.tChart1.Legend.Title.Shadow.Visible = false;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Visible = false;
			this.tChart1.Series.Add(this.points3D1);
			// 
			// tChart1.SubFooter
			// 
			// 
			// tChart1.SubFooter.Font
			// 
			// 
			// tChart1.SubFooter.Font.Shadow
			// 
			this.tChart1.SubFooter.Font.Shadow.Visible = false;
			// 
			// tChart1.SubFooter.Shadow
			// 
			this.tChart1.SubFooter.Shadow.Visible = false;
			// 
			// tChart1.SubHeader
			// 
			// 
			// tChart1.SubHeader.Font
			// 
			// 
			// tChart1.SubHeader.Font.Shadow
			// 
			this.tChart1.SubHeader.Font.Shadow.Visible = false;
			// 
			// tChart1.SubHeader.Shadow
			// 
			this.tChart1.SubHeader.Shadow.Visible = false;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.AutoHide = false;
			// 
			// tChart1.Walls.Back.Shadow
			// 
			this.tChart1.Walls.Back.Shadow.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.AutoHide = false;
			// 
			// tChart1.Walls.Bottom.Shadow
			// 
			this.tChart1.Walls.Bottom.Shadow.Visible = false;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.AutoHide = false;
			// 
			// tChart1.Walls.Left.Shadow
			// 
			this.tChart1.Walls.Left.Shadow.Visible = false;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.AutoHide = false;
			// 
			// tChart1.Walls.Right.Shadow
			// 
			this.tChart1.Walls.Right.Shadow.Visible = false;
			// 
			// buttonPen1
			// 
			this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPen1.Location = new System.Drawing.Point(16, 8);
			this.buttonPen1.Name = "buttonPen1";
			this.buttonPen1.Size = new System.Drawing.Size(96, 23);
			this.buttonPen1.TabIndex = 0;
			this.buttonPen1.Text = "Base Line ...";
			this.buttonPen1.Click += new System.EventHandler(this.buttonPen1_Click);
			// 
			// points3D1
			// 
			// 
			// points3D1.BaseLine
			// 
			this.points3D1.BaseLine.Visible = true;
			// 
			// points3D1.Marks
			// 
			// 
			// points3D1.Marks.Callout
			// 
			this.points3D1.Marks.Callout.Arrow = this.points3D1.Marks.Arrow;
			this.points3D1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.points3D1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// points3D1.Marks.Callout.Brush
			// 
			this.points3D1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.points3D1.Marks.Callout.Distance = 0;
			this.points3D1.Marks.Callout.Draw3D = false;
			this.points3D1.Marks.Callout.Length = 10;
			this.points3D1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// points3D1.Marks.Font
			// 
			// 
			// points3D1.Marks.Font.Shadow
			// 
			this.points3D1.Marks.Font.Shadow.Visible = false;
			// 
			// points3D1.Pointer
			// 
			// 
			// points3D1.Pointer.Brush
			// 
			this.points3D1.Pointer.Brush.Color = System.Drawing.Color.Red;
			// 
			// points3D1.Pointer.Pen
			// 
			this.points3D1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.points3D1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.points3D1.Pointer.Visible = true;
			this.points3D1.Title = "point3D1";
			// 
			// points3D1.XValues
			// 
			this.points3D1.XValues.DataMember = "X";
			// 
			// points3D1.YValues
			// 
			this.points3D1.YValues.DataMember = "Y";
			// 
			// points3D1.ZValues
			// 
			this.points3D1.ZValues.DataMember = "Z";
			// 
			// Point3D_BaseLine
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Point3D_BaseLine";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonPen1_Click(object sender, System.EventArgs e)
		{
			points3D1.Invalidate();
		}
	}
}

