bool looping = true;

while (looping)
{
  try
  {
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num);
    looping = false;
  }
  catch (OverflowException e)
  {
    Console.WriteLine($"{e.Message}\nPlease enter a number under 2 billion!");
  }
  catch (FormatException e)
  {
    Console.WriteLine($"{e.Message}\nPlease only enter numbers!");
  }
  catch (Exception e)
  {
    Console.WriteLine($"Error: {e}");
  }
}