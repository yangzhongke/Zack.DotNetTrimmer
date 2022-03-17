using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_DragPoint : Samples.BaseForm
    {
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
        private Steema.TeeChart.Tools.DragPoint dragPoint1;
        private Steema.TeeChart.Styles.Points points1;
		private System.ComponentModel.IContainer components = null;

		public Tool_DragPoint()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

            this.points1.FillSampleValues(20);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_DragPoint));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dragPoint1 = new Steema.TeeChart.Tools.DragPoint();
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 48);
            this.textBox1.Text = "The Drag Point tool allows clicking and moving Series points at run-time, using t" +
                "he mouse.\r\nClick and drag a point !";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Size = new System.Drawing.Size(466, 41);
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
            this.tChart1.Axes.Bottom.MaximumOffset = 5;
            this.tChart1.Axes.Bottom.MinimumOffset = 5;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 5;
            this.tChart1.Axes.Left.MinimumOffset = 5;
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            this.tChart1.Series.Add(this.points1);
            this.tChart1.Size = new System.Drawing.Size(466, 197);
            this.tChart1.Tools.Add(this.dragPoint1);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 89);
            this.chartContainer.Size = new System.Drawing.Size(466, 197);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(13, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "&Active";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "X only",
            "Y only",
            "X and Y"});
            this.comboBox1.Location = new System.Drawing.Point(130, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Style:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(273, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Edit...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dragPoint1
            // 
            this.dragPoint1.Cursor = Drawing.Cursors.Hand;
            this.dragPoint1.Series = this.points1;
            // 
            // points1
            // 
            this.points1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.points1.ColorEach = false;
            // 
            // 
            // 
            this.points1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.points1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.points1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.points1.Marks.Callout.Distance = 0;
            this.points1.Marks.Callout.Draw3D = false;
            this.points1.Marks.Callout.Length = 0;
            this.points1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.points1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.points1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.points1.Title = "points1";
            // 
            // 
            // 
            this.points1.XValues.DataMember = "X";
            this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points1.YValues.DataMember = "Y";
            // 
            // Tool_DragPoint
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "Tool_DragPoint";
            this.Load += new System.EventHandler(this.Tools_DragPoint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dragPoint1.Active = checkBox1.Checked;
		}

		private void Tools_DragPoint_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 2;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.dragPoint1.Style = (Steema.TeeChart.Tools.DragPointStyles)comboBox1.SelectedIndex;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.Tools.ToolsEditor.ShowEditor(this.dragPoint1);
		}
	}
}

