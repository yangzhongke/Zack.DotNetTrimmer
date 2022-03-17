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
	public class Series_NullableValues : BaseForm
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Series_NullableValues));
			this.chartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 

			this.textBox1.Text = resources.GetString("textBox1.Text");
#if !VS2005
			this.textBox1.Text += "System.Nullable only supported in .NET Framework 2.0";
#else
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
#endif
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
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.Title.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Labels.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Depth.Title.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Labels.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.DepthTop.Title.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Labels.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Left.Title.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Labels.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Right.Title.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Labels.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Top.Title.Font.Name = "Verdana";
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
			this.tChart1.Header.Font.Name = "Verdana";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Legend.Font.Name = "Verdana";
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
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
			this.tChart1.Panel.Brush.Gradient.ExtendedColorPalette = null;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tChart1.Panel.Brush.Gradient.Sigma = true;
			this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
			this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
			// 
			// Series_NullableValues
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Series_NullableValues";
			this.Text = "Series_NullableValues";
			this.chartContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Series_NullableValues()
		{
			InitializeComponent();
#if VS2005
			InitializeChart();
#endif
		}
#if VS2005
		private void InitializeChart()
		{
			tChart1.Aspect.View3D = false;

			double?[] XValues = new double?[200];
			double?[] YValues = new double?[200];

			Random rnd = new Random();
			for(int i = 0; i < 200; i++)
			{
				XValues[i] = i;
				if(i % 4 == 0)
				{
					YValues[i] = (double?)null;
				}
				else
				{
					YValues[i] = rnd.NextDouble();
				}
			}
			Steema.TeeChart.Styles.FastLine fastLine;
			tChart1.Series.Add(fastLine = new Steema.TeeChart.Styles.FastLine());
			fastLine.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint;
			tChart1.Series[0].Add(XValues, YValues);
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
#endif
	}
}