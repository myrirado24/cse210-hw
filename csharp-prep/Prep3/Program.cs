using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("What is the magic number?");
        string magicNumber = Console.ReadLine();
        int magicNumber2 = int.Parse(magicNumber);


        Console.WriteLine("What is the magic number?");
        string guess = Console.ReadLine();
        int guess2 = int.Parse(guess);

        if (guess2 > magicNumber2)
        {
            Console.WriteLine("Lower");
        }
        else if (guess2 < magicNumber2)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Correct");
        }
    }
}