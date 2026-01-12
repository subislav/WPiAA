using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Garrison garrison = new Garrison();
            var infantryBuilder = new InfantryBuilder();
            var archerBuilder = new ArcherBuilder();
            var cavalryBuilder = new CavalryBuilder();
            List<IWarrior> army = new List<IWarrior>();
            for (int i = 0; i < 2; i++)
            {
                garrison.TrainWarrior(infantryBuilder);
                army.Add(infantryBuilder.GetWarrior());
            }
            for (int i = 0; i < 2; i++)
            {
                garrison.TrainWarrior(cavalryBuilder);
                army.Add(cavalryBuilder.GetWarrior());
            }
            for (int i = 0; i < 2; i++)
            {
                garrison.TrainWarrior(archerBuilder);
                army.Add(archerBuilder.GetWarrior());
            }
            foreach (var warrior in army)
            {
                warrior.Introduce();
            }
            Console.ReadKey();
        }
    }
}