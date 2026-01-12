using System;

namespace Adapter
{
    public class Club
    {
        public void CheckEntrance(Adult person)
        {
            Console.WriteLine($"Bramkarz sprawdza {person.Name}..");
            person.ShowID();
            if (person.IsAdult())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bramkarz wpuszcza {person.Name}.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Bramkarz nie wpuszcza {person.Name}.");
                Console.ResetColor();
            }
        }
    }
}