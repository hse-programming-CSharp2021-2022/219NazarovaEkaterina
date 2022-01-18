using System;

namespace Task_01_6_
{
    class Program
    {
        
        class Plant
        {
            private double growth;
            private double photosensivity;
            private double frostresistance;

            public Plant(double gr, double pho, double fro)
            {
                growth = gr;
                photosensivity = ConvertToGood(pho);
                frostresistance = ConvertToGood(fro);
            }

            private double ConvertToGood(double t)
            {
                if(t < 0)
                {
                    while (t < 0)
                        t += 100;
                }
                else if( t > 100)
                {
                    while (t > 100)
                        t -= 100;
                }
                return t;
            }

            public double Growth
            {
                get { return growth; }
            }

            public double Photosensivity
            {
                get { return photosensivity; }
            }

            public double Frostresistance
            {
                get { return frostresistance; }
            }

            public override string ToString()
            {
                return $"Growth: {Growth}, Photosensivity: {Photosensivity}, Frostresistance: {Frostresistance}";
            }
        }
        
        static void Main(string[] args)
        {
            Random ran = new();
            int.TryParse(Console.ReadLine(), out int n);
            Plant[] array = new Plant[n];
            for(int i = 0; i < n; i++)
            {
                double man1 = ran.NextDouble();
                double man2 = ran.NextDouble();
                double man3 = ran.NextDouble();
                double gr = ran.Next(25, 100) + man1;
                double pho = ran.Next(0, 100) + man2;
                double fro = ran.Next(0, 80) + man3;
                array[i] = new Plant(gr, pho, fro);
            }

            Action<Plant> write = x => Console.WriteLine(x);
            Array.ForEach(array, write);
            Console.WriteLine();

            Array.Sort(array, delegate (Plant x, Plant y)
            {
                if (x.Growth > y.Growth)
                    return -1;
                else if (x.Growth == y.Growth)
                    return 0;
                else
                    return 1;
            });
            Array.ForEach(array, write);
            Console.WriteLine();

            Array.Sort(array, (Plant x, Plant y) =>
            {
                if (x.Frostresistance < y.Frostresistance)
                    return -1;
                else if (x.Frostresistance == y.Frostresistance)
                    return 0;
                else return 1;
            });
            Array.ForEach(array, write);
            Console.WriteLine();

            Comparison<Plant> byPhoto = (Plant x, Plant y) =>
            {
                if (x.Photosensivity % 2 != 0 && y.Photosensivity % 2 == 0)
                    return 1;
                else if (x.Photosensivity % 2 == y.Photosensivity % 2)
                    return 0;
                else return -1;
            };
            Array.Sort(array, byPhoto);
            Array.ForEach(array, write);
            Console.WriteLine();

            Converter<Plant, Plant> con = (Plant x) =>
            {
                if (x.Frostresistance % 2 == 0)
                    return new Plant(x.Growth, x.Photosensivity, x.Frostresistance / 3);
                else
                    return new Plant(x.Growth, x.Photosensivity, x.Frostresistance / 2);
            };
            Plant[] array2 = Array.ConvertAll(array, con);
            Array.ForEach(array2, write);
        }
    }
}
