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
	public class Canvas_CustomGradients : BaseForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbFromCenter = new System.Windows.Forms.RadioButton();
			this.rbRadial = new System.Windows.Forms.RadioButton();
			this.udXOffset = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.udYOffset = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udXOffset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udYOffset)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "New gradient properties enable new gradient directions, custom gradient colour pa" +
					"lettes\r\nand custom destination rectangles.\r\n\r\nResize and move the gradient on th" +
					"e chart to see the effects.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.udYOffset);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.udXOffset);
			this.panel1.Controls.Add(this.groupBox1);
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
			this.tChart1.Resize += new System.EventHandler(this.tChart1_Resize);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbFromCenter);
			this.groupBox1.Controls.Add(this.rbRadial);
			this.groupBox1.Location = new System.Drawing.Point(12, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(172, 33);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction";
			// 
			// rbFromCenter
			// 
#if VS2005
			this.rbFromCenter.AutoSize = true;
#endif
			this.rbFromCenter.Checked = true;
			this.rbFromCenter.Location = new System.Drawing.Point(77, 13);
			this.rbFromCenter.Name = "rbFromCenter";
			this.rbFromCenter.Size = new System.Drawing.Size(82, 17);
			this.rbFromCenter.TabIndex = 2;
			this.rbFromCenter.TabStop = true;
			this.rbFromCenter.Text = "From Center";
#if VS2005
			this.rbFromCenter.UseVisualStyleBackColor = true;
#endif
			this.rbFromCenter.CheckedChanged += new System.EventHandler(this.rbFromCenter_CheckedChanged);
			// 
			// rbRadial
			// 
#if VS2005
			this.rbRadial.AutoSize = true;
#endif
			this.rbRadial.Location = new System.Drawing.Point(16, 13);
			this.rbRadial.Name = "rbRadial";
			this.rbRadial.Size = new System.Drawing.Size(55, 17);
			this.rbRadial.TabIndex = 1;
			this.rbRadial.Text = "Radial";
#if VS2005
			this.rbRadial.UseVisualStyleBackColor = true;
#endif
			this.rbRadial.CheckedChanged += new System.EventHandler(this.rbRadial_CheckedChanged);
			// 
			// udXOffset
			// 
			this.udXOffset.Location = new System.Drawing.Point(241, 16);
			this.udXOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.udXOffset.Name = "udXOffset";
			this.udXOffset.Size = new System.Drawing.Size(56, 20);
			this.udXOffset.TabIndex = 1;
			this.udXOffset.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.udXOffset.ValueChanged += new System.EventHandler(this.udXOffset_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(190, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "XOffset:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(303, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "YOffset:";
			// 
			// udYOffset
			// 
			this.udYOffset.Location = new System.Drawing.Point(351, 16);
			this.udYOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.udYOffset.Name = "udYOffset";
			this.udYOffset.Size = new System.Drawing.Size(56, 20);
			this.udYOffset.TabIndex = 3;
			this.udYOffset.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.udYOffset.ValueChanged += new System.EventHandler(this.udYOffset_ValueChanged);
			// 
			// Canvas_CustomGradients
			// 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Canvas_CustomGradients";
			this.Text = "Canvas_CustomGradients";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udXOffset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udYOffset)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Canvas_CustomGradients()
		{
			InitializeComponent();
			InitializeChart();
		
		}

		private GroupBox groupBox1;
		private RadioButton rbFromCenter;
		private RadioButton rbRadial;
		private Label label2;
		private NumericUpDown udYOffset;
		private Label label1;
		private NumericUpDown udXOffset;

		private Steema.TeeChart.Tools.RectangleTool rectangle;
		private void InitializeChart()
		{
			tChart1.Tools.Add(rectangle = new Steema.TeeChart.Tools.RectangleTool());
		

		}

		private void CustomizeGradient(Steema.TeeChart.Drawing.IGradient gradient)
		{
			gradient.Visible = true;
			Color[] CustomGradientPalette = new Color[] { 
				Color.FromArgb(120, Color.Red), 
				Color.FromArgb(120, Color.Yellow),
				Color.FromArgb(120, Color.Blue), 
				Color.FromArgb(120, Color.Violet) 
			};
			gradient.ExtendedColorPalette = CustomGradientPalette;
			gradient.CustomTargetRectangle = new Rectangle(0, 0, tChart1.Width, tChart1.Height);
			gradient.Style.Visible = true;
			gradient.Style.CenterXOffset = 50;
			gradient.Style.CenterYOffset = 50;
			gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.FromCenter;
		}

		private void tChart1_Resize(object sender, EventArgs e)
		{
            if (rectangle !=null)
			  CustomizeGradient(rectangle.Shape.Gradient);
		}

		private void rbRadial_CheckedChanged(object sender, EventArgs e)
		{
			if(rbRadial.Checked) 
			{
				rectangle.Shape.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
			}
		}

		private void rbFromCenter_CheckedChanged(object sender, EventArgs e)
		{
			if(rbFromCenter.Checked)
			{
				rectangle.Shape.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.FromCenter;
			}
		}

		private void udXOffset_ValueChanged(object sender, EventArgs e)
		{
			rectangle.Shape.Gradient.Style.CenterXOffset = (int)udXOffset.Value;
		}

		private void udYOffset_ValueChanged(object sender, EventArgs e)
		{
			rectangle.Shape.Gradient.Style.CenterYOffset = (int)udYOffset.Value;
		}

	}
}
