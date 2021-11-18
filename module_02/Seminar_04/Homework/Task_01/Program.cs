using System;
using System.Collections.Generic;

namespace Task_01
{
    public abstract class Something
    {
        double someWeight = 0;
        double someVolume = 0;

        public virtual double GetWeight
        {
            get
            {
                return this.someWeight;
            }
        } 
        
        public virtual double GetVolume
        {
            get
            {
                return this.someVolume;
            }
        }
    }

    public class Lentil : Something
    {
        private Random rnd = new Random();
        double Weight;
        public Lentil()
        {
            Weight = (double)rnd.Next(2001) / 1000;
        }

        public override double GetWeight
        {
            get
            {
                return this.Weight;
            }
        }
    }

    public class Ashes : Something
    {
        private Random rnd = new Random();
        double Volume;
        public Ashes()
        {
            Volume = (double)rnd.Next(1001) / 1000;
        }

        public override double GetVolume
        {
            get
            {
                return this.Volume;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);
            var array = new Something[N];
            var rand = new Random();
            for(int i = 0; i < N; i++)
            {
                int getType = rand.Next(2);
                if (getType == 0)
                    array[i] = new Ashes();
                else
                    array[i] = new Lentil();
            }

            var ashes = new List<Something>();
            var lentil = new List<Something>();

            foreach(Something i in array)
            {
                if(i is Lentil)
                {
                    Console.Write(i.GetWeight + " ");
                    lentil.Add(i);
                }
                else if(i is Ashes)
                {
                    Console.Write(i.GetVolume + " ");
                    ashes.Add(i);
                }
            }

            Console.WriteLine();
            Console.Write("Lentil: ");
            foreach(Something item in lentil)
            {
                Console.Write(item.GetWeight + " ");
            }
            Console.WriteLine();
            Console.Write("Ashes: ");
            foreach(Something item in ashes)
            {
                Console.Write(item.GetVolume + " ");
            }
            Console.WriteLine();
        }
    }
}
