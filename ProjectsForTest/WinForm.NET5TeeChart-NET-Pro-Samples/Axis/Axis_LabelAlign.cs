using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Axis_LabelAlign : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.HorizBar horizBar1;
		private System.ComponentModel.IContainer components = null;

		public Axis_LabelAlign()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			// Sample values 
			this.horizBar1.Add(278, "Africa");
  		this.horizBar1.Add( 123, "America");
  		this.horizBar1.Add( 321, "Asia");
  		this.horizBar1.Add( 432, "Australia");
  		this.horizBar1.Add( 89, "Europe");
			this.horizBar1.Add( 300, "Moon");

			// show % values
			this.horizBar1.Marks.Style = TeeChart.Styles.MarksStyles.Percent;
			// Set axes labels to "opposite" alignment
			this.tChart1.Axes.Left.Labels.Align = TeeChart.AxisLabelAlign.Opposite;
			this.tChart1.Axes.Right.Labels.Align = TeeChart.AxisLabelAlign.Opposite;
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.horizBar1 = new Steema.TeeChart.Styles.HorizBar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(440, 63);
			this.textBox1.Text = "Vertical axes can align their Labels to the opposite direction.\r\nNote: The labels" +
				" Angle should be 0 (no label rotation).\r\n\r\ntChart1.Axes.Left.Labels.Align = TeeC" +
				"hart.AxisLabelAlign.Opposite;";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 20;
			
			
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
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			// 
			// tChart1.Axes.Left.AxisPen
			// 
			this.tChart1.Axes.Left.AxisPen.Width = 1;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Header.Font.Name = "Verdana";
			// 
			// tChart1.Header.Font.Shadow
			// 
			// 
			// tChart1.Header.Font.Shadow.Brush
			// 
			this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Header.Font.Shadow.Visible = true;
			this.tChart1.Header.Lines = new string[] {
														 "Axis labels alignment"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Shadow
			// 
			this.tChart1.Legend.Shadow.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
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
			this.tChart1.Series.Add(this.horizBar1);
			this.tChart1.Size = new System.Drawing.Size(440, 237);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(63)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.Transparency = 75;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.Transparency = 75;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 1;
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Location = new System.Drawing.Point(64, 8);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 21);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "&Left";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Location = new System.Drawing.Point(120, 8);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(79, 21);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "&Right";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Axis:";
			this.label1.UseMnemonic = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(216, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(154, 21);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "&Opposite label alignment";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// horizBar1
			// 
			// 
			// horizBar1.Brush
			// 
			this.horizBar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
			// 
			// horizBar1.Gradient
			// 
			this.horizBar1.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizBar1.Gradient
			// 
			this.horizBar1.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizBar1.Marks
			// 
			this.horizBar1.Marks.Visible = false;
			// 
			// horizBar1.Pen
			// 
			this.horizBar1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(61)), ((System.Byte)(92)), ((System.Byte)(153)));
			this.horizBar1.Title = "horizBar1";
			// 
			// horizBar1.XValues
			// 
			this.horizBar1.XValues.DataMember = "X";
			// 
			// horizBar1.YValues
			// 
			this.horizBar1.YValues.DataMember = "Bar";
			this.horizBar1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// Axis_LabelAlign
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 333);
			this.Name = "Axis_LabelAlign";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked)
				this.horizBar1.GetVertAxis.Labels.Align = TeeChart.AxisLabelAlign.Opposite;
			else this.horizBar1.GetVertAxis.Labels.Align = TeeChart.AxisLabelAlign.Default;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.radioButton1.Checked)
				this.horizBar1.VertAxis = TeeChart.Styles.VerticalAxis.Left;
			else this.horizBar1.VertAxis = TeeChart.Styles.VerticalAxis.Right;
			checkBox1_CheckedChanged(this,new System.EventArgs());
		}
	}
}

