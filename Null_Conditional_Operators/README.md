# Null-conditional operators

> Null values are complicated code. You need to check every access to ensure that object is not `null`. The *null conditional operators* makes those checks easier and fluid.

> Earlier version you was checked to ensure the object is not `null` with the help of `if` or `ternary operator`

> Example
```C#
//if condition
string Name;
if(student != null)
    Name = student.Name;

//ternary operator
string Name = student != null ? student.Name : null;
```

> Now, we can simply replace the member access with the help of `.` and `?.`
```C#
var name = student?.Name;
```
> In the preceding example, the variable `name` is assigned `null` if the student object is `null`. Otherwise, it gets assigned the value of the `Name`.

> You can often use this construct with the null coalescing operator to assign default values when one of the
properties are `null`

```C#
string Name = person?.Name?? "Default";
````