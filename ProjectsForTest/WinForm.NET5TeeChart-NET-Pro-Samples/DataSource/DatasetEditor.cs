using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class DatasetEditor : Steema.TeeChart.Samples.BaseForm
	{
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn colX;
		private System.Data.DataColumn colY;
		private System.Data.DataColumn colZ;
		private System.Data.DataColumn colDesc;
		private Steema.TeeChart.Styles.Points3D point3DSeries1;
		private Steema.TeeChart.Tools.Rotate rotate1;
    private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public DatasetEditor()
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
			this.dataSet1 = new System.Data.DataSet();
			this.dataTable1 = new System.Data.DataTable();
			this.colX = new System.Data.DataColumn();
			this.colY = new System.Data.DataColumn();
			this.colZ = new System.Data.DataColumn();
			this.colDesc = new System.Data.DataColumn();
			this.point3DSeries1 = new Steema.TeeChart.Styles.Points3D();
			this.rotate1 = new Steema.TeeChart.Tools.Rotate();
			this.button1 = new System.Windows.Forms.Button();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(592, 48);
			this.textBox1.Text = "This example uses a DataSet created at designtime and linked via the Chart Editor" +
				" to a Chart Series at designtime. The DataSet is populated at Form load.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(592, 40);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 50;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 78;
			
			
			this.tChart1.Aspect.Zoom = 75;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Labels.Shadow
			// 
			this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font
			// 
			// 
			// tChart1.Axes.Bottom.Title.Font.Shadow
			// 
			this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Bottom.Title.Shadow
			// 
			this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Labels.Shadow
			// 
			this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Title
			// 
			// 
			// tChart1.Axes.Depth.Title.Font
			// 
			// 
			// tChart1.Axes.Depth.Title.Font.Shadow
			// 
			this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Depth.Title.Shadow
			// 
			this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop
			// 
			// 
			// tChart1.Axes.DepthTop.Labels
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Font
			// 
			// 
			// tChart1.Axes.DepthTop.Labels.Font.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Labels.Shadow
			// 
			this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Title
			// 
			// 
			// tChart1.Axes.DepthTop.Title.Font
			// 
			// 
			// tChart1.Axes.DepthTop.Title.Font.Shadow
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.DepthTop.Title.Shadow
			// 
			this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			// 
			// tChart1.Axes.Left.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Labels.Shadow
			// 
			this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Title
			// 
			// 
			// tChart1.Axes.Left.Title.Font
			// 
			// 
			// tChart1.Axes.Left.Title.Font.Shadow
			// 
			this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Left.Title.Shadow
			// 
			this.tChart1.Axes.Left.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			// 
			// tChart1.Axes.Right.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Labels.Shadow
			// 
			this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Title
			// 
			// 
			// tChart1.Axes.Right.Title.Font
			// 
			// 
			// tChart1.Axes.Right.Title.Font.Shadow
			// 
			this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Right.Title.Shadow
			// 
			this.tChart1.Axes.Right.Title.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			// 
			// tChart1.Axes.Top.Labels.Font.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Labels.Shadow
			// 
			this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Title
			// 
			// 
			// tChart1.Axes.Top.Title.Font
			// 
			// 
			// tChart1.Axes.Top.Title.Font.Shadow
			// 
			this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Axes.Top.Title.Shadow
			// 
			this.tChart1.Axes.Top.Title.Shadow.Visible = false;
			// 
			// tChart1.Footer
			// 
			// 
			// tChart1.Footer.Font
			// 
			// 
			// tChart1.Footer.Font.Shadow
			// 
			this.tChart1.Footer.Font.Shadow.Visible = false;
			// 
			// tChart1.Footer.Shadow
			// 
			this.tChart1.Footer.Shadow.Visible = false;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Font
			// 
			// 
			// tChart1.Header.Font.Shadow
			// 
			this.tChart1.Header.Font.Shadow.Visible = false;
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Header.Shadow
			// 
			this.tChart1.Header.Shadow.Visible = false;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Shadow
			// 
			this.tChart1.Legend.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Title
			// 
			// 
			// tChart1.Legend.Title.Font
			// 
			this.tChart1.Legend.Title.Font.Bold = true;
			// 
			// tChart1.Legend.Title.Font.Shadow
			// 
			this.tChart1.Legend.Title.Font.Shadow.Visible = false;
			// 
			// tChart1.Legend.Title.Pen
			// 
			this.tChart1.Legend.Title.Pen.Visible = false;
			// 
			// tChart1.Legend.Title.Shadow
			// 
			this.tChart1.Legend.Title.Shadow.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 88);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			this.tChart1.Panel.Shadow.Visible = false;
			this.tChart1.Series.Add(this.point3DSeries1);
			this.tChart1.Size = new System.Drawing.Size(592, 280);
			// 
			// tChart1.SubFooter
			// 
			// 
			// tChart1.SubFooter.Font
			// 
			// 
			// tChart1.SubFooter.Font.Shadow
			// 
			this.tChart1.SubFooter.Font.Shadow.Visible = false;
			// 
			// tChart1.SubFooter.Shadow
			// 
			this.tChart1.SubFooter.Shadow.Visible = false;
			// 
			// tChart1.SubHeader
			// 
			// 
			// tChart1.SubHeader.Font
			// 
			// 
			// tChart1.SubHeader.Font.Shadow
			// 
			this.tChart1.SubHeader.Font.Shadow.Visible = false;
			// 
			// tChart1.SubHeader.Shadow
			// 
			this.tChart1.SubHeader.Shadow.Visible = false;
			this.tChart1.Tools.Add(this.rotate1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Pen
			// 
			this.tChart1.Walls.Back.Pen.Visible = false;
			// 
			// tChart1.Walls.Back.Shadow
			// 
			this.tChart1.Walls.Back.Shadow.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			// 
			// tChart1.Walls.Bottom.Shadow
			// 
			this.tChart1.Walls.Bottom.Shadow.Visible = false;
			this.tChart1.Walls.Bottom.Size = 4;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			// 
			// tChart1.Walls.Left.Shadow
			// 
			this.tChart1.Walls.Left.Shadow.Visible = false;
			this.tChart1.Walls.Left.Size = 4;
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Shadow
			// 
			this.tChart1.Walls.Right.Shadow.Visible = false;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("es-ES");
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
																																	this.dataTable1});
			// 
			// dataTable1
			// 
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
																																			this.colX,
																																			this.colY,
																																			this.colZ,
																																			this.colDesc});
			this.dataTable1.TableName = "Table1";
			// 
			// colX
			// 
			this.colX.Caption = "colX";
			this.colX.ColumnName = "colX";
			this.colX.DataType = typeof(System.Double);
			// 
			// colY
			// 
			this.colY.Caption = "colY";
			this.colY.ColumnName = "colY";
			this.colY.DataType = typeof(System.Double);
			// 
			// colZ
			// 
			this.colZ.Caption = "colZ";
			this.colZ.ColumnName = "colZ";
			this.colZ.DataType = typeof(System.Double);
			// 
			// colDesc
			// 
			this.colDesc.ColumnName = "colDesc";
			// 
			// point3DSeries1
			// 
			this.point3DSeries1.Cursor = Drawing.Cursors.Cross;
			this.point3DSeries1.DataSource = this.dataTable1;
			this.point3DSeries1.LabelMember = "colDesc";
			// 
			// point3DSeries1.LinePen
			// 
			this.point3DSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// point3DSeries1.Marks
			// 
			// 
			// point3DSeries1.Marks.Callout
			// 
			this.point3DSeries1.Marks.Callout.Arrow = this.point3DSeries1.Marks.Arrow;
			this.point3DSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.point3DSeries1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// point3DSeries1.Marks.Callout.Brush
			// 
			this.point3DSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.point3DSeries1.Marks.Callout.Distance = 0;
			this.point3DSeries1.Marks.Callout.Draw3D = false;
			this.point3DSeries1.Marks.Callout.Length = 10;
			this.point3DSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// point3DSeries1.Marks.Font
			// 
			// 
			// point3DSeries1.Marks.Font.Shadow
			// 
			this.point3DSeries1.Marks.Font.Shadow.Visible = false;
			// 
			// point3DSeries1.Pointer
			// 
			// 
			// point3DSeries1.Pointer.Brush
			// 
			this.point3DSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.point3DSeries1.Pointer.HorizSize = 5;
			// 
			// point3DSeries1.Pointer.Pen
			// 
			this.point3DSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.point3DSeries1.Pointer.Pen.Visible = false;
			this.point3DSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.point3DSeries1.Pointer.VertSize = 5;
			this.point3DSeries1.Pointer.Visible = true;
			this.point3DSeries1.Title = "point3DSeries1";
			// 
			// point3DSeries1.XValues
			// 
			this.point3DSeries1.XValues.DataMember = "colX";
			// 
			// point3DSeries1.YValues
			// 
			this.point3DSeries1.YValues.DataMember = "colY";
			// 
			// point3DSeries1.ZValues
			// 
			this.point3DSeries1.ZValues.DataMember = "colZ";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit Datasource...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(25)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// DatasetEditor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 368);
			this.Name = "DatasetEditor";
			this.Load += new System.EventHandler(this.DatasetEditor_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void PopulateTable()
		{
			Random r=new Random(255);
			int numVals=20;

			DataRow NewRow;
			for(int x = 0; x <numVals; x++)
				for (int z = 0; z <numVals; z++)
				{
					double tmpvar=r.Next(10);
					NewRow = dataTable1.NewRow();
					NewRow["colDesc"] = "Text"+x.ToString()+z.ToString();
					NewRow["colX"] = x;
					NewRow["colY"] = 0.5*Math.Pow(Math.Cos(x/(numVals*0.2)),2)+
													Math.Pow(Math.Cos(z/(numVals*0.2)),2)-
													Math.Cos(z/(numVals*0.5));
					NewRow["colZ"] = z;
					dataTable1.Rows.Add(NewRow);
				}
		}

		private void DatasetEditor_Load(object sender, System.EventArgs e)
		{
			PopulateTable();
		  tChart1[0].CheckDataSource();
		}

    private void button1_Click(object sender, System.EventArgs e)
    {
      TeeChart.Editors.SeriesEditor.ShowEditor(tChart1[0],TeeChart.Editors.ChartEditorTabs.SeriesDataSource);
    }
	}
}

