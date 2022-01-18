using System;

namespace Task_01_1_
{
    class Program
    {
        public delegate int Cast(double t);
        
        static int Example2(double t)
        {
            int prom = (int)Math.Log10(t);
            return prom + 1;
        }

        static int Example1(double t)
        {
            int p = (int)t;
            int p1 = (p % 2 == 0) ? p : (p - 1);
            int p2 = ((p + 1) % 2 == 0) ? (p + 1) : (p + 2);
            if (Math.Abs(t - p1) > Math.Abs(t - p2))
                return p2;
            else
                return p1;
        }
        
        static void Main(string[] args)
        {
            Cast first = delegate (double t)
            {
                int p = (int)t;
                int p1 = (p % 2 == 0) ? p : (p - 1);
                int p2 = ((p + 1) % 2 == 0) ? (p + 1) : (p + 2);
                if (Math.Abs(t - p1) > Math.Abs(t - p2))
                    return p2;
                else
                    return p1;
            };

            Cast second = delegate (double t)
            {
                int p = (int)t;
                int counter = 0;
                while (p > 0)
                {
                    p /= 10;
                    counter++;
                }
                return counter;
            };

            Console.WriteLine(first(20.15));
            Console.WriteLine(second(20.15));
            Console.WriteLine(first(2.35));
            Console.WriteLine(second(2.35));

            first += second;
            Console.WriteLine(first(20.5));

            first = (double t) =>
            {
                int p = (int)t;
                int p1 = (p % 2 == 0) ? p : (p - 1);
                int p2 = ((p + 1) % 2 == 0) ? (p + 1) : (p + 2);
                if (Math.Abs(t - p1) > Math.Abs(t - p2))
                    return p2;
                else
                    return p1;
            };
            second = (double t) =>
            {
                int p = (int)t;
                int counter = 0;
                while (p > 0)
                {
                    p /= 10;
                    counter++;
                }
                return counter;
            };

            first += second;
            Console.WriteLine(first(20.5));

            Console.WriteLine(first.Invoke(20.5));

            first = Program.Example1;
            first += Program.Example2;
            first.Invoke(20.5);
            first -= Program.Example2;
            first.Invoke(20.5);



        }
    }
}
