using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ColorBandClicked : Steema.TeeChart.Samples.BaseForm
 {
		protected Steema.TeeChart.Tools.ColorBand colorBand1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;

		public ColorBandClicked () {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
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
            this.colorBand1 = new Steema.TeeChart.Tools.ColorBand();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "The ColorBand tool provides a Click event and a Clicked function that is triggere" +
                "d when clicking it.\r\n\r\nClick the white color band...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 40;
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Automatic = false;
            this.tChart1.Axes.Left.AutomaticMaximum = false;
            this.tChart1.Axes.Left.AutomaticMinimum = false;
            this.tChart1.Axes.Left.Maximum = 1000;
            this.tChart1.Axes.Left.Minimum = 0;
            this.tChart1.Cursor = Cursors.Default;
            // 
            // 
            // 
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            this.tChart1.Tools.Add(this.colorBand1);
            // 
            // 
            // 
            // 
            // 
            // 
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
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 3;
            this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
            // 
            // colorBand1
            // 
            this.colorBand1.Axis = this.tChart1.Axes.Left;
            this.colorBand1.DrawBehind = false;
            this.colorBand1.End = 800;
            this.colorBand1.ResizeEnd = false;
            this.colorBand1.ResizeStart = false;
            this.colorBand1.Start = 400;
            this.colorBand1.Click += this.colorBand1_Click;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clicked:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(72, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 1;
            // 
            // ColorBandClicked
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "ColorBandClicked";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void colorBand1_Click(object sender, Drawing.MouseEventArgs e) {
			Random rnd = new Random();
			label2.Text="Clicked at X:"+e.X.ToString()+" Y:"+e.Y.ToString();

			colorBand1.Color=Color.FromArgb(rnd.Next(255),rnd.Next(255),rnd.Next(255));
		}

		private void tChart1_MouseMove(object sender, MouseEventArgs e) {
			if(colorBand1.Clicked(e.X, e.Y)) 
				tChart1.Cursor = Cursors.Hand;
			else
				tChart1.Cursor = Cursors.Default;
		}
	}
}

