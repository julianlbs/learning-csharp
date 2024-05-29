namespace PasswordChecker;

class Program
{
  /**
    * Ask user to enter password, and store it
    * Ask user to enter password again, and store it
    * Check if they both contain something
      * If so, check if they are the same
        * If they are, print "Passwords match"
        * If they are not, print "Passwords do not match"
      * If they are empty, print "Please enter a password
  */
  static void Main(string[] args)
  {
    string? password = string.Empty;
    string? passwordConfirm = string.Empty;

    while (string.IsNullOrEmpty(password))
    {
      Console.Write("Enter your password: ");
      password = Console.ReadLine();
    }

    while (string.IsNullOrEmpty(passwordConfirm))
    {
      Console.Write("Confirm your password: ");
      passwordConfirm = Console.ReadLine();
    }

    if (password.Equals(passwordConfirm)) Console.WriteLine("Passwords match");
    else Console.WriteLine("Passwords do not match");
  }
}