using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Legend_CustomPos : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Pie pieSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;
    private bool setting=false;

		public Legend_CustomPos()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			pieSeries1.FillSampleValues(5);
			tChart1.Legend.CustomPosition = true;
			tChart1.Legend.Left = 0;
			tChart1.Legend.Top = 0;

      trackBar1.Value=tChart1.Legend.Left;
      trackBar2.Value=tChart1.Legend.Top;
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
			this.pieSeries1 = new Steema.TeeChart.Styles.Pie();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(511, 64);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "The Chart Legend can be custom-positioned.\r\n\r\nExample: tChart1.Legend.CustomPosit" +
				"ion = true;\r\n              tChart1.Legend.Left := 123;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar2);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(511, 40);
			this.panel1.TabIndex = 1;
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
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Left;
			// 
			// tChart1.Legend.Pen
			// 
			this.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pieSeries1);
			this.tChart1.Size = new System.Drawing.Size(511, 208);
			this.tChart1.TabIndex = 2;
			// 
			// pieSeries1
			// 
			// 
			// pieSeries1.Brush
			// 
			this.pieSeries1.Brush.Color = System.Drawing.Color.Red;
			this.pieSeries1.LabelMember = "Labels";
			// 
			// pieSeries1.Marks
			// 
			// 
			// pieSeries1.Marks.Pen
			// 
			this.pieSeries1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// pieSeries1.Marks.Symbol
			// 
			// 
			// pieSeries1.Marks.Symbol.Shadow
			// 
			this.pieSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries1.Pen
			// 
			this.pieSeries1.Pen.Visible = false;
			// 
			// pieSeries1.Shadow
			// 
			this.pieSeries1.Shadow.Height = 20;
			this.pieSeries1.Shadow.Width = 20;
			this.pieSeries1.Title = "pieSeries1";
			// 
			// pieSeries1.XValues
			// 
			this.pieSeries1.XValues.DataMember = "Angle";
			this.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries1.YValues
			// 
			this.pieSeries1.YValues.DataMember = "Pie";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(15, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(109, 23);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Custom position";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.AutoSize = false;
			this.trackBar1.Location = new System.Drawing.Point(183, 11);
			this.trackBar1.Maximum = 300;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(102, 17);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.TickFrequency = 20;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// trackBar2
			// 
			this.trackBar2.AutoSize = false;
			this.trackBar2.Location = new System.Drawing.Point(336, 11);
			this.trackBar2.Maximum = 300;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(102, 17);
			this.trackBar2.TabIndex = 4;
			this.trackBar2.TickFrequency = 20;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(146, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Left:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(292, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Top:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Legend_CustomPos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(511, 312);
			this.Name = "Legend_CustomPos";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void trackBar1_Scroll(object sender, System.EventArgs e)
		{
      UpdateCustomPosition();
      tChart1.Legend.Left = (int)trackBar1.Value;
		}

		private void trackBar2_Scroll(object sender, System.EventArgs e)
		{
      UpdateCustomPosition();
      tChart1.Legend.Top = (int)trackBar2.Value;
		}

    private void UpdateCustomPosition()
    {
      tChart1.Legend.CustomPosition=true;
      setting=true;
      checkBox1.Checked=true;
      setting=false;
    }

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
      if (! setting)
      {
        tChart1.Legend.CustomPosition=checkBox1.Checked;

        // Force chart repaint and update trackbar positions
        tChart1.Refresh();
        trackBar1.Value=tChart1.Legend.Left;
        trackBar2.Value=tChart1.Legend.Top;
      }
    }
	}
}