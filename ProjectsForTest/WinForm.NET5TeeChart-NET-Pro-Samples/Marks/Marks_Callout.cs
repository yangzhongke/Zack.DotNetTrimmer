using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Marks_Callout : Samples.BaseForm
	{
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label2;
    private Steema.TeeChart.Styles.Bar bar1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Marks_Callout()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

      bar1.FillSampleValues();
      bar1.Marks.Callout.Style=Styles.PointerStyles.DownTriangle;
      comboBox1.SelectedIndex=3;
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bar1 = new Steema.TeeChart.Styles.Bar();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 64);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Series Marks new CallOut property, to change the appearance of lines connecting m" +
				"arks to series points.\r\n\r\nNew styles: Callout, rectangle, ellipse... and new pro" +
				"perties: size, brush, distance.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 40);
			this.panel1.TabIndex = 1;
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 25;
			
			
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Dash;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Dash;
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.AdjustFrame = false;
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Navy;
			this.tChart1.Header.Font.Size = 9;
			this.tChart1.Header.Lines = new string[] {
																								 "Series Marks Callout"};
			// 
			// tChart1.Header.Shadow
			// 
			// 
			// tChart1.Header.Shadow.Brush
			// 
			this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Header.Shadow.Height = 1;
			this.tChart1.Header.Shadow.Width = 1;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Symbol
			// 
			this.tChart1.Legend.Symbol.DefaultPen = false;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(223)), ((System.Byte)(227)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(244)), ((System.Byte)(244)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(244)), ((System.Byte)(244)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.bar1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			this.tChart1.TabIndex = 2;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 5;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Square",
																									 "Circle",
																									 "Triangle",
																									 "Down Triangle",
																									 "Cross",
																									 "Diagonal Cross",
																									 "Star",
																									 "Diamond",
																									 "Small Dot",
																									 "Nothing",
																									 "Left Triangle",
																									 "Right Triangle"});
			this.comboBox1.Location = new System.Drawing.Point(64, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Style:";
			// 
			// bar1
			// 
			this.bar1.BarStyle = Steema.TeeChart.Styles.BarStyles.Cylinder;
			// 
			// bar1.Brush
			// 
			this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// bar1.Marks
			// 
			// 
			// bar1.Marks.Symbol
			// 
			// 
			// bar1.Marks.Symbol.Shadow
			// 
			this.bar1.Marks.Symbol.Shadow.Height = 1;
			this.bar1.Marks.Symbol.Shadow.Visible = true;
			this.bar1.Marks.Symbol.Shadow.Width = 1;
			// 
			// bar1.Pen
			// 
			this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.bar1.Title = "bar1";
			// 
			// bar1.XValues
			// 
			this.bar1.XValues.DataMember = "X";
			this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar1.YValues
			// 
			this.bar1.YValues.DataMember = "Bar";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(200, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 24);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(296, 11);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(64, 16);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "&Visible";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// MarksCallout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "MarksCallout";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      bar1.Marks.Callout.Style=(Styles.PointerStyles)comboBox1.SelectedIndex;
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      Editors.ChartEditor.ShowModal(tChart1,Editors.ChartEditorTabs.Series);
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      bar1.Marks.Callout.Visible=checkBox1.Checked;
    }

	}
}

