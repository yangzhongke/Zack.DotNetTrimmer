using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Surface_WirePalette : Steema.TeeChart.Samples.BaseForm
	{
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox checkBox1;
    private Steema.TeeChart.Styles.Surface surface1;
		private System.ComponentModel.IContainer components = null;

		public Surface_WirePalette()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			surface1.UsePalette = true;
      surface1.FillSampleValues(10);
      surface1.WireFrame = true;
      surface1.Pen.Width = 2;
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.surface1 = new Steema.TeeChart.Styles.Surface();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(440, 72);
			this.textBox1.Text = "Surface series can now display in \"Wire-frame\" mode using the color palette and r" +
				"ange.\r\n\r\nExample: surface1.UsePalette = true ;  \r\n               surface1.Pen.Wi" +
				"dth = 2 ;\r\n               surfac1.WireFrame = true;";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 55);
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
			this.tChart1.Legend.MaxNumRows = 8;
			this.tChart1.Location = new System.Drawing.Point(0, 127);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.surface1);
			this.tChart1.Size = new System.Drawing.Size(440, 190);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.tChart1.Walls.Back.Transparent = false;
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
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
																									 "Single",
																									 "Range",
																									 "Palette"});
			this.comboBox1.Location = new System.Drawing.Point(128, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(120, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "comboBox1";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Wireframe color style:";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(272, 16);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(120, 24);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Wireframe";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// surface1
			// 
			// 
			// surface1.Brush
			// 
			this.surface1.Brush.Color = System.Drawing.Color.Red;
			// 
			// surface1.Marks
			// 
			// 
			// surface1.Marks.Symbol
			// 
			// 
			// surface1.Marks.Symbol.Shadow
			// 
			this.surface1.Marks.Symbol.Shadow.Height = 1;
			this.surface1.Marks.Symbol.Shadow.Visible = true;
			this.surface1.Marks.Symbol.Shadow.Width = 1;
			this.surface1.PaletteMin = 0;
			this.surface1.PaletteStep = 0;
			this.surface1.Title = "surface1";
			// 
			// surface1.XValues
			// 
			this.surface1.XValues.DataMember = "X";
			// 
			// surface1.YValues
			// 
			this.surface1.YValues.DataMember = "Y";
			// 
			// surface1.ZValues
			// 
			this.surface1.ZValues.DataMember = "Z";
			// 
			// Surface_Wireframepalette
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Surface_Wireframepalette";
			this.Load += new System.EventHandler(this.Surface_Wireframepalette_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      surface1.WireFrame = checkBox1.Checked;
    }

    private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      switch (comboBox1.SelectedIndex)
      {
        case 0 : { surface1.UsePalette = false; surface1.UseColorRange = false; break;}
        case 1 : { surface1.UsePalette = false; surface1.UseColorRange = true; break;}
        case 2 : { surface1.UsePalette = true; surface1.UseColorRange = false; break;}
      }
    }

    private void Surface_Wireframepalette_Load(object sender, System.EventArgs e)
    {
      comboBox1.SelectedIndex = 2;
    }
	}
}

