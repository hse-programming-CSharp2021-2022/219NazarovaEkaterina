using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_01
{
    class MyOwnException : Exception
    {
        public MyOwnException() : base() { }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var myArray = new int[] { 1, 2, 3 };
                Console.WriteLine(myArray[100]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Case 1: it's IndexOutOfRangeException");
            }

            //try
            //{
            //    string s = null;
            //    s.ToString();
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("Case 2: ");
            //}

            try
            {
                int i = 0;
                Console.WriteLine(15 / i);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Case 2: it's DivideByZeroException");
            }

            try
            {
                string digit = "some digit";
                int dig = int.Parse(digit);
            }
            catch (FormatException)
            {
                Console.WriteLine("Case 3: it's FormatException");
            }

            try
            {
                File.ReadAllLines("non-existentFile.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Case 4: it's FileNotFoundException");
            }

            try
            {
                string incorrect = "**t";
                Regex exception = new Regex(incorrect);
            }
            catch(RegexParseException)
            {
                Console.WriteLine("Case 5: it's RegexParseException");
            }

            try
            {
                ForException(null);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Case 6: it's ArgumentNullException");
            }

            try
            {
                DateTime date = new DateTime(10000, 1, 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Case 7: it's ArgumentOutOfRangeException");
            }

            try
            {
                int overflow = 12000;
                byte l = checked((byte)(overflow + 1));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Case 8: it's OverflowException");
            }

            try
            {
                string res = new string('-', 2000000000);
                res = res + res;
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Case 9: it's OutOfMemoryException");
            }

            try
            {
                Directory.GetFiles("XAR:\\");
            }
            catch (IOException)
            {
                Console.WriteLine("Case 10: it's IOException");
            }
            try
            {
                throw new MyOwnException();
            }
            catch (MyOwnException)
            {
                Console.WriteLine("Case 11: it's MyOwnException");
            }


        }

        public static void ForException(string s)
        {
            int i = int.Parse(s);
        }

        public static void ForExceptionTwo(int[][] array)
        {
            return;
        }
    }
}
