using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using Avalonia.VisualTree;

namespace AvaloniaCoreSnow
{
    public class MainWindow : Window
    {
        private SnowViewModel _viewModel;
        private IControl _img;

        public MainWindow()
        {
            InitializeComponent();
            this.AttachDevTools();

            DataContext = _viewModel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            _img = ((Grid) Content).Children.First();
            _img.PointerMoved += Image_PointerMoved;
            _img.PointerPressed += Img_PointerPressed;

            // Delegate is called from bg thread, use synchronous call to avoid concurrency issues within Avalonia.
            _viewModel = new SnowViewModel(() =>
                Dispatcher.UIThread.InvokeAsync(() => _img.InvalidateVisual()).Wait());
        }

        private void Image_PointerMoved(object sender, PointerEventArgs e)
        {
            if (e.InputModifiers.HasFlag(InputModifiers.LeftMouseButton))
            {
                var (x, y) = GetScaledPosition(e, _img);

                _viewModel.PutPixel(x, y, 2);
            }
        }

        private async void Img_PointerPressed(object sender, PointerPressedEventArgs e)
        {
            if (e.MouseButton == MouseButton.Right && e.ClickCount == 1)
            {
                var (x, y) = GetScaledPosition(e, _img);

                var dlg = new OpenFileDialog
                {
                    AllowMultiple = false,
                    Title = "Choose a picture to load",
                    Filters = new List<FileDialogFilter>
                    {
                        new FileDialogFilter {Name = "Pictures", Extensions = new List<string> {"png", "jpg"}}
                    }
                };

                var files = await dlg.ShowAsync(this);

                if (files != null)
                {
                    _viewModel.LoadFile(files.First(), x, y);
                }
            }
        }

        private static (double x, double y) GetScaledPosition(PointerEventArgs e, IVisual visual)
        {
            var pos = e.GetPosition(visual);

            var x = pos.X / visual.Bounds.Width;
            var y = pos.Y / visual.Bounds.Height;

            return (x, y);
        }
    }
}
