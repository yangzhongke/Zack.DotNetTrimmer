using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Pie_OtherLegend : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Pie pie1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public Pie_OtherLegend()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			//add data
			pie1.Add(134, "Google");
			pie1.Add( 65, "Yahoo");
			pie1.Add( 23, "AltaVista");
			pie1.Add( 12, "AllTheWeb");
			pie1.Add(  9, "Terra");
			pie1.Add(  6, "Lycos");
			pie1.Add(  3, "Ask Jeeves");

      // prepare "Other" to group values below 10
			pie1.OtherSlice.Style=Steema.TeeChart.Styles.PieOtherStyles.BelowValue;
			pie1.OtherSlice.Value=10;
			pie1.OtherSlice.Text = "Other";

			pie1.OtherSlice.Legend.Visible = true;
			pie1.OtherSlice.Legend.CustomPosition = true;
			pie1.OtherSlice.Legend.Left = 475;
			pie1.OtherSlice.Legend.Top = 150;
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
			this.pie1 = new Steema.TeeChart.Styles.Pie();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "New Pie series Legend property to display a sub-legend for Pie \"Other\" grouped sl" +
				"ices. \r\n\r\npie1.OtherSlice.Legend.Visible = true;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pie1);
			this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
			// 
			// pie1
			// 
			// 
			// pie1.Brush
			// 
			this.pie1.Brush.Color = System.Drawing.Color.Red;
			this.pie1.LabelMember = "Labels";
			// 
			// pie1.Marks
			// 
			// 
			// pie1.Marks.Symbol
			// 
			// 
			// pie1.Marks.Symbol.Shadow
			// 
			this.pie1.Marks.Symbol.Shadow.Height = 1;
			this.pie1.Marks.Symbol.Shadow.Visible = true;
			this.pie1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pie1.Pen
			// 
			this.pie1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pie1.Shadow
			// 
			this.pie1.Shadow.Height = 20;
			this.pie1.Shadow.Width = 20;
			this.pie1.Title = "pie1";
			// 
			// pie1.XValues
			// 
			this.pie1.XValues.DataMember = "Angle";
			this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pie1.YValues
			// 
			this.pie1.YValues.DataMember = "Pie";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Show \"other\" Legend";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(203, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Edit Legend...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Pie_OtherLegend
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Pie_OtherLegend";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g) {
			// cosmetic line from normal legend to "other" legend
			if(pie1.OtherSlice.Legend.Visible) {
				g.Pen.Style = Drawing.DashStyle.Dot;
				g.Pen.Width = 2;
				g.Pen.Color = Color.Navy;

				int tmpX = tChart1.Legend.Left;
				g.MoveTo(tmpX, tChart1.Legend.ShapeBounds.Bottom - 4);
				g.LineTo(tmpX-10, tChart1.Legend.ShapeBounds.Bottom - 4);
				g.LineTo(tmpX-10, pie1.OtherSlice.Legend.Top+4);
				g.LineTo(pie1.OtherSlice.Legend.Left, pie1.OtherSlice.Legend.Top+4);

			}
		}

		private void checkBox1_Click(object sender, System.EventArgs e) {
			pie1.OtherSlice.Legend.Visible = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.LegendEditor lEdit = new Steema.TeeChart.Editors.LegendEditor(tChart1, pie1.OtherSlice.Legend, null);
      Steema.TeeChart.Editors.EditorUtils.Translate(lEdit);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(lEdit);
		}
	}
}

