using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Tools;

namespace Steema.TeeChart.Samples
{
	public class Tool_AnnotationAllowEdit : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_AnnotationAllowEdit));
            this.cbTopLeft = new System.Windows.Forms.CheckBox();
            this.cbBottomLeft = new System.Windows.Forms.CheckBox();
            this.cbTopRight = new System.Windows.Forms.CheckBox();
            this.cbBottomRight = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbBottomRight);
            this.panel1.Controls.Add(this.cbTopRight);
            this.panel1.Controls.Add(this.cbBottomLeft);
            this.panel1.Controls.Add(this.cbTopLeft);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "Annotation Allow Edit"};
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // cbTopLeft
            // 
            this.cbTopLeft.Checked = true;
            this.cbTopLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTopLeft.Location = new System.Drawing.Point(12, 3);
            this.cbTopLeft.Name = "cbTopLeft";
            this.cbTopLeft.Size = new System.Drawing.Size(109, 17);
            this.cbTopLeft.TabIndex = 0;
            this.cbTopLeft.Text = "AllowEdit TopLeft";
#if VS2005
            this.cbTopLeft.AutoSize = true;
            this.cbTopLeft.UseVisualStyleBackColor = true;
#endif
            this.cbTopLeft.CheckedChanged += new System.EventHandler(this.cbTopLeft_CheckedChanged);
            // 
            // cbBottomLeft
            // 
            this.cbBottomLeft.Checked = true;
            this.cbBottomLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBottomLeft.Location = new System.Drawing.Point(12, 19);
            this.cbBottomLeft.Name = "cbBottomLeft";
            this.cbBottomLeft.Size = new System.Drawing.Size(123, 17);
            this.cbBottomLeft.TabIndex = 1;
            this.cbBottomLeft.Text = "AllowEdit BottomLeft";
#if VS2005
            this.cbBottomLeft.AutoSize = true;
            this.cbBottomLeft.UseVisualStyleBackColor = true;
#endif
            this.cbBottomLeft.CheckedChanged += new System.EventHandler(this.cbBottomLeft_CheckedChanged);
            // 
            // cbTopRight
            // 
            this.cbTopRight.Checked = true;
            this.cbTopRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTopRight.Location = new System.Drawing.Point(141, 3);
            this.cbTopRight.Name = "cbTopRight";
            this.cbTopRight.Size = new System.Drawing.Size(116, 17);
            this.cbTopRight.TabIndex = 2;
            this.cbTopRight.Text = "AllowEdit TopRight";
#if VS2005
            this.cbTopRight.AutoSize = true;
            this.cbTopRight.UseVisualStyleBackColor = true;
#endif
            this.cbTopRight.CheckedChanged += new System.EventHandler(this.cbTopRight_CheckedChanged);
            // 
            // cbBottomRight
            // 
            this.cbBottomRight.Checked = true;
            this.cbBottomRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBottomRight.Location = new System.Drawing.Point(141, 19);
            this.cbBottomRight.Name = "cbBottomRight";
            this.cbBottomRight.Size = new System.Drawing.Size(130, 17);
            this.cbBottomRight.TabIndex = 3;
            this.cbBottomRight.Text = "AllowEdit BottomRight";
#if VS2005
            this.cbBottomRight.AutoSize = true;
            this.cbBottomRight.UseVisualStyleBackColor = true;
#endif
            this.cbBottomRight.CheckedChanged += new System.EventHandler(this.cbBottomRight_CheckedChanged);
            // 
            // Tool_AnnotationAllowEdit
            // 
#if VS2005
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Tool_AnnotationAllowEdit";
            this.Text = "Tool_AnnotationAllowEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public Tool_AnnotationAllowEdit()
		{
			InitializeComponent();
			InitializeChart();
		}

		private Annotation anno1;
		private RectangleTool rect1;
		private Annotation anno2;
		private CheckBox cbTopLeft;
		private CheckBox cbBottomRight;
		private CheckBox cbTopRight;
		private CheckBox cbBottomLeft;
		private RectangleTool rect2;

		private void InitializeChart()
		{
			tChart1.Aspect.View3D = false;
			tChart1.Tools.Add(anno1 = new Annotation());
			tChart1.Tools.Add(rect1 = new RectangleTool());
			tChart1.Tools.Add(anno2 = new Annotation());
			tChart1.Tools.Add(rect2 = new RectangleTool());

			rect1.Position = AnnotationPositions.LeftBottom;
			anno2.Position = AnnotationPositions.RightBottom;
			rect2.Position = AnnotationPositions.RightTop;

			anno1.Text = "Top Left";
			rect1.Text = "Bottom Left";
			anno2.Text = "Bottom Right";
			rect2.Text = "Top Right";

			rect1.AutoSize = true;
			rect2.AutoSize = true;
			anno1.AllowEdit = true;
			rect1.AllowEdit = true;
			anno2.AllowEdit = true;
			rect2.AllowEdit = true;

		}

		private void cbTopLeft_CheckedChanged(object sender, EventArgs e)
		{
			anno1.AllowEdit = cbTopLeft.Checked;
		}

		private void cbBottomLeft_CheckedChanged(object sender, EventArgs e)
		{
			rect1.AllowEdit = cbBottomLeft.Checked;
		}

		private void cbTopRight_CheckedChanged(object sender, EventArgs e)
		{
			rect2.AllowEdit = cbTopRight.Checked;
		}

		private void cbBottomRight_CheckedChanged(object sender, EventArgs e)
		{
			anno2.AllowEdit = cbBottomRight.Checked;
		}
	}
}