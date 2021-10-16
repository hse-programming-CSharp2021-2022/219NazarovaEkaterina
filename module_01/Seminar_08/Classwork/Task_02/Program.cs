using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            double[] mas = new double[n];
            int[] zel = new int[n];
            double[] drobn = new double[n];
            Random rand = new Random();
            int i1;
            double i2;
            for(int j = 0; j < n; j++)
            {
                zel[j] = rand.Next(0, 100);
                mas[j] = zel[j];
                i2 = (double)(rand.Next(0, 1001)) / 1000;
                drobn[j] = i2;
                mas[j] += i2;
                Console.Write("{0} ", mas[j]);
            }
            Console.WriteLine();
            Array.Sort(zel, (int a, int b) =>
            {
                if (a > b) return 1;
                if (a < b) return -1;
                else return 0;

            });
            Array.ForEach(zel, el => Console.Write("{0} ", el));
            Console.WriteLine();
            Array.Sort(drobn, (double a, double b) =>
            {
                if (a > b) return 1;
                if (a < b) return -1;
                else return 0;

            });
            Array.ForEach(drobn, el => Console.Write("{0} ", el));

        }
    }
}
