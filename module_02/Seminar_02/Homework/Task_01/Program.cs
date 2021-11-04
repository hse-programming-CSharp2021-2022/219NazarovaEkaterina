using System;

namespace Task_01
{
    public class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor;
        private ConsoleColor _backColor;

        public ConsolePlate()
        {
            this.PlateChar = 'A';
            this.PlateColor = ConsoleColor.White;
            this.BackColor = ConsoleColor.DarkMagenta;
        }
        public ConsolePlate(char someChar, ConsoleColor someColor, ConsoleColor backColor)
        {
            this.PlateChar = someChar;
            this.PlateColor = someColor;
            this.BackColor = backColor;
        }

        public char PlateChar
        {
            get
            {
                return this._plateChar;
            }
            set
            {
                if (value >= 65 && value < 90)
                    this._plateChar = value;
                else
                    this._plateChar = 'A';
            }
        }

        public ConsoleColor PlateColor
        {
            get
            {
                return this._plateColor;
            }
            set
            {
                this._plateColor = value;
            }
        }

        public ConsoleColor BackColor
        {
            get
            {
                return this._backColor;
            }
            set
            {
                if(value == this._plateColor)
                {
                    if (this._plateColor == ConsoleColor.Black)
                        this._backColor = ConsoleColor.White;
                    else
                        this._backColor = ConsoleColor.Black;
                }
                else
                {
                    this._backColor = value;
                }
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 5. Задание к задаче 5 см. ниже
            ConsolePlate[] plates = new ConsolePlate[20];
            for(int i = 0; i < 20; i++)
            {
                if(i < 5)
                {
                    plates[i] = new ConsolePlate();
                }
                else if(i < 10)
                {
                    plates[i] = new ConsolePlate((char)i, ConsoleColor.Red, ConsoleColor.DarkBlue);
                }
                else if(i < 15)
                {
                    plates[i] = new ConsolePlate((char)(i + 20), ConsoleColor.Green, ConsoleColor.DarkGray);
                }
                else
                {
                    plates[i] = new ConsolePlate((char)(i + 20), ConsoleColor.Cyan, ConsoleColor.Black);
                }
            }
            for(int i = 0; i < 20; i++)
            {
                Console.ForegroundColor = plates[i].PlateColor;
                Console.BackgroundColor = plates[i].BackColor;
                Console.Write($"{plates[i].PlateChar} ");
            }
            Console.ResetColor();

            // Задание к задаче 5:
            ConsolePlate x = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate o = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            int n = 0;
            while(!(n >=2 && n < 35))
            {
                Console.WriteLine("Введите n от 2 до 35");
                int.TryParse(Console.ReadLine(), out n);
            }
            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j<=n; j++)
                {
                    if (i % 2 == j % 2)
                    {
                        Console.ForegroundColor = x.PlateColor;
                        Console.BackgroundColor = x.BackColor;
                        Console.Write(x.PlateChar);
                    }
                    else
                    {
                        Console.ForegroundColor = o.PlateColor;
                        Console.BackgroundColor = o.BackColor;
                        Console.Write(o.PlateChar);
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
