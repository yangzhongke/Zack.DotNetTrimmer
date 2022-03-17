using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_CursorSynchro : Steema.TeeChart.Samples.BaseNoChart
	{
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.Styles.Line lineSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Tools.CursorTool cursorSRC;
		private Steema.TeeChart.TChart tChart2;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Tools.CursorTool cursorDEST;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;


		/// <summary>
		/// This procedure synchronizes two cursors.
		/// "SRC" is the original cursor, and "DEST" the cursor
		/// that is re-positioned.
		/// </summary>
		private void CursorSynchronize(Steema.TeeChart.Tools.CursorTool SRC, Steema.TeeChart.Tools.CursorTool DEST)
		{
			/* DEST.Chart.AutoRepaint = false; // stop repainting
				TODO: DEST.RedrawCursor();   // hide cursor
			*/

			DEST.XValue = SRC.XValue;
			DEST.YValue = SRC.YValue;

			/* TODO: DEST.RedrawCursor();   // draw cursor again
			DEST.Chart.AutoRepaint = true; // enable repainting
			*/
		}

		private void ShowXY(double X, double Y)
		{
			this.label1.Text = X.ToString("#.00") + "   " + Y.ToString("#.00");
		}

		public Tool_CursorSynchro()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			this.lineSeries1.FillSampleValues(1000);
			this.lineSeries2.DataSource = this.lineSeries1;

			// Setup cursors
			this.cursorSRC.FollowMouse = true;
			this.cursorSRC.Series = this.lineSeries1;
			this.cursorSRC.XValue = 500;
			this.cursorSRC.YValue = 0.5*(this.lineSeries1.YValues.Maximum + this.lineSeries1.YValues.Minimum);

			this.cursorDEST.Series = this.lineSeries2;
			this.cursorDEST.FollowMouse = true;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_CursorSynchro));
            this.tChart1 = new Steema.TeeChart.TChart();
            this.lineSeries1 = new Steema.TeeChart.Styles.Line();
            this.cursorSRC = new Steema.TeeChart.Tools.CursorTool();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.lineSeries2 = new Steema.TeeChart.Styles.Line();
            this.cursorDEST = new Steema.TeeChart.Tools.CursorTool();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(426, 54);
            this.textBox1.Text = "Cursors can be synchronized as this example shows. Both Chart1 and Chart2 contain" +
                " a Cursor tool. The Cursor tool OnChange event is used to synchronize the other." +
                "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Size = new System.Drawing.Size(426, 48);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tChart2);
            this.panel2.Controls.Add(this.tChart1);
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Size = new System.Drawing.Size(426, 156);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.View3D = false;
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.BackColor = System.Drawing.Color.Transparent;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(0, 0);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tChart1.Series.Add(this.lineSeries1);
            this.tChart1.Size = new System.Drawing.Size(300, 156);
            this.tChart1.TabIndex = 0;
            this.tChart1.Tools.Add(this.cursorSRC);
            // 
            // lineSeries1
            // 
            // 
            // 
            // 
            this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineSeries1.ColorEach = false;
            this.lineSeries1.Cursor = Drawing.Cursors.Cross;
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
            // cursorSRC
            // 
            this.cursorSRC.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorSRC_Change);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(13, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "&Follow mouse";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tChart2
            // 
            // 
            // 
            // 
            this.tChart2.Aspect.View3D = false;
            this.tChart2.Aspect.ZOffset = 0;
            this.tChart2.BackColor = System.Drawing.Color.Transparent;
            this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.tChart2.Header.Lines = new string[] {
        "tChart2"};
            // 
            // 
            // 
            this.tChart2.Legend.Visible = false;
            this.tChart2.Location = new System.Drawing.Point(300, 0);
            this.tChart2.Name = "tChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tChart2.Series.Add(this.lineSeries2);
            this.tChart2.Size = new System.Drawing.Size(126, 156);
            this.tChart2.TabIndex = 1;
            this.tChart2.Tools.Add(this.cursorDEST);
            // 
            // lineSeries2
            // 
            // 
            // 
            // 
            this.lineSeries2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.lineSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.lineSeries2.ColorEach = false;
            this.lineSeries2.Cursor = Drawing.Cursors.Cross;
            // 
            // 
            // 
            this.lineSeries2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
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
            // cursorDEST
            // 
            this.cursorDEST.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorDEST_Change);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(127, 14);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "&Synchronize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0,0";
            this.label1.UseMnemonic = false;
            // 
            // Tool_CursorSynchro
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(426, 258);
            this.Name = "Tool_CursorSynchro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.cursorSRC.FollowMouse = this.checkBox1.Checked;
			this.cursorDEST.FollowMouse = this.checkBox1.Checked;
		}

		private void cursorSRC_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
		{
			if (this.checkBox2.Checked)
				CursorSynchronize(sender as Steema.TeeChart.Tools.CursorTool, this.cursorDEST);
			ShowXY(e.XValue, e.YValue);
		}

		private void cursorDEST_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
		{
			if (this.checkBox2.Checked)
				CursorSynchronize(sender as Steema.TeeChart.Tools.CursorTool, this.cursorSRC);
			ShowXY(e.XValue, e.YValue);
		}
	}
}

