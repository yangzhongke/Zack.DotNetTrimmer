using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_Annotation : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Tools.Annotation annotation1;
		private Steema.TeeChart.Tools.Annotation annotation2;
		private Steema.TeeChart.Tools.Annotation annotation3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components = null;

		public Tool_Annotation()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.lineSeries1.FillSampleValues(20);
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.annotation1 = new Steema.TeeChart.Tools.Annotation();
			this.annotation2 = new Steema.TeeChart.Tools.Annotation();
			this.annotation3 = new Steema.TeeChart.Tools.Annotation();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "The Annotation tool is a general purpose component to show text over Chart panels" +
				". It includes formatting properties and custom positioning.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
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
			this.tChart1.Header.Lines = new string[] {
																								 "Annotation tool example"};
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			this.tChart1.Tools.Add(this.annotation1);
			this.tChart1.Tools.Add(this.annotation2);
			this.tChart1.Tools.Add(this.annotation3);
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries1.Pointer
			// 
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "line1";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.DataMember = "X";
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries1.YValues
			// 
			this.lineSeries1.YValues.DataMember = "Y";
			// 
			// annotation1
			// 
			this.annotation1.Cursor = Drawing.Cursors.Default;
			this.annotation1.Left = 65;
			// 
			// annotation1.Shape
			// 
			this.annotation1.Shape.Bottom = 142;
			this.annotation1.Shape.CustomPosition = true;
			this.annotation1.Shape.Left = 65;
			this.annotation1.Shape.Lines = new string[] {
																										"Annotation1"};
			this.annotation1.Shape.Right = 133;
			// 
			// annotation1.Shape.Shadow
			// 
			// 
			// annotation1.Shape.Shadow.Brush
			// 
			this.annotation1.Shape.Shadow.Brush.Color = System.Drawing.Color.Gray;
			this.annotation1.Shape.Shadow.Visible = true;
			this.annotation1.Shape.Top = 125;
			this.annotation1.Text = "Annotation1";
			this.annotation1.Top = 125;
			// 
			// annotation2
			// 
			this.annotation2.Cursor = Drawing.Cursors.Default;
			this.annotation2.Left = 130;
			// 
			// annotation2.Shape
			// 
			this.annotation2.Shape.Bottom = 87;
			// 
			// annotation2.Shape.Brush
			// 
			this.annotation2.Shape.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.annotation2.Shape.CustomPosition = true;
			this.annotation2.Shape.Left = 130;
			this.annotation2.Shape.Lines = new string[] {
																										"Annotation 2"};
			this.annotation2.Shape.Right = 201;
			// 
			// annotation2.Shape.Shadow
			// 
			// 
			// annotation2.Shape.Shadow.Brush
			// 
			this.annotation2.Shape.Shadow.Brush.Color = System.Drawing.Color.Black;
			this.annotation2.Shape.Shadow.Visible = true;
			this.annotation2.Shape.Top = 70;
			this.annotation2.Text = "Annotation 2";
			this.annotation2.Top = 70;
			// 
			// annotation3
			// 
			this.annotation3.Cursor = Drawing.Cursors.Default;
			this.annotation3.Position = Steema.TeeChart.Tools.AnnotationPositions.RightTop;
			// 
			// annotation3.Shape
			// 
			// 
			// annotation3.Shape.Bevel
			// 
			this.annotation3.Shape.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Raised;
			// 
			// annotation3.Shape.Brush
			// 
			this.annotation3.Shape.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.annotation3.Shape.Lines = new string[] {
																										"Another one"};
			// 
			// annotation3.Shape.Shadow
			// 
			this.annotation3.Shape.Shadow.Visible = true;
			this.annotation3.Text = "Another one";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(13, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Edit annotation...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(147, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(93, 21);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "&Visible";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Tool_Annotation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Tool_Annotation";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.Tools.ToolsEditor.ShowEditor(this.annotation1);
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.annotation1.Active = checkBox1.Checked;
			this.annotation2.Active = checkBox1.Checked;
			this.annotation3.Active = checkBox1.Checked;
		}
	}
}

