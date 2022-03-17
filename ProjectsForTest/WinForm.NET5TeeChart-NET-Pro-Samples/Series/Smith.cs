using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Smith : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Smith smithSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Smith()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.smithSeries1.FillSampleValues(20);
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
			this.smithSeries1 = new Steema.TeeChart.Styles.Smith();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(499, 64);
			this.textBox1.Text = "As name suggests SmithSeries draws Smith charts. Each point is defined with Resis" +
				"tance and Reactance values.\r\nInherits most common properties with Polar and Circ" +
				"led ancestor series.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(499, 39);
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
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 103);
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
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.smithSeries1);
			this.tChart1.Size = new System.Drawing.Size(499, 217);
			// 
			// smithSeries1
			// 
			// 
			// smithSeries1.Brush
			// 
			this.smithSeries1.Brush.Color = System.Drawing.Color.Red;
			this.smithSeries1.Brush.Visible = false;
			this.smithSeries1.CircleBackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.smithSeries1.Circled = true;
			this.smithSeries1.CLabels = true;
			this.smithSeries1.ImagSymbol = "i";
			// 
			// smithSeries1.Marks
			// 
			// 
			// smithSeries1.Marks.Symbol
			// 
			// 
			// smithSeries1.Marks.Symbol.Shadow
			// 
			this.smithSeries1.Marks.Symbol.Shadow.Height = 1;
			this.smithSeries1.Marks.Symbol.Shadow.Visible = true;
			this.smithSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// smithSeries1.Pointer
			// 
			// 
			// smithSeries1.Pointer.Brush
			// 
			this.smithSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.smithSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.smithSeries1.RLabels = true;
			this.smithSeries1.Title = "smithSeries1";
			// 
			// smithSeries1.XValues
			// 
			this.smithSeries1.XValues.DataMember = "Resistance";
			// 
			// smithSeries1.YValues
			// 
			this.smithSeries1.YValues.DataMember = "Reactance";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(13, 9);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(107, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(60, 21);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "&Circled";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(180, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "&Imag. symbol :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(260, 9);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(27, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "i";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// SeriesType_Smith
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(499, 320);
			this.Name = "SeriesType_Smith";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.smithSeries1.FillSampleValues(10);
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.smithSeries1.Circled = checkBox1.Checked;
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
			this.smithSeries1.ImagSymbol = textBox2.Text;
		}
	}
}

