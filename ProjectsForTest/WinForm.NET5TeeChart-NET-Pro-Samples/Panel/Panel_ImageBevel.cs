using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class PanelImageBevel : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Button bEdit;
		private Steema.TeeChart.Styles.Pie pie1;
		private System.ComponentModel.IContainer components = null;

		public PanelImageBevel()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			pie1.FillSampleValues();
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
			this.bEdit = new System.Windows.Forms.Button();
			this.pie1 = new Steema.TeeChart.Styles.Pie();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Image Bevels are an alternative to standard Windows bevels and \r\ncan be configure" +
				"d to any number of interesting combinations to give\r\nthat extra touch to your ch" +
				"arts.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bEdit);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 70;
			this.tChart1.Aspect.Elevation = 333;
			this.tChart1.Aspect.HorizOffset = -12;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 46;
			this.tChart1.Aspect.Rotation = 342;
			
			
			this.tChart1.Aspect.VertOffset = -12;
			this.tChart1.Aspect.Zoom = 79;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.AxisPen
			// 
			this.tChart1.Axes.Bottom.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(185)), ((System.Byte)(185)));
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Bold = true;
			// 
			// tChart1.Axes.Bottom.Labels.Font.Brush
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Tahoma";
			// 
			// tChart1.Axes.Bottom.MinorGrid
			// 
			this.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(((System.Byte)(229)), ((System.Byte)(229)), ((System.Byte)(229)));
			this.tChart1.Axes.Bottom.MinorGrid.Visible = true;
			this.tChart1.Axes.Bottom.MinorTickCount = 7;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Length = 5;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Length = 2;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.Navy;
			this.tChart1.Axes.Left.AxisPen.Width = 1;
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Blue;
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			this.tChart1.Axes.Left.Labels.Font.Bold = true;
			// 
			// tChart1.Axes.Left.Labels.Font.Brush
			// 
			this.tChart1.Axes.Left.Labels.Font.Name = "Tahoma";
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Length = 2;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Length = 2;
			this.tChart1.Axes.Right.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.AxisPen
			// 
			this.tChart1.Axes.Top.AxisPen.Visible = false;
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Gray;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Length = 2;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Black;
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(64)));
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Brush.Gradient.UseMiddle = true;
			this.tChart1.Header.Brush.Gradient.Visible = true;
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Navy;
			this.tChart1.Header.Font.Name = "Verdana";
			this.tChart1.Header.Font.Size = 12;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Black;
			this.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(64)));
			this.tChart1.Header.Gradient.StartColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Gradient.UseMiddle = true;
			this.tChart1.Header.Gradient.Visible = true;
			this.tChart1.Header.Lines = new string[] {
																								 "Image Bevels"};
			// 
			// tChart1.Header.Pen
			// 
			this.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(221)), ((System.Byte)(251)));
			this.tChart1.Header.Pen.Width = 2;
			// 
			// tChart1.Header.Shadow
			// 
			// 
			// tChart1.Header.Shadow.Brush
			// 
			this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(169)), ((System.Byte)(169)), ((System.Byte)(169)));
			this.tChart1.Header.Shadow.Height = 4;
			this.tChart1.Header.Shadow.Width = 4;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(206)), ((System.Byte)(219)), ((System.Byte)(255)));
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(230)), ((System.Byte)(233)));
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(243)), ((System.Byte)(234)));
			this.tChart1.Legend.Brush.Gradient.UseMiddle = true;
			this.tChart1.Legend.Brush.Gradient.Visible = true;
			// 
			// tChart1.Legend.DividingLines
			// 
			this.tChart1.Legend.DividingLines.Color = System.Drawing.Color.Silver;
			this.tChart1.Legend.DividingLines.Visible = true;
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Brush
			// 
			this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(100)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			this.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(206)), ((System.Byte)(219)), ((System.Byte)(255)));
			this.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(230)), ((System.Byte)(233)));
			this.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(243)), ((System.Byte)(234)));
			this.tChart1.Legend.Gradient.UseMiddle = true;
			this.tChart1.Legend.Gradient.Visible = true;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Shadow.Height = 4;
			this.tChart1.Legend.Shadow.Width = 5;
			// 
			// tChart1.Legend.Symbol
			// 
			this.tChart1.Legend.Symbol.Squared = true;
			this.tChart1.Legend.Visible = false;
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
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(165)), ((System.Byte)(3)), ((System.Byte)(32)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(165)), ((System.Byte)(3)), ((System.Byte)(32)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			// 
			// tChart1.Panel.ImageBevel
			// 
			// 
			// tChart1.Panel.ImageBevel.Brush
			// 
			this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(208)));
			this.tChart1.Panel.ImageBevel.Brush.ForegroundColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.ImageBevel.Brush.Solid = false;
			this.tChart1.Panel.ImageBevel.Brush.Style = Drawing.HatchStyle.Shingle;
			// 
			// tChart1.Panel.ImageBevel.Pen
			// 
			this.tChart1.Panel.ImageBevel.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Panel.ImageBevel.Pen.Transparency = 50;
			this.tChart1.Panel.ImageBevel.Pen.Visible = false;
			this.tChart1.Panel.ImageBevel.Pen.Width = 2;
			this.tChart1.Panel.ImageBevel.Visible = true;
			this.tChart1.Panel.ImageBevel.Width = 18;
			// 
			// tChart1.Panel.Pen
			// 
			this.tChart1.Panel.Pen.Color = System.Drawing.Color.Navy;
			this.tChart1.Panel.Pen.Width = 6;
			// 
			// tChart1.Panel.Shadow
			// 
			// 
			// tChart1.Panel.Shadow.Brush
			// 
			this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Panel.Shadow.Height = 7;
			this.tChart1.Panel.Shadow.Visible = true;
			this.tChart1.Panel.Shadow.Width = 7;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(207)), ((System.Byte)(236)), ((System.Byte)(252)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 80;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 80;
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			this.tChart1.Walls.Back.Size = 5;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
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
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(53)), ((System.Byte)(53)), ((System.Byte)(0)));
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
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver;
			this.tChart1.Walls.Right.Size = 5;
			// 
			// bEdit
			// 
			this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bEdit.Location = new System.Drawing.Point(16, 8);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(72, 23);
			this.bEdit.TabIndex = 0;
			this.bEdit.Text = "Edit...";
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// pie1
			// 
			// 
			// pie1.Brush
			// 
			this.pie1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(204)));
			// 
			// pie1.Marks
			// 
			// 
			// pie1.Marks.Symbol
			// 
			// 
			// pie1.Marks.Symbol.Shadow
			// 
			this.pie1.Marks.Symbol.Shadow.Height = 1;
			this.pie1.Marks.Symbol.Shadow.Visible = true;
			this.pie1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pie1.Shadow
			// 
			this.pie1.Shadow.Height = 20;
			this.pie1.Shadow.Width = 20;
			this.pie1.Title = "pie1";
			// 
			// pie1.XValues
			// 
			this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// PanelImageBevel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "PanelImageBevel";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void bEdit_Click(object sender, System.EventArgs e)
    {
      Steema.TeeChart.Editors.BevelImageEditor editor = new Steema.TeeChart.Editors.BevelImageEditor(tChart1.Panel.ImageBevel, null);
      Steema.TeeChart.Editors.EditorUtils.Translate(editor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor);
    }
	}
}

