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
    public class Tool_BannerTool : Steema.TeeChart.Samples.BaseForm
    {
        public Tool_BannerTool()
        {
            InitializeComponent();
        }

        private Steema.TeeChart.Tools.BannerTool bannerTool1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;

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
            this.bannerTool1 = new Steema.TeeChart.Tools.BannerTool();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "Scrolling banner and Font Blinker.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Size = new System.Drawing.Size(440, 68);
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
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Sigma = true;
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Size = new System.Drawing.Size(440, 176);
            this.tChart1.Tools.Add(this.bannerTool1);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 141);
            this.chartContainer.Size = new System.Drawing.Size(440, 176);
            // 
            // bannerTool1
            // 
            this.bannerTool1.AutoSize = true;
            this.bannerTool1.BlinkDelayOff = 500;
            this.bannerTool1.Cursor = Drawing.Cursors.Default;
            this.bannerTool1.Left = 100;
            this.bannerTool1.Position = Steema.TeeChart.Tools.AnnotationPositions.RightTop;
            // 
            // 
            // 
            this.bannerTool1.Shape.BorderRound = 8;
            this.bannerTool1.Shape.Bottom = 119;
            this.bannerTool1.Shape.CustomPosition = true;
            this.bannerTool1.Shape.Left = 100;
            this.bannerTool1.Shape.Lines = new string[] {
        "Scrolling and/or blinking text"};
            this.bannerTool1.Shape.Right = 273;
            // 
            // 
            // 
            this.bannerTool1.Shape.Shadow.Visible = true;
            this.bannerTool1.Shape.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;
            this.bannerTool1.Shape.Top = 100;
            this.bannerTool1.Text = "Scrolling and/or blinking text";
            this.bannerTool1.Top = 100;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(12, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Scroll";
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(81, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Blink";
#if VS2005
            this.checkBox2.AutoSize = true;
            this.checkBox2.UseVisualStyleBackColor = true;
#endif
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Direction";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
#if VS2005
            this.comboBox1.FormattingEnabled = true;
#endif
            this.comboBox1.Items.AddRange(new object[] {
            "Right to Left",
            "Left to Right"});
            this.comboBox1.Location = new System.Drawing.Point(81, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Scrolling and blinking text";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Tool_BannerTool
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Tool_BannerTool";
            this.Load += new System.EventHandler(this.Tool_BannerTool_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bannerTool1.Scroll = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bannerTool1.Blink = checkBox2.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bannerTool1.ScrollDirection = (Steema.TeeChart.Tools.ScrollingDirection)comboBox1.SelectedIndex;
        }

        private void Tool_BannerTool_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            bannerTool1.Scroll = checkBox1.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bannerTool1.Text = textBox2.Text;
        }

    }
}

