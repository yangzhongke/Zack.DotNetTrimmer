using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
    public class WorldMapDemo : Steema.TeeChart.Samples.BaseForm
    {
        private World worldmap1;
        
        public WorldMapDemo()
        {
            InitializeComponent();
            worldmap1 = new World();
            tChart1.Series.Add(worldmap1);
            worldmap1.UseColorRange = false;
            worldmap1.UsePalette = true;
            worldmap1.Shadow.Visible = false;

            buttonPen1.Pen = worldmap1.Pen;
        }

        private ComboBox comboBox1;
        private Label label1;
        private CheckBox checkBox1;
        private ButtonPen buttonPen1;
        private Button button1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldMapDemo));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonPen1 = new Steema.TeeChart.ButtonPen();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonPen1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            this.tChart1.Axes.Visible = false;
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
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map:";
            // 
            // comboBox1
            // 
#if VS2005
            this.comboBox1.FormattingEnabled = true;
#endif
            this.comboBox1.Items.AddRange(new object[] {
            "World",
            "Africa",
            "Asia",
            "Australia",
            "CentralAmerica",
            "Europe",
            "Europe (EU 15)",
            "Europe (EU 27)",
            "Spain",
            "Middle East",
            "North America",
            "South America",
            "USA",
            "USA with Hawaii and Alaska"});
            this.comboBox1.Location = new System.Drawing.Point(236, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(382, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Axes";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonPen1
            // 
#if VS2005
            this.buttonPen1.UseVisualStyleBackColor = true;
#endif
            this.buttonPen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPen1.Location = new System.Drawing.Point(12, 10);
            this.buttonPen1.Name = "buttonPen1";
            this.buttonPen1.Size = new System.Drawing.Size(75, 23);
            this.buttonPen1.TabIndex = 3;
            this.buttonPen1.Text = "Border";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(99, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Edit";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorldMapDemo
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "WorldMapDemo";
            this.Load += new System.EventHandler(this.WorldMapDemo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void WorldMapDemo_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 5; // Europe
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            worldmap1.Map = (WorldMapType)comboBox1.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tChart1.Axes.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Steema.TeeChart.Editors.SeriesEditor.ShowModal(worldmap1);
        }

    }
}

