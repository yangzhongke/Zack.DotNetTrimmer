using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Clipboard_Single : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Styles.Line lineSeries2;
		private Steema.TeeChart.Styles.Points pointSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.ComponentModel.IContainer components = null;

		public Clipboard_Single()
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.lineSeries2 = new Steema.TeeChart.Styles.Line();
			this.pointSeries1 = new Steema.TeeChart.Styles.Points();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Charts can be copied to Clipboard with a CopyToClipboard method call.\r\n\r\nClick th" +
				"e button, then for example open Word and paste !";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
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
			this.tChart1.Aspect.Chart3DPercent = 50;
			this.tChart1.Aspect.Elevation = 360;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 72;
			this.tChart1.Aspect.Rotation = 360;
			
			
			this.tChart1.Aspect.Zoom = 86;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "This is a TeeChart !"};
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(0)));
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.UseMiddle = true;
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Series.Add(this.lineSeries2);
			this.tChart1.Series.Add(this.pointSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
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
			// 
			// lineSeries1.Pointer.Brush
			// 
			this.lineSeries1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "lineSeries1";
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
			// lineSeries2
			// 
			// 
			// lineSeries2.Brush
			// 
			this.lineSeries2.Brush.Color = System.Drawing.Color.Green;
			// 
			// lineSeries2.Marks
			// 
			// 
			// lineSeries2.Marks.Symbol
			// 
			// 
			// lineSeries2.Marks.Symbol.Shadow
			// 
			this.lineSeries2.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries2.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries2.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries2.Pointer
			// 
			// 
			// lineSeries2.Pointer.Brush
			// 
			this.lineSeries2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lineSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries2.Title = "lineSeries2";
			// 
			// lineSeries2.XValues
			// 
			this.lineSeries2.XValues.DataMember = "X";
			this.lineSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries2.YValues
			// 
			this.lineSeries2.YValues.DataMember = "Y";
			// 
			// pointSeries1
			// 
			// 
			// pointSeries1.Marks
			// 
			// 
			// pointSeries1.Marks.Symbol
			// 
			// 
			// pointSeries1.Marks.Symbol.Shadow
			// 
			this.pointSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pointSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pointSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pointSeries1.Pointer
			// 
			// 
			// pointSeries1.Pointer.Brush
			// 
			this.pointSeries1.Pointer.Brush.Color = System.Drawing.Color.Yellow;
			this.pointSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.pointSeries1.Title = "pointSeries1";
			// 
			// pointSeries1.XValues
			// 
			this.pointSeries1.XValues.DataMember = "X";
			this.pointSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pointSeries1.YValues
			// 
			this.pointSeries1.YValues.DataMember = "Y";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Copy to Clipboard";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Location = new System.Drawing.Point(161, 9);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(115, 21);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "as &metafile";
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Location = new System.Drawing.Point(261, 9);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(103, 21);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "as &bitmap";
			// 
			// Clipboard_Single
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Clipboard_Single";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (this.radioButton1.Checked) 
			{
			//	this.tChart1.Export.Image.Metafile.Enhanced = true;
				this.tChart1.Export.Image.Metafile.CopyToClipboard();
			}
			else this.tChart1.Export.Image.Bitmap.CopyToClipboard();
		}
	}
}

