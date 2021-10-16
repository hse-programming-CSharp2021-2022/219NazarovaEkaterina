using System;

namespace Task_4
{
    class Program
    {
        public static int Cl(string x, string y, string z)
        {
            int x1, y1, z1;
            int.TryParse(x, out x1);
            int.TryParse(y, out y1);
            int.TryParse(z, out z1);
            int r1 = x1 % 100, r2 = y1 % 100, r3 = z1 % 100;
            if ((r1 <= r2) && (r1 <= r3))
            {
                return x1;
            }
            else if ((r2 <= x1) && (r2 <= r3))
            {
                return y1;
            }
            else
            {
                return z1;
            }
        }
        static void Main(string[] args)
        {
            string s1, s2, s3;
            do
            {
                Console.WriteLine("Введите номера трёх аудиторий: ");
                s1 = Console.ReadLine();
                s2 = Console.ReadLine();
                s3 = Console.ReadLine();
                Console.WriteLine("Искомая аудитория: {0}", Cl(s1, s2, s3));
                Console.WriteLine("Для выхода нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
