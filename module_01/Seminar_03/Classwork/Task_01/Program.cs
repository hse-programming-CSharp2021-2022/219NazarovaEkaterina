using System;

namespace Task_1
{
    class Program
    {

        public static void Func1(bool a, bool b, out bool res)
        {
            res = (!(a & b) & !(a | !b));
        }
        public static bool Func2(bool a, bool b)
        {
            return (!(a & b) & !(a | !b));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" P  Q  F1(P, Q)  F2(P, Q)");
            int i, j, ires1, ires2;
            bool p, q, r1, r2;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    p = i == 0 ? false : true;
                    q = j == 0 ? false : true;
                    Func1(p, q, out r1);
                    r2 = Func2(p, q);
                    ires1 = r1 == true ? 1 : 0;
                    ires2 = r2 == true ? 1 : 0;
                    Console.WriteLine(" {0}  {1}     {2}         {3}", i, j, ires1, ires2);
                }
            }
        }
    }
}
