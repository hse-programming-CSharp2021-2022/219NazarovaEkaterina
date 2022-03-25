using System;

namespace Homework_7
{
    struct Person : IComparable<Person>
    {
        string Name;
        string LastName;
        int Age;

        public Person(string name, string lastname, string age)
        {
            if (!int.TryParse(age, out int goodage) || goodage < 0)
                throw new ArgumentOutOfRangeException("Некорректный возраст! Введите снова.");
            (Name, LastName, Age) = (name, lastname, goodage);
        }

        public int CompareTo(Person other)
        {
            if (Age > other.Age) return 1;
            else if (Age == other.Age) return 0;
            else return -1;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Lastname: {LastName}, Age: {Age}";
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Anastasia", "Anna", "Jane", "Helen", "Lucy", 
                "Leo", "Den", "Alex", "Andrew", "George", "Mark" };
            string[] lastnames = { "Smith", "Brown", "Holmes", "Beggins", "Lotto", 
                "Walker", "Lee", "Chen", "White", "O'Brien", "Reed", "McLauren" };

            Random ran = new();
            int n = int.Parse(Console.ReadLine());
            Person[] characters = new Person[n];
            for(int i = 0; i < n; i++)
            {
                characters[i] = new Person(names[ran.Next(12)], lastnames[ran.Next(12)], ran.Next(1, 101).ToString());
            }

            Console.WriteLine();
            Array.Sort(characters);
            foreach (Person p in characters)
                Console.WriteLine(p);

        }
    }
}
