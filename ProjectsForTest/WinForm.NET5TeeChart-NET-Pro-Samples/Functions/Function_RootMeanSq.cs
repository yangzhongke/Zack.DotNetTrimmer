using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
	public class Function_RootMeanSq : Samples.BaseForm
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelRMS;
		private Steema.TeeChart.Functions.RootMeanSquare rootMeanSquare1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Styles.Line line2;
		private System.ComponentModel.IContainer components = null;

		public Function_RootMeanSq()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			this.line1.FillSampleValues(30);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_RootMeanSq));
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.label2 = new System.Windows.Forms.Label();
			this.labelRMS = new System.Windows.Forms.Label();
			this.rootMeanSquare1 = new Steema.TeeChart.Functions.RootMeanSquare();
			this.line2 = new Steema.TeeChart.Styles.Line();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Size = new System.Drawing.Size(466, 56);
			this.textBox1.Text = "The Root Mean Square (RMS) function does the following calculation:\r\n\r\nRMS = Sqrt" +
					"( Sum( Square(Value) ) ) / NumValues )";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelRMS);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Size = new System.Drawing.Size(466, 39);
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
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.MaximumOffset = 5;
			this.tChart1.Axes.Bottom.MinimumOffset = 5;
			// 
			// 
			// 
			this.tChart1.Axes.Left.MaximumOffset = 5;
			this.tChart1.Axes.Left.MinimumOffset = 5;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "Root Mean Square function"};
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Series.Add(this.line2);
			this.tChart1.Size = new System.Drawing.Size(466, 191);
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
			// 
			// chartContainer
			// 
			this.chartContainer.Location = new System.Drawing.Point(0, 95);
			this.chartContainer.Size = new System.Drawing.Size(466, 191);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Style:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Incomplete",
            "Complete"});
			this.comboBox1.Location = new System.Drawing.Point(60, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "Data";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(187, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "RMS value : ";
			this.label2.UseMnemonic = false;
			// 
			// labelRMS
			// 
			this.labelRMS.AutoSize = true;
			this.labelRMS.Location = new System.Drawing.Point(260, 11);
			this.labelRMS.Name = "labelRMS";
			this.labelRMS.Size = new System.Drawing.Size(28, 13);
			this.labelRMS.TabIndex = 3;
			this.labelRMS.Text = "0.00";
			this.labelRMS.UseMnemonic = false;
			// 
			// line2
			// 
			// 
			// 
			// 
			this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
			this.line2.ColorEach = false;
			this.line2.DataSource = this.line1;
			this.line2.Function = this.rootMeanSquare1;
			// 
			// 
			// 
			this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
			// 
			// 
			// 
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
			this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line2.Pointer.Visible = true;
			this.line2.Title = "RMS";
			// 
			// 
			// 
			this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// Function_RMS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "Function_RMS";
			this.Load += new System.EventHandler(this.Function_RMS_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void Function_RMS_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			rootMeanSquare1.Complete = (this.comboBox1.SelectedIndex == 1);
			labelRMS.Text = this.line2.YValues[0].ToString("0.00");
		}
	}
}

