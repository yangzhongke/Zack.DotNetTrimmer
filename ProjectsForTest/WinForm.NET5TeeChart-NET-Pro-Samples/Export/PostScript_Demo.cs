using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class PostScript_Demo : Steema.TeeChart.Samples.BaseForm
	{
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private Steema.TeeChart.Styles.TriSurface triSurface1;
		private System.ComponentModel.IContainer components = null;

		public PostScript_Demo()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			triSurface1.FillSampleValues(20);
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.triSurface1 = new Steema.TeeChart.Styles.TriSurface();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "New PSCanvas.cs unit which allows exporting to Encapsulated PostScript format (EP" +
				"S).";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 100;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 333;
			
			
			this.tChart1.Aspect.Zoom = 71;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Bottom = 23;
			this.tChart1.Header.CustomPosition = true;
			this.tChart1.Header.Left = 0;
			this.tChart1.Header.Lines = new string[] {
																								 "EPS export"};
			this.tChart1.Header.Right = 72;
			this.tChart1.Header.Top = 9;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Series.Add(this.triSurface1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 50;
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
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 50;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Save to EPS";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(160, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Show export dialog";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// triSurface1
			// 
			// 
			// triSurface1.Brush
			// 
			this.triSurface1.Brush.Color = System.Drawing.Color.Red;
			// 
			// triSurface1.Marks
			// 
			// 
			// triSurface1.Marks.Symbol
			// 
			// 
			// triSurface1.Marks.Symbol.Shadow
			// 
			this.triSurface1.Marks.Symbol.Shadow.Height = 1;
			this.triSurface1.Marks.Symbol.Shadow.Visible = true;
			this.triSurface1.Marks.Symbol.Shadow.Width = 1;
			this.triSurface1.PaletteMin = 0;
			this.triSurface1.PaletteStep = 0;
			this.triSurface1.Title = "triSurface1";
			this.triSurface1.UseColorRange = false;
			this.triSurface1.UsePalette = true;
			// 
			// triSurface1.XValues
			// 
			this.triSurface1.XValues.DataMember = "X";
			// 
			// triSurface1.YValues
			// 
			this.triSurface1.YValues.DataMember = "Y";
			// 
			// triSurface1.ZValues
			// 
			this.triSurface1.ZValues.DataMember = "Z";
			// 
			// ExportEPS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "ExportEPS";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void button1_Click(object sender, System.EventArgs e)
    {
      saveFileDialog1.DefaultExt = tChart1.Export.Image.EPS.FileExtension;
      saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter=Texts.PSFilter;
      if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        tChart1.Export.Image.EPS.Save( saveFileDialog1.FileName );
      }
    
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      tChart1.Export.ShowExportDialog(tChart1.Export.Image.EPS);
    }
	}
}

