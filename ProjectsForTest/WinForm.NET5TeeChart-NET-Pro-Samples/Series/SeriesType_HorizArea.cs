using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class SeriesType_HorizArea : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.HorizArea horizArea1;
		private Steema.TeeChart.Styles.HorizArea horizArea2;
		private Steema.TeeChart.Styles.HorizArea horizArea3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CBLayout;
		private System.Windows.Forms.CheckBox CBStairs;
		private System.Windows.Forms.CheckBox CB3D;
		private System.Windows.Forms.Button BEdit;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_HorizArea()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			horizArea1.FillSampleValues();
			horizArea2.FillSampleValues();
			horizArea3.FillSampleValues();

			CBLayout.SelectedIndex = 0;
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
			this.horizArea1 = new Steema.TeeChart.Styles.HorizArea();
			this.horizArea2 = new Steema.TeeChart.Styles.HorizArea();
			this.horizArea3 = new Steema.TeeChart.Styles.HorizArea();
			this.label1 = new System.Windows.Forms.Label();
			this.CBLayout = new System.Windows.Forms.ComboBox();
			this.CBStairs = new System.Windows.Forms.CheckBox();
			this.CB3D = new System.Windows.Forms.CheckBox();
			this.BEdit = new System.Windows.Forms.Button();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = @"The Horizontal Area style allows single or multiple areas, with different layouts ( 3D, overlap, stacked, stacked 100 percent ).Options include 2D and 3D, color-each-area, patterns, gradients,dark 3D, bottom origin, stairs mode, marks, border, transparency, etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BEdit);
			this.panel1.Controls.Add(this.CB3D);
			this.panel1.Controls.Add(this.CBStairs);
			this.panel1.Controls.Add(this.CBLayout);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Name = "panel1";
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
																								 "tChart1"};
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.Transparency = 50;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.Transparency = 50;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.horizArea1);
			this.tChart1.Series.Add(this.horizArea2);
			this.tChart1.Series.Add(this.horizArea3);
			this.tChart1.Tools.Add(this.gridBand1);
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
			// horizArea1
			// 
			// 
			// horizArea1.AreaBrush
			// 
			this.horizArea1.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(215)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// horizArea1.Gradient
			// 
			this.horizArea1.AreaBrush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizArea1.AreaLines
			// 
			this.horizArea1.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(129)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// horizArea1.Brush
			// 
			this.horizArea1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(215)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// horizArea1.Gradient
			// 
			this.horizArea1.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizArea1.LinePen
			// 
			this.horizArea1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(129)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// horizArea1.Marks
			// 
			// 
			// horizArea1.Marks.Symbol
			// 
			// 
			// horizArea1.Marks.Symbol.Shadow
			// 
			this.horizArea1.Marks.Symbol.Shadow.Height = 1;
			this.horizArea1.Marks.Symbol.Shadow.Visible = true;
			this.horizArea1.Marks.Symbol.Shadow.Width = 1;
			// 
			// horizArea1.Pointer
			// 
			// 
			// horizArea1.Pointer.Brush
			// 
			this.horizArea1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.horizArea1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.horizArea1.Title = "horizArea1";
			// 
			// horizArea1.XValues
			// 
			this.horizArea1.XValues.DataMember = "X";
			// 
			// horizArea1.YValues
			// 
			this.horizArea1.YValues.DataMember = "Y";
			this.horizArea1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// horizArea2
			// 
			// 
			// horizArea2.AreaBrush
			// 
			this.horizArea2.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(149)));
			// 
			// horizArea2.Gradient
			// 
			this.horizArea2.AreaBrush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizArea2.AreaLines
			// 
			this.horizArea2.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(89)));
			// 
			// horizArea2.Brush
			// 
			this.horizArea2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(149)));
			// 
			// horizArea2.Gradient
			// 
			this.horizArea2.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizArea2.LinePen
			// 
			this.horizArea2.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(89)));
			// 
			// horizArea2.Marks
			// 
			// 
			// horizArea2.Marks.Symbol
			// 
			// 
			// horizArea2.Marks.Symbol.Shadow
			// 
			this.horizArea2.Marks.Symbol.Shadow.Height = 1;
			this.horizArea2.Marks.Symbol.Shadow.Visible = true;
			this.horizArea2.Marks.Symbol.Shadow.Width = 1;
			// 
			// horizArea2.Pointer
			// 
			// 
			// horizArea2.Pointer.Brush
			// 
			this.horizArea2.Pointer.Brush.Color = System.Drawing.Color.Green;
			this.horizArea2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.horizArea2.Title = "horizArea2";
			// 
			// horizArea2.XValues
			// 
			this.horizArea2.XValues.DataMember = "X";
			// 
			// horizArea2.YValues
			// 
			this.horizArea2.YValues.DataMember = "Y";
			this.horizArea2.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// horizArea3
			// 
			// 
			// horizArea3.AreaBrush
			// 
			this.horizArea3.AreaBrush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(234)), ((System.Byte)(234)), ((System.Byte)(0)));
			// 
			// horizArea3.Gradient
			// 
			this.horizArea3.AreaBrush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizArea3.AreaLines
			// 
			this.horizArea3.AreaLines.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(140)), ((System.Byte)(140)), ((System.Byte)(0)));
			// 
			// horizArea3.Brush
			// 
			this.horizArea3.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(234)), ((System.Byte)(234)), ((System.Byte)(0)));
			// 
			// horizArea3.Gradient
			// 
			this.horizArea3.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
			// 
			// horizArea3.LinePen
			// 
			this.horizArea3.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(140)), ((System.Byte)(140)), ((System.Byte)(0)));
			// 
			// horizArea3.Marks
			// 
			// 
			// horizArea3.Marks.Symbol
			// 
			// 
			// horizArea3.Marks.Symbol.Shadow
			// 
			this.horizArea3.Marks.Symbol.Shadow.Height = 1;
			this.horizArea3.Marks.Symbol.Shadow.Visible = true;
			this.horizArea3.Marks.Symbol.Shadow.Width = 1;
			// 
			// horizArea3.Pointer
			// 
			// 
			// horizArea3.Pointer.Brush
			// 
			this.horizArea3.Pointer.Brush.Color = System.Drawing.Color.Yellow;
			this.horizArea3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.horizArea3.Title = "horizArea3";
			// 
			// horizArea3.XValues
			// 
			this.horizArea3.XValues.DataMember = "X";
			// 
			// horizArea3.YValues
			// 
			this.horizArea3.YValues.DataMember = "Y";
			this.horizArea3.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Layout:";
			// 
			// CBLayout
			// 
			this.CBLayout.Items.AddRange(new object[] {
																									"3D",
																									"Stacked",
																									"Stacked 100%"});
			this.CBLayout.Location = new System.Drawing.Point(51, 6);
			this.CBLayout.Name = "CBLayout";
			this.CBLayout.Size = new System.Drawing.Size(93, 21);
			this.CBLayout.TabIndex = 1;
			this.CBLayout.SelectedIndexChanged += new System.EventHandler(this.CBLayout_SelectedIndexChanged);
			// 
			// CBStairs
			// 
			this.CBStairs.Location = new System.Drawing.Point(161, 6);
			this.CBStairs.Name = "CBStairs";
			this.CBStairs.Size = new System.Drawing.Size(79, 24);
			this.CBStairs.TabIndex = 2;
			this.CBStairs.Text = "Stairs";
			this.CBStairs.Click += new System.EventHandler(this.CBStairs_Click);
			// 
			// CB3D
			// 
			this.CB3D.Checked = true;
			this.CB3D.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CB3D.Location = new System.Drawing.Point(234, 7);
			this.CB3D.Name = "CB3D";
			this.CB3D.Size = new System.Drawing.Size(79, 24);
			this.CB3D.TabIndex = 3;
			this.CB3D.Text = "3D";
			this.CB3D.Click += new System.EventHandler(this.CB3D_Click);
			// 
			// BEdit
			// 
			this.BEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BEdit.Location = new System.Drawing.Point(344, 8);
			this.BEdit.Name = "BEdit";
			this.BEdit.TabIndex = 4;
			this.BEdit.Text = "Edit...";
			this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
			// 
			// gridBand1
			// 
			this.gridBand1.Axis = this.tChart1.Axes.Bottom;
			// 
			// gridBand1.Band1
			// 
			this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			// 
			// gridBand1.Band2
			// 
			this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// SeriesType_HorizArea
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "SeriesType_HorizArea";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void CBLayout_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch(CBLayout.SelectedIndex) {
				case 0:
					horizArea1.MultiArea = Steema.TeeChart.Styles.MultiAreas.None;
					horizArea2.MultiArea = Steema.TeeChart.Styles.MultiAreas.None;
					horizArea3.MultiArea = Steema.TeeChart.Styles.MultiAreas.None;
					break;
				case 1:
					horizArea1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
					horizArea2.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
					horizArea3.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked;
					break;
				case 2:
					horizArea1.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked100;
					horizArea2.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked100;
					horizArea3.MultiArea = Steema.TeeChart.Styles.MultiAreas.Stacked100;
					break;
			}
			horizArea1.Marks.Visible=horizArea1.MultiArea==Steema.TeeChart.Styles.MultiAreas.None;
			horizArea2.Marks.Visible=horizArea2.MultiArea==Steema.TeeChart.Styles.MultiAreas.None;
			horizArea3.Marks.Visible=horizArea3.MultiArea==Steema.TeeChart.Styles.MultiAreas.None;
		
		}

		private void CBStairs_Click(object sender, System.EventArgs e) {
			horizArea1.Stairs = CBStairs.Checked;
			horizArea2.Stairs = CBStairs.Checked;
			horizArea3.Stairs = CBStairs.Checked;
		}

		private void CB3D_Click(object sender, System.EventArgs e) {
			tChart1.Aspect.View3D = CB3D.Checked;
		}

		private void BEdit_Click(object sender, System.EventArgs e) {
			tChart1.ShowEditor();
		}
	}
}

