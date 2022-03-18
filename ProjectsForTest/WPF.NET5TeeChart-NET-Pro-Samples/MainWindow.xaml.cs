using System.Linq;
using System.Windows;
using TeeChart.Xaml.WPF;

namespace WPF_XAMLTeeChart
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      //SetChart();
    }

    private void SetChart()
    {
      Steema.TeeChart.WPF.TChart innerChart = LogicalTreeHelper.GetChildren(tChart1).OfType<Steema.TeeChart.WPF.TChart>().FirstOrDefault();
      innerChart.Zoom.Direction = Steema.TeeChart.ZoomDirections.Horizontal;
    }
  }
}
