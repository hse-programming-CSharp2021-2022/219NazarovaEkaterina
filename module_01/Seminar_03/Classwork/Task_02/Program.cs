using System;

namespace Task_01
{
    class Program
    {
        public static void Ffor()
        {
            int k;
            for(int i = 2; i<=20; i+=2)
            {
                Console.WriteLine(i * i);
            }
        }
        public static void Fwhile()
        {
            int i = 2;
            while (i <= 20)
            {
                Console.WriteLine(i * i);
                i += 2;
            }
        }
        public static void FDoWhile()
        {
            int i = 2;
            do
            {
                Console.WriteLine(i * i);
                i += 2;
            }
            while (i <= 20);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("For: ");
            Ffor();
            Console.WriteLine("While: ");
            Fwhile();
            Console.WriteLine("Do-While: ");
            FDoWhile();
        }
    }
}
