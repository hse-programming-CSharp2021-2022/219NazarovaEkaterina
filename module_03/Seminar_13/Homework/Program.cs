using System;
using System.Collections.Generic;

namespace Homework_13
{
    class TriangleNums
    {
        static int count = 0;

        public IEnumerable<int> GetNumbers(int howmany)
        {
            if (howmany < 0)
                yield break;
            for(int i = 0; i < howmany; i++)
            {
                count++;
                yield return (int)(0.5 * count * (count + 1));
                if (count == howmany)
                {
                    count = 0;
                    yield break;
                }
            }
        }
    }

    class FibonacciNums
    {
        int count = 0;
        int previous = 1, preprevious = 1;

        public IEnumerable<int> GetNumbers(int howmany)
        {
            if (howmany < 0)
                yield break;
            for (int i = 0; i < howmany; i++)
            {
                count++;
                if (count == 1 || count == 2)
                    yield return 1;
                else
                {
                    int res = preprevious + previous;
                    preprevious = previous;
                    previous = res;
                    yield return res;
                }
                if (count == howmany)
                {
                    count = 0;
                    preprevious = 1;
                    previous = 1;
                    yield break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TriangleNums nums1 = new();
            FibonacciNums nums2 = new();
            Console.Write($"{"Треугольные: ",14}");
            foreach (int number in nums1.GetNumbers(10))
            {
                Console.Write($"{number,3} ");
            }
            Console.WriteLine();
            Console.Write($"{"Фибоначчи: ",14}");
            foreach (int number in nums2.GetNumbers(10))
            {
                Console.Write($"{number,3} ");
            }
            Console.WriteLine();
            Console.Write($"{"Суммы: ",14}");
            for (int i = 1; i <= 10; i++)
            {
                int j1 = 0, j2 = 0;
                foreach (int p in nums1.GetNumbers(i))
                    j1 = p;
                foreach (int p in nums2.GetNumbers(i))
                    j2 = p;
                Console.Write($"{j1 + j2, 3} ");
            }
            Console.WriteLine();

        }
    }
}
