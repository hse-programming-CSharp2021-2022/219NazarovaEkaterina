using System;

namespace Task_3
{
    class Program
    {
        public static double G(string x)
        {
            double x1;
            double.TryParse(x, out x1);
            if (x1 <= 0.5)
            {
                return Math.Sin(Math.PI/2);
            }
            else
            {
                return Math.Sin(((x1 - 1)/2)*Math.PI);
            }
        }
        static void Main(string[] args)
        {
            string s;
            do
            {
                Console.WriteLine("Введите значение X: ");
                s = Console.ReadLine();
                Console.WriteLine("G = {0}", G(s));
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
