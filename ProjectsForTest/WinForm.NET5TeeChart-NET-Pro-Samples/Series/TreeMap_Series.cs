using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Editors;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public class TreeMap_Series : BaseForm
  {
    private Button bEdit;
    private ComboBox cbStyle;
    private Label label1;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeMap_Series));
      this.bEdit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.cbStyle = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Size = new System.Drawing.Size(414, 73);
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cbStyle);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.bEdit);
      this.panel1.Size = new System.Drawing.Size(414, 39);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Bottom.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Bottom.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Bottom.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Depth.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Depth.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.DepthTop.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.DepthTop.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Left.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Left.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Left.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Right.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Right.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Right.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Labels.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Top.Labels.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Top.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Axes.Top.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Footer.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Footer.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Header.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Header.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Legend.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Legend.Title.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Legend.Title.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Panel.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Panel.Bevel.StringColorTwo = "FF808080";
      this.tChart1.Size = new System.Drawing.Size(414, 257);
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubFooter.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.SubFooter.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.SubHeader.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.SubHeader.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Back.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Back.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Bottom.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Bottom.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Left.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Left.Bevel.StringColorTwo = "FF808080";
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Walls.Right.Bevel.StringColorOne = "FFFFFFFF";
      this.tChart1.Walls.Right.Bevel.StringColorTwo = "FF808080";
      // 
      // chartContainer
      // 
      this.chartContainer.Size = new System.Drawing.Size(414, 257);
      // 
      // bEdit
      // 
      this.bEdit.Location = new System.Drawing.Point(12, 10);
      this.bEdit.Name = "bEdit";
      this.bEdit.Size = new System.Drawing.Size(75, 23);
      this.bEdit.TabIndex = 0;
      this.bEdit.Text = "Edit...";
#if VS2005
      this.bEdit.UseVisualStyleBackColor = true;
#endif
      this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(115, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Tiling Style:";
      // 
      // cbStyle
      // 
#if VS2005
      this.cbStyle.FormattingEnabled = true;
#endif
      this.cbStyle.Items.AddRange(new object[] {
            "Slice & Dice",
            "Strip"});
      this.cbStyle.Location = new System.Drawing.Point(182, 12);
      this.cbStyle.Name = "cbStyle";
      this.cbStyle.Size = new System.Drawing.Size(121, 21);
      this.cbStyle.TabIndex = 2;
      this.cbStyle.Text = "Slice & dice";
      this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
      // 
      // TreeMap_Series
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(414, 369);
      this.Name = "TreeMap_Series";
      this.Text = "TreeMap_Series";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TreeMap treeMap;

    public TreeMap_Series()
    {
      InitializeComponent();

      tChart1.Aspect.View3D = false;
      treeMap = new TreeMap(tChart1.Chart);
      treeMap.FillSampleValues();
    }

    private void bEdit_Click(object sender, EventArgs e)
    {
      Steema.TeeChart.Editors.Series.TreeMapEditor s = new Steema.TeeChart.Editors.Series.TreeMapEditor(treeMap);
      Steema.TeeChart.Editors.EditorUtils.Translate(s);
      EditorUtils.ShowFormModal(s);
    }

    private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
      treeMap.MapStyle = (TreeMapTiling)cbStyle.SelectedIndex;
    }
  }
}
