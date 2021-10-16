using System;

namespace Task_04
{
    class Program
    {
        public static void Sw(int a)
        {
            int p, m = 0;
            while (a > 0)
            {
                m *= 10;
                p = a % 10;
                a = a / 10;
                m += p;
            }
            Console.WriteLine(m);
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i;
            int.TryParse(s, out i);
            Sw(i);
        }
    }
}
