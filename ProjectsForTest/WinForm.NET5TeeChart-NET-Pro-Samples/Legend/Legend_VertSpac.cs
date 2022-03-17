using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Legend_VertSpac : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;

		public Legend_VertSpac()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.barSeries1.FillSampleValues(5);
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
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "The Legend can display items with custom vertical spacing. Values can be positive" +
				" (more space) or negative (less space).\r\n\r\nExample: tChart1.Legend.VertSpacing =" +
				" 6;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			this.panel1.TabIndex = 1;
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
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			this.tChart1.Legend.Shadow.Visible = false;
			// 
			// tChart1.Legend.Symbol
			// 
			this.tChart1.Legend.Symbol.DefaultPen = false;
			// 
			// tChart1.Legend.Symbol.Pen
			// 
			this.tChart1.Legend.Symbol.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(64)), ((System.Byte)(0)));
			this.tChart1.Legend.Symbol.Squared = true;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			this.tChart1.TabIndex = 2;
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
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// barSeries1.Marks
			// 
			// 
			// barSeries1.Marks.Font
			// 
			this.barSeries1.Marks.Font.Size = 9;
			// 
			// barSeries1.Marks.Pen
			// 
			this.barSeries1.Marks.Pen.Visible = false;
			// 
			// barSeries1.Marks.Symbol
			// 
			// 
			// barSeries1.Marks.Symbol.Shadow
			// 
			this.barSeries1.Marks.Symbol.Shadow.Height = 1;
			this.barSeries1.Marks.Symbol.Shadow.Visible = true;
			this.barSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// barSeries1.Pen
			// 
			this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(64)), ((System.Byte)(0)));
			this.barSeries1.Title = "barSeries1";
			// 
			// barSeries1.XValues
			// 
			this.barSeries1.XValues.DataMember = "X";
			this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries1.YValues
			// 
			this.barSeries1.YValues.DataMember = "Bar";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(112, 12);
			this.hScrollBar1.Maximum = 30;
			this.hScrollBar1.Minimum = -30;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(146, 17);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Vertical spacing :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(265, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "0";
			this.label2.UseMnemonic = false;
			// 
			// Legend_VertSpac
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Legend_VertSpac";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void hScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Legend.VertSpacing = (int)this.hScrollBar1.Value;
			this.label2.Text = this.hScrollBar1.Value.ToString();
		}
	}
}

