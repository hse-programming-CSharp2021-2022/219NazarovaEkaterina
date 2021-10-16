using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[6];
            int prom;
            Random r = new Random();
            for(int i = 0; i < 6; i++)
            {
                int.TryParse(Console.ReadLine(), out mas[i]);
            }
            for(int i = 0; i < 6; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine();
            int k = mas.Length;
            for(int i = 0; i < k - 1; i++)
            {
                prom = mas[i] + mas[i + 1];
                if (prom % 3 == 0)
                {
                    mas[i] = mas[i] * mas[i + 1];
                    for(int j = i+2; j <= mas.Length-1; j++)
                    {
                        mas[j - 1] = mas[j];
                    }
                    k--;
                }
            }
            for(int i = 0; i < k; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
        }
    }
}
