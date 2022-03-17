using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Export_SVG : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.Line line1;
    private Steema.TeeChart.Styles.Area area1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Button button2;
    private Steema.TeeChart.Tools.Annotation annotation1;
		private System.ComponentModel.IContainer components = null;

		public Export_SVG()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
      
            line1.FillSampleValues(10);
            area1.FillSampleValues(10);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_SVG));
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.area1 = new Steema.TeeChart.Styles.Area();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.annotation1 = new Steema.TeeChart.Tools.Annotation();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(440, 56);
            this.textBox1.Text = "Exporting to SVG (Scalable Vector Graphics) graphic format is available using the" +
                " Export Dialog or by code at run-time. ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 10;
            this.tChart1.Aspect.Perspective = 0;
            this.tChart1.Aspect.Rotation = 348;
            this.tChart1.Aspect.RotationFloat = 348;
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Axes.Bottom.MaximumOffset = 3;
            this.tChart1.Axes.Bottom.MinimumOffset = 3;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Axes.Right.MaximumOffset = 3;
            this.tChart1.Axes.Right.MinimumOffset = 3;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Visible = false;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Series.Add(this.area1);
            this.tChart1.Size = new System.Drawing.Size(440, 222);
            this.tChart1.Tools.Add(this.annotation1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Visible = false;
            this.tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.Transparency = 30;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Walls.Left.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 95);
            this.chartContainer.Size = new System.Drawing.Size(440, 222);
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.line1.ColorEach = true;
            // 
            // 
            // 
            this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.line1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.line1.Marks.Callout.Distance = 0;
            this.line1.Marks.Callout.Draw3D = false;
            this.line1.Marks.Callout.Length = 10;
            this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line1.Marks.Callout.Visible = false;
            // 
			// line1.Marks.Symbol.Shadow
            // 
			this.line1.Marks.Symbol.Shadow.Height = 1;
			this.line1.Marks.Symbol.Shadow.Visible = true;
			this.line1.Marks.Symbol.Shadow.Width = 1;
            // 
			// line1.Pointer
            // 
            this.line1.Pointer.HorizSize = 2;
            this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.line1.Pointer.VertSize = 2;
            this.line1.Pointer.Visible = true;
            this.line1.Title = "line1";
            this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
            // 
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
            // area1
            // 
            // 
            // 
            // 
            this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            // 
            // 
            // 
            this.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.area1.Gradient.Transparency = 50;
            // 
            // 
			this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
            // 
            this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            // 
			this.area1.AreaBrush.Gradient.Transparency = 50;
            // 
			// area1.Brush
            // 
			this.area1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
            this.area1.ColorEach = true;
            // 
            // 
            // 
            this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.area1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
			this.area1.Gradient.Transparency = 50;
            // 
            this.area1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.area1.Marks.Callout.Distance = 0;
            this.area1.Marks.Callout.Draw3D = false;
            this.area1.Marks.Callout.Length = 10;
            this.area1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            // 
            // 
			this.area1.Marks.Symbol.Shadow.Height = 1;
			this.area1.Marks.Symbol.Shadow.Visible = true;
			this.area1.Marks.Symbol.Shadow.Width = 1;
            // 
            this.area1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.area1.Title = "area1";
            // 
            // 
            // 
            this.area1.XValues.DataMember = "X";
            this.area1.XValues.DateTime = true;
            this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.area1.YValues.DataMember = "Y";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save to SVG";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(160, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show export dialog";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // annotation1
            // 
            this.annotation1.AutoSize = true;
            this.annotation1.Cursor = Drawing.Cursors.Default;
            this.annotation1.Left = 100;
            // 
            // 
            // 
            this.annotation1.Shape.BorderRound = 8;
            this.annotation1.Shape.Bottom = 41;
            // 
            // 
            // 
            this.annotation1.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.annotation1.Shape.Brush.Gradient.Transparency = 60;
            this.annotation1.Shape.CustomPosition = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.annotation1.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.annotation1.Shape.Font.Name = "Arial Black";
            this.annotation1.Shape.Left = 100;
            this.annotation1.Shape.Lines = new string[] {
        "SVG example"};
            this.annotation1.Shape.Right = 193;
            // 
            // 
            // 
            this.annotation1.Shape.Shadow.Visible = true;
            this.annotation1.Shape.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
            this.annotation1.Shape.Top = 20;
            this.annotation1.Text = "SVG example";
            this.annotation1.Top = 20;
            // 
            // Export_SVG
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Export_SVG";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

    private void button1_Click(object sender, System.EventArgs e)
    {
      saveFileDialog1.DefaultExt = tChart1.Export.Image.SVG.FileExtension;
      saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter=Texts.SVGFilter;
      if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        tChart1.Export.Image.SVG.Save( saveFileDialog1.FileName );
      }
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      tChart1.Export.ShowExportDialog(tChart1.Export.Image.SVG);
    }
	}
}

