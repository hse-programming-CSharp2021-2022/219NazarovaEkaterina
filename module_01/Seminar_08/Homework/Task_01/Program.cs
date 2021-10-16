using System;

namespace SnakeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк/столбцов в массиве");
            int.TryParse(Console.ReadLine(), out int n);
            var mas = new int[n, n];
            int ringCounter = 0, numberCounter = 1;
            while (numberCounter <= n * n)
            {
                for(var i = ringCounter; i < n - ringCounter; i++)
                {
                    mas[ringCounter, i] = numberCounter++;
                }
                numberCounter--;
                for(var j = ringCounter; j < n - ringCounter; j++)
                {
                    mas[j, n - ringCounter - 1] = numberCounter++;
                }
                numberCounter--;
                for(var i = n - ringCounter - 1; i >= ringCounter; i--)
                {
                    mas[n - ringCounter - 1, i] = numberCounter++;
                }
                numberCounter--;
                for(var j = n - ringCounter - 1; j > ringCounter; j--)
                {
                    mas[j, ringCounter] = numberCounter++;
                }
                ringCounter++;
            }
            for(var i = 0; i<n; i++)
            {
                for(var j = 0; j<n; j++)
                {
                    Console.Write("{0, 3} ", mas[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
