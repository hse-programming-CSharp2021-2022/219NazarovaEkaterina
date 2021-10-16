using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, delta;
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            double.TryParse(s1, out a);
            double.TryParse(s2, out b);
            double.TryParse(s3, out delta);
            double x1 = a, x2 = a + delta;
            double s = 0;
            do
            {
                s = s + (((x1 * x1 + x2 * x2) / 2) * delta);
                x1 = x2;
                x2 = x2 + delta;
            } while ((b - delta) < delta);
            x2 = b - x1;
            s = s + (((x1 * x1 + x2 * x2) / 2) * delta);
            Console.WriteLine(s);


        }
    }
}
