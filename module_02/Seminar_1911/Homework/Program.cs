using System;
using System.Text;
using System.Collections.Generic;

namespace Homework_from1911
{
    public class Person
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Person(string name)
        {
            Name = name;
        }

        public string pocket;

        public virtual void Receive(string present)
        {
            if (String.IsNullOrEmpty(pocket))
            {
                pocket = present;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }

    public class SnowMaiden : Person
    {
        public SnowMaiden(string name) : base(name) { }
        
        public string[] CreatePresents(int amount)
        {
            var rnd = new Random();
            var sb = new StringBuilder();
            var res = new List<string>();
            for(int i = 0; i < amount; i++)
            {
                sb.Clear();
                char a = (char)rnd.Next(100), b = (char)rnd.Next(100), c = (char)rnd.Next(100);
                sb.Append(a);
                sb.Append(b);
                sb.Append(c);
                sb.Append(b);
                sb.Append(a);
                res.Add(sb.ToString());
            }

            return res.ToArray();
        }

        public new void Receive(string present) => base.Receive(present);
    }

    public class Santa : Person
    {
        public Santa(string name) : base(name) { }

        public List<string> sack = new List<string>();

        public void Request(SnowMaiden sm, int amount)
        {
            string[] presents = sm.CreatePresents(amount);
            foreach(string present in presents)
            {
                sack.Add(present);
            }
        }

        public void Give(Person person)
        {
            if(sack.Count == 0)
            {
                throw new OutOfMemoryException();
            }
            else
            {
                var rnd = new Random();
                int number = rnd.Next(sack.Count);
                string present = sack[number];
                sack.RemoveAt(number);
                person.Receive(present);
            }
        }
        public new void Receive(string present) => base.Receive(present);

    }

    public class Child : Person
    {
        public Child(string name) : base(name) { }

        string additionalPocket;

        public new void Receive(string present)
        {
            if (String.IsNullOrEmpty(this.pocket))
            {
                pocket = present;
            }
            else if (String.IsNullOrEmpty(additionalPocket))
            {
                additionalPocket = present;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    
    
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            Santa S = new Santa("Santa");
            SnowMaiden SM = new SnowMaiden("Snow Maiden");
            S.Request(SM, 5);
            list.Add(S);
            list.Add(SM);
            for(int i = 0; i < 10; i++)
            {
                list.Add(new Child(i.ToString()));
            }

            var rnd = new Random();
            bool flag = true;
            while (flag)
            {
                if (list.Count == 1 && list[0] is Santa)
                    break;
                int next = rnd.Next(10);
                if(next == 0)
                {
                    try
                    {
                        Console.WriteLine(list[0]);
                        S.Give(list[0]);
                        bool flag2 = true;
                        foreach(Person p in list)
                        {
                            if (p is SnowMaiden)
                            {
                                flag2 = false;
                                break;
                            }
                        }
                        if (!flag2)
                        {
                            var r = new Random();
                            S.Request(SM, r.Next(1, 4));
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
                else
                {
                    int forWho = rnd.Next(1, list.Count);
                    try
                    {
                        Console.WriteLine(list[forWho]);
                        S.Give(list[forWho]);
                        bool flag2 = true;
                        foreach (Person p in list)
                        {
                            if (p is SnowMaiden)
                            {
                                flag2 = false;
                                break;
                            }
                        }
                        if (!flag2)
                        {
                            var r = new Random();
                            S.Request(SM, r.Next(1, 4));
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        break;
                    }
                    catch (ArgumentException)
                    {
                        list.RemoveAt(forWho);
                    }
                }
            }

        }
    }
}
