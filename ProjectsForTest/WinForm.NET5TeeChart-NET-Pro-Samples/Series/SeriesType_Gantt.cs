using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class SeriesType_Gantt : Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Gantt ganttSeries1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Gantt()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			ganttSeries1.FillSampleValues(10);
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ganttSeries1 = new Steema.TeeChart.Styles.Gantt();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 72);
			this.textBox1.Text = "For scheduling applications, the Gantt chart style allows points with start and e" +
				"nd dates.\r\n\r\nOptions include point style, label, marks, color, border, pattern, " +
				"drag and drop of bars, connecting lines, click events, etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Gantt - Scheduling"};
			this.tChart1.Location = new System.Drawing.Point(0, 113);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.ganttSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 173);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(20, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(52, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&3D";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(113, 7);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ganttSeries1
			// 
			this.ganttSeries1.ColorEach = true;
			// 
			// ganttSeries1.EndValues
			// 
			this.ganttSeries1.EndValues.DataMember = "End";
			this.ganttSeries1.EndValues.DateTime = true;
			this.ganttSeries1.LabelMember = "Labels";
			// 
			// ganttSeries1.LinePen
			// 
			this.ganttSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			// 
			// ganttSeries1.Marks
			// 
			// 
			// ganttSeries1.Marks.Symbol
			// 
			// 
			// ganttSeries1.Marks.Symbol.Shadow
			// 
			this.ganttSeries1.Marks.Symbol.Shadow.Height = 1;
			this.ganttSeries1.Marks.Symbol.Shadow.Visible = true;
			this.ganttSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// ganttSeries1.NextTasks
			// 
			this.ganttSeries1.NextTasks.DataMember = "NextTask";
			// 
			// ganttSeries1.Pointer
			// 
			// 
			// ganttSeries1.Pointer.Brush
			// 
			this.ganttSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.ganttSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			this.ganttSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// ganttSeries1.StartValues
			// 
			this.ganttSeries1.StartValues.DataMember = "Start";
			this.ganttSeries1.StartValues.DateTime = true;
			this.ganttSeries1.Title = "gantt1";
			// 
			// ganttSeries1.StartValues
			// 
			this.ganttSeries1.XValues.DataMember = "Start";
			this.ganttSeries1.XValues.DateTime = true;
			// 
			// ganttSeries1.YValues
			// 
			this.ganttSeries1.YValues.DataMember = "Y";
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Gantt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Gantt";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			tChart1.Aspect.View3D = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.ganttSeries1);
		}
	}
}

