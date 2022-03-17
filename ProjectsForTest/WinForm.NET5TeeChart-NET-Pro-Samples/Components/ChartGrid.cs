using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ChartGrid : Steema.TeeChart.Samples.BaseNoChart
	{
		private System.Windows.Forms.DataGridView dataGrid1;
		private System.Windows.Forms.Splitter splitter1;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.Styles.Bar bar1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public ChartGrid()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bar1.Add(32, "John");
			bar1.Add(417, "Anne");
			bar1.Add(65, "Louise");
			bar1.Add(87, "Jeff");
			dataGrid1.DataBindings.Clear();
		
			dataGrid1.DataBindings.Add("DataSource", bar1.DataSource, "TeeDataTable");
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
			this.dataGrid1 = new System.Windows.Forms.DataGridView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.tChart1 = new Steema.TeeChart.TChart();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Using a few lines of simple code, it is now possible to link a TeeChart Series to" +
				"\r\na standard .NET DataGrid.\r\nUsing the grid via the standard navigation keys on " +
				"your keyboard, \r\nyou can add, delete and modify point values and text.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tChart1);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Name = "panel2";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Top;
			//this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 0);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(426, 120);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 120);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(426, 3);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			//
			//
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 123);
			this.tChart1.Name = "tChart1";
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Size = new System.Drawing.Size(426, 31);
			this.tChart1.TabIndex = 2;
			// 
			// bar1
			// 
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.Red;
			this.bar1.ColorEach = true;
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(24, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Read Only";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(139, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Change second value";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ChartGrid
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(426, 258);
			this.Name = "ChartGrid";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			bar1.CheckDataSource();
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			dataGrid1.ReadOnly = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			bar1[1].Y = 50;
			bar1[1].Label = "Christine";
			bar1.WriteToDataSource();
			dataGrid1.DataBindings.Add("DataSource", bar1.DataSource, "TeeDataTable");
		}
	}
}

