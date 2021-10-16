using System;
using System.Linq;

namespace Task_01
{
    class Program
    {
        public static int GetNumDigits(int a)
        {
            int counter = 0;
            while (a > 0)
            {
                a = a / 10;
                counter++;
            }
            return counter;
        }
        public static bool Pali(int a)
        {
            string s = a.ToString();
            for(int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    return false;
            }
            return true;
        }

        public static int SumD (int a)
        {
            var counter = 0;
            while (a > 0)
            {
                counter += a % 10;
                a = a / 10;
            }
            return counter;
        }
        public static int MaxD(int a)
        {
            int max = 0, prom = 0;
            while (a > 0)
            {
                prom = a % 10;
                if (prom > max)
                    max = prom;
                a /= 10;
            }
            return max;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            if((n<1) || (n > 10000))
            {
                return;
            }
            var mas = new int[n];
            var rand = new Random();
            for(int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(1, 10001);
            }
            foreach (var x in mas)
                Console.Write(x + " ");
            Console.WriteLine();
            var select = from x in mas
                         where (x >= 10) && (x <= 99) && (x % 3 == 0)
                         select x;
            foreach (var x in select)
                Console.Write(x + " ");
            Console.WriteLine();
            var select2 = from x in mas
                          where Pali(x)
                          orderby x
                          select x;
            foreach (var x in select2)
                Console.Write(x + " ");
            Console.WriteLine();
            var select3 = mas
                .OrderBy(x => SumD(x))
                .ThenBy(x => x);
            foreach (var x in select3)
                Console.Write(x + " ");
            Console.WriteLine();
            var select4 = from x in mas
                          where (x >= 1000) && (x <= 9999)
                          select x;
            int Sum = 0;
            foreach (var x in select4)
                Sum += x;
            Console.WriteLine(Sum);
            Console.WriteLine();
            var select5 = (from x in mas
                             where (x >= 10) && (x <= 99)
                             orderby x descending
                             select x).ToArray();
            if (select5.Length == 0)
                Console.WriteLine("Двухзначных нет");
            else Console.WriteLine(select5[0]);
            Console.WriteLine();
            var select6 = (from x in mas
                           select MaxD(x)).ToArray();
            foreach (var x in select6)
                Console.Write(x + " ");
            Console.WriteLine();

        }
    }
}
