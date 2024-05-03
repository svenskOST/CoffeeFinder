using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace CoffeeFinder
{
    public partial class MainWindow : Window
    {
        readonly static SolidColorBrush whiteBrush = new(Colors.White);
        int size;

        Searcher? Searcher;
        Target? Target;

        readonly DispatcherTimer searchTimer = new();

        public MainWindow()
        {
            InitializeComponent();
            searchTimer.Tick += new(OnSearchTick!);
            searchTimer.Interval = new(0, 0, 0, 0, 200);
        }

        private void Initialize()
        {
            int length = (int)Math.Floor(GridCanvas.ActualWidth / size);

            Searcher = new(GridCanvas, length);
            Target = new(GridCanvas, length);

            GridCanvas.Children.Clear();

            double actualSize = GridCanvas.ActualWidth / length;

            double y = 0;
            for (int i = 0; i < length; i++)
            {
                double x = 0;
                for (int j = 0; j < length; j++)
                {
                    Border box = new()
                    {
                        BorderBrush = whiteBrush,
                        BorderThickness = new(0.5),
                        Width = actualSize,
                        Height = actualSize,
                    };
                    GridCanvas.Children.Add(box);
                    Canvas.SetLeft(box, x);
                    Canvas.SetBottom(box, y);
                    x += actualSize;
                }
                y += actualSize;
            }

            while (Searcher.X == Target.X && Searcher.Y == Target.Y)
            {
                Searcher.Initialize(actualSize);
                Target.Initialize(actualSize);
            }
        }

        private void OnSearchTick(object sender, EventArgs e)
        {
            Searcher!.Search(Target!);

            if (Searcher.X == Target!.X && Searcher.Y == Target.Y)
            {
                Found();
                searchTimer.Stop();
            } 
            else
            {
                Target.Avoid();
            }
        }

        private static void Found()
        {
            MessageBox.Show("The programmer found the coffee!");
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            Initialize();
        }

        private void OnRunClick(object sender, RoutedEventArgs e)
        {
            searchTimer.Start();
        }

        private void OnExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnSizeValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            switch (SizeSlider.Value)
            {
                case 1:
                    size = 20;
                    break;
                case 2:
                    size = 40;
                    break;
                case 3:
                    size = 60;
                    break;
                case 4:
                    size = 100;
                    break;
                case 5:
                    size = 120;
                    break;
            }

            if (GridCanvas != null)
            {
                Initialize();
            }
        }
    }
}