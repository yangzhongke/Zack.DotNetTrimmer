using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
    /// <summary>
    /// Main Examples form.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView treeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxFindAll;
        private System.Windows.Forms.CheckBox checkBoxFindSource;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;

        // manually defined at runtime
        private static string OldSourceFile;
        private static Form TheForm;
        private static Type OldFormType;
        private System.Windows.Forms.TabPage tabPageNew;
        private System.Windows.Forms.TabPage tabPageAll;
        //private System.Windows.Forms.ContextMenu contextMenu1;
        //private System.Windows.Forms.MenuItem menuItem1;
        //private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNodePath;
        private System.Windows.Forms.Button butGo;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Panel panelExample;
        private System.Windows.Forms.TabControl tabControlExample;
        private System.Windows.Forms.TabPage tabExample;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabWeb;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        //private MenuItem menuItem5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private SaveFileDialog saveFileDialog1;
        private static string SourceFile;

        private struct DemoFormInfo
        {
            public Type formtype;
            public string unitname;
        }

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //			this.tabControl1.TabPages.Remove(this.tabPageNew); // well, it's first NET version so ...
            tabControl1.SelectedTab = tabPageNew;
            // load data from tree
            LoadTreeFromStrings(treeView1, textBox1.Lines);
            LoadTreeFromStrings(treeView2, textBox2.Lines);
            treeView1.HotTracking = true;
            //canvasType = CanvasType.GDIPlus;
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

        /// <summary>
        /// Finds source code *.cs file
        /// </summary>
        private string CodeFile(TreeNode node)
        {
            if (node == null)
            {
                return "";
            }
            else
            {
                var fn = ((DemoFormInfo)node.Tag).unitname;
                fn = fn.Trim();
                if (fn != "")
                {
                    fn += ".cs";
                }

                return fn;
            }
        }

        private Type FindType(Type t)
        {
            Type tp = null;
            // find match, only one assembly, so not a problem
            var a = System.Reflection.Assembly.GetCallingAssembly();
            var types = a.GetExportedTypes();
            for (var i = 0; i < types.Length; i++)
            {
                if (types[i].Equals(t))
                {
                    tp = types[i];
                    break;
                }
            }

            return tp;
        }

        /// <summary>
        /// Shows specific demo form
        /// </summary>
        private void ShowForm(TreeView tree)
        {
            if (tree.SelectedNode != null)
            {
                if (((DemoFormInfo)tree.SelectedNode.Tag).formtype != null)
                {
                    var t = FindType(((DemoFormInfo)tree.SelectedNode.Tag).formtype);
                    if (t != OldFormType)
                    {
                        try
                        {
                            if (TheForm != null)
                            {
                                TheForm.Dispose();
                            }
                            // find and create form
                            TheForm = (Form)System.Activator.CreateInstance(t);
                            OldFormType = t;
                            Steema.TeeChart.Editors.EditorUtils.InsertForm(TheForm, tabExample);
                        }
                        catch (Exception ee)
                        {
                            // missing form, set red bullet icon
                            MessageBox.Show(ee.Message);
                            tree.SelectedNode.ImageIndex = 3;
                            tree.SelectedNode.SelectedImageIndex = 3;
                        }
                    }
                }
                else
                  if (tree.SelectedNode.Nodes.Count == 0)
                {
                    // missing form, set red bullet icon
                    tree.SelectedNode.ImageIndex = 3;
                    tree.SelectedNode.SelectedImageIndex = 3;
                }

                //statusBar1.Panels[0].Text = tree.SelectedNode.Text;
                tbNodePath.Text = tree.SelectedNode.FullPath;
            }
            else
            {
                //statusBar1.Panels[0].Text = "";
                tbNodePath.Text = "";

            }
        }

        #region Setup Tree
        /// <summary>
        // Loads treeView structure from a string array
        /// </summary>
        private void LoadTreeFromStrings(System.Windows.Forms.TreeView tree,
            string[] strings)
        {
            tree.BeginUpdate();
            try
            {
                string tmpstr, NodeText, ClassName, UnitName;
                string[] st;
                int alevel;
                DemoFormInfo FormInfo;

                tree.Nodes.Clear();
                DemoNode OwnerNode = null;
                DemoNode tmpNode, NextNode;
                for (var i = 0; i < strings.Length; i++)
                {
                    NodeText = "";
                    // first get level
                    alevel = 0;
                    while (strings[i][alevel] == ' ')
                    {
                        alevel++;
                    }

                    tmpstr = strings[i].Substring(alevel);
                    // split info, get caption, form class name + unit name
                    st = tmpstr.Split(',');
                    NodeText = st[0];
                    ClassName = st.Length > 1 ? "Steema.TeeChart.Samples." + st[1] : "";
                    UnitName = st.Length > 2 ? st[2] : "";

                    // use TreeNode Tag property to add form info
                    FormInfo = new DemoFormInfo
                    {
                        unitname = UnitName,
                        formtype = ClassName == "" ? null : System.Reflection.Assembly.GetCallingAssembly().GetType(ClassName)
                    };

                    // finally, add node to treeView
                    tmpNode = new DemoNode(NodeText);
                    if ((OwnerNode == null) || (alevel == 0))
                    {
                        tree.Nodes.Add(tmpNode);
                    }
                    else if (OwnerNode.Level == alevel)
                    {
                        OwnerNode.Parent.Nodes.Add(tmpNode);
                    }
                    else if (OwnerNode.Level == alevel - 1)
                    {
                        OwnerNode.Nodes.Add(tmpNode);
                    }
                    else if (OwnerNode.Level > alevel)
                    {
                        NextNode = (DemoNode)OwnerNode.Parent;
                        while (NextNode.Level > alevel)
                        {
                            NextNode = (DemoNode)NextNode.Parent;
                        }

                        NextNode.Parent.Nodes.Add(tmpNode);
                    }
                    tmpNode.AbsoluteIndex = i;
                    tmpNode.Tag = FormInfo;
                    OwnerNode = tmpNode;
                }
                // now setup images
                SetTreeNodesImage(tree);
                if (tree.Nodes.Count > 0)
                {
                    tree.Nodes[0].Expand();
                }
            }
            finally
            {
                tree.EndUpdate();
            }
        }

        private void SetImagesRecursively(TreeNode n)
        {
            n.ImageIndex = n.Nodes.Count == 0 ? 2 : 0;
            n.SelectedImageIndex = n.ImageIndex;
            foreach (TreeNode ch in n.Nodes)
            {
                SetImagesRecursively(ch);
            }
        }

        private void SetTreeNodesImage(TreeView tree)
        {
            tree.BeginUpdate();
            try
            {
                var nodes = tree.Nodes;
                foreach (TreeNode n in nodes)
                {
                    SetImagesRecursively(n);
                }
            }
            finally
            {
                tree.EndUpdate();
            }
        }
        #endregion

        private TreeView theTree()
        {
            if (tabControl1.SelectedTab == tabPageNew)
            {
                return treeView1;
            }
            else if (tabControl1.SelectedTab == tabPageAll)
            {
                return treeView2;
            }
            else
            {
                return treeSearch;
            }
        }

        private void OpenWebPage(string location)
        {
           
        }

        #region	Tree Search Algorithm
        private bool FoundTextIn(string s, string[] Words, bool FindAllWords)
        {
            // covert to UPPERCASE
            s = s.ToUpper();
            if (FindAllWords)
            {
                for (var t = 0; t < Words.Length; t++)
                {
                    if (s.IndexOf(Words[t], 0) == -1)
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                for (var t = 0; t < Words.Length; t++)
                {
                    if (s.IndexOf(Words[t], 0) != -1)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        private void AddResult(DemoNode n)
        {
            var Added = new DemoNode(n.Text)
            {
                Tag = n.Tag,
                AbsoluteIndex = treeSearch.GetNodeCount(false)
            };
            treeSearch.Nodes.Add(Added);
        }

        private bool SearchInLines(string[] lines, string[] Words, bool FindAllWords)
        {
            for (var t = 0; t < lines.Length; t++)
            {
                if (FoundTextIn(lines[t], Words, FindAllWords))
                {
                    return true;
                }
            }

            return false;
        }

        private bool SearchInTextBox(TextBox txtbox, string[] Words, bool FindAllWords)
        {
            if (txtbox.Lines.Length > 0)
            {
                return SearchInLines(txtbox.Lines, Words, FindAllWords);
            }
            else
            {
                return FoundTextIn(txtbox.Text, Words, FindAllWords);
            }
        }

        private bool SearchInForm(Form form, string[] Words, bool FindAllWords)
        {
            var res = false;
            for (var t = 0; t < form.Controls.Count; t++)
            {
                if (form.Controls[t] is System.Windows.Forms.TextBox)
                {
                    res = SearchInTextBox(form.Controls[t] as System.Windows.Forms.TextBox, Words, FindAllWords);
                    if (res)
                    {
                        break;
                    }
                }
            }

            return res;
        }

        private bool FoundTextInNode(DemoNode n, string[] Words, bool FindAllWords,
                                    StringCollection formNames)
        {
            var res = false;
            var tmp = (DemoFormInfo)n.Tag;
            if ((tmp.formtype != null) || (tmp.unitname != null))
            {
                // First of all, search in tree node Text...
                res = FoundTextIn(n.Text, Words, FindAllWords);

                if (!res)
                {
                    var t = FindType(((DemoFormInfo)n.Tag).formtype);
                    if (t != null)
                    {
                        using (var tmpForm = (Form)System.Activator.CreateInstance(t))
                        {
                            // Avoid processing same form twice...
                            if (formNames.IndexOf(tmp.formtype.ToString()) != -1)
                            {
                                return res;
                            }

                            formNames.Add(tmp.formtype.ToString());

                            // Now do search ...
                            if (tmpForm is BaseForm)
                            {
                                res = SearchInTextBox((tmpForm as BaseForm).textBox1, Words, FindAllWords);
                            }
                            else
                            {
                                res = SearchInForm(tmpForm, Words, FindAllWords);
                            }
                        }
                    }
                }

                // Load form source code and search...
                if (!res)
                {
                    if ((tmp.unitname != null) && (checkBoxFindSource.Checked))
                    {
                        var fn = Utils.CodePath() + tmp.unitname + ".cs";
                        var fi = new FileInfo(fn);
                        if (fi.Exists)
                        {
                            var r = fi.OpenText();
                            try
                            {
                                string textLine;
                                while ((textLine = r.ReadLine()) != null)
                                {
                                    res = FoundTextIn(textLine, Words, FindAllWords);
                                    if (res)
                                    {
                                        break;
                                    }
                                }
                            }
                            finally
                            {
                                r.Close();
                            }
                        }
                    }
                }
            }
            return res;
        }

        private void DoSearchTree(TreeView tree, ProgressBar pb, int Offset,
            string[] Words, bool FindAllWords, StringCollection formNames)
        {
            var tmp = 0;
            DemoNode n = null;
            var NodeCount = tree.GetNodeCount(true);
            if (NodeCount > 0)
            {
                n = (DemoNode)tree.Nodes[0];
            }

            for (var t = 0; t < NodeCount; t++)
            {
                tmp = Offset + t * 50 / NodeCount;
                if (pb.Value != tmp)
                {
                    pb.Value = tmp;
                }

                if (FoundTextInNode(n, Words, FindAllWords, formNames))
                {
                    AddResult(n);
                }

                t++;
                n = (DemoNode)n.MoveForward();
            }
        }

        private void DoSearch()
        {
            treeSearch.BeginUpdate();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                treeSearch.Nodes.Clear();
                if (TheForm != null)
                {
                    TheForm.Dispose();
                }

                var SearchText = comboBoxSearch.Text;

                if (SearchText != "")
                {
                    // new text item ? Then add it to combobox items
                    if (comboBoxSearch.Items.IndexOf(SearchText) < 0)
                    {
                        comboBoxSearch.Items.Add(SearchText);
                    }

                    // first, convert SearchText to UPPERCASE
                    SearchText = SearchText.ToUpper();
                    // split words
                    var Words = SearchText.Split(' ');
                    var pb = new System.Windows.Forms.ProgressBar(); ;

                    // used to store all already seached forms (to prevent duplicate search
                    var formNames = new StringCollection();
                    try
                    {
                        // setup ProgressBar properties
                        pb.Location = new System.Drawing.Point(0, 3);
                        pb.Width = Math.Max(200, tabControl1.Width);
                        pb.Minimum = 0;
                        pb.Maximum = 100;
                        pb.Value = 0;
                        //statusBar1.SuspendLayout();
                        //statusBar1.Controls.Add(pb);
                        //statusBar1.ResumeLayout(true);

                        // now do complete search
                        DoSearchTree(treeView1, pb, 0, Words, checkBoxFindAll.Checked, formNames);
                        DoSearchTree(treeView2, pb, 50, Words, checkBoxFindAll.Checked, formNames);
                        pb.Value = 100;
                    }
                    finally
                    {
                        //statusBar1.SuspendLayout();
                        //statusBar1.Controls.Remove(pb);
                        pb.Dispose();
                        formNames.Clear();
                        formNames = null;
                        //statusBar1.ResumeLayout(true);
                    }
                }
            }
            finally
            {
                treeSearch.EndUpdate();
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNew = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.treeSearch = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxFindSource = new System.Windows.Forms.CheckBox();
            this.checkBoxFindAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAll = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelExample = new System.Windows.Forms.Panel();
            this.tabControlExample = new System.Windows.Forms.TabControl();
            this.tabExample = new System.Windows.Forms.TabPage();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabWeb = new System.Windows.Forms.TabPage();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.butGo = new System.Windows.Forms.Button();
            this.tbNodePath = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageNew.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageAll.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelExample.SuspendLayout();
            this.tabControlExample.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(756, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 100);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(775, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(96, 100);
            this.panel6.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 100);
            this.panel2.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNew);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabPageAll);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 614);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPageNew
            // 
            this.tabPageNew.Controls.Add(this.textBox2);
            this.tabPageNew.Controls.Add(this.textBox1);
            this.tabPageNew.Controls.Add(this.treeView1);
            this.tabPageNew.ImageIndex = 3;
            this.tabPageNew.Location = new System.Drawing.Point(4, 24);
            this.tabPageNew.Name = "tabPageNew";
            this.tabPageNew.Size = new System.Drawing.Size(280, 586);
            this.tabPageNew.TabIndex = 0;
            this.tabPageNew.Text = "What\'s New?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 44);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 242);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.Visible = false;
            this.textBox2.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 315);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 177);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.CausesValidation = false;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.FullRowSelect = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(280, 586);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.treeSearch);
            this.tabSearch.Controls.Add(this.panel4);
            this.tabSearch.Location = new System.Drawing.Point(4, 24);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(280, 751);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "Search";
            // 
            // treeSearch
            // 
            this.treeSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSearch.Location = new System.Drawing.Point(0, 138);
            this.treeSearch.Name = "treeSearch";
            this.treeSearch.Size = new System.Drawing.Size(280, 613);
            this.treeSearch.TabIndex = 0;
            this.treeSearch.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.buttonSearch);
            this.panel4.Controls.Add(this.checkBoxFindSource);
            this.panel4.Controls.Add(this.checkBoxFindAll);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboBoxSearch);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 138);
            this.panel4.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(246, 31);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(32, 28);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // checkBoxFindSource
            // 
            this.checkBoxFindSource.Checked = true;
            this.checkBoxFindSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFindSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxFindSource.Location = new System.Drawing.Point(19, 111);
            this.checkBoxFindSource.Name = "checkBoxFindSource";
            this.checkBoxFindSource.Size = new System.Drawing.Size(263, 19);
            this.checkBoxFindSource.TabIndex = 0;
            this.checkBoxFindSource.Text = "&Look in source code";
            // 
            // checkBoxFindAll
            // 
            this.checkBoxFindAll.Checked = true;
            this.checkBoxFindAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxFindAll.Location = new System.Drawing.Point(19, 87);
            this.checkBoxFindAll.Name = "checkBoxFindAll";
            this.checkBoxFindAll.Size = new System.Drawing.Size(263, 20);
            this.checkBoxFindAll.TabIndex = 5;
            this.checkBoxFindAll.Text = "Find &all words (AND)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search options : ";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Location = new System.Drawing.Point(10, 32);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(231, 23);
            this.comboBoxSearch.TabIndex = 2;
            this.comboBoxSearch.Text = "Gradient Text";
            this.comboBoxSearch.TextChanged += new System.EventHandler(this.comboBoxSearch_TextChanged);
            this.comboBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Enter words to search:";
            // 
            // tabPageAll
            // 
            this.tabPageAll.Controls.Add(this.treeView2);
            this.tabPageAll.Location = new System.Drawing.Point(4, 24);
            this.tabPageAll.Name = "tabPageAll";
            this.tabPageAll.Size = new System.Drawing.Size(280, 751);
            this.tabPageAll.TabIndex = 1;
            this.tabPageAll.Text = "All Features";
            // 
            // treeView2
            // 
            this.treeView2.CausesValidation = false;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(280, 751);
            this.treeView2.TabIndex = 1;
            this.treeView2.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);
            this.treeView2.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelExample);
            this.panel3.Controls.Add(this.panelNavBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(288, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 614);
            this.panel3.TabIndex = 4;
            // 
            // panelExample
            // 
            this.panelExample.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelExample.Controls.Add(this.tabControlExample);
            this.panelExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExample.Location = new System.Drawing.Point(0, 69);
            this.panelExample.Name = "panelExample";
            this.panelExample.Size = new System.Drawing.Size(676, 545);
            this.panelExample.TabIndex = 2;
            // 
            // tabControlExample
            // 
            this.tabControlExample.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlExample.Controls.Add(this.tabExample);
            this.tabControlExample.Controls.Add(this.tabSource);
            this.tabControlExample.Controls.Add(this.tabWeb);
            this.tabControlExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlExample.HotTrack = true;
            this.tabControlExample.Location = new System.Drawing.Point(0, 0);
            this.tabControlExample.Name = "tabControlExample";
            this.tabControlExample.SelectedIndex = 0;
            this.tabControlExample.Size = new System.Drawing.Size(676, 545);
            this.tabControlExample.TabIndex = 1;
            this.tabControlExample.SelectedIndexChanged += new System.EventHandler(this.tabControlExample_SelectedIndexChanged);
            // 
            // tabExample
            // 
            this.tabExample.BackColor = System.Drawing.Color.White;
            this.tabExample.Location = new System.Drawing.Point(4, 4);
            this.tabExample.Name = "tabExample";
            this.tabExample.Size = new System.Drawing.Size(668, 517);
            this.tabExample.TabIndex = 0;
            this.tabExample.Text = "Example";
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.buttonConfig);
            this.tabSource.Controls.Add(this.richTextBox1);
            this.tabSource.Location = new System.Drawing.Point(4, 4);
            this.tabSource.Name = "tabSource";
            this.tabSource.Size = new System.Drawing.Size(861, 682);
            this.tabSource.TabIndex = 2;
            this.tabSource.Text = "Source";
            this.tabSource.Visible = false;
            // 
            // buttonConfig
            // 
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.Location = new System.Drawing.Point(22, 23);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(132, 29);
            this.buttonConfig.TabIndex = 1;
            this.buttonConfig.Text = "&Configure...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(861, 682);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // tabWeb
            // 
            this.tabWeb.Location = new System.Drawing.Point(4, 4);
            this.tabWeb.Name = "tabWeb";
            this.tabWeb.Size = new System.Drawing.Size(861, 682);
            this.tabWeb.TabIndex = 1;
            this.tabWeb.Text = "Web";
            this.tabWeb.Visible = false;
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNavBar.Controls.Add(this.button1);
            this.panelNavBar.Controls.Add(this.button2);
            this.panelNavBar.Controls.Add(this.buttonF);
            this.panelNavBar.Controls.Add(this.buttonB);
            this.panelNavBar.Controls.Add(this.butGo);
            this.panelNavBar.Controls.Add(this.tbNodePath);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(676, 69);
            this.panelNavBar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(580, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Close";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(485, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 24);
            this.button2.TabIndex = 16;
            this.button2.Text = "&About...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonF.CausesValidation = false;
            this.buttonF.Enabled = false;
            this.buttonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonF.Image = ((System.Drawing.Image)(resources.GetObject("buttonF.Image")));
            this.buttonF.Location = new System.Drawing.Point(86, 38);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(66, 25);
            this.buttonF.TabIndex = 15;
            this.buttonF.Text = " Next";
            this.buttonF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonB.CausesValidation = false;
            this.buttonB.Enabled = false;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Image = ((System.Drawing.Image)(resources.GetObject("buttonB.Image")));
            this.buttonB.Location = new System.Drawing.Point(8, 38);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(66, 25);
            this.buttonB.TabIndex = 14;
            this.buttonB.Text = "Prev_";
            this.buttonB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.button3_Click);
            // 
            // butGo
            // 
            this.butGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGo.Location = new System.Drawing.Point(437, 4);
            this.butGo.Name = "butGo";
            this.butGo.Size = new System.Drawing.Size(90, 24);
            this.butGo.TabIndex = 13;
            this.butGo.Text = "GoTo";
            this.butGo.Click += new System.EventHandler(this.butGo_Click);
            // 
            // tbNodePath
            // 
            this.tbNodePath.BackColor = System.Drawing.Color.White;
            this.tbNodePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNodePath.Location = new System.Drawing.Point(8, 4);
            this.tbNodePath.Name = "tbNodePath";
            this.tbNodePath.Size = new System.Drawing.Size(424, 23);
            this.tbNodePath.TabIndex = 12;
            this.tbNodePath.TextChanged += new System.EventHandler(this.tbNodePath_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(288, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 614);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "ChartLayout.bmp";
            this.saveFileDialog1.Filter = "Bitmap files |*.bmp";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(964, 714);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeeChart for .NET Examples";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageNew.ResumeLayout(false);
            this.tabPageNew.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageAll.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelExample.ResumeLayout(false);
            this.tabControlExample.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.Run(new MainForm());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Steema.TeeChart.Editors.AboutBox.ShowModal();
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            var s = sender as TreeView;
            tabExample.SuspendLayout();
            try
            {
                ShowForm(s);
                tabControlExample.SelectedTab = tabExample;
                s.Select();
            }
            finally
            {
                tabExample.ResumeLayout(true);
            }

            buttonB.Enabled = (s.SelectedNode != null) && (((DemoNode)s.SelectedNode).AbsoluteIndex > 0);
            buttonF.Enabled = (s.SelectedNode != null) && (((DemoNode)s.SelectedNode).AbsoluteIndex < s.GetNodeCount(true) - 1);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (theTree().SelectedNode != null)
            {
                theTree().SelectedNode = ((DemoNode)theTree().SelectedNode).MoveForward();
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            theTree().SelectedNode = ((DemoNode)theTree().SelectedNode).MoveBackward();
        }

        private void tabControlExample_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControlExample.SelectedTab == tabSource)
            {
                SourceFile = CodeFile(theTree().SelectedNode);
                var path = Utils.CodePath();

                buttonConfig.Visible = path == "";

                if ((SourceFile != "") && (path != ""))
                {
                    if (!SourceFile.Equals(OldSourceFile))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        try
                        {
                            var sc = new SourceControl(richTextBox1);
                            sc.LoadTextFromFile(path + SourceFile);
                            //statusBar1.Panels[0].Text = SourceFile;
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                        OldSourceFile = SourceFile;
                    }
                }
            }
            else if (tabControlExample.SelectedTab == tabWeb)
            {
                if ((theTree().SelectedNode != null) && (((DemoFormInfo)theTree().SelectedNode.Tag).formtype != null))
                {
                    OpenWebPage("ABOUT:Loading page from Steema.com ...");
                    //string URLAddress = "http://www.Steema.TeeChart.net/"+((DemoFormInfo)theTree().SelectedNode.Tag).formtype+".htm";
                    var URLAddress = "http://www.teechart.net/support";
                    OpenWebPage(URLAddress);
                }
                else
                {
                    OpenWebPage("ABOUT:All information about TeeChart Pro at <A HREF=" + (char)34 + "http://www.teeChart.net" + (char)34 + ">www.teeChart.net</A>");
                }
            }
        }

        private void buttonConfig_Click(object sender, System.EventArgs e)
        {
            var ds = new DirectorySelect();
            if (ds.ShowDialog() == DialogResult.OK)
            {
                Utils.WriteCodePath(ds.ReturnPath + "\\");
                tabControlExample_SelectedIndexChanged(tabControlExample, new System.EventArgs());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedTab == tabSearch)
            {
                checkBoxFindSource.Enabled = (Utils.CodePath() != "");
                if (!checkBoxFindSource.Enabled)
                {
                    checkBoxFindSource.Checked = false;
                }
            }
            else
            {
                theTree().Select();
                treeView1_AfterSelect(theTree(), new System.Windows.Forms.TreeViewEventArgs(theTree().SelectedNode));
            }
        }

        private void comboBoxSearch_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                DoSearch();
            }
        }

        private void comboBoxSearch_TextChanged(object sender, System.EventArgs e)
        {
            buttonSearch.Enabled = (comboBoxSearch.Text != "");
        }

        private void buttonSearch_Click(object sender, System.EventArgs e)
        {
            DoSearch();
        }

        private void treeView1_BeforeCollapse(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 0;
        }

        private void treeView1_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
            e.Node.SelectedImageIndex = 1;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            timer1.Stop();
            try
            {
            }
            finally
            {
                timer1.Start();
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
#if TEELITE
      tChart2.Header.Text="TeeChart Lite for .NET Examples";
#endif

#if CHINESE
      Languages.ChineseSimp.Activate();
#endif

            theTree().Select();
#if DEBUG
            timer1.Enabled = false;
#endif
        }

        private void ShowFullNode(TreeNode n)
        {
#if DEBUG
            Console.WriteLine(n.Text);
#endif
            n.TreeView.SelectedNode = n;
            n.EnsureVisible();
            Application.DoEvents();
            foreach (TreeNode nn in n.Nodes)
            {
                ShowFullNode(nn);
            }
        }

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            foreach (TreeNode n in theTree().Nodes)
            {
                ShowFullNode(n);
            }
        }

        private void buttonSearch_Click_1(object sender, System.EventArgs e)
        {
            DoSearch();
        }

        private void butGo_Click(object sender, System.EventArgs e)
        {
            var st = tbNodePath.Text.Split(new char[] { '\\' });
            DemoNode n = null;
            var NodeCount = theTree().GetNodeCount(true);
            if (NodeCount > 0)
            {
                n = (DemoNode)theTree().Nodes[0];
            }

            for (var t = 0; t < NodeCount; t++)
            {
                if (n.Text == st[st.Length - 1])
                {
                    theTree().SelectedNode = n;
                }
                else
                {
                    n = (DemoNode)n.MoveForward();
                }
            }

        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void tbNodePath_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                foreach (TreeNode n in theTree().Nodes)
                    ShowFullNode(n);
            }
        }

        //    private CanvasType canvasType;
        //
        //    private void menuGDI_Click(object sender, EventArgs e)
        //    {
        //      canvasType = CanvasType.GDI;
        //    }
        //
        //    private void menuGDIPlus_Click(object sender, EventArgs e)
        //    {
        //      canvasType = CanvasType.GDIPlus;
        //    }
        //
        //    private void menuOpenGL_Click(object sender, EventArgs e)
        //    {
        //      canvasType = CanvasType.OpenGL;
        //    }

        //private void contextMenu1_Popup(object sender, EventArgs e)
        //{
        //  menuGDI.Checked = false;
        //  menuGDIPlus.Checked = false;
        //  menuOpenGL.Checked = false;
        //  switch(canvasType) 
        //  {
        //    case CanvasType.GDI:
        //      menuGDI.Checked = true;
        //      break;
        //    case CanvasType.GDIPlus:
        //      menuGDIPlus.Checked = true;
        //      break;
        //    case CanvasType.OpenGL:
        //      menuOpenGL.Checked = true;
        //      break;
        //  }
        //}
    }

    public enum CanvasType
    {
        GDI,
        GDIPlus,
        OpenGL
    }
}
