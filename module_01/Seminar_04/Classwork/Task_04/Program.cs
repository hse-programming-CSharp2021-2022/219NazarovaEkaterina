using System;

namespace Task_4
{
    class Program
    {
        public static double Total1(double k, double r, uint n)
        {
            r = r + 1;
            for(int i = 1; i<=n; i++)
            {
                k *= r;
            }
            return k;
        }
        public static double Total2(double k, double r, uint n)
        {
            if (n == 0)
                return k;
            return (r+1) * Total2(k, r, n - 1);
            
        }
        static void Main(string[] args)
        {
            double k, r;
            uint n;
            string s1 = Console.ReadLine();
            double.TryParse(s1, out k);
            string s2 = Console.ReadLine();
            double.TryParse(s2, out r);
            string s3 = Console.ReadLine();
            uint.TryParse(s3, out n);
            for(int i = 0; i<6; i++)
            {
                Console.WriteLine("{0}   {1}    {2}", i, Total1(k, r, n), Total2(k, r, n));
            }

        }
    }
}
