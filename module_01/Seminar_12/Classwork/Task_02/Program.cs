using System;
using System.Text.RegularExpressions;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Regex reg = new Regex(@"[^a-z]*[a-z][a-z][a-z][a-z][^a-z]");  // или \b\w{4}\b
            var matches = reg.Matches(s);
            foreach (Match x in matches)
                Console.WriteLine(x);
        }
    }
}
