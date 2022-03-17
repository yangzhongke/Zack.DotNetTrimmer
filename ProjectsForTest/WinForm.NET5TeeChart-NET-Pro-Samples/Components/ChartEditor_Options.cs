using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	public class ChartEditor_Options : Samples.BaseForm
    {
    private Button bEditorRuntime;
    private ChartController chartController1;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private NumericUpDown editorGalleryHeight;
    private Label label5;
    private NumericUpDown editorGalleryWidth;
    private Label label6;
    private GroupBox groupBox1;
    private NumericUpDown editorHeight;
    private Label label3;
    private NumericUpDown editorWidth;
    private Label label4;
    private GroupBox groupBox4;
    private NumericUpDown ChartControllerEdHeight;
    private Label label1;
    private NumericUpDown ChartControllerEdWidth;
    private Label label2;
    private Button button1;
    private Editor editor1;
		private System.ComponentModel.IContainer components = null;

        public ChartEditor_Options()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartEditor_Options));
            this.chartController1 = new Steema.TeeChart.ChartController();
            this.bEditorRuntime = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editorHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.editorWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editorGalleryHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.editorGalleryWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChartControllerEdHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartControllerEdWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editor1 = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorGalleryHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorGalleryWidth)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartControllerEdHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartControllerEdWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(466, 65);
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Size = new System.Drawing.Size(466, 126);
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
            this.tChart1.Header.Lines = new string[] {
        "tChart1"};
            this.tChart1.Location = new System.Drawing.Point(0, 25);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Size = new System.Drawing.Size(466, 70);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Visible = false;
            this.tChart1.Walls.Bottom.Size = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            this.tChart1.Walls.Left.Size = 5;
            // 
            // chartContainer
            // 
            this.chartContainer.Controls.Add(this.chartController1);
            this.chartContainer.Location = new System.Drawing.Point(0, 191);
            this.chartContainer.Size = new System.Drawing.Size(466, 95);
            this.chartContainer.Controls.SetChildIndex(this.chartController1, 0);
            this.chartContainer.Controls.SetChildIndex(this.tChart1, 0);
            // 
            // chartController1
            // 
#if VS2005
            this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
#endif
            this.chartController1.LabelValues = true;
            this.chartController1.Location = new System.Drawing.Point(0, 0);
            this.chartController1.Name = "chartController1";
            this.chartController1.Size = new System.Drawing.Size(466, 25);
            this.chartController1.TabIndex = 1;
            this.chartController1.Text = "chartController1";
            // 
            // bEditorRuntime
            // 
            this.bEditorRuntime.Location = new System.Drawing.Point(8, 11);
            this.bEditorRuntime.Name = "bEditorRuntime";
            this.bEditorRuntime.Size = new System.Drawing.Size(119, 23);
            this.bEditorRuntime.TabIndex = 1;
            this.bEditorRuntime.Text = "Show &Editor Runtime";
#if VS2005
            this.bEditorRuntime.UseVisualStyleBackColor = true;
