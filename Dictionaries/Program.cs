Dictionary<int, string> names = new()
{
  { 1, "Aba"  },
  { 2, "Test" },
  { 3, "Test2" }
};

// for (int i = 0; i < names.Count; i++)
// {
//   KeyValuePair<int, string> item = names.ElementAt(i);
//   Console.WriteLine($"id: {item.Key} | name: {item.Value}");
// }

foreach (KeyValuePair<int, string> item in names)
{
  Console.WriteLine($"id: {item.Key} | name: {item.Value}");
}

Dictionary<string, string> teachers = new()
{
  { "Math", "Aba"},
  { "Science", "Test" },
  { "English", "Test2" }
};

if (teachers.TryGetValue("Math", out string? teacher)) Console.WriteLine(teacher);
else Console.WriteLine("Math teacher not found");

if (teachers.Remove("Math")) Console.WriteLine("Math teacher Removed");
else Console.WriteLine("Math teacher not found to remove");

foreach (var item in teachers)
{
  Console.WriteLine($"id: {item.Key} | name: {item.Value}");
}