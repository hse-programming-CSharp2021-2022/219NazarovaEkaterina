using System;

namespace Task_01
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
            return $"Number of sides: {number,5:F3}; Radius of the inscribed circle: {rad, 5:F3}; Perimetr: {this.Perimetr, 5:F3}; Area: {this.Area, 5:F3}";
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Polygons defaultPolygon = new Polygons();
            Console.WriteLine("Параметры многоугольника по умолчанию: ");
            Console.WriteLine(defaultPolygon.PolygonData());
            do
            {
                Console.WriteLine("Введите количество сторон и радиус вписанной окружности многоугольника: ");
                int.TryParse(Console.ReadLine(), out int number);
                double.TryParse(Console.ReadLine(), out double radius);
                Polygons newPolygon = new Polygons(number, radius);
                Console.WriteLine("Информация о Вашем многоугольнике: ");
                Console.WriteLine(newPolygon.PolygonData());
                Console.WriteLine("Нажмите Esc для выхода, любую другую кнупку, чтобы продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
