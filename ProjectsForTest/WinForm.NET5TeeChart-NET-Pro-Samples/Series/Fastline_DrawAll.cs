using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class FastLine_DrawAll : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.FastLine fastLineSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.ComponentModel.IContainer components = null;

		public FastLine_DrawAll()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			const int numPoints = 100000;

			this.fastLineSeries1.GetHorizAxis.SetMinMax(0,numPoints-1);
			// tell Series1 to draw non-repeated points only ( much faster ! )
			this.fastLineSeries1.DrawAllPoints = false;
			// this.tChart1.Axes.FastCals = true;
			
			// lets generate 1E+5 points }
#if VS2005 && NULLABLE
            double?[] myX = new double?[numPoints];
			double?[] myY = new double?[numPoints];
#else
            double[] myX = new double[numPoints];
			double[] myY = new double[numPoints];
#endif
            
			System.Random r = new System.Random();
			double tmp = r.NextDouble()*10000;
			for (int t=0; t<numPoints; t++)
			{
				tmp += r.Next(100)-49.5;
				myX[t] = t;
				myY[t] = tmp;
			}

			// now add points to series
			this.fastLineSeries1.XValues.Count = numPoints;
			this.fastLineSeries1.XValues.Value = myX;
			this.fastLineSeries1.YValues.Count = numPoints;
			this.fastLineSeries1.YValues.Value = myY;


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
      this.fastLineSeries1 = new Steema.TeeChart.Styles.FastLine();
      this.label1 = new System.Windows.Forms.Label();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.panel1.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(592, 73);
      this.textBox1.Text = "The Fast-Line series below is displaying 100.000 ! To speed up display, a new pro" +
        "perty ( DrawAllPoints ) only draws line segments between points that are not pla" +
        "ced at the same \"X\" pixel position.\r\n\r\nfastlineSeries1.DrawAllPoints = false ;";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.radioButton2);
      this.panel1.Controls.Add(this.radioButton1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(592, 31);
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
      this.tChart1.Header.Visible = false;
      // 
      // tChart1.Legend
      // 
      this.tChart1.Legend.Visible = false;
      this.tChart1.Location = new System.Drawing.Point(0, 104);
      this.tChart1.Name = "tChart1";
      this.tChart1.Series.Add(this.fastLineSeries1);
      this.tChart1.Size = new System.Drawing.Size(592, 264);
      // 
      // fastLineSeries1
      // 
      this.fastLineSeries1.Cursor = Drawing.Cursors.Cross;
      // 
      // fastLineSeries1.LinePen
      // 
      this.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red;
      this.fastLineSeries1.Title = "fastLineSeries1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Draw :";
      this.label1.UseMnemonic = false;
      // 
      // radioButton1
      // 
      this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.radioButton1.Location = new System.Drawing.Point(104, 6);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.TabIndex = 1;
      this.radioButton1.Text = "&All points";
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.Checked = true;
      this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.radioButton2.Location = new System.Drawing.Point(192, 6);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(152, 24);
      this.radioButton2.TabIndex = 2;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "&Non-repeated X only";
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // Fastline_DrawAll
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(592, 368);
      this.Name = "Fastline_DrawAll";
      this.panel1.ResumeLayout(false);

    }
		#endregion

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.fastLineSeries1.DrawAllPoints = this.radioButton1.Checked;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.fastLineSeries1.DrawAllPoints = this.radioButton1.Checked;
		}
	}
}

