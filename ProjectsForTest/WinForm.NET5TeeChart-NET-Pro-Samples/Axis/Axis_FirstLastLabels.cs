using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class AxisFirstLastLabels : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Line line1;
		private System.ComponentModel.IContainer components = null;

		public AxisFirstLastLabels()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			line1.Clear();
			line1.Add(123, "First");
			line1.Add(456, "Second");
			line1.Add(321, "Third");
			line1.Add(234, "Last");

	
			tChart1.Axes.Bottom.GetAxisDrawLabel += new Steema.TeeChart.GetAxisDrawLabelEventHandler(Bottom_GetAxisDrawLabel);
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
						this.checkBox1 = new System.Windows.Forms.CheckBox();
						this.line1 = new Steema.TeeChart.Styles.Line();
						this.panel1.SuspendLayout();
						this.SuspendLayout();
						// 
						// textBox1
						// 
						this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
						this.textBox1.Name = "textBox1";
						this.textBox1.Text = "The Axis \"GetAxisDrawLabel\" event can be used for multiple purposes.\r\nIt is calle" +
							"d just before the axis is going to draw a label.\r\n\r\nThis example shows how to se" +
							"t a different text alignment for the first and\r\nlast labels of the bottom axis.";
						// 
						// panel1
						// 
						this.panel1.BackColor = System.Drawing.SystemColors.Control;
						this.panel1.Controls.Add(this.checkBox1);
						this.panel1.Name = "panel1";
						// 
						// tChart1
						// 
						// 
						// tChart1.Header
						// 
						this.tChart1.Header.Lines = new string[] {
																	 "TeeChart"};
						this.tChart1.Name = "tChart1";
						// 
						// tChart1.Panel
						// 
						// 
						// tChart1.Panel.Brush
						// 
						// 
						// tChart1.Panel.Gradient
						// 
						this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
						this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
						this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
						this.tChart1.Panel.Brush.Gradient.Visible = true;
						// 
						// tChart1.Panel.Gradient
						// 
						this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
						this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
						this.tChart1.Panel.Gradient.UseMiddle = true;
						this.tChart1.Panel.Gradient.Visible = true;
						this.tChart1.Series.Add(this.line1);
						// 
						// checkBox1
						// 
						this.checkBox1.Checked = true;
						this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
						this.checkBox1.Location = new System.Drawing.Point(16, 8);
						this.checkBox1.Name = "checkBox1";
						this.checkBox1.Size = new System.Drawing.Size(248, 24);
						this.checkBox1.TabIndex = 0;
						this.checkBox1.Text = "First and last bottom axis labels aligned";
						this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
						// 
						// line1
						// 
						// 
						// line1.Brush
						// 
						this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
						this.line1.ColorEach = true;
						// 
						// line1.LinePen
						// 
						this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(61)), ((System.Byte)(92)), ((System.Byte)(153)));
						// 
						// line1.Pointer
						// 						
						this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
						this.line1.Pointer.Visible = true;
						this.line1.Title = "line1";
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
						// AxisFirstLastLabels
						// 
						this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
						this.ClientSize = new System.Drawing.Size(440, 317);
						this.Name = "AxisFirstLastLabels";
						this.panel1.ResumeLayout(false);
						this.ResumeLayout(false);

					}
		#endregion

		private void Bottom_GetAxisDrawLabel(object sender, Steema.TeeChart.GetAxisDrawLabelEventArgs e) 
		{
			Steema.TeeChart.Axis bottom = sender as Steema.TeeChart.Axis;
			bottom.Labels.Font.Bold = false;
			if(this.checkBox1.Checked) 
			{
				if(e.X == bottom.CalcPosValue(bottom.Minimum))	 
				{
					bottom.Chart.Graphics3D.TextAlign =	Drawing.StringAlignment.Near;
					bottom.Labels.Font.Bold = true;
				}	 
				else
					if(e.X == bottom.CalcPosValue(bottom.Maximum)) 
				{
					bottom.Chart.Graphics3D.TextAlign =	Drawing.StringAlignment.Far;
					bottom.Labels.Font.Bold = true;
				}
				else bottom.Labels.Font.Bold = false;
			}
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			 tChart1.Refresh();
		}
	}
}

