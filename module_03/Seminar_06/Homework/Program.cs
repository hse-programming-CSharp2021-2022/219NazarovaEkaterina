using System;
using System.Collections.Generic;

namespace Homework_6
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) => (X, Y) = (x, y);

        public double Distance(Point other) => Math.Sqrt((other.X - X) * (other.X - X) + (other.Y - Y) * (other.Y - Y));
    }

    class Circle : IComparable<Circle>
    {
        double rad;
        public double Rad
        {
            get => rad;
            set => rad = value;
        }

        public Point center;

        public Circle(double x, double y, double rad)
        {
            Rad = rad;
            center = new Point(x, y);
        }

        public override string ToString()
        {
            return $"Center: ({center.X:F3}, {center.Y:F3}), Radius: {Rad:F3}";
        }

        public int CompareTo(Circle other)
        {
            Point zero = new(0, 0);
            double param1 = Rad * center.Distance(zero);
            double param2 = other.Rad * other.center.Distance(zero);
            if (param1 > param2) return 1;
            else if (param1 == param2) return 0;
            else return -1;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Comparison<Circle> anonymous = delegate (Circle a, Circle b)
            {
                Point zero = new(0, 0);
                double param1 = a.Rad * a.center.Distance(zero);
                double param2 = b.Rad * b.center.Distance(zero);
                if (param1 > param2) return 1;
                else if (param1 == param2) return 0;
                else return -1;
            };

            List<Circle> circles = new();
            Circle[] circles_arr;

            while (true)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                double.TryParse(Console.ReadLine(), out double rad);
                circles.Add(new Circle(x, y, rad));
                circles_arr = circles.ToArray();

                // Сортировка через lambda:

                Array.Sort(circles_arr, (a, b) =>
                {
                    Point zero = new(0, 0);
                    double param1 = a.Rad * a.center.Distance(zero);
                    double param2 = b.Rad * b.center.Distance(zero);
                    if (param1 > param2) return 1;
                    else if (param1 == param2) return 0;
                    else return -1;
                });

                // Сортировка через анонимный метод:
                //Array.Sort(circles_arr, anonymous);

                //Сортировка через IComparable
                //Array.Sort(circles_arr);

                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                foreach (Circle c in circles_arr)
                    Console.WriteLine(c);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine();


            }
        }

        struct Point_s
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point_s(double x, double y) => (X, Y) = (x, y);

            public double Distance(Point_s other) => Math.Sqrt((other.X - X) * (other.X - X) + (other.Y - Y) * (other.Y - Y));
        }

        struct Circle_s
        {
            double rad;

            public Point_s center;

            public Circle_s(double x, double y, double rad)
            {
                this.rad = rad;
                center = new Point_s(x, y);
            }

            public override string ToString()
            {
                return $"Center: ({center.X:F3}, {center.Y:F3}), Radius: {rad:F3}";
            }

            public int CompareTo(Circle_s other)
            {
                Point_s zero = new(0, 0);
                double param1 = rad * center.Distance(zero);
                double param2 = other.rad * other.center.Distance(zero);
                if (param1 > param2) return 1;
                else if (param1 == param2) return 0;
                else return -1;
            }
        }


    }
}
