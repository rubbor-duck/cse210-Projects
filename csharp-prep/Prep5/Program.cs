using System;

class Program
{
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

    static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            string favorite = Console.ReadLine();
            int number = int.Parse(favorite);

            return number;
        }

    static void PromptUserBirthYear(out int x)
        {
            x = 0;
            string y;
            Console.Write("What year were you born: ");
            y = Console.ReadLine();
            x = int.Parse(y);



        }

    static int SquareNumber(int number)
        {
            int square;
            square = number * number;
            return square;
        }

    static void DisplayResult(string userName, int square, int year)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - year;
            
            Console.WriteLine($"{userName}, the square of your number is {square}");
            Console.WriteLine($"{userName}, you will turn {age} this year.");

        }

    
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        
        int x;
        PromptUserBirthYear(out x);

        int square = SquareNumber(number);

        DisplayResult(userName, square, x);
    }
}