using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Marks_PerPoint : Samples.BaseForm
	{
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private Steema.TeeChart.Styles.Pie pie1;
		private System.ComponentModel.IContainer components = null;

		public Marks_PerPoint()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

      pie1.FillSampleValues();

      // customize mark...
      pie1.Marks.Items[3].Font.Size=14;
      pie1.Marks.Items[3].Color=Color.Silver;

      // customize another mark...
      pie1.Marks.Items[5].Font.Size=12;
      pie1.Marks.Items[5].Font.Color=Color.White;
      pie1.Marks.Items[5].Color=Color.Navy;
      pie1.Marks.Items[5].ShapeStyle=Drawing.TextShapeStyle.RoundRectangle;
      pie1.Marks.Items[5].Shadow.Width=4;
      pie1.Marks.Items[5].Shadow.Height=4;
      pie1.Marks.Items[5].Shadow.Transparency=60;
      pie1.Marks.Items[5].Shadow.Color=Color.DarkGray;

      numericUpDown1.Maximum=pie1.Count-1;

      label1.Text=pie1.Labels[Convert.ToInt16(numericUpDown1.Value)];
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marks_PerPoint));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pie1 = new Steema.TeeChart.Styles.Pie();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Series Marks can be individually customized using the default property:\r\n\r\npie1.M" +
                "arks.Items[3].Font.Size = 14 ;    // custom font for mark item 3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Size = new System.Drawing.Size(466, 40);
            this.panel1.TabIndex = 1;
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 20;
            this.tChart1.Aspect.Elevation = 310;
            this.tChart1.Aspect.ElevationFloat = 310;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 0;
            this.tChart1.Aspect.Rotation = 360;
            this.tChart1.Aspect.RotationFloat = 360;
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.BackColor = System.Drawing.Color.Transparent;
            this.tChart1.Cursor = Cursors.Default;
            // 
            // 
            // 
            this.tChart1.Header.AdjustFrame = false;
            // 
            // 
            // 
            this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Header.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Header.Font.Brush.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Header.Font.Brush.Solid = false;
            this.tChart1.Header.Font.Brush.Style = Drawing.HatchStyle.Percent50;
            this.tChart1.Header.Font.Name = "Microsoft Sans Serif";
            this.tChart1.Header.Font.Size = 14;
            this.tChart1.Header.Font.SizeFloat = 14F;
            this.tChart1.Header.Lines = new string[] {
        "Marks per point"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Shadow.Height = 1;
            this.tChart1.Header.Shadow.Width = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Legend.Shadow.Height = 4;
            this.tChart1.Legend.Shadow.Width = 4;
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.DefaultPen = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Sigma = true;
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0.447F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.694F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.pie1);
            this.tChart1.Size = new System.Drawing.Size(466, 182);
            this.tChart1.TabIndex = 2;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 104);
            this.chartContainer.Size = new System.Drawing.Size(466, 182);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Mark:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(108, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Edit...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(56, 10);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(208, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Reset";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // pie1
            // 
            // 
            // 
            // 
            this.pie1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
            this.pie1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.pie1.LabelMember = "Labels";
            // 
            // 
            // 
            this.pie1.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.pie1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.pie1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.pie1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.pie1.Marks.Callout.Distance = 0;
            this.pie1.Marks.Callout.Draw3D = false;
            this.pie1.Marks.Callout.Length = 10;
            this.pie1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.pie1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.pie1.MarksPie.LegSize = 0;
            this.pie1.MarksPie.VertCenter = false;
            this.pie1.MultiPie = Steema.TeeChart.Styles.MultiPies.Automatic;
            // 
            // 
            // 
            this.pie1.OtherSlice.Color = System.Drawing.Color.Empty;
            this.pie1.OtherSlice.Style = Steema.TeeChart.Styles.PieOtherStyles.None;
            this.pie1.OtherSlice.Text = "";
            this.pie1.OtherSlice.Value = 0;
            // 
            // 
            // 
            this.pie1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.pie1.Shadow.Height = 20;
            this.pie1.Shadow.Width = 20;
            this.pie1.Title = "pie1";
            this.pie1.Transparency = 0;
            // 
            // 
            // 
            this.pie1.XValues.DataMember = "Angle";
            this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.pie1.YValues.DataMember = "Pie";
            // 
            // MarksPerPoint
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "MarksPerPoint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


    private void button1_Click(object sender, System.EventArgs e)
    {
      Editors.CustomShapeEditor a = new Editors.CustomShapeEditor(pie1.Marks.Items[Convert.ToInt16(numericUpDown1.Value)]);
      Steema.TeeChart.Editors.EditorUtils.Translate(a);
      Editors.EditorUtils.ShowFormModal(a,this);
    }

    private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
    {
      label1.Text=pie1.Labels[Convert.ToInt16(numericUpDown1.Value)];
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      // Remove custom marks (set all to default)
      pie1.Marks.Clear();
    }

	}
}

