using System;
using System.Runtime.InteropServices;

class Program
{
   

    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        int selection = -1;

        Console.WriteLine("ō͡≡o˞ Vehicle Manager ō͡≡o˞");
        Console.WriteLine("1. Save File\n2. Load File\n4. New Vehicle\n3. Refuel Vehicle\n4. Start Vehicle\n5. Vehicle Details");
        {

            switch(selection)
            {
                case 1:
                Save(vehicles);
                break;

                case 2:
                vehicles.Clear();
                Load(vehicles);
                break;

                case 3:
                NewVehicle();
                break;

                case 4:
                ();
                break;

                case 5:
                VehicleDetails();
                break;
            }
        
    }







        // saves the goals to a user specified file
    static void Save(List<Vehicle> vehicles)
    {
        string fileName;

        // gets the file name to save to
        Console.Write("What file would you like to save to? ");
        fileName = Console.ReadLine();

        // writes to a file
        using (StreamWriter _writer = new StreamWriter(fileName))
        {
            // iterates through all the goals in the list
            foreach (Vehicle vehicle in vehicles)
            {
                // converts the goal list into an array of strings for easier writing to file
                string stringrep = vehicle.GetStringRepresentation();

                // writes the array to the selected file
                _writer.WriteLine(stringrep);
                _writer.WriteLine("");
            }
        }
    }

    static void Load(List<Vehicle> vehicles)
{
        string fileName;

        // gets the file name to load from
        Console.Write("What file would you like to load from? ");
        fileName = Console.ReadLine();

        // creates an array of all the lines of the file
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] parts = null;

        // goes through each line and breaks the lines down into individual strings
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            // splits the string by ":"
            parts = line.Split(":");
            
            // line split up into its different values
            string goaltype = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool completed = bool.Parse(parts[4]);

            // checks the goal type, then loads the attributes into a new goal that gets added to the overarching goal list
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
}