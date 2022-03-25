using System;
using System.IO;
using System.Collections.Generic;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\Homework_11\bin\Debug\net5.0\Numbers.bin";

            // Во втором проекте вывести на экран числа из файла Numbers, а затем заменять в этом файле на введенное
            // пользователем целое значение число, ближайшее по значению к тому, которое ввел пользователь, и вновь
            // выводить числа из файла на экран.
            // Вводимые числа, не принадлежащие интервалу [1;100], игнорировать.

            var list = new List<int>();
            FileStream fs = new(path, FileMode.Open, FileAccess.ReadWrite);
            using (BinaryReader br = new(fs))
            {
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    list.Add(br.ReadInt32());
                }
            }
            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();

            var numbers = list.ToArray();
            int nearest = 1;
            List<int> positions = new();
            int minD = 100;
            int n = 1000;
            while (n < 1 || n > 100)
            {
                int.TryParse(Console.ReadLine(), out n);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int currDif = Math.Abs(numbers[i] - n);
                if(currDif < minD)
                {
                    minD = currDif;
                    nearest = numbers[i];
                    positions.Clear();
                    positions.Add(i);
                }
                else if(currDif == minD)
                {
                    positions.Add(i);
                }
            }

            foreach(int pos in positions)
            {
                numbers[pos] = n;
            }

            foreach (int i in numbers)
                Console.Write(i + " ");
            Console.WriteLine();

        }
    }
}
