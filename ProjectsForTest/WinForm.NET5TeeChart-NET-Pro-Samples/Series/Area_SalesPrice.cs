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
    public class Area_SalesPrice : Steema.TeeChart.Samples.BaseForm
    {        
        public Area_SalesPrice()
        {
            InitializeComponent();
						InitializeChart();
				}

				private string[] console = {"Wii", "PS3", "X360", "PSP", "DS"};
				private int[] units = {217235, 162239, 101889, 161156, 609136};
				private double[] price = { 249, 299, 249, 169, 149 };
				private Steema.TeeChart.Styles.Area area1;				

				private void InitializeChart()
				{
					area1.Stairs = true;
					area1.ColorEach = true;
					area1.Marks.Visible = true;
					area1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;
					area1.Marks.Transparent = true;
					area1.Marks.Font.Bold = true;

					area1.GetSeriesMark += new Steema.TeeChart.Styles.Series.GetSeriesMarkEventHandler(area1_GetSeriesMark);

					FillSeries();

					tChart1.Aspect.View3D = false;
					tChart1.Legend.Visible = false;

					tChart1.Header.Visible = true;
					tChart1.Header.Text = "Gaming consoles sales 1st half 2009 in Spain";
					tChart1.Header.Font.Size = 10;

					tChart1.Axes.Left.Title.Text = "Price (€)";
					tChart1.Axes.Left.Title.Font.Bold = true;
					tChart1.Axes.Left.SetMinMax(0, 350);
					tChart1.Axes.Left.Increment = 50;

					tChart1.Axes.Bottom.Grid.Visible = false;					

					AddCustomLabels();
					//AddDataTable();

					tChart1.AfterDraw += new PaintChartEventHandler(tChart1_AfterDraw);
					tChart1.Zoomed += new EventHandler(tChart1_Zoomed);
					tChart1.UndoneZoom += new EventHandler(tChart1_UndoneZoom);

					this.Resize += new EventHandler(Area_SalesPrice_Resize);
				}

				void tChart1_UndoneZoom(object sender, EventArgs e)
				{
					tChart1.Draw(); //Necessary so that marks have valid positions
				}

				void tChart1_Zoomed(object sender, EventArgs e)
				{
					tChart1.Draw(); //Necessary so that marks have valid positions
				}

				void Area_SalesPrice_Resize(object sender, EventArgs e)
				{
					tChart1.Draw(); //Necessary so that marks have valid positions
				}

				void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
				{
					SetCustomMarksPosition();
					SetupAnnotations();
				}

				private Steema.TeeChart.Tools.Annotation annotation1;
				private Steema.TeeChart.Tools.Annotation annotation2;

				private void SetupAnnotations()
				{
					int tmp = area1.CalcXPos(area1.Count - 2) + 
										((area1.CalcXPos(area1.Count - 1) - area1.CalcXPos(area1.Count - 2)) / 2);
					Rectangle chartRect = tChart1.Chart.ChartRect;

					if (annotation1 == null)
					{
						annotation1 = new Steema.TeeChart.Tools.Annotation(tChart1.Chart); 
					}
					annotation1.Text = "Total = " + area1.MaxXValue().ToString() + " consoles sold";
					annotation1.Shape.Font.Bold = true;
					annotation1.Shape.Transparent = true;
					annotation1.Shape.CustomPosition = true;
					annotation1.Shape.Left = tmp - 80;
					annotation1.Shape.Top = chartRect.Top + 20;

					if (annotation2 == null)
					{
						annotation2 = new Steema.TeeChart.Tools.Annotation(tChart1.Chart);
					}
					annotation2.Text = "Average price " + average.MaxYValue().ToString() + " €";
					annotation2.Shape.Font.Bold = true;
					annotation2.Shape.Font.Color = Color.Red;
					annotation2.Shape.Transparent = true;
					annotation2.Shape.CustomPosition = true;
					annotation2.Shape.Left = tmp;
					annotation2.Shape.Top = average.CalcYPos(0) - 15;
				}

				private void SetCustomMarksPosition()
				{
					for (int i = 0; i < area1.Marks.Positions.Count; i++)
					{
						double tmp = area1.XValues[i] + ((area1.XValues[i + 1] - area1.XValues[i]) / 2);
						area1.Marks.Positions[i].Custom = true;
						area1.Marks.Positions[i].LeftTop.X = tChart1.Axes.Bottom.CalcXPosValue(tmp) -
																									(area1.Marks.Positions[i].Width / 2);
						area1.Marks.Positions[i].LeftTop.Y = area1.CalcYPos(i) - 25;
					}

					area1.Marks.Arrow.Visible = false;
					area1.Repaint();
				}

				void area1_GetSeriesMark(Steema.TeeChart.Styles.Series series, Steema.TeeChart.Styles.GetSeriesMarkEventArgs e)
				{
					e.MarkText = e.ValueIndex < area1.Count - 1 ? e.MarkText + " €" : ""; //"Dummy" point mark removed
				}

				private void AddDataTable()
				{
					Steema.TeeChart.Tools.DataTableTool dataTable = new Steema.TeeChart.Tools.DataTableTool(tChart1.Chart);

					dataTable.RowPen.Visible = false;
					dataTable.ColumnPen.Visible = false;
					dataTable.TableLegend.Symbol.Visible = false;
					dataTable.TableLegend.Font.Bold = true;

					dataTable.FilterSeries += new Steema.TeeChart.Tools.DataTableFilterSeriesEventHandler(dataTable_FilterSeries);

					//Add series to display customized data in the DataTable tool
					//They are not visible because they are out of the range of the left axis
					Steema.TeeChart.Styles.FastLine salesSeries = new Steema.TeeChart.Styles.FastLine(tChart1.Chart);
					salesSeries.Title = "Sales (in €)";

					Steema.TeeChart.Styles.FastLine unitsSeries = new Steema.TeeChart.Styles.FastLine(tChart1.Chart);
					unitsSeries.Title = "Units sold";

					for (int i = 1; i < area1.Count; i++)
					{
						double tmp = area1.XValues[i] - area1.XValues[i - 1];
						salesSeries.Add(area1.XValues[i], tmp * price[i - 1]);
						unitsSeries.Add(area1.XValues[i], tmp);
					}

					area1.Title = "";
					average.Title = "";
				}

				void dataTable_FilterSeries(Steema.TeeChart.Tools.DataTableTool sender, Steema.TeeChart.Tools.DataTableFilterSeriesEventArgs e)
				{
					if (tChart1.Series.IndexOf(e.Series) < 2)
					{
						e.Accept = false;
					}
				}

				private void AddCustomLabels()
				{
					tChart1.Axes.Bottom.Labels.Items.Clear();

					for (int i = 0; i < area1.Count - 1; i++)
					{
						double value = area1.XValues[i] + ((area1.XValues[i + 1] - area1.XValues[i]) / 2);
						(tChart1.Axes.Bottom.Labels.Items.Add(value, console[i])).Font.Bold = true;
					}
				}

				private Steema.TeeChart.Styles.Line average;

				private void FillSeries()
				{
					double tmp = 0;

					for (int i = 0; i < console.Length; i++)
					{
						area1.Add(tmp, price[i], console[i]);
						tmp += units[i];
					}

					average = new Steema.TeeChart.Styles.Line(tChart1.Chart);
					average.Color = Color.Black;
					average.Function = new Steema.TeeChart.Functions.Average();
					average.DataSource = area1;

					//A "dummy" point is necessary to plot last area
					area1.Add(tmp, price[price.Length - 1]);
					average.XValues[average.Count - 1] = tmp;
				}

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
					System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_SalesPrice));
					this.area1 = new Steema.TeeChart.Styles.Area();
					this.chartContainer.SuspendLayout();
					this.SuspendLayout();
					// 
					// textBox1
					// 
					this.textBox1.Text = resources.GetString("textBox1.Text");
					// 
					// panel1
					// 
					this.panel1.Size = new System.Drawing.Size(440, 10);
					// 
					// tChart1
					// 
					// 
					// 
					// 
					this.tChart1.Aspect.ZOffset = 0;
					this.tChart1.Series.Add(this.area1);
					this.tChart1.Size = new System.Drawing.Size(440, 234);
					// 
					// chartContainer
					// 
					this.chartContainer.Location = new System.Drawing.Point(0, 83);
					this.chartContainer.Size = new System.Drawing.Size(440, 234);
					// 
					// area1
					// 
					// 
					// 
					// 
					this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
					// 
					// 
					// 
					this.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
					// 
					// 
					// 
					this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
					// 
					// 
					// 
					this.area1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
					this.area1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
					this.area1.ColorEach = false;
					// 
					// 
					// 
					this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
					// 
					// 
					// 
					// 
					// 
					// 
					this.area1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
					this.area1.Marks.Callout.ArrowHeadSize = 8;
					// 
					// 
					// 
					this.area1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
					this.area1.Marks.Callout.Distance = 0;
					this.area1.Marks.Callout.Draw3D = false;
					this.area1.Marks.Callout.Length = 10;
					this.area1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
					this.area1.Marks.Callout.Visible = false;
					// 
					// 
					// 
					this.area1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
					this.area1.Title = "area1";
					// 
					// 
					// 
					this.area1.XValues.DataMember = "X";
					this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
					// 
					// 
					// 
					this.area1.YValues.DataMember = "Y";
					// 
					// Area_SalesPrice
					// 
					this.ClientSize = new System.Drawing.Size(440, 317);
					this.Name = "Area_SalesPrice";
					this.chartContainer.ResumeLayout(false);
					this.ResumeLayout(false);
					this.PerformLayout();

        }

        #endregion


		}
}

