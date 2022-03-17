using System.Linq;
using System.Windows;

namespace XamlWPFDemo.Demos
{
    public partial class BindingDataProperties
    {
        public BindingDataProperties()
        {
            InitializeComponent();

            //var internalChart = LogicalTreeHelper.GetChildren(tChart1).OfType<Steema.TeeChart.WPF.TChart>().First();

            //var internalColorGrid = (Steema.TeeChart.Styles.ColorGrid)internalChart[0];
            //internalColorGrid.Pen.Color = System.Drawing.Color.White;
            //internalColorGrid.Pen.Width = 2;
        }
    }
}
