using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Series_Bar3D : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Bar3D bar3DSeries1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Tools.ColorBand colorBand1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Series_Bar3D()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.bar3DSeries1.Clear();
			this.bar3DSeries1.Add(0, 250, 200, "A", Color.Red);
			this.bar3DSeries1.Add( 1,  10, 200, "B", Color.Green );
			this.bar3DSeries1.Add( 2,  90, 100, "C", Color.Yellow );
			this.bar3DSeries1.Add( 3,  30,  50, "D", Color.Blue );
			this.bar3DSeries1.Add( 4,  70, 150, "E", Color.White );
			this.bar3DSeries1.Add( 5, 120, 150, "F", Color.Silver );

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
			this.bar3DSeries1 = new Steema.TeeChart.Styles.Bar3D();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.colorBand1 = new Steema.TeeChart.Tools.ColorBand();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 48);
			this.textBox1.Text = "The Bar 3D series is an extension of Bar series, providing an extra \"Y\" coordinat" +
				"e for each bar point.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 40);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Chart3DPercent = 25;
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Bar 3D series"};
			this.tChart1.Location = new System.Drawing.Point(0, 88);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.bar3DSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 198);
			this.tChart1.Tools.Add(this.colorBand1);
			this.tChart1.Tools.Add(this.gridBand1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.Visible = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Bottom.Pen
			// 
			this.tChart1.Walls.Bottom.Pen.Visible = false;
			this.tChart1.Walls.Bottom.Size = 3;
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(224)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.Transparency = 30;
			// 
			// tChart1.Walls.Left.Pen
			// 
			this.tChart1.Walls.Left.Pen.Visible = false;
			this.tChart1.Walls.Left.Size = 3;
			// 
			// bar3DSeries1
			// 
			// 
			// bar3DSeries1.Brush
			// 
			this.bar3DSeries1.Brush.Color = System.Drawing.Color.Red;
			// 
			// bar3DSeries1.Gradient
			// 
			this.bar3DSeries1.Brush.Gradient.StartColor = System.Drawing.Color.Yellow;
			this.bar3DSeries1.Brush.Gradient.Visible = true;
			// 
			// bar3DSeries1.Gradient
			// 
			this.bar3DSeries1.Gradient.StartColor = System.Drawing.Color.Yellow;
			this.bar3DSeries1.Gradient.Visible = true;
			this.bar3DSeries1.LabelMember = "Labels";
			// 
			// bar3DSeries1.Marks
			// 
			// 
			// bar3DSeries1.Marks.Symbol
			// 
			// 
			// bar3DSeries1.Marks.Symbol.Shadow
			// 
			this.bar3DSeries1.Marks.Symbol.Shadow.Height = 1;
			this.bar3DSeries1.Marks.Symbol.Shadow.Visible = true;
			this.bar3DSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// bar3DSeries1.Pen
			// 
			this.bar3DSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(0)));
			this.bar3DSeries1.Title = "bar3DSeries1";
			// 
			// bar3DSeries1.XValues
			// 
			this.bar3DSeries1.XValues.DataMember = "X";
			this.bar3DSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bar3DSeries1.YValues
			// 
			this.bar3DSeries1.YValues.DataMember = "Bar";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Style :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Rectangle",
																									 "Pyramid",
																									 "Invert. Pyramid",
																									 "Cylinder",
																									 "Ellipse",
																									 "Arrow",
																									 "Rect. Gradient",
																									 "Cone"});
			this.comboBox1.Location = new System.Drawing.Point(60, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(200, 9);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// colorBand1
			// 
			this.colorBand1.Axis = this.tChart1.Axes.Left;
			// 
			// colorBand1.Brush
			// 
			this.colorBand1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(255)));
			this.colorBand1.End = 400;
			// 
			// colorBand1.Pen
			// 
			this.colorBand1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(160)));
			this.colorBand1.ResizeEnd = false;
			this.colorBand1.ResizeStart = false;
			this.colorBand1.Start = 800;
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Left;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_Bar3D
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Bar3D";
			this.Load += new System.EventHandler(this.SeriesType_Bar3D_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			TeeChart.Editors.SeriesEditor.ShowEditor(this.bar3DSeries1);
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.bar3DSeries1.BarStyle = (Steema.TeeChart.Styles.BarStyles)comboBox1.SelectedIndex;
		}

		private void SeriesType_Bar3D_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 6;
		}
	}
}

