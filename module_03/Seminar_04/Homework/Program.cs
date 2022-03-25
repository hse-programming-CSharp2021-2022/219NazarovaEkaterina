using System;

namespace Homework_4
{
    class RingIsFoundEventArgs : EventArgs
    {
        public string Message { get; set; }

        public RingIsFoundEventArgs(string message) => Message = message;
    }
    
    abstract class Existance
    {
        public Existance(string name) => Name = name;

        public string Name { get; set; }

        //public EventHandler<RingIsFoundEventArgs> RingIsFoundEventHandler;

        public abstract void Handler(object sender, RingIsFoundEventArgs info);
    }

    class Wizard : Existance
    {
        public Wizard(string name) : base(name) { }

        public event EventHandler<RingIsFoundEventArgs> RingIsFoundEvent;

        public override void Handler(object sender, RingIsFoundEventArgs info)
        {
            Console.WriteLine($"Wizard {Name}. Destination: {info.Message}");
        }

        public void FindRing(string destination) => RingIsFoundEvent.Invoke(this, new RingIsFoundEventArgs(destination));

    }

    class Dwarf : Existance
    {
        public Dwarf(string name) : base(name) { }

        public override void Handler(object sender, RingIsFoundEventArgs info)
        {
            Console.WriteLine($"Dwarf {Name}. Destination: {info.Message}");
        }
    }

    class Elf : Existance
    {
        public Elf(string name) : base(name) { }

        public override void Handler(object sender, RingIsFoundEventArgs info)
        {
            Console.WriteLine($"Elf {Name}. Destination: {info.Message}");
        }
    }

    class Human : Existance
    {
        public Human(string name) : base(name) { }

        public override void Handler(object sender, RingIsFoundEventArgs info)
        {
            Console.WriteLine($"Human {Name}. Destination: {info.Message}");
        }
    }

    class Hobbit : Existance
    {
        public Hobbit(string name) : base(name) { }

        public override void Handler(object sender, RingIsFoundEventArgs info)
        {
            Console.WriteLine($"Hobbit {Name}. Destination: {info.Message}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Wizard Hendalf = new("Hendalf");
            Hobbit Frodo = new("Frodo");
            Hobbit Sam = new("Sam");
            Hobbit Pipin = new("Pipin");
            Hobbit Marry = new("Marry");
            Human Aragorn = new("Aragorn");
            Human Boromir = new("Boromir");
            Dwarf Gimly = new("Gimly");
            Elf Legolas = new("Legolas");

            Hendalf.RingIsFoundEvent += Frodo.Handler;
            Hendalf.RingIsFoundEvent += Sam.Handler;
            Hendalf.RingIsFoundEvent += Pipin.Handler;
            Hendalf.RingIsFoundEvent += Marry.Handler;
            Hendalf.RingIsFoundEvent += Aragorn.Handler;
            Hendalf.RingIsFoundEvent += Boromir.Handler;
            Hendalf.RingIsFoundEvent += Gimly.Handler;
            Hendalf.RingIsFoundEvent += Legolas.Handler;

            Hendalf.FindRing("Mordor");
        }
    }
}
