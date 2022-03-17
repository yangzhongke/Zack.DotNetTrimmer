using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Bar_Size_Example : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Tools.Annotation annotation1;
		private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TrackBar trackBar2;

    private BarSize Series1;

		public Bar_Size_Example()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
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
			this.annotation1 = new Steema.TeeChart.Tools.Annotation();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(528, 56);
			this.textBox1.Text = "An example of a new Bar series that can display individual \r\nbars with different " +
				"sizes (widths).";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.trackBar2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(528, 40);
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
																								 "Bar Size Series example"};
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
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Size = new System.Drawing.Size(528, 261);
			this.tChart1.Tools.Add(this.annotation1);
			this.tChart1.ClickSeries += new Steema.TeeChart.SeriesEventHandler(this.tChart1_ClickSeries);
			// 
			// annotation1
			// 
			this.annotation1.Cursor = Drawing.Cursors.Default;
			this.annotation1.Left = 6;
			// 
			// annotation1.Shape
			// 
			this.annotation1.Shape.Bottom = 25;
			// 
			// annotation1.Shape.Brush
			// 
			// 
			// annotation1.Shape.Gradient
			// 
			this.annotation1.Shape.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			this.annotation1.Shape.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.annotation1.Shape.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.annotation1.Shape.Brush.Gradient.Visible = true;
			this.annotation1.Shape.CustomPosition = true;
			// 
			// annotation1.Shape.Gradient
			// 
			this.annotation1.Shape.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			this.annotation1.Shape.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.annotation1.Shape.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.annotation1.Shape.Gradient.Visible = true;
			this.annotation1.Shape.Left = 6;
			this.annotation1.Shape.Right = 15;
			// 
			// annotation1.Shape.Shadow
			// 
			this.annotation1.Shape.Shadow.Height = 1;
			this.annotation1.Shape.Shadow.Visible = true;
			this.annotation1.Shape.Shadow.Width = 1;
			this.annotation1.Shape.Top = 8;
			this.annotation1.Top = 8;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(64, 8);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.AutoSize = false;
			this.trackBar1.Location = new System.Drawing.Point(187, 8);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(88, 21);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Bar:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(144, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Position:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(320, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Size:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(272, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(432, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(10, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "1";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBar2
			// 
			this.trackBar2.AutoSize = false;
			this.trackBar2.BackColor = System.Drawing.SystemColors.Control;
			this.trackBar2.Location = new System.Drawing.Point(344, 8);
			this.trackBar2.Maximum = 300;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(88, 21);
			this.trackBar2.TabIndex = 8;
			this.trackBar2.TickFrequency = 20;
			this.trackBar2.Value = 100;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// Bar_Size_Example
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 357);
			this.Name = "Bar_Size_Example";
			this.Load += new System.EventHandler(this.Bar_Size_Example_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

    private void Bar_Size_Example_Load(object sender, System.EventArgs e)
    {
      Series1 = new Steema.TeeChart.Samples.BarSize(tChart1.Chart);
      Series1.FillSampleValues();

      Series1.SizeValues[0]=0.4;
      Series1.SizeValues[2]=0.1;
      Series1.SizeValues[4]=1.1;

      Series1.XValues[3]=2.8;

      Series1.Colors[1]=Color.Blue;
      Series1.Colors[4]=Color.Yellow;

      Series1.Marks.Visible=false;
    
      Series1.Cursor=Drawing.Cursors.Hand;

      trackBar1.Maximum=Series1.Count*100;
      trackBar1.TickFrequency=trackBar1.Maximum/10;
      trackBar1.Minimum=-trackBar1.Maximum;

      numericUpDown1.Maximum=Series1.Count-1;
      numericUpDown1_ValueChanged(null,null);
    }

    private void trackBar1_Scroll(object sender, System.EventArgs e)
    {
      Series1.XValues[Convert.ToInt32(numericUpDown1.Value)]=trackBar1.Value/100.0;
      Series1.Repaint();
      label4.Text=Series1.XValues[Convert.ToInt32(numericUpDown1.Value)].ToString();

      RefreshAnnotation();
    }

    private void trackBar2_Scroll(object sender, System.EventArgs e)
    {
      Series1.SizeValues[Convert.ToInt32(numericUpDown1.Value)]=trackBar2.Value/100.0;
      Series1.Repaint();
      label5.Text=Series1.SizeValues[Convert.ToInt32(numericUpDown1.Value)].ToString();
    }

    private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
    {
      trackBar1.Value=Convert.ToInt32(Series1.XValues[Convert.ToInt32(numericUpDown1.Value)]*100);
      trackBar2.Value=Convert.ToInt32(Series1.SizeValues[Convert.ToInt32(numericUpDown1.Value)]*100);

      RefreshAnnotation();
    }

    private void RefreshAnnotation()
    {
      annotation1.Text=numericUpDown1.Value.ToString();
      annotation1.Shape.Top=tChart1.Height-28;
      annotation1.Shape.Left=Series1.CalcXPosValue(Series1.XValues[Convert.ToInt32(numericUpDown1.Value)])-8;
    }

    private void tChart1_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, Drawing.MouseEventArgs e)
    {
      if(valueIndex>=0) numericUpDown1.Value=valueIndex;
    }

    private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
    {
    
    }

	}
}

