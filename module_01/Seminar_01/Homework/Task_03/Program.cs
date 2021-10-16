using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Code;
            string input = Console.ReadLine();
            int.TryParse(input, out Code);
            Console.WriteLine((char)Code);
        }
    }
}
