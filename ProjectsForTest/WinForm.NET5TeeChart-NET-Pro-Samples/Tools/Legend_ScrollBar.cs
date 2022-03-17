using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class LegendScrollBar : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Steema.TeeChart.Styles.Points points1;
		private Steema.TeeChart.Tools.LegendScrollBar legendScrollBar1;
		private System.ComponentModel.IContainer components = null;

		public LegendScrollBar()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			points1.FillSampleValues();

            tChart1.Draw();
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.points1 = new Steema.TeeChart.Styles.Points();
			this.legendScrollBar1 = new Steema.TeeChart.Tools.LegendScrollBar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Legend scrollbar tool displays a scroll-bar inside the legend bounds.\r\n\r\nThe scro" +
				"llbar is not a Windows control, thus it allows more customization\r\nof colors, et" +
				"c.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
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
			this.tChart1.Series.Add(this.points1);
			this.tChart1.Tools.Add(this.legendScrollBar1);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Edit Legend ScrollBar...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(182, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Legend First Value:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(288, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 2;
			// 
			// points1
			// 
			this.points1.ColorEach = true;
			// 
			// points1.Marks
			// 
			// 
			// points1.Marks.Symbol
			// 
			// 
			// points1.Marks.Symbol.Shadow
			// 
			this.points1.Marks.Symbol.Shadow.Height = 1;
			this.points1.Marks.Symbol.Shadow.Visible = true;
			this.points1.Marks.Symbol.Shadow.Width = 1;
			// 
			// points1.Pointer
			// 
			// 
			// points1.Pointer.Brush
			// 
			this.points1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.points1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.points1.Title = "points1";
			// 
			// points1.XValues
			// 
			this.points1.XValues.DataMember = "X";
			this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// points1.YValues
			// 
			this.points1.YValues.DataMember = "Y";
			// 
			// legendScrollBar1
			// 
			// 
			// legendScrollBar1.ArrowBrush
			// 
			this.legendScrollBar1.ArrowBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			// 
			// legendScrollBar1.Bevel
			// 
			this.legendScrollBar1.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
			this.legendScrollBar1.DrawStyle = Steema.TeeChart.Tools.ScrollBarDrawStyle.Always;
			this.legendScrollBar1.Horizontal = false;
			// 
			// legendScrollBar1.Pen
			// 
			this.legendScrollBar1.Pen.Color = System.Drawing.SystemColors.WindowFrame;
			this.legendScrollBar1.Position = 0;
			this.legendScrollBar1.Size = 18;
			// 
			// legendScrollBar1.ThumbBrush
			// 
			this.legendScrollBar1.ThumbBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			this.legendScrollBar1.Scrolled += new Steema.TeeChart.Tools.ScrollBarScrolledHandler(this.legendScrollBar1_Scrolled);
			// 
			// LegendScrollBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "LegendScrollBar";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.Tools.ScrollBarEditor.Edit(legendScrollBar1);
		}

		private void legendScrollBar1_Scrolled(object sender, System.EventArgs e) {
			label2.Text=tChart1.Legend.FirstValue.ToString();
		}
	}
}

