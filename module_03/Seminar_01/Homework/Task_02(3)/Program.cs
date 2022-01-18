using System;

namespace Task_02_3_
{
    class Program
    {

        public delegate double DelegateConvertTemperature(double t);

        class TemperatureConverterImp
        {
            public double FromCelToFar(double t)
            {
                return (9.0 / 5.0) * t + 32;
            }

            public double FromFarToCel(double t)
            {
                return (5.0 / 9.0) * (t - 32); 
            }
        }

        static class StaticTempConverters
        {
            public static double FromCelToKel(double t)
            {
                return t + 273.15;
            }

            public static double FromKelToCel(double t)
            {
                return t - 273.15;
            }

            public static double FromCelToRank(double t)
            {
                TemperatureConverterImp a = new();
                return (a.FromCelToFar(t)) + 459.67; 
            }

            public static double FromRankToCel(double t)
            {
                TemperatureConverterImp a = new();
                return a.FromFarToCel(t - 459.67);
            }

            public static double FromCelToReo(double t)
            {
                return (4.0 / 5.0) * t;
            }

            public static double FromReoToCel(double t)
            {
                return (5.0 / 4/0) * t;
            }
        }
        
        static void Main(string[] args)
        {
            TemperatureConverterImp temp = new();
            DelegateConvertTemperature fromFtoC = temp.FromFarToCel;
            DelegateConvertTemperature fromCtoF = temp.FromCelToFar;
            Console.WriteLine(fromCtoF(0));
            Console.WriteLine(fromFtoC(0));

            DelegateConvertTemperature[] array1 = { fromCtoF, fromFtoC };

            DelegateConvertTemperature fromCtoK = StaticTempConverters.FromCelToKel;
            DelegateConvertTemperature fromCtoRa = StaticTempConverters.FromCelToRank;
            DelegateConvertTemperature fromCtoReo = StaticTempConverters.FromCelToReo;

            DelegateConvertTemperature[] array2 = { fromCtoF, fromCtoK, fromCtoRa, fromCtoReo };
            double.TryParse(Console.ReadLine(), out double t);

            for(int i = 0; i < array2.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Фаренгейты: ");
                        break;
                    case 1:
                        Console.Write("Кельвины: ");
                        break;
                    case 2:
                        Console.Write("Ранкины: ");
                        break;
                    case 3:
                        Console.Write("Реомюры: ");
                        break;
                }
                Console.WriteLine(array2[i](t));
            }
        }
    }
}
