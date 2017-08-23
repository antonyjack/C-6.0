using System;

namespace Expression_bodied_function_members
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{LastName}, {FirstName}";//Expression bodied function implementation in property level

        public string FullNameToUpper() => FullName.ToUpper();//Expression bodied function implementation in method level
    }
}