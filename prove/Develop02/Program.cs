using System;

//I added a goals class to my program for the Show Creativity and Exceeding Requirements



class Program
{
    // This function acts as the main select screen for the use to choose their option.
    static int SelectFunction()
    {
        Console.Write($"Please Select a Function\n0. Exit\n1. New Entry\n2. Display Latest Journal\n3. Display all Journals\n4. Save Journal to File\n5. Load Journal from File\n6. Set New Goal\nSelection: ");

        string preSelection;
        preSelection = Console.ReadLine();
        int selection = int.Parse(preSelection);
        return selection;
    }
    
    static void Main(string[] args)
    {
        int selection = -1;
        
        //creates a new journal entry and sets it to null
        JournalEntry entry = null;

        //creates a new journal manager that is used to save to a file and used to load from a file
        JournalToFile jFile = new JournalToFile();

        //creates Goals class and loads the previous goal
        Goals goal = new Goals();
        goal.LoadGoal();

        while (selection != 0)
        {

            //calls the main menu to pop up
            selection = SelectFunction();

        // Exit loop. Asks if the user wants to save before closing the program
        if (selection == 0)
            {
                 for(;;)
                {
                    Console.Write("Do you want to save before you close the program? (y/n):  ");
                    string save = Console.ReadLine();
                
               

                    if (save == "y")
                    {
                        jFile.Save();
                        break; 
                    }
                    
                    
                    else if (save == "n")
                        break;

                    // if the user doesn't choose y or n, then it will pop up this error and loop back
                    else
                    {
                        Console.WriteLine("please select either 'y' or 'n'");
                        Console.WriteLine();
                    }
                }
            }
        
        // calls for user input to create a new journal entry w/prompt. Saves the entry to the journal manager "jFile"
        // Displays the current goal before asking for input
        else if (selection == 1)
            {
                Console.WriteLine();
                goal.DisplayGoal();
                Console.WriteLine();
                entry = new JournalEntry();
                entry.GetInput();
                jFile.AddEntry(entry);
            }
        
        // Displays the last journal entry to be added to jFile. 
        else if (selection == 2)
            {
                if (entry != null)
                {
                    entry.Display();
                }

                //If nothing has been added to jFile, it will display a message instead.
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("There is nothing to display");
                    Console.WriteLine();
                }
            }

        // Displays all the journal entries in jFile
        else if (selection == 3)
            {
                jFile.DisplayAllJournals();
            }

        // Saves the journal entries to a user specified file
        else if (selection == 4)
            {
                jFile.Save();
            }

        // Loads journal entries from a user specified file. Will overwrite what is already written in jFile.
        else if (selection == 5)
            {
                jFile.Load();
            }

        // Allows the user to set the goal they want to work on
        else if (selection == 6)
            {
                goal.CurrentGoal();
                goal.SaveGoal();
            }

        // if the user chooses a number not in the menu, it will pop up this error message
        else
            {
                Console.WriteLine("Please select a valid function");
            }
        }

    }
}