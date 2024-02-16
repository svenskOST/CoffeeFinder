using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CoffeeFinder
{
    public partial class MainWindow : Window
    {
        Searcher programmer = new();
        Target coffee = new();

        int size = 100;
        //Rectangle[][] grid;
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
            int columns = GridPanel.Width / size;
            int rows = columns;
            grid = new Rectangle[columns][];
            for (int x = 0; x < grid.Length; x++)
            {
                grid[x] = new Rectangle[rows];
                for (int y = 0; y < grid.Length; y++)
                {
                    grid[x][y] = new Rectangle(x * size, y * size, size, size);
                }
            }

            InitializeObjects();
            DrawGrid();

            void InitializeObjects()
            {
                Random random = new Random();
                AlexanderX = RandomInt();
                AlexanderY = RandomInt();
                CoffeeX = RandomInt();
                CoffeeY = RandomInt();
                if (AlexanderX == CoffeeX && AlexanderY == CoffeeY)
                {
                    InitializeObjects();
                }

                UpdatePositions();

                Size objectSize = new Size(size, size);
                Alexander.Size = objectSize;
                Coffee.Size = objectSize;

                int RandomInt()
                {
                    return random.Next(0, grid.Length - 1);
                }
            }
        }

        private void UpdatePositions()
        {
            Rectangle AlexanderXY = grid[AlexanderX][AlexanderY];
            Rectangle CoffeeXY = grid[CoffeeX][CoffeeY];
            Alexander.Left = AlexanderXY.X + 1;
            Alexander.Top = AlexanderXY.Y + 1;
            Coffee.Left = CoffeeXY.X + 1;
            Coffee.Top = CoffeeXY.Y + 1;
        }

        private void DrawGrid()
        {
            for (int x = 0; x < grid.Length; x++)
            {
                GridPanel.CreateGraphics().DrawRectangles(new Pen(Color.White), grid[x]);
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
            SearchTimer.Start();
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

            SizeLog.Content = size.ToString();
            InitializeGrid();
        }
    }
}