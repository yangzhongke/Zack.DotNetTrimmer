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
    public class Tool_LegendPalette : Steema.TeeChart.Samples.BaseForm
    {
        public Tool_LegendPalette()
        {
            InitializeComponent();
            AddSurfacePoints();
            surface1.UseColorRange = true;
            surface1.UsePalette = false;
            legendPalette1.Pen.Visible = false;
            legendPalette1.Transparent = true;
        }

        private void AddSurfacePoints()
        {
            int NumX = 30;
            int NumZ = 30;
            surface1.NumXValues = NumX;
            surface1.NumZValues =  NumZ;
            for (int x=1; x<=NumX; x++)
                for (int z=1; z<=NumZ; z++)
                    surface1.Add(x,Math.Cos(0.14*x)*Math.Cos(0.25*z)+
                          0.01*(x-(NumX/2))*(z-(NumZ/2)) +
                          13.0*Math.Exp(-0.06*(Math.Pow(x-(NumX/2),2)+Math.Pow(z-(NumZ /2),2)))+
                          6*Math.Exp(-0.03*(Math.Pow(x-(NumX /3),2)+Math.Pow(z-3*(NumZ /5),2)))-1,
                          z);
        }

        private Steema.TeeChart.Styles.Surface surface1;
        private Steema.TeeChart.Tools.LegendPalette legendPalette1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private ComboBox comboBox1;
        private CheckBox checkBox3;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_LegendPalette));
            this.surface1 = new Steema.TeeChart.Styles.Surface();
            this.legendPalette1 = new Steema.TeeChart.Tools.LegendPalette();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Size = new System.Drawing.Size(440, 49);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 80;
            this.tChart1.Aspect.Elevation = 351;
            this.tChart1.Aspect.ElevationFloat = 351;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Rotation = 318;
            this.tChart1.Aspect.RotationFloat = 318;
            
            
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Aspect.Zoom = 79;
            this.tChart1.Aspect.ZoomFloat = 79;
            // 
            // 
            // 
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.MaxNumRows = 8;
            this.tChart1.Legend.Visible = false;
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
            this.tChart1.Panel.MarginRight = 25;
            this.tChart1.Series.Add(this.surface1);
            this.tChart1.Size = new System.Drawing.Size(440, 195);
            this.tChart1.Tools.Add(this.legendPalette1);
            this.tChart1.Resize += new System.EventHandler(this.tChart1_Resize);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 122);
            this.chartContainer.Size = new System.Drawing.Size(440, 195);
            // 
            // surface1
            // 
            // 
            // 
            // 
            this.surface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.surface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.surface1.ColorEach = false;
            this.surface1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.surface1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.surface1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.surface1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.surface1.Marks.Callout.Distance = 0;
            this.surface1.Marks.Callout.Draw3D = false;
            this.surface1.Marks.Callout.Length = 10;
            this.surface1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.surface1.Marks.Callout.Visible = false;
            this.surface1.PaletteMin = 0;
            this.surface1.PaletteStep = 0;
            this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            this.surface1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.surface1.Title = "surface1";
            // 
            // 
            // 
            this.surface1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.surface1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.surface1.ZValues.DataMember = "Z";
            // 
            // legendPalette1
            // 
            this.legendPalette1.Axis = Steema.TeeChart.Tools.LegendPaletteAxis.laDefault;
            // 
            // 
            // 
            this.legendPalette1.Pen.Visible = false;
            this.legendPalette1.Series = this.surface1;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(12, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Vertical";
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(76, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Transparent";
#if VS2005
            this.checkBox2.AutoSize = true;
            this.checkBox2.UseVisualStyleBackColor = true;
#endif
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
#if VS2005
            this.comboBox1.FormattingEnabled = true;
#endif
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Other",
            "Both"});
            this.comboBox1.Location = new System.Drawing.Point(212, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Axis";
            // 
            // checkBox3
            // 
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(337, 17);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(42, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Pen";
#if VS2005
            this.checkBox3.AutoSize = true;
            this.checkBox3.UseVisualStyleBackColor = true;
#endif
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Tool_LegendPalette
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Tool_LegendPalette";
            this.Load += new System.EventHandler(this.Tool_LegendPalette_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            legendPalette1.Vertical = checkBox1.Checked;
            legendPalette1.Left = tChart1.Width - legendPalette1.Width - 10;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            legendPalette1.Transparent = checkBox2.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            legendPalette1.Axis = (Steema.TeeChart.Tools.LegendPaletteAxis)comboBox1.SelectedIndex;
        }

        private void Tool_LegendPalette_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            legendPalette1.Pen.Visible = checkBox3.Checked;
        }

        private void tChart1_Resize(object sender, EventArgs e)
        {
            legendPalette1.Left = tChart1.Width - legendPalette1.Width - 10;
        }

    }
}

