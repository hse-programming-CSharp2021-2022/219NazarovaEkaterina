using System;

namespace Task_2
{
    class Program
    {
        public static void Maximum(string x)
        {
            int i;
            int.TryParse(x, out i);
            int a = i / 100, b = (i % 100) / 10, c = i % 10, m = 0;
            if ((a >= b) && (a >= c))
            {
                m += a;
                m *= 10;
                if (b >= c)
                {
                    m += b;
                    m *= 10;
                    m += c;
                }
                else
                {
                    m += c;
                    m *= 10;
                    m += b;
                }
            }
            if ((b >= a) && (b >= c))
            {
                m += b;
                m *= 10;
                if (a >= c)
                {
                    m += a;
                    m *= 10;
                    m += c;
                }
                else
                {
                    m += c;
                    m *= 10;
                    m += a;
                }
            }
            if ((c >= b) && (c >= a))
            {
                m += c;
                m *= 10;
                if (b >= a)
                {
                    m += b;
                    m *= 10;
                    m += a;
                }
                else
                {
                    m += a;
                    m *= 10;
                    m += b;
                }
            }
            Console.WriteLine(m);

        }
        static void Main(string[] args)
        {
            string s;
            do
            {
                Console.WriteLine("Введите трёхзначное число: ");
                s = Console.ReadLine();
                Maximum(s);
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
