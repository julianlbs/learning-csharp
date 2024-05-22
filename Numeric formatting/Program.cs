using System.Globalization;

namespace NumericFormatting
{
  class Program
  {
    static void Main(string[] args)
    {
      double money = -10D / 3D;
      Console.WriteLine(money);
      Console.WriteLine(string.Format("-£10 / £3 = £{0:0.00}", money));
      Console.WriteLine(money.ToString("C"));
      Console.WriteLine(money.ToString("C0"));

      Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

      bool success = false;

      while (!success)
      {
        Console.WriteLine("Enter a number");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int num))
        {
          Console.WriteLine(num);
          success = true;
        }
        else
        {
          Console.WriteLine("Invalid input");
        }
      }
    }
  }
}