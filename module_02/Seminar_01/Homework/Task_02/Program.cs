using System;

namespace Task_02_3_
{
    class Polygons
    {
        private int number;
        public int Number
        {
            set { number = value; }
            get { return number; }
        }
        private double rad;
        public double Radius
        {
            set { rad = value; }
            get { return rad; }
        }
        public Polygons(int number, double radius)
        {
            Number = number;
            Radius = radius;
        }
        public Polygons()
        {
            Number = 3;
            Radius = 1;
        }
        public double Perimetr
        {
            get
            {
                double radOpOkr = rad / Math.Cos(Math.PI / number);
                return 2 * radOpOkr * Math.Sin(Math.PI / number) * number;
            }
        }
        public double Area
        {
            get
            {
                return 0.5 * this.Perimetr * rad;
            }
        }
        public string PolygonData()
        {
            return $"Number of sides: {number}; Radius of the inscribed circle: {rad,5:F3}; Perimetr: {this.Perimetr,5:F3}; Area: {this.Area,5:F3}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество многоугольников: ");
            int.TryParse(Console.ReadLine(), out int N);
            var polygons = new Polygons[N];
            double minArea = 1000000, maxArea = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите количество сторон и радиус вписанной окружности многоугольника: ");
                int.TryParse(Console.ReadLine(), out int number);
                double.TryParse(Console.ReadLine(), out double radius);
                polygons[i] = new Polygons(number, radius);
                if (polygons[i].Area < minArea)
                    minArea = polygons[i].Area;
                if (polygons[i].Area > maxArea)
                    maxArea = polygons[i].Area;
            }
            for (int i = 0; i < N; i++)
            {
                if (polygons[i].Area == minArea)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(polygons[i].PolygonData());
                    Console.ResetColor();
                }
                else if (polygons[i].Area == maxArea)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(polygons[i].PolygonData());
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(polygons[i].PolygonData());
                }
            }


            // ОТСЮДА НАЧИНАЕТСЯ НОМЕР 4*
            // ЧТОБЫ ЕГО ЗАПУСТИТЬ, НУЖНО ЗАКОММЕНТИРОВАТЬ ВЕСЬ КОД В MAIN ВЫШЕ И РАСКОММЕНТИРОВАТЬ ВСЁ, ЧТО НИЖЕ

            //int n = 1;
            //var polygons = new Polygons[0];
            //int number = 1;
            //double radius = 1;
            //double minArea = 1000000, maxArea = 0;
            //while (!(number == 0 && radius == 0))
            //{
            //    Console.WriteLine("Введите количество сторон и радиус вписанной окружности многоугольника: ");
            //    int.TryParse(Console.ReadLine(), out number);
            //    double.TryParse(Console.ReadLine(), out radius);
            //    if (number == 0 && radius == 0)
            //        return;
            //    Polygons newPolygon = new Polygons(number, radius);
            //    Polygons[] newP = new Polygons[polygons.Length + 1];
            //    newP[newP.Length - 1] = newPolygon;
            //    if(polygons.Length != 0)
            //    {
            //        for(int i = 0; i < polygons.Length; i++)
            //        {
            //            newP[i] = polygons[i];
            //        }
            //    }
            //    polygons = newP;
            //    minArea = 1000000; 
            //    maxArea = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (polygons[i].Area < minArea)
            //            minArea = polygons[i].Area;
            //        if (polygons[i].Area > maxArea)
            //            maxArea = polygons[i].Area;
            //    }
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (polygons[i].Area == minArea)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine(polygons[i].PolygonData());
            //            Console.ResetColor();
            //        }
            //        else if (polygons[i].Area == maxArea)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine(polygons[i].PolygonData());
            //            Console.ResetColor();
            //        }
            //        else
            //        {
            //            Console.WriteLine(polygons[i].PolygonData());
            //        }
            //    }
            //    n++;
            //}

        }
    }
}
