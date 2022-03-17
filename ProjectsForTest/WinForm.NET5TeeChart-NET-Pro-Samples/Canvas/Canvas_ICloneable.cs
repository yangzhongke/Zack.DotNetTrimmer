using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Tools;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
	public class Canvas_ICloneable : Steema.TeeChart.Samples.BaseForm
  {

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "A number of Canvas objects now implement the ICloneable interface,\r\nmaking deep c" +
				"opies of these objects a one line operation, e.g.\r\n\r\nSteema.TeeChart.Axis newAxi" +
				"s = tChart1.Axes.Left.Clone() as Axis;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.ElevationFloat = 345;
			this.tChart1.Aspect.RotationFloat = 345;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Automatic = true;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Dash;
			this.tChart1.Axes.Bottom.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
			
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Automatic = true;
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Dash;
			this.tChart1.Axes.Depth.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
			
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
			
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Automatic = true;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Grid.Style = Drawing.DashStyle.Dash;
			this.tChart1.Axes.DepthTop.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Automatic = true;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Dash;
			this.tChart1.Axes.Left.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Automatic = true;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Dash;
			this.tChart1.Axes.Right.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Automatic = true;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Dash;
			this.tChart1.Axes.Top.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Footer.Font.Shadow.Visible = false;
			
			// 
			// 
			// 
			this.tChart1.Footer.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Font.Shadow.Visible = false;
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// 
			// 
			this.tChart1.Header.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Font.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Title.Font.Bold = true;
			// 
			// 
			// 
			this.tChart1.Legend.Title.Font.Shadow.Visible = false;
			
			// 
			// 
			// 
			this.tChart1.Legend.Title.Pen.Visible = false;
			// 
			// 
			// 
			this.tChart1.Legend.Title.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubFooter.Font.Shadow.Visible = false;
			
			// 
			// 
			// 
			this.tChart1.SubFooter.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubHeader.Font.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.SubHeader.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.AutoHide = false;
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Visible = false;
			// 
			// 
			// 
			this.tChart1.Walls.Back.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.AutoHide = false;
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Walls.Left.AutoHide = false;
			// 
			// 
			// 
			this.tChart1.Walls.Left.Shadow.Visible = false;
			// 
			// 
			// 
			this.tChart1.Walls.Right.AutoHide = false;
			// 
			// 
			// 
			this.tChart1.Walls.Right.Shadow.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select an object with the mouse (axes, series, legend, titles, annotation) ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "and click Ctrl+V to paste a copy!";
			// 
			// Canvas_ICloneable
			// 
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Canvas_ICloneable";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;

    public Canvas_ICloneable()
    {
      InitializeComponent();
      InitializeChart();
    }

    private Steema.TeeChart.Styles.Line line1;
    private Steema.TeeChart.Tools.Selector selector1;
    private Steema.TeeChart.Tools.Annotation annotation1;

    private void InitializeChart()
    {
      tChart1.Aspect.View3D = false;
      tChart1.Header.Text = "Canvas ICloneable Implementation";
      annotation1 = new Steema.TeeChart.Tools.Annotation(tChart1.Chart);
      annotation1.Text = "Click on me!";
      annotation1.Position = Steema.TeeChart.Tools.AnnotationPositions.LeftTop;
      line1 = new Steema.TeeChart.Styles.Line(tChart1.Chart);
      line1.FillSampleValues();
      selector1 = new Steema.TeeChart.Tools.Selector(tChart1.Chart);
      selector1.AllowDrag = false;
      selector1.Selected += new Steema.TeeChart.Tools.SelectorSelectedEventHandler(selector1_Selected);

      tChart1.Axes.Left.Grid.Visible = false;
      tChart1.Axes.Bottom.Grid.Visible = false;

      tChart1.KeyDown += new KeyEventHandler(tChart1_KeyDown);
      tChart1.AfterDraw += new PaintChartEventHandler(tChart1_AfterDraw);
    }

    void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      if (tempTitle != null)
      {
        tempTitle.CustomPosition = true;
        Rectangle rect = tChart1.Chart.ChartRect;
        tempTitle.DoDraw(g, ref rect, true, "Title");
      }
    
    }

    private Title tempTitle;

    void tChart1_KeyDown(object sender, KeyEventArgs e)
    {
      Annotation tempAnno;
      Steema.TeeChart.Styles.Series tempSeries;
      Axis tempAxis;

      if (e.Control == true && e.KeyCode == Keys.V)
      {
        if (selected is ICloneable)
        {
          if (selected is Annotation)
          {
            tempAnno = (selected as ICloneable).Clone() as Annotation;
            tempAnno.Shape.CustomPosition = true;
            tempAnno.Left = tempAnno.Left + 50;
            tempAnno.Top = tempAnno.Top + 50;
            tChart1.Invalidate();
          }
					else if (selected is Steema.TeeChart.Styles.Series)
          {
						tempSeries = (selected as ICloneable).Clone() as Steema.TeeChart.Styles.Series;
            for (int i = 0; i < tempSeries.Count; i++)
            {
              tempSeries.XValues[i] = tempSeries.XValues[i] + 1;
            }
            tempSeries.Invalidate();
          }
          else if (selected is Axis)
          {
            tempAxis = (selected as ICloneable).Clone() as Axis;
            tChart1.Axes.Custom.Add(tempAxis);
            tempAxis.RelativePosition = tempAxis.RelativePosition + 10;
            if (tempAxis.Horizontal)
            {
              line1.CustomHorizAxis = tempAxis;
            }
            else
            {
              line1.CustomVertAxis = tempAxis;
            }
          }
          else if (selected is Title)
          {
            tempTitle = (selected as ICloneable).Clone() as Title;
            tempTitle.Top = tempTitle.Top + 20;
            tChart1.Invalidate();
                        
          }
          else if (selected is Legend)
          {
            Steema.TeeChart.Tools.ExtraLegend legend = new ExtraLegend(tChart1.Chart);
            //The ExtraLegend.Legend property implements Legend.Clone().
            legend.Legend = selected as Legend;
            legend.Series = line1;
            legend.Legend.Left = tChart1.Legend.Left - 50;
          }
        
        }
      }
    }

    

    private object selected;

    void selector1_Selected(object sender, EventArgs e)
    {
      selected = selector1.Selection;
    }
  }
}

