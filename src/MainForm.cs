using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeFinder
{
    public partial class MainForm : Form
    {
        public int size = 100;
        public Rectangle[][] grid;
        public int AlexanderX;
        public int AlexanderY;
        public int CoffeeX;
        public int CoffeeY;

        public MainForm()
        {
            InitializeComponent();
            InitializeGrid();
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
            GridPanel.Invalidate();

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

        private void GridPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            SearchTimer.Start();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void SizeTrackbar_ValueChanged(object sender, System.EventArgs e)
        {
            switch (SizeTrackbar.Value)
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

            SizeLog.Text = size.ToString();
            InitializeGrid();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            AlexanderX++;
            UpdatePositions();
        }
    }
}
