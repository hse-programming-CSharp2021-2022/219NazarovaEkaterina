using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            Random rand = new Random();
            int[][] mas = new int[n][];
            for(int i = 0; i<n; i++)
            {
                mas[i] = new int[rand.Next(5, 16)];
                for(int j = 0; j < mas[i].Length; j++)
                {
                    mas[i][j] = rand.Next(-10, 11);
                    Console.Write("{0} ", mas[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                Array.Sort(mas[i], (int a, int b) =>
                {
                    if (a > b) return -1;
                    if (a < b) return 1;
                    else return 0;
                });
            }
            Array.Sort(mas, (int[] a, int[] b) =>
            {
                if (a.Length > b.Length) return -1;
                if (a.Length < b.Length) return 1;
                else return 0;
            });
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < mas[i].Length; j++)
                {
                    Console.Write("{0} ", mas[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
