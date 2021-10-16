using System;

namespace Task_2
{
    class Program
    {
        public static double G(string x, string y)
        {
            double x1, y1;
            double.TryParse(x, out x1);
            double.TryParse(y, out y1);
            if ((x1 < y1) && (x1 > 0))
            {
                return x1 + Math.Sin(y1);
            }
            else if ((x1 > y1) && (x1 < 0))
            {
                return y1 - Math.Cos(x1);
            }
            else
            {
                return 0.5 * x1 * y1;
            }
        }
        static void Main(string[] args)
        {
            string s1, s2;
            do
            {
                Console.WriteLine("Введите значения X и Y: ");
                s1 = Console.ReadLine();
                s2 = Console.ReadLine();
                Console.WriteLine("G = {0}", G(s1, s2));
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
