using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[] mas = new int[n];
            Random rand = new Random();
            for(int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(0, 1001);
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine();
            Array.Sort(mas, (int a, int b) =>
            {
                if ((a % 2 == 1) && (b % 2 == 0)) return 1;
                else if ((a % 2 == -1) && (b % 2 == 1)) return -1;
                else return 0;
            });
            Array.ForEach(mas, el => Console.Write("{0} ", el));
            Console.WriteLine();
            Array.Sort(mas, (int a, int b) =>
            {
                if (Leng(a) > Leng(b)) return 1;
                if (Leng(a) < Leng(b)) return -1;
                else return 0;
            });
            Array.ForEach(mas, el => Console.Write("{0} ", el));
            Console.WriteLine();
            Array.Sort(mas, (int a, int b) =>
            {
                if (SumZ(a) > SumZ(b)) return 1;
                if (SumZ(a) < SumZ(b)) return -1;
                else return 0;
            });
            Array.ForEach(mas, el => Console.Write("{0} ", el));

        }

        public static int Leng(int a)
        {
            int i = 0;
            while(a!= 0)
            {
                a = a / 10;
                i++;
            }
            return i;
        }
        public static int SumZ(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += (a % 10);
                a = a / 10;
            }
            return sum;
        }
    }
}
