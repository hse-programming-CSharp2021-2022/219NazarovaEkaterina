using System;

namespace Task_02
{
    class Program
    {
        public static void PrintMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[100];
            for(int i = 0; i <100; i++)
            {
                array[i] = i+1;
            }
            Random rand = new Random();
            int prom, prom2, c;
            for(int i = 0; i < 200; i++)
            {
                prom = rand.Next(0, 100);
                prom2 = rand.Next(0, 100);
                c = array[prom];
                array[prom] = array[prom2];
                array[prom2] = c;
            }
            Array.Resize(ref array, 99);
            int sum1 = 0;
            for(int i = 0; i < 99; i++)
            {
                sum1 += array[i];
            }
            Console.WriteLine(5050 - sum1);
            
        }
    }
}
