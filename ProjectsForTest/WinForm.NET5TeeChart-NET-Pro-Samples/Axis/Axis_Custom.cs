using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Axis_Custom : Steema.TeeChart.Samples.BaseForm
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Axis axis1;
		private Steema.TeeChart.Axis axis2;
		private Steema.TeeChart.Axis axis3;
		private Steema.TeeChart.Axis axis4;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Styles.Line line2;
		private Steema.TeeChart.Styles.Line line3;
		private System.ComponentModel.IContainer components = null;

		public Axis_Custom()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			line1.CustomHorizAxis = axis2;
			line2.CustomVertAxis = axis1;
			line3.CustomHorizAxis = axis3;
			line3.CustomVertAxis = axis4;

      //Use of elected Partner Axes to limit GridLine zone
      tChart1.Axes.Bottom.UsePartnerAxis = true;
      tChart1.Axes.Bottom.PartnerAxis = tChart1.Axes.Custom[0];
      tChart1.Axes.Custom[0].UsePartnerAxis = true;
      tChart1.Axes.Custom[0].PartnerAxis = tChart1.Axes.Bottom;

      tChart1.Axes.Custom[1].UsePartnerAxis = true;
      tChart1.Axes.Custom[1].PartnerAxis = tChart1.Axes.Left;

      tChart1.Axes.Custom[3].UsePartnerAxis = true;
      tChart1.Axes.Custom[3].PartnerAxis = tChart1.Axes.Custom[2];
      tChart1.Axes.Custom[2].UsePartnerAxis = true;
      tChart1.Axes.Custom[2].PartnerAxis = tChart1.Axes.Custom[3];

			foreach (TeeChart.Styles.Series s in tChart1.Series)
				s.FillSampleValues(20);
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Axis_Custom));
      this.axis1 = new Steema.TeeChart.Axis(this.components);
      this.axis2 = new Steema.TeeChart.Axis(this.components);
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.axis3 = new Steema.TeeChart.Axis(this.components);
      this.axis4 = new Steema.TeeChart.Axis(this.components);
      this.line1 = new Steema.TeeChart.Styles.Line();
      this.line2 = new Steema.TeeChart.Styles.Line();
      this.line3 = new Steema.TeeChart.Styles.Line();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
      this.textBox1.Size = new System.Drawing.Size(472, 62);
      this.textBox1.Text = resources.GetString("textBox1.Text");
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.Control;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Location = new System.Drawing.Point(0, 62);
      this.panel1.Size = new System.Drawing.Size(472, 34);
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.EndPosition = 50;
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.TicksInner.Visible = true;
      this.tChart1.Axes.Custom.Add(this.axis1);
      this.tChart1.Axes.Custom.Add(this.axis2);
      this.tChart1.Axes.Custom.Add(this.axis3);
      this.tChart1.Axes.Custom.Add(this.axis4);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.MinorTicks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.TicksInner.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Grid.Style = Drawing.DashStyle.Solid;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.MinorTicks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.TicksInner.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.EndPosition = 50;
      // 
      // 
      // 
      this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.LogarithmicBase = 2;
      // 
      // 
      // 
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.TicksInner.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.MinorTicks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.TicksInner.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.MinorTicks.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.TicksInner.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Bold = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Size = 11;
      this.tChart1.Header.Font.SizeFloat = 11F;
      this.tChart1.Header.Lines = new string[] {
        "Axis grid zoning"};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Legend.Brush.Gradient.Visible = true;
      // 
      // 
      // 
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
      this.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      // 
      // 
      // 
      this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
      this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Series.Add(this.line1);
      this.tChart1.Series.Add(this.line2);
      this.tChart1.Series.Add(this.line3);
      this.tChart1.Size = new System.Drawing.Size(472, 221);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
      // 
      // 
      // 
      this.tChart1.Walls.Left.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
      this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
      // 
      // 
      // 
      this.tChart1.Walls.Right.Pen.Visible = false;
      // 
      // chartContainer
      // 
      this.chartContainer.Location = new System.Drawing.Point(0, 96);
      this.chartContainer.Size = new System.Drawing.Size(472, 221);
      // 
      // axis1
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis1.Grid.Style = Drawing.DashStyle.Solid;
      this.axis1.Horizontal = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis1.LogarithmicBase = 2;
      // 
      // 
      // 
      this.axis1.MinorTicks.Visible = false;
      this.axis1.OtherSide = false;
      this.axis1.StartPosition = 62;
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis1.TicksInner.Visible = true;
      // 
      // axis2
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis2.Grid.Style = Drawing.DashStyle.Solid;
      this.axis2.Horizontal = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis2.LogarithmicBase = 2;
      // 
      // 
      // 
      this.axis2.MinorTicks.Visible = false;
      this.axis2.OtherSide = false;
      this.axis2.RelativePosition = 50;
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis2.TicksInner.Visible = true;
      // 
      // checkBox1
      // 
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox1.Location = new System.Drawing.Point(13, 4);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(123, 23);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "&Show custom axes";
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(184, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "&Edit...";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // axis3
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis3.Grid.Style = Drawing.DashStyle.Solid;
      this.axis3.Horizontal = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis3.LogarithmicBase = 2;
      // 
      // 
      // 
      this.axis3.MinorTicks.Visible = false;
      this.axis3.OtherSide = false;
      this.axis3.StartPosition = 55;
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis3.TicksInner.Visible = true;
      // 
      // axis4
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis4.Grid.Style = Drawing.DashStyle.Solid;
      this.axis4.Horizontal = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis4.LogarithmicBase = 2;
      // 
      // 
      // 
      this.axis4.MinorTicks.Visible = false;
      this.axis4.OtherSide = true;
      this.axis4.StartPosition = 62;
      // 
      // 
      // 
      // 
      // 
      // 
      this.axis4.TicksInner.Visible = true;
      this.axis4.ZPosition = 0;
      // 
      // line1
      // 
      // 
      // 
      // 
      this.line1.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Marks.Brush.Gradient.SigmaFocus = 0F;
      this.line1.Marks.Brush.Gradient.SigmaScale = 0F;
      // 
      // 
      // 
      this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.line1.Marks.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
      this.line1.Marks.Callout.Distance = 0;
      this.line1.Marks.Callout.Draw3D = false;
      this.line1.Marks.Callout.Length = 10;
      this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.line1.Marks.Callout.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line1.Marks.Transparent = true;
      // 
      // 
      // 
      this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.line1.Title = "line1";
      // 
      // 
      // 
      this.line1.XValues.DataMember = "X";
      this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line1.YValues.DataMember = "Y";
      // 
      // line2
      // 
      // 
      // 
      // 
      this.line2.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Marks.Brush.Gradient.SigmaFocus = 0F;
      this.line2.Marks.Brush.Gradient.SigmaScale = 0F;
      // 
      // 
      // 
      this.line2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.line2.Marks.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.line2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
      this.line2.Marks.Callout.Distance = 0;
      this.line2.Marks.Callout.Draw3D = false;
      this.line2.Marks.Callout.Length = 10;
      this.line2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.line2.Marks.Callout.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line2.Marks.Transparent = true;
      // 
      // 
      // 
      this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.line2.Title = "line2";
      // 
      // 
      // 
      this.line2.XValues.DataMember = "X";
      this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line2.YValues.DataMember = "Y";
      // 
      // line3
      // 
      // 
      // 
      // 
      this.line3.ColorEach = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.line3.Marks.Brush.Gradient.SigmaFocus = 0F;
      this.line3.Marks.Brush.Gradient.SigmaScale = 0F;
      // 
      // 
      // 
      this.line3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.line3.Marks.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.line3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
      this.line3.Marks.Callout.Distance = 0;
      this.line3.Marks.Callout.Draw3D = false;
      this.line3.Marks.Callout.Length = 10;
      this.line3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.line3.Marks.Callout.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.line3.Marks.Transparent = true;
      // 
      // 
      // 
      this.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
      this.line3.Title = "line3";
      // 
      // 
      // 
      this.line3.XValues.DataMember = "X";
      this.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.line3.YValues.DataMember = "Y";
      // 
      // Axis_Custom
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(472, 317);
      this.Name = "Axis_Custom";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			Steema.TeeChart.CustomAxes axes = tChart1.Axes.Custom;
			for (int t=0; t<axes.Count; t++)
				axes[t].Visible = checkBox1.Checked;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (tChart1.Axes.Custom.Count > 0)
			{
        Editors.AxesEditor a=new Editors.AxesEditor(tChart1,null);
        Steema.TeeChart.Editors.EditorUtils.Translate(a);
        Editors.EditorUtils.ShowFormModal(a,this);
			}
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
	}
}

