using System;
using System.Collections.Generic;

namespace TaskSetSolution
{
    // Сиквел.
    // У Склад.LIFE большое количество различных складов с различными видами товаров.
    // Руководству важно знать, какие виды товаров находятся на различных складах. Помогите Склад.LIFE. 
    // P.S. В последнее время с заказами все плохо, поэтому на склад только завозят новые виды товаров.
    //
    // На вход программе поступают следующие запросы:
    // 1) add <storage_name> <product_name> - добавить вид товара на склад.
    // 2) get <storage_name> - получить список всех видов товаров на складе.
    // 3) exist <storage_name> <product_name> - узнать находится ли вид товара на складе.
    // 4) exit - завершить программу.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RedisClient.Connect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            while (true)
            {
                Console.WriteLine("Input: ");
                string command = Console.ReadLine();

                string[] words = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name;
                switch (words[0])
                {
                    case ("add"):
                        name = words[1];
                        string version = words[2];
                        RedisClient.Add(name, version);
                        //Console.WriteLine("Version added");
                        break;
                    case ("exist"):
                        name = words[1];
                        string product = words[2];
                        bool result = RedisClient.ExistProduct(name, product);
                        Console.WriteLine(result);
                        break;
                    case ("get"):
                        name = words[1];
                        List<string> resultTwo = RedisClient.GetProducts(name);
                        foreach (string s in resultTwo)
                            Console.WriteLine(s);
                        break;
                    case ("exit"):
                        return;
                    default:
                        Console.WriteLine("Incorrect query");
                        break;

                }
            }

        }
    }
}