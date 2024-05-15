using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoffeeFinder
{
    // Searcher och Target är baserade på klassen Entity, en bild med tillagd funktionalitet
    internal class Entity(Canvas GridCanvas, int length = 1) : Image
    {
        // X och Y värden för objektets position i rutnätet
        public int X = 0;
        public int Y = 0;
        readonly Random random = new();

        public void Initialize(double actualSize)
        {
            if (!GridCanvas.Children.Contains(this))
            {
                GridCanvas.Children.Add(this);
            }
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

        // Metod för att uppdatera objektets position visuellt
        public void RenderPosition()
        {
            Canvas.SetLeft(this, X * Width);
            Canvas.SetTop(this, Y * Height);
        }

        // Metoder för att ändra position i olika riktningar
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

        // Enkel metod för att söka efter Target
        public void Search(Entity Target)
        {
            if (X < Target.X)
            {
                MoveRight();
            }
            else if (X > Target.X)
            {
                MoveLeft();
            }
            else if (Y < Target.Y)
            {
                MoveDown();
            }
            else if (Y > Target.Y)
            {
                MoveUp();
            }

            RenderPosition();
        }
    }

    internal class Target(Canvas GridCanvas, int length) : Entity(GridCanvas)
    {
        public new void Initialize(double actualSize)
        {
            base.Initialize(actualSize);
            Source = new BitmapImage(new Uri("/assets/target.png", UriKind.Relative));
        }

        // Metod som ger slumpmässig förflyttning
        public void Avoid()
        {
            Random random = new();
            int direction = random.Next(0, 4);

            switch (direction)
            {
                case 0:
                    if (X > 0) MoveLeft();
                    break;
                case 1:
                    if (X < length - 1) MoveRight();
                    break;
                case 2:
                    if (Y > 0) MoveUp();
                    break;
                case 3:
                    if (Y < length - 1) MoveDown();
                    break;
            }

            RenderPosition();
        }
    }
}
