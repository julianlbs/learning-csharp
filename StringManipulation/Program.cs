namespace StringManipulation;

class Program
{
  static void Main(string[] args)
  {
    string message = "Hello";
    char[] chars = ['H', 'e', 'l', 'l', 'o'];
    object newCompare = new string(chars);

    if (message.Equals(newCompare)) Console.WriteLine("Same");
    else Console.WriteLine("Different");

    string newMessage = "C# is awesome";
    foreach (char c in newMessage)
    {
      Console.Write(c);
      Thread.Sleep(250);
    }

    Console.WriteLine();
    Console.WriteLine($"contains: {newMessage.Contains('C')}");

    string? name = null;
    if (string.IsNullOrEmpty(name)) Console.WriteLine("Is Null or Empty");
    else Console.WriteLine("Has Value");

    string? userMessage = null;

    while (string.IsNullOrEmpty(userMessage))
    {
      Console.Write("Enter your message: ");
      userMessage = Console.ReadLine();
    }

    Console.Write("message in reverse: ");
    for (int i = userMessage.Length - 1; i >= 0; i--)
    {
      Console.Write(userMessage[i]);
    }
    Console.WriteLine("");
  }
}