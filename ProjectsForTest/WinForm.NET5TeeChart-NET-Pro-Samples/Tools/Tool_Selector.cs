using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Tool_Selector : Steema.TeeChart.Samples.BaseForm
	{
		private System.ComponentModel.IContainer components = null;

		private PropertyGrid propertyGrid1;
		private Steema.TeeChart.Tools.Selector selector1;
		private Steema.TeeChart.Styles.Line line1;

		public Tool_Selector()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.tChart1.Aspect.View3D = false;

			selector1 = new Steema.TeeChart.Tools.Selector(tChart1.Chart);
			line1 = new Steema.TeeChart.Styles.Line(tChart1.Chart);
			line1.Marks.Visible = true;
			line1.FillSampleValues();
			propertyGrid1 = new PropertyGrid();

			propertyGrid1.Dock = DockStyle.Left;		
			propertyGrid1.Width = 200;
			this.chartContainer.Controls.Add(propertyGrid1);

			selector1.Selected += new Steema.TeeChart.Tools.SelectorSelectedEventHandler(selector1_Selected);





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
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "The Selector tool enables the selection of various chart elements at runtime.\r\n\r\n" +
                "Simply click on area of the chart (header, series, axes etc.) and use the proper" +
                "tygrid to change their characteristics.";
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // Tool_Selector
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Tool_Selector";
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		private void selector1_Selected(object sender, System.EventArgs e) 
		{
			 propertyGrid1.SelectedObject = selector1.Selection;
		}
	
	}
}

