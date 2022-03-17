using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Tower : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Tower towerSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Tower()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			Random r = new Random(1000);

			this.towerSeries1.Clear();
			for (int x=1; x<=10; x++)
				for (int z=1; z<=10; z++)
					this.towerSeries1.Add(x,r.Next(1000)-100,z);

			 // example:
			this.towerSeries1.Origin = 500;
			this.towerSeries1.UseOrigin = true;

			comboBox1.Items.Clear();
			comboBox1.Items.AddRange(Enum.GetNames(typeof(Styles.TowerStyles)));
			comboBox1.SelectedItem=Styles.TowerStyles.Cube.ToString();
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
			this.towerSeries1 = new Steema.TeeChart.Styles.Tower();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(488, 49);
			this.textBox1.Text = "Tower series displays bars in 3D grid mode. Several properties configure the aspe" +
				"ct and size of each bar.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(488, 39);
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
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 88);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.towerSeries1);
			this.tChart1.Size = new System.Drawing.Size(488, 245);
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
			// towerSeries1
			// 
			// 
			// towerSeries1.Brush
			// 
			this.towerSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// towerSeries1.Marks
			// 
			// 
			// towerSeries1.Marks.Symbol
			// 
			// 
			// towerSeries1.Marks.Symbol.Shadow
			// 
			this.towerSeries1.Marks.Symbol.Shadow.Height = 1;
			this.towerSeries1.Marks.Symbol.Shadow.Visible = true;
			this.towerSeries1.Marks.Symbol.Shadow.Width = 1;
			this.towerSeries1.NumXValues = 25;
			this.towerSeries1.NumZValues = 25;
			this.towerSeries1.Origin = 0;
			this.towerSeries1.PaletteMin = 0;
			this.towerSeries1.PaletteStep = 0;
			this.towerSeries1.Title = "towerSeries1";
			this.towerSeries1.UseColorRange = false;
			this.towerSeries1.UsePalette = true;
			// 
			// towerSeries1.XValues
			// 
			this.towerSeries1.XValues.DataMember = "X";
			// 
			// towerSeries1.YValues
			// 
			this.towerSeries1.YValues.DataMember = "Y";
			// 
			// towerSeries1.ZValues
			// 
			this.towerSeries1.ZValues.DataMember = "Z";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(8, 7);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(114, 10);
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
																									 "Cube",
																									 "Rectangle",
																									 "Cover",
																									 "Cylinder",
																									 "Arrow",
																									 "Cone"});
			this.comboBox1.Location = new System.Drawing.Point(153, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(293, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(87, 21);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "&Use origin";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
			// SeriesType_Tower
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 333);
			this.Name = "SeriesType_Tower";
			this.Load += new System.EventHandler(this.SeriesType_Tower_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.towerSeries1);			
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.towerSeries1.UseOrigin = this.checkBox1.Checked;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.towerSeries1.TowerStyle = (Steema.TeeChart.Styles.TowerStyles)this.comboBox1.SelectedIndex;
		}

		private void SeriesType_Tower_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
		}
	}
}

