using System;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using TeeChart.Xaml.WPF.Series;

namespace XamlWPFDemo.Demos
{
    public class BindingDataPropertiesViewModel : ViewModelBase
    {
        private const int Height = 20;
        private const int Amount = 100;

        private double _offset;

        private readonly DispatcherTimer _timer;

        public Series3DData[] Data { get; }

        public BindingDataPropertiesViewModel()
        {
            Data = new Series3DData[Amount];

            int i = 0;
            for (int x = 0; x < 10; x++)
            {
                for (int z = 0; z < 10; z++)
                {
                    Data[i] = new Series3DData { X = x, Y = Math.Sin(i / (double)Amount * Math.PI * 2) * Height, Z = z };
                    i++;
                }
            }

            _timer = new DispatcherTimer(DispatcherPriority.Normal) { Interval = TimeSpan.FromSeconds(0.05) };
            _timer.Tick += OnTick;
            _timer.Start();
        }

        private void OnTick(object sender, EventArgs eventArgs)
        {
            _offset += 2;
            for (var i = 0; i < Amount; i++)
            {
                Data[i].Y = Math.Sin((i + _offset) / Amount * Math.PI * 2) * Height;
            }
        }

        public override void Cleanup()
        {
            base.Cleanup();

            _timer.Stop();
            _timer.Tick -= OnTick;
        }
    }
}
