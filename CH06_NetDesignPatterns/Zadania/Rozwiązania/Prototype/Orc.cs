using System;

namespace Prototype
{
    public class Orc
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public void ShowStats()
        {
            Console.WriteLine($"Ork: {Name} ; Siła: {Strength} ; Życie: {Health}");
        }
    }
}