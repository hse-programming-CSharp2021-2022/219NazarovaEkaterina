using System;

namespace Task_5
{
    class Program
    {
        public static void NotEqual(string x, string y, string z)
        {
            double a, b, c;
            double.TryParse(x, out a);
            double.TryParse(y, out b);
            double.TryParse(z, out c);
            string d;
            d = ((a < b + c) && (b < a + c) && (c < a + b)) ? "Неравенство треугольника выполняется" : "Неравенство треугольника не выполняется";
            Console.WriteLine(d);
        }
        static void Main(string[] args)
        {
            string s1, s2, s3;
            do
            {
                Console.WriteLine("Введите 3 вещественных числа: ");
                s1 = Console.ReadLine();
                s2 = Console.ReadLine();
                s3 = Console.ReadLine();
                NotEqual(s1, s2, s3);
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
