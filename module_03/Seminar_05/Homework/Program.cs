using System;

namespace Homework_5
{
    public interface IFunction
    {
        public double Function(double x);
    }

    public delegate double Calculate(double x);

    class F : IFunction
    {

        public F(Calculate c) => calculate = c; 
        public Calculate calculate { get; set; }

        public double Function(double x)
        {
            return calculate.Invoke(x);
        }
    }

    class G
    {
        public G(F f, F g) => (_fx, _gx) = (f, g);
        
        F _fx, _gx;

        public double GF(double x0) => _gx.Function(_fx.Function(x0));
    }

    class Program
    {


        static void Main(string[] args)
        {
            F f1 = new((x) => x * x - 4);
            F f2 = new((x) => Math.Sin(x));

            G g = new(f2, f1);

            for(int i = 0; i <= 16; i++)
            {
                Console.WriteLine($"{i} * pi / 16:\t{g.GF(i * Math.PI / 16):F4}");
            }
        }
    }
}
