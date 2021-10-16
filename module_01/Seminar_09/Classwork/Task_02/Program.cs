using System;
using System.Text;

namespace Task_02
{
    class Program
    {
        public static string ConvertHexToBin(string Hex)
        {
            StringBuilder b = new StringBuilder("");
            for(int i = 0; i<Hex.Length; i++)
            {
                switch (Hex[i])
                {
                    case '1':
                        b.Append("0001");
                        break;
                    case '2':
                        b.Append("0010");
                        break;
                    case '3':
                        b.Append("0011");
                        break;
                    case '4':
                        b.Append("0100");
                        break;
                    case '5':
                        b.Append("0101");
                        break;
                    case '6':
                        b.Append("0110");
                        break;
                    case '7':
                        b.Append("0111");
                        break;
                    case '8':
                        b.Append("1000");
                        break;
                    case '9':
                        b.Append("1001");
                        break;
                    case 'A':
                        b.Append("1010");
                        break;
                    case 'B':
                        b.Append("1011");
                        break;
                    case 'C':
                        b.Append("1100");
                        break;
                    case 'D':
                        b.Append("1101");
                        break;
                    case 'E':
                        b.Append("1110");
                        break;
                    case 'F':
                        b.Append("1111");
                        break;
                }
            }
            return b.ToString();
        }
        
        static void Main(string[] args)
        {
            string Hex = Console.ReadLine();
            Console.WriteLine(ConvertHexToBin(Hex));
        }
    }
}
