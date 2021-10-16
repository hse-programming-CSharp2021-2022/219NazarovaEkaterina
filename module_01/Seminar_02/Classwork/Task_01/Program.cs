using System;

namespace Task_1
{
    class Program
    {
        public static void Cut(string s)
        {
            int l = s.Length;
            int a;
            int.TryParse(s, out a);
            int i, dec = 1;
            for (i = 1; i < l; i++)
            {
                dec = dec * 10;
            }
            while(a>0)
            {
                Console.WriteLine(a / dec);
                a = a % dec;
                dec = dec / 10;
            }

        }
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            Cut(ss);
        }
    }
}
