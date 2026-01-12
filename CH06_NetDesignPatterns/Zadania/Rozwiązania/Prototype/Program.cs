using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc prototypeOrc = new Orc
            {
                Name = "Uruk-hai",
                Strength = 10,
                Health = 100
            };
            prototypeOrc.ShowStats();
            Console.WriteLine("Klony:");
            List<Orc> army = new List<Orc>();
            Random random = new Random();
            int rnd = random.Next(3, 10);
            for (int i = 0; i < rnd; i++)
            {
                string jsonString = JsonConvert.SerializeObject(prototypeOrc);
                Orc clonedOrc = JsonConvert.DeserializeObject<Orc>(jsonString);
                clonedOrc.Name = $"{prototypeOrc.Name} - Klon #{i + 1}";
                clonedOrc.Strength = random.Next(4, 16);
                clonedOrc.Health = random.Next(60, 150);
                army.Add(clonedOrc);
            }
            foreach (var orc in army)
            {
                orc.ShowStats();
            }
            Console.ReadKey();
        }
    }
}