using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
  public class Axis_GetAxisLabel : Steema.TeeChart.Samples.BaseForm
  {
  	private Steema.TeeChart.Styles.FastLine fastLine1;
    private System.ComponentModel.IContainer components = null;

    public Axis_GetAxisLabel()
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();

      fastLine1.FillSampleValues();
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
		this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
		this.SuspendLayout();
		// 
		// textBox1
		// 
		this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(388, 63);
		this.textBox1.Text = "Customizing axis labels format (font color, etc) can be done also \r\nusing the Get" +
			"AxisLabel event.\r\n\r\nThe left axis shows labels in different colors.";
		// 
		// panel1
		// 
		this.panel1.BackColor = System.Drawing.SystemColors.Control;
		this.panel1.Location = new System.Drawing.Point(0, 63);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(388, 27);
		// 
		// tChart1
		// 
		// 
		// tChart1.Aspect
		// 
		this.tChart1.Aspect.View3D = false;
		// 
		// tChart1.Axes
		// 
		// 
		// tChart1.Axes.Bottom
		// 
		// 
		// tChart1.Axes.Bottom.AxisPen
		// 
		this.tChart1.Axes.Bottom.AxisPen.Width = 1;
		// 
		// tChart1.Axes.Left
		// 
		// 
		// tChart1.Axes.Left.AxisPen
		// 
		this.tChart1.Axes.Left.AxisPen.Width = 1;
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
		// 
		// tChart1.Header.Font.Shadow
		// 
		// 
		// tChart1.Header.Font.Shadow.Brush
		// 
		this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
		this.tChart1.Header.Font.Shadow.Visible = true;
		this.tChart1.Header.Lines = new string[] {
													 "Axis LAbels Format"};
		// 
		// tChart1.Legend
		// 
		this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series;
		// 
		// tChart1.Legend.Shadow
		// 
		this.tChart1.Legend.Shadow.Visible = false;
		this.tChart1.Location = new System.Drawing.Point(0, 90);
		this.tChart1.Name = "tChart1";
		// 
		// tChart1.Panel
		// 
		// 
		// tChart1.Panel.Brush
		// 
		// 
		// tChart1.Panel.Gradient
		// 
		this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
		this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
		this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
		this.tChart1.Panel.Brush.Gradient.Visible = true;
		// 
		// tChart1.Panel.Gradient
		// 
		this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
		this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(210)));
		this.tChart1.Panel.Gradient.UseMiddle = true;
		this.tChart1.Panel.Gradient.Visible = true;
		this.tChart1.Series.Add(this.fastLine1);
		this.tChart1.Size = new System.Drawing.Size(388, 157);
		// 
		// tChart1.Walls
		// 
		// 
		// tChart1.Walls.Back
		// 
		this.tChart1.Walls.Back.Visible = false;
		this.tChart1.GetAxisLabel += new Steema.TeeChart.GetAxisLabelEventHandler(this.tChart1_GetAxisLabel);
		// 
		// fastLine1
		// 
		// 
		// fastLine1.LinePen
		// 
		this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(153)), ((System.Byte)(255)));
		this.fastLine1.Title = "fastLine1";
		// 
		// fastLine1.XValues
		// 
		this.fastLine1.XValues.DataMember = "X";
		this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
		// 
		// fastLine1.YValues
		// 
		this.fastLine1.YValues.DataMember = "Y";
		// 
		// Axis_GetAxisLabel
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(388, 247);
		this.Name = "Axis_GetAxisLabel";
		this.ResumeLayout(false);

	}
		#endregion

    private void tChart1_GetAxisLabel(object sender, Steema.TeeChart.GetAxisLabelEventArgs e)
    {
      double num = Convert.ToDouble(e.LabelText);

      if (sender==tChart1.Axes.Left)
      {
        if (num>((Axis)sender).Minimum+(((Axis)sender).Maximum-((Axis)sender).Minimum)/2)
          ((Axis)sender).Labels.Font.Color=Color.Red;
        else
          ((Axis)sender).Labels.Font.Color=Color.Blue;
      }
      else
      if (sender==tChart1.Axes.Bottom)
      {
        if (num>12)
          ((Axis)sender).Labels.Font.Color=Color.Red;
        else
          ((Axis)sender).Labels.Font.Color=Color.Blue;
      }
    }
	}
}

