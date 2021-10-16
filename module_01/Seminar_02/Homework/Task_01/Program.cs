using System;

namespace Task_1
{
    class Program
    {
        public static int Polynom(int x)
        {
            int b = x * x;
            return (b * (12 * b + 9 * x - 3) + 2 * x - 4);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            string s;
            do
            {
                s = Console.ReadLine();
                if (s != "End")
                {
                    int i, res;
                    int.TryParse(s, out i);
                    res = Polynom(i);
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Для выхода введите End; чтобы продолжить, введите х");
                }
            } while (s != "End");
        }
    }
}
