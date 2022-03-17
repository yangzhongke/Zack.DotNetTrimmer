using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Tool_AnnotationClick : Samples.BaseForm
	{
		private Steema.TeeChart.Tools.Annotation annotation1;
		private Steema.TeeChart.Tools.Annotation annotation2;
		private Steema.TeeChart.Tools.Annotation annotation3;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public Tool_AnnotationClick()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
      label1.Text="";
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
            this.annotation1 = new Steema.TeeChart.Tools.Annotation();
            this.annotation2 = new Steema.TeeChart.Tools.Annotation();
            this.annotation3 = new Steema.TeeChart.Tools.Annotation();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(456, 48);
            this.textBox1.Text = "Annotation tools include a Cursor property and Click event\'.\r\nMove the mouse over" +
                " annotations and click them...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Size = new System.Drawing.Size(456, 44);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            this.tChart1.Header.Lines = new string[] {
        "Annotation tool : Click and cursor example"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Size = new System.Drawing.Size(456, 241);
            this.tChart1.Tools.Add(this.annotation1);
            this.tChart1.Tools.Add(this.annotation2);
            this.tChart1.Tools.Add(this.annotation3);
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
            this.tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 5;
            this.tChart1.MouseMove += this.tChart1_MouseMove;
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 92);
            this.chartContainer.Size = new System.Drawing.Size(456, 241);
            // 
            // annotation1
            // 
            this.annotation1.AutoSize = true;
            this.annotation1.Cursor = Drawing.Cursors.Default;
            this.annotation1.Position = Steema.TeeChart.Tools.AnnotationPositions.LeftBottom;
            // 
            // 
            // 
            this.annotation1.Shape.Lines = new string[] {
        "ABCD"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.annotation1.Shape.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.annotation1.Shape.Shadow.Visible = true;
            this.annotation1.Text = "ABCD";
            this.annotation1.Click += this.annotation1_onClick;
            // 
            // annotation2
            // 
            this.annotation2.AutoSize = true;
            this.annotation2.Cursor = Drawing.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            this.annotation2.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.annotation2.Shape.Font.Shadow.Visible = true;
            this.annotation2.Shape.Font.Size = 9;
            this.annotation2.Shape.Font.SizeFloat = 9F;
            this.annotation2.Shape.Lines = new string[] {
        "Hello\r\nWorld"};
            // 
            // 
            // 
            this.annotation2.Shape.Shadow.Visible = true;
            this.annotation2.Text = "Hello\r\nWorld";
            this.annotation2.Click += this.annotation1_onClick;
            // 
            // annotation3
            // 
            this.annotation3.AutoSize = true;
            this.annotation3.Cursor = Drawing.Cursors.Default;
            this.annotation3.Position = Steema.TeeChart.Tools.AnnotationPositions.RightTop;
            // 
            // 
            // 
            // 
            // 
            // 
            this.annotation3.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.annotation3.Shape.Font.Brush.Color = System.Drawing.Color.Navy;
            // 
            // 
            // 
            // 
            // 
            // 
            this.annotation3.Shape.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.annotation3.Shape.Font.Shadow.Visible = true;
            this.annotation3.Shape.Font.Size = 12;
            this.annotation3.Shape.Font.SizeFloat = 12F;
            this.annotation3.Shape.Lines = new string[] {
        "1234567"};
            // 
            // 
            // 
            this.annotation3.Shape.Shadow.Visible = true;
            this.annotation3.Text = "1234567";
            this.annotation3.Click += this.annotation1_onClick;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.UseMnemonic = false;
            // 
            // Tool_AnnotationClick
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(456, 333);
            this.Name = "Tool_AnnotationClick";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void annotation1_onClick(object sender, Drawing.MouseEventArgs e)
		{
			MessageBox.Show((sender as TeeChart.Tools.Annotation).Text,"Clicked");
		}

		private void tChart1_MouseMove(object sender, MouseEventArgs e)
		{
            Point p=new Point(e.X,e.Y);
            if (annotation1.Shape.ShapeBounds.Contains(p))
                label1.Text=annotation1.Text;
            else
                if (annotation2.Shape.ShapeBounds.Contains(p))
                    label1.Text=annotation2.Text;
                else
                    if (annotation3.Shape.ShapeBounds.Contains(p))
                        label1.Text=annotation3.Text;
                    else
                        label1.Text="";
        }
	}
}

