using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class FastLine_Nulls : Steema.TeeChart.Samples.BaseForm
    {
        private Steema.TeeChart.Styles.FastLine fastLine1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.ComponentModel.IContainer components = null;

        public FastLine_Nulls()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            fastLine1.FillSampleValues(50);

            // set some null points:
            fastLine1.SetNull(14);
            fastLine1.SetNull(20);
            fastLine1.SetNull(31);
            fastLine1.SetNull(39);

            // allow nulls:
            // (Ignore nulls ... faster )             
            fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;

            // Draw in "stairs" mode:
            fastLine1.Stairs = true;

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastLine_Nulls));
					this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
					this.checkBox1 = new System.Windows.Forms.CheckBox();
					this.checkBox2 = new System.Windows.Forms.CheckBox();
					this.checkBox3 = new System.Windows.Forms.CheckBox();
					this.panel1.SuspendLayout();
					this.chartContainer.SuspendLayout();
					this.SuspendLayout();
					// 
					// textBox1
					// 
					this.textBox1.Text = resources.GetString("textBox1.Text");
					// 
					// panel1
					// 
					this.panel1.Controls.Add(this.checkBox3);
					this.panel1.Controls.Add(this.checkBox2);
					this.panel1.Controls.Add(this.checkBox1);
					this.panel1.Size = new System.Drawing.Size(440, 55);
					// 
					// tChart1
					// 
					// 
					// 
					// 
					this.tChart1.Header.Lines = new string[] {
        "Fastline series with null points and stairs"};
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					this.tChart1.Legend.Title.Pen.Visible = false;
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
					this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
					this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
					this.tChart1.Panel.Brush.Gradient.Sigma = true;
					this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
					this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
					this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
					this.tChart1.Series.Add(this.fastLine1);
					this.tChart1.Size = new System.Drawing.Size(440, 189);
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					// 
					this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
					// 
					// 
					// 
					// 
					// 
					// 
					this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
					this.tChart1.Walls.Bottom.Size = 3;
					// 
					// 
					// 
					// 
					// 
					// 
					this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
					this.tChart1.Walls.Left.Size = 3;
					// 
					// chartContainer
					// 
					this.chartContainer.Location = new System.Drawing.Point(0, 128);
					this.chartContainer.Size = new System.Drawing.Size(440, 189);
					// 
					// fastLine1
					// 
					this.fastLine1.ColorEach = false;
					this.fastLine1.TreatNulls = Styles.TreatNullsStyle.Ignore;
					// 
					// 
					// 
					this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
					// 
					// 
					// 
					// 
					// 
					// 
					this.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
					this.fastLine1.Marks.Callout.ArrowHeadSize = 8;
					// 
					// 
					// 
					this.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
					this.fastLine1.Marks.Callout.Distance = 0;
					this.fastLine1.Marks.Callout.Draw3D = false;
					this.fastLine1.Marks.Callout.Length = 10;
					this.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
					this.fastLine1.Stairs = true;
					this.fastLine1.Title = "fastLine1";
					this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
					// 
					// 
					// 
					this.fastLine1.XValues.DataMember = "X";
					this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
					// 
					// 
					// 
					this.fastLine1.YValues.DataMember = "Y";
					// 
					// checkBox1
					// 
					this.checkBox1.Checked = true;
					this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
					this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
					this.checkBox1.Location = new System.Drawing.Point(16, 16);
					this.checkBox1.Name = "checkBox1";
					this.checkBox1.Size = new System.Drawing.Size(88, 24);
					this.checkBox1.TabIndex = 0;
					this.checkBox1.Text = "Stairs mode";
					this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
					// 
					// checkBox2
					// 
					this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
					this.checkBox2.Location = new System.Drawing.Point(112, 16);
					this.checkBox2.Name = "checkBox2";
					this.checkBox2.Size = new System.Drawing.Size(104, 24);
					this.checkBox2.TabIndex = 1;
					this.checkBox2.Text = "Inverted stairs";
					this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
					// 
					// checkBox3
					// 
					this.checkBox3.Checked = true;
					this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
					this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
					this.checkBox3.Location = new System.Drawing.Point(240, 16);
					this.checkBox3.Name = "checkBox3";
					this.checkBox3.Size = new System.Drawing.Size(104, 24);
					this.checkBox3.TabIndex = 2;
					this.checkBox3.Text = "Ignore nulls";
					this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
					// 
					// FastLine_Nulls
					// 
					this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
					this.ClientSize = new System.Drawing.Size(440, 317);
					this.Name = "FastLine_Nulls";
					this.panel1.ResumeLayout(false);
					this.chartContainer.ResumeLayout(false);
					this.ResumeLayout(false);
					this.PerformLayout();

        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            fastLine1.Stairs = checkBox1.Checked;
            checkBox2.Enabled = fastLine1.Stairs;
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            fastLine1.InvertedStairs = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            fastLine1.TreatNulls = checkBox3.Checked ? Steema.TeeChart.Styles.TreatNullsStyle.Ignore : Steema.TeeChart.Styles.TreatNullsStyle.DoNotPaint;
						tChart1.Invalidate(); 
        }
    }
}

