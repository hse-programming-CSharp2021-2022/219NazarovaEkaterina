using System;

namespace Task_03_7_
{
    class Program
    {
        public static void NokNod(int a, int b, out int nok, out int nod)
        {
            int m1 = (int)Math.Min(a, b);
            nok = 0; nod = 0;
            for(int i = m1; i>=0; i--)
            {
                if((a % i == 0) && (b % i == 0))
                {
                    nod = i;
                    break;
                }
            }
            int m2 = (int)Math.Max(a, b);
            for(int i = m2; i <= (a * b); i++)
            {
                if ((i % a == 0) && (i % b == 0))
                {
                    nok = i;
                    break;
                }
            }

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            int c, d;
            NokNod(a, b, out c, out d);
            Console.WriteLine("НОК: {0} \nНОД: {1}", c, d);
        }
    }
}
