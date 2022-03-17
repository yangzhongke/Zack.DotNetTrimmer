using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
  public class Axis_Items : Steema.TeeChart.Samples.BaseForm
  {
    private System.Windows.Forms.CheckBox checkBox1;
    private Steema.TeeChart.Styles.Line line1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.ComponentModel.IContainer components = null;

    public Axis_Items()
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();

      int[] values = {200,0,123,300,260,-100,650,400};
      line1.Add(values);
			
      AddCustomLabels();

      SetDemoControls();

      numericUpDown2.Value=123;
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
		this.line1 = new Steema.TeeChart.Styles.Line();
		this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
		this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
		this.button1 = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
		this.SuspendLayout();
		// 
		// textBox1
		// 
		this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(388, 63);
		this.textBox1.Text = "Axis can be customized to display labels at specific positions with\r\ncustom text " +
			"and formatting, without using any event:\r\n\r\ntChart1.Axes.Left.Labels.Items.Add(1" +
			"23,\"Hello\");";
		// 
		// panel1
		// 
		this.panel1.BackColor = System.Drawing.SystemColors.Control;
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Controls.Add(this.numericUpDown2);
		this.panel1.Controls.Add(this.numericUpDown1);
		this.panel1.Controls.Add(this.checkBox1);
		this.panel1.Location = new System.Drawing.Point(0, 63);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(388, 33);
		// 
		// tChart1
		// 
		// 
		// tChart1.Aspect
		// 
		this.tChart1.Aspect.Chart3DPercent = 50;
		
		
		// 
		// tChart1.Header
		// 
		// 
		// tChart1.Header.Font
		// 
		// 
		// tChart1.Header.Font.Brush
		// 
		this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
		this.tChart1.Header.Font.Name = "Verdana";
		this.tChart1.Header.Lines = new string[] {
													 "Custom axis labels "};
		// 
		// tChart1.Legend
		// 
		this.tChart1.Legend.BorderRound = 8;
		// 
		// tChart1.Legend.Brush
		// 
		this.tChart1.Legend.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
		// 
		// tChart1.Legend.Font
		// 
		// 
		// tChart1.Legend.Font.Brush
		// 
		this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
		// 
		// tChart1.Legend.Pen
		// 
		this.tChart1.Legend.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
		// 
		// tChart1.Legend.Shadow
		// 
		this.tChart1.Legend.Shadow.Visible = false;
		this.tChart1.Legend.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
		this.tChart1.Location = new System.Drawing.Point(0, 96);
		this.tChart1.Name = "tChart1";
		// 
		// tChart1.Panel
		// 
		// 
		// tChart1.Panel.Brush
		// 
		this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
		// 
		// tChart1.Panel.Gradient
		// 
		this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
		this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
		this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
		this.tChart1.Panel.Brush.Gradient.Visible = true;
		// 
		// tChart1.Panel.Gradient
		// 
		this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
		this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
		this.tChart1.Panel.Gradient.UseMiddle = true;
		this.tChart1.Panel.Gradient.Visible = true;
		this.tChart1.Series.Add(this.line1);
		this.tChart1.Size = new System.Drawing.Size(388, 151);
		// 
		// tChart1.Walls
		// 
		// 
		// tChart1.Walls.Back
		// 
		this.tChart1.Walls.Back.Visible = false;
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
		// checkBox1
		// 
		this.checkBox1.Checked = true;
		this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.checkBox1.Location = new System.Drawing.Point(13, 7);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(91, 18);
		this.checkBox1.TabIndex = 0;
		this.checkBox1.Text = "&Custom labels";
		this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
		// 
		// line1
		// 
		// 
		// line1.Brush
		// 
		this.line1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(223)), ((System.Byte)(0)), ((System.Byte)(0)));
		// 
		// line1.LinePen
		// 
		this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(134)), ((System.Byte)(0)), ((System.Byte)(0)));
		// 
		// line1.Pointer
		// 
		this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
		this.line1.Title = "line1";
		// 
		// line1.XValues
		// 
		this.line1.XValues.DataMember = "X";
		this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
		// 
		// line1.YValues
		// 
		this.line1.YValues.DataMember = "Y";
		// 
		// numericUpDown1
		// 
		this.numericUpDown1.Location = new System.Drawing.Point(152, 6);
		this.numericUpDown1.Name = "numericUpDown1";
		this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
		this.numericUpDown1.TabIndex = 1;
		this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
		// 
		// numericUpDown2
		// 
		this.numericUpDown2.Location = new System.Drawing.Point(195, 6);
		this.numericUpDown2.Maximum = new System.Decimal(new int[] {
																	   10000,
																	   0,
																	   0,
																	   0});
		this.numericUpDown2.Minimum = new System.Decimal(new int[] {
																	   10000,
																	   0,
																	   0,
																	   -2147483648});
		this.numericUpDown2.Name = "numericUpDown2";
		this.numericUpDown2.Size = new System.Drawing.Size(61, 20);
		this.numericUpDown2.TabIndex = 2;
		this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
		// 
		// button1
		// 
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Location = new System.Drawing.Point(272, 5);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(56, 24);
		this.button1.TabIndex = 3;
		this.button1.Text = "&Edit...";
		this.button1.Click += new System.EventHandler(this.button1_Click);
		// 
		// label1
		// 
		this.label1.Location = new System.Drawing.Point(112, 8);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(40, 16);
		this.label1.TabIndex = 4;
		this.label1.Text = "&Label:";
		// 
		// Axis_Items
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(388, 247);
		this.Name = "Axis_Items";
		this.Text = "Axis_Items";
		this.panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
		this.ResumeLayout(false);

	}
		#endregion

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      if(checkBox1.Checked)
        AddCustomLabels();
      else
        tChart1.Axes.Left.Labels.Items.Clear();
      SetDemoControls();
    }

    private void AddCustomLabels()
    {
      tChart1.Axes.Left.Labels.Items.Clear();

      (tChart1.Axes.Left.Labels.Items.Add(123,"Hello")).Font.Size=16;
      (tChart1.Axes.Left.Labels.Items.Add(466,"Good\n\rbye")).Transparent=false;
      tChart1.Axes.Left.Labels.Items.Add(300);
      AxisLabelItem a = tChart1.Axes.Left.Labels.Items.Add(-100);
      a.Transparent=false;
      a.Color=Color.Blue;
      a.Transparency=50;
    }

    private void SetDemoControls()
    {
      numericUpDown1.Enabled=tChart1.Axes.Left.Labels.Items.Count>0;

      if (numericUpDown1.Enabled) 
        numericUpDown1.Maximum=tChart1.Axes.Left.Labels.Items.Count-1;
      numericUpDown2.Enabled=numericUpDown1.Enabled;
      button1.Enabled=numericUpDown1.Enabled;
    }

    private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
    {
      numericUpDown2.Value=(decimal)tChart1.Axes.Left.Labels.Items[(int)numericUpDown1.Value].Value;
    }

    private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
    {
      tChart1.Axes.Left.Labels.Items[(int)numericUpDown1.Value].Value=(double)numericUpDown2.Value;
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      Editors.CustomShapeEditor s=
        new Editors.CustomShapeEditor (tChart1.Axes.Left.Labels.Items[(int)numericUpDown1.Value]);
      Steema.TeeChart.Editors.EditorUtils.Translate(s);
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(s,this);
    }

	}
}

