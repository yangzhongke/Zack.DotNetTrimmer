using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Steema.TeeChart.Samples
{
  public class SeriesType_Bubble : Samples.BaseForm
  {
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private Steema.TeeChart.Styles.Bubble bubbleSeries1;
    private System.ComponentModel.IContainer components = null;
    private Random random = new Random();

    public SeriesType_Bubble()
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();
			
      bubbleSeries1.Clear();
      for (int t=0; t<100; t++)
        bubbleSeries1.Add(t, random.Next(1000), 1000.0/(20+random.Next(25)));
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.bubbleSeries1 = new Steema.TeeChart.Styles.Bubble();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 63);
			this.textBox1.Text = "Bubbles are represented with a center position and Radius. Each bubble can show a" +
				" different style using the OnGetPointerStyle event.\r\n\r\nOptions include style, pa" +
				"ttern, border, marks, radius, etc.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(466, 33);
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Header
			// 
			this.tChart1.Header.Lines = new string[] {
																								 "Bubble"};
			this.tChart1.Header.Visible = false;
			// 
			// tChart1.Legend
			// 
			this.tChart1.Legend.Visible = false;
			this.tChart1.Location = new System.Drawing.Point(0, 96);
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(234)), ((System.Byte)(234)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Brush.Gradient.Visible = true;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(234)), ((System.Byte)(234)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.tChart1.Panel.Gradient.Visible = true;
			this.tChart1.Series.Add(this.bubbleSeries1);
			this.tChart1.Size = new System.Drawing.Size(466, 190);
			// 
			// tChart1.Zoom
			// 
			this.tChart1.Zoom.Animated = true;
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(13, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(107, 21);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&View Marks";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(96, 7);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(80, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "&Random";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
																									 "Rectangle",
																									 "Circle",
																									 "Triangle",
																									 "DownTriangle",
																									 "Cross",
																									 "DiagCross",
																									 "Star",
																									 "Diamond"});
			this.comboBox1.Location = new System.Drawing.Point(207, 7);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(86, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(167, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "&Style :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button1
			// 
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(307, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(23, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "+";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(336, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(23, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "-";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// bubbleSeries1
			// 
			this.bubbleSeries1.LabelMember = "Labels";
			// 
			// bubbleSeries1.Marks
			// 
			// 
			// bubbleSeries1.Marks.Symbol
			// 
			// 
			// bubbleSeries1.Marks.Symbol.Shadow
			// 
			this.bubbleSeries1.Marks.Symbol.Shadow.Height = 1;
			this.bubbleSeries1.Marks.Symbol.Shadow.Visible = true;
			this.bubbleSeries1.Marks.Symbol.Shadow.Width = 1;
			this.bubbleSeries1.Marks.Transparent = true;
			// 
			// bubbleSeries1.Pointer
			// 
			// 
			// bubbleSeries1.Pointer.Brush
			// 
			this.bubbleSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.bubbleSeries1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
			this.bubbleSeries1.Pointer.HorizSize = 19;
			this.bubbleSeries1.Pointer.InflateMargins = false;
			this.bubbleSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Sphere;
			this.bubbleSeries1.Pointer.VertSize = 19;
			this.bubbleSeries1.Title = "bubble1";
			// 
			// bubbleSeries1.XValues
			// 
			this.bubbleSeries1.XValues.DataMember = "X";
			this.bubbleSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// bubbleSeries1.YValues
			// 
			this.bubbleSeries1.YValues.DataMember = "Y";
      //this.bubbleSeries1.GetPointerStyle += new Steema.TeeChart.Styles.CustomPoint.GetPointerStyleEventHandler(this.bubbleSeries1_GetPointerStyle);
			// 
			// SeriesType_Bubble
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 286);
			this.Name = "SeriesType_Bubble";
			this.Load += new System.EventHandler(this.SeriesType_Bubble_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
    #endregion

    private void SeriesType_Bubble_Load(object sender, System.EventArgs e)
    {
      this.comboBox1.SelectedIndex = (int)Steema.TeeChart.Styles.PointerStyles.Circle;
    }

    private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      bubbleSeries1.Pointer.Style = (Steema.TeeChart.Styles.PointerStyles)this.comboBox1.SelectedIndex;
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
      bubbleSeries1.Marks.Visible = checkBox1.Checked;
    }

    private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
    {
      bubbleSeries1.Repaint();
      comboBox1.Enabled = ! checkBox2.Checked;
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      tChart1.Zoom.ZoomPercent(110);
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      tChart1.Zoom.ZoomPercent(90);
    }


    //private void bubbleSeries1_GetPointerStyle(Steema.TeeChart.Styles.CustomPoint series, Steema.TeeChart.Styles.CustomPoint.GetPointerStyleEventArgs e)
    //{
    //  if (checkBox2.Checked)
    //  {
    //    switch (random.Next(8))
    //    {
    //      case 1: e.Style=Styles.PointerStyles.Circle; break;
    //      case 2: e.Style=Styles.PointerStyles.Diamond; break;
    //      case 3: e.Style=Styles.PointerStyles.Triangle; break;
    //      case 4: e.Style=Styles.PointerStyles.Cross; break;
    //      case 5: e.Style=Styles.PointerStyles.DiagCross; break;
    //      case 6: e.Style=Styles.PointerStyles.DownTriangle; break;
    //      case 7: e.Style=Styles.PointerStyles.Star; break;
    //      default: e.Style=Styles.PointerStyles.Rectangle; break;
    //    }
    //  }
    //}
  }
}

