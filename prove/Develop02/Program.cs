using System;

class Program
{

    static int SelectFunction()
    {
        Console.Write($"Please Select a Function\n1. New Entry\n2. Display Journal\n3. Save Journal to File\n4. Load Journal from File\n5. Exit\nSelection: ");

        string preSelection;
        preSelection = Console.ReadLine();
        int selection = int.Parse(preSelection);
        return selection;
    }

    static void Main(string[] args)
    {

    int selection = 0;

    while (selection != 5)
        {

            selection = SelectFunction();


        if (selection == 1)
            {
                JournalEntry.NewEntry();
            }

        else if (selection == 2)
            {
                JournalEntry.Display();
            }

        else if (selection == 3)
            {
                JournalToFile.Save();
            }

        else if (selection == 4)
            {
                JournalToFile.Load();
            }

        else if (selection == 5)
            {
                continue;
            }
        
        else
            {
                Console.WriteLine("Please select a valid function");
            }
        }

    }
}