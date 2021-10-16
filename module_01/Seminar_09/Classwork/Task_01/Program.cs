using System;
using System.Text;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string charss = "aAeEiIoOuUyY";
            StringBuilder builder = new StringBuilder("");
            char[] delimiters = new char[] { ';' };
            char[] delimiter2 = new char[] { ' ' };
            string[] splitLine = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i< splitLine.Length; i++)
            {
                string[] splitTense = splitLine[i].Split(delimiter2, StringSplitOptions.RemoveEmptyEntries);
                for(int j = 0; j < splitTense.Length; j++)
                {
                    for(int k = 0; k<splitTense[j].Length; k++)
                    {
                        if (k == 0)
                            builder.Append(splitTense[j][k].ToString().ToUpper());
                        if (charss.Contains(splitTense[j][k]))
                        {
                            Console.WriteLine(builder.ToString());
                            break;
                        }
                    }
                }
            }
        }
    }
}
