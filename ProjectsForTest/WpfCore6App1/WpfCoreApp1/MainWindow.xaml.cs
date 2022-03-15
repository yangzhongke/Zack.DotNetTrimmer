using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zack.Commons;

namespace WpfCoreApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            
                MessageBox.Show(Assembly.GetExecutingAssembly().Location);
            MessageBox.Show(typeof(MainWindow).Assembly.Location);
            MessageBox.Show(Process.GetCurrentProcess().ProcessName);*/
            MessageBox.Show(Process.GetCurrentProcess().MainModule.FileName);
            using (var mod = ModuleDefMD.Load(Assembly.GetExecutingAssembly().Modules.Single()))
            {
                mod.Write("e:/temp/1.dll");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(HashHelper.ComputeMd5Hash("xxxx"));
        }
    }
}
