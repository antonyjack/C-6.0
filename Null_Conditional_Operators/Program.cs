using System;

namespace Null_Conditional_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = null;
            string Name = person?.FirstName;//Person object is null
            Console.WriteLine($"{nameof(Name)} is : {Name}");
            Name = person?.FirstName ?? "Null object";//Assign default value if object is null
            Console.WriteLine($"{nameof(Name)} is : {Name}");
            person = new Person();
            Name = person?.FirstName ?? "Null object";//Assign default values if property is null
            Console.WriteLine($"{nameof(Name)} is : {Name}");
            person.FirstName = "James";
            Name = person?.FirstName ?? "Null object";//If value present, value is assigned to the variable
            Console.WriteLine($"{nameof(Name)} is : {Name}");
            person.FirstName = string.Empty;
            Name = person?.FirstName ?? "Null object";//If value is empty, value is assigned to the variable as empty
            Console.WriteLine($"{nameof(Name)} is : {Name}");

            Person person1 = null;
            Console.WriteLine($"Name is : {person1?.ConvertToUpper()}");
            person1 = new Person();
            person1.FirstName = "James";
            Console.WriteLine($"Name is : {person1?.ConvertToUpper()}");
        }
    }

    class Person
    {
        public string FirstName { get; set; }

        public string ConvertToUpper() => FirstName.ToUpper();
    }
}
