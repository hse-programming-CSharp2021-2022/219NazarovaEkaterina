using System;
using System.IO;

namespace Homework_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //В первом проекте, создать бинарный файл Numbers и записать в него средствами класса
            //BinaryWriter 10 целых чисел, случайно выбранных из интервала [1;100].

            Random ran = new();
            using (BinaryWriter bw = new(new FileStream("Numbers.bin", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; i++)
                {
                    bw.Write(ran.Next(1, 101));
                }
            }
        }
    }
}
