using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Markiplier = new Assignment("Markiplier", "Iron Lung");
        MathAssignment David = new MathAssignment("David Mark", "Fractions", 7.3, "20-42");
        WritingAssignment Johnathan = new WritingAssignment("Jonathan", "Multiplication", "10 Tricks Mathmatitions Don't Want You To Know");

        Console.WriteLine(Markiplier.GetSummary());
        Console.WriteLine();
        Console.WriteLine(David.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(Johnathan.GetWritingInformation());

    }
}