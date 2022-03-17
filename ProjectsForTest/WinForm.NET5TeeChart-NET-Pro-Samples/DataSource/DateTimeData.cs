using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class DateTimeData : Steema.TeeChart.Samples.BaseForm
	{
		//variables
		private DataTable sourceTable;
		private DataColumn colDate;
		private DataColumn colDateAsDbl;
		private DataColumn colOpen;
		private DataColumn colHigh;
		private DataColumn colLow;
		private DataColumn colClose;
		private System.Windows.Forms.CheckBox checkBox1;

		private System.ComponentModel.IContainer components = null;

		public DateTimeData()
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(592, 40);
			this.textBox1.Text = "DateTime fields may be passed to a Series directly as DateTime values or alternat" +
				"ively as doubles (OADateTime).";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 40);
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
			this.tChart1.Location = new System.Drawing.Point(0, 71);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Size = new System.Drawing.Size(592, 297);
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
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(8, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(360, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "When checked uses &DateTime, if not it uses the Date as doubles";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// DateTimeData
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 368);
			this.Name = "DateTimeData";
			this.Load += new System.EventHandler(this.DateTimeData_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void DateTimeData_Load(object sender, System.EventArgs e)
		{
			tChart1.Axes.Bottom.Labels.Angle=90;
			CreateTable();
			LoadData();
		}

    private void CreateTable()
    {
	    Random r=new Random(255);
    	
	    // Create DataTable
	    sourceTable = new DataTable("sourceTable");
	    colDate = new DataColumn(Texts.ValuesDate,Type.GetType("System.DateTime"));
	    colDateAsDbl = new DataColumn("DateAsDbl",Type.GetType("System.Double"));
	    colOpen = new DataColumn(Texts.ValuesOpen,Type.GetType("System.Double"));
	    colHigh = new DataColumn(Texts.ValuesHigh,Type.GetType("System.Double"));
	    colLow = new DataColumn(Texts.ValuesLow,Type.GetType("System.Double"));
	    colClose = new DataColumn(Texts.ValuesClose,Type.GetType("System.Double"));

	    sourceTable.Columns.Add(colDate);
	    sourceTable.Columns.Add(colDateAsDbl);
	    sourceTable.Columns.Add(colOpen);
	    sourceTable.Columns.Add(colHigh);
	    sourceTable.Columns.Add(colLow);
	    sourceTable.Columns.Add(colClose);

	    //add some data
	    double highVal;
	    double lowVal;
	    double lastClose=r.Next(10);
	    DataRow NewRow;
	    for(int i = 0; i <20; i++)
	    {
		    double tmpVar=r.Next(10);
		    NewRow = sourceTable.NewRow();
		    NewRow[Texts.ValuesDate] = DateTime.FromOADate(i+37550);
		    NewRow["DateAsDbl"] = i+37550; //OADate
		    NewRow[Texts.ValuesOpen] = lastClose;
		    NewRow[Texts.ValuesHigh] = highVal = lastClose+1+r.Next(10);
		    NewRow[Texts.ValuesLow] = lowVal = lastClose-1-r.Next(10);
		    lastClose=lowVal+r.Next((int)(highVal-lowVal));
		    NewRow[Texts.ValuesClose] = lastClose;
    		
		    sourceTable.Rows.Add(NewRow);
      }
      
    }


		private void LoadData()
		{
			tChart1.Series.RemoveAllSeries();

			Styles.Candle cs=new Styles.Candle();
			tChart1.Series.Add(cs);

			if (checkBox1.Checked)
				foreach (Styles.ValueList v in cs.ValuesLists)
					v.DataMember=v.Name;  //as column name is same as ValueList name
			else
			{
				foreach (Styles.ValueList v in cs.ValuesLists)
					if (v.Name!="Date")
					  v.DataMember=v.Name;
				cs.DateValues.DataMember="DateAsDbl";
			}

			DataView localView = new DataView(sourceTable);

			tChart1[0].DataSource=localView;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			LoadData();
		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			g.Font.Color=Color.Blue;
			g.Font.Bold=true;
			g.Font.Size=11;

      g.TextAlign= Drawing.StringAlignment.Near;

			if (checkBox1.Checked)
				g.TextOut(10,10,"DateTime values");
			else
				g.TextOut(10,10,"DateTime as double");
		}
	}
}

