using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class CurveFitting_Coef : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.FastLine fastLine1;
    private Steema.TeeChart.Styles.FastLine fastLine2;
    private Steema.TeeChart.Functions.PolyFitting polyFitting1;
    private System.Windows.Forms.Label label1;
    private Steema.TeeChart.Tools.CursorTool cursorTool1;
		private System.ComponentModel.IContainer components = null;

		public CurveFitting_Coef()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			fastLine1.FillSampleValues(100);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurveFitting_Coef));
			this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
			this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
			this.polyFitting1 = new Steema.TeeChart.Functions.PolyFitting();
			this.label1 = new System.Windows.Forms.Label();
			this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(464, 73);
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Size = new System.Drawing.Size(464, 39);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Aspect.ZOffset = 0;
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "tChart1"};
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
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
			this.tChart1.Series.Add(this.fastLine1);
			this.tChart1.Series.Add(this.fastLine2);
			this.tChart1.Size = new System.Drawing.Size(464, 221);
			this.tChart1.Tools.Add(this.cursorTool1);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
			// 
			// chartContainer
			// 
			this.chartContainer.Size = new System.Drawing.Size(464, 221);
			// 
			// fastLine1
			// 
			this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.fastLine1.ColorEach = false;
			// 
			// 
			// 
			this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLine1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLine1.Marks.Callout.Distance = 0;
			this.fastLine1.Marks.Callout.Draw3D = false;
			this.fastLine1.Marks.Callout.Length = 10;
			this.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLine1.Marks.Callout.Visible = false;
			this.fastLine1.Title = "Data";
			this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLine1.XValues.DataMember = "X";
			this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.fastLine1.YValues.DataMember = "Y";
			// 
			// fastLine2
			// 
			this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.fastLine2.ColorEach = false;
			this.fastLine2.DataSource = this.fastLine1;
			this.fastLine2.Function = this.polyFitting1;
			// 
			// 
			// 
			this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLine2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLine2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLine2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLine2.Marks.Callout.Distance = 0;
			this.fastLine2.Marks.Callout.Draw3D = false;
			this.fastLine2.Marks.Callout.Length = 10;
			this.fastLine2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLine2.Marks.Callout.Visible = false;
			this.fastLine2.Title = "Poly";
			this.fastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// polyFitting1
			// 
			this.polyFitting1.PolyDegree = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// Function_PolyFitCoeff
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 333);
			this.Name = "Function_PolyFitCoeff";
			this.Load += new System.EventHandler(this.PolyFitCoeff_Load);
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

    private void ShowFunction()
    {
      string txt = "y=";
      for (int t=0; t<polyFitting1.PolyDegree; t++)
      {
        txt += " ";
        if (polyFitting1.Coefficient(t) >= 0.0) txt += "+";
        txt += polyFitting1.Coefficient(t).ToString("0.00##");
        if (t>0) txt += "*x";
        if (t>1) txt += "^"+t.ToString();
      }
      label1.Text = "Function : " + txt;
    }

    private void PolyFitCoeff_Load(object sender, System.EventArgs e)
    {
      ShowFunction();
    }

    private void tChart1_MouseMove(object sender, MouseEventArgs e)
    {
      double xval = fastLine2.GetHorizAxis.CalcPosPoint(e.X);
      double yval = polyFitting1.GetCurveYValue(fastLine1,xval);
      cursorTool1.XValue = xval;
      cursorTool1.YValue = yval;
    }

    private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      if (cursorTool1.XValue > tChart1.Axes.Bottom.Minimum && cursorTool1.XValue < tChart1.Axes.Bottom.Maximum)
      {
        g.Brush.Color = Color.Red;
        g.Brush.Visible = true;
        int xpos = cursorTool1.GetHorizAxis.CalcPosValue(cursorTool1.XValue);
        int ypos = cursorTool1.GetVertAxis.CalcPosValue(cursorTool1.YValue);
        g.Rectangle(xpos-5,ypos+5,xpos+5,ypos-5);
      }
    }
	}
}

