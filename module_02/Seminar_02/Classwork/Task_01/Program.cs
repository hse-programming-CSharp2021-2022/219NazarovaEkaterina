using System;

namespace Task_01
{

    class MyComplex
    {
        public double re, im;
        public MyComplex(double xre, double xim)
        { re = xre; im = xim; }
        public static MyComplex operator ++(MyComplex mc)
        { return new MyComplex(mc.re + 1, mc.im + 1); }
        public static MyComplex operator --(MyComplex mc)
        { return new MyComplex(mc.re - 1, mc.im - 1); }
        public double Mod() { return Math.Abs(re * re + im * im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
        public static MyComplex operator + (MyComplex first, MyComplex second)
        {
            return new MyComplex(first.re + second.re, first.im + second.im);
        }
        public static MyComplex operator - (MyComplex first, MyComplex second)
        {
            return new MyComplex(first.re - second.re, first.im - second.im);
        }
        public static MyComplex operator * (MyComplex first, MyComplex second)
        {
            return new MyComplex(first.re * second.re - first.im * second.im, first.im * second.re + first.re * second.im);
        }
        public static MyComplex operator / (MyComplex first, MyComplex second)
        {
            return new MyComplex((double)(first.re * second.re + first.im * second.im) / (double)(second.re * second.re + second.im * second.im),
                (double)(first.im * second.re - first.re * second.im) / (double)(second.re * second.re + second.im * second.im));
        }
        public override string ToString()
        {
            return $"{this.re} + ({this.im})i";
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            var a = new MyComplex(1, 2);
            var b = new MyComplex(2, 3);
            Console.WriteLine(a.ToString());
            Console.WriteLine((b).ToString());
            Console.WriteLine((a + b).ToString());
            Console.WriteLine((b - a).ToString());
            Console.WriteLine((a * b).ToString());
            Console.WriteLine((b / a).ToString());
        }
    }
}
