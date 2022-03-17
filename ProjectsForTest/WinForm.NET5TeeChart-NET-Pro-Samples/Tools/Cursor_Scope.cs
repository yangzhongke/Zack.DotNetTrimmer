using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Cursor_Scope : BaseForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbUseSeriesZ = new System.Windows.Forms.CheckBox();
			this.cbFullWidth = new System.Windows.Forms.CheckBox();
			this.cbFastCursor = new System.Windows.Forms.CheckBox();
			this.bEdit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "CursorTool has scopes of various styles and the UseSeriesZ property.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.bEdit);
			this.panel1.Controls.Add(this.cbFastCursor);
			this.panel1.Controls.Add(this.cbFullWidth);
			this.panel1.Controls.Add(this.cbUseSeriesZ);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "Cursor Scope"};
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Title.Pen.Visible = false;
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// cbUseSeriesZ
			// 
			this.cbUseSeriesZ.Checked = true;
			this.cbUseSeriesZ.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbUseSeriesZ.Location = new System.Drawing.Point(3, 6);
			this.cbUseSeriesZ.Name = "cbUseSeriesZ";
			this.cbUseSeriesZ.Size = new System.Drawing.Size(81, 17);
			this.cbUseSeriesZ.TabIndex = 0;
			this.cbUseSeriesZ.Text = "UseSeriesZ";
#if VS2005
			this.cbUseSeriesZ.AutoSize = true;
			this.cbUseSeriesZ.UseVisualStyleBackColor = true;
#endif
			this.cbUseSeriesZ.CheckedChanged += new System.EventHandler(this.cbUseSeriesZ_CheckedChanged);
			// 
			// cbFullWidth
			// 
			this.cbFullWidth.Location = new System.Drawing.Point(90, 6);
			this.cbFullWidth.Name = "cbFullWidth";
			this.cbFullWidth.Size = new System.Drawing.Size(73, 17);
			this.cbFullWidth.TabIndex = 1;
			this.cbFullWidth.Text = "Full Width";
#if VS2005
			this.cbFullWidth.AutoSize = true;
			this.cbFullWidth.UseVisualStyleBackColor = true;
#endif
			this.cbFullWidth.CheckedChanged += new System.EventHandler(this.cbFullWidth_CheckedChanged);
			// 
			// cbFastCursor
			// 
			this.cbFastCursor.Location = new System.Drawing.Point(169, 6);
			this.cbFastCursor.Name = "cbFastCursor";
			this.cbFastCursor.Size = new System.Drawing.Size(76, 17);
			this.cbFastCursor.TabIndex = 2;
			this.cbFastCursor.Text = "FastCursor";
#if VS2005
			this.cbFastCursor.AutoSize = true;
			this.cbFastCursor.UseVisualStyleBackColor = true;
#endif
			this.cbFastCursor.CheckedChanged += new System.EventHandler(this.cbFastCursor_CheckedChanged);
			// 
			// bEdit
			// 
			this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bEdit.Location = new System.Drawing.Point(340, 7);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(75, 23);
			this.bEdit.TabIndex = 3;
			this.bEdit.Text = "Edit...";
#if VS2005
			this.bEdit.UseVisualStyleBackColor = true;
#endif
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// Cursor_Scope
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Cursor_Scope";
			this.Text = "Cursor_Scope";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Cursor_Scope()
		{
			InitializeComponent();
			InitializeChart();
		}

		Steema.TeeChart.Styles.Line line1;
		Steema.TeeChart.Styles.Line line2;
		private CheckBox cbUseSeriesZ;
		private CheckBox cbFullWidth;
		private CheckBox cbFastCursor;
		private Button bEdit;
		Steema.TeeChart.Tools.CursorTool cursor;

		private void InitializeChart()
		{
			tChart1.Series.Add(line1 = new Steema.TeeChart.Styles.Line());
			tChart1.Series.Add(line2 = new Steema.TeeChart.Styles.Line());

			line1.FillSampleValues();
			line2.FillSampleValues();

			tChart1.Tools.Add(cursor = new Steema.TeeChart.Tools.CursorTool());
			cursor.Series = line1;
			cursor.UseSeriesZ = true;
			cursor.FollowMouse = true;
			cursor.Style = Steema.TeeChart.Tools.CursorToolStyles.Scope;
			cursor.ScopeStyle = Steema.TeeChart.Tools.ScopeCursorStyle.Rectangle;
			cursor.ScopeSize = 20;
			cursor.HorizSize = 10;
			cursor.VertSize = 10;

		}

		private void cbUseSeriesZ_CheckedChanged(object sender, EventArgs e)
		{
			cursor.UseSeriesZ = cbUseSeriesZ.Checked;
		}

		private void cbFullWidth_CheckedChanged(object sender, EventArgs e)
		{
			cursor.HorizSize = cbFullWidth.Checked ? 0 : 10;
			cursor.VertSize = cbFullWidth.Checked ? 0 : 10;
		}

		private void cbFastCursor_CheckedChanged(object sender, EventArgs e)
		{
			cursor.FastCursor = cbFastCursor.Checked;
		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			Steema.TeeChart.Editors.Tools.CursorEditor editor = new Steema.TeeChart.Editors.Tools.CursorEditor(cursor);
      Steema.TeeChart.Editors.EditorUtils.Translate(editor);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(editor);
		}
	}
}