using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Tools_DrawLineDragged : Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Line lineSeries1;
		private Steema.TeeChart.Tools.DrawLine drawLine1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components = null;

		public Tools_DrawLineDragged()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.lineSeries1.FillSampleValues(30);

			/* set the "X" line positions (start and end position) */
			Steema.TeeChart.Tools.DrawLineItem I = new Steema.TeeChart.Tools.DrawLineItem(drawLine1);
      /* set the "Y" line positions (start and end position) */
			double tmp = lineSeries1.YValues.Range/5.0; 			
      I.StartPos = new Steema.TeeChart.Drawing.PointDouble(5, lineSeries1.YValues.Maximum - tmp);
      I.EndPos = new Steema.TeeChart.Drawing.PointDouble(15, lineSeries1.YValues.Minimum + tmp);

			drawLine1.Pen.Color = Color.Blue;
			drawLine1.Pen.Width = 2;
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
			this.lineSeries1 = new Steema.TeeChart.Styles.Line();
			this.drawLine1 = new Steema.TeeChart.Tools.DrawLine();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(512, 64);
			this.textBox1.Text = "DrawLine tool introduces OnDraggedLine event. This event is triggered when the us" +
				"er finishes dragging a line.\r\nTry drawing a line, then clicking and moving it. W" +
				"hen finished, the event is raised and the label below shows the new line positio" +
				"n.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(512, 48);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			this.tChart1.Header.Visible = false;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Series.Add(this.lineSeries1);
			this.tChart1.Size = new System.Drawing.Size(512, 181);
			this.tChart1.Tools.Add(this.drawLine1);
			// 
			// lineSeries1
			// 
			// 
			// lineSeries1.Brush
			// 
			this.lineSeries1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(0)));
			// 
			// lineSeries1.LinePen
			// 
			this.lineSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(0)), ((System.Byte)(77)), ((System.Byte)(0)));
			// 
			// lineSeries1.Marks
			// 
			// 
			// lineSeries1.Marks.Symbol
			// 
			// 
			// lineSeries1.Marks.Symbol.Shadow
			// 
			this.lineSeries1.Marks.Symbol.Shadow.Height = 1;
			this.lineSeries1.Marks.Symbol.Shadow.Visible = true;
			this.lineSeries1.Marks.Symbol.Shadow.Width = 1;
			// 
			// lineSeries1.Pointer
			// 
			this.lineSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.lineSeries1.Title = "lineSeries1";
			// 
			// lineSeries1.XValues
			// 
			this.lineSeries1.XValues.DataMember = "X";
			this.lineSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// lineSeries1.YValues
			// 
			this.lineSeries1.YValues.DataMember = "Y";
			// 
			// drawLine1
			// 
			this.drawLine1.EnableDraw = false;
			this.drawLine1.DraggedLine += new Steema.TeeChart.Tools.DrawLineEventHandler(this.drawLine1_DraggedLine);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dragging line position : ";
			this.label1.UseMnemonic = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "0,0";
			this.label2.UseMnemonic = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(160, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "0,0";
			this.label3.UseMnemonic = false;
			// 
			// Tool_DrawLineDragged
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 293);
			this.Name = "Tool_DrawLineDragged";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void drawLine1_DraggedLine(Steema.TeeChart.Tools.DrawLine sender)
		{
			Steema.TeeChart.Tools.DrawLineItem I = drawLine1.Selected;
			label2.Text = "Start: (x: "+ I.StartPos.X.ToString("0.00")+ ", y: " + I.StartPos.Y.ToString("0.00")+")";
            label3.Text = "End: (x: " + I.EndPos.X.ToString("0.00") + ", y: " + I.EndPos.Y.ToString("0.00") + ")";
		}
	}
}

