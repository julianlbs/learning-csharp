namespace CustomTryParse;

class Program
{
  /*
    * Create a custom try parse function
    * Find the real function and copy return type/params
    * Read the tooltip it gives you, to give you ideas on what to do
  */
  static void Main(string[] args)
  {
    bool success = false;
    while (!success)
    {
      Console.Write("Enter a number: ");
      string? input = Console.ReadLine();
      if (!string.IsNullOrEmpty(input) && TryParse(input, out int num))
      {
        success = true;
        Console.WriteLine(num);
      }

    }
  }

  static bool TryParse(string input, out int result)
  {
    result = -1;
    try
    {
      result = Convert.ToInt32(input);
      return true;
    }
    catch (Exception)
    {
      return false;
    }
  }
}