using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class XYZ_Gridding : Steema.TeeChart.Samples.BaseForm
  {
    private Steema.TeeChart.Styles.Points3D points3D1;
    private Steema.TeeChart.Styles.Surface surface1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private Steema.TeeChart.Tools.Rotate rotate1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
    private System.ComponentModel.IContainer components = null;

    private void Fill()
    {
      points3D1.Clear();
      points3D1.BeginUpdate();
      try
      {
        int m = 40;
        double tmpz, tmpx, tmpy;

        for (int x=-m; x<m; x++)
        {
          tmpx = x*x/900.0;
          for (int z=-m; z<m; z++)
          {
            tmpz = z*z/900.0;
            tmpz = Math.Sqrt(tmpx+tmpz);
            tmpy = 4*Math.Cos(3*tmpz)*Math.Exp(-0.5*tmpz);
            points3D1.Add(x,tmpy,z);
          }
        }
      }
      finally
      {
        points3D1.EndUpdate();
      }
    }
  
    public XYZ_Gridding()
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();

      Fill();
      Grid3DUtils.CreateGrid(points3D1,surface1,15);
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
			this.points3D1 = new Steema.TeeChart.Styles.Points3D();
			this.surface1 = new Steema.TeeChart.Styles.Surface();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(544, 56);
			this.textBox1.Text = "Small routine can do the \"gridding\" of arbitrary, floating XYZ data.\r\n\r\nThe gridd" +
				"ing algorithm creates a fixed, regular grid of aproximate values using XYZ data." +
				"";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 40);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 75;
			this.tChart1.Aspect.Elevation = 338;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 314;
			
			
			this.tChart1.Aspect.Zoom = 63;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.points3D1);
			this.tChart1.Series.Add(this.surface1);
			this.tChart1.Size = new System.Drawing.Size(544, 253);
			this.tChart1.Tools.Add(this.rotate1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
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
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// points3D1
			// 
			// 
			// points3D1.LinePen
			// 
			this.points3D1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.points3D1.LinePen.Visible = false;
			// 
			// points3D1.Marks
			// 
			// 
			// points3D1.Marks.Symbol
			// 
			// 
			// points3D1.Marks.Symbol.Shadow
			// 
			this.points3D1.Marks.Symbol.Shadow.Height = 1;
			this.points3D1.Marks.Symbol.Shadow.Visible = true;
			this.points3D1.Marks.Symbol.Shadow.Width = 1;
			// 
			// points3D1.Pointer
			// 
			// 
			// points3D1.Pointer.Brush
			// 
			this.points3D1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.points3D1.Pointer.HorizSize = 2;
			this.points3D1.Pointer.InflateMargins = false;
			// 
			// points3D1.Pointer.Pen
			// 
			this.points3D1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.points3D1.Pointer.Pen.Visible = false;
			this.points3D1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.points3D1.Pointer.VertSize = 2;
			this.points3D1.Title = "points3D1";
			this.points3D1.Visible = false;
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
			// surface1
			// 
			// 
			// surface1.Brush
			// 
			this.surface1.Brush.Color = System.Drawing.Color.Green;
			this.surface1.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// surface1.Marks
			// 
			// 
			// surface1.Marks.Symbol
			// 
			// 
			// surface1.Marks.Symbol.Shadow
			// 
			this.surface1.Marks.Symbol.Shadow.Height = 1;
			this.surface1.Marks.Symbol.Shadow.Visible = true;
			this.surface1.Marks.Symbol.Shadow.Width = 1;
			this.surface1.PaletteMin = 0;
			this.surface1.PaletteStep = 0;
			this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong;
			this.surface1.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.surface1.Title = "surface1";
			// 
			// surface1.XValues
			// 
			this.surface1.XValues.DataMember = "X";
			// 
			// surface1.YValues
			// 
			this.surface1.YValues.DataMember = "Y";
			// 
			// surface1.ZValues
			// 
			this.surface1.ZValues.DataMember = "Z";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Show:";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(104, 8);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 1;
			this.radioButton1.Text = "Original data";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(224, 8);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Surface";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
			// XYZ_gridding
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 349);
			this.Name = "XYZ_gridding";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
    #endregion

    private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
    {
      points3D1.Visible = radioButton1.Checked;
      surface1.Visible = !radioButton1.Checked;
    }

    private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
    {
      surface1.Visible = radioButton2.Checked;
      points3D1.Visible = !radioButton2.Checked;
    }
  }
}

