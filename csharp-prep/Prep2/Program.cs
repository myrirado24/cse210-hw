using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade?");
        string grade = Console.ReadLine();
        int persent = int.Parse(grade);

        string letter = "";

        if (persent >= 90)
        {
            letter = "A";
        }
        else if (persent >= 80)
        {
            letter = "B";
        }
        else if (persent >= 70)
        {
            letter = "C";
        }
        else if (persent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (persent >= 70)
        {
            Console.WriteLine("You passed the class!!!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. :(");
        }

    }
}