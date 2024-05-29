## Verbatim string literal

To ignore special caracters like \t and \n you can use \*\*@\*\* before the string:

```csharp
Console.WriteLine(@"C:\Users\Julian\Desktop")
```

Normally, the \ would not be printed, but using the @, all special caracters are treated like normal caracter.
