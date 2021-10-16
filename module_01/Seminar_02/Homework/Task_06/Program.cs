using System;

namespace Task_6
{
    class Program
    {
        public static void Budget(string x, string y)
        {
            double sum, a, b;
            double.TryParse(x, out a);
            double.TryParse(y, out b);
            b = b / 100;
            sum = a * b;
            decimal sum2 = (decimal)sum;
            Console.WriteLine($"{sum2:C}");
        }
        static void Main(string[] args)
        {
            string s1, s2;
            do
            {
                Console.WriteLine("Введите бюджет (вещественное число): ");
                s1 = Console.ReadLine();
                Console.WriteLine("Введите кол-во процентов, приходящееся на компьютерные игры: ");
                s2 = Console.ReadLine();
                Budget(s1, s2);
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
