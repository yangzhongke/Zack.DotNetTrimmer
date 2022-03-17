using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Circled_Gradient : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Polar polar1;
		private System.ComponentModel.IContainer components = null;

		public Circled_Gradient()
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circled_Gradient));
			this.button1 = new System.Windows.Forms.Button();
			this.polar1 = new Steema.TeeChart.Styles.Polar();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "New Gradient property for \"Circled\" series like Smith, Polar, Radar, Clock and  W" +
					"ind-Rose.  ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.ElevationFloat = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			this.tChart1.Aspect.RotationFloat = 360;
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Aspect.ZOffset = 0;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[0];
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
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Series.Add(this.polar1);
			this.tChart1.Size = new System.Drawing.Size(440, 205);
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
			// 
			// 
			this.polar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.polar1.Circled = true;
			// 
			// 
			// 
			this.polar1.CircleGradient.Visible = true;
			this.polar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.polar1.ColorEach = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.polar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.polar1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.polar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.polar1.Marks.Callout.Distance = 0;
			this.polar1.Marks.Callout.Draw3D = false;
			this.polar1.Marks.Callout.Length = 10;
			this.polar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polar1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			this.polar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.polar1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.polar1.Title = "polar1";
			// 
			// 
			// 
			this.polar1.XValues.DataMember = "Angle";
			this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.polar1.YValues.DataMember = "Y";
			// 
			// Circled_Gradient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Circled_Gradient";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.GradientEditor.Edit(polar1.CircleGradient);
		}
	}
}

