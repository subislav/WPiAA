using System;

namespace Composite
{
    public abstract class MenuComponent
    {
        public string Name { get; set; }
        public MenuComponent(string name)
        {
            Name = name;
        }
        public abstract void Display(int depth);
    }
}