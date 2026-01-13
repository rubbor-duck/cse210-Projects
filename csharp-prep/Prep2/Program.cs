using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percent of your grade? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (90 > percent && percent >= 80)
        {
            letter = "B";
        }
        else if (80 > percent && percent >= 70)
        {
            letter = "C";
        }
        else if (70 > percent && percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }



        {
            Console.WriteLine($"You got an {letter}. ");
        }

        if (percent >= 70)
        {
            Console.WriteLine("Great Job! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sadly, you didn't pass. You go this next time!");
        }
    }
}