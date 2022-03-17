using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Pie_Shadow : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Pie pieSeries1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components = null;

		public Pie_Shadow()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			pieSeries1.FillSampleValues(5);

			// Setup shadow
			pieSeries1.Shadow.Color = Color.Silver;
			pieSeries1.Shadow.Height = 30;
			pieSeries1.Shadow.Width = 50;
			pieSeries1.Shadow.Visible = true;
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
			this.pieSeries1 = new Steema.TeeChart.Styles.Pie();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Pie series has a subproperty to display a \"shadow\" under it.\r\nShadow\'s color and " +
				"size can be customized.\r\n\r\nExample: \r\npieSeries1.Shadow.Color = Color.Silver;\r\np" +
				"ieSeries1.Shadow.Height = 50 ;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 41);
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
			this.tChart1.Location = new System.Drawing.Point(0, 104);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.pieSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 182);
			// 
			// pieSeries1
			// 
			// 
			// pieSeries1.Brush
			// 
			this.pieSeries1.Brush.Color = System.Drawing.Color.Red;
			this.pieSeries1.LabelMember = "Labels";
			// 
			// pieSeries1.Marks
			// 
			// 
			// pieSeries1.Marks.Symbol
			// 
			// 
			// pieSeries1.Marks.Symbol.Shadow
			// 
			this.pieSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries1.Pen
			// 
			this.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pieSeries1.Shadow
			// 
			this.pieSeries1.Shadow.Height = 20;
			this.pieSeries1.Shadow.Width = 20;
			this.pieSeries1.Title = "pieSeries1";
			// 
			// pieSeries1.XValues
			// 
			this.pieSeries1.XValues.DataMember = "Angle";
			this.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries1.YValues
			// 
			this.pieSeries1.YValues.DataMember = "Pie";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(24, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(128, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Draw pie shadow";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(168, 6);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "&Shadow...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Pie_Shadow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Pie_Shadow";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			pieSeries1.Shadow.Visible = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
      Steema.TeeChart.Editors.ShadowEditor s=new Steema.TeeChart.Editors.ShadowEditor(pieSeries1.Shadow,null);
      Steema.TeeChart.Editors.EditorUtils.Translate(s);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(s,this);
		}
	}
}

