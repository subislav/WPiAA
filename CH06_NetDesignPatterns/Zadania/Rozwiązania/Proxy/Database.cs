using System;

namespace Proxy
{
    public interface IDatabase
    {
        void DisplayData();
    }
    public class PublicDatabase : IDatabase
    {
        public void DisplayData()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dane ogólnodostępne:" +
                "\nGdańsk to polskie miasto." +
                "\nBerlin znajduje się w Niemczech.");
            Console.ResetColor();
        }
    }
    public class SecretDatabase : IDatabase
    {
        public void DisplayData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dane zastrzeżone:" +
                "\nStudiuję na WWSI." +
                "\nW wolnym czasie programuję.");
            Console.ResetColor();
        }
    }
}