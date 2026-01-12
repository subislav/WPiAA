using System;

namespace Adapter
{
    public class Adult
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual bool IsAdult()
        {
            return Age >= 18;
        }
        public virtual void ShowID()
        {
            Console.WriteLine($"Dowód osobity: {Name}, {Age} lat");
        }
    }
    public class Teenager
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Teenager(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}