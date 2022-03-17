using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Canvas_GradRadialCenter : Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.TrackBar trackBar2;
    private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;

		public Canvas_GradRadialCenter()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 72);
			this.textBox1.Text = "The center position of Radial gradients can be customized with the new Canvas Rad" +
				"ialGradientOffset property:\r\n\r\nChart1.Walls.Back.Gradient.RadialX := 123 ;  // <" +
				"-- pixels ( + or - )\r\nChart1.Walls.Back.Gradient.RadialY := - 321 ;  // <-- pixe" +
				"ls ( + or - )";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.trackBar2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 40;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Radial gradient center offset"};
			this.tChart1.Location = new System.Drawing.Point(0, 105);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			// 
			// tChart1.Panel.Brush.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Size = new System.Drawing.Size(466, 181);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			// 
			// tChart1.Walls.Back.Brush.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.SigmaFocus = 0.505F;
			this.tChart1.Walls.Back.Brush.Gradient.SigmaScale = 0.953F;
			this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Walls.Back.Brush.Gradient.Visible = true;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Horiz:";
			this.label1.UseMnemonic = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(328, 6);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// trackBar1
			// 
			this.trackBar1.AutoSize = false;
			this.trackBar1.LargeChange = 10;
			this.trackBar1.Location = new System.Drawing.Point(48, 8);
			this.trackBar1.Maximum = 300;
			this.trackBar1.Minimum = -300;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(88, 21);
			this.trackBar1.SmallChange = 10;
			this.trackBar1.TabIndex = 4;
			this.trackBar1.TickFrequency = 30;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// trackBar2
			// 
			this.trackBar2.AutoSize = false;
			this.trackBar2.LargeChange = 10;
			this.trackBar2.Location = new System.Drawing.Point(193, 8);
			this.trackBar2.Maximum = 300;
			this.trackBar2.Minimum = -300;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(87, 21);
			this.trackBar2.SmallChange = 10;
			this.trackBar2.TabIndex = 6;
			this.trackBar2.TickFrequency = 30;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(153, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Horiz:";
			this.label2.UseMnemonic = false;
			// 
			// Canvas_GradRadialCenter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Canvas_GradRadialCenter";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();

		}
		#endregion


    private void button1_Click(object sender, System.EventArgs e)
    {
      TeeChart.Editors.GradientEditor.Edit(tChart1.Walls.Back.Gradient);
    }

    private void trackBar2_Scroll(object sender, System.EventArgs e)
    {
    }

    private void trackBar1_Scroll(object sender, System.EventArgs e)
    {
    }
	}
}
