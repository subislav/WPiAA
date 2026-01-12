using System;
using System.Collections.Generic;

namespace Composite
{
    public class MenuCategory : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        public MenuCategory(string name) : base(name) { }
        public void Add(MenuComponent component)
        {
            _menuComponents.Add(component);
        }
        public void Remove(MenuComponent component)
        {
            _menuComponents.Remove(component);
        }
        public override void Display(int depth)
        {
            string indent = new String(' ', depth);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{indent} [{Name.ToUpper()}]");
            Console.ResetColor();
            foreach (var component in _menuComponents)
            {
                component.Display(depth + 3);
            }
        }
    }
}