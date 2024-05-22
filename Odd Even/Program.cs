namespace Exercise
{
  class Program
  /*
    * Create & initialize two ints
    * Make a variable to work out the remainder
    * Output the result to the console
    * Change the first int to a different number
      * And recalculate the remainder
      * Output the new result to the console
  */
  {
    static void Main(string[] args)
    {
      int num1 = 5;
      int num2 = 3;
      int remainder = num1 % num2;
      Console.WriteLine($"Remainder: {remainder}");

      num1 = 7;
      remainder = num1 % num2;
      Console.WriteLine($"New Remainder: {remainder}");

      Console.WriteLine("Hello! my name is Julian.");
      Console.Write("Enter your name: ");
      string? name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}!");
    }
  }
}