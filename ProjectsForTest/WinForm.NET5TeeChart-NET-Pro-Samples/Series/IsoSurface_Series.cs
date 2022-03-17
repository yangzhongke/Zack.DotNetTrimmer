using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class IsoSurface_Series : BaseForm
	{
    private GroupBox groupBox1;
    private RadioButton rbDotGrid;
    private RadioButton rbWireFrame;
    private RadioButton rbNormal;
    private Steema.TeeChart.Styles.IsoSurface isoSurface1;
    private CheckBox cbSides;
    private Button bEdit;

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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsoSurface_Series));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbDotGrid = new System.Windows.Forms.RadioButton();
      this.rbWireFrame = new System.Windows.Forms.RadioButton();
      this.rbNormal = new System.Windows.Forms.RadioButton();
      this.isoSurface1 = new Steema.TeeChart.Styles.IsoSurface();
      this.cbSides = new System.Windows.Forms.CheckBox();
      this.bEdit = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = "The new IsoSurface Series enables the visualization of 3D data in a \'map\' like fa" +
          "shion.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.bEdit);
      this.panel1.Controls.Add(this.cbSides);
      this.panel1.Controls.Add(this.groupBox1);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.Orthogonal = false;
      
      
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Header.Brush.Gradient.UseMiddle = true;
      this.tChart1.Header.Lines = new string[] {
        "IsoSurface Series"};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Legend.Brush.Gradient.UseMiddle = true;
      this.tChart1.Legend.MaxNumRows = 8;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
      this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.Sigma = true;
      this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
      this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Series.Add(this.isoSurface1);
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
      // 
      // 
      // 
      this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Back.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Bottom.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Left.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.tChart1.Walls.Right.Brush.Gradient.UseMiddle = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbDotGrid);
      this.groupBox1.Controls.Add(this.rbWireFrame);
      this.groupBox1.Controls.Add(this.rbNormal);
      this.groupBox1.Location = new System.Drawing.Point(12, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(231, 33);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Style";
      // 
      // rbDotGrid
      // 
      this.rbDotGrid.Location = new System.Drawing.Point(168, 13);
      this.rbDotGrid.Name = "rbDotGrid";
      this.rbDotGrid.Size = new System.Drawing.Size(61, 17);
      this.rbDotGrid.TabIndex = 2;
      this.rbDotGrid.Text = "DotGrid";
      this.rbDotGrid.CheckedChanged += new System.EventHandler(this.rbDotGrid_CheckedChanged);
      // 
      // rbWireFrame
      // 
      this.rbWireFrame.Location = new System.Drawing.Point(80, 13);
      this.rbWireFrame.Name = "rbWireFrame";
      this.rbWireFrame.Size = new System.Drawing.Size(82, 17);
      this.rbWireFrame.TabIndex = 1;
      this.rbWireFrame.Text = "WireFrame";
      this.rbWireFrame.CheckedChanged += new System.EventHandler(this.rbWireFrame_CheckedChanged);
      // 
      // rbNormal
      // 
      this.rbNormal.Checked = true;
      this.rbNormal.Location = new System.Drawing.Point(6, 13);
      this.rbNormal.Name = "rbNormal";
      this.rbNormal.Size = new System.Drawing.Size(66, 17);
      this.rbNormal.TabIndex = 0;
      this.rbNormal.TabStop = true;
      this.rbNormal.Text = "Normal";
      this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
      // 
      // isoSurface1
      // 
      // 
      // 
      // 
      this.isoSurface1.BandPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      // 
      // 
      // 
      this.isoSurface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.isoSurface1.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.isoSurface1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.isoSurface1.Marks.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.isoSurface1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
      this.isoSurface1.Marks.Callout.Distance = 0;
      this.isoSurface1.Marks.Callout.Draw3D = false;
      this.isoSurface1.Marks.Callout.Length = 10;
      this.isoSurface1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.isoSurface1.PaletteMin = 0;
      this.isoSurface1.PaletteStep = 0;
      this.isoSurface1.PaletteSteps = 20;
      // 
      // 
      // 
      this.isoSurface1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.isoSurface1.Title = "iso-Surface1";
      this.isoSurface1.UseColorRange = false;
      this.isoSurface1.UsePalette = true;
      // 
      // 
      // 
      this.isoSurface1.XValues.DataMember = "X";
      // 
      // 
      // 
      this.isoSurface1.YValues.DataMember = "Y";
      // 
      // 
      // 
      this.isoSurface1.ZValues.DataMember = "Z";
      // 
      // cbSides
      // 
      this.cbSides.Location = new System.Drawing.Point(249, 16);
      this.cbSides.Name = "cbSides";
      this.cbSides.Size = new System.Drawing.Size(82, 17);
      this.cbSides.TabIndex = 3;
      this.cbSides.Text = "Show Sides";
      this.cbSides.CheckedChanged += new System.EventHandler(this.cbSides_CheckedChanged);
      // 
      // bEdit
      // 
      this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.bEdit.Location = new System.Drawing.Point(337, 10);
      this.bEdit.Name = "bEdit";
      this.bEdit.Size = new System.Drawing.Size(75, 23);
      this.bEdit.TabIndex = 2;
      this.bEdit.Text = "Edit...";
      this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
      // 
      // IsoSurface_Series
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "IsoSurface_Series";
      this.Text = "IsoSurface_Series";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		public IsoSurface_Series()
		{
			InitializeComponent();
      InitializeChart();

		}

    private void InitializeChart()
    {
      isoSurface1.Brush.Transparency = 0;
      isoSurface1.BandPen.Visible = true;
      isoSurface1.FillSampleValues();
    }

    private void Normalize()
    {
      isoSurface1.UseColorRange = false;
      isoSurface1.UsePalette = false;
      isoSurface1.WireFrame = false;
      isoSurface1.DotFrame = false;
    }

    private void rbNormal_CheckedChanged(object sender, EventArgs e)
    {
      isoSurface1.WireFrame = false;
      isoSurface1.DotFrame = false;
    }

    private void rbWireFrame_CheckedChanged(object sender, EventArgs e)
    {
      isoSurface1.WireFrame = rbWireFrame.Checked;
    }

    private void rbDotGrid_CheckedChanged(object sender, EventArgs e)
    {
      isoSurface1.DotFrame = rbDotGrid.Checked;
    }

    private void cbSides_CheckedChanged(object sender, EventArgs e)
    {
      isoSurface1.SideBrush.Visible = cbSides.Checked;
    }

    private void bEdit_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.Series.IsoSurfaceEditor form = new Steema.TeeChart.Editors.Series.IsoSurfaceEditor(isoSurface1);
      Steema.TeeChart.Editors.EditorUtils.Translate(form);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(form);
    }
	}
}