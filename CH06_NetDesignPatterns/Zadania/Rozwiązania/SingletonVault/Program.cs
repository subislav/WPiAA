using System;

namespace SingletonVault
{
    class Program
    {
        static void Main(string[] args)
        {
            Vault vault1 = Vault.GetInstance();
            Console.WriteLine($"Zwrócenie klucza #1: {vault1.GetAccessKey()}");
            Vault vault2 = Vault.GetInstance();
            Console.WriteLine($"Zwrócenie klucza #2: {vault2.GetAccessKey()}");
            Console.ReadKey();
        }
    }
}