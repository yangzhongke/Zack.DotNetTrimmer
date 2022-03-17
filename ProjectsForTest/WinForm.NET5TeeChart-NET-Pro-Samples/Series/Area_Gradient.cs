using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Area_Gradient : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Area areaSeries1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Label label1;
    private CheckBox cbGradRelative;
		private System.ComponentModel.IContainer components = null;

		public Area_Gradient()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			areaSeries1.FillSampleValues(10);
			areaSeries1.Gradient.Visible = true;
			areaSeries1.Gradient.StartColor = Color.Red;
			areaSeries1.Gradient.MiddleColor = Color.Blue;
			areaSeries1.Gradient.EndColor = Color.Green;
      areaSeries1.AreaLines.Visible = false;

      trackBar1.Value=areaSeries1.Transparency;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_Gradient));
      this.areaSeries1 = new Steema.TeeChart.Styles.Area();
      this.button1 = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.cbGradRelative = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(466, 63);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cbGradRelative);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.trackBar1);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Location = new System.Drawing.Point(0, 63);
      this.panel1.Size = new System.Drawing.Size(466, 33);
      this.panel1.TabIndex = 1;
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Aspect.ZOffset = 0;
      // 
      // 
      // 
      this.tChart1.Header.Lines = new string[] {
        "Area series gradient & transparency"};
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.BackwardDiagonal;
      this.tChart1.Series.Add(this.areaSeries1);
      this.tChart1.Size = new System.Drawing.Size(466, 190);
      this.tChart1.TabIndex = 2;
      // 
      // chartContainer
      // 
      this.chartContainer.Location = new System.Drawing.Point(0, 96);
      this.chartContainer.Size = new System.Drawing.Size(466, 190);
      // 
      // areaSeries1
      // 
      // 
      // 
      // 
      this.areaSeries1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.areaSeries1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      // 
      // 
      // 
      this.areaSeries1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      // 
      // 
      // 
      this.areaSeries1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.areaSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.areaSeries1.ColorEach = false;
      // 
      // 
      // 
      this.areaSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.areaSeries1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.areaSeries1.Marks.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.areaSeries1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
      this.areaSeries1.Marks.Callout.Distance = 0;
      this.areaSeries1.Marks.Callout.Draw3D = false;
      this.areaSeries1.Marks.Callout.Length = 10;
      this.areaSeries1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.areaSeries1.Marks.Callout.Visible = false;
      // 
      // 
      // 
      this.areaSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.areaSeries1.Title = "areaSeries1";
      // 
      // 
      // 
      this.areaSeries1.XValues.DataMember = "X";
      this.areaSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.areaSeries1.YValues.DataMember = "Y";
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(11, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(85, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "&Edit gradient...";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox1.Location = new System.Drawing.Point(102, 1);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(119, 15);
      this.checkBox1.TabIndex = 1;
      this.checkBox1.Text = "&Gradient visible";
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // trackBar1
      // 
      this.trackBar1.AutoSize = false;
      this.trackBar1.LargeChange = 10;
      this.trackBar1.Location = new System.Drawing.Point(276, 10);
      this.trackBar1.Maximum = 100;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(127, 13);
      this.trackBar1.TabIndex = 3;
      this.trackBar1.TickFrequency = 5;
      this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(227, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "&Transp:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // cbGradRelative
      // 
      this.cbGradRelative.Checked = true;
      this.cbGradRelative.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbGradRelative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbGradRelative.Location = new System.Drawing.Point(102, 15);
      this.cbGradRelative.Name = "cbGradRelative";
      this.cbGradRelative.Size = new System.Drawing.Size(119, 15);
      this.cbGradRelative.TabIndex = 4;
      this.cbGradRelative.Text = "Gradient &relative";
      this.cbGradRelative.CheckedChanged += new System.EventHandler(this.cbGradRelative_CheckedChanged);
      // 
      // Area_Gradient
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(466, 286);
      this.Name = "Area_Gradient";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Editors.GradientEditor.Edit(areaSeries1.Gradient);

      // reset this controls
      checkBox1.Checked=areaSeries1.Gradient.Visible;
      trackBar1.Value=areaSeries1.Gradient.Transparency;
      areaSeries1.Transparency = areaSeries1.Gradient.Transparency;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.areaSeries1.Gradient.Visible = this.checkBox1.Checked;
      trackBar1_ValueChanged(sender, e);
      cbGradRelative.Enabled = areaSeries1.Gradient.Visible;
    }

		private void trackBar1_ValueChanged(object sender, System.EventArgs e)
		{
      if (this.checkBox1.Checked)
      {
        this.areaSeries1.Gradient.Transparency = (int)this.trackBar1.Value;
      }
      else
      {
        this.areaSeries1.Transparency = (int)this.trackBar1.Value;
      }
		}

    private void cbGradRelative_CheckedChanged(object sender, EventArgs e)
    {
      areaSeries1.GradientRelative = cbGradRelative.Checked;
    }
	}
}

