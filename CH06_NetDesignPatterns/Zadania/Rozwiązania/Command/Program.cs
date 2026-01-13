using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            SantaClausFactory factory = new SantaClausFactory();
            SantaHelper elf = new SantaHelper();
            ICommand order1 = new ToyCommand(factory, "Zestaw małego chemika");
            ICommand order2 = new ToyCommand(factory, "Klocki LEGO");
            ICommand order3 = new ToyCommand(factory, "Samochód zdalnie sterowany");
            ICommand punishment = new StickCommand(factory, "Koszmarny Karolek");
            elf.SetCommand(order1);
            elf.PressButton();
            elf.SetCommand(order2);
            elf.PressButton();
            elf.SetCommand(order3);
            elf.PressButton();
            elf.SetCommand(punishment);
            elf.PressButton();
            Console.ReadKey();
        }
    }
}