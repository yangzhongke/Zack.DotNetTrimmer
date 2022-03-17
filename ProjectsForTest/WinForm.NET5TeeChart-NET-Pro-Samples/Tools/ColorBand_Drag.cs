using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ColorBandDrag : Steema.TeeChart.Samples.ColorBandClicked {
		private Steema.TeeChart.ButtonPen BPStart;
		private Steema.TeeChart.ButtonPen BPEnd;
		private System.ComponentModel.IContainer components = null;

		public ColorBandDrag() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			BPStart.Pen = colorBand1.StartLinePen;
			BPEnd.Pen = colorBand1.EndLinePen;

			colorBand1.ResizeStart=true;
		  colorBand1.ResizeEnd=true;

			tChart1.Aspect.View3D = false;


		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
		private void InitializeComponent() {
			this.BPStart = new Steema.TeeChart.ButtonPen();
			this.BPEnd = new Steema.TeeChart.ButtonPen();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The ColorBand tool allows dragging its start or end edges.\r\n\r\ncolorBand1.ResizeSt" +
				"art = true ;\r\ncolorBand1.ResizeEnd = true ;\r\n\r\nDrag the color band edges...\r\n";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BPEnd);
			this.panel1.Controls.Add(this.BPStart);
			this.panel1.Name = "panel1";
			this.panel1.Controls.SetChildIndex(this.BPStart, 0);
			this.panel1.Controls.SetChildIndex(this.BPEnd, 0);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 40;
			
			
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.Automatic = false;
			this.tChart1.Axes.Left.AutomaticMaximum = false;
			this.tChart1.Axes.Left.AutomaticMinimum = false;
			this.tChart1.Axes.Left.Maximum = 1000;
			this.tChart1.Axes.Left.Minimum = 0;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
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
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// BPStart
			// 
			this.BPStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BPStart.Location = new System.Drawing.Point(224, 8);
			this.BPStart.Name = "BPStart";
			this.BPStart.TabIndex = 2;
			this.BPStart.Text = "&Start Pen...";
			// 
			// BPEnd
			// 
			this.BPEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BPEnd.Location = new System.Drawing.Point(312, 8);
			this.BPEnd.Name = "BPEnd";
			this.BPEnd.TabIndex = 3;
			this.BPEnd.Text = "&End Pen...";
			// 
			// ColorBandDrag
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "ColorBandDrag";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

	}
}

