using System;

namespace Expression_bodied_function_members
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "James";
            employee.LastName = "Raj";

            Console.WriteLine($"{employee.FullName}");
            Console.WriteLine($"{employee.FullNameToUpper()}");
        }
    }
}
