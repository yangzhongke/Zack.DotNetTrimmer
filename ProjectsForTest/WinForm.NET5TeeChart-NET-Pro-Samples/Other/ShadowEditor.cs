using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Summary description for ShadowEditor.
	/// </summary>
	public class ShadowEditor : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bOK;
		private System.Windows.Forms.NumericUpDown UDShaHoriz;
		private System.Windows.Forms.NumericUpDown UDShaVert;
		private System.Windows.Forms.NumericUpDown UDShaTrans;
		private Steema.TeeChart.ButtonColor shadowColor;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ShadowEditor()
		{
			InitializeComponent();
		}

		private Steema.TeeChart.Drawing.Shadow Shadow;

		public ShadowEditor(Steema.TeeChart.Drawing.Shadow AShadow) {
			InitializeComponent();

			Shadow = AShadow;
			bOK.Visible = true;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void RefreshControls(Steema.TeeChart.Drawing.Shadow AShadow) {
			Shadow = AShadow;
			UDShaHoriz.Value = Shadow.Width;
			UDShaVert.Value = Shadow.Height;
			UDShaTrans.Value = Shadow.Transparency;
			shadowColor.Color = Shadow.Color;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.shadowColor = new Steema.TeeChart.ButtonColor();
			this.UDShaHoriz = new System.Windows.Forms.NumericUpDown();
			this.UDShaVert = new System.Windows.Forms.NumericUpDown();
			this.UDShaTrans = new System.Windows.Forms.NumericUpDown();
			this.bOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.UDShaHoriz)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UDShaVert)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UDShaTrans)).BeginInit();
			this.SuspendLayout();
			// 
			// shadowColor
			// 
			this.shadowColor.Color = System.Drawing.Color.Empty;
			this.shadowColor.Location = new System.Drawing.Point(48, 16);
			this.shadowColor.Name = "shadowColor";
			this.shadowColor.Size = new System.Drawing.Size(72, 23);
			this.shadowColor.TabIndex = 0;
			this.shadowColor.Text = "&Color...";
			// 
			// UDShaHoriz
			// 
			this.UDShaHoriz.Location = new System.Drawing.Point(81, 52);
			this.UDShaHoriz.Name = "UDShaHoriz";
			this.UDShaHoriz.Size = new System.Drawing.Size(40, 20);
			this.UDShaHoriz.TabIndex = 1;
			this.UDShaHoriz.ValueChanged += new System.EventHandler(this.UDShaHoriz_ValueChanged);
			// 
			// UDShaVert
			// 
			this.UDShaVert.Location = new System.Drawing.Point(81, 78);
			this.UDShaVert.Name = "UDShaVert";
			this.UDShaVert.Size = new System.Drawing.Size(40, 20);
			this.UDShaVert.TabIndex = 2;
			this.UDShaVert.ValueChanged += new System.EventHandler(this.UDShaVert_ValueChanged);
			// 
			// UDShaTrans
			// 
			this.UDShaTrans.Location = new System.Drawing.Point(80, 103);
			this.UDShaTrans.Name = "UDShaTrans";
			this.UDShaTrans.Size = new System.Drawing.Size(40, 20);
			this.UDShaTrans.TabIndex = 3;
			this.UDShaTrans.ValueChanged += new System.EventHandler(this.UDShaTrans_ValueChanged);
			// 
			// bOK
			// 
			this.bOK.Location = new System.Drawing.Point(45, 136);
			this.bOK.Name = "bOK";
			this.bOK.TabIndex = 4;
			this.bOK.Text = "OK";
			this.bOK.Click += new System.EventHandler(this.bOK_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "&Horiz Size:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "&Vert Size:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-1, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "&Transparency:";
			// 
			// ShadowEditor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(144, 166);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bOK);
			this.Controls.Add(this.UDShaTrans);
			this.Controls.Add(this.UDShaVert);
			this.Controls.Add(this.UDShaHoriz);
			this.Controls.Add(this.shadowColor);
			this.Name = "ShadowEditor";
			this.Text = "ShadowEditor";
			this.Load += new System.EventHandler(this.ShadowEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.UDShaHoriz)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UDShaVert)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UDShaTrans)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void UDShaHoriz_ValueChanged(object sender, System.EventArgs e) {
			Shadow.Width = (int)UDShaHoriz.Value;
		}

		private void UDShaVert_ValueChanged(object sender, System.EventArgs e) {
			Shadow.Height = (int)UDShaVert.Value;
		}

		private void UDShaTrans_ValueChanged(object sender, System.EventArgs e) {
			Shadow.Transparency = (int)UDShaTrans.Value;
		}

		private void ShadowEditor_Load(object sender, System.EventArgs e) {
			RefreshControls(Shadow);
		}

		private void bOK_Click(object sender, System.EventArgs e) {
		  Shadow.Color = shadowColor.Color;
			this.Close();
		}

		
	}
}
