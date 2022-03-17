using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
  public class Axis_LabelsFormat : Steema.TeeChart.Samples.BaseForm
  {
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox comboBox1;
    private Steema.TeeChart.Styles.Bar bar1;
		private Steema.TeeChart.Tools.GridBand gridBand1;
    private System.ComponentModel.IContainer components = null;

    public Axis_LabelsFormat()
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();

      comboBox1.SelectedIndex=0;
      bar1.FillSampleValues(5);
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
		this.label1 = new System.Windows.Forms.Label();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.bar1 = new Steema.TeeChart.Styles.Bar();
		this.gridBand1 = new Steema.TeeChart.Tools.GridBand();
		this.panel1.SuspendLayout();
		this.SuspendLayout();
		// 
		// textBox1
		// 
		this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(388, 64);
		this.textBox1.Text = "Now you can customize the Labels properties like another shape.\r\nBy default they " +
			"are set to transparent.\r\n\r\ntChart1.Axes.Left.Labels.Transparent = false;";
		// 
		// panel1
		// 
		this.panel1.BackColor = System.Drawing.SystemColors.Control;
		this.panel1.Controls.Add(this.comboBox1);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Controls.Add(this.checkBox1);
		this.panel1.Location = new System.Drawing.Point(0, 64);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(388, 32);
		// 
		// tChart1
		// 
		// 
		// tChart1.Aspect
		// 
		this.tChart1.Aspect.Chart3DPercent = 50;
		
		
		// 
		// tChart1.Axes
		// 
		// 
		// tChart1.Axes.Bottom
		// 
		// 
		// tChart1.Axes.Bottom.Grid
		// 
		this.tChart1.Axes.Bottom.Grid.Visible = false;
		// 
		// tChart1.Header
		// 
		this.tChart1.Header.Lines = new string[] {
													 "TChart"};
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
		this.tChart1.Series.Add(this.bar1);
		this.tChart1.Size = new System.Drawing.Size(388, 151);
		this.tChart1.Tools.Add(this.gridBand1);
		// 
		// tChart1.Walls
		// 
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
		this.checkBox1.Location = new System.Drawing.Point(160, 6);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(91, 18);
		this.checkBox1.TabIndex = 0;
		this.checkBox1.Text = "&Transparent";
		this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
		// 
		// button1
		// 
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Location = new System.Drawing.Point(262, 4);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(56, 24);
		this.button1.TabIndex = 3;
		this.button1.Text = "&Edit...";
		this.button1.Click += new System.EventHandler(this.button1_Click);
		// 
		// label1
		// 
		this.label1.Location = new System.Drawing.Point(8, 8);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(40, 16);
		this.label1.TabIndex = 4;
		this.label1.Text = "&Axis:";
		// 
		// comboBox1
		// 
		this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.Items.AddRange(new object[] {
													   "Left",
													   "Top",
													   "Right",
													   "Bottom"});
		this.comboBox1.Location = new System.Drawing.Point(40, 4);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(104, 21);
		this.comboBox1.TabIndex = 5;
		this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
		// 
		// bar1
		// 
		// 
		// bar1.Brush
		// 
		this.bar1.Brush.Color = System.Drawing.Color.Red;
		this.bar1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both;
		this.bar1.Title = "bar1";
		this.bar1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both;
		// 
		// bar1.XValues
		// 
		this.bar1.XValues.DataMember = "X";
		this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
		// 
		// bar1.YValues
		// 
		this.bar1.YValues.DataMember = "Bar";
		// 
		// gridBand1
		// 
		this.gridBand1.Axis = this.tChart1.Axes.Left;
		// 
		// gridBand1.Band1
		// 
		this.gridBand1.Band1.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
		// 
		// gridBand1.Band2
		// 
		this.gridBand1.Band2.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
		// 
		// Axis_LabelsFormat
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(388, 247);
		this.Name = "Axis_LabelsFormat";
		this.panel1.ResumeLayout(false);
		this.ResumeLayout(false);

	}
		#endregion

    private Drawing.TextShape LabelsFormat()
    {
      switch (comboBox1.SelectedIndex)
      {
        case 0: 
          return tChart1.Axes.Left.Labels;
        case 1: 
          return tChart1.Axes.Top.Labels;
        case 2: 
          return tChart1.Axes.Right.Labels;
        default: 
          return tChart1.Axes.Bottom.Labels;
      }
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      LabelsFormat().Transparent=checkBox1.Checked;
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      Editors.CustomShapeEditor s= new Editors.CustomShapeEditor (LabelsFormat());
      Steema.TeeChart.Editors.EditorUtils.ShowFormModal(s,this);
    }

    private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      checkBox1.Checked=LabelsFormat().Transparent;
    }
	}
}

