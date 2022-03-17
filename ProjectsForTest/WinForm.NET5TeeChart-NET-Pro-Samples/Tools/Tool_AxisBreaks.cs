using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_AxisBreaks : Samples.BaseForm
	{
        private Steema.TeeChart.Styles.Line lineSeries1;
        private Button bPattern;
        private Button bPen;
        private ComboBox cbStyle;
        private Label label1;
        private TrackBar trackBar1;
        private Label label6;
        private Button button1;
		private System.ComponentModel.IContainer components = null;

        Steema.TeeChart.Tools.AxisBreaksTool axisBreak;
        Boolean existBreaks;

		public Tool_AxisBreaks()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

            tChart1.Aspect.View3D = false;
            tChart1.Series[0].FillSampleValues(100);
            cbStyle.SelectedIndex = 1;
            axisBreak = new Steema.TeeChart.Tools.AxisBreaksTool(tChart1.Chart);
            button1_Click(null, null);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_AxisBreaks));
            this.lineSeries1 = new Steema.TeeChart.Styles.Line();
            this.bPattern = new System.Windows.Forms.Button();
            this.bPen = new System.Windows.Forms.Button();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(631, 63);
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bPattern);
            this.panel1.Controls.Add(this.bPen);
            this.panel1.Controls.Add(this.cbStyle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Size = new System.Drawing.Size(631, 38);
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.AxisPen.Width = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Header.Alignment = Drawing.StringAlignment.Near;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Font.Italic = true;
            this.tChart1.Header.Lines = new string[] {
        "Axis Breaks Tool"};
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
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Series.Add(this.lineSeries1);
            this.tChart1.Size = new System.Drawing.Size(631, 349);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Visible = false;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 101);
            this.chartContainer.Size = new System.Drawing.Size(631, 349);
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
            this.lineSeries1.Marks.Callout.Series = this.lineSeries1;
            this.lineSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineSeries1.Marks.Callout.Visible = false;
            this.lineSeries1.Marks.Series = this.lineSeries1;
            // 
            // 
            // 
            this.lineSeries1.Pointer.Series = this.lineSeries1;
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
            // bPattern
            // 
            this.bPattern.Enabled = false;
            this.bPattern.Location = new System.Drawing.Point(552, 6);
            this.bPattern.Name = "bPattern";
            this.bPattern.Size = new System.Drawing.Size(75, 23);
            this.bPattern.TabIndex = 41;
            this.bPattern.Text = "Pattern";
#if VS2005
            this.bPattern.UseVisualStyleBackColor = true;
#endif
            this.bPattern.Click += new System.EventHandler(this.bPattern_Click);
            // 
            // bPen
            // 
            this.bPen.Enabled = false;
            this.bPen.Location = new System.Drawing.Point(471, 6);
            this.bPen.Name = "bPen";
            this.bPen.Size = new System.Drawing.Size(75, 23);
            this.bPen.TabIndex = 40;
            this.bPen.Text = "Border";
#if VS2005
            this.bPen.UseVisualStyleBackColor = true;
#endif
            this.bPen.Click += new System.EventHandler(this.bPen_Click);
            // 
            // cbStyle
            // 
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.Enabled = false;
#if VS2005
            this.cbStyle.FormattingEnabled = true;
#endif
            this.cbStyle.Items.AddRange(new object[] {
            "SmallZigZag",
            "ZigZag",
            "Line",
            "None"});
            this.cbStyle.Location = new System.Drawing.Point(348, 7);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(105, 21);
            this.cbStyle.TabIndex = 39;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "&Break style:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(159, 10);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(107, 20);
            this.trackBar1.TabIndex = 37;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "&Gap size:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add Breaks";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tool_AxisBreaks
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Name = "Tool_AxisBreaks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (existBreaks)
            {
                // Remove all breaks
                axisBreak.Breaks.Clear();
                existBreaks = false;
                button1.Text = "Add Breaks";
            }
            else
            {
                button1.Text = "Clear Breaks";
                existBreaks = true;
                // Add Breaks
                axisBreak.Axis = tChart1.Axes.Bottom;
                axisBreak.GapSize = 20;

                Steema.TeeChart.Tools.AxisBreak break1 = new Steema.TeeChart.Tools.AxisBreak(axisBreak);
                axisBreak.Breaks.Add(break1);
                break1.StartValue = 20;
                break1.EndValue = 30;

                Steema.TeeChart.Tools.AxisBreak break2 = new Steema.TeeChart.Tools.AxisBreak(axisBreak);
                axisBreak.Breaks.Add(break2);
                break2.StartValue = 50;
                break2.EndValue = 60;
            }

            trackBar1.Enabled = existBreaks;
            trackBar1.Value = axisBreak.GapSize;
            cbStyle.Enabled = existBreaks;
            bPen.Enabled = existBreaks;
            bPattern.Enabled = existBreaks;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axisBreak.GapSize = trackBar1.Value;
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStyle.Enabled)
                for (int i = 0; i < axisBreak.Breaks.Count; i++)
                    switch (cbStyle.SelectedIndex)
                    {
                        case 0: axisBreak.Breaks[i].Style = Steema.TeeChart.Tools.AxisBreakStyle.SmallZigZag; break;
                        case 1: axisBreak.Breaks[i].Style = Steema.TeeChart.Tools.AxisBreakStyle.ZigZag; break;
                        case 2: axisBreak.Breaks[i].Style = Steema.TeeChart.Tools.AxisBreakStyle.Line; break;
                        case 3: axisBreak.Breaks[i].Style = Steema.TeeChart.Tools.AxisBreakStyle.None; break;
                    }
        }

        private void bPen_Click(object sender, EventArgs e)
        {
            Steema.TeeChart.Editors.PenEditor.Edit(axisBreak.Pen);
            axisBreak.Invalidate();
        }

        private void bPattern_Click(object sender, EventArgs e)
        {
            Steema.TeeChart.Editors.BrushEditor.Edit(axisBreak.Brush, true);
            axisBreak.Invalidate();
        }

	}
}

