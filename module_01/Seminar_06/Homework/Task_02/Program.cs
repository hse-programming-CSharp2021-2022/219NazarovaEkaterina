using System;

namespace Task_02_6_
{
    class Program
    {
        public static int Factorial(int a)
        {
            int res = 1;
            for (int i = 1; i <= a; i++)
            {
                res = res * i;
            }
            return res;
        }

        public static double S1(double x)
        {
            double s = 0, prom = 1;
            int powx = 2, pow2 = 1, fact = 2, counter = 1, sign;
            while(prom > 0)
            {
                sign = (counter % 2 == 1) ? 1 : -1;
                prom = (sign * (Math.Pow(x, powx)) * (Math.Pow(2, pow2))) / (Factorial(fact));
                powx += 2;
                pow2 += 2;
                fact += 2;
                counter += 1;
                s += prom;
            }
            return s;
        }
        
        public static double S2(double x)
        {
            int powx = 0, fact = 0;
            double s = 0, prom = 1;
            while (prom > 0)
            {
                prom = (Math.Pow(x, powx)) / (Factorial(fact));
                powx++;
                fact++;
                s += prom;
            }
            return s;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            string s = Console.ReadLine();
            if (!double.TryParse(s, out double x))
            {
                Console.WriteLine("Неверный ввод");
            }
            else
            {
                Console.WriteLine("S1 = {0}, S2 = {1}", S1(x), S2(x));
            }
        }
    }
}
