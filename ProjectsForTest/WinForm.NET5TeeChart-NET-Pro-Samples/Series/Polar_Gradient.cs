using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Polar_Gradient : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Polar polar1;
		private System.ComponentModel.IContainer components = null;

		public Polar_Gradient()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			polar1.FillSampleValues();
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
			this.polar1 = new Steema.TeeChart.Styles.Polar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "New Gradient property for \"Circled\" series like Smith, Polar, Radar, Clock and  W" +
				"ind-Rose.  ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[0];
			// 
			// tChart1.Legend
			// 
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
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.polar1);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Edit Gradient...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// polar1
			// 
			// 
			// polar1.Brush
			// 
			this.polar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.polar1.Circled = true;
			// 
			// polar1.Marks
			// 
			// 
			// polar1.Marks.Symbol
			// 
			// 
			// polar1.Marks.Symbol.Shadow
			// 
			this.polar1.Marks.Symbol.Shadow.Height = 1;
			this.polar1.Marks.Symbol.Shadow.Visible = true;
			this.polar1.Marks.Symbol.Shadow.Width = 1;
			// 
			// polar1.Pen
			// 
			this.polar1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// polar1.Pointer
			// 
			// 
			// polar1.Pointer.Brush
			// 
			this.polar1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polar1.Title = "polar1";
			// 
			// polar1.XValues
			// 
			this.polar1.XValues.DataMember = "Angle";
			this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// polar1.YValues
			// 
			this.polar1.YValues.DataMember = "Y";
			// 
			// Polar_Gradient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Polar_Gradient";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.GradientEditor.Edit(polar1.CircleGradient);
		}
	}
}

