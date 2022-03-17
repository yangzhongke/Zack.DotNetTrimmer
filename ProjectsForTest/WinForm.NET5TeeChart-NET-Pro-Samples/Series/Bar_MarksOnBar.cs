using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    public class Bar_MarksOnBar : Steema.TeeChart.Samples.BaseForm
    {
        Steema.TeeChart.Styles.HorizBar ser1;

        public Bar_MarksOnBar()
        {
            InitializeComponent();
        }

        private void Bar_MarksOnBar_Load(object sender, EventArgs e)
        {
            ser1 = new Steema.TeeChart.Styles.HorizBar();
            ser1.FillSampleValues(5);
            ser1.Marks.AutoPosition = false;
            ser1.Pen.Visible = false;
            tChart1.Series.Add(ser1);

            tChart1.Aspect.View3D = false;
            ser1.MarksOnBar = true;
            cbStyle.SelectedIndex = 0;
            cbLocation.SelectedIndex = 2;
            ser1.Marks.Transparent = true;
            ser1.Marks.Font.Name = "Rage Italic";
            ser1.Marks.Font.Color = Color.Black;
            UDFontSize.Value = 17;

            ser1.BarStyle = Steema.TeeChart.Styles.BarStyles.RectGradient;
            ser1.Gradient.StartColor = Color.FromArgb(230, 200, 90);
            ser1.Gradient.MiddleColor = Color.FromArgb(226, 242, 170);
            ser1.Gradient.EndColor = Color.FromArgb(230, 200, 90);
            ser1.Gradient.Visible = true;
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Steema.TeeChart.Styles.Series s = tChart1[0];

            switch (cbStyle.SelectedIndex)
            {
                case 0:
                    Steema.TeeChart.Styles.Series.ChangeType(ref s, typeof(Steema.TeeChart.Styles.HorizBar));
                    break;
                case 1:
                    Steema.TeeChart.Styles.Series.ChangeType(ref s, typeof(Steema.TeeChart.Styles.Bar));
                    break;
            }
            UpdateMarksLocation();
        }

        private void UpdateMarksLocation()
        {
            (tChart1[0] as Steema.TeeChart.Styles.CustomBar).MarksOnBar = cbMarksOnBar.Checked;
            cbLocation_SelectedIndexChanged(null, null);
        }

        private void cbMarksOnBar_CheckedChanged(object sender, EventArgs e)
        {
            (tChart1[0] as Steema.TeeChart.Styles.CustomBar).MarksOnBar = cbMarksOnBar.Checked;
            cbLocation.Enabled = cbMarksOnBar.Checked;
            label2.Enabled = cbMarksOnBar.Enabled;
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLocation.SelectedIndex)
            {
                case 0:
                    (tChart1[0] as Steema.TeeChart.Styles.CustomBar).MarksLocation = Steema.TeeChart.Styles.MarksLocation.Start;
                    break;
                case 1:
                    (tChart1[0] as Steema.TeeChart.Styles.CustomBar).MarksLocation = Steema.TeeChart.Styles.MarksLocation.Center;
                    break;
                case 2:
                    (tChart1[0] as Steema.TeeChart.Styles.CustomBar).MarksLocation = Steema.TeeChart.Styles.MarksLocation.End;
                    break;
            }
        }

        private void UDAngle_ValueChanged(object sender, EventArgs e)
        {
            tChart1[0].Marks.Angle = (int)UDAngle.Value;
        }

        private void UDFontSize_ValueChanged(object sender, EventArgs e)
        {
            tChart1[0].Marks.Font.Size = (int)UDFontSize.Value;
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bar_MarksOnBar));
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMarksOnBar = new System.Windows.Forms.CheckBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UDAngle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.UDFontSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(624, 106);
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UDFontSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.UDAngle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbMarksOnBar);
            this.panel1.Controls.Add(this.cbStyle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Size = new System.Drawing.Size(624, 39);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Size = new System.Drawing.Size(624, 298);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 145);
            this.chartContainer.Size = new System.Drawing.Size(624, 298);
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
#if VS2005
            this.cbLocation.FormattingEnabled = true;
#endif
            this.cbLocation.Items.AddRange(new object[] {
            "start",
            "center",
            "end"});
            this.cbLocation.Location = new System.Drawing.Point(319, 12);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(67, 20);
            this.cbLocation.TabIndex = 10;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Location :";
            // 
            // cbMarksOnBar
            // 
            this.cbMarksOnBar.Checked = true;
            this.cbMarksOnBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMarksOnBar.Location = new System.Drawing.Point(169, 14);
            this.cbMarksOnBar.Name = "cbMarksOnBar";
            this.cbMarksOnBar.Size = new System.Drawing.Size(93, 16);
#if VS2005
            this.cbMarksOnBar.AutoSize = true;
            this.cbMarksOnBar.TabIndex = 8;
            this.cbMarksOnBar.UseVisualStyleBackColor = true;
#endif
            this.cbMarksOnBar.Text = "Marks on Bar";
            this.cbMarksOnBar.CheckedChanged += new System.EventHandler(this.cbMarksOnBar_CheckedChanged);
            // 
            // cbStyle
            // 
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
#if VS2005
            this.cbStyle.FormattingEnabled = true;
#endif
            this.cbStyle.Items.AddRange(new object[] {
            "horizontal",
            "vertical"});
            this.cbStyle.Location = new System.Drawing.Point(67, 12);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(89, 20);
            this.cbStyle.TabIndex = 7;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bar Style :";
            // 
            // UDAngle
            // 
            this.UDAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UDAngle.Increment = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.UDAngle.Location = new System.Drawing.Point(437, 13);
            this.UDAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.UDAngle.Name = "UDAngle";
            this.UDAngle.Size = new System.Drawing.Size(46, 19);
            this.UDAngle.TabIndex = 12;
            this.UDAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UDAngle.ValueChanged += new System.EventHandler(this.UDAngle_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "&Angle:";
            // 
            // UDFontSize
            // 
            this.UDFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UDFontSize.Location = new System.Drawing.Point(544, 13);
            this.UDFontSize.Name = "UDFontSize";
            this.UDFontSize.Size = new System.Drawing.Size(42, 19);
            this.UDFontSize.TabIndex = 14;
            this.UDFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.UDFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0}); 
            this.UDFontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.UDFontSize.ValueChanged += new System.EventHandler(this.UDFontSize_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "&Font Size:";
            // 
            // Bar_MarksOnBar
            // 
            this.ClientSize = new System.Drawing.Size(624, 443);
            this.Name = "Bar_MarksOnBar";
            this.Load += new System.EventHandler(this.Bar_MarksOnBar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UDAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbMarksOnBar;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UDAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UDFontSize;
        private System.Windows.Forms.Label label4;
    }


    
}
