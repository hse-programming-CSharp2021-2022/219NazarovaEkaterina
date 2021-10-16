using System;
using System.Text.RegularExpressions;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); 
            Regex regOne = new Regex(@"\b[a-zA-Z]*a\b");
            var mat = regOne.Matches(s);
            foreach (var x in mat)
                Console.Write("{0} ", x);
        }
    }
}
