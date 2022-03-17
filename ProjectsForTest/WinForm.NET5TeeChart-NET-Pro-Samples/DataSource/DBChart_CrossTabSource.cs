using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class DBChart_CrossTabSource : Steema.TeeChart.Samples.BaseForm
	{
		private System.ComponentModel.IContainer components = null;

		//variables
		private DataSet sourceDataSet;
		private Steema.TeeChart.Styles.Bar barSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
        private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Data.CrossTabSource crossTabSource1;
        private Label label1;
        private ComboBox comboBox1;
		private System.Windows.Forms.Button button1;

		public DBChart_CrossTabSource()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBChart_CrossTabSource));
            this.barSeries1 = new Steema.TeeChart.Styles.Bar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.crossTabSource1 = new Steema.TeeChart.Data.CrossTabSource();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(592, 73);
            this.textBox1.Text = "DBCrosstabSource component connects to any dataset and automatically creates seri" +
                "es from database data, \r\nusing Group and Label fields and formula (count, sum, m" +
                "inimum, maximum, product of values).";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Size = new System.Drawing.Size(592, 31);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            this.tChart1.Axes.Bottom.MaximumOffset = 44;
            this.tChart1.Axes.Bottom.MinimumOffset = 44;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Visible = false;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "TeeChart",
        "Crosstab source example"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Sigma = true;
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tChart1.Series.Add(this.barSeries1);
            this.tChart1.Size = new System.Drawing.Size(592, 264);
            this.tChart1.Tools.Add(this.gridBand1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Size = 5;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 104);
            this.chartContainer.Size = new System.Drawing.Size(592, 264);
            // 
            // barSeries1
            // 
            // 
            // 
            // 
            this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.ColorEach = false;
            this.barSeries1.Cursor = Drawing.Cursors.Cross;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.barSeries1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.barSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.barSeries1.Marks.Callout.Distance = 0;
            this.barSeries1.Marks.Callout.Draw3D = false;
            this.barSeries1.Marks.Callout.Length = 20;
            this.barSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.barSeries1.Marks.Callout.Visible = false;
            this.barSeries1.Marks.Visible = false;
            // 
            // 
            // 
            this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.barSeries1.Title = "barSeries1";
            // 
            // 
            // 
            this.barSeries1.XValues.DataMember = "X";
            this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.barSeries1.YValues.DataMember = "Bar";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(16, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "&Load dataset";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(421, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Swap";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(313, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "&Case sensitive";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // crossTabSource1
            // 
            this.crossTabSource1.CaseSensitive = true;
            this.crossTabSource1.DataSource = null;
            this.crossTabSource1.Formula = Steema.TeeChart.Data.GroupFormula.Sum;
            this.crossTabSource1.GroupField = "Terms";
            this.crossTabSource1.LabelField = "PaymentMethod";
            this.crossTabSource1.Series = null;
            this.crossTabSource1.ValueField = "AmountPaid";
            // 
            // comboBox1
            // 
#if VS2005
            this.comboBox1.FormattingEnabled = true;
#endif
            this.comboBox1.Items.AddRange(new object[] {
            "Count",
            "Sum",
            "Min",
            "Max",
            "Product"});
            this.comboBox1.Location = new System.Drawing.Point(176, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Formula:";
            // 
            // DBChart_CrossTabSource
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.Name = "DBChart_CrossTabSource";
            this.Load += new System.EventHandler(this.DataConnect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void DataConnect_Load(object sender, System.EventArgs e)
		{
			sourceDataSet = new DataSet();
			crossTabSource1.DataSource = sourceDataSet;
			barSeries1.DataSource = crossTabSource1;
            comboBox1.SelectedIndex = 1;

			LoadData();
			barSeries1.CheckDataSource();
		}

		private void LoadData()
		{
			sourceDataSet.ReadXmlSchema(Utils.CodePath()+"\\DataSource\\OrdersDS.xsd");
			sourceDataSet.ReadXml(Utils.CodePath()+"\\DataSource\\orders.xml");

			barSeries1.Clear();

            crossTabSource1.Formula = (Steema.TeeChart.Data.GroupFormula)comboBox1.SelectedIndex;
			crossTabSource1.CaseSensitive = checkBox2.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox1.Checked)
				LoadData();
			else
				sourceDataSet.Clear();
			barSeries1.CheckDataSource();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string tmp = crossTabSource1.GroupField;
			crossTabSource1.GroupField=crossTabSource1.LabelField;
			crossTabSource1.LabelField=tmp;
			barSeries1.CheckDataSource();
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			crossTabSource1.CaseSensitive = checkBox2.Checked;
			barSeries1.CheckDataSource();
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            crossTabSource1.Formula = (Steema.TeeChart.Data.GroupFormula)comboBox1.SelectedIndex;
            barSeries1.CheckDataSource();
        }
	}
}

