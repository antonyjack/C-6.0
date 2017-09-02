## Index initializer

> We can define `dictionary` initializer like an array  using square brackets.

```C#
Dictionary<string,string> Obj = new Dictionary<string,string>
{
    ["First"] = "First Message",
    ["Second"] = "Second Message"
};

//Old way to initialize dictionary
Dictionary<string,string> Obj = new Dictionary<string,string>
{
    {"First","First Message"},
    {"Second","Second Message"}
};
```