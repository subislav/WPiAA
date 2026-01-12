using System;

namespace Composite
{
    public class MenuItem : MenuComponent
    {
        public double Price { get; set; }
        public MenuItem(string name, double price) : base(name)
        {
            Price = price;
        }
        public override void Display(int depth)
        {
            string indent = new String(' ', depth);
            Console.WriteLine($"{indent} {Name} ({Price} PLN)");
        }
    }
}