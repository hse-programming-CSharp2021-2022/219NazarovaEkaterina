using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int k);
            char[] mas = new char[k];
            Random rand = new Random();
            for(int i = 0; i < k; i++)
            {
                mas[i] = (char)rand.Next('A', 'Z' + 1);
            }
            for(int i = 0; i < k; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine();
            char[] cmas = new char[k];
            Array.Copy(mas, cmas, k);
            Array.Sort(cmas, (char a, char b) =>
            {
                int a1 = (int)a;
                int b1 = (int)b;
                if (a1 > b1) return 1;
                if (a1 < b1) return -1;
                return 0;
            });
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", cmas[i]);
            }
            Console.WriteLine();
            Array.Reverse(cmas);
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", cmas[i]);
            }
        }
    }
}
