using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Steema.TeeChart.Samples
{
	public class ContourFoot : Steema.TeeChart.Samples.BaseForm
	{
		
		private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private Steema.TeeChart.Styles.Custom3DGrid series;
		private Color[] ColorPalette;

        // Parameters for binary data
        private const int BIGPADWIDTH = 64;
        private const int BIGPADLENGTH = 96;
        private byte[,] FootScanArray;

		public ContourFoot()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			ColorPalette = new Color[] {Color.FromArgb(0x00,0x00,0x00),
				Color.FromArgb(0xFF,0x00,0x00),
				Color.FromArgb(0xFF,0x80,0x00),
				Color.FromArgb(0xFF,0xC0,0x00),
				Color.FromArgb(0xFF,0xFF,0x00),
				Color.FromArgb(0xC0,0xFF,0x00),
				Color.FromArgb(0x80,0xFF,0x00),
				Color.FromArgb(0x00,0xFF,0x00),
				Color.FromArgb(0x00,0xFF,0x80),
				Color.FromArgb(0x00,0xFF,0xFF),
				Color.FromArgb(0x00,0xDF,0xFF),
				Color.FromArgb(0x00,0xC0,0xFF),
				Color.FromArgb(0x00,0xA0,0xFF),
				Color.FromArgb(0x00,0x80,0xFF),
				Color.FromArgb(0x00,0x60,0xFF),
				Color.FromArgb(0x00,0x00,0xFF)};

			FootScanArray = new byte[BIGPADLENGTH,BIGPADWIDTH];
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Text = "This example demonstrates alternative way to load data from binary file\r\nand disp" +
				"lay it in a Contour or ColorGrid series.\r\nThis example was kindly provided by Le" +
				"e Grissom.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Name = "panel1";
			// 
			// tChart1
			// 
			// 
			// tChart1.Aspect
			// 
			
			
			this.tChart1.Aspect.View3D = false;
			// 
			// tChart1.Axes
			// 
			// 
			// tChart1.Axes.Bottom
			// 
			// 
			// tChart1.Axes.Bottom.Grid
			// 
			this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
			this.tChart1.Axes.Bottom.Grid.Visible = false;
			// 
			// tChart1.Axes.Bottom.Labels
			// 
			// 
			// tChart1.Axes.Bottom.Labels.Font
			// 
			this.tChart1.Axes.Bottom.Labels.Font.Bold = true;
			this.tChart1.Axes.Bottom.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Bottom.MinorGrid
			// 
			this.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(((System.Byte)(229)), ((System.Byte)(229)), ((System.Byte)(229)));
			// 
			// tChart1.Axes.Bottom.MinorTicks
			// 
			this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Bottom.Ticks
			// 
			this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.Ticks.Length = 0;
			// 
			// tChart1.Axes.Bottom.TicksInner
			// 
			this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Bottom.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Depth
			// 
			// 
			// tChart1.Axes.Depth.Grid
			// 
			this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Depth.Labels
			// 
			// 
			// tChart1.Axes.Depth.Labels.Font
			// 
			this.tChart1.Axes.Depth.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Depth.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Depth.MinorTicks
			// 
			this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Depth.Ticks
			// 
			this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.Ticks.Length = 0;
			// 
			// tChart1.Axes.Depth.TicksInner
			// 
			this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Depth.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Left
			// 
			this.tChart1.Axes.Left.Automatic = false;
			this.tChart1.Axes.Left.AutomaticMaximum = false;
			this.tChart1.Axes.Left.AutomaticMinimum = false;
			// 
			// tChart1.Axes.Left.Grid
			// 
			this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Left.Labels
			// 
			// 
			// tChart1.Axes.Left.Labels.Font
			// 
			this.tChart1.Axes.Left.Labels.Font.Bold = true;
			this.tChart1.Axes.Left.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Left.Labels.Font.Size = 10;
			this.tChart1.Axes.Left.Maximum = 90;
			this.tChart1.Axes.Left.Minimum = 0;
			// 
			// tChart1.Axes.Left.MinorTicks
			// 
			this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Left.Ticks
			// 
			this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.Ticks.Length = 0;
			// 
			// tChart1.Axes.Left.TicksInner
			// 
			this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Left.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Right
			// 
			// 
			// tChart1.Axes.Right.Grid
			// 
			this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
			// 
			// tChart1.Axes.Right.Labels
			// 
			// 
			// tChart1.Axes.Right.Labels.Font
			// 
			this.tChart1.Axes.Right.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Right.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Right.MinorTicks
			// 
			this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Right.Ticks
			// 
			this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.Ticks.Length = 0;
			// 
			// tChart1.Axes.Right.TicksInner
			// 
			this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Right.TicksInner.Length = 6;
			// 
			// tChart1.Axes.Top
			// 
			// 
			// tChart1.Axes.Top.Grid
			// 
			this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
			this.tChart1.Axes.Top.Grid.Visible = false;
			// 
			// tChart1.Axes.Top.Labels
			// 
			// 
			// tChart1.Axes.Top.Labels.Font
			// 
			this.tChart1.Axes.Top.Labels.Font.Name = "Lucida Console";
			this.tChart1.Axes.Top.Labels.Font.Size = 10;
			// 
			// tChart1.Axes.Top.MinorTicks
			// 
			this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.MinorTicks.Length = -3;
			// 
			// tChart1.Axes.Top.Ticks
			// 
			this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.Ticks.Length = 0;
			// 
			// tChart1.Axes.Top.TicksInner
			// 
			this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black;
			this.tChart1.Axes.Top.TicksInner.Length = 6;
			// 
			// tChart1.Header
			// 
			// 
			// tChart1.Header.Brush
			// 
			this.tChart1.Header.Brush.Color = System.Drawing.Color.Black;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Black;
			this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(64)));
			this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Brush.Gradient.UseMiddle = true;
			this.tChart1.Header.Brush.Gradient.Visible = true;
			// 
			// tChart1.Header.Font
			// 
			this.tChart1.Header.Font.Bold = true;
			// 
			// tChart1.Header.Font.Brush
			// 
			this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Header.Font.Name = "Lucida Console";
			this.tChart1.Header.Font.Size = 10;
			// 
			// tChart1.Header.Gradient
			// 
			this.tChart1.Header.Gradient.EndColor = System.Drawing.Color.Black;
			this.tChart1.Header.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(64)));
			this.tChart1.Header.Gradient.StartColor = System.Drawing.Color.Gray;
			this.tChart1.Header.Gradient.UseMiddle = true;
			this.tChart1.Header.Gradient.Visible = true;
			this.tChart1.Header.Lines = new string[] {
																								 "tChart1"};
			// 
			// tChart1.Header.Pen
			// 
			this.tChart1.Header.Pen.Color = System.Drawing.Color.FromArgb(((System.Byte)(153)), ((System.Byte)(221)), ((System.Byte)(251)));
			this.tChart1.Header.Pen.Width = 2;
			// 
			// tChart1.Header.Shadow
			// 
			// 
			// tChart1.Header.Shadow.Brush
			// 
			this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(169)), ((System.Byte)(169)), ((System.Byte)(169)));
			this.tChart1.Header.Shadow.Height = 4;
			this.tChart1.Header.Shadow.Width = 4;
			// 
			// tChart1.Legend
			// 
			// 
			// tChart1.Legend.Brush
			// 
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Legend.DividingLines
			// 
			this.tChart1.Legend.DividingLines.Color = System.Drawing.Color.Silver;
			// 
			// tChart1.Legend.Font
			// 
			// 
			// tChart1.Legend.Font.Brush
			// 
			this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(100)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.tChart1.Legend.Font.Name = "Lucida Console";
			this.tChart1.Legend.Font.Size = 9;
			// 
			// tChart1.Legend.Gradient
			// 
			this.tChart1.Legend.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Legend.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Legend.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Legend.Shadow
			// 
			// 
			// tChart1.Legend.Shadow.Brush
			// 
			this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
			// 
			// tChart1.Legend.Symbol
			// 
			this.tChart1.Legend.Symbol.Squared = true;
			this.tChart1.Legend.Transparent = true;
			this.tChart1.Name = "tChart1";
			// 
			// tChart1.Panel
			// 
			// 
			// tChart1.Panel.Bevel
			// 
			this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			// 
			// tChart1.Panel.Brush
			// 
			this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(196)), ((System.Byte)(196)));
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Gradient
			// 
			this.tChart1.Panel.Gradient.EndColor = System.Drawing.Color.Yellow;
			this.tChart1.Panel.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Panel.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Panel.Pen
			// 
			this.tChart1.Panel.Pen.Visible = true;
			// 
			// tChart1.Panel.Shadow
			// 
			// 
			// tChart1.Panel.Shadow.Brush
			// 
			this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
			this.tChart1.Panel.Shadow.Height = 0;
			this.tChart1.Panel.Shadow.Visible = true;
			this.tChart1.Panel.Shadow.Width = 0;
			// 
			// tChart1.Walls
			// 
			// 
			// tChart1.Walls.Back
			// 
			// 
			// tChart1.Walls.Back.Brush
			// 
			this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(122)), ((System.Byte)(41)));
			this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White;
			// 
			// tChart1.Walls.Back.Gradient
			// 
			this.tChart1.Walls.Back.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(122)), ((System.Byte)(41)));
			this.tChart1.Walls.Back.Gradient.MiddleColor = System.Drawing.Color.Empty;
			this.tChart1.Walls.Back.Gradient.StartColor = System.Drawing.Color.White;
			this.tChart1.Walls.Back.Transparent = false;
			// 
			// tChart1.Walls.Bottom
			// 
			// 
			// tChart1.Walls.Bottom.Brush
			// 
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(254)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(47)), ((System.Byte)(133)), ((System.Byte)(253)));
			// 
			// tChart1.Walls.Bottom.Gradient
			// 
			this.tChart1.Walls.Bottom.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(254)), ((System.Byte)(253)));
			this.tChart1.Walls.Bottom.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(47)), ((System.Byte)(133)), ((System.Byte)(253)));
			// 
			// tChart1.Walls.Left
			// 
			// 
			// tChart1.Walls.Left.Brush
			// 
			this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.White;
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(36)), ((System.Byte)(209)), ((System.Byte)(252)));
			this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(13)), ((System.Byte)(188)), ((System.Byte)(124)));
			// 
			// tChart1.Walls.Left.Gradient
			// 
			this.tChart1.Walls.Left.Gradient.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(36)), ((System.Byte)(209)), ((System.Byte)(252)));
			this.tChart1.Walls.Left.Gradient.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(13)), ((System.Byte)(188)), ((System.Byte)(124)));
			// 
			// tChart1.Walls.Right
			// 
			// 
			// tChart1.Walls.Right.Brush
			// 
			this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.White;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(8, -1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Show as:";
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Location = new System.Drawing.Point(142, 13);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(114, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "ColorGrid Series";
			this.radioButton2.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Location = new System.Drawing.Point(16, 13);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Contour Series";
			this.radioButton1.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// ContourFoot
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 317);
			this.Name = "ContourFoot";
			this.Load += new System.EventHandler(this.Contour_Foot_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void LoadData(string FileName) {
			string path = Application.StartupPath + @"\..\..\";
			path = path + FileName;

			if(File.Exists(path))	{ 
				FileStream fs = File.OpenRead(path);
				BinaryReader bin = new BinaryReader(fs);
				for(int len=0; len<BIGPADLENGTH; ++len) {
					for(int wid=0; wid<BIGPADWIDTH; ++wid) {
						FootScanArray[len, wid] = bin.ReadByte();
					}
				}
				bin.Close();
				fs.Close();
			}			
		}

		private void AddDataToSeries(Steema.TeeChart.Styles.Custom3DGrid ASeries) {	
			ASeries.Clear();
			for(int len=0; len<BIGPADLENGTH; ++len) {
				for(int wid=0; wid<BIGPADWIDTH; ++wid) {
					ASeries.Add(wid+1, Convert.ToDouble(FootScanArray[len, wid]), len+1);
				}
			}
		}

        private void InitSeries(Steema.TeeChart.Styles.Custom3DGrid ASeries)
        {

            if (ASeries is Styles.Contour)
            {
                (ASeries as Styles.Contour).NumLevels = ColorPalette.Length;
                (ASeries as Styles.Contour).CreateAutoLevels();
                (ASeries as Styles.Contour).AutomaticLevels = false;
                for (int i = 0; i < ColorPalette.Length; i++)
                {
                    (ASeries as Styles.Contour).Levels[i].UpToValue = i + 0.5;
                    (ASeries as Styles.Contour).Levels[i].Color = ColorPalette[i];
                }
            }
            ASeries.ColorEach = false;
            ASeries.UsePalette = true;
            ASeries.UseColorRange = false;
            ASeries.ClearPalette();
            for (int i = 0; i < ColorPalette.Length; i++)
                ASeries.AddPalette(i + 0.5, ColorPalette[i]);

            ASeries.Repaint();
        }

		private void Contour_Foot_Load(object sender, System.EventArgs e) {
			LoadData("FootData.bin");

			radioButton_Click(null, null);
		}


		private void radioButton_Click(object sender, System.EventArgs e) {
			tChart1.Series.RemoveAllSeries();
			if(radioButton1.Checked) 
            {
				series = new Steema.TeeChart.Styles.Contour(tChart1.Chart);
                (series as Styles.Contour).DrawingAlgorithm = Steema.TeeChart.Styles.ContourConstruction.Fast;
			}
			else if(radioButton2.Checked) {
				series = new Steema.TeeChart.Styles.ColorGrid(tChart1.Chart);
			}
			AddDataToSeries(series);
			InitSeries(series);

		}
	}
}

