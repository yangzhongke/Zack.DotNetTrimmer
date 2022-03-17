using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_GanttTool : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Gantt ganttSeries1;
		private Steema.TeeChart.Tools.GanttTool ganttTool1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.ComponentModel.IContainer components = null;

		public Tool_GanttTool()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Disable automatic sorting by date
			this.ganttSeries1.XValues.Order = TeeChart.Styles.ValueListOrder.None;
			// Fill Gantt with sample date-time values:
			this.ganttSeries1.Add(new System.DateTime(2002,4,1),new System.DateTime(2002,4,10),0,"A");
			this.ganttSeries1.Add(new System.DateTime(2002,4,5),new System.DateTime(2002,4,15),1,"B");
			this.ganttSeries1.Add(new System.DateTime(2002,4,2),new System.DateTime(2002,4,8),2,"C");
			this.ganttSeries1.Add(new System.DateTime(2002,4,9),new System.DateTime(2002,4,21),3,"D");

			// Make marks visible
			this.ganttSeries1.Marks.Visible = true;
			this.ganttSeries1.Marks.Shadow.Height = 0;
			this.ganttSeries1.Marks.Shadow.Width = 0;
			this.ganttSeries1.Marks.Gradient.Visible = true;
  
			// Set horizontal bottom axis minimum and maximum
			this.tChart1.Axes.Bottom.SetMinMax(new System.DateTime(2002,4,1),new System.DateTime(2002,5,1));

			// Set vertical left axis minimum and maximum
			this.tChart1.Axes.Left.SetMinMax( -2, 5 );
			this.tChart1.Axes.Left.Grid.Centered = false;

			// Disable zoom
            tChart1.Zoom.Direction = ZoomDirections.None;

            // Set horizontal daily Increment for labels and grids:
            this.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.OneDay); // one day
			this.tChart1.Axes.Bottom.Labels.Angle = 90;
			this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "dd-mmm";
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
			this.ganttSeries1 = new Steema.TeeChart.Styles.Gantt();
			this.ganttTool1 = new Steema.TeeChart.Tools.GanttTool();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(504, 32);
			this.textBox1.Text = "Gantt Tool offers mouse interaction to drag and resize Gantt bars.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Location = new System.Drawing.Point(0, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(504, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[0];
			this.tChart1.Location = new System.Drawing.Point(0, 65);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.ganttSeries1);
			this.tChart1.Size = new System.Drawing.Size(504, 276);
			this.tChart1.Tools.Add(this.ganttTool1);
			this.tChart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseUp);
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
			this.ganttSeries1.Title = "ganttSeries1";
			// 
			// ganttSeries1.StartValues
			// 
			this.ganttSeries1.XValues.DataMember = "Start";
			this.ganttSeries1.XValues.DateTime = true;
			// 
			// ganttSeries1.YValues
			// 
			this.ganttSeries1.YValues.DataMember = "Y";
			this.ganttSeries1.GetSeriesMark += new Steema.TeeChart.Styles.Series.GetSeriesMarkEventHandler(this.ganttSeries1_GetSeriesMark);
			// 
			// ganttTool1
			// 
			this.ganttTool1.Series = this.ganttSeries1;
			this.ganttTool1.DragBar += new Steema.TeeChart.Tools.GanttDragEventHandler(this.ganttTool1_DragBar);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "One day",
																									 "One week",
																									 "Half month",
																									 "One month"});
			this.comboBox1.Location = new System.Drawing.Point(13, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(153, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(34, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "<<";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(193, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(34, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = ">>";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(253, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(34, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "><";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(293, 6);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(34, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "<>";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Tool_GanttTool
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(504, 341);
			this.Name = "Tool_GanttTool";
			this.Load += new System.EventHandler(this.Tool_GanttTool_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Tool_GanttTool_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (this.comboBox1.SelectedIndex)
			{
				case 0: this.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.OneDay); break;
				case 1: this.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.OneWeek); break;
				case 2: this.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.HalfMonth); break;
				case 3: this.tChart1.Axes.Bottom.Increment = Convert.ToDouble(TeeChart.DateTimeSteps.OneMonth); break;
			}
		}

		private void ganttSeries1_GetSeriesMark(Steema.TeeChart.Styles.Series series, Steema.TeeChart.Styles.GetSeriesMarkEventArgs e)
		{
			// Example, customize Series marks...
			switch (e.ValueIndex)
			{
				case 0: e.MarkText = "John"; break;
				case 1: e.MarkText = "Ann"; break;
				case 2: e.MarkText = "David"; break;
				case 3: e.MarkText = "Carol"; break;
			}
		}

		private void tChart1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.tChart1.Header.Text = "";
		}

		private void ganttTool1_DragBar(object sender, Steema.TeeChart.Tools.GanttDragEventArgs e)
		{
			this.tChart1.Header.Text = (sender as TeeChart.Tools.GanttTool).Gantt.StartValues[e.Bar].ToString() + " "+
				(sender as TeeChart.Tools.GanttTool).Gantt.EndValues[e.Bar].ToString();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.tChart1.Axes.Bottom.Scroll(-1,false);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.tChart1.Axes.Bottom.Scroll(1,false);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.tChart1.Axes.Bottom.SetMinMax(this.tChart1.Axes.Bottom.Minimum+1,
											this.tChart1.Axes.Bottom.Maximum -1);
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.tChart1.Axes.Bottom.SetMinMax(this.tChart1.Axes.Bottom.Minimum-1,
				this.tChart1.Axes.Bottom.Maximum +1);		
		}
	}
}

