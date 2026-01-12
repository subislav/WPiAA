using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWybierz pozycję:");
                Console.WriteLine("1. Dostęp do bazy danych");
                Console.WriteLine("2. Wyjście");
                string choice = Console.ReadLine();
                if (choice == "2") break;
                if (choice == "1")
                {
                    Console.Write("Podaj hasło:");
                    string inputPassword = Console.ReadLine();
                    IDatabase databaseHandle = new DatabaseProxy(inputPassword);
                    databaseHandle.DisplayData();
                }
            }
        }
    }
}