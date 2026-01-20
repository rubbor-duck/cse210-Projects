using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1,100);

        int guess = 0;

        while (guess != random)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            
            if (guess > random)
            {
                Console.WriteLine("Lower");
            }
            
            else if (guess == random)
            {
                continue;
            }

            else
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You guessed it correctly!");

    }

}