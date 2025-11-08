using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Console.WriteLine("What is the magic number?");
        //string magicNumber = Console.ReadLine();
        //int magicNumber2 = int.Parse(magicNumber);

        Random random = new Random();
        int magicNumber = random.Next(1, 100);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
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