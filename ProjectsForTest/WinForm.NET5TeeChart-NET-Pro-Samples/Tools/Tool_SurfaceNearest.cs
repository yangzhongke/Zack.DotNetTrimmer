using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Tools;

namespace Steema.TeeChart.Samples {
	public class ToolSurfaceNearest : Steema.TeeChart.Samples.BaseForm {
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Surface surface1;
		private Steema.TeeChart.Tools.SurfaceNearestTool surfaceNearestTool1;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public ToolSurfaceNearest() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			AddSurfacePoints();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSurfaceNearest));
            this.button1 = new System.Windows.Forms.Button();
            this.surface1 = new Steema.TeeChart.Styles.Surface();
            this.surfaceNearestTool1 = new Steema.TeeChart.Tools.SurfaceNearestTool();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.chartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Text = "The SurfaceNearest tool can be used to highlight a surface cell when moving the m" +
                "ouse over a surface series.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 40;
            this.tChart1.Aspect.Elevation = 324;
            this.tChart1.Aspect.ElevationFloat = 324;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Rotation = 353;
            this.tChart1.Aspect.RotationFloat = 353;
            this.tChart1.Aspect.ThemeIndex = 1;
            this.tChart1.Aspect.ZOffset = 0;
            this.tChart1.Aspect.Zoom = 87;
            this.tChart1.Aspect.ZoomFloat = 87;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Centered = true;
            this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.Grid.Style = Drawing.DashStyle.Solid;
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Bold = true;
            this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorGrid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Bottom.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Size = 10;
            this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Depth.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Bold = true;
            this.tChart1.Axes.Left.Labels.Font.Size = 10;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Left.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.Grid.Style = Drawing.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Size = 10;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Right.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Right.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.Grid.Style = Drawing.DashStyle.Solid;
            this.tChart1.Axes.Top.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Size = 10;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Top.MinorTicks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.Black;
            this.tChart1.Axes.Top.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.Gray;
            this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.White;
            this.tChart1.Header.Brush.Gradient.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart1.Header.Font.Size = 10;
            this.tChart1.Header.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Header.Pen.Width = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Shadow.Height = 4;
            this.tChart1.Header.Shadow.Width = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Gradient.Direction = Drawing.LinearGradientMode.Horizontal;
            this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.tChart1.Legend.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            this.tChart1.Legend.DividingLines.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Font.Size = 10;
            this.tChart1.Legend.Font.SizeFloat = 10F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Squared = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.Yellow;
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.White;
            this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
            // 
            // 
            // 
            this.tChart1.Panel.Pen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.Black;
            this.tChart1.Panel.Shadow.Visible = true;
            this.tChart1.Series.Add(this.surface1);
            this.tChart1.Size = new System.Drawing.Size(440, 205);
            this.tChart1.Tools.Add(this.surfaceNearestTool1);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.ApplyDark = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(122)))), ((int)(((byte)(41)))));
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Pen.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Back.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.ApplyDark = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(133)))), ((int)(((byte)(253)))));
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Walls.Left.ApplyDark = false;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(124)))));
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Left.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.ApplyDark = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Pen.Color = System.Drawing.Color.DarkGray;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit Tool...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // surface1
            // 
            // 
            // 
            // 
            this.surface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.surface1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.Silver;
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
            // 
            // 
            // 
            this.surface1.Marks.Font.Size = 10;
            this.surface1.Marks.Font.SizeFloat = 10F;
            this.surface1.Marks.Transparent = true;
            this.surface1.PaletteMin = 0;
            this.surface1.PaletteStep = 0;
            this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            this.surface1.Title = "surface1";
            this.surface1.UseColorRange = false;
            this.surface1.UsePalette = true;
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
            // surfaceNearestTool1
            // 
            this.surfaceNearestTool1.CellColor = System.Drawing.Color.Red;
            this.surfaceNearestTool1.ColumnColor = System.Drawing.Color.Green;
            this.surfaceNearestTool1.RowColor = System.Drawing.Color.Blue;
            this.surfaceNearestTool1.Series = this.surface1;
            this.surfaceNearestTool1.Select += new Steema.TeeChart.Tools.SelectEventHandler(this.surfaceNearestTool1_Select);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(109, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 1;
            // 
            // ToolSurfaceNearest
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 317);
            this.Name = "ToolSurfaceNearest";
            this.panel1.ResumeLayout(false);
            this.chartContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e) {
			TeeChart.Editors.Tools.ToolsEditor.ShowEditor(surfaceNearestTool1);
		}

		private void AddSurfacePoints() {
			const int NumX=50;
			const int NumZ=30;

			for(int x=0; x <= NumX; ++x) {
				for(int z=0; z <= NumZ; ++z) {
					surface1.Add(x,
						Math.Cos(0.14*x)*Math.Cos(0.25*z)+
						0.01*(x-(NumX / 2))*(z-(NumZ / 2)) +
						13*Math.Exp(-0.06*(Math.Pow(x-(NumX / 2),2)+Math.Pow(z-(NumZ / 2),2)))+
						6*Math.Exp(-0.03*(Math.Pow(x-(NumX / 3),2)+Math.Pow(z-3*(NumZ / 5),2)))-1,
						z); 
				}
			}
		}

		private void surfaceNearestTool1_Select(object sender, System.EventArgs e) {
			int tmp;
			double tmpRow, tmpColumn;

			tmp=(sender as SurfaceNearestTool).SelectedCell;

			if(tmp==-1) label1.Text="";
			else {
				(sender as SurfaceNearestTool).GetRowCol(out tmpRow,out tmpColumn);
				label1.Text="Row: "+tmpRow.ToString()+" Column: "+tmpColumn.ToString();
			}
		}
	}
}

