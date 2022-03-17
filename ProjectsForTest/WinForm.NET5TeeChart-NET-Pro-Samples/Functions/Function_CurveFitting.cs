using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Function_CurveFitting : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.FastLine fastLine1;
    private Steema.TeeChart.Styles.FastLine fastLine2;
    private Steema.TeeChart.Functions.PolyFitting polyFitting1;
    private Steema.TeeChart.Styles.FastLine fastLine3;
    private Steema.TeeChart.Functions.PolyFitting polyFitting2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Timer timer1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Function_CurveFitting()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			fastLine1.FillSampleValues(100);
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_CurveFitting));
			this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
			this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
			this.polyFitting1 = new Steema.TeeChart.Functions.PolyFitting();
			this.fastLine3 = new Steema.TeeChart.Styles.FastLine();
			this.polyFitting2 = new Steema.TeeChart.Functions.PolyFitting();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(464, 73);
			this.textBox1.Text = "Polynomial curvefitting function calculates the polynomial factors that best matc" +
					"hes the source data. The degree of the polynomial is configurable (from 2 to 20)" +
					".";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numericUpDown2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Size = new System.Drawing.Size(464, 47);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Aspect.ZOffset = 0;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "Polynomial fitting"};
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Series.Add(this.fastLine1);
			this.tChart1.Series.Add(this.fastLine2);
			this.tChart1.Series.Add(this.fastLine3);
			this.tChart1.Size = new System.Drawing.Size(464, 213);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 120);
			this.chartContainer.Size = new System.Drawing.Size(464, 213);
			// 
			// fastLine1
			// 
			this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.fastLine1.ColorEach = false;
			// 
			// 
			// 
			this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLine1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLine1.Marks.Callout.Distance = 0;
			this.fastLine1.Marks.Callout.Draw3D = false;
			this.fastLine1.Marks.Callout.Length = 10;
			this.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLine1.Marks.Callout.Visible = false;
			this.fastLine1.Title = "Data";
			this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLine1.XValues.DataMember = "X";
			this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.fastLine1.YValues.DataMember = "Y";
			// 
			// fastLine2
			// 
			this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.fastLine2.ColorEach = false;
			this.fastLine2.DataSource = this.fastLine1;
			this.fastLine2.Function = this.polyFitting1;
			// 
			// 
			// 
			this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLine2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLine2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLine2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLine2.Marks.Callout.Distance = 0;
			this.fastLine2.Marks.Callout.Draw3D = false;
			this.fastLine2.Marks.Callout.Length = 10;
			this.fastLine2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLine2.Marks.Callout.Visible = false;
			this.fastLine2.Title = "Curve 1";
			this.fastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// polyFitting1
			// 
			this.polyFitting1.PolyDegree = 3;
			// 
			// fastLine3
			// 
			this.fastLine3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			this.fastLine3.ColorEach = false;
			this.fastLine3.DataSource = this.fastLine1;
			this.fastLine3.Function = this.polyFitting2;
			// 
			// 
			// 
			this.fastLine3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLine3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.fastLine3.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.fastLine3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.fastLine3.Marks.Callout.Distance = 0;
			this.fastLine3.Marks.Callout.Draw3D = false;
			this.fastLine3.Marks.Callout.Length = 10;
			this.fastLine3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.fastLine3.Marks.Callout.Visible = false;
			this.fastLine3.Title = "Curve 2";
			this.fastLine3.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLine3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 16);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(72, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Animate";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(104, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Poly 1 degree:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(184, 16);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(240, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Poly 2 degree:";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(320, 16);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown2.TabIndex = 5;
			this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// 
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// 
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			// 
			// Function_CurveFitting
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 333);
			this.Name = "Function_CurveFitting";
			this.panel1.ResumeLayout(false);
			this.chartContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

    private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
    {
      polyFitting2.PolyDegree = (int)numericUpDown2.Value;
    }

    private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
    {
      polyFitting1.PolyDegree = (int)numericUpDown1.Value;
    }

    private void timer1_Tick(object sender, System.EventArgs e)
    {
      timer1.Enabled = false;
      try
      {
        fastLine1.Delete(0);
        Random r = new Random();
        fastLine1.Add(fastLine1.XValues.Last + 1.0,
          fastLine1.YValues.Last + r.Next(100)-50);
        fastLine2.CheckDataSource(); // <-- fill again the points
        fastLine3.CheckDataSource(); // <-- fill again the points
      }
      finally { timer1.Enabled = true;}
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      timer1.Enabled = checkBox1.Checked;
    }
	}
}

