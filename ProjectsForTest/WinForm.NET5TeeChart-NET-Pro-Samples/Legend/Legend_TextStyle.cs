using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Legend_TextStyle : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Pie pieSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.ComponentModel.IContainer components = null;

		public Legend_TextStyle()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.pieSeries1.FillSampleValues(5);
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Several different legend text styles are supported via the Legend.TextStyle prope" +
				"rty.\r\n\r\nExample: tChart1.Legend.TextStyle =Steema.TeeChart.LegendTextStyles.Left" +
				"Value;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
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
			this.tChart1.Size = new System.Drawing.Size(466, 182);
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
			this.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Style :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Plain",
																									 "Left Value",
																									 "Right Value",
																									 "Left Percent",
																									 "Right Percent",
																									 "X Value",
																									 "Value",
																									 "Percent",
																									 "X and Value",
																									 "X and Percent"});
			this.comboBox1.Location = new System.Drawing.Point(67, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Legend_TextStyle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Legend_TextStyle";
			this.Load += new System.EventHandler(this.Legend_TextStyle_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Legend_TextStyle_Load(object sender, System.EventArgs e)
		{
			// left value style
			this.comboBox1.SelectedIndex = 1;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Legend.TextStyle = (Steema.TeeChart.LegendTextStyles)this.comboBox1.SelectedIndex;
		}
	}
}

