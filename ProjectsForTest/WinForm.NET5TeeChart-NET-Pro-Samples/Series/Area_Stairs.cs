using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Area_Stairs : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Area area1;
		private Steema.TeeChart.Styles.Area area2;
		private System.ComponentModel.IContainer components = null;

		public Area_Stairs()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (Steema.TeeChart.Styles.Area s in this.tChart1.Series)
			{
				s.FillSampleValues(10);
				s.Transparency = 30;
				s.Stairs = true;
			}
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
			this.area1 = new Steema.TeeChart.Styles.Area();
			this.area2 = new Steema.TeeChart.Styles.Area();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 56);
			this.textBox1.Text = "Area Series in \"Stair\" mode can set using :\r\n\r\narea1.Stairs=true; area2.Stairs=tr" +
				"ue;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 31);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.ZPosition = 0;
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
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.ZPosition = 0;
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
			// tChart1.Axes.DepthTop.Grid
			// 
			this.tChart1.Axes.DepthTop.Grid.ZPosition = 0;
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
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.ZPosition = 0;
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
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.ZPosition = 0;
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
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.ZPosition = 0;
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
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			// 
			// tChart1.Header.Font.Shadow
			// 
			// 
			// tChart1.Header.Font.Shadow.Brush
			// 
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Header.Font.Shadow.Visible = false;
			this.tChart1.Header.Lines = new string[] {
														 "Area series stairs"};
			// 
			// tChart1.Header.Shadow
			// 
			this.tChart1.Header.Shadow.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(240)), ((System.Byte)(240)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Shadow
			// 
			this.tChart1.Legend.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(134)), ((System.Byte)(134)), ((System.Byte)(134)));
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			this.tChart1.Legend.Shadow.Visible = false;
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
			this.tChart1.Location = new System.Drawing.Point(0, 87);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.518F;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Gradient.SigmaFocus = 0.518F;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Visible = false;
			this.tChart1.Series.Add(this.area1);
			this.tChart1.Series.Add(this.area2);
			this.tChart1.Size = new System.Drawing.Size(466, 199);
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
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(94, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Stairs";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// area1
			// 
			// 
			// area1.AreaBrush
			// 
			this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(153)), ((System.Byte)(102)));
			// 
			// area1.AreaLines
			// 
			this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(92)), ((System.Byte)(61)));
			// 
			// area1.Brush
			// 
			this.area1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(153)), ((System.Byte)(102)));
			// 
			// area1.LinePen
			// 
			this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(92)), ((System.Byte)(61)));
			// 
			// area1.Marks
			// 
			// 
			// area1.Marks.Callout
			// 
			this.area1.Marks.Callout.Arrow = this.area1.Marks.Arrow;
			this.area1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.area1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// area1.Marks.Callout.Brush
			// 
			this.area1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.area1.Marks.Callout.Distance = 0;
			this.area1.Marks.Callout.Draw3D = false;
			this.area1.Marks.Callout.Length = 10;
			this.area1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// area1.Marks.Font
			// 
			// 
			// area1.Marks.Font.Shadow
			// 
			this.area1.Marks.Font.Shadow.Visible = false;
			this.area1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
			// 
			// area1.Pointer
			// 
			this.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.area1.Stacked = Steema.TeeChart.Styles.CustomStack.Stack;
			this.area1.Title = "area1";
			// 
			// area1.XValues
			// 
			this.area1.XValues.DataMember = "X";
			this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// area1.YValues
			// 
			this.area1.YValues.DataMember = "Y";
			// 
			// area2
			// 
			// 
			// area2.AreaBrush
			// 
			this.area2.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(102)), ((System.Byte)(102)));
			// 
			// area2.AreaLines
			// 
			this.area2.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(61)), ((System.Byte)(61)));
			// 
			// area2.Brush
			// 
			this.area2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(102)), ((System.Byte)(102)));
			// 
			// area2.LinePen
			// 
			this.area2.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(61)), ((System.Byte)(61)));
			// 
			// area2.Marks
			// 
			// 
			// area2.Marks.Callout
			// 
			this.area2.Marks.Callout.Arrow = this.area2.Marks.Arrow;
			this.area2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.area2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// area2.Marks.Callout.Brush
			// 
			this.area2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.area2.Marks.Callout.Distance = 0;
			this.area2.Marks.Callout.Draw3D = false;
			this.area2.Marks.Callout.Length = 10;
			this.area2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// area2.Marks.Font
			// 
			// 
			// area2.Marks.Font.Shadow
			// 
			this.area2.Marks.Font.Shadow.Visible = false;
			this.area2.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
			// 
			// area2.Pointer
			// 
			this.area2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.area2.Stacked = Steema.TeeChart.Styles.CustomStack.Stack;
			this.area2.Title = "area2";
			// 
			// area2.XValues
			// 
			this.area2.XValues.DataMember = "X";
			this.area2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// area2.YValues
			// 
			this.area2.YValues.DataMember = "Y";
			// 
			// Area_Stairs
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Area_Stairs";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			area1.Stairs=checkBox1.Checked;
			area2.Stairs=checkBox1.Checked;
		}
	}
}

