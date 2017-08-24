# Expression-bodied function members

> The body of a lot of members that we write consist of only one statement that can be represented as an expression.
You can reduce that syntax by writing an expression-bodied member instead. It works for methods and read-only
properties.

> Method:
```C#
public class Student
{
    public string FirstName {get; set;}
    public string LastName {get;set;}

    public string GetFullName() => $"{this.LastName} {this.FirstName}";
}
```

> Members:
```C#
public class Student
{
    public string FirstName {get; set;}
    public string LastName {get;set;}
    public string FullName => $"{this.LastName} {this.FirstName}"; //read-only auto-property
}
```