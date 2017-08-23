using static System.Console;
using static System.String;

namespace Using_Static_Enhancement
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");//Static console methods.

            Employee employee = new Employee();
            if(IsNullOrEmpty(employee.Name))//Static string methods.
                WriteLine($"{nameof(employee.Name)} property is null.");
        }
    }

    class Employee
    {
        public string Name { get; set; }
    }
}
