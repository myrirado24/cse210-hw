using System;

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
    }
}