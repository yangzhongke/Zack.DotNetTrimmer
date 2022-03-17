using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Export_HTML : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar barSeries1;
		private Steema.TeeChart.Styles.Bar barSeries2;
		private Steema.TeeChart.Styles.Bar barSeries3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.ComponentModel.IContainer components = null;

		public Export_HTML()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			this.barSeries1.Add(3,"A");
			this.barSeries1.Add(0,"B");
			this.barSeries1.Add(-3,"C");
			this.barSeries2.Add(2,"A");
			this.barSeries2.Add(-2,"B");
			this.barSeries2.Add(3,"C");
			this.barSeries3.Add(1,"A");
			this.barSeries3.Add(1,"B");
			this.barSeries3.Add(2,"C");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_HTML));
            this.barSeries1 = new Steema.TeeChart.Styles.Bar();
            this.barSeries2 = new Steema.TeeChart.Styles.Bar();
            this.barSeries3 = new Steema.TeeChart.Styles.Bar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 63);
            this.textBox1.Text = "Series data can be exported to HTML tables. It allows saving to file and copying " +
                "to clipboard. There are several options when exporting t\'o text format, such as " +
                "include labels, point\'s index, etc.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button2);
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
            this.tChart1.Axes.Bottom.MaximumOffset = 28;
            this.tChart1.Axes.Bottom.MinimumOffset = 28;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 37;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            // 
            // 
            // 
            this.tChart1.Legend.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.barSeries1);
            this.tChart1.Series.Add(this.barSeries2);
            this.tChart1.Series.Add(this.barSeries3);
            this.tChart1.Size = new System.Drawing.Size(466, 145);
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Visible = false;
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
            // barSeries1
            // 
            // 
            // 
            // 
            this.barSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.barSeries1.ColorEach = false;
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
            this.barSeries1.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
            // 
            // 
            // 
            this.barSeries1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.barSeries1.StackGroup = 1;
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
            // barSeries2
            // 
            // 
            // 
            // 
            this.barSeries2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.barSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.barSeries2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.barSeries2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.barSeries2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.barSeries2.Marks.Callout.Distance = 0;
            this.barSeries2.Marks.Callout.Draw3D = false;
            this.barSeries2.Marks.Callout.Length = 20;
            this.barSeries2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.barSeries2.Marks.Callout.Visible = false;
            this.barSeries2.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
            // 
            // 
            // 
            this.barSeries2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.barSeries2.StackGroup = 1;
            this.barSeries2.Title = "barSeries2";
            // 
            // 
            // 
            this.barSeries2.XValues.DataMember = "X";
            this.barSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.barSeries2.YValues.DataMember = "Bar";
            // 
            // barSeries3
            // 
            // 
            // 
            // 
            this.barSeries3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.barSeries3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.barSeries3.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.barSeries3.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.barSeries3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.barSeries3.Marks.Callout.Distance = 0;
            this.barSeries3.Marks.Callout.Draw3D = false;
            this.barSeries3.Marks.Callout.Length = 20;
            this.barSeries3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.barSeries3.Marks.Callout.Visible = false;
            this.barSeries3.MultiBar = Steema.TeeChart.Styles.MultiBars.Stacked;
            // 
            // 
            // 
            this.barSeries3.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
            this.barSeries3.Title = "barSeries3";
            // 
            // 
            // 
            this.barSeries3.XValues.DataMember = "X";
            this.barSeries3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.barSeries3.YValues.DataMember = "Bar";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Save to HTML...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(152, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show &export dialog...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Title = "Save Data (HTML)";
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(327, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Include &labels";
            // 
            // checkBox2
            // 
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(327, 28);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 21);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Include &index";
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(327, 49);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 20);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Include &header";
            // 
            // Export_HTML
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Export_HTML";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			tChart1.Export.ShowExportDialog(tChart1.Export.Data.HTML);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.DefaultExt = tChart1.Export.Data.HTML.FileExtension;
			saveFileDialog1.FileName = tChart1.Name+ "."+saveFileDialog1.DefaultExt;
      saveFileDialog1.Filter="HTML files (*.htm;*.html)|*.htm;*.html";
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tChart1.Export.Data.HTML.Series = null; // export all series
				tChart1.Export.Data.HTML.IncludeLabels = checkBox1.Checked;
				tChart1.Export.Data.HTML.IncludeIndex = checkBox2.Checked;
				tChart1.Export.Data.HTML.IncludeHeader = checkBox3.Checked;
				tChart1.Export.Data.HTML.Save(this.saveFileDialog1.FileName);
			}
		}
	}
}

