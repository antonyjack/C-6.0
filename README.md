# C# 6.0

## New features in C# 6.0

1. **Read-Only Auto-Properties**
    - Create readonly properties without private setter method.  [Reference](https://github.com/antonyjack/C-6.0/tree/master/Auto_Property_Enhancements)  
2. **Auto Property Initializers**
    - We can declare the default value for an auto property as part of the property declaration. [Reference](https://github.com/antonyjack/C-6.0/tree/master/Auto_Property_Enhancements)
3. **Expression-bodied function members**
    - We can create one line method using lambda expression. [Reference](https://github.com/antonyjack/C-6.0/tree/master/Expression_bodied_function_members)
4. **Using static**
    - using static enhancement enables to import the static method of a single class. Previously using statemenet imported all types in a namespace.
    ```C#
    using System;
    using static System.Console; //Static methods are imported from Console class.

    public class Program()
    {
        public static void main(string args[])
        {
            WriteLine("Enter your name");//Static method invoking.
            string Name = ReadLine();
            WriteLine($"Hai {Name}");
        }
    }
    ```
5. **Null - conditional operators**
    - Concisely and safely access members of an object while still checking for null with the null
conditional operator. [Reference](https://github.com/antonyjack/C-6.0/tree/master/Null_Conditional_Operators)
6. **String Interpolation**
    - We can write string formatting expressions using inline expressions instead of positional arguments. [Reference](https://github.com/antonyjack/C-6.0/tree/master/Interpolation)

    > This feature is enables you to embed the expressions in the format string. Simple prefrence the string is `$`

    ```C#
    public string Fullname => "{firstname} {lastname}"; // variable expression
    ```
    > You can also implement the method level expression.

    ```C#
    public string GetFormatted(string firstName, string lastName) => $"Welcome {firstName} {lastName}.";
    ```
    > you can also implement the lambda expression and method invocation.

    ```C#
    public string FormattedString() => $"Name {firstname}, {lastname}. Rank : {Student.GetRank()}";
    ```

7. **Exception Filters**
    - Catch expressions based on properties of the exception. [Reference](https://github.com/antonyjack/C-6.0/tree/master/Exception_Filter)
8. **Expressions nameof()**
    - Compiler generate string representations of symbols.
    ```C#
    public class Employee
    {
        public string Name {get;set;}   
        ...
    }
    //To get the name of the Employee object with the help of `nameof()` expression.
    Employee emp = new Employee();
    emp.Name = "James";
    string Name = nameof(emp.Name) //it returns `Name` as string value instead of `James`.
    ```
9. **Await in Catch and Finally blocks**
    - We can use `await` in `catch` and `finally` blocks. [Reference](https://github.com/antonyjack/C-6.0/tree/master/AwaitInCatchAndFinallyBlocks)
10. **Index Initializers**
    - Dictionary initializer
    - Extension `Add` methods in collection initializers
    - [Reference](https://github.com/antonyjack/C-6.0/tree/master/IndexInitializerDictionary)