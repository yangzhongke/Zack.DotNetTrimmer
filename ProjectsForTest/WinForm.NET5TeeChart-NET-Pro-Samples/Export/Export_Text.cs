using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Export_Text : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Styles.Line lineSeries3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Button button2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Export_Text()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			foreach (Steema.TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(10);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_Text));
            this.lineSeries1 = new Steema.TeeChart.Styles.Line();
            this.lineSeries2 = new Steema.TeeChart.Styles.Line();
            this.lineSeries3 = new Steema.TeeChart.Styles.Line();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 63);
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Size = new System.Drawing.Size(466, 78);
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
            this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Visible = false;
            this.tChart1.Axes.Right.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Visible = false;
            this.tChart1.Axes.Top.Visible = false;
            this.tChart1.Cursor = Cursors.Default;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tChart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Visible = false;
            this.tChart1.Legend.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.lineSeries1);
            this.tChart1.Series.Add(this.lineSeries2);
            this.tChart1.Series.Add(this.lineSeries3);
            this.tChart1.Size = new System.Drawing.Size(466, 145);
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
            this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Walls.Back.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 5;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 141);
            this.chartContainer.Size = new System.Drawing.Size(466, 145);
            // 
            // lineSeries1
            // 
            // 
            // 
            // 
            this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.lineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.lineSeries1.ColorEach = false;
            // 
            // 
            // 
            this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineSeries1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineSeries1.Marks.Callout.Distance = 0;
            this.lineSeries1.Marks.Callout.Draw3D = false;
            this.lineSeries1.Marks.Callout.Length = 10;
            this.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries1.Title = "lineSeries1";
            // 
            // 
            // 
            this.lineSeries1.XValues.DataMember = "X";
            this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineSeries1.YValues.DataMember = "Y";
            // 
            // lineSeries2
            // 
            // 
            // 
            // 
            this.lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.lineSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.lineSeries2.ColorEach = false;
            // 
            // 
            // 
            this.lineSeries2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineSeries2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineSeries2.Marks.Callout.Distance = 0;
            this.lineSeries2.Marks.Callout.Draw3D = false;
            this.lineSeries2.Marks.Callout.Length = 10;
            this.lineSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries2.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries2.Title = "lineSeries2";
            // 
            // 
            // 
            this.lineSeries2.XValues.DataMember = "X";
            this.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineSeries2.YValues.DataMember = "Y";
            // 
            // lineSeries3
            // 
            // 
            // 
            // 
            this.lineSeries3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.lineSeries3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.lineSeries3.ColorEach = false;
            // 
            // 
            // 
            this.lineSeries3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineSeries3.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineSeries3.Marks.Callout.Distance = 0;
            this.lineSeries3.Marks.Callout.Draw3D = false;
            this.lineSeries3.Marks.Callout.Length = 10;
            this.lineSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries3.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.lineSeries3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries3.Title = "lineSeries3";
            // 
            // 
            // 
            this.lineSeries3.XValues.DataMember = "X";
            this.lineSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineSeries3.YValues.DataMember = "Y";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Save to Text...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Title = "Save Data (Text)";
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(287, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Include &labels";
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(287, 28);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Include &index";
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(287, 49);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(129, 20);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Include &header";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(136, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show &export dialog...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // Export_Text
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Export_Text";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.DefaultExt = tChart1.Export.Data.Text.FileExtension;
			saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter="Text files (*.csv;*.txt)|*.csv;*.txt";
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tChart1.Export.Data.Text.Series = this.lineSeries1; // export only 1st series
				tChart1.Export.Data.Text.IncludeLabels = checkBox1.Checked;
				tChart1.Export.Data.Text.IncludeIndex = checkBox2.Checked;
				tChart1.Export.Data.Text.IncludeHeader = checkBox3.Checked;
				tChart1.Export.Data.Text.Save(this.saveFileDialog1.FileName);
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
      tChart1.Export.ShowExportDialog(tChart1.Export.Data.Text);
		}
	}
}

