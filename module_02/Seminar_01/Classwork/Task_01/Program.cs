using System;

namespace Homework_From2610
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Ro
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public double Fi
        {
            get
            {
                if (X > 0)
                {
                    return (Y >= 0) ? Math.Atan(Y / X) : (Math.Atan(Y / X) + 2 * Math.PI);
                }
                else if (X < 0)
                    return Math.Atan(Y / X) + Math.PI;
                else
                {
                    if (Y > 0)
                        return Math.PI / 2;
                    else if (Y < 0)
                        return Math.PI * 1.5;
                    else return 0;
                }
            }
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public override string ToString()
        {
            return $"X: {this.X,5:F3}; Y: {this.Y,5:F3}; Fi: {this.Fi,5:F3}; Ro: {this.Ro,5:F3}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point(1, 1);
            Point secondPoint = new Point();
            Console.WriteLine("Введите координаты третьей точки: ");
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            Point thirdPoint = new Point(x, y);
            double maxDistance = Math.Max(Math.Max(firstPoint.Ro, secondPoint.Ro), thirdPoint.Ro);
            double minDistance = Math.Min(Math.Min(firstPoint.Ro, secondPoint.Ro), thirdPoint.Ro);
            if(firstPoint.Ro == maxDistance)
            {
                if(thirdPoint.Ro == minDistance)
                {
                    Console.WriteLine(thirdPoint);
                    Console.WriteLine(secondPoint);
                    Console.WriteLine(firstPoint);
                }
                else
                {
                    Console.WriteLine(secondPoint);
                    Console.WriteLine(thirdPoint);
                    Console.WriteLine(firstPoint);
                }
            }
            else if(secondPoint.Ro == maxDistance)
            {
                if (thirdPoint.Ro == minDistance)
                {
                    Console.WriteLine(thirdPoint);
                    Console.WriteLine(firstPoint);
                    Console.WriteLine(secondPoint);
                }
                else
                {
                    Console.WriteLine(firstPoint);
                    Console.WriteLine(thirdPoint);
                    Console.WriteLine(secondPoint);
                }
            }
            else
            {
                if (firstPoint.Ro == minDistance)
                {
                    Console.WriteLine(firstPoint);
                    Console.WriteLine(secondPoint);
                    Console.WriteLine(thirdPoint);
                }
                else
                {
                    Console.WriteLine(secondPoint);
                    Console.WriteLine(firstPoint);
                    Console.WriteLine(thirdPoint);
                }
            }
        }
    }
}
