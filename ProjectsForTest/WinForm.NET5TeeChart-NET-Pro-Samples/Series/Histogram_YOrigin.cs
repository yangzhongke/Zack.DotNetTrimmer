using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
    public class Histogram_YOrigin : Samples.BaseForm
    {
        private CheckBox cbUseYOrigin;
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Steema.TeeChart.Styles.Histogram ser1;

        public Histogram_YOrigin()
        {
            InitializeComponent();
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

        private void Histogram_YOrigin_Load(object sender, EventArgs e)
        {
            tChart1.Aspect.View3D = false;
            ser1 = new Steema.TeeChart.Styles.Histogram();
            tChart1.Series.Add(ser1);
            ser1.Add(0, 10);
            ser1.Add(1, 20);
            ser1.Add(2, -30);
            ser1.Add(3, -10);
            ser1.Add(4, 10);
            ser1.Add(5, 20);
            ser1.Add(6, 30);
            ser1.Add(7, 10);
            ser1.UseYOrigin = true;
            ser1.YOrigin = 0;
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbUseYOrigin = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Histogram Series now allows to specify an YOrigin. \r\nExample :\r\n  histoSeries.Use" +
                "YOrigin = true;\r\n  histoSeries.YOrigin = 0;";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.cbUseYOrigin);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // cbUseYOrigin
            // 
            this.cbUseYOrigin.Checked = true;
            this.cbUseYOrigin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseYOrigin.Location = new System.Drawing.Point(19, 13);
            this.cbUseYOrigin.Name = "cbUseYOrigin";
            this.cbUseYOrigin.Size = new System.Drawing.Size(82, 17);
            this.cbUseYOrigin.TabIndex = 0;
            this.cbUseYOrigin.Text = "&Use YOrigin";
#if VS2005
            this.cbUseYOrigin.AutoSize = true;
            this.cbUseYOrigin.UseVisualStyleBackColor = true;
#endif
            this.cbUseYOrigin.CheckedChanged += new System.EventHandler(this.cbUseYOrigin_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(204, 10);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "YOrigin:";
            // 
            // Histogram_YOrigin
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Histogram_YOrigin";
            this.Load += new System.EventHandler(this.Histogram_YOrigin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void cbUseYOrigin_CheckedChanged(object sender, EventArgs e)
        {
            ser1.UseYOrigin = cbUseYOrigin.Checked;
            label1.Enabled = cbUseYOrigin.Checked;
            numericUpDown1.Enabled = cbUseYOrigin.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ser1.YOrigin = (int) numericUpDown1.Value;
        }
    }
}

