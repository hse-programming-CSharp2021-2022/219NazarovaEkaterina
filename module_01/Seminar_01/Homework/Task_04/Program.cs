using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R;
            string inp1 = Console.ReadLine();
            double.TryParse(inp1, out U);
            string inp2 = Console.ReadLine();
            double.TryParse(inp2, out R);
            Console.WriteLine("I = " + U / R);
            Console.WriteLine("P = " + (U * U) / R);
        }
    }
}
