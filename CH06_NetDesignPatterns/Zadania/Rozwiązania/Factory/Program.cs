using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Garrison garrison = new Garrison();
            Warrior[] army = new Warrior[10];
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                army[index] = garrison.TrainWarrior("infantry");
                index++;
            }
            for (int i = 0; i < 3; i++)
            {
                army[index] = garrison.TrainWarrior("cavalry");
                index++;
            }
            for (int i = 0; i < 4; i++)
            {
                army[index] = garrison.TrainWarrior("archer");
                index++;
            }
            Console.WriteLine("Tablica jednostek:");
            foreach (var soldier in army)
            {
                if (soldier != null)
                {
                    soldier.Introduce();
                }
            }
            Console.ReadKey();
        }
    }
}