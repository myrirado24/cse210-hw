using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade?");
        string grade = Console.ReadLine();
        int persent = int.Parse(grade);
    
        if (persent >= 90)
        {
            Console.WriteLine("A");
        }
    

    }
}