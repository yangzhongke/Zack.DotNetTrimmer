using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Canvas_Transparency : Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label2;
		private Steema.TeeChart.Styles.Bubble bubble1;
		private System.ComponentModel.IContainer components = null;

		public Canvas_Transparency()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			bubble1.FillSampleValues(10);
      tChart1.Panel.Gradient.Visible = false;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Canvas_Transparency));
			this.label1 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.bubble1 = new Steema.TeeChart.Styles.Bubble();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 64);
			this.textBox1.Text = "The Chart Legend, Titles ( Title, SubTitle, Foot and SubFoot ) and the BackWall (" +
				"in 2D mode), can \"blend\" with the chart background ( transparency ).\r\n\r\nExample:" +
				" tChart1.Legend.Transparency = 50 ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.tChart1.Header.Font.Italic = true;
			// 
			// tChart1.Header.Font.Shadow
			// 
			// 
			// tChart1.Header.Font.Shadow.Brush
			// 
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Header.Font.Shadow.Visible = true;
			this.tChart1.Header.Font.Size = 12;
			this.tChart1.Header.Lines = new string[] {
																								 "Title with transparency"};
			// 
			// tChart1.Header.Shadow
			// 
			this.tChart1.Header.Shadow.Height = 2;
			this.tChart1.Header.Shadow.Width = 2;
			this.tChart1.Header.Transparent = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Location = new System.Drawing.Point(0, 97);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			//this.tChart1.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("tChart1.Panel.Brush.Image")));
			this.tChart1.Panel.Brush.Solid = false;
			//this.tChart1.Panel.Image = ((System.Drawing.Image)(resources.GetObject("tChart1.Panel.Image")));
			this.tChart1.Series.Add(this.bubble1);
			this.tChart1.Size = new System.Drawing.Size(466, 189);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 70;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 70;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 70;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Transparency %";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(104, 8);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(127, 14);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Value = 70;
			this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(240, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "70";
			this.label2.UseMnemonic = false;
			// 
			// bubble1
			// 
			this.bubble1.LabelMember = "Labels";
			// 
			// bubble1.Marks
			// 
			// 
			// bubble1.Marks.Symbol
			// 
			// 
			// bubble1.Marks.Symbol.Shadow
			// 
			this.bubble1.Marks.Symbol.Shadow.Height = 1;
			this.bubble1.Marks.Symbol.Shadow.Visible = true;
			this.bubble1.Marks.Symbol.Shadow.Width = 1;
			this.bubble1.Marks.Transparent = true;
			// 
			// bubble1.Pointer
			// 
			// 
			// bubble1.Pointer.Brush
			// 
			this.bubble1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			this.bubble1.Pointer.HorizSize = 11;
			this.bubble1.Pointer.InflateMargins = false;
			this.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.bubble1.Pointer.VertSize = 11;
			this.bubble1.Title = "bubble1";
			// 
			// bubble1.XValues
			// 
			this.bubble1.XValues.DataMember = "X";
			this.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bubble1.YValues
			// 
			this.bubble1.YValues.DataMember = "Y";
			// 
			// Canvas_Transp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Canvas_Transp";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void hScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
      int t=(int)hScrollBar1.Value;
			tChart1.Header.Transparency = t;
			tChart1.Legend.Transparency = t;
      tChart1.Legend.Shadow.Transparency = t;
			tChart1.Walls.Left.Transparency = t;
			tChart1.Walls.Bottom.Transparency = t;
      tChart1.Walls.Back.Transparency = t;
			label2.Text = t.ToString();		
		}
	}
}

