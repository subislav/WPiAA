using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecturer lecturer = new Lecturer();
            Student s1 = new Student("Jan Kowalski");
            Student s2 = new Student("Anna Nowak");
            Student s3 = new Student("Karol Wiśniewski");
            lecturer.AddStudent(s1, 5);
            lecturer.AddStudent(s2, 2);
            lecturer.AddStudent(s3, 4);
            lecturer.AnnounceResults();
            Console.ReadKey();
        }
    }
}