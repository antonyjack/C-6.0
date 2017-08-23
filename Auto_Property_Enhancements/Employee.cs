using System;

namespace Auto_Property_Enhancements
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
            this.SurName = "Raj"; //This is the old way to initialize the property
        }

        //This is the old way to hiding setter property
        public string Name {get;private set;}

        public string SurName {get;}
    }

    public class Student
    {
        public Student(string name)
        {
            this.Name = name;
        }

        //This is new way to hiding setter property.
        //This feature is implemented in C# 6.0
        public string Name {get;}

        public string SurName {get;} = "Joseph"; //This is the new way to initialize the property
    }
}