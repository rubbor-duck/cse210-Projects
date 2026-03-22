using System.Xml.Linq;


class Program {
    static void Main(string[] args)
    {
        int selection = -1;
        string name;
        string description;
        int points;

        List<Goals> goals = new List<Goals>();

        while (selection != 0)
        {
            Console.WriteLine("-------- Goals Program --------");
            Console.WriteLine("1. New Simple Goal\n2. New Eternal Goal\n3. New Checklist Goal\n4. Update a Goal\n5. Get total score\n6. Show All Goals\n7. Save to file\n8. Load from file\n0. Exit the program");
            Console.Write("Please choose a selection: ");
            selection = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (selection)
            {
                case 1:
                    Console.Write("What name do you want: ");
                    name = Console.ReadLine();

                    Console.Write("What is the description: ");
                    description = Console.ReadLine();

                    Console.Write("How many points will this be worth: ");
                    points = int.Parse(Console.ReadLine());

                    SimpleGoals simple = new SimpleGoals(name, description, points);

                    goals.Add(simple);
                    break;

                case 2:
                    Console.Write("What name do you want: ");
                    name = Console.ReadLine();

                    Console.Write("What is the description: ");
                    description = Console.ReadLine();

                    Console.Write("How many points will this be worth: ");
                    points = int.Parse(Console.ReadLine());

                    EternalGoals eternal = new EternalGoals(name, description, points);

                    goals.Add(eternal);
                    break;

                case 3:
                    Console.Write("What name do you want: ");
                    name = Console.ReadLine();

                    Console.Write("What is the description: ");
                    description = Console.ReadLine();

                    Console.Write("How many points will each part of this be worth: ");
                    points = int.Parse(Console.ReadLine());

                    Console.Write("How many parts are there to this: ");
                    int listLength = int.Parse(Console.ReadLine());

                    Console.Write("How many points is completing this goal worth: ");
                    int completedPoints = int.Parse(Console.ReadLine());

                    ChecklistGoal checklist = new ChecklistGoal(name, description, points, listLength, completedPoints);

                    goals.Add(checklist);
                    break;

                case 4:
                    Console.Write("What goal do you want to update: ");
                    string goalname = Console.ReadLine();

                    foreach (Goals goal in goals)
                    {
                        if (goal.GetName() == goalname)
                        {
                            goal.RecordEvent();
                            Console.WriteLine("Goal has been updated");
                            break;
                        }

                        else
                        {
                            continue;
                        }
                    }

                    break;

                case 5:
                    int totalscore = 0;
                    
                    Console.WriteLine("");
                    
                    foreach (Goals goals_point in goals)
                    {
                        totalscore += goals_point.GetPoints();
                    }

                    Console.WriteLine($"Your total score is {totalscore}");
                    break;

                case 6:
                    Console.WriteLine("");
                    foreach (Goals goal_list in goals)
                    {
                        Console.WriteLine(goal_list.DisplayStringDetails());

                        Console.WriteLine("");
                    }
                    break;

                case 7:
                    Save(goals);
                    break;

                case 8:
                    goals.Clear();
                    Load(goals);
                    break;

                case 0:
                // exits the program
                    break;

            }

            Console.WriteLine();
        }
    }


    // saves the goals to a user specified file
    static void Save(List<Goals> goal_list)
    {
        string fileName;

        // gets the file name to save to
        Console.Write("What file would you like to save to? ");
        fileName = Console.ReadLine();

        // writes to a file
        using (StreamWriter _writer = new StreamWriter(fileName))
        {
            // iterates through all the goals in the list
            foreach (Goals goal in goal_list)
            {
                // converts the goal list into an array of strings for easier writing to file
                string stringrep = goal.GetStringRepresentation();

                // writes the array to the selected file
                _writer.WriteLine(stringrep);
                _writer.WriteLine("");
            }
        }
    }

    static void Load(List<Goals> goal_list)
{
        string fileName;

        // gets the file name to load from
        Console.Write("What file would you like to load from? ");
        fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] parts = null;

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            parts = line.Split(":");
            
            string goaltype = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool completed = bool.Parse(parts[4]);

            if (goaltype == "SimpleGoals")
            {
                SimpleGoals simple = new SimpleGoals(name, description, points, completed);
                goal_list.Add(simple);
            }

            else if (goaltype == "EternalGoals")
            {
                int timesCompleted = int.Parse(parts[5]);

                EternalGoals eternal = new EternalGoals(name, description, points, completed, timesCompleted);
                goal_list.Add(eternal);
            }

            else if (goaltype == "CheckListGoal")
            {
                int listLength = int.Parse(parts[5]);
                int completedPoints = int.Parse(parts[6]);
                int numberDone = int.Parse(parts[7]);

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, completed, listLength, completedPoints, numberDone);
                goal_list.Add(checklist);
            }

        }
}

}