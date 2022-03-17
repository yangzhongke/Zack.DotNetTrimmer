using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class DataConnect : Steema.TeeChart.Samples.BaseForm
	{
		private System.ComponentModel.IContainer components = null;

		//variables
		private DataTable sourceTable;
		private DataColumn colXData;
		private DataColumn colYData;
		private DataColumn colDesc;
		private Steema.TeeChart.Styles.Bar barSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private DataColumn colColor;

		public DataConnect()
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
			this.barSeries1 = new Steema.TeeChart.Styles.Bar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(592, 73);
			this.textBox1.Text = "This example demonstrates how to connect a TeeChart XY Series to a DataTable at r" +
				"untime.\r\n\r\nCheck/uncheck the checkboxes to include/exclude the X value and Label" +
				" DataTable fields from the Series.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(592, 31);
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
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Series.Add(this.barSeries1);
			this.tChart1.Size = new System.Drawing.Size(592, 264);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Walls.Back.Transparent = false;
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
			// barSeries1
			// 
			// 
			// barSeries1.Brush
			// 
			this.barSeries1.Brush.Color = System.Drawing.Color.Red;
			this.barSeries1.Cursor = Drawing.Cursors.Cross;
			// 
			// barSeries1.Marks
			// 
			// 
			// barSeries1.Marks.Symbol
			// 
			// 
			// barSeries1.Marks.Symbol.Shadow
			// 
			this.barSeries1.Marks.Symbol.Shadow.Height = 1;
			this.barSeries1.Marks.Symbol.Shadow.Visible = true;
			this.barSeries1.Marks.Symbol.Shadow.Width = 1;
			this.barSeries1.Title = "barSeries1";
			// 
			// barSeries1.XValues
			// 
			this.barSeries1.XValues.DataMember = "X";
			this.barSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// barSeries1.YValues
			// 
			this.barSeries1.YValues.DataMember = "Bar";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(16, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Include &Labels";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(120, 6);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(120, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Include &XValues";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
			// DataConnect
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 368);
			this.Name = "DataConnect";
			this.Load += new System.EventHandler(this.DataConnect_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void DataConnect_Load(object sender, System.EventArgs e)
		{
			tChart1.Axes.Bottom.Labels.Style=AxisLabelStyle.Value;
			CreateTable();
			LoadData();
		}

		private void CreateTable()
		{
			Random r=new Random(255);
			
			// Create DataTable
			sourceTable = new DataTable("sourceTable");
			colXData = new DataColumn("XData",Type.GetType("System.Double"));
			colYData = new DataColumn("YData",Type.GetType("System.Double"));
			colDesc = new DataColumn("Desc",Type.GetType("System.String"));
			colColor = new DataColumn("Color",Type.GetType("System.Object"));

			sourceTable.Columns.Add(colXData);
			sourceTable.Columns.Add(colYData);
			sourceTable.Columns.Add(colDesc);
			sourceTable.Columns.Add(colColor);

			// Add table items.
			DataRow NewRow;
			double lastVal=0;
			for(int i = 0; i <10; i++)
			{
				Color cc=Color.FromArgb(r.Next(255),r.Next(255),r.Next(255));
				NewRow = sourceTable.NewRow();
				NewRow["Desc"] = "Label"+i.ToString();
				NewRow["XData"] = lastVal;
				NewRow["YData"] = r.Next(10);
				NewRow["Color"] = cc;
				sourceTable.Rows.Add(NewRow);
				lastVal=lastVal+5+r.Next(5);
			}

		}

		private void LoadData()
		{
			tChart1[0].Clear();

			//include Labels
			if (checkBox1.Checked)
			  tChart1[0].LabelMember=colDesc.ToString();
			else
				tChart1[0].LabelMember="";

			//include XValues
			if (checkBox2.Checked)
				tChart1[0].XValues.DataMember=colXData.ToString();
			else
				tChart1[0].XValues.DataMember="";

			tChart1[0].ColorMember=colColor.ToString();
			tChart1[0].YValues.DataMember=colYData.ToString();
			tChart1[0].DataSource=sourceTable;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
		  LoadData();
			tChart1[0].CheckDataSource();
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
		  LoadData();
			tChart1[0].CheckDataSource();
		}

	}
}

