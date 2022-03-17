using System;
#if VS2005
using System.Collections.Generic;
#endif
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class Function_DSamp_MMFLN_DPC : BaseForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_DSamp_MMFLN_DPC));
			this.udPointCount = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbMethod = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udPointCount)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = resources.GetString("textBox1.Text");
#if !VS2005
			this.textBox1.Text += "System.Nullable only supported in .NET Framework 2.0";
#endif
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbMethod);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.udPointCount);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Walls.Back.Brush.Gradient.ExtendedColorPalette = null;
			this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.tChart1.Walls.Back.Brush.Gradient.Visible = true;
			this.tChart1.Walls.Back.Brush.Visible = true;
			this.tChart1.Walls.Back.Transparent = false;
#if VS2005
			this.tChart1.UndoneZoom += new System.EventHandler(this.tChart1_UndoneZoom);
			this.tChart1.Zoomed += new System.EventHandler(this.tChart1_Zoomed);
#endif
			// 
			// udPointCount
			// 
			this.udPointCount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.udPointCount.Location = new System.Drawing.Point(117, 8);
			this.udPointCount.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			this.udPointCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.udPointCount.Name = "udPointCount";
			this.udPointCount.Size = new System.Drawing.Size(66, 20);
			this.udPointCount.TabIndex = 0;
			this.udPointCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
#if VS2005
			this.udPointCount.ValueChanged += new System.EventHandler(this.udPointCount_ValueChanged);
#endif
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "DisplayedPointCount:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(189, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "DownSamplingMethod:";
			// 
			// cbMethod
			// 
#if VS2005
			this.cbMethod.FormattingEnabled = true;
#endif
			this.cbMethod.Location = new System.Drawing.Point(307, 8);
			this.cbMethod.Name = "cbMethod";
			this.cbMethod.Size = new System.Drawing.Size(121, 21);
			this.cbMethod.TabIndex = 3;
			this.cbMethod.Text = "MinMaxFirstLastNull";
#if VS2005
			this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.cbMethod_SelectedIndexChanged);
#endif
			// 
			// Function_DSamp_MMFLN_DPC
			//
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Function_DSamp_MMFLN_DPC";
			this.Text = "Function_DSamp_MMFLN_DPC";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udPointCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Function_DSamp_MMFLN_DPC()
		{
			InitializeComponent();
#if VS2005
			cbMethod.Items.AddRange(Enum.GetNames(typeof(Steema.TeeChart.Functions.DownSamplingMethod)));

			InitializeChart();
#endif
		}



		private Label label1;
		private Label label2;
		private ComboBox cbMethod;
		private NumericUpDown udPointCount;
#if VS2005
		private Steema.TeeChart.Styles.Points points;
		private Steema.TeeChart.Styles.FastLine fastLine;
		private Steema.TeeChart.Functions.DownSampling downSampling;
		private Nullable<double>[] xValues, yValues;

		private void InitializeChart()
		{
			CreateArrays();
			tChart1.Aspect.View3D = false;
			tChart1.Zoom.Direction = ZoomDirections.Horizontal;
			tChart1.Series.Add(points = new Steema.TeeChart.Styles.Points());
			tChart1.Series.Add(fastLine = new Steema.TeeChart.Styles.FastLine());

			downSampling = new Steema.TeeChart.Functions.DownSampling(tChart1.Chart);
			points.Add(xValues, yValues);
			points.Active = false;

			downSampling.DisplayedPointCount = 1000;
			downSampling.Method = Steema.TeeChart.Functions.DownSamplingMethod.MinMaxFirstLastNull;
			fastLine.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint;
			fastLine.DataSource = points;
			fastLine.Function = downSampling;

		}

		private void CreateArrays()
		{
			int length = 20000;

			xValues = new Nullable<double>[length];
			yValues = new Nullable<double>[length];

			Random rnd = new Random();
			for (int i = 0; i < length; i++)
			{
				xValues[i] = i;
				if (i % 20 == 0)
				{
					yValues[i] = null;
				}
				else
				{
					yValues[i] = rnd.Next(100);
				}
			}
		}

		private void tChart1_Zoomed(object sender, EventArgs e)
		{
			tChart1[1].CheckDataSource(); //series 1 is the function series
		}

		private void tChart1_UndoneZoom(object sender, EventArgs e)
		{
			tChart1.Axes.Bottom.SetMinMax(0, tChart1[0].Count); //series 0 is the original series, although you could use any value to set the maximum
			tChart1[1].CheckDataSource();
		}

		private void udPointCount_ValueChanged(object sender, EventArgs e)
		{
			downSampling.DisplayedPointCount = (int)udPointCount.Value;
			tChart1.Axes.Bottom.SetMinMax(0, tChart1[0].Count);
			tChart1[1].CheckDataSource();
		
		}

		private void cbMethod_SelectedIndexChanged(object sender, EventArgs e)
		{
			downSampling.Method = (Steema.TeeChart.Functions.DownSamplingMethod)Enum.Parse(typeof(Steema.TeeChart.Functions.DownSamplingMethod), cbMethod.SelectedItem.ToString());
			tChart1[1].CheckDataSource();
		}
#endif
	}
}