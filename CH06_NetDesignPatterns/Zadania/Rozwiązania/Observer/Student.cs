using System;

namespace Observer
{
    public class Student : IStudentObserver
    {
        public string Name { get; private set; }
        public Student(string name)
        {
            Name = name;
        }
        public void ReceiveGrade(int grade)
        {
            if (grade >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Student {Name} otrzymał/a {grade} i zaliczył/a przedmiot.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Student {Name} otrzymał/a {grade} i musi poprawiać przedmiot.");
            }
            Console.ResetColor();
        }
    }
}