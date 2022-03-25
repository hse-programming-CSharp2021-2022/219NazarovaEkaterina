using System;
using System.Linq;
using System.Collections.Generic;

namespace Homework_14
{

    // В некоторой̆ коллекции хранятся целые числа.
    // 1. Составить LINQ-выражение, формирующее коллекцию их квадратов.
    // 2. Составить LINQ- выражение, выбирающее только положительные двузначные числа.
    // 3. Составить LINQ- выражение, выбирающее только чётные числа и сортирующее их по убыванию.
    // 4. Составить LINQ- выражение, группирующее числа по порядку (сотни, десятки, единицы).
    // Написать программу, применяющую выражения к коллекции из n (задать с клавиатуры)
    // случайных чисел из отрезка[-1000, 1000]. (снабдить выводом исходных чисел и сформированных коллекций).

    class Program
    {
        public static void Print(IEnumerable<int> a)
        {
            foreach (int i in a)
                Console.Write($"{i,5} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int nn = int.Parse(Console.ReadLine());
            int[] arr = new int[nn];
            Random ran = new();
            for(int i = 0; i < nn; i++)
            {
                arr[i] = ran.Next(-1000, 1001);
            }

            Print(arr);

            var res1 = from n in arr
                       select n * n;

            var res2 = from n in arr
                       where (n >= 10 && n <= 99)
                       select n;

            var res3 = from n in arr
                       where Math.Abs(n) % 2 == 0
                       orderby -n
                       select n;

            var res4 = from n in arr
                       orderby Math.Abs(n) / 100, Math.Abs(n) / 10, Math.Abs(n)
                       select n;

            Print(res1);
            Print(res2);
            Print(res3);
            Print(res4);

        }
    }
}
