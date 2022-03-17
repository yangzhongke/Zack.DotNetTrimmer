using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Marks_Angle : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Area areaSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.ComponentModel.IContainer components = null;

		public Marks_Angle()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.areaSeries1.FillSampleValues(10);
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
			this.areaSeries1 = new Steema.TeeChart.Styles.Area();
			this.label1 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Series Marks can be rotated using the Angle property.\r\n\r\nExample: areaSeries1.Mar" +
				"ks.Angle = 90 ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.areaSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
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
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// areaSeries1
			// 
			// 
			// areaSeries1.AreaBrush
			// 
			this.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// areaSeries1.Brush
			// 
			this.areaSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// areaSeries1.Marks
			// 
			this.areaSeries1.Marks.Angle = 45;
			// 
			// areaSeries1.Marks.Symbol
			// 
			// 
			// areaSeries1.Marks.Symbol.Shadow
			// 
			this.areaSeries1.Marks.Symbol.Shadow.Height = 1;
			this.areaSeries1.Marks.Symbol.Shadow.Visible = true;
			this.areaSeries1.Marks.Symbol.Shadow.Width = 1;
			this.areaSeries1.Marks.Visible = true;
			// 
			// areaSeries1.Pointer
			// 
			this.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries1.Title = "areaSeries1";
			// 
			// areaSeries1.XValues
			// 
			this.areaSeries1.XValues.DataMember = "X";
			this.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// areaSeries1.YValues
			// 
			this.areaSeries1.YValues.DataMember = "Y";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Angle:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(60, 13);
			this.hScrollBar1.Maximum = 360;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(113, 17);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Value = 45;
			this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(180, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "45";
			this.label2.UseMnemonic = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(232, 10);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "&Reset";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(327, 10);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "&Vertical";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Angle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Angle";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void button1_Click(object sender, System.EventArgs e)
		{
			this.hScrollBar1.Value = 0;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.hScrollBar1.Value = 90;
		}

		private void hScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
			this.label2.Text = this.hScrollBar1.Value.ToString();
			this.areaSeries1.Marks.Angle = (int)this.hScrollBar1.Value;
		}
	}
}

