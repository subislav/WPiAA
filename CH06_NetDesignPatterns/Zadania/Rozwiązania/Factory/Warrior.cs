using System;

namespace Factory
{
    public abstract class Warrior
    {
        public string Name { get; set; }
        public void Introduce()
        {
            Console.WriteLine($"{Name}");
        }
    }
    public class Infantry : Warrior
    {
        public Infantry()
        {
            Name = "Piechur";
        }
    }
    public class Archer : Warrior
    {
        public Archer()
        {
            Name = "Strzelec";
        }
    }
    public class Cavalry : Warrior
    {
        public Cavalry()
        {
            Name = "Konny";
        }
    }
}