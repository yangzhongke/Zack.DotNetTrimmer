using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Bubble_Transparency : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bubble bubble1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Bubble_Transparency()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bubble1.FillSampleValues();
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
			this.bubble1 = new Steema.TeeChart.Styles.Bubble();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Bubble series allows Transparency:\r\n\r\nbubble1.Pointer.Transparency = 50;  // <-- " +
				"50 %";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Name = "panel1";
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
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.bubble1);
			this.tChart1.Tools.Add(this.gridBand1);
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
			this.bubble1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			this.bubble1.Pointer.HorizSize = 17;
			this.bubble1.Pointer.InflateMargins = false;
			this.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.bubble1.Pointer.VertSize = 17;
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
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(104, 13);
			this.hScrollBar1.Maximum = 109;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(227, 17);
			this.hScrollBar1.TabIndex = 0;
			this.hScrollBar1.Value = 50;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Transparency:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(338, 15);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "50";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Bubble_Transparency
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Bubble_Transparency";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e) {
			bubble1.Pointer.Transparency =hScrollBar1.Value;
			label2.Text = hScrollBar1.Value.ToString();
		}
	}
}

