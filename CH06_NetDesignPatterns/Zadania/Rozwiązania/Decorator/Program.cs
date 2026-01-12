using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop myShop = new Shop();
            myShop.ProcessOrder(214.35);
            Console.ReadKey();
        }
    }
}