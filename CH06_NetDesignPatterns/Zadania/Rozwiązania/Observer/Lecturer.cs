using System;
using System.Collections.Generic;

namespace Observer
{
    public class Lecturer
    {
        private Dictionary<IStudentObserver, int> _gradeBook = new Dictionary<IStudentObserver, int>();
        public void AddStudent(IStudentObserver student, int grade)
        {
            if (!_gradeBook.ContainsKey(student))
            {
                _gradeBook.Add(student, grade);
                Console.WriteLine($"Wykładowca dodaje studenta {student.Name} do listy.");
            }
        }
        public void RemoveStudent(IStudentObserver student)
        {
            _gradeBook.Remove(student);
        }
        public void AnnounceResults()
        {
            Console.WriteLine("\nWyniki egzaminu:\n");
            foreach (var entry in _gradeBook)
            {
                IStudentObserver student = entry.Key;
                int grade = entry.Value;
                student.ReceiveGrade(grade);
            }
        }
    }
}