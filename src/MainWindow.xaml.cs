using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CoffeeFinder
{
    public partial class MainWindow : Window
    {
        Searcher Programmer = new();
        Target Coffee = new();

        Rect[][] grid = [];

        int size = 100;
        int AlexanderX;
        int AlexanderY;
        int CoffeeX;
        int CoffeeY;

        readonly static SolidColorBrush whiteBrush = new(Colors.White);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeGrid()
        {
            int columns = (int) Math.Floor(GridCanvas.ActualWidth / size);
            int rows = columns;
            grid = new Rect[columns][];
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new Rect[rows];
                for (int j = 0; j < grid.Length; j++)
                {
                    grid[i][j] = new Rect(i * size, j * size, size, size);
                }
            }

            InitializeObjects();
            DrawGrid();

            void InitializeObjects()
            {
                Random random = new();
                AlexanderX = RandomInt();
                AlexanderY = RandomInt();
                CoffeeX = RandomInt();
                CoffeeY = RandomInt();
                if (AlexanderX == CoffeeX && AlexanderY == CoffeeY)
                {
                    InitializeObjects();
                }

                UpdatePositions();

                Programmer.Width = size;
                Programmer.Height = size;
                Coffee.Width = size;
                Coffee.Height = size;

                int RandomInt()
                {
                    return random.Next(0, grid.Length - 1);
                }
            }
        }

        private void UpdatePositions()
        {
            Rect AlexanderXY = grid[AlexanderX][AlexanderY];
            Rect CoffeeXY = grid[CoffeeX][CoffeeY];
            /*Programmer.Left = AlexanderXY.X + 1;
            Programmer.Top = AlexanderXY.Y + 1;
            Coffee.Left = CoffeeXY.X + 1;
            Coffee.Top = CoffeeXY.Y + 1;*/
        }

        private void DrawGrid()
        {
            GridCanvas.Children.Clear();

            double size = GridCanvas.ActualWidth / grid.Length;

            double positionY = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                double positionX = 0;
                for (int j = 0; j < grid.Length; j++)
                {
                    Border box = new()
                    {
                        BorderBrush = whiteBrush,
                        BorderThickness = new(1),
                        Width = size,
                        Height = size,
                    };
                    GridCanvas.Children.Add(box);
                    Canvas.SetLeft(box, positionX);
                    Canvas.SetBottom(box, positionY);
                    positionX += size;
                }
                positionY += size;
            }
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            InitializeGrid();
        }

        private void OnSearchTimerTick(object sender, EventArgs e)
        {
            AlexanderX++;
            UpdatePositions();
        }

        private void OnRunClick(object sender, RoutedEventArgs e)
        {
            //SearchTimer.Start();
        }

        private void OnExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnSizeValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            switch (SizeSlider.Value)
            {
                case 0:
                    size = 20;
                    break;
                case 1:
                    size = 40;
                    break;
                case 2:
                    size = 60;
                    break;
                case 3:
                    size = 100;
                    break;
                case 4:
                    size = 120;
                    break;
            }

            if (GridCanvas != null)
            {
                InitializeGrid();
            }
        }
    }
}