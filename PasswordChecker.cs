using System;
namespace tools;
{
class Program
{
    static void Main()
    {
      // Defining standards for the password
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "#!%$&+-*/?";

      // Asking the user for a password
      Console.WriteLine("Please enter a password: ");
      string userPassword = Console.ReadLine();

      // Declaring a variable for the score of the password
      int score = 0;

      // if the password is longer than minLength, add a point to score
      if (userPassword.Length >= minLength)
      {
        score++;
      }

      // if the password contains uppercase letters, add a point to score
      if (Tools.Contains(userPassword, uppercase))
      {
        score++;
      }

      // if the password contains lowercase letters, add a point to score
      if (Tools.Contains(userPassword, lowercase))
      {
        score++;
      }

      // if the password contains digits, add a point to score
      if (Tools.Contains(userPassword, digits))
      {
        score++;
      }

      // if the password contains special characters, add a point to score
      if (Tools.Contains(userPassword, specialChars))
      {
        score++;
      }

      // checks if the password == "1234" or "password", if true, set score = 0
      if (userPassword == "1234" || userPassword == "password")
      {
        score = 0;
      }

      Console.WriteLine(score);

      Console.ReadLine();

      switch (score)
      {
        case 4:
        case 5:
          Console.WriteLine("Your password is: Extremely strong");
          break;
        case 3:
          Console.WriteLine("Your password is: Strong");
          break;
        case 2:
          Console.WriteLine("Your password is: Medium");
          break;
        case 1:
          Console.WriteLine("Your password is: Weak");
          break;
      default:
          Console.WriteLine("Your password doesn't meet the standards!");
          break;
      }
    }
  }
}