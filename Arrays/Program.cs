/*
  * Arrays have a fixed size.
  * Lists can grow and shrink.
  * Lists are more flexible than arrays.
  * Lists are more flexible than arrays.
*/

int[] numbers = new int[3];

for (int i = 0; i < numbers.Length; i++)
{
  string? userInput = string.Empty;
  bool isInt = false;
  while (string.IsNullOrEmpty(userInput) && !isInt)
  {
    Console.Write($"Enter a number for index {i} : ");
    userInput = Console.ReadLine();
    if (int.TryParse(userInput, out int result))
    {
      isInt = true;
      numbers[i] = result;
    }
    else
    {
      userInput = null;
      Console.WriteLine("Invalid input");
    }
  }
}


int[] numbersArray = [5, 8, 3, 9, 1, 6, 7, 2, 4];
Array.Sort(numbersArray);
foreach (int num in numbersArray) Console.Write($"{num} | ");
Console.WriteLine();

Array.Reverse(numbersArray);
foreach (int num in numbersArray) Console.Write($"{num} | ");
Console.WriteLine();
Array.Reverse(numbersArray);

Console.Write("Enter a number to search: ");
int search = Convert.ToInt32(Console.ReadLine());
int position = Array.IndexOf(numbersArray, search);

if (position != -1) Console.WriteLine($"Number in position {position}: {numbersArray[position]}");
else Console.WriteLine($"Number {search} was not found");


Array.Clear(numbersArray);

// #################### Lists

List<int> listNumbers = [];
listNumbers.Add(5);
listNumbers.Add(8);
listNumbers.Add(3);

void ArrayOfMultiples()
{
  int qty = 7;
  int length = 5;
  int[] result = new int[length];
  int counter = 0;

  for (int i = 1; i <= result.Length; i++, counter++)
  {
    result[counter] = qty * i;
  }

  foreach (int num in result) Console.Write($"{num} ");
}

ArrayOfMultiples();