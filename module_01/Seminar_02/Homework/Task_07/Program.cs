using System;

namespace Task_7
{
    class Program
    {
        public static void M1(string x, out int i, out double y)
        {
            double b;
            double.TryParse(x, out b);
            i = (int)b;
            y = b - i;
        }
        public static void M2(string x, out string s, out double a)
        {
            double c;
            double.TryParse(x, out c);
            s = c < 0 ? "Невозможно вычислить" : (Math.Sqrt(c)).ToString();
            a = c * c;
        }
        static void Main(string[] args)
        {
            string s1, sqrt;
            double a, b;
            int i;
            do
            {
                Console.WriteLine("Введите вещественное число: ");
                s1 = Console.ReadLine();
                M1(s1, out i, out a);
                M2(s1, out sqrt, out b);
                Console.WriteLine("Корень из этого числа: " + sqrt);
                Console.WriteLine("Квадрат этого числа: {0}", b);
                Console.WriteLine("Целая часть числа: {0}", i);
                Console.WriteLine("Дробная часть числа: {0}", a);
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
