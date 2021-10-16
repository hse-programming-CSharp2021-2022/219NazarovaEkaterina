using System;

namespace Task_3
{
    class Program
    {
        public static int A(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if ((m > 0) && (n == 1))
            {
                return A(m - 1, 1);
            }
            else return A(m - 1, A(m, n - 1));
        }
        static void Main(string[] args)
        {
            int m, n;
            string s1 = Console.ReadLine();
            int.TryParse(s1, out m);
            string s2 = Console.ReadLine();
            int.TryParse(s2, out n);
            Console.WriteLine(A(m, n));

        }
    }
}
