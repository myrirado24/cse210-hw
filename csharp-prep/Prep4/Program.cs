using System;
using System.Collections.Generic;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            //Console.WriteLine("Enter number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int Sum = 0;
        foreach (int number in numbers)
        {
            Sum += number;
        }
        Console.WriteLine($"The sume is: {Sum}");

        //double ListAverage = numbers.Average();
        //Console.WriteLine($"The average is: {ListAverage}");

        //int maximunNumber = numbers.Max();
        //Console.WriteLine($"The largest number is: {maximunNumber}");
    }
}