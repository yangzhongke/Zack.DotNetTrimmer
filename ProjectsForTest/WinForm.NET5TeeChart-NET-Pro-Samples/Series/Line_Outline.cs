using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Line_Outline : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.ButtonPen buttonPen1;
		private Steema.TeeChart.ButtonPen buttonPen2;
    private Steema.TeeChart.ButtonColor buttonColor1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Line_Outline()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			lineSeries1.FillSampleValues(25);
			this.buttonPen1.Pen = this.lineSeries1.LinePen;
			this.buttonPen2.Pen = this.lineSeries1.OutLine;
      buttonColor1.Color=lineSeries1.Color;
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.buttonPen1 = new Steema.TeeChart.ButtonPen();
			this.buttonPen2 = new Steema.TeeChart.ButtonPen();
			this.buttonColor1 = new Steema.TeeChart.ButtonColor();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(528, 56);
			this.textBox1.Text = "Line series Outline property is a Pen used to display the same line at the backgr" +
				"ound with a bigger size.\r\n\r\nline1.Outline.Color = Color.Yellow ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonColor1);
			this.panel1.Controls.Add(this.buttonPen2);
			this.panel1.Controls.Add(this.buttonPen1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(528, 42);
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
			this.tChart1.Location = new System.Drawing.Point(0, 98);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(528, 211);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// lineSeries1.LinePen
			// 
			this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries1.OutLine
			// 
			this.lineSeries1.OutLine.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.lineSeries1.OutLine.Visible = true;
			// 
			// lineSeries1.Pointer
			//
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "lineSeries1";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.DataMember = "X";
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries1.YValues
			// 
			this.lineSeries1.YValues.DataMember = "Y";
			// 
			// buttonPen1
			// 
			this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPen1.Location = new System.Drawing.Point(15, 9);
			this.buttonPen1.Name = "buttonPen1";
			this.buttonPen1.TabIndex = 0;
			this.buttonPen1.Text = "&Line...";
			// 
			// buttonPen2
			// 
			this.buttonPen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPen2.Location = new System.Drawing.Point(112, 8);
			this.buttonPen2.Name = "buttonPen2";
			this.buttonPen2.TabIndex = 1;
			this.buttonPen2.Text = "&Outline...";
			// 
			// buttonColor1
			// 
			this.buttonColor1.Color = System.Drawing.Color.Empty;
			this.buttonColor1.Location = new System.Drawing.Point(208, 8);
			this.buttonColor1.Name = "buttonColor1";
			this.buttonColor1.TabIndex = 2;
			this.buttonColor1.Text = "&Color...";
			this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// Line_Outline
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 309);
			this.Name = "Line_Outline";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void buttonColor1_Click(object sender, System.EventArgs e)
    {
      lineSeries1.Color=buttonColor1.Color;
    }
	}
}

