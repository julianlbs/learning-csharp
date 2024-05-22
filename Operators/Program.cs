namespace Operations
{
  class Program
  {
    static void Main(string[] args)
    {
      int age = 24;
      age++;
      age--;
      Console.WriteLine(age);

      age *= 10;
      Console.WriteLine(age);

      // If you need to do a division, it's better to use double, because otherwise you'll get a truncated integer result.
      double sampleNumber = 20;
      sampleNumber /= 3;
      Console.WriteLine(sampleNumber);

      Console.WriteLine(10 % 3);

      var age2 = 32;
      Console.WriteLine(++age2);

      const int VAT = 20; // constant variables can't be changed
      Console.WriteLine(VAT);
    }
  }
}