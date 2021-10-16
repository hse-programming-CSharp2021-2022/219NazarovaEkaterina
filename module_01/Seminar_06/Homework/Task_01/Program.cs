using System;

namespace Task_01_2_
{
    class Program
    {
        public static bool Shift(ref char ch)
        {
            int a = (int)('a');
            int z = (int)('z');
            int c = (int)(ch);
            if ((c < a) || (c > z))
            {
                return false;
            }
            else
            {
                c = (c - a) + 1;
                c = c + 4;
                if (c > 26)
                {
                    c -= 26;
                }
                c = (c + a) - 1;
                ch = (char)c;
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ латинского алфавита: ");
            string s = Console.ReadLine();
            char letter;
            if(!char.TryParse(s, out letter))
            {
                Console.WriteLine("Incorrect input. Restart the program and try again!");
            }
            else
            {
                char.TryParse(s, out letter);
                if (!Shift(ref letter))
                {
                    Console.WriteLine("Incorrect input. Restart the program and try again!");
                }
                else
                {
                    Console.WriteLine("Result: {0}", letter);
                }
            }
        }
    }
}
