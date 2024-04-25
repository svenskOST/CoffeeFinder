using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoffeeFinder
{
    internal class Entity(Canvas GridCanvas, int length) : Image
    {
        public int X = 0;
        public int Y = 0;
        readonly Random random = new();
        public Canvas GridCanvas { get; set; } = GridCanvas; // testa utan denna rad

        public void Initialize(double actualSize)
        {
            GridCanvas.Children.Add(this);
            X = RandomInt();
            Y = RandomInt();
            Width = actualSize;
            Height = actualSize;
            RenderPosition();
        }

        protected int RandomInt()
        {
            return random.Next(0, length - 1);
        }

        public void RenderPosition()
        {
            Canvas.SetLeft(this, X * Width);
            Canvas.SetTop(this, Y * Height);
        }

        public void MoveLeft()
        {
            X--;
        }

        public void MoveRight()
        {
            X++;
        }

        public void MoveUp()
        {
            Y--;
        }

        public void MoveDown()
        {
            Y++;
        }
    }

    internal class Searcher(Canvas GridCanvas, int length) : Entity(GridCanvas, length)
    {
        public new void Initialize(double actualSize)
        {
            base.Initialize(actualSize);
            Source = new BitmapImage(new Uri("/assets/searcher.png", UriKind.Relative));
        }
    }

    internal class Target(Canvas GridCanvas, int length) : Entity(GridCanvas, length)
    {
        public new void Initialize(double actualSize)
        {
            base.Initialize(actualSize);
            Source = new BitmapImage(new Uri("/assets/target.png", UriKind.Relative));
        }
    }
}
