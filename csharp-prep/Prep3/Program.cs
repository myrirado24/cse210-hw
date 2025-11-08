using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Console.WriteLine("What is the magic number?");
        //string magicNumber = Console.ReadLine();
        //int magicNumber2 = int.Parse(magicNumber);

        int guess = -1;

        while (guess != magicNumber2)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber2)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber2)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}