using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            TextureFactory factory = new TextureFactory();
            List<GameUnit> units = new List<GameUnit>();
            SharedTexture treeTexture = factory.GetTexture("Tree.png");
            units.Add(new GameUnit("Świerk", 10, 15, treeTexture));
            units.Add(new GameUnit("Jodła", 15, 20, treeTexture));
            units.Add(new GameUnit("Sosna", 25, 30, treeTexture));
            SharedTexture goblinTexture = factory.GetTexture("Goblin.png");
            units.Add(new GameUnit("Goblin Alfred", 100, 100, goblinTexture));
            units.Add(new GameUnit("Goblin Edward", 120, 100, goblinTexture));
            SharedTexture extraTreeTexture = factory.GetTexture("Tree.png");
            units.Add(new GameUnit("Modrzew", 231, 420, extraTreeTexture));
            Console.WriteLine("\nRENDEROWANIE:");
            foreach (var unit in units)
            {
                unit.Draw();
            }
            Console.ReadKey();
        }
    }
}