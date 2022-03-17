using Steema.TeeChart.Editors;
using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Master_Detail : BaseNoChart
  {
    private System.Windows.Forms.SplitContainer splitContainer2;
    private TChart tChart1;
    private TChart tChart2;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private DataGridView dataGridView1;
    private DataGridView dataGridView2;
    private Label label1;
    private Series master;
    public Master_Detail()
    {
      InitializeComponent();

      comboBox1.Items.Clear();
      EditorUtils.FillEnum(comboBox1, typeof(DetailAggregate));

      tChart1.ClickSeries += tChart1_ClickSeries;

      master = new Bar(tChart1.Chart);
      master.Title = "Sample";
      master.ColorEach = true;

      master.Detail.Aggregate = DetailAggregate.Sum;
      master.BeginUpdate();

      master.Add("Cars", Color.Empty, 21, 14, 59, 8);
      master.Add("Lamps", Color.Empty, 5, 10, 20, 7);
      master.Add("Tables", Color.Empty, 17, 20, 6, 12);

      master.Detail[0].Labels[1] = "Ford";
      master.Detail[2].Labels[2] = "Wood";

      System.Data.DataSet data = master.DataSource as System.Data.DataSet;
      System.Data.DataTable dataTable = data.Tables[0];
      dataGridView1.DataBindings.Add("DataSource", data, dataTable.TableName);
      dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
      dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;


      master.EndUpdate();
    }

    void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
      DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
      if (rows.Count == 1)
      {
        SelectDetail(rows[0].Index);
      }

    }

    void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      master.manualData = true;
      master.CheckDataSource();
    }

    void tChart1_ClickSeries(object sender, Series s, int valueIndex, Drawing.MouseEventArgs e)
    {
      SelectDetail(valueIndex);

      for (int i = 0; i < dataGridView1.Rows.Count; i++)
      {
        dataGridView1.Rows[i].Selected = false;
      }

      dataGridView1.Rows[valueIndex].Selected = true;
    }

    private void SelectDetail(int valueIndex)
    {
      tChart2.Series.Clear();

      if (master.Detail.Count > valueIndex)
      {
        master.Detail[valueIndex].Color = master.ValueColor(valueIndex);
        master.Detail[valueIndex].Chart = tChart2.Chart;
        tChart2.Header.Text = master.Detail[valueIndex].Title;

        System.Data.DataSet data = tChart2[0].DataSource as System.Data.DataSet;
        System.Data.DataTable dataTable = data.Tables[0];
        dataGridView2.DataBindings.Clear();
        dataGridView2.DataBindings.Add("DataSource", data, dataTable.TableName);
        dataGridView2.CellEndEdit += dataGridView2_CellEndEdit;
      }
    }

    void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      tChart2[0].manualData = true;
      tChart2[0].CheckDataSource();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      master.Detail.Aggregate = (DetailAggregate)comboBox1.SelectedIndex;
    }

    private void InitializeComponent()
    {
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.tChart1 = new Steema.TeeChart.TChart();
      this.tChart2 = new Steema.TeeChart.TChart();
      this.splitContainer3 = new System.Windows.Forms.SplitContainer();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.Panel2.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(672, 62);
      this.textBox1.Text = "Click on the Bars on the upper Chart to see the Detail \'drill-down\' associated to " +
    "each \r\none of them.";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.comboBox1);
      this.panel1.Size = new System.Drawing.Size(672, 42);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.splitContainer1);
      this.panel2.Size = new System.Drawing.Size(672, 296);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
      this.splitContainer1.Size = new System.Drawing.Size(672, 296);
      this.splitContainer1.SplitterDistance = 456;
      this.splitContainer1.TabIndex = 0;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.tChart1);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.tChart2);
      this.splitContainer2.Size = new System.Drawing.Size(456, 296);
      this.splitContainer2.SplitterDistance = 149;
      this.splitContainer2.TabIndex = 0;
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Automatic = true;
      this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tChart1.Location = new System.Drawing.Point(0, 0);
      this.tChart1.Name = "tChart1";
      this.tChart1.Size = new System.Drawing.Size(456, 149);
      this.tChart1.TabIndex = 0;
      // 
      // tChart2
      // 
      // 
      // 
      // 
      this.tChart2.Axes.Automatic = true;
      this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tChart2.Location = new System.Drawing.Point(0, 0);
      this.tChart2.Name = "tChart2";
      this.tChart2.Size = new System.Drawing.Size(456, 143);
      this.tChart2.TabIndex = 0;
      // 
      // splitContainer3
      // 
      this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer3.Location = new System.Drawing.Point(0, 0);
      this.splitContainer3.Name = "splitContainer3";
      this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer3.Panel1
      // 
      this.splitContainer3.Panel1.Controls.Add(this.dataGridView1);
      // 
      // splitContainer3.Panel2
      // 
      this.splitContainer3.Panel2.Controls.Add(this.dataGridView2);
      this.splitContainer3.Size = new System.Drawing.Size(212, 296);
      this.splitContainer3.SplitterDistance = 138;
      this.splitContainer3.TabIndex = 0;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(212, 138);
      this.dataGridView1.TabIndex = 0;
      // 
      // dataGridView2
      // 
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView2.Location = new System.Drawing.Point(0, 0);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new System.Drawing.Size(212, 154);
      this.dataGridView2.TabIndex = 0;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Sum",
            "Count",
            "Average",
            "Min",
            "Max"});
      this.comboBox1.Location = new System.Drawing.Point(116, 3);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.Text = "Sum";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Aggregate method:";
      // 
      // Master_Detail
      // 
      this.ClientSize = new System.Drawing.Size(672, 400);
      this.Name = "Master_Detail";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.ResumeLayout(false);
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel2.ResumeLayout(false);
      this.splitContainer3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
  }
}
