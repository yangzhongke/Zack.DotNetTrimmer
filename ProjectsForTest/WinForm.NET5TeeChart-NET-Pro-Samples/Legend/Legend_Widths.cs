using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Legend_Widths : Samples.BaseForm
  {
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private Steema.TeeChart.Tools.GridBand gridBand1;
    private Label label3;
    private NumericUpDown UDSymbolGap;
    private Steema.TeeChart.Styles.Line line1;
		private System.ComponentModel.IContainer components = null;

		public Legend_Widths()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
			this.line1.FillSampleValues(20);
      //this.tChart1.Legend.DrawBehind = false;

      UDSymbolGap.Value = tChart1.Legend.TextSymbolGap;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Legend_Widths));
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
      this.label3 = new System.Windows.Forms.Label();
      this.UDSymbolGap = new System.Windows.Forms.NumericUpDown();
      this.line1 = new Steema.TeeChart.Styles.Line();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.UDSymbolGap)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(466, 88);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.UDSymbolGap);
      this.panel1.Controls.Add(this.numericUpDown2);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.numericUpDown1);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Location = new System.Drawing.Point(0, 88);
      this.panel1.Size = new System.Drawing.Size(466, 65);
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
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "dd/MM/yyyy";
      this.tChart1.Axes.Bottom.MaximumOffset = 5;
      this.tChart1.Axes.Bottom.MinimumOffset = 5;
      this.tChart1.Axes.Bottom.PartnerAxis = null;
      this.tChart1.Axes.Bottom.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.Depth.PartnerAxis = null;
      this.tChart1.Axes.Depth.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.PartnerAxis = null;
      this.tChart1.Axes.DepthTop.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.Left.MaximumOffset = 5;
      this.tChart1.Axes.Left.MinimumOffset = 5;
      this.tChart1.Axes.Left.PartnerAxis = null;
      this.tChart1.Axes.Left.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.Right.PartnerAxis = null;
      this.tChart1.Axes.Right.UsePartnerAxis = false;
      // 
      // 
      // 
      this.tChart1.Axes.Top.PartnerAxis = null;
      this.tChart1.Axes.Top.UsePartnerAxis = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Header.Font.Size = 11;
      this.tChart1.Header.Font.SizeFloat = 11F;
      this.tChart1.Header.Lines = new string[] {
        "Adjusting Legend spacing"};
      // 
      // 
      // 
      this.tChart1.Legend.BorderRound = 8;
      // 
      // 
      // 
      this.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
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
      this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(225)))));
      this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
      this.tChart1.Series.Add(this.line1);
      this.tChart1.Size = new System.Drawing.Size(466, 133);
      this.tChart1.TabIndex = 2;
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
      this.tChart1.Walls.Back.Pen.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Pen.Visible = false;
      this.tChart1.Walls.Bottom.Size = 5;
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Pen.Visible = false;
      this.tChart1.Walls.Left.Size = 5;
      // 
      // chartContainer
      // 
      this.chartContainer.Location = new System.Drawing.Point(0, 153);
      this.chartContainer.Size = new System.Drawing.Size(466, 133);
      // 
      // checkBox1
      // 
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBox1.Location = new System.Drawing.Point(13, 9);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(120, 21);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "&Automatic widths";
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Enabled = false;
      this.numericUpDown1.Location = new System.Drawing.Point(216, 9);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
      this.numericUpDown1.TabIndex = 2;
      this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(130, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Column &1 width:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(130, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Column &2 width:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Enabled = false;
      this.numericUpDown2.Location = new System.Drawing.Point(216, 37);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
      this.numericUpDown2.TabIndex = 4;
      this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDown2.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
      this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
      // 
      // gridBand1
      // 
      this.gridBand1.Axis = this.tChart1.Axes.Left;
      // 
      // 
      // 
      this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(280, 11);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(121, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Ad&just gap Symbol-Text:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // UDSymbolGap
      // 
      this.UDSymbolGap.Location = new System.Drawing.Point(408, 9);
      this.UDSymbolGap.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.UDSymbolGap.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
      this.UDSymbolGap.Name = "UDSymbolGap";
      this.UDSymbolGap.Size = new System.Drawing.Size(47, 20);
      this.UDSymbolGap.TabIndex = 6;
      this.UDSymbolGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.UDSymbolGap.ValueChanged += new System.EventHandler(this.UDSymbolGap_ValueChanged);
      // 
      // line1
      // 
      // 
      // 
      // 
      this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.line1.ColorEach = false;
      // 
      // 
      // 
      this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.line1.LinePen.Width = 2;
      // 
      // 
      // 
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
      this.line1.Pointer.HorizSize = 5;
      // 
      // 
      // 
      this.line1.Pointer.Pen.Visible = false;
      this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere;
      this.line1.Pointer.VertSize = 5;
      this.line1.Pointer.Visible = true;
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
      // Legend_Widths
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(466, 286);
      this.Name = "Legend_Widths";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.UDSymbolGap)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Legend.ColumnWidthAuto = this.checkBox1.Checked;
			this.tChart1.Refresh();

			this.numericUpDown1.Enabled = ! this.tChart1.Legend.ColumnWidthAuto;
			this.numericUpDown2.Enabled = ! this.tChart1.Legend.ColumnWidthAuto;

      numericUpDown1.Value = tChart1.Legend.ColumnWidths[0];
      numericUpDown2.Value = tChart1.Legend.ColumnWidths[1];
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Legend.ColumnWidths[0] = (int)this.numericUpDown1.Value;
			this.tChart1.Refresh();
		}

		private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
		{
			this.tChart1.Legend.ColumnWidths[1] = (int)this.numericUpDown2.Value;
			this.tChart1.Refresh();
		}

    private void UDSymbolGap_ValueChanged(object sender, EventArgs e)
    {
      this.tChart1.Legend.TextSymbolGap = (int)UDSymbolGap.Value;
    }
	}
}

