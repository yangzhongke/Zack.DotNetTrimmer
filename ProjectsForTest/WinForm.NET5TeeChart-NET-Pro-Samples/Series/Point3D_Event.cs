using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Point3D_Event : Samples.BaseForm
  {
    private Steema.TeeChart.Styles.Points3D point3DSeries1;
    private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
    private System.ComponentModel.IContainer components = null;

    public Point3D_Event()
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();

      point3DSeries1.FillSampleValues(20);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Point3D_Event));
			this.point3DSeries1 = new Steema.TeeChart.Styles.Points3D();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(466, 32);
			this.textBox1.Text = "Point 3D series has an event to supply each point style, color, etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 32);
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.Chart3DPercent = 100;
			this.tChart1.Aspect.Elevation = 355;
			this.tChart1.Aspect.ElevationFloat = 355;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 76;
			this.tChart1.Aspect.Rotation = 336;
			this.tChart1.Aspect.RotationFloat = 336;
			this.tChart1.Aspect.ZOffset = 0;
			this.tChart1.Aspect.Zoom = 66;
			this.tChart1.Aspect.ZoomFloat = 66;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.MaximumOffset = 15;
			this.tChart1.Axes.Bottom.MinimumOffset = 15;
			// 
			// 
			// 
			this.tChart1.Axes.Left.MaximumOffset = 15;
			this.tChart1.Axes.Left.MinimumOffset = 15;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "Custom Point3D series pointer styles"};
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Series.Add(this.point3DSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 221);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 40;
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
			// 
			// 
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 40;
			// 
			// 
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 65);
			this.chartContainer.Size = new System.Drawing.Size(466, 221);
			// 
			// point3DSeries1
			// 
			this.point3DSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.point3DSeries1.ColorEach = true;
			// 
			// 
			// 
			this.point3DSeries1.LinePen.Color = System.Drawing.Color.Brown;
			// 
			// 
			// 
			// 
			// 
			// 
			this.point3DSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.point3DSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.point3DSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.point3DSeries1.Marks.Callout.Distance = 0;
			this.point3DSeries1.Marks.Callout.Draw3D = false;
			this.point3DSeries1.Marks.Callout.Length = 10;
			this.point3DSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.point3DSeries1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.point3DSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			// 
			// 
			// 
			this.point3DSeries1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.point3DSeries1.Pointer.HorizSize = 14;
			// 
			// 
			// 
			this.point3DSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.point3DSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.point3DSeries1.Pointer.VertSize = 14;
			this.point3DSeries1.Title = "point3DSeries1";
			// 
			// 
			// 
			this.point3DSeries1.XValues.DataMember = "X";
			// 
			// 
			// 
			this.point3DSeries1.YValues.DataMember = "Y";
			// 
			// 
			// 
			this.point3DSeries1.ZValues.DataMember = "Z";
			this.point3DSeries1.GetPointerStyle += new Steema.TeeChart.Styles.Points3D.GetPointerStyleEventHandler(this.point3DSeries1_GetPointerStyle);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(24, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(87, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Use event";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// 
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			// 
			// 
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// Point3D_Event
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Point3D_Event";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
    #endregion

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      point3DSeries1.Repaint();
    }

		private void point3DSeries1_GetPointerStyle(Steema.TeeChart.Styles.Points3D series, Steema.TeeChart.Styles.GetPointerStyleEventArgs e)
		{
      e.Style=Styles.PointerStyles.Rectangle;

      if (checkBox1.Checked)
        switch (e.ValueIndex % 3)
        {
          case 0: { e.Style=Styles.PointerStyles.Circle; point3DSeries1.Pointer.Brush.Color=Color.Red; } break;
          case 1: { e.Style=Styles.PointerStyles.Triangle; point3DSeries1.Pointer.Brush.Color=Color.Blue; } break;
          case 2: { e.Style=Styles.PointerStyles.Rectangle; point3DSeries1.Pointer.Brush.Color=Color.Yellow; } break;
          default:  
          {
            e.Style=Styles.PointerStyles.Rectangle;
            point3DSeries1.Pointer.Brush.Color=Color.Empty;
          } break;
        }
    }
  }
}
