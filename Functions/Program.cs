using System.Runtime.InteropServices;

namespace Functions;

class Program
{
  static void Main(string[] args)
  {
    int result = Add(5);
    Console.WriteLine(result);

    string nameInput = "Aba";
    int ageInput = 23;
    string addressInput = "1 Something Road";

    // Using named parameters
    PrintDetails(
      age: ageInput,
      name: nameInput,
      address: addressInput
    );

    // Out parameters
    Test(out int num);
    Console.WriteLine(num);

    // Ref params
    int num2 = 10;
    Assign(ref num2);
    Console.WriteLine(num2);
  }

  // When you set a function argument to optional, you can omit it from the call.
  // The default value of the argument is used in this case.
  static int Add(int a, [Optional] int b)
  {
    Console.WriteLine($"b = {b}");
    return a + b;
  }

  static void PrintDetails(string name, int age, string address)
  {
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Address: {address}");
  }

  static void Test(out int num)
  {
    num = 5;
  }

  static void Assign(ref int num)
  {
    num = 15656;
  }
}