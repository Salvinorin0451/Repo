using System;

namespace DataInitiliaze
{
    //Троелсон 237
    //Инициализация данных с помощью синтаксиса инициализации
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            Console.WriteLine("Hello World!");
        }
    }

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }

        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine($"TopLeft: {topLeft.X}, {topLeft.Y} BottomRight: {BottomRight.X}, {BottomRight.Y}");

        }
    }
}
