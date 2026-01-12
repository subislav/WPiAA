using System;
using System.Collections.Generic;

namespace Bridge
{
    public interface IUserInterface
    {
        void DisplayMenu(string systemName, List<string> programs);
    }
    public class GraphicInterface : IUserInterface
    {
        public void DisplayMenu(string systemName, List<string> programs)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"╔══════════════════════════════════════╗");
            Console.WriteLine($"║  MENU START {systemName}             ║");
            Console.WriteLine($"╠══════════════════════════════════════╣");
            foreach (var prog in programs)
            {
                Console.WriteLine($"║  [Ikona] {prog,-27} ║");
            }
            Console.WriteLine($"╚══════════════════════════════════════╝");
            Console.ResetColor();
        }
    }
    public class TextInterface : IUserInterface
    {
        public void DisplayMenu(string systemName, List<string> programs)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($">>> {systemName} Command Line <<<");
            Console.WriteLine("Installed packages:");
            foreach (var prog in programs)
            {
                Console.WriteLine($"- {prog}");
            }
        }
    }
}