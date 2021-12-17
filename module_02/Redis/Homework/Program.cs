using System;

namespace TaskListSolution
{
    // Сиквел.
    // Разработчики из HSE company просят доработать ваше приложение!
    // Дело в том, что разработчики тоже ошибаются, и приходится откатывать приложение к предыдущей версии.
    // К тому же, HSE company не хочет расходовать много памяти,
    // поэтому было принято решение хранить только определенное колличество последних версий приложений.
    // 
    // На вход программе подаются запросы следующего типа:
    // 1) add <application_name> <version> - добавить актуальную версию приложения.
    // 2) back <application_name> - откатить приложение до предыдущей версии. Если предыдущей нет, то удалить приложение.
    // 3) get <application_name> - получить актуальную версию приложения. Если приложения нет, то сообщить об этом.
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
                    case ("back"):
                        name = words[1];
                        string result = RedisClient.Back(name);
                        Console.WriteLine(result);
                        break;
                    case ("get"):
                        name = words[1];
                        string resultTwo = RedisClient.Get(name);
                        Console.WriteLine(resultTwo);
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