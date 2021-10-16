using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i;
            int.TryParse(s, out i);
            switch (i)
            {
                case <=3:
                    Console.WriteLine("неудовлетворительно");
                    break;
                case <= 5:
                    Console.WriteLine("удовлетворительно");
                    break;
                case <=7:
                    Console.WriteLine("удовлетворительно");
                    break;
                case <= 10:
                    Console.WriteLine("отлично");
                    break;
                default:
                    Console.WriteLine("нет такой оценки");
                    break;
            }
        }
    }
}
