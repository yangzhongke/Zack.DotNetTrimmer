using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Surface_Irregular : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Surface surfaceSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Surface_Irregular()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			/*
			 *  Arrays of X and Z values with sample points...
			 * The values have floating point decimals and define
			 * an irregular grid
			*/
			double [] xval = new double[10] {0.1, 0.2, 0.3, 0.5, 0.8, 1.1, 1.5, 2.0, 2.2, 3.0};
			double [] zval = new double[10] {0.5, 0.6, 0.7, 0.75, 0.8, 1.1, 1.5, 2.0, 2.2, 5.6};
			surfaceSeries1.IrregularGrid = true; // <---------- VERY IMPORTANT !!!
			surfaceSeries1.GetVertAxis.SetMinMax(-2.0, 2.0); // axis scale for Y values
			
			// Now add all "Y" points...
			// An irregular grid of 10 x 10 cells
			surfaceSeries1.NumXValues = 10;
			surfaceSeries1.NumZValues = 10;

			double y;

			for (int x=0; x<9; x++) // = 10 rows
				for (int z=0;z<9; z++) // = 10 columns
				{
					y = Math.Sin(z*Math.PI/10.0)*Math.Cos(x*Math.PI/5.0);  // example Y value
					surfaceSeries1.Add(xval[x],y,zval[z]);
				}
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
			this.surfaceSeries1 = new Steema.TeeChart.Styles.Surface();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Surface series accept X,Y and Z values as \"double\" floating point numbers.\r\nThe I" +
				"rregularGrid property controls if X and Z values should be equidistant or not.\r\n" +
				"\r\nExample: surfaceSeries11.Add( -123.456, 321.45, 456.789 );";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
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
																								 "Surface Series : ",
																								 "irregular grid example"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.surfaceSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
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
			// surfaceSeries1
			// 
			// 
			// surfaceSeries1.Brush
			// 
			this.surfaceSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// surfaceSeries1.Marks
			// 
			// 
			// surfaceSeries1.Marks.Symbol
			// 
			// 
			// surfaceSeries1.Marks.Symbol.Shadow
			// 
			this.surfaceSeries1.Marks.Symbol.Shadow.Height = 1;
			this.surfaceSeries1.Marks.Symbol.Shadow.Visible = true;
			this.surfaceSeries1.Marks.Symbol.Shadow.Width = 1;
			this.surfaceSeries1.NumXValues = 25;
			this.surfaceSeries1.NumZValues = 25;
			this.surfaceSeries1.PaletteMin = 0;
			this.surfaceSeries1.PaletteStep = 0;
			this.surfaceSeries1.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.surfaceSeries1.Title = "surfaceSeries1";
			// 
			// surfaceSeries1.XValues
			// 
			this.surfaceSeries1.XValues.DataMember = "X";
			// 
			// surfaceSeries1.YValues
			// 
			this.surfaceSeries1.YValues.DataMember = "Y";
			// 
			// surfaceSeries1.ZValues
			// 
			this.surfaceSeries1.ZValues.DataMember = "Z";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(83, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Irregular";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(93, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(115, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&3D";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// Surface_Irregular
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Surface_Irregular";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = checkBox2.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			surfaceSeries1.IrregularGrid = checkBox1.Checked;
		}
	}
}