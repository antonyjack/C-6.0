## Await in Catch and Finally blocks

> In C# 5 we don’t allow the `await` keyword in catch and finally blocks, because we’d somehow convinced ourselves that it wasn’t possible to implement. Now we’ve figured it out, so apparently it wasn’t impossible after all.

> In C# 6 we do implement the `await` keyword in catch and finally blocks.

```C#
public static async Task<string> Test()
{
    await AsyncMethodStartLog();
    try
    {                
        throw new Exception("200 error");
    }
    catch (Exception ex) when (ex.Message.Contains("200"))
    {
        await LogError("Custom error",ex);
        return "Success";            
    }
    finally
    {
        await AsyncMethodEndLog();
    }
}

public static async Task AsyncMethodStartLog()
{
    Console.WriteLine("Method start..");
}

public static async Task AsyncMethodEndLog()
{
    Console.WriteLine("Method end..");
}

public static async Task LogError(string message, Exception ex)
{
    Console.WriteLine($"{message}, {ex.Message}");
}
```