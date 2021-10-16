using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            double sum2 = (1 / ((double)(a + b + c))), sum1 = 0;
            while(sum1 < sum2)
            {
                sum1 = sum2;
                a++; b++; c++;
                sum2 = sum2 + (1 / ((double)(a + b + c)));
            }
            Console.WriteLine(sum2);
        }
    }
}
