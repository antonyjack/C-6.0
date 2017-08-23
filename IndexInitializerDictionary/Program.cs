using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IndexInitializerDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> Obj = new Dictionary<string,string>
            {
                ["First"] = "First Message",
                ["Second"] = "Second Message"
            };
            Console.WriteLine(Obj["First"]);

            var entrollment = new Enrollment();

            entrollment.Add(new Student("A"));
            entrollment.Add(new Student("B"));

            Console.WriteLine($"{entrollment.Length()}");

            Task.Run(Log);
        }
            
        static Task Log()
        {
            Console.WriteLine("Hello World");
            return Task.FromResult(0);
        }
    }

    class Student
    {
        public Student(string name) => Name = name;
        public string Name{get;set;}
    }

    class Enrollment
    {
        private List<Student> _allStudents = new List<Student>();

        public void Enroll(Student s) => _allStudents.Add(s);

        public int Length() => _allStudents.Count;
    }

    static class StudentExtension
    {
        public static void Add(this Enrollment e, Student s) => e.Enroll(s);
    }
}
