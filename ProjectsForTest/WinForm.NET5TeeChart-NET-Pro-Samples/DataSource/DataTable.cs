using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples.DataSource
{
	public class DataConnect : Steema.TeeChart.Samples.BaseForm
	{
		private System.ComponentModel.IContainer components = null;

		//variables
		private DataTable sourceTable;
		private DataColumn colXData;
		private DataColumn colYData;
		private DataColumn colDesc;
		private DataColumn colColor;

		public DataConnect()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
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
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Visible = true;
			// 
			// panel1
			// 
			this.panel1.Visible = true;
			// 
			// tChart1
			// 
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.MinorGrid
			// 
			this.tChart1.Axes.Bottom.MinorGrid.Style = Drawing.DashStyle.Dot;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.MinorGrid
			// 
			this.tChart1.Axes.Depth.MinorGrid.Style = Drawing.DashStyle.Dot;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.MinorGrid
			// 
			this.tChart1.Axes.Left.MinorGrid.Style = Drawing.DashStyle.Dot;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.MinorGrid
			// 
			this.tChart1.Axes.Right.MinorGrid.Style = Drawing.DashStyle.Dot;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.MinorGrid
			// 
			this.tChart1.Axes.Top.MinorGrid.Style = Drawing.DashStyle.Dot;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Visible = true;
			// 
			// DataConnect
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 368);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.tChart1,
																																	this.panel1,
																																	this.textBox1});
			this.Name = "DataConnect";
			this.Load += new System.EventHandler(this.DataConnect_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void DataConnect_Load(object sender, System.EventArgs e)
		{
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

			// Add five items.
			DataRow NewRow;
			double lastVal=0;
			for(int i = 0; i <20; i++)
			{
				Color cc=Color.FromArgb(r.Next(255),r.Next(255),r.Next(255));
				NewRow = sourceTable.NewRow();
				NewRow["Desc"] = "Value "+i.ToString();
				NewRow["XData"] = lastVal+i+r.Next(5);
				NewRow["YData"] = r.Next(10);
				NewRow["Color"] = cc;
				sourceTable.Rows.Add(NewRow);
			}

		}

		private void LoadData()
		{
			tChart1[0].ColorMember=colColor.ToString();
			tChart1[0].XValues.DataMember=colXData.ToString();
			tChart1[0].YValues.DataMember=colYData.ToString();
			tChart1[0].DataSource=sourceTable;
		}

	}
}

