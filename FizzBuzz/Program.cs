/**
  Create a for loop from 1 to X (15)
  3 and 5 = FizzBuzz
  3 = Fizz
  5 = Buzz
  else = number
 */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool threeDiv = false;
bool fiveDiv = false;

for (int i = 0; i <= number; i++)
{
  threeDiv = i % 3 == 0;
  fiveDiv = i % 5 == 0;
  if (threeDiv && fiveDiv) Console.WriteLine("FizzBuzz");
  else if (threeDiv) Console.WriteLine("Fizz");
  else if (fiveDiv) Console.WriteLine("Buzz");
  else Console.WriteLine(i);
}