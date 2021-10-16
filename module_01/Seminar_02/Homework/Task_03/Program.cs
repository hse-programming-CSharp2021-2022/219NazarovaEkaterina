using System;

namespace Task_2
{
    class Program
    {
        public static void Resolution(string a1, string b1, string c1)
        {
            int a, b, c;
            double d;
            string x1, x2;
            int.TryParse(a1, out a);
            int.TryParse(b1, out b);
            int.TryParse(c1, out c);
            d = b * b - 4 * a * c;
            bool flag;
            flag = d >= 0 ? true : false;
            x1 = flag == true ? ((-b + Math.Sqrt(d)) / (2 * a)).ToString() : "Комплексное число";
            x2 = flag == true ? ((-b - Math.Sqrt(d)) / (2 * a)).ToString() : "Комплексное число";
            Console.Write("x1 = ");
            Console.WriteLine(x1);
            Console.Write("x2 = ");
            Console.WriteLine(x2);


        }
        static void Main(string[] args)
        {
            string s1, s2, s3;
            do
            {
                Console.WriteLine("Введите А: ");
                s1 = Console.ReadLine();
                Console.WriteLine("Введите B: ");
                s2 = Console.ReadLine();
                Console.WriteLine("Введите C: ");
                s3 = Console.ReadLine();
                Resolution(s1, s2, s3);
                Console.WriteLine("Для завершения нажмите Esc; для продолжения нажмите Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
