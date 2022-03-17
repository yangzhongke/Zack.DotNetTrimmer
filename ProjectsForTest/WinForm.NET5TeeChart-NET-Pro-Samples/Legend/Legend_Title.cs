using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Legend_Title : Steema.TeeChart.Samples.BaseForm
	{
		private System.ComponentModel.IContainer components = null;

		public Legend_Title()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			InitializeChart();
	
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "The Legend Title property displays text at top of Legend rectangle.\r\n\r\nChart1.Leg" +
				"end.Title.Visible = true;";
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
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			this.tChart1.Axes.Bottom.Labels.Height = 0;
			this.tChart1.Axes.Bottom.Labels.Width = 0;
			// 
			// tChart1.Axes.Bottom.Title
			// 
			this.tChart1.Axes.Bottom.Title.Height = 0;
			this.tChart1.Axes.Bottom.Title.Width = 0;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Labels
			// 
			this.tChart1.Axes.Depth.Labels.Height = 0;
			this.tChart1.Axes.Depth.Labels.Width = 0;
			// 
			// tChart1.Axes.Depth.Title
			// 
			this.tChart1.Axes.Depth.Title.Height = 0;
			this.tChart1.Axes.Depth.Title.Width = 0;
			// 
			// tChart1.Axes.DepthTop
			// 
			// 
			// tChart1.Axes.DepthTop.Labels
			// 
			this.tChart1.Axes.DepthTop.Labels.Height = 0;
			this.tChart1.Axes.DepthTop.Labels.Width = 0;
			// 
			// tChart1.Axes.DepthTop.Title
			// 
			this.tChart1.Axes.DepthTop.Title.Height = 0;
			this.tChart1.Axes.DepthTop.Title.Width = 0;
			// 
			// tChart1.Axes.Left
			// 
			// 
			// tChart1.Axes.Left.Labels
			// 
			this.tChart1.Axes.Left.Labels.Height = 0;
			this.tChart1.Axes.Left.Labels.Width = 0;
			// 
			// tChart1.Axes.Left.Title
			// 
			this.tChart1.Axes.Left.Title.Height = 0;
			this.tChart1.Axes.Left.Title.Width = 0;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Labels
			// 
			this.tChart1.Axes.Right.Labels.Height = 0;
			this.tChart1.Axes.Right.Labels.Width = 0;
			// 
			// tChart1.Axes.Right.Title
			// 
			this.tChart1.Axes.Right.Title.Height = 0;
			this.tChart1.Axes.Right.Title.Width = 0;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Labels
			// 
			this.tChart1.Axes.Top.Labels.Height = 0;
			this.tChart1.Axes.Top.Labels.Width = 0;
			// 
			// tChart1.Axes.Top.Title
			// 
			this.tChart1.Axes.Top.Title.Height = 0;
			this.tChart1.Axes.Top.Title.Width = 0;
			// 
			// tChart1.Footer
			// 
			this.tChart1.Footer.Height = 0;
			this.tChart1.Footer.Width = 0;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Height = 14;
			this.tChart1.Header.Lines = new string[] {
																								 "TeeChart"};
			this.tChart1.Header.Width = 62;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Height = 0;
			// 
			// tChart1.Legend.Title
			// 
			// 
			// tChart1.Legend.Title.Font
			// 
			this.tChart1.Legend.Title.Font.Bold = true;
			this.tChart1.Legend.Title.Height = 0;
			this.tChart1.Legend.Title.Width = 0;
			this.tChart1.Legend.Width = 0;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			this.tChart1.Panel.Height = 0;
			this.tChart1.Panel.Width = 0;
			// 
			// tChart1.SubFooter
			// 
			this.tChart1.SubFooter.Height = 0;
			this.tChart1.SubFooter.Width = 0;
			// 
			// tChart1.SubHeader
			// 
			this.tChart1.SubHeader.Height = 0;
			this.tChart1.SubHeader.Width = 0;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			this.tChart1.Walls.Back.Height = 0;
			this.tChart1.Walls.Back.Width = 0;
			// 
			// tChart1.Walls.Bottom
			// 
			this.tChart1.Walls.Bottom.Height = 0;
			this.tChart1.Walls.Bottom.Width = 0;
			// 
			// tChart1.Walls.Left
			// 
			this.tChart1.Walls.Left.Height = 0;
			this.tChart1.Walls.Left.Width = 0;
			// 
			// tChart1.Walls.Right
			// 
			this.tChart1.Walls.Right.Height = 0;
			this.tChart1.Walls.Right.Width = 0;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(16, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Visible";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(152, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Legend Properties...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Legend_Title
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Legend_Title";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;

	
		private Steema.TeeChart.Styles.Line line1;

		private void InitializeChart() 
		{

			line1 = new Steema.TeeChart.Styles.Line(tChart1.Chart);
			line1.FillSampleValues();
			tChart1.Legend.Title.Visible = true;
			tChart1.Legend.Title.Text = "Values";
		
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			tChart1.Legend.Title.Visible = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Editors.LegendEditor legend = new Steema.TeeChart.Editors.LegendEditor(tChart1, null);
      Steema.TeeChart.Editors.EditorUtils.Translate(legend);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(legend);
		}

	}
}

