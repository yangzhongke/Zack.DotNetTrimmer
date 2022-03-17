using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
  public class Tool_Pie : Steema.TeeChart.Samples.BaseForm
  {
    private Steema.TeeChart.Styles.Pie pieSeries1;
    private Steema.TeeChart.Tools.PieTool pieTool1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private Steema.TeeChart.ButtonPen buttonPen1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panelColor;
    private System.ComponentModel.IContainer components = null;

    public Tool_Pie()
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();

      pieSeries1.FillSampleValues(6);
      tChart1.Legend.Visible = false;
			
      // link pen button with tool pen
      buttonPen1.Pen = pieTool1.Pen;
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
			this.pieSeries1 = new Steema.TeeChart.Styles.Pie();
			this.pieTool1 = new Steema.TeeChart.Tools.PieTool();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonPen1 = new Steema.TeeChart.ButtonPen();
			this.button1 = new System.Windows.Forms.Button();
			this.panelColor = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(440, 63);
			this.textBox1.Text = "Use PieTool to focus pie slices when passing the mouse over them.\r\nMove the mouse" +
				" over pie slices...";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panelColor);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.buttonPen1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 41);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			this.tChart1.Aspect.Elevation = 315;
			this.tChart1.Aspect.Orthogonal = false;
			this.tChart1.Aspect.Perspective = 0;
			this.tChart1.Aspect.Rotation = 360;
			
			
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Location = new System.Drawing.Point(0, 104);
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
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.pieSeries1);
			this.tChart1.Size = new System.Drawing.Size(440, 237);
			this.tChart1.Tools.Add(this.pieTool1);
			this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
			// 
			// pieSeries1
			// 
			// 
			// pieSeries1.Brush
			// 
			this.pieSeries1.Brush.Color = System.Drawing.Color.Red;
			this.pieSeries1.LabelMember = "Labels";
			// 
			// pieSeries1.Marks
			// 
			// 
			// pieSeries1.Marks.Symbol
			// 
			// 
			// pieSeries1.Marks.Symbol.Shadow
			// 
			this.pieSeries1.Marks.Symbol.Shadow.Height = 1;
			this.pieSeries1.Marks.Symbol.Shadow.Visible = true;
			this.pieSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// pieSeries1.Pen
			// 
			this.pieSeries1.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// pieSeries1.Shadow
			// 
			this.pieSeries1.Shadow.Height = 20;
			this.pieSeries1.Shadow.Width = 20;
			this.pieSeries1.Title = "pieSeries1";
			// 
			// pieSeries1.XValues
			// 
			this.pieSeries1.XValues.DataMember = "Angle";
			this.pieSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// pieSeries1.YValues
			// 
			this.pieSeries1.YValues.DataMember = "Pie";
			// 
			// pieTool1
			// 
			// 
			// pieTool1.Pen
			// 
			this.pieTool1.Pen.Width = 4;
			this.pieTool1.Series = this.pieSeries1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Slice:";
			this.label1.UseMnemonic = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "...";
			this.label2.UseMnemonic = false;
			// 
			// buttonPen1
			// 
			this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPen1.Location = new System.Drawing.Point(167, 8);
			this.buttonPen1.Name = "buttonPen1";
			this.buttonPen1.TabIndex = 2;
			this.buttonPen1.Text = "&Pen...";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(264, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "&Edit...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panelColor
			// 
			this.panelColor.Location = new System.Drawing.Point(127, 5);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(26, 28);
			this.panelColor.TabIndex = 4;
			// 
			// Tool_PieTool
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 341);
			this.Name = "Tool_PieTool";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
    #endregion

    private void button1_Click(object sender, System.EventArgs e)
    {
      TeeChart.Editors.Tools.ToolsEditor.ShowEditor(pieTool1);
    }

    private void tChart1_MouseMove(object sender, MouseEventArgs e)
    {
      int tmp = pieTool1.Slice;
      if (tmp == -1)
      {
        label2.Text = "";
        panelColor.Visible = false;
      }
      else
      {
        label2.Text = pieSeries1.Labels[tmp];
        panelColor.BackColor = pieSeries1.ValueColor(tmp);
        panelColor.Visible = true;
      }
    }
  }
}
