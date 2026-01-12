using System;

namespace Builder
{
    public interface IWarrior
    {
        string Name { get; }
        string Weapon { get; set; }
        string Action { get; set; }
        void Introduce();
    }
    public class Warrior : IWarrior
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public string Action { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"JEDNOSTKA: {Name} ; POBRANA BROŃ: {Weapon} ; TYP TRENINGU: {Action}");
        }
    }
    public class Infantry : Warrior
    {
        public Infantry() { Name = "Piechur"; }
    }
    public class Archer : Warrior
    {
        public Archer() { Name = "Strzelec"; }
    }
    public class Cavalry : Warrior
    {
        public Cavalry() { Name = "Konny"; }
    }
}