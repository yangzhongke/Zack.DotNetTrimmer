using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples {
	public class Tool_ExtraLegend : Steema.TeeChart.Samples.BaseForm {
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.ComponentModel.IContainer components = null;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Tools.ExtraLegend extraLegend1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private Steema.TeeChart.Styles.Line line2;
		

		public Tool_ExtraLegend() {
			
			// This call is required by the Windows Form Designer.
			
			InitializeComponent();
			line1.FillSampleValues();
			line2.FillSampleValues();
			
			// Cosmetic...
			extraLegend1.Legend.Left = 50;
			extraLegend1.Legend.Top = 50;
		}

		

		/// <summary>
		
		/// Clean up any resources being used.
		
		/// </summary>
		
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
		private void InitializeComponent() {
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.line2 = new Steema.TeeChart.Styles.Line();
			this.extraLegend1 = new Steema.TeeChart.Tools.ExtraLegend();
			this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "ExtraLegend tool displays additional legend objects. \r\nThe tool has a Series prop" +
				"erty to display legend with series values and / or texts.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
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
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Series.Add(this.line2);
			this.tChart1.Tools.Add(this.extraLegend1);
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
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(128, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Show Extra Legend";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(144, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Edit Extra Legend...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(304, 8);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "Align";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// line1
			// 
			// 
			// line1.Brush
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// line1.LinePen
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(77)), ((System.Byte)(0)));
			// 
			// line1.Marks
			// 
			// 
			// line1.Marks.Symbol
			// 
			// 
			// line1.Marks.Symbol.Shadow
			// 
			this.line1.Marks.Symbol.Shadow.Height = 1;
			this.line1.Marks.Symbol.Shadow.Visible = true;
			this.line1.Marks.Symbol.Shadow.Width = 1;
			// 
			// line1.Pointer
			// 
			// 
			// line1.Pointer.Brush
			// 
			this.line1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "line1";
			// 
			// line1.XValues
			// 
			this.line1.XValues.DataMember = "X";
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line1.YValues
			// 
			this.line1.YValues.DataMember = "Y";
			// 
			// line2
			// 
			// 
			// line2.Brush
			// 
			this.line2.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(128)));
			// 
			// line2.LinePen
			// 
			this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(77)), ((System.Byte)(0)), ((System.Byte)(77)));
			// 
			// line2.Marks
			// 
			// 
			// line2.Marks.Symbol
			// 
			// 
			// line2.Marks.Symbol.Shadow
			// 
			this.line2.Marks.Symbol.Shadow.Height = 1;
			this.line2.Marks.Symbol.Shadow.Visible = true;
			this.line2.Marks.Symbol.Shadow.Width = 1;
			// 
			// line2.Pointer
			// 
			// 
			// line2.Pointer.Brush
			// 
			this.line2.Pointer.Brush.Color = System.Drawing.Color.Green;
			this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line2.Title = "line2";
			// 
			// line2.XValues
			// 
			this.line2.XValues.DataMember = "X";
			this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// line2.YValues
			// 
			this.line2.YValues.DataMember = "Y";
			// 
			// extraLegend1
			// 
			this.extraLegend1.Series = this.line2;
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
			// Tool_ExtraLegend
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Tool_ExtraLegend";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e) {
			extraLegend1.Active = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.LegendEditor lEdit = new Steema.TeeChart.Editors.LegendEditor(tChart1, extraLegend1.Legend, null);
      Steema.TeeChart.Editors.EditorUtils.Translate(lEdit);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(lEdit);
		}

		private void button2_Click(object sender, System.EventArgs e) {
			// Customize extra legend position.
			// Align with default normal legend.
			extraLegend1.Legend.Left = tChart1.Legend.Left;
			extraLegend1.Legend.Top = tChart1.Legend.ShapeBounds.Bottom + 10;

		}
	}
}

