using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public class Export_ODS : BaseForm
  {
    private Button bToFile;
    private Button bOptions;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_ODS));
      this.bOptions = new System.Windows.Forms.Button();
      this.bToFile = new System.Windows.Forms.Button();
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
      this.panel1.Controls.Add(this.bToFile);
      this.panel1.Controls.Add(this.bOptions);
      // 
      // tChart1
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
      // 
      // 
      // 
      this.tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
      this.tChart1.Size = new System.Drawing.Size(440, 205);
      // 
      // bOptions
      // 
      this.bOptions.Location = new System.Drawing.Point(12, 10);
      this.bOptions.Name = "bOptions";
      this.bOptions.Size = new System.Drawing.Size(98, 23);
      this.bOptions.TabIndex = 0;
      this.bOptions.Text = "Export Options...";
#if VS2005
      this.bOptions.UseVisualStyleBackColor = true;
#endif
      this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
      // 
      // bToFile
      // 
      this.bToFile.Location = new System.Drawing.Point(116, 10);
      this.bToFile.Name = "bToFile";
      this.bToFile.Size = new System.Drawing.Size(149, 23);
      this.bToFile.TabIndex = 1;
      this.bToFile.Text = "Export to file and open ...";
#if VS2005
      this.bToFile.UseVisualStyleBackColor = true;
#endif
      this.bToFile.Click += new System.EventHandler(this.bToFile_Click);
      // 
      // Export_ODS
      // 
      this.ClientSize = new System.Drawing.Size(440, 317);
      this.Name = "Export_ODS";
      this.panel1.ResumeLayout(false);
      this.chartContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    public Export_ODS()
    {
      InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      tChart1.Series.Add(typeof(Bar));
      tChart1.Series.Add(typeof(Bar));

      Random rnd = new Random();

      tChart1[0].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());
      tChart1[0].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());
      tChart1[0].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());
      tChart1[0].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());
      tChart1[0].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());

      tChart1[1].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());
      tChart1[1].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());
      tChart1[1].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());
      tChart1[1].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());
      tChart1[1].Add(rnd.NextDouble() * 100, Convert.ToChar(64 + rnd.Next(27)).ToString());

#if VS2005
      tChart1.Export.Data.OpenDocument.IncludeHeader = true;
      tChart1.Export.Data.OpenDocument.IncludeIndex = true;
      tChart1.Export.Data.OpenDocument.IncludeLabels = true;
      tChart1.Export.Data.OpenDocument.IncludeSeriesTitle = true;
      tChart1.Export.Data.OpenDocument.IndexFieldName = "BarIndex";
#endif
    }

    private void bOptions_Click(object sender, EventArgs e)
    {
#if VS2005
      Steema.TeeChart.Editors.Export.ExportEditor.ShowModal(tChart1, tChart1.Export.Data.OpenDocument);
#else
      Steema.TeeChart.UtilsWF.ErrorMessage("This functionality is only available in .NET 2.0 and above");      
#endif
    }

    private void bToFile_Click(object sender, EventArgs e)
    {
#if VS2005
      string path = Environment.GetEnvironmentVariable("TEMP") + "\\teechartdata.ods";
      tChart1.Export.Data.OpenDocument.Save(path);
      System.Diagnostics.Process.Start(path);
#else
      Steema.TeeChart.UtilsWF.ErrorMessage("This functionality is only available in .NET 2.0 and above");
#endif
    }
  }
}

