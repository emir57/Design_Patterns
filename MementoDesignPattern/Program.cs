using System;

namespace MementoDesignPattern
{
    //Originator Class
    class GameWorld
    {
        public string Name { get; set; }
        public long Population { get; set; }

        public GameWorldMemento Save()
        {
            return new GameWorldMemento
            {
                Name = this.Name,
                Population = this.Population
            };
        }
        public void Undo(GameWorldMemento memento)
        {
            this.Name = memento.Name;
            this.Population = memento.Population;
        }
        public override string ToString()
        {
            return $"World Name:{Name} ,Population:{Population}";
        }
    }
    //Memento Class
    class GameWorldMemento
    {
        public string Name { get; set; }
        public long Population { get; set; }

    }
    //Caretaker Class
    class GameWorldCareTaker
    {
        public GameWorldMemento World { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GameWorld ascent = new GameWorld() { Name="Ascent",Population=1000};
            GameWorldCareTaker taker = new GameWorldCareTaker();
            taker.World = ascent.Save();
            ascent.Population = 5654564234;
            Console.WriteLine(ascent.ToString());
            ascent.Undo(taker.World);
            Console.WriteLine(ascent.ToString());
        }
    }
}
