using System.Xml.Linq;

int x = -1;

while (x != 0)
{
    Console.WriteLine("1. New Simple Goal\n2. New Eternal Goal\n3. New Checklist Goal\n4. Save to file\n5. Load from file");
    Console.Write("Please choose a selection: ");
    switch (x)
    {
        case 1:
            SimpleGoals;
            break;

        case 2:
            EternalGoals;
            break;

        case 3:
            ChecklistGoals;
            break;

        case 4:
            "Save to File";
            break;

        case 5:
            "Load to File";
            break;

        case 0:
        // exits the program
            break;
        
    }
    


}