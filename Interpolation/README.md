**String Interpolation**

> We can write string formatting expressions using inline expressions instead of positional arguments.

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