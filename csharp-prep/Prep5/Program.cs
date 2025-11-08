using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcomeMessage();

        string userName = PromptUserName;
        int userNumber = PromptUserNumber;

        int squaredNumber = SquareNumber(userNumber);
        
        int birthYear;
        PromtUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("Please enterthe year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
}