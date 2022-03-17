using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Line_Stack : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Styles.Line lineSeries3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
        private Steema.TeeChart.Styles.Line lineSeries4;
		private System.ComponentModel.IContainer components = null;

		public Line_Stack()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line_Stack));
            this.lineSeries1 = new Steema.TeeChart.Styles.Line();
            this.lineSeries2 = new Steema.TeeChart.Styles.Line();
            this.lineSeries3 = new Steema.TeeChart.Styles.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lineSeries4 = new Steema.TeeChart.Styles.Line();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 56);
            this.textBox1.Text = "Line Series can be Stacked and Overlaped. \r\nExample:\r\nlineSeries1.Stacked  = Stee" +
                "ma.TeeChart.Styles.CustomStack.Stack;";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Size = new System.Drawing.Size(466, 33);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 35;
            this.tChart1.Aspect.ZOffset = 0;
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
            this.tChart1.Legend.Visible = false;
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
            this.tChart1.Series.Add(this.lineSeries4);
            this.tChart1.Size = new System.Drawing.Size(466, 197);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Back.Brush.Visible = false;
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
            this.chartContainer.Location = new System.Drawing.Point(0, 89);
            this.chartContainer.Size = new System.Drawing.Size(466, 197);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Overlap",
            "Stack",
            "Stack 100%"});
            this.comboBox1.Location = new System.Drawing.Point(60, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lineSeries4
            // 
            // 
            // 
            // 
            this.lineSeries4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
            this.lineSeries4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
            this.lineSeries4.ColorEach = false;
            // 
            // 
            // 
            this.lineSeries4.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineSeries4.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineSeries4.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineSeries4.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineSeries4.Marks.Callout.Distance = 0;
            this.lineSeries4.Marks.Callout.Draw3D = false;
            this.lineSeries4.Marks.Callout.Length = 10;
            this.lineSeries4.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries4.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.lineSeries4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries4.Title = "lineSeries4";
            // 
            // 
            // 
            this.lineSeries4.XValues.DataMember = "X";
            this.lineSeries4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineSeries4.YValues.DataMember = "Y";
            // 
            // Line_Stack
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Line_Stack";
            this.Load += new System.EventHandler(this.Line_Stack_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Line_Stack_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (this.comboBox1.SelectedIndex)
			{
				case 0 : this.lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.None; break;
				case 1 : this.lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.Overlap; break;
				case 2 : this.lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.Stack; break;
				case 3 : this.lineSeries1.Stacked = Steema.TeeChart.Styles.CustomStack.Stack100; break;
			}
		}
	}
}

