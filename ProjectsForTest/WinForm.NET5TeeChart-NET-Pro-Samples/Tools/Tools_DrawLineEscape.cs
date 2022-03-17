using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tools_DrawLineEscape : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.FastLine fastLineSeries1;
		private Steema.TeeChart.Tools.DrawLine drawLine1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label NumLines;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private Label label2;
		private ComboBox cbKeys;
		private System.ComponentModel.IContainer components = null;

		public Tools_DrawLineEscape()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.fastLineSeries1.FillSampleValues(100);

			ArrayList list = new ArrayList();
			list.AddRange(Enum.GetNames(typeof(Keys)));
			list.Sort();

			this.cbKeys.Items.AddRange(list.ToArray());
			this.cbKeys.SelectedIndex = list.IndexOf("Escape");
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools_DrawLineEscape));
			this.fastLineSeries1 = new Steema.TeeChart.Styles.FastLine();
			this.drawLine1 = new Steema.TeeChart.Tools.DrawLine();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NumLines = new System.Windows.Forms.Label();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.label2 = new System.Windows.Forms.Label();
			this.cbKeys = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(425, 59);
			this.textBox1.Text = "Use the new EscapeKey property to select a key you can use to delete a line\r\nwhil" +
    "e it is being drawn.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbKeys);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.NumLines);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 59);
			this.panel1.Size = new System.Drawing.Size(425, 65);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.View3D = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Bottom.Labels.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Bottom.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Depth.Labels.Bevel.StringColorTwo = "FF808080";
			this.tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Depth.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorTwo = "FF808080";
			this.tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.DepthTop.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Left.Labels.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Left.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Right.Labels.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Right.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Top.Labels.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Axes.Top.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Footer.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Footer.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Header.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Header.Bevel.StringColorTwo = "FF808080";
			this.tChart1.Header.Lines = new string[] {
        "tChart1"};
			this.tChart1.Header.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Legend.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Title.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Legend.Title.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Panel.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Series.Add(this.fastLineSeries1);
			this.tChart1.Size = new System.Drawing.Size(425, 146);
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubFooter.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.SubFooter.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.SubHeader.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.SubHeader.Bevel.StringColorTwo = "FF808080";
			this.tChart1.Tools.Add(this.drawLine1);
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
			this.tChart1.Walls.Back.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Walls.Back.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Bottom.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Walls.Bottom.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Left.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Walls.Left.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Right.Bevel.StringColorOne = "FFFFFFFF";
			this.tChart1.Walls.Right.Bevel.StringColorTwo = "FF808080";
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 124);
			this.chartContainer.Size = new System.Drawing.Size(425, 146);
			// 
			// fastLineSeries1
			// 
			this.fastLineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			this.fastLineSeries1.ColorEach = false;
			// 
			// 
			// 
			this.fastLineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLineSeries1.Marks.Bevel.StringColorOne = "FFFFFFFF";
			this.fastLineSeries1.Marks.Bevel.StringColorTwo = "FF808080";
			// 
			// 
			// 
			// 
			// 
			// 
			this.fastLineSeries1.Marks.Symbol.Bevel.StringColorOne = "FFFFFFFF";
			this.fastLineSeries1.Marks.Symbol.Bevel.StringColorTwo = "FF808080";
			this.fastLineSeries1.Title = "fastLineSeries1";
			this.fastLineSeries1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
			// 
			// 
			// 
			this.fastLineSeries1.XValues.DataMember = "X";
			this.fastLineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.fastLineSeries1.YValues.DataMember = "Y";
			// 
			// drawLine1
			// 
			this.drawLine1.Style = Steema.TeeChart.Tools.DrawLineStyle.Line;
			this.drawLine1.NewLine += new Steema.TeeChart.Tools.DrawLineEventHandler(this.drawLine1_NewLine);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(12, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(116, 20);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Active";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(81, 9);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(116, 20);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Enable Draw";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(179, 10);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(116, 19);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Enable &Selection";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(301, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Lines :";
			this.label1.UseMnemonic = false;
			// 
			// NumLines
			// 
			this.NumLines.AutoSize = true;
			this.NumLines.Location = new System.Drawing.Point(343, 13);
			this.NumLines.Name = "NumLines";
			this.NumLines.Size = new System.Drawing.Size(13, 13);
			this.NumLines.TabIndex = 4;
			this.NumLines.Text = "0";
			this.NumLines.UseMnemonic = false;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Key:";
			// 
			// cbKeys
			// 
#if VS2005
			this.cbKeys.FormattingEnabled = true;
#endif
			this.cbKeys.Location = new System.Drawing.Point(46, 35);
			this.cbKeys.Name = "cbKeys";
			this.cbKeys.Size = new System.Drawing.Size(121, 21);
			this.cbKeys.TabIndex = 6;
			this.cbKeys.SelectedIndexChanged += new System.EventHandler(this.cbKeys_SelectedIndexChanged);
			// 
			// Tools_DrawLineEscape
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(425, 270);
			this.Name = "Tools_DrawLineEscape";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.drawLine1.DeleteSelected();
			NumLines.Text = this.drawLine1.Lines.Count.ToString();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.drawLine1.Active = this.checkBox1.Checked;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (cbKeys.SelectedIndex)
			{
				case 0 : this.drawLine1.Button = Drawing.MouseButtons.Left; break;
				case 1 : this.drawLine1.Button = Drawing.MouseButtons.Right; break;
				case 2 : this.drawLine1.Button = Drawing.MouseButtons.Middle; break;
			}
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.drawLine1.EnableDraw = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			this.drawLine1.EnableSelect = checkBox3.Checked;
		}

		private void drawLine1_NewLine(Steema.TeeChart.Tools.DrawLine sender)
		{
			NumLines.Text = this.drawLine1.Lines.Count.ToString();
		}

		private void cbKeys_SelectedIndexChanged(object sender, EventArgs e)
		{
			var key = (Drawing.Keys)Enum.Parse(typeof(Drawing.Keys), cbKeys.SelectedItem.ToString());
			this.drawLine1.EscapeKey = key;
		}
	}
}

