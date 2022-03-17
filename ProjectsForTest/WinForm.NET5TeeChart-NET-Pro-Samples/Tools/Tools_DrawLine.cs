using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tools_DrawLine : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.FastLine fastLineSeries1;
		private Steema.TeeChart.Tools.DrawLine drawLine1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label NumLines;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Tools_DrawLine()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.fastLineSeries1.FillSampleValues(100);
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
			this.drawLine1 = new Steema.TeeChart.Tools.DrawLine();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NumLines = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(425, 59);
			this.textBox1.Text = "The Draw Line tool allows the user to draw lines at run-time using the mouse. Lin" +
				"e pen is customizable. All drawn lines are stored in a Lines array property.\r\n\r\n" +
				"Example: Draw a line dragging the mouse.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.NumLines);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(425, 79);
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
			this.tChart1.Location = new System.Drawing.Point(0, 138);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.fastLineSeries1);
			this.tChart1.Size = new System.Drawing.Size(425, 132);
			this.tChart1.Tools.Add(this.drawLine1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// fastLineSeries1
			// 
			// 
			// fastLineSeries1.LinePen
			// 
			this.fastLineSeries1.LinePen.Color = System.Drawing.Color.Red;
			// 
			// fastLineSeries1.Marks
			// 
			// 
			// fastLineSeries1.Marks.Symbol
			// 
			// 
			// fastLineSeries1.Marks.Symbol.Shadow
			// 
			this.fastLineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.fastLineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.fastLineSeries1.Marks.Symbol.Shadow.Width = 1;
			this.fastLineSeries1.Title = "fastLineSeries1";
			// 
			// fastLineSeries1.XValues
			// 
			this.fastLineSeries1.XValues.DataMember = "X";
			this.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// fastLineSeries1.YValues
			// 
			this.fastLineSeries1.YValues.DataMember = "Y";
			// 
			// drawLine1
			// 
			this.drawLine1.NewLine += new Steema.TeeChart.Tools.DrawLineEventHandler(this.drawLine1_NewLine);
			this.drawLine1.Select += new Steema.TeeChart.Tools.DrawLineEventHandler(this.drawLine1_Select);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(12, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(116, 20);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Active";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(12, 29);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(116, 20);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Enable Draw";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(12, 49);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(116, 19);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Enable &Selection";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(122, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Lines :";
			this.label1.UseMnemonic = false;
			// 
			// NumLines
			// 
			this.NumLines.AutoSize = true;
			this.NumLines.Location = new System.Drawing.Point(164, 7);
			this.NumLines.Name = "NumLines";
			this.NumLines.Size = new System.Drawing.Size(10, 16);
			this.NumLines.TabIndex = 4;
			this.NumLines.Text = "0";
			this.NumLines.UseMnemonic = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(176, 48);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "&Delete";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(213, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "&Mouse button:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Left",
																									 "Right",
																									 "Middle"});
			this.comboBox1.Location = new System.Drawing.Point(296, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(85, 21);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Tool_DrawLine
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(425, 270);
			this.Name = "Tool_DrawLine";
			this.Load += new System.EventHandler(this.Tool_DrawLine_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.drawLine1.DeleteSelected();
			this.button1.Enabled = false;
			NumLines.Text = this.drawLine1.Lines.Count.ToString();
		}

		private void Tool_DrawLine_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.drawLine1.Active = this.checkBox1.Checked;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0 : this.drawLine1.Button = Drawing.MouseButtons.Left; break;
				case 1 : this.drawLine1.Button = Drawing.MouseButtons.Right; break;
				case 2 : this.drawLine1.Button = Drawing.MouseButtons.Middle; break;
			}
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.drawLine1.EnableDraw = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			this.drawLine1.EnableSelect = checkBox3.Checked;
		}

		private void drawLine1_Select(Steema.TeeChart.Tools.DrawLine sender)
		{
			this.button1.Enabled = true;
		
		}

		private void drawLine1_NewLine(Steema.TeeChart.Tools.DrawLine sender)
		{
			NumLines.Text = this.drawLine1.Lines.Count.ToString();
		}
	}
}

