using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- ZADANIE: ADAPTER (FAŁSZYWY DOWÓD) ---\n");
            Club club = new Club();
            Teenager krzys = new Teenager("Krzyś", 17);
            Console.WriteLine("Symulacja uczciwego Krzysia:");
            Adult honestKrzys = new Adult { Name = krzys.Name, Age = krzys.Age };
            club.CheckEntrance(honestKrzys);
            Console.WriteLine("Krzyś używa fałszywki:");
            Adult fakeID = new FakeAdult(krzys);
            club.CheckEntrance(fakeID);
            Console.ReadKey();
        }
    }
}