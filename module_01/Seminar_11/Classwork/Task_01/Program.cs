using System;
using System.IO;
using System.Text;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";

            // Создаем файл с данными
            if (!File.Exists(path))
            {
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                File.Create(path);
                //string createText = "10 20 30 40 50" + Environment.NewLine +
                    //"60 70 80 90";
                //File.WriteAllText(path, createText, Encoding.UTF8);
            }
            int.TryParse(Console.ReadLine(), out int numOfLines);
            var mas = new int[5];
            var rnd = new Random();
            for (int i = 0; i < numOfLines; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mas[j] = rnd.Next(10, 100);
                }
                File.AppendAllText(path, $"{mas[0]} {mas[1]} {mas[2]} {mas[3]} {mas[4]}");
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int numCh, numNech;
                int[] arr = StringArrayToIntArray(stringValues, out numCh, out numNech);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                var firstMas = new int[numCh];
                var secondMas = new int[numNech];
                int indCh = 0, indNech = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        firstMas[indCh] = i;
                        indCh++;
                    }
                    else
                    {
                        secondMas[indNech] = i;
                        indNech++;
                        arr[i] = 0;
                    }
                }
                Console.WriteLine();
                for(int i = 0; i < firstMas.Length; i++)
                {
                    Console.Write("{0} ", firstMas[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < secondMas.Length; i++)
                {
                    Console.Write("{0} ", secondMas[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();
                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                // TODO3: Заменяем все нечётные числа исходного массива нулями
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str, out int numCh, out int numNech)
        {
            var arr = new int[str.Length * 5];
            int num = 0, numC = 0, numN = 0;
            if (str.Length != 0)
            {
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        arr[num++] = tmp;
                        if (tmp % 2 == 0)
                            numC++;
                        else
                            numN++;
                    }
                } // end of foreach (string s in str)      
            }
            numCh = numC;
            numNech = numN;
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}
