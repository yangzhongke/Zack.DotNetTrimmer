using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Tool_RotateOutline : Steema.TeeChart.Samples.BaseForm
	{
    private Steema.TeeChart.Styles.HorizArea horizArea1;
    private Steema.TeeChart.ButtonPen buttonPen1;
    private System.Windows.Forms.CheckBox checkBox1;
    private Steema.TeeChart.Tools.Rotate rotate1;
		private System.ComponentModel.IContainer components = null;

		public Tool_RotateOutline()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

      rotate1.Pen.Visible=true;
      buttonPen1.Pen=rotate1.Pen;
      horizArea1.FillSampleValues();  
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_RotateOutline));
            this.horizArea1 = new Steema.TeeChart.Styles.HorizArea();
            this.buttonPen1 = new Steema.TeeChart.ButtonPen();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rotate1 = new Steema.TeeChart.Tools.Rotate();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(360, 73);
            this.textBox1.Text = "Rotate tool can display a wireframe while rotating, instead of re-painting the wh" +
                "ole chart.\r\n\r\nClick and drag the chart to see the wireframe.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.buttonPen1);
            this.panel1.Size = new System.Drawing.Size(360, 39);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 95;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Aspect.Zoom = 87;
            this.tChart1.Aspect.ZoomFloat = 87;
            this.tChart1.Cursor = Cursors.Default;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "Rotate tool outline"};
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
            this.tChart1.Series.Add(this.horizArea1);
            this.tChart1.Size = new System.Drawing.Size(360, 189);
            this.tChart1.Tools.Add(this.rotate1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tChart1.Walls.Right.Visible = true;
            // 
            // chartContainer
            // 
            this.chartContainer.Size = new System.Drawing.Size(360, 189);
            // 
            // horizArea1
            // 
            // 
            // 
            // 
            this.horizArea1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.horizArea1.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
            this.horizArea1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.horizArea1.Gradient.Transparency = 20;
            // 
            // 
            // 
            this.horizArea1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            // 
            // 
            // 
            this.horizArea1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.horizArea1.TopGradient.Transparency = 100;
            this.horizArea1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.horizArea1.ColorEach = false;
            // 
            // 
            // 
            this.horizArea1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizArea1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.horizArea1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.horizArea1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.horizArea1.Marks.Callout.Distance = 0;
            this.horizArea1.Marks.Callout.Draw3D = false;
            this.horizArea1.Marks.Callout.Length = 10;
            this.horizArea1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.horizArea1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.horizArea1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.horizArea1.Title = "horizArea1";
            // 
            // 
            // 
            this.horizArea1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.horizArea1.YValues.DataMember = "Y";
            this.horizArea1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // buttonPen1
            // 
            this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPen1.Location = new System.Drawing.Point(24, 8);
            this.buttonPen1.Name = "buttonPen1";
            this.buttonPen1.Size = new System.Drawing.Size(80, 24);
            this.buttonPen1.TabIndex = 1;
            this.buttonPen1.Text = "Outline...";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(120, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Draw outline";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Tool_RotateOutline
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(360, 301);
            this.Name = "Tool_RotateOutline";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      rotate1.Pen.Visible=checkBox1.Checked;
    }
	}
}

