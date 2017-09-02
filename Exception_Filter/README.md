## Exception Filters

> Exception filter allows you to check an if condition before reach catch block with the help of `when` operator.

```C#
try
{...}
catch(Exception ex) when (ex.Message.Contains("300"))
{
    //catch only 300 message error
    //Do work
}
```

> You can try one or more catch filters. You can execute methods inside `when` statement, but the method should be return boolean value.
If the method returns `true` then it reach the catch block. If the method return `false` then the flow never reach catch block.

```C#
public static bool LogMessage(this Exception ex)
{
    //Do Work here
    return false;
}

try
{
    ....
}
catch(Exception ex) when (ex.Message.Contains("400"))
{

}
catch(Exception ex) when (ex.LogMessage())
{
    //Never reached this block
}
```