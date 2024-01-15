using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the password: ");
        string password = Console.ReadLine();

        bool isValid = IsPasswordValid(password);

        Console.WriteLine("Password is valid: " + isValid);
    }

    static bool IsPasswordValid(string password)
    {
        if (password.Length < 6 || password.Length > 16)
        {
            return false;
        }

        if (!password.Any(char.IsLower) || !password.Any(char.IsUpper) ||
            !password.Any(char.IsDigit) || !password.Any(c => "$#@".Contains(c)))
        {
            return false;
        }

        return true;
    }
}