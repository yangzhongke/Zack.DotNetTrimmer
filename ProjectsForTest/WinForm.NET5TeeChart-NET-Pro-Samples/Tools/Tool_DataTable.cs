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
    public class Tool_DataTable : Steema.TeeChart.Samples.BaseForm
    {
        public Tool_DataTable()
        {
            InitializeComponent();
            bar1.FillSampleValues(6);
            bar2.FillSampleValues(6);
            bar3.FillSampleValues(6);
            bar2.SetNull(3);
        }

        private Steema.TeeChart.Tools.DataTableTool dataTableTool1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Button button3;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool_DataTable));
            this.bar1 = new Steema.TeeChart.Styles.Bar();
            this.bar2 = new Steema.TeeChart.Styles.Bar();
            this.bar3 = new Steema.TeeChart.Styles.Bar();
            this.dataTableTool1 = new Steema.TeeChart.Tools.DataTableTool();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Size = new System.Drawing.Size(440, 61);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MaximumOffset = 24;
            this.tChart1.Axes.Bottom.MinimumOffset = 24;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MaximumOffset = 37;
            // 
            // 
            // 
            this.tChart1.Legend.CheckBoxes = true;
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
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Sigma = true;
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 1F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0.8F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Series.Add(this.bar1);
            this.tChart1.Series.Add(this.bar2);
            this.tChart1.Series.Add(this.bar3);
            this.tChart1.Size = new System.Drawing.Size(440, 183);
            this.tChart1.Tools.Add(this.dataTableTool1);
            // 
            // chartContainer
            // 
            this.chartContainer.Location = new System.Drawing.Point(0, 134);
            this.chartContainer.Size = new System.Drawing.Size(440, 183);
            // 
            // bar1
            // 
            // 
            // 
            // 
            this.bar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bar1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bar1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bar1.Marks.Callout.Distance = 0;
            this.bar1.Marks.Callout.Draw3D = false;
            this.bar1.Marks.Callout.Length = 20;
            this.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.bar1.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.bar1.Title = "bar1";
            // 
            // 
            // 
            this.bar1.XValues.DataMember = "X";
            this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bar1.YValues.DataMember = "Bar";
            // 
            // bar2
            // 
            // 
            // 
            // 
            this.bar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.bar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.bar2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bar2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bar2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bar2.Marks.Callout.Distance = 0;
            this.bar2.Marks.Callout.Draw3D = false;
            this.bar2.Marks.Callout.Length = 20;
            this.bar2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.bar2.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.bar2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.bar2.Title = "bar2";
            // 
            // 
            // 
            this.bar2.XValues.DataMember = "X";
            this.bar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bar2.YValues.DataMember = "Bar";
            // 
            // bar3
            // 
            // 
            // 
            // 
            this.bar3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.bar3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.bar3.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bar3.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bar3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bar3.Marks.Callout.Distance = 0;
            this.bar3.Marks.Callout.Draw3D = false;
            this.bar3.Marks.Callout.Length = 20;
            this.bar3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.bar3.Marks.Callout.Visible = false;
            // 
            // 
            // 
            this.bar3.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(122)))));
            this.bar3.Title = "bar3";
            // 
            // 
            // 
            this.bar3.XValues.DataMember = "X";
            this.bar3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bar3.YValues.DataMember = "Bar";
            // 
            // dataTableTool1
            // 
            // 
            // 
            // 
            this.dataTableTool1.ColumnPen.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.dataTableTool1.RowPen.Color = System.Drawing.Color.Black;
            this.dataTableTool1.Top = 103;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vert <-> Horiz";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(129, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Axis <-> Other axis";
#if VS2005
            this.button2.UseVisualStyleBackColor = true;
#endif
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(270, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Axis inverted";
#if VS2005
            this.checkBox1.AutoSize = true;
            this.checkBox1.UseVisualStyleBackColor = true;
#endif
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(359, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit tool";
#if VS2005
            this.button3.UseVisualStyleBackColor = true;
#endif
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tool_DataTable
            // 
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "Tool_DataTable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Steema.TeeChart.Styles.Bar bar1;
        private Steema.TeeChart.Styles.Bar bar2;
        private Steema.TeeChart.Styles.Bar bar3;

        private void button1_Click(object sender, EventArgs e)
        {
            Type style = (tChart1[0].YValues == tChart1[0].mandatory) ? typeof(Styles.HorizBar) : typeof(Styles.Bar);
            for (int t=0; t<tChart1.Series.Count; t++)
            {
                Styles.Series s = tChart1[t];
                Styles.Series.ChangeType(ref s, style);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int t=0; t<tChart1.Series.Count; t++)
            {
                Styles.ValueList vals = tChart1[t].mandatory;
                if (vals == tChart1[t].YValues)
                {
                    if (tChart1[t].HorizAxis == Steema.TeeChart.Styles.HorizontalAxis.Bottom)
                        tChart1[t].HorizAxis= Steema.TeeChart.Styles.HorizontalAxis.Top;
                    else tChart1[t].HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Bottom;
                }
                else
                {
                    if (tChart1[t].VertAxis == Steema.TeeChart.Styles.VerticalAxis.Left)
                        tChart1[t].VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
                    else tChart1[t].VertAxis = Steema.TeeChart.Styles.VerticalAxis.Left;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            for (int t=0; t<tChart1.Series.Count; t++)
            {
                if (tChart1[t].Visible)
                {
                    if (tChart1[t].mandatory == tChart1[t].YValues)
                        tChart1[t].GetHorizAxis.Inverted = checkBox1.Checked;
                    else tChart1[t].GetVertAxis.Inverted = checkBox1.Checked;
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editors.Tools.ToolsEditor.ShowEditor(dataTableTool1);
        }
    }
}

