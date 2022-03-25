using System;

namespace Homework_3
{
    delegate void CoordChanged(Dot point);
    
    class Dot
    {
        public Dot(double x, double y)
        {
            (X, Y) = (x, y);
        }

        public double X { get; set; }
        public double Y { get; set; }

        public event CoordChanged OnCoordChanged;

        public void DotFlow()
        {
            Random ran = new();
            for(int i = 0; i < 10; i++)
            {
                X = ran.Next(-10, 10) + ran.NextDouble();
                Y = ran.Next(-10, 10) + ran.NextDouble();
                if(X < 0 && Y < 0)
                {
                    OnCoordChanged.Invoke(this);
                }
            }
        }
    }
    
    class Program
    {
        static void PrintInfo(Dot A) => Console.WriteLine($"X: {A.X:F4}, Y: {A.Y:F4}");
        
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Dot d = new(x, y);
            d.OnCoordChanged += PrintInfo;
            d.DotFlow();
        }

        
    }
}
