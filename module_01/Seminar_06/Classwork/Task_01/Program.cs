using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, i = 0, nomer, prom, a;
            
            string s = Console.ReadLine();
            int n = s.Length;
            int.TryParse(s, out int num);

            int max = 0;

            int j = 1;
            while (num > 0)
            {
                j++;
                prom = num % 10;
                if (prom > max)
                {
                    max = prom;
                    nomer = j;
                }
                num = num / 10;
            }
            m *= 10;
            m += max;
            num = num - max * (int)Math.Pow(10, nomer);



                  
            

        }
    }
}
