using System;

namespace Radius
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double r;
            double.TryParse(s, out r);
            double l, sq;
            l = 2 * 3.14159265 * r;
            sq = 3.14159265 * r * r;
            double res1 = l * 1000, res2 = sq * 1000;
            int i = (int)res1, i2 = (int)res2;
            res1 = i;
            res2 = i2;
            Console.WriteLine("Длина = " + res1/1000);
            Console.WriteLine("Площадь = " + "{0:0.000}", res2/1000);
        }
    }
}
