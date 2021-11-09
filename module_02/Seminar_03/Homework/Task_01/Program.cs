using System;
using System.Text;

namespace Task_01_5_
{
    class VideoFile
    {
        private string _name;
        private int _duration;
        private int _quality;

        public VideoFile(string name, int duration, int quality)
        {
            this._name = name;
            this._duration = duration;
            this._quality = quality;
        }

        public int Size
        {
            get
            {
                return (this._duration * this._quality);
            }
        }

        public string GetInfo()
        {
            return $"Имя: {this._name}, длительность: {this._duration}, качество: {this._quality}, размер: {this.Size}";
        }
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            var file = new VideoFile("example", 120, 150);
            var rand = new Random();
            var files = new VideoFile[rand.Next(5, 16)];
            var nextName = new StringBuilder("");
            for(int i = 0; i < files.Length; i++)
            {
                nextName.Clear();
                for(int j = 1; j<=rand.Next(2, 10); j++)
                {
                    nextName.Append((char)rand.Next(65, 91));
                }
                files[i] = new VideoFile(nextName.ToString(), rand.Next(60, 361), rand.Next(100, 1001));
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(file.GetInfo());
            Console.ResetColor();
            for(int i = 0; i < files.Length; i++)
            {
                if(files[i].Size > file.Size)
                {
                    Console.WriteLine(files[i].GetInfo());
                }
            }
            //65 91
        }
    }
}
