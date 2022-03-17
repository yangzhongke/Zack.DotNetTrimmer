using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;
using System.IO;

namespace Steema.TeeChart.Samples
{
  public class CompactCharts : BaseForm
  {
    private Button button1;
    private Label label2;
    private Label label1;
    private NumericUpDown udWidth;
    private NumericUpDown udHeight;
    private FolderBrowserDialog folderBrowserDialog1;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompactCharts));
      this.button1 = new System.Windows.Forms.Button();
      this.udHeight = new System.Windows.Forms.NumericUpDown();
      this.udWidth = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.panel1.SuspendLayout();
      this.chartContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.udHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.udWidth);
      this.panel1.Controls.Add(this.udHeight);
      this.panel1.Controls.Add(this.button1);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      this.tChart1.Aspect.ZOffset = 0;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(12, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(199, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Create and Open CompactChart...";
#if VS2005
      this.button1.UseVisualStyleBackColor = true;
#endif
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // udHeight
      // 
      this.udHeight.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.udHeight.Location = new System.Drawing.Point(370, 13);
      this.udHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.udHeight.Name = "udHeight";
      this.udHeight.Size = new System.Drawing.Size(47, 20);
      this.udHeight.TabIndex = 1;
      // 
      // udWidth
      // 
      this.udWidth.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.udWidth.Location = new System.Drawing.Point(270, 13);
      this.udWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.udWidth.Name = "udWidth";
      this.udWidth.Size = new System.Drawing.Size(47, 20);
      this.udWidth.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(226, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Width:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(323, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Height:";
      // 
      // CompactCharts
      // 
#if VS2005
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "CompactCharts";
      this.Text = "CompactCharts";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.chartContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.udHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public CompactCharts()
    {
      InitializeComponent();
      udWidth.Value = 250;
      udHeight.Value = 150;
      InitializeChart();
    }

    private void InitializeChart()
    {
      tChart1.Aspect.View3D = false;
      tChart1.Legend.Visible = false;
      tChart1.Header.Font.Color = Color.FromArgb(154, 154, 154);
      tChart1.Header.Text = "Euribor";
      tChart1.Panel.Bevel.Inner = BevelStyles.None;
      tChart1.Panel.Bevel.Outer = BevelStyles.None;
      tChart1.Panel.Color = Color.White;
      tChart1.Panel.Gradient.Visible = false;
      tChart1.Axes.Left.AxisPen.Color = Color.FromArgb(120, 60, 20);
      tChart1.Axes.Left.AxisPen.Width = 4;
      tChart1.Axes.Left.MinorTicks.Visible = false;
      tChart1.Axes.Left.Grid.Color = Color.FromArgb(245, 225, 170);
      tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
      tChart1.Axes.Bottom.AxisPen.Color = Color.FromArgb(120, 60, 20);
      tChart1.Axes.Bottom.Grid.Visible = false;
      tChart1.Axes.Bottom.MinorTicks.Visible = false;
      tChart1.Axes.Bottom.AxisPen.Width = 4;
      tChart1.Walls.Back.Pen.Visible = false;
      tChart1.Walls.Back.Gradient.Visible = false;
      tChart1.Walls.Back.Color = Color.White;

      Steema.TeeChart.Styles.Line series1 = new Steema.TeeChart.Styles.Line(tChart1.Chart);
      series1.Color = Color.FromArgb(128, 128, 128);
      series1.Pointer.Style = PointerStyles.Circle;
      series1.Pointer.Visible = true;

      series1.Add(5.323, "08-Aug");
      series1.Add(5.384, "08-Sep");
      series1.Add(5.248, "08-Oct");
      series1.Add(4.350, "08-Nov");
      series1.Add(3.452, "08-Dec");
      series1.Add(2.622, "09-Jan");
      series1.Add(2.135, "09-Feb");

      Steema.TeeChart.Tools.SeriesRegionTool region = new Steema.TeeChart.Tools.SeriesRegionTool(tChart1.Chart);
      region.Color = Color.FromArgb(225, 225, 255);
      region.Transparency = 50;
      region.Series = series1;

      Steema.TeeChart.Tools.MarksTip markstip = new MarksTip(tChart1.Chart);
      markstip.Series = series1;
#if VS2005
      markstip.BackColor = Color.White;
#endif
      markstip.Style = MarksStyles.Value;
      

      Steema.TeeChart.Animations.Expand expand;
      tChart1.Animations.Add(expand = new Steema.TeeChart.Animations.Expand());
      expand.Target = ChartClickedPartStyle.SeriesPointer;
      expand.Trigger = Steema.TeeChart.Animations.AnimationTrigger.MouseOver;
    }

    private void CompileAndShow()
    {
      string tmpPath = Steema.TeeChart.UtilsWF.Registry_GetValue(Steema.TeeChart.Utils.TeeChartKeyName, "FlexCanvas_Temp", "").ToString();
      if (Steema.TeeChart.Utils.IsNullOrEmpty(tmpPath) || !Directory.Exists(tmpPath))
      {
        tmpPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        Steema.TeeChart.UtilsWF.Registry_SetValue(Steema.TeeChart.Utils.TeeChartKeyName, "FlexCanvas_Temp", tmpPath);
      }
      Steema.TeeChart.Export.FlexOptions.CompileDeleteShow(tChart1, (int)udWidth.Value, 
        (int)udHeight.Value, tmpPath, false, true, true);
    }


    private bool RecursiveChooseFolder()
    {
      bool result = false;
      folderBrowserDialog1.Description = "Adobe Flex 3 SDK folder";
      folderBrowserDialog1.ShowNewFolderButton = false;

      switch (folderBrowserDialog1.ShowDialog())
      {
        case DialogResult.Cancel:
          result = true;
          break;
        case DialogResult.OK:
          if (File.Exists(folderBrowserDialog1.SelectedPath + "\\bin\\mxmlc.exe"))
          {
            Steema.TeeChart.UtilsWF.Registry_SetValue(Steema.TeeChart.Utils.TeeChartKeyName, "FlexCanvas_Compiler", folderBrowserDialog1.SelectedPath + "\\bin");
            result = true;
          }
          break;
      }
      return result;
    }


    private bool TryCompileAndShow()
    {
      bool result = false;

      string mxmlc = (string)Steema.TeeChart.UtilsWF.Registry_GetValue(Steema.TeeChart.Utils.TeeChartKeyName, "FlexCanvas_Compiler", "");
      mxmlc += "\\mxmlc.exe";
      if (File.Exists(mxmlc))
      {
        result = true;
        CompileAndShow();
      }
      return result;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!TryCompileAndShow())
      {
        if (Steema.TeeChart.UtilsWF.YesNo("For this demonstration to work, you need the Adobe Flex 4 SDK"
          + Environment.NewLine + "installed on your machine" + Environment.NewLine + Environment.NewLine +
          "If you have the Flex SDK installed on your machine, please click yes to select the folder."
          + Environment.NewLine + Environment.NewLine + "Otherwise click no to be taken to the download location."
          ))
        {
          bool canCompile = false;

          while (!canCompile) 
          {
            canCompile = RecursiveChooseFolder();
            if (canCompile)
            {
              TryCompileAndShow();
            }
          }
        }
        else
        {
          System.Diagnostics.Process.Start("http://www.adobe.com/devnet/flex/flex-sdk-download.html");
        }
      }
    }
  }
}
