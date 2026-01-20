using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int uInput = 1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Type a List of numbers, then type 0 when finished");

        while (uInput != 0)
        {
            Console.Write("Enter A Number: ");
            string input = Console.ReadLine();
            uInput = int.Parse(input);

            numbers.Add(uInput);

        }

        int add = 0;
        int sum = 0;
        int average = 0;
        int total = 0;
        int large = 0;

        for (int i = 0; i < numbers.Count; i++)
        {

            add = numbers[i];
            sum = sum + add;

            if (large < add)
            {
                large = add;
            }

            else
            {
                continue;
            }

        }
        total = numbers.Count - 1;

        average = sum/total;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average} ");
        Console.WriteLine($"The largest number is: {large}");
    }
}