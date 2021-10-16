using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            for(int i = 0; i < 100; i++)
            {
                array[i] = i + 1;
            }
            Random rand = new Random();
            int prom1 = 0, prom2 = 1;
            while(prom1 != prom2)
            {
                prom1 = rand.Next(0, 100);
                prom2 = rand.Next(0, 100);
            }
            array[prom1] = array[prom2];
            int sum1 = array[0], prom, res = 5050;
            for(int i = 1; i < 100; i++)
            {
                prom = sum1 ^ array[i];
                if(sum1 == prom)
                {
                    res = array[i];
                }
                sum1 = prom;


                //if (a^sum = sum) -------------
                // !!!!!        a^b^a = b;     !!!!!!!
            }
            Console.WriteLine(res);

        }
    }
}
