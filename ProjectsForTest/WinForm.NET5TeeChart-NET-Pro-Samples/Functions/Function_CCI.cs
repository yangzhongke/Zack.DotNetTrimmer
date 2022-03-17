using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Steema.TeeChart.Samples
{
	public class Function_CCI : Steema.TeeChart.Samples.BaseForm
	{
		private Steema.TeeChart.Styles.Candle candle1;
		private Steema.TeeChart.Axis axis1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private Steema.TeeChart.Functions.CCIFunction cciFunction1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Axis axis2;
		private System.ComponentModel.IContainer components = null;

		public Function_CCI()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			candle1.FillSampleValues();
			numericUpDown1.Value = (decimal)cciFunction1.Period;
			textBox2.Text = cciFunction1.Constant.ToString();

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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function_CCI));
			this.candle1 = new Steema.TeeChart.Styles.Candle();
			this.axis1 = new Steema.TeeChart.Axis(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.cciFunction1 = new Steema.TeeChart.Functions.CCIFunction();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.axis2 = new Steema.TeeChart.Axis(this.components);
			this.panel1.SuspendLayout();
			this.chartContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Text = "CCI function (Commodity Channel Index), is a financial indicator. \r\nIt is used to" +
					" identify cyclical turns in commodities.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.label1);
			// 
			// tChart1
			// 
			// 
			// 
			// 
			this.tChart1.Aspect.View3D = false;
			this.tChart1.Aspect.ZOffset = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tChart1.Axes.Bottom.MaximumOffset = 5;
			this.tChart1.Axes.Bottom.MinimumOffset = 5;
			this.tChart1.Axes.Custom.Add(this.axis1);
			this.tChart1.Axes.Custom.Add(this.axis2);
			// 
			// 
			// 
			this.tChart1.Axes.Left.Visible = false;
			this.tChart1.Cursor = Cursors.Default;
			// 
			// 
			// 
			this.tChart1.Header.Lines = new string[] {
        "CCI Function"};
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
			// 
			// 
			// 
			this.tChart1.Panel.Brush.Gradient.Direction = Drawing.LinearGradientMode.ForwardDiagonal;
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tChart1.Panel.MarginLeft = 8;
			this.tChart1.Series.Add(this.candle1);
			this.tChart1.Series.Add(this.line1);
			this.tChart1.Size = new System.Drawing.Size(440, 205);
			// 
			// candle1
			// 
			// 
			// 
			// 
			this.candle1.Brush.Color = System.Drawing.Color.Red;
			this.candle1.CloseValues = this.candle1.YValues;
			this.candle1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
			this.candle1.ColorEach = false;
			this.candle1.CustomVertAxis = this.axis1;
			this.candle1.DateValues = this.candle1.XValues;
			// 
			// 
			// 
			this.candle1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.candle1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.candle1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.candle1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.candle1.Marks.Callout.Distance = 0;
			this.candle1.Marks.Callout.Draw3D = false;
			this.candle1.Marks.Callout.Length = 10;
			this.candle1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Marks.Callout.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.candle1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.candle1.Pointer.Draw3D = false;
			this.candle1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.candle1.Title = "candle1";
			this.candle1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.candle1.XValues.DataMember = "Date";
			this.candle1.XValues.DateTime = true;
			this.candle1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.candle1.YValues.DataMember = "Close";
			// 
			// axis1
			// 
			this.axis1.EndPosition = 49;
			this.axis1.Horizontal = false;
			this.axis1.MaximumOffset = 5;
			this.axis1.MinimumOffset = 5;
			this.axis1.OtherSide = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Moving average period:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(128, 8);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(240, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Constant:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(296, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// cciFunction1
			// 
			this.cciFunction1.Period = 20;
			// 
			// line1
			// 
			// 
			// 
			// 
			this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
			this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
			this.line1.ColorEach = false;
			this.line1.CustomVertAxis = this.axis2;
			this.line1.DataSource = this.candle1;
			this.line1.Function = this.cciFunction1;
			// 
			// 
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
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
			// 
			// 
			// 
			this.line1.Pointer.Brush.Color = System.Drawing.Color.Green;
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Title = "line1";
			this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
			// 
			// 
			// 
			this.line1.XValues.DateTime = true;
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// axis2
			// 
			this.axis2.Horizontal = false;
			this.axis2.OtherSide = false;
			this.axis2.StartPosition = 51;
			// 
			// Function_CCI
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "Function_CCI";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.chartContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e) {
			cciFunction1.Period=(double)numericUpDown1.Value;
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e) {
			if(!Regex.IsMatch(textBox2.Text, @"[^0-9.,]") && textBox2.Text!="")
				try {
					cciFunction1.Constant=Convert.ToDouble(textBox2.Text);
				}
				catch {throw;}
		}
	}
}

