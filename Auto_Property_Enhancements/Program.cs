using System;

namespace Auto_Property_Enhancements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee = new Employee("James");
                Console.WriteLine($"Name of the employee is : {employee.Name}");
                //employee.Name = "New Name"; //Build error throws, because setter property is inaccessible

                Student student = new Student("Antony");
                Console.WriteLine($"Name of the student is : {student.Name}");
                //student.Name = "New Name"; //Build error throws, because setter property is read only

                //To get initialized values from class object
                Console.WriteLine($"Surname of the employee is : {employee.SurName}");
                Console.WriteLine($"Surname of the student is : {student.SurName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }            
        }
    }
}
