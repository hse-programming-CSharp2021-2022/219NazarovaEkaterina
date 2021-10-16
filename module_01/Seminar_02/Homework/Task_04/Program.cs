using System;

namespace Task_4
{
    class Program
    {
        public static void Swi(string x)
        {
            int i, m=0;
            int.TryParse(x, out i);
            while (i > 0)
            {
                m *= 10;
                m += (i % 10);
                i = i / 10;
            }
            Console.WriteLine(m);
        }
        static void Main(string[] args)
        {
            string s;
            do
            {
                Console.WriteLine("Введите четырёхзначное число: ");
                s = Console.ReadLine();
                Swi(s);
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
