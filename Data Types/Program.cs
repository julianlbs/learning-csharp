
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      string? userInput = Console.ReadLine();
      Console.WriteLine("You entered: " + userInput);

      // ############################# NUMBER TYPES

      int age = 23;
      Console.WriteLine(age);
      Console.WriteLine("Int max value: " + int.MaxValue);
      Console.WriteLine("Int min value: " + int.MinValue);

      long bigNumber = 90000000L;
      Console.WriteLine(bigNumber);

      double negative = -55.2D;
      Console.WriteLine(negative);
      Console.WriteLine("Double max value: " + double.MaxValue);
      Console.WriteLine("Double min value: " + double.MinValue);

      float precision = 5.000001f;
      Console.WriteLine(precision);
      Console.WriteLine("Float max value: " + float.MaxValue);
      Console.WriteLine("Float min value: " + float.MinValue);

      decimal money = 14.99M;
      Console.WriteLine(money);
      Console.WriteLine("Decimal max value: " + decimal.MaxValue);
      Console.WriteLine("Decimal min value: " + decimal.MinValue);

      /*
        Seeing the difference between the types is important when working with numbers.
        int, long, double, float, and decimal all have different ranges of values that can be used.
        The int type is limited to a 32-bit range, while long is 64-bit.
        The double type is limited to a 64-bit range, while float is 32-bit.
        The decimal type is limited to a 128-bit range, while float is 32-bit.
      */

      int x = 10,
          y = 20,
          z = 30;
      Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);

      // ############################# STRINGS
      string name = "John";
      Console.WriteLine(name);
      char letter = 'A';
      Console.WriteLine(letter);

      // ############################# TYPE CONVERTIONS
      string textAge = "-23";
      int age2 = Convert.ToInt32(textAge);
      Console.WriteLine(age2);

      // ############################# BOOLS
      bool isMale = true;
      Console.WriteLine("isMale: " + isMale);
    }
  }
}