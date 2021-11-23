using System;
using System.Text;

namespace Task_01
{
    public class Creature
    {
        string name;
        double speed;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value[0] == value.ToUpper()[0])
                {
                    name = value;
                }
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if(value >= 0)
                {
                    speed = value;
                }
            }
        }


        public string Run()
        {
            return $"I am running with a speed of {this.Speed}. ";
        }

        public override string ToString()
        {
            return (this.Run() + $"My name is {this.Name}. ");
        }

        public Creature(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }
    }


    public class Dwarf : Creature
    {
        int strength;

        public int Strength
        {
            get
            {
                return this.strength;
            }
            set
            {
                if(value >= 1 && value <= 20)
                {
                    strength = value;
                }
                else
                {
                    var rnd = new Random();
                    strength = rnd.Next(1, 21);
                }
            }
        }


        public new string Run()
        {
            return $"I am running with a speed of {this.Speed}. My strength is {this.Strength}. ";
        }

        public string MakeNewStaff()
        {
            return "I've created a new staff!";
        }

        public Dwarf(string name, double speed, int strength) :base(name, speed)
        {
            Strength = strength;
        }

        public override string ToString()
        {
            return (this.Run() + $"My name is {this.Name}.");
        }
    }

    public class Elf : Creature
    {
        int age;
        static int ageWhenSpeedIncrease;

        public Elf(string name, double speed, int ageWhen=77) : base(name, speed)
        {
            var rnd = new Random();
            this.age = rnd.Next(100, 201);
            ageWhenSpeedIncrease = ageWhen;
        }

        public new string Run()
        {
            return $"I am running with a speed of {this.Speed + age / ageWhenSpeedIncrease}. My age is {age}. ";
        }

        public override string ToString()
        {
            return (this.Run() + $"My name is {this.Name}. ");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if(n <= 100)
                    {
                        break;
                    }
                }
            }

            var mas = new Creature[n];
            var rnd = new Random();
            var sb = new StringBuilder();
            for(int i = 0; i < n; i++)
            {
                sb.Clear();
                int k = rnd.Next(1, 11);
                int sp = rnd.Next(10, 18);
                int str = rnd.Next(-50, 51);
                sb.Append((char)rnd.Next((int)'A', (int)'Z' + 1));
                int count = rnd.Next(3, 11);
                for(int j = 0; j < count; j++)
                {
                    int t = rnd.Next(0, 2);
                    if(t == 0)
                    {
                        sb.Append((char)rnd.Next((int)'a', (int)'z' + 1));
                    }
                    else
                    {
                        sb.Append((char)rnd.Next((int)'A', (int)'Z' + 1));
                    }
                }

                if(k == 1 || k == 2)
                {
                    mas[i] = new Creature(sb.ToString(), sp);
                }
                else if(k == 3 || k == 4 || k == 5 || k == 6)
                {
                    mas[i] = new Dwarf(sb.ToString(), sp, str);
                }
                else
                {
                    mas[i] = new Elf(sb.ToString(), sp);
                }
            }

            foreach(Creature pers in mas)
            {
                Console.WriteLine(pers);
            }
            foreach(Creature pers in mas)
            {
                if(pers is Dwarf)
                {
                    Console.WriteLine((pers as Dwarf).MakeNewStaff());
                }
            }
        }
    }
}