#endif
            this.bEditorRuntime.Click += new System.EventHandler(this.bEditorRuntime_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editorHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.editorWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editor Size";
            // 
            // editorHeight
            // 
            this.editorHeight.Location = new System.Drawing.Point(60, 43);
            this.editorHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.editorHeight.Name = "editorHeight";
            this.editorHeight.Size = new System.Drawing.Size(53, 20);
            this.editorHeight.TabIndex = 13;
            this.editorHeight.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "&Height :";
            // 
            // editorWidth
            // 
            this.editorWidth.Location = new System.Drawing.Point(60, 18);
            this.editorWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.editorWidth.Name = "editorWidth";
            this.editorWidth.Size = new System.Drawing.Size(53, 20);
            this.editorWidth.TabIndex = 11;
            this.editorWidth.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "&Width :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editorGalleryHeight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.editorGalleryWidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(141, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 72);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor Gallery Size";
            // 
            // editorGalleryHeight
            // 
            this.editorGalleryHeight.Location = new System.Drawing.Point(60, 43);
            this.editorGalleryHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.editorGalleryHeight.Name = "editorGalleryHeight";
            this.editorGalleryHeight.Size = new System.Drawing.Size(53, 20);
            this.editorGalleryHeight.TabIndex = 13;
            this.editorGalleryHeight.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "&Height :";
            // 
            // editorGalleryWidth
            // 
            this.editorGalleryWidth.Location = new System.Drawing.Point(60, 18);
            this.editorGalleryWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.editorGalleryWidth.Name = "editorGalleryWidth";
            this.editorGalleryWidth.Size = new System.Drawing.Size(53, 20);
            this.editorGalleryWidth.TabIndex = 11;
            this.editorGalleryWidth.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "&Width :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.bEditorRuntime);
            this.groupBox3.Location = new System.Drawing.Point(9, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 120);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChartControllerEdHeight);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.ChartControllerEdWidth);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(290, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 72);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ChartController Editor Size";
            // 
            // ChartControllerEdHeight
            // 
            this.ChartControllerEdHeight.Location = new System.Drawing.Point(60, 43);
            this.ChartControllerEdHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ChartControllerEdHeight.Name = "ChartControllerEdHeight";
            this.ChartControllerEdHeight.Size = new System.Drawing.Size(56, 20);
            this.ChartControllerEdHeight.TabIndex = 13;
            this.ChartControllerEdHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ChartControllerEdHeight.ValueChanged += new System.EventHandler(this.ChartControllerEdHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "&Height :";
            // 
            // ChartControllerEdWidth
            // 
            this.ChartControllerEdWidth.Location = new System.Drawing.Point(60, 18);
            this.ChartControllerEdWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ChartControllerEdWidth.Name = "ChartControllerEdWidth";
            this.ChartControllerEdWidth.Size = new System.Drawing.Size(56, 20);
            this.ChartControllerEdWidth.TabIndex = 11;
            this.ChartControllerEdWidth.Value = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.ChartControllerEdWidth.ValueChanged += new System.EventHandler(this.ChartControllerEdWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Width :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "&ShowGallery Custom Size";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // editor1
            // 
            this.editor1.HighLightTabs = false;
            this.editor1.Location = new System.Drawing.Point(0, 0);
            this.editor1.Name = "editor1";
            this.editor1.Options = null;
            this.editor1.TabIndex = 0;
            // 
            // ChartEditor_Options
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(466, 286);
            this.Name = "ChartEditor_Options";
            this.Load += new System.EventHandler(this.ChartEditor_Options_Load);
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.chartContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorGalleryHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorGalleryWidth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartControllerEdHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartControllerEdWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


    private void ChartEditor_Options_Load(object sender, System.EventArgs e)
	{
        editor1.Width = (int)ChartControllerEdWidth.Value;
        editor1.Height = (int)ChartControllerEdHeight.Value;
        this.editor1.Chart = this.tChart1;
        this.chartController1.Chart = this.tChart1;
        this.chartController1.Editor = this.editor1;
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        Styles.Series s = Editors.ChartGallery.CreateNew(tChart1, null, 650, 500);
        if (s != null)
            s.FillSampleValues();
    }

    private void bEditorRuntime_Click(object sender, EventArgs e)
    {
        Steema.TeeChart.Editors.ChartEditor ed = new Steema.TeeChart.Editors.ChartEditor(tChart1);
        ed.Width = (int)editorWidth.Value;
        ed.Height = (int)editorHeight.Value;

        Size size = new Size((int)editorGalleryWidth.Value, (int) editorGalleryHeight.Value);
        ed.GallerySize = size;
        ed.ShowDialog();
    }

    private void ChartControllerEdWidth_ValueChanged(object sender, EventArgs e)
    {
        editor1.Width = (int)ChartControllerEdWidth.Value;
    }

    private void ChartControllerEdHeight_ValueChanged(object sender, EventArgs e)
    {
        editor1.Height = (int)ChartControllerEdHeight.Value;
    }
	}
}

