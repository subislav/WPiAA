using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfejs graficzny Windows:");
            SystemBase myWindows = new WindowsSystem(new GraphicInterface());
            myWindows.OpenMenu();
            Console.WriteLine("Interfejs konsolowy Linux:");
            SystemBase myLinux = new LinuxSystem(new TextInterface());
            myLinux.OpenMenu();
            Console.WriteLine("Interfejs graficzny Linux:");
            myLinux.SetInterface(new GraphicInterface());
            myLinux.OpenMenu();
            Console.ReadKey();
        }
    }
}