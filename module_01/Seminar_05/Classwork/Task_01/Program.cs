using System;

namespace Task_1
{
    class Program
    {
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            uint Even = 0, Odd = 0, prom;
            string s = number.ToString();
            for(int i = 1; i <= s.Length; i++)
            {
                prom = number % 10;
                if ((i % 2) == 1)
                {
                    Odd += prom;
                }
                else
                {
                    Even += prom;
                }
                number = number / 10;
            }
            sumEven = Even;
            sumOdd = Odd;
            

        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            uint.TryParse(s, out uint i);
            uint a, b;
            Sums(i, out a, out b);
            Console.WriteLine("SumEven = {0}, SumOdd = {1}", a, b);
        }
    }
}
