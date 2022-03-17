using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_AnnotationCallout : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.ButtonPen buttonPen1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Button button1;
    private Steema.TeeChart.Styles.Points points1;
    private Steema.TeeChart.Tools.Annotation annotation1;
		private System.ComponentModel.IContainer components = null;

		public Tool_AnnotationCallout()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

      points1.FillSampleValues();

      annotation1.Callout.Visible=true;
      annotation1.Callout.Arrow.Visible=true;

      buttonPen1.Pen = annotation1.Callout.Arrow;
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.points1 = new Steema.TeeChart.Styles.Points();
			this.annotation1 = new Steema.TeeChart.Tools.Annotation();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(360, 73);
			this.textBox1.Text = "Annotations include a Callout object.\r\n\r\nThis object is used to draw a line from " +
				"the annotation to any position in the chart.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.buttonPen1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 39);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 25;
			
			
			this.tChart1.Aspect.ZoomText = false;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Annotation callout"};
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
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.points1);
			this.tChart1.Size = new System.Drawing.Size(360, 189);
			this.tChart1.Tools.Add(this.annotation1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.ClickSeries += this.tChart1_ClickSeries;
			this.tChart1.MouseMove += this.tChart1_MouseMove;
			// 
			// buttonPen1
			// 
			this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPen1.Location = new System.Drawing.Point(116, 8);
			this.buttonPen1.Name = "buttonPen1";
			this.buttonPen1.Size = new System.Drawing.Size(64, 24);
			this.buttonPen1.TabIndex = 2;
			this.buttonPen1.Text = "Border...";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(196, 12);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(92, 16);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Follow mouse";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(32, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// points1
			// 
			this.points1.ColorEach = true;
			// 
			// points1.Marks
			// 
			// 
			// points1.Marks.Symbol
			// 
			// 
			// points1.Marks.Symbol.Shadow
			// 
			this.points1.Marks.Symbol.Shadow.Height = 1;
			this.points1.Marks.Symbol.Shadow.Visible = true;
			this.points1.Marks.Symbol.Shadow.Width = 1;
			// 
			// points1.Pointer
			// 
			// 
			// points1.Pointer.Brush
			// 
			this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(204)));
			this.points1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.points1.Title = "points1";
			// 
			// points1.XValues
			// 
			this.points1.XValues.DataMember = "X";
			this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// points1.YValues
			// 
			this.points1.YValues.DataMember = "Y";
			// 
			// annotation1
			// 
			this.annotation1.Cursor = Drawing.Cursors.Default;
			this.annotation1.Left = 180;
			// 
			// annotation1.Shape
			// 
			this.annotation1.Shape.Bottom = 42;
			this.annotation1.Shape.CustomPosition = true;
			this.annotation1.Shape.Left = 180;
			this.annotation1.Shape.Lines = new string[] {
																										" Move the mouse ! "};
			// 
			// annotation1.Shape.Pen
			// 
			this.annotation1.Shape.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
			this.annotation1.Shape.Right = 279;
			// 
			// annotation1.Shape.Shadow
			// 
			this.annotation1.Shape.Shadow.Visible = true;
			this.annotation1.Shape.Top = 25;
			this.annotation1.Text = " Move the mouse ! ";
			this.annotation1.Top = 25;
			// 
			// AnnotationCallout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 301);
			this.Name = "AnnotationCallout";
			this.Load += new System.EventHandler(this.AnnotationCallout_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void AnnotationCallout_Load(object sender, System.EventArgs e)
    {
      // force a first-time chart redrawing, to obtain valid
      // coordinates (Series1.CalcYPos, etc).
      tChart1.Invalidate();

      tChart1.Aspect.Zoom=100;
      // Start positioning annotation callout at point index 5
      SetCallout(5);
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      if (checkBox1.Checked)
      {
        tChart1.Text="Move the mouse over points !";
        points1.Cursor= Drawing.Cursors.Default;
      }
      else
      {
        tChart1.Text="Click a point !";
        points1.Cursor= Drawing.Cursors.Hand;
      }
    }

    private void tChart1_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, Drawing.MouseEventArgs e)
    {
      if (!checkBox1.Checked) SetCallout(valueIndex);
    }

    private void tChart1_MouseMove(object sender, MouseEventArgs e)
    {
      if (checkBox1.Checked)  // follow mouse
      {
        // Locate nearest point to mouse...
        int tmp=NearestPoint(points1, e.X, e.Y);
        if (tmp!=-1) SetCallout(tmp);  // set annotation callout
      }
    }

    private void SetCallout(int AIndex)
    {
      // Change annotation text
      annotation1.Text="Point: "+AIndex.ToString()+"\r\n"+
        "Value: "+points1.ValueMarkText(AIndex);

      // Re-position annotation callout
      annotation1.Callout.XPosition=points1.CalcXPos(AIndex);
      annotation1.Callout.YPosition=points1.CalcYPos(AIndex);
      annotation1.Callout.ZPosition=0;
    }

    // Returns Series point index that is nearest to xy position.
    private int NearestPoint (Steema.TeeChart.Styles.Series ASeries, int x, int y)
    {
      int diff=-1;
      int tmpDiff, t, tmpX, tmpY, res;
      
      res=-1;
      for (t=0; t<ASeries.Count; t++)
      {
        tmpX=ASeries.CalcXPos(t)-x;
        tmpY=ASeries.CalcYPos(t)-y;
        tmpDiff=TeeChart.Utils.Round(Math.Sqrt(TeeChart.Utils.Sqr(tmpX)+TeeChart.Utils.Sqr(tmpY)));
        if (diff==-1 || tmpDiff<diff)
        {
          diff=tmpDiff;
          res=t;
        }
      }
      return res;
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      Editors.ChartEditor.ShowModal(tChart1,Editors.ChartEditorTabs.Tools);
    }
  }
}

