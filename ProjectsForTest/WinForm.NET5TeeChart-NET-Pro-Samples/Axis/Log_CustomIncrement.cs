using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Log_CustomIncrement : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.Line line1;
		private System.ComponentModel.IContainer components = null;
    private const int majorcount = 4; 
    private double[] majors = new double[majorcount];
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2; 
    private double[] minors = new double[2*majorcount-2]; 

		public Log_CustomIncrement()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

      // major ticks = labels 
      majors[0] = 0.1; 
      majors[1] = 0.2; 
      majors[2] = 0.5; 
      majors[3] = 1.0; 

      // two minors between each major tick 
      minors[0] = 0.12; 
      minors[1] = 0.17; 

      minors[2] = 0.30; 
      minors[3] = 0.38; 

      minors[4] = 0.55; 
      minors[5] = 0.7;

      for (int t=0; t<100; t++)
        line1.Add(t,2.0E-3*(5*t-50)*(2*t-10)+5.0);
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = @"Using custom axis labels it's fairly easy to construct non-linear axis scale. 
The following example demonstrates how to setup custom logarithmic axis increment and minor ticks for vertical axis.
In the example we setup four axis labels per decade and additionally two minor ticklines between each label (see code).";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.ThemeIndex = 7;
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.AxisPen
			// 
			this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.tChart1.Axes.Bottom.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Bottom.MinorTicks
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.Ticks.Length = 2;
			// 
			// tChart1.Axes.Bottom.TicksInner
			// 
			this.tChart1.Axes.Bottom.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.AxisPen
			// 
			this.tChart1.Axes.Depth.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Depth.MinorTicks
			// 
			this.tChart1.Axes.Depth.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			// 
			// tChart1.Axes.Depth.TicksInner
			// 
			this.tChart1.Axes.Depth.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.tChart1.Axes.Left.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Left.Labels
			// 
			this.tChart1.Axes.Left.Labels.CustomSize = 50;
			this.tChart1.Axes.Left.Logarithmic = true;
			// 
			// tChart1.Axes.Left.MinorTicks
			// 
			this.tChart1.Axes.Left.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.Ticks.Length = 2;
			// 
			// tChart1.Axes.Left.TicksInner
			// 
			this.tChart1.Axes.Left.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.AxisPen
			// 
			this.tChart1.Axes.Right.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Right.MinorTicks
			// 
			this.tChart1.Axes.Right.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Ticks.Length = 2;
			// 
			// tChart1.Axes.Right.TicksInner
			// 
			this.tChart1.Axes.Right.TicksInner.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.AxisPen
			// 
			this.tChart1.Axes.Top.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray;
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Top.MinorTicks
			// 
			this.tChart1.Axes.Top.MinorTicks.Visible = false;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Ticks.Length = 2;
			// 
			// tChart1.Axes.Top.TicksInner
			// 
			this.tChart1.Axes.Top.TicksInner.Visible = false;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Header.Brush.Gradient.Visible = true;
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Header.Font.Name = "Verdana";
			// 
			// tChart1.Header.Font.Shadow
			// 
			// 
			// tChart1.Header.Font.Shadow.Brush
			// 
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Header.Font.Shadow.Visible = true;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Header.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Header.Gradient.Visible = true;
			this.tChart1.Header.Lines = new string[] {
														 "Logarithmic axis labels"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.DividingLines
			// 
			this.tChart1.Legend.DividingLines.Visible = true;
			// 
			// tChart1.Legend.Font
			// 
			this.tChart1.Legend.Font.Name = "Verdana";
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Shadow.Height = 0;
			this.tChart1.Legend.Shadow.Width = 0;
			this.tChart1.Legend.Transparent = true;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			// 
			// tChart1.Panel.Pen
			// 
			this.tChart1.Panel.Pen.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Width = 0;
			this.tChart1.Series.Add(this.line1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.ApplyDark = false;
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Walls.Back.Size = 8;
			this.tChart1.Walls.Back.Transparent = false;
			this.tChart1.Walls.Back.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.ApplyDark = false;
			this.tChart1.Walls.Bottom.Size = 8;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.ApplyDark = false;
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Walls.Left.Size = 8;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.ApplyDark = false;
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
			this.tChart1.Walls.Right.Size = 8;
			this.tChart1.BeforeDrawAxes += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_BeforeDrawAxes);
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(165)), ((System.Byte)(255)));
			// 
			// line1.Marks
			// 
			// 
			// line1.Marks.Arrow
			// 
			this.line1.Marks.Arrow.Color = System.Drawing.Color.Black;
			// 
			// line1.Marks.Font
			// 
			this.line1.Marks.Font.Size = 10;
			this.line1.Marks.Transparent = true;
			// 
			// line1.Pointer
			// 
			this.line1.Pointer.HorizSize = 3;
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Diamond;
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
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(152, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Logarithmic vertical axis";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(176, 8);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(176, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Custom log axis increment";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// Log_CustomIncrement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Log_CustomIncrement";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    /// <summary>
    /// Calculates the decade of 0.y x 10^n 
    /// </summary>
    /// <param name="Value"></param>
    /// <returns>the decade number</returns>
    private int GetDecade(double Value) 
    { 
      double absval = Math.Abs(Value);
      int res = 0; 
      if (absval>= 1)
      {
        while (absval >= 1.0) 
        { 
          absval /= 10.0; 
          res ++; 
        }
      } 
      else
      {
        while (absval < 1.0) 
        { 
          absval *= 10.0; 
          res --; 
        }
      }
      return res; 
    } 

    /// <summary> 
    /// Generates specific logarithmic labels for axis. 
    /// </summary> 
    /// <param name="g">Graphics3D object</param> 
    /// <param name="ax">Axis</param> 
    /// <param name="majorlabels">array of logarithmic axis labels</param> 
    /// <param name="minorticks">array of minor ticks</param> 
    /// <param name="start">left/lower bound for minor tick</param> 
    /// <param name="end">right/upper bound for minor tick</param> 
    private void GenerateLogLabels(Steema.TeeChart.Drawing.IGraphics3D g, Steema.TeeChart.Axis ax, double [] majorlabels, double [] minorticks, int start, int end) 
    { 
      ax.Labels.Items.Clear(); 
      int mindecade = GetDecade(ax.Minimum); 
      int maxdecade = GetDecade(ax.Maximum); 
      double currval; 
      int tickypos; 

      start -= ax.MinorTicks.Length; 
      end += ax.MinorTicks.Length; 

      g.Pen.Style = ax.MinorGrid.Style; 
      g.Pen.Color = ax.MinorGrid.Color; 

      for (int i = mindecade ; i<=maxdecade; i++) 
      { 
        for (int j = 0; j<majorlabels.Length; j++) 
        { 
          currval =majorlabels[j]*Math.Pow(10,i) ; 
          if (currval >= ax.Minimum && currval <= ax.Maximum) 
            ax.Labels.Items.Add(currval); 
        } 
        for (int k = 0; k<minorticks.Length; k++) 
        { 
          currval =minorticks[k]*Math.Pow(10,i) ; 
            if (currval >= ax.Minimum && currval <= ax.Maximum) 
          { 
            tickypos = ax.CalcPosValue(currval); 
            if (ax.Horizontal) 
              g.Line(tickypos,start,tickypos,end); 
            else 
              g.Line(start,tickypos,end,tickypos); 
            } 
        }        
      } 
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      tChart1.Axes.Left.Logarithmic = checkBox1.Checked;
    }

    private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
    {
      tChart1.Invalidate();
    }

    private void tChart1_BeforeDrawAxes(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      if (checkBox1.Checked && checkBox2.Checked)
      {
        GenerateLogLabels(g,line1.GetVertAxis,majors,minors,
                line1.GetHorizAxis.IStartPos, line1.GetHorizAxis.IEndPos);
        tChart1.Invalidate();
      }
      else line1.GetVertAxis.Labels.Items.Clear();
    }
  }
}

