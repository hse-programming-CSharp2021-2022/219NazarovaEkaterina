﻿using System;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int aa, bb;
            int.TryParse(a, out aa);
            int.TryParse(b, out bb);
            Console.WriteLine(aa + bb);
        }
    }
}
