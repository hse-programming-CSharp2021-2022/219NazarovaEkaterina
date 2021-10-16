using System;

namespace Task_5
{
    class Program
    {
        public static int NumDel(int a)
        {
            int col = 0;
            for(int i = 1; i < ((int)Math.Sqrt(a)); i++)
            {
                if(a % i == 0)
                {
                    col = col + 2;
                }
            }
            if (Math.Sqrt(a) == (int)Math.Sqrt(a))
            {
                col = col + 1;
            }
            return col;
        }
        static void Main(string[] args)
        {
            int k;
            string s = Console.ReadLine();
            int.TryParse(s, out k);
            for(int i = 100; i<1000; i++)
            {
                if(NumDel(i) == k)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
