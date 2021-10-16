using System;

namespace Task_1
{
    class Program
    {
        public static bool F(string x, string y)
        {
            double x1, y1, two = Math.Sqrt(2);
            double.TryParse(x, out x1);
            double.TryParse(y, out y1);
            if ((x1 >= 0) && (x1 <= two) && (y1 >= -2) && (y1 <= two))
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            string s1, s2;
            do
            {
                Console.WriteLine("Введите координаты точки");
                s1 = Console.ReadLine();
                s2 = Console.ReadLine();
                Console.WriteLine("Результат: {0}", F(s1, s2));
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
