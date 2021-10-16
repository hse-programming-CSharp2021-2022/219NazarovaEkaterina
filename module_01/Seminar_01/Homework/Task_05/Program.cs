using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1, k2;
            string inp1 = Console.ReadLine();
            int.TryParse(inp1, out k1);
            string inp2 = Console.ReadLine();
            int.TryParse(inp2, out k2);
            Console.WriteLine(Math.Sqrt((k1 * k1) + (k2 * k2)));
        }
    }
}
