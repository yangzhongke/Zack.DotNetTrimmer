using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Candle_CustomColors : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Candle candleSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		private void SetCustomColors()
		{
			candleSeries1.Colors[11] = Color.Yellow;
			candleSeries1.Colors[15] = Color.Lime;
			candleSeries1.Colors[16] = Color.Blue;
		}
		
		public Candle_CustomColors()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			candleSeries1.FillSampleValues(30);

			SetCustomColors();
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
			this.candleSeries1 = new Steema.TeeChart.Styles.Candle();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 40);
			this.textBox1.Text = "Candle bars can be displayed using custom colors.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
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
																								 "tChart1"};
			this.tChart1.Location = new System.Drawing.Point(0, 81);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.candleSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 205);
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
			// candleSeries1
			// 
			// 
			// candleSeries1.Brush
			// 
			this.candleSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.candleSeries1.CloseValues = this.candleSeries1.YValues;
			this.candleSeries1.DateValues = this.candleSeries1.XValues;
			this.candleSeries1.DownCloseColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// candleSeries1.LinePen
			// 
			this.candleSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(77)), ((System.Byte)(77)), ((System.Byte)(0)));
			// 
			// candleSeries1.Marks
			// 
			// 
			// candleSeries1.Marks.Symbol
			// 
			// 
			// candleSeries1.Marks.Symbol.Shadow
			// 
			this.candleSeries1.Marks.Symbol.Shadow.Height = 1;
			this.candleSeries1.Marks.Symbol.Shadow.Visible = true;
			this.candleSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// candleSeries1.Pointer
			// 
			this.candleSeries1.Pointer.Draw3D = false;
			this.candleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candleSeries1.Title = "candleSeries1";
			// 
			// candleSeries1.XValues
			// 
			this.candleSeries1.XValues.DataMember = "Date";
			this.candleSeries1.XValues.DateTime = true;
			this.candleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// candleSeries1.YValues
			// 
			this.candleSeries1.YValues.DataMember = "Close";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(20, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(116, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Custom Colors";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(147, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Style:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Stick",
																									 "Bar",
																									 "Open Close",
																									 "Line"});
			this.comboBox1.Location = new System.Drawing.Point(187, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// Candle_CustomColors
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Candle_CustomColors";
			this.Load += new System.EventHandler(this.Candle_CustomColors_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked) SetCustomColors();
			else
				for (int i=0; i<candleSeries1.Count; i++) 
          candleSeries1[i].Color=Color.Empty;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			candleSeries1.Style = (TeeChart.Styles.CandleStyles)comboBox1.SelectedIndex;
		}

		private void Candle_CustomColors_Load(object sender, System.EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}
	}
}
