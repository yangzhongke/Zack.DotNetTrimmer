using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Area_Transparency : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Area areaSeries1;
		private Steema.TeeChart.Styles.Area areaSeries2;
		private Steema.TeeChart.Styles.Area areaSeries3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.HScrollBar hScrollBar3;
		private System.ComponentModel.IContainer components = null;

		public Area_Transparency()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (Steema.TeeChart.Styles.Area s in this.tChart1.Series)
			{
				s.FillSampleValues(10);
				s.Transparency = 30;
			}

      // Fix Net bug:
      hScrollBar1.Maximum+=hScrollBar1.LargeChange-1;
      hScrollBar2.Maximum+=hScrollBar2.LargeChange-1;
      hScrollBar3.Maximum+=hScrollBar3.LargeChange-1;
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
			this.areaSeries2 = new Steema.TeeChart.Styles.Area();
			this.areaSeries3 = new Steema.TeeChart.Styles.Area();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 73);
			this.textBox1.Text = "Area Series, when displayed in 2D mode, allows Transparency. Transparency is a nu" +
				"mber from 0 to 100 expressed in percent units.\r\n\r\nareaSeries1.Transparency = 45 " +
				";";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.hScrollBar3);
			this.panel1.Controls.Add(this.hScrollBar2);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 31);
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
																								 "Area series transparency"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(240)), ((System.Byte)(240)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(134)), ((System.Byte)(134)), ((System.Byte)(134)));
			this.tChart1.Legend.Pen.Visible = false;
			// 
			// tChart1.Legend.Shadow
			// 
			this.tChart1.Legend.Shadow.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
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
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.BackwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.Direction = Drawing.LinearGradientMode.BackwardDiagonal;
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.areaSeries1);
			this.tChart1.Series.Add(this.areaSeries2);
			this.tChart1.Series.Add(this.areaSeries3);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			// 
			// areaSeries1
			// 
			// 
			// areaSeries1.AreaBrush
			// 
			this.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(219)), ((System.Byte)(37)), ((System.Byte)(23)));
			// 
			// areaSeries1.Gradient
			// 
			this.areaSeries1.AreaBrush.Gradient.Transparency = 30;
			// 
			// areaSeries1.AreaLines
			// 
			this.areaSeries1.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(64)), ((System.Byte)(64)));
			// 
			// areaSeries1.Brush
			// 
			this.areaSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(219)), ((System.Byte)(37)), ((System.Byte)(23)));
			// 
			// areaSeries1.TopGradient
			// 
			this.areaSeries1.Brush.Gradient.Transparency = 30;
			// 
			// areaSeries1.Gradient
			// 
			this.areaSeries1.Gradient.Transparency = 30;
			// 
			// areaSeries1.LinePen
			// 
			this.areaSeries1.LinePen.Visible = false;
			// 
			// areaSeries1.Marks
			// 
			// 
			// areaSeries1.Marks.Symbol
			// 
			// 
			// areaSeries1.Marks.Symbol.Shadow
			// 
			this.areaSeries1.Marks.Symbol.Shadow.Height = 1;
			this.areaSeries1.Marks.Symbol.Shadow.Visible = true;
			this.areaSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// areaSeries1.Pointer
			// 
			this.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries1.Title = "areaSeries1";
			// 
			// areaSeries1.TopGradient
			// 
			this.areaSeries1.TopGradient.Transparency = 30;
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
			// areaSeries2
			// 
			// 
			// areaSeries2.AreaBrush
			// 
			this.areaSeries2.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(1)), ((System.Byte)(43)), ((System.Byte)(81)));
			// 
			// areaSeries2.Gradient
			// 
			this.areaSeries2.AreaBrush.Gradient.Transparency = 30;
			// 
			// areaSeries2.AreaLines
			// 
			this.areaSeries2.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(64)));
			// 
			// areaSeries2.Brush
			// 
			this.areaSeries2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(1)), ((System.Byte)(43)), ((System.Byte)(81)));
			// 
			// areaSeries2.TopGradient
			// 
			this.areaSeries2.Brush.Gradient.Transparency = 30;
			// 
			// areaSeries2.Gradient
			// 
			this.areaSeries2.Gradient.Transparency = 30;
			// 
			// areaSeries2.LinePen
			// 
			this.areaSeries2.LinePen.Visible = false;
			// 
			// areaSeries2.Marks
			// 
			// 
			// areaSeries2.Marks.Symbol
			// 
			// 
			// areaSeries2.Marks.Symbol.Shadow
			// 
			this.areaSeries2.Marks.Symbol.Shadow.Height = 1;
			this.areaSeries2.Marks.Symbol.Shadow.Visible = true;
			this.areaSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// areaSeries2.Pointer
			// 
			this.areaSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries2.Title = "areaSeries2";
			// 
			// areaSeries2.TopGradient
			// 
			this.areaSeries2.TopGradient.Transparency = 30;
			// 
			// areaSeries2.XValues
			// 
			this.areaSeries2.XValues.DataMember = "X";
			this.areaSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// areaSeries2.YValues
			// 
			this.areaSeries2.YValues.DataMember = "Y";
			// 
			// areaSeries3
			// 
			// 
			// areaSeries3.AreaBrush
			// 
			this.areaSeries3.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(234)), ((System.Byte)(88)));
			// 
			// areaSeries3.Gradient
			// 
			this.areaSeries3.AreaBrush.Gradient.Transparency = 30;
			// 
			// areaSeries3.AreaLines
			// 
			this.areaSeries3.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(0)));
			// 
			// areaSeries3.Brush
			// 
			this.areaSeries3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(234)), ((System.Byte)(88)));
			// 
			// areaSeries3.TopGradient
			// 
			this.areaSeries3.Brush.Gradient.Transparency = 30;
			// 
			// areaSeries3.Gradient
			// 
			this.areaSeries3.Gradient.Transparency = 30;
			// 
			// areaSeries3.LinePen
			// 
			this.areaSeries3.LinePen.Visible = false;
			// 
			// areaSeries3.Marks
			// 
			// 
			// areaSeries3.Marks.Symbol
			// 
			// 
			// areaSeries3.Marks.Symbol.Shadow
			// 
			this.areaSeries3.Marks.Symbol.Shadow.Height = 1;
			this.areaSeries3.Marks.Symbol.Shadow.Visible = true;
			this.areaSeries3.Marks.Symbol.Shadow.Width = 1;
			// 
			// areaSeries3.Pointer
			// 
			this.areaSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.areaSeries3.Title = "areaSeries3";
			// 
			// areaSeries3.TopGradient
			// 
			this.areaSeries3.TopGradient.Transparency = 30;
			// 
			// areaSeries3.XValues
			// 
			this.areaSeries3.XValues.DataMember = "X";
			this.areaSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// areaSeries3.YValues
			// 
			this.areaSeries3.YValues.DataMember = "Y";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(94, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Transparency";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(120, 10);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(100, 14);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Value = 30;
			this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(232, 10);
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(100, 14);
			this.hScrollBar2.TabIndex = 2;
			this.hScrollBar2.Value = 30;
			this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
			// 
			// hScrollBar3
			// 
			this.hScrollBar3.Location = new System.Drawing.Point(333, 10);
			this.hScrollBar3.Name = "hScrollBar3";
			this.hScrollBar3.Size = new System.Drawing.Size(100, 14);
			this.hScrollBar3.TabIndex = 3;
			this.hScrollBar3.Value = 30;
			this.hScrollBar3.ValueChanged += new System.EventHandler(this.hScrollBar3_ValueChanged);
			// 
			// Area_Transparency
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Area_Transparency";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.areaSeries1.Transparency = (int)this.hScrollBar1.Value;
				this.areaSeries2.Transparency = (int)this.hScrollBar2.Value;
				this.areaSeries3.Transparency = (int)this.hScrollBar3.Value;
				
			}
			else
				foreach (Steema.TeeChart.Styles.Area s in this.tChart1.Series)
					s.Transparency = 0;
		
		}

		private void hScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
			this.areaSeries1.Transparency = (int)this.hScrollBar1.Value;
		}

		private void hScrollBar2_ValueChanged(object sender, System.EventArgs e)
		{
			this.areaSeries2.Transparency = (int)this.hScrollBar2.Value;
		}

		private void hScrollBar3_ValueChanged(object sender, System.EventArgs e)
		{
			this.areaSeries3.Transparency = (int)this.hScrollBar3.Value;
		}

    private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
    {
    
    }
	}
}

