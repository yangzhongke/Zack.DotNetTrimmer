using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_Cursor : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Axis axis1;
		private Steema.TeeChart.Tools.CursorTool cursorTool1;
		private Steema.TeeChart.Tools.CursorTool cursorTool2;
		private System.ComponentModel.IContainer components = null;

    private bool flag;

		public Tool_Cursor()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.lineSeries1.FillSampleValues(100);
			this.lineSeries2.FillSampleValues(100);
			this.tChart1.Axes.Left.AutomaticMinimum = false;
			this.tChart1.Axes.Left.Minimum = 0.0;
			this.lineSeries2.CustomVertAxis = this.axis1;
      this.tChart1.BeforeDrawSeries += new PaintChartEventHandler(tChart1_BeforeDrawSeries);
      flag = true;

			this.cursorTool1.Pen.Color = Color.Navy;
			this.cursorTool1.Pen.Style = Drawing.DashStyle.Dash; 
			this.cursorTool1.Pen.Width = 2;

			this.cursorTool2.Pen.Color = Color.Plum;
			this.cursorTool2.Pen.Style = Drawing.DashStyle.Dot; 
			this.cursorTool2.Pen.Width = 2;

		}

    void tChart1_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      if (flag)
      {
        // place upper series cursor in the middle
        this.cursorTool1.XValue = 0.5 * (this.lineSeries1.XValues.Maximum + this.lineSeries1.XValues.Minimum);
        flag = false;
      }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_Cursor));
            this.lineSeries1 = new Steema.TeeChart.Styles.Line();
            this.lineSeries2 = new Steema.TeeChart.Styles.Line();
            this.axis1 = new Steema.TeeChart.Axis(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
            this.cursorTool2 = new Steema.TeeChart.Tools.CursorTool();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(406, 56);
            this.textBox1.Text = "Cursor Tool is used to display vertical and / or horizontal lines on top of chart" +
                "s. Cursors can be dragged by mouse or by code at runtime. They notify position c" +
                "hanges with the OnChange event.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Size = new System.Drawing.Size(406, 52);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.View3D = false;
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Custom.Add(this.axis1);
            // 
            // 
            // 
            this.tChart1.Axes.Left.EndPosition = 50;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Size = 7;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 7F;
            this.tChart1.Axes.Left.LogarithmicBase = 2;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "Cursor tool example"};
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.lineSeries1);
            this.tChart1.Series.Add(this.lineSeries2);
            this.tChart1.Size = new System.Drawing.Size(406, 155);
            this.tChart1.Tools.Add(this.cursorTool1);
            this.tChart1.Tools.Add(this.cursorTool2);
            this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 108);
            this.chartContainer.Size = new System.Drawing.Size(406, 155);
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
            this.lineSeries1.Title = "line1";
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
            this.lineSeries2.CustomVertAxis = this.axis1;
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
            this.lineSeries2.Title = "line2";
            this.lineSeries2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
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
            // axis1
            // 
            this.axis1.Horizontal = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.axis1.Labels.Font.Size = 7;
            this.axis1.Labels.Font.SizeFloat = 7F;
            this.axis1.OtherSide = false;
            this.axis1.StartPosition = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.UseMnemonic = false;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(107, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 23);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "&Snap";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(167, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 23);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "&Active";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(247, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Edit...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cursorTool1
            // 
            this.cursorTool1.Series = this.lineSeries1;
            this.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            this.cursorTool1.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool1_Change);
            // 
            // cursorTool2
            // 
            this.cursorTool2.FollowMouse = true;
            this.cursorTool2.Series = this.lineSeries2;
            this.cursorTool2.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool2_Change);
            // 
            // Tool_Cursor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(406, 263);
            this.Name = "Tool_Cursor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.cursorTool1.Snap = this.checkBox1.Checked;
			this.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.cursorTool1.Active = this.checkBox2.Checked;
		}

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
		{
			Steema.TeeChart.Drawing.IGraphics3D gr = this.tChart1.Graphics3D;
			// TODO : add custom horizontal line where the axes meet
		}

		private void cursorTool1_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
		{
			// show the cursor values...
			this.label1.Text = "X="+e.XValue.ToString("#.00");
		}

		private void cursorTool2_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
		{
			// show the cursor values...
			this.label2.Text = "X="+e.XValue.ToString("#.00")+"; Y="+e.YValue.ToString("#.00");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.Tools.ToolsEditor.ShowEditor(this.cursorTool1);
		}
	}
}

