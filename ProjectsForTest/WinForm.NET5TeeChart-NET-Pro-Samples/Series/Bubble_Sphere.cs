using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Bubble_Sphere : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private Steema.TeeChart.Styles.Bubble bubble1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
		private System.ComponentModel.IContainer components = null;

		public Bubble_Sphere()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			bubble1.Pointer.Gradient.StartColor = Color.DarkBlue;
			bubble1.FillSampleValues();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bubble_Sphere));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bubble1 = new Steema.TeeChart.Styles.Bubble();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Bubble series can now fill points using a gradient. \r\n\r\nbubble1.Pointer.Gradient." +
                "Visible = true;";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 100;
            this.tChart1.Aspect.Elevation = 351;
            this.tChart1.Aspect.ElevationFloat = 351;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 88;
            this.tChart1.Aspect.Rotation = 336;
            this.tChart1.Aspect.RotationFloat = 336;
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Aspect.Zoom = 78;
            this.tChart1.Aspect.ZoomFloat = 78;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.bubble1);
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            this.tChart1.Tools.Add(this.gridBand1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Visible = false;
            this.tChart1.Walls.Bottom.Size = 3;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(16, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Use Gradient";
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // bubble1
            // 
            this.bubble1.Color = System.Drawing.Color.Red;
            this.bubble1.LabelMember = "Labels";
            // 
            // 
            // 
            // 
            // 
            // 
            this.bubble1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bubble1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bubble1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bubble1.Marks.Callout.Distance = 0;
            this.bubble1.Marks.Callout.Draw3D = false;
            this.bubble1.Marks.Callout.Length = 0;
            this.bubble1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.bubble1.Marks.Callout.Visible = false;
            this.bubble1.Marks.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bubble1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.bubble1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
            this.bubble1.Pointer.HorizSize = 19;
            this.bubble1.Pointer.InflateMargins = false;
            // 
            // 
            // 
            this.bubble1.Pointer.Pen.Visible = false;
            this.bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere;
            this.bubble1.Pointer.VertSize = 19;
            this.bubble1.Title = "bubble1";
            // 
            // 
            // 
            this.bubble1.XValues.DataMember = "X";
            this.bubble1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bubble1.YValues.DataMember = "Y";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(120, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit Gradient...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Plain Bubble",
            "Sphere",
            "Polished"});
            this.comboBox1.Location = new System.Drawing.Point(328, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(240, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Bubble style:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridBand1
            // 
            this.gridBand1.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // Bubble_Sphere
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Bubble_Sphere";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void checkBox1_Click(object sender, System.EventArgs e) {
			bubble1.Pointer.Gradient.Visible = checkBox1.Checked;
		}

		private void setGradient(bool val)
		{
			bubble1.Pointer.Gradient.Visible = val;
			checkBox1.Checked = val;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.GradientEditor.Edit(bubble1.Pointer.Gradient);
			checkBox1.Checked=bubble1.Pointer.Gradient.Visible;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0: bubble1.Pointer.Style=Styles.PointerStyles.Circle; break;
				case 1: bubble1.Pointer.Style=Styles.PointerStyles.Sphere; 
					      setGradient(false);
					      break;
				case 2: bubble1.Pointer.Style=Styles.PointerStyles.PolishedSphere; 
					      setGradient(false);
								break;
			}

			if (comboBox1.SelectedIndex==0)
			{
				checkBox1.Enabled=true;
				checkBox1.Checked=bubble1.Pointer.Gradient.Visible;
        button1.Enabled=true;
			}
			else
			{
				checkBox1.Enabled=false;
				button1.Enabled=false;
			}
		}
	}
}

