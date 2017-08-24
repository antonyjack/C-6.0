# Auto-Property Enhancements

## Read-only auto-properties

> Read-only auto property provide more easiest way to create immutable type. You can get immutable type in  C# earlier version was to declare private setters.

```C#
public string Name { get; private set; }
```

> To enable true read-only behavior, you declare auto-property with only get accessor.

```C#
public string Name { get; }
```

> Read-only auto property can be set only in the constructor. 

```C#
public class Student
{
    public Student(string name)
    {
        this.Name = name;
    }

    public string Name { get; }
}
```

> Trying to set `Name` in another method generates a `CS0200` complilation error.

```C#
public class Student
{
    public Student(string name)
    {
        this.Name = name;
    }

    public string Name { get; }

    public void ChangeName(string newName) 
    {
        //Generates CS 0200: Property or indexer cannot be assigned to -- it is read only
        this.Name = newName;
    }
}
```

## Auto-Property Initializers

> You declare the initial value(inital value/ default value) for an auto-property as part of declaration. In the earlier version you should set the values in constractor method.

> How to initialize collection object?
```C#
public List<int> Numbers {get;set;} = new List<int>();
```

> Hot to set default value for auto-property?
```C#
public string Name {get;set;} = "James";
```