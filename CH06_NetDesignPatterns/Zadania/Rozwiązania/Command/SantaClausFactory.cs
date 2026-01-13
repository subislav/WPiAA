using System;

namespace Command
{
    public class SantaClausFactory
    {
        public void ProduceToy(string toyName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Wyprodukowano zabawkę: {toyName}");
            Console.ResetColor();
        }
        public void ProduceStick(string childName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wyprodukowano RÓZGĘ dla: {childName}");
            Console.ResetColor();
        }
    }
}