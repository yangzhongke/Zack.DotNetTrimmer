using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Error : Samples.BaseForm
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label2;
		private Steema.TeeChart.Styles.Error errorSeries1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Error()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.errorSeries1.Clear();
			this.errorSeries1.Add(0, 50, 10, "A", Color.Red);
			this.errorSeries1.Add(1, 80, 20, "B", Color.Yellow);
			this.errorSeries1.Add(2, 20,  8, "C", Color.Green);
			this.errorSeries1.Add(3, 60, 30, "D", Color.Blue);
			this.errorSeries1.Add(4, 40,  5, "E", Color.White);
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.errorSeries1 = new Steema.TeeChart.Styles.Error();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "\"Error\" series uses X,Y and Error coordinate values to display points. Style, pos" +
				"ition of error bars and size are configurable.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.hScrollBar1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
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
			this.tChart1.Header.Alignment = Drawing.StringAlignment.Near;
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			this.tChart1.Header.Font.Size = 7;
			this.tChart1.Header.Lines = new string[] {
																								 "Error Series"};
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.errorSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			this.tChart1.TabIndex = 2;
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
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(13, 7);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(97, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Style :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Left",
																									 "Top",
																									 "Right",
																									 "Bottom",
																									 "Left and Right",
																									 "Top and Bottom"});
			this.comboBox1.Location = new System.Drawing.Point(138, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(300, 10);
			this.hScrollBar1.Maximum = 200;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(93, 17);
			this.hScrollBar1.TabIndex = 4;
			this.hScrollBar1.Value = 100;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(253, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "S&ize :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// errorSeries1
			// 
			// 
			// errorSeries1.Brush
			// 
			this.errorSeries1.Brush.Color = System.Drawing.Color.SaddleBrown;
			this.errorSeries1.ColorEach = true;
			// 
			// errorSeries1.ErrorPen
			// 
			this.errorSeries1.ErrorPen.Color = System.Drawing.Color.SaddleBrown;
			// 
			// errorSeries1.ErrorValues
			// 
			this.errorSeries1.ErrorValues.DataMember = "StdError";
			this.errorSeries1.LabelMember = "Labels";
			// 
			// errorSeries1.Marks
			// 
			// 
			// errorSeries1.Marks.Symbol
			// 
			// 
			// errorSeries1.Marks.Symbol.Shadow
			// 
			this.errorSeries1.Marks.Symbol.Shadow.Height = 1;
			this.errorSeries1.Marks.Symbol.Shadow.Visible = true;
			this.errorSeries1.Marks.Symbol.Shadow.Width = 1;
			this.errorSeries1.Marks.Visible = false;
			this.errorSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
			this.errorSeries1.Title = "error1";
			// 
			// errorSeries1.XValues
			// 
			this.errorSeries1.XValues.DataMember = "X";
			this.errorSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// errorSeries1.YValues
			// 
			this.errorSeries1.YValues.DataMember = "Bar";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Error
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Error";
			this.Load += new System.EventHandler(this.SeriesType_Error_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.errorSeries1);
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : this.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Left; break;
				case 1 : this.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Top; break;
				case 2 : this.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Right; break;
				case 3 : this.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Bottom; break;
				case 4 : this.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.LeftRight; break;
				case 5 : this.errorSeries1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.TopBottom; break;
			}
		}

		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.errorSeries1.ErrorWidth = hScrollBar1.Value;
		}

		private void SeriesType_Error_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 5;
		}
	}
}

