using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Line_Interpolate : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.Line line1;
    private Steema.TeeChart.Styles.Line line2;
    private Steema.TeeChart.Styles.Line line3;
    private Steema.TeeChart.Tools.CursorTool cursorTool1;
    private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;
		private Steema.TeeChart.Tools.GridBand gridBand1;
    private double xval;

    /// <summary>
    /// Calculate y=y(x) for arbitrary x. Works fine only for line series with ordered x values.
    /// </summary>
    /// <param name="series"></param>
    /// <param name="firstindex"></param>
    /// <param name="lastindex"></param>
    /// <param name="xvalue"></param>
    /// <returns>y=y(xvalue) where xvalue is arbitrary x value.</returns>
    private double InterpolateLineSeries(TeeChart.Styles.Custom series, int firstindex, int lastindex, double xvalue)
    {
      int index;
      for (index=firstindex; index<=lastindex; index++)
      {
        if (index == -1 || series.XValues.Value[index]>xvalue) break;
      }
      // safeguard
      if (index<1) index = 1;
      else if (index>=series.Count) index = series.Count -1;
      // y=(y2-y1)/(x2-x1)*(x-x1)+y1
      double dx = series.XValues[index] - series.XValues[index-1];
      double dy = series.YValues[index] - series.YValues[index-1];
      if (dx!=0.0) return dy*(xvalue - series.XValues[index-1])/dx + series.YValues[index-1];
      else return 0.0;
    }

    private double InterpolateLineSeries(TeeChart.Styles.Custom series,double xvalue)
    {
      return InterpolateLineSeries(series,series.FirstVisibleIndex,series.LastVisibleIndex,xvalue);
    }

		public Line_Interpolate()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (TeeChart.Styles.Series s in tChart1.Series)
        s.FillSampleValues(20);
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
			this.line2 = new Steema.TeeChart.Styles.Line();
			this.line3 = new Steema.TeeChart.Styles.Line();
			this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(440, 72);
			this.textBox1.Text = @"Using a simple linear interpolation formula it's now possible to calculate y=y(x) for arbitrary x value. The code will work correctly only if you use line/fastline series and if x values are ordered.
Try moving the cursor -> series y values will be shown for arbitrary x value.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 40);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Series.Add(this.line2);
			this.tChart1.Series.Add(this.line3);
			this.tChart1.Tools.Add(this.cursorTool1);
			this.tChart1.Tools.Add(this.gridBand1);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.Red;
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
			this.line1.Pointer.HorizSize = 3;
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Pointer.VertSize = 3;
			this.line1.Pointer.Visible = true;
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
			// line2
			// 
			// 
			// line2.Brush
			// 
			this.line2.Brush.Color = System.Drawing.Color.Green;
			// 
			// line2.Marks
			// 
			// 
			// line2.Marks.Symbol
			// 
			// 
			// line2.Marks.Symbol.Shadow
			// 
			this.line2.Marks.Symbol.Shadow.Height = 1;
			this.line2.Marks.Symbol.Shadow.Visible = true;
			this.line2.Marks.Symbol.Shadow.Width = 1;
			// 
			// line2.Pointer
			// 
			// 
			// line2.Pointer.Brush
			// 
			this.line2.Pointer.HorizSize = 3;
			this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.line2.Pointer.VertSize = 3;
			this.line2.Pointer.Visible = true;
			this.line2.Title = "line2";
			// 
			// line2.XValues
			// 
			this.line2.XValues.DataMember = "X";
			this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line2.YValues
			// 
			this.line2.YValues.DataMember = "Y";
			// 
			// line3
			// 
			// 
			// line3.Brush
			// 
			this.line3.Brush.Color = System.Drawing.Color.Yellow;
			// 
			// line3.Marks
			// 
			// 
			// line3.Marks.Symbol
			// 
			// 
			// line3.Marks.Symbol.Shadow
			// 
			this.line3.Marks.Symbol.Shadow.Height = 1;
			this.line3.Marks.Symbol.Shadow.Visible = true;
			this.line3.Marks.Symbol.Shadow.Width = 1;
			// 
			// line3.Pointer
			// 
			// 
			// line3.Pointer.Brush
			// 
			this.line3.Pointer.HorizSize = 3;
			this.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle;
			this.line3.Pointer.VertSize = 3;
			this.line3.Pointer.Visible = true;
			this.line3.Title = "line3";
			// 
			// line3.XValues
			// 
			this.line3.XValues.DataMember = "X";
			this.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line3.YValues
			// 
			this.line3.YValues.DataMember = "Y";
			// 
			// cursorTool1
			// 
			this.cursorTool1.FollowMouse = true;
			// 
			// cursorTool1.Pen
			// 
			this.cursorTool1.Pen.Style = Drawing.DashStyle.Dash;
			this.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
			this.cursorTool1.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool1_Change);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(112, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Show markers";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Line_Interpolate
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Line_Interpolate";
			this.Load += new System.EventHandler(this.Line_Interpolate_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void cursorTool1_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
    {
      xval = e.XValue;
      tChart1.Header.Text = "";
      for (int i=0; i<tChart1.Series.Count; i++)
        if (tChart1.Series[i] is TeeChart.Styles.Custom)
        {
          tChart1.Header.Text += tChart1.Series[i].Title + ": Y("+e.XValue.ToString("0.00")+")= ";
          tChart1.Header.Text += InterpolateLineSeries(tChart1.Series[i] as Steema.TeeChart.Styles.Custom,e.XValue).ToString("0.00")+"\r\n";
        }
    }

    private void Line_Interpolate_Load(object sender, System.EventArgs e)
    {
      cursorTool1_Change(tChart1,new Steema.TeeChart.Tools.CursorChangeEventArgs());
    }

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      if (checkBox1.Checked)
      {
        int xs = tChart1.Axes.Bottom.CalcXPosValue(xval);
        int ys;
        g.Brush.Visible = true;
        g.Brush.Solid = true;
        for (int i=0; i<tChart1.Series.Count; i++)
          if (tChart1.Series[i] is TeeChart.Styles.Custom)
          {
            ys = tChart1.Series[i].GetVertAxis.CalcYPosValue(InterpolateLineSeries(tChart1.Series[i] as Steema.TeeChart.Styles.Custom,xval));
            g.Brush.Color = tChart1.Series[i].Color;
            g.Ellipse(new Rectangle(xs-4,ys-4,8,8));
          }
      }
  }
	}
}

