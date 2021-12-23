namespace YZKGameWizard
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectDir = new System.Windows.Forms.TextBox();
            this.cmbIDEVersion = new System.Windows.Forms.ComboBox();
            this.btnBrowseProjectDir = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.dirDlgProjectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "项目路径";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(128, 21);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(491, 30);
            this.txtProjectName.TabIndex = 2;
            // 
            // txtProjectDir
            // 
            this.txtProjectDir.Location = new System.Drawing.Point(128, 64);
            this.txtProjectDir.Name = "txtProjectDir";
            this.txtProjectDir.Size = new System.Drawing.Size(491, 30);
            this.txtProjectDir.TabIndex = 3;
            // 
            // cmbIDEVersion
            // 
            this.cmbIDEVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDEVersion.FormattingEnabled = true;
            this.cmbIDEVersion.Items.AddRange(new object[] {
            "VC6",
            "VS2008",
            "VS2010",
            "VS2012",
            "VS2013",
            "VS2015",
            "VS2017",
            "VS2019",
            "VS2022"});
            this.cmbIDEVersion.Location = new System.Drawing.Point(625, 25);
            this.cmbIDEVersion.Name = "cmbIDEVersion";
            this.cmbIDEVersion.Size = new System.Drawing.Size(163, 32);
            this.cmbIDEVersion.TabIndex = 4;
            // 
            // btnBrowseProjectDir
            // 
            this.btnBrowseProjectDir.Location = new System.Drawing.Point(625, 66);
            this.btnBrowseProjectDir.Name = "btnBrowseProjectDir";
            this.btnBrowseProjectDir.Size = new System.Drawing.Size(163, 34);
            this.btnBrowseProjectDir.TabIndex = 5;
            this.btnBrowseProjectDir.Text = "浏览...";
            this.btnBrowseProjectDir.UseVisualStyleBackColor = true;
            this.btnBrowseProjectDir.Click += new System.EventHandler(this.btnBrowseProjectDir_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(165, 131);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 24);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://www.yzk18.com";
            this.linkLabel1.Text = "作者：杨中科";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Clicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(338, 131);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(118, 24);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Tag = "https://github.com/yangzhongke/CYZKGameWizard";
            this.linkLabel2.Text = "项目开源网址";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Clicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "版本：3.0.0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseProjectDir);
            this.Controls.Add(this.cmbIDEVersion);
            this.Controls.Add(this.txtProjectDir);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YZKGame向导";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProjectName;
        private TextBox txtProjectDir;
        private ComboBox cmbIDEVersion;
        private Button btnBrowseProjectDir;
        private Button btnStart;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private FolderBrowserDialog dirDlgProjectPath;
        private Label label3;
    }
}