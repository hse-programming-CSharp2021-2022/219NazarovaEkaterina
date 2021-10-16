using System;
using System.Text.RegularExpressions;

namespace Task_04
{
    class Program
    {

        public static int NumOfDigits(Match x)
        {
            string strX = x.Value.ToString();
            return strX.Length;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Regex reg = new Regex(@"[0-9]*");
            var mat = reg.Matches(s);
            int maxNum = 0;
            foreach(Match x in mat)
            {
                if (NumOfDigits(x) > maxNum)
                {
                    maxNum = NumOfDigits(x);
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
