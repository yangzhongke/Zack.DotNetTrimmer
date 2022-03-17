using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class SeriesType_Gauges : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Gauges gauges1;
		private System.Windows.Forms.Button BEdit;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public SeriesType_Gauges()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			trackBar1.Value = (int)gauges1.Value;
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
			this.gauges1 = new Steema.TeeChart.Styles.Gauges();
			this.BEdit = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "Gauge series displays industrial instrumentation controls. \r\nLots of properties a" +
				"llow full customization.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Controls.Add(this.BEdit);
			this.panel1.Name = "panel1";
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
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.Increment = 10;
			this.tChart1.BackColor = System.Drawing.Color.Transparent;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Volts"};
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Bevel.ColorTwo = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.Angle = 15;
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.BackwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.Angle = 15;
			this.tChart1.Panel.Gradient.Direction = Drawing.LinearGradientMode.BackwardDiagonal;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.gauges1);
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// gauges1
			// 
			// 
			// gauges1.Center
			// 
			// 
			// gauges1.Center.Brush
			// 
			this.gauges1.Center.Brush.Color = System.Drawing.Color.Black;
			this.gauges1.Center.HorizSize = 8;
			this.gauges1.Center.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.gauges1.Center.VertSize = 8;
			this.gauges1.Circled = true;
			// 
			// gauges1.EndPoint
			// 
			this.gauges1.EndPoint.HorizSize = 3;
			this.gauges1.EndPoint.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			this.gauges1.EndPoint.VertSize = 3;
			this.gauges1.EndPoint.Visible = false;
			// 
			// gauges1.Marks
			// 
			// 
			// gauges1.Marks.Symbol
			// 
			// 
			// gauges1.Marks.Symbol.Shadow
			// 
			this.gauges1.Marks.Symbol.Shadow.Height = 1;
			this.gauges1.Marks.Symbol.Shadow.Visible = true;
			this.gauges1.Marks.Symbol.Shadow.Width = 1;
			this.gauges1.Maximum = 100;
			this.gauges1.Minimum = 0;
			this.gauges1.RotationAngle = 135;
			this.gauges1.Legend.Visible = false;
			this.gauges1.Title = "gauges1";
			this.gauges1.TotalAngle = 90;
			this.gauges1.Value = 66.859565287297386;
			// 
			// gauges1.XValues
			// 
			this.gauges1.XValues.DataMember = "Angle";
			this.gauges1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// gauges1.YValues
			// 
			this.gauges1.YValues.DataMember = "Y";
			this.gauges1.OnChange += new Steema.TeeChart.Styles.GaugesChangeHandler(this.gauges1_OnChange);
			// 
			// BEdit
			// 
			this.BEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BEdit.Location = new System.Drawing.Point(16, 8);
			this.BEdit.Name = "BEdit";
			this.BEdit.TabIndex = 0;
			this.BEdit.Text = "Edit...";
			this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 20;
			this.trackBar1.Location = new System.Drawing.Point(148, 6);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(132, 42);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(296, 12);
			this.label1.Name = "label1";
			this.label1.TabIndex = 2;
			// 
			// SeriesType_Gauges
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "SeriesType_Gauges";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void BEdit_Click(object sender, System.EventArgs e) {
			Steema.TeeChart.Editors.EditorUtils.ShowFormModal(new Steema.TeeChart.Editors.Series.GaugesSeries(gauges1));
		}

		private void trackBar1_Scroll(object sender, System.EventArgs e) {
			gauges1.Value = (double)trackBar1.Value;
		}

		private void gauges1_OnChange(object sender, System.EventArgs e) {
			label1.Text = gauges1.Value.ToString();
		}
	}
}

