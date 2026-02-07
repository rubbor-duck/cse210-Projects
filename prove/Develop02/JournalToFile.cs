using System.Formats.Asn1;

//This class is the blueprint for each journal entry
public class JournalEntry()
{
    public string _input;

    // displays the lastest journal entry
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine(_input);
        Console.WriteLine();
    }

    // gets input from user to write a jounral entry
    // gets the date as well as gets the random prompt to display
    public void GetInput()
    {
        string _date = GetDate();
        
        GetPrompt();

        Console.Write($"{_date}: ");
        _input = _date + Console.ReadLine();
        
        Console.WriteLine();
    }

    // chooses a random prompt by getting a random number, and pulls from an array of different prompts
    public void GetPrompt()
    {
        List<string> _prompt = new List<string>();
        _prompt.Add("What would nice thing would you say to your roommate?");
        _prompt.Add("What nice thing has happend to you today?");
        _prompt.Add("How did I see the hand of the Lord in my life today?");
        _prompt.Add("What good did I do today?");
        _prompt.Add("What would you like to improve upon?");
        
        Random _random = new Random();
        int _randomNumber = _random.Next(0,5);
        Console.WriteLine(_prompt[_randomNumber]);

    }

    // gets the current date from the comptuer
    public string GetDate()
    {
        string _currentDate = DateTime.Now.ToString("M/d/yyyy: ");
        return _currentDate;
    }
}

// journal entry file manager
public class JournalToFile
{

    public string _fileName;
    
    public List<JournalEntry> _currentJournal = new List<JournalEntry>();
    
    // adds the lastest journal entry to the file manager
    public void AddEntry(JournalEntry _input)
    {
        _currentJournal.Add(_input);
    }

    // saves the file manager to a user specified file
    public void Save()
    {
        Console.Write("What file would you like to save to? ");
        _fileName = Console.ReadLine();

        using (StreamWriter _writer = new StreamWriter(_fileName))
        {
            //Saves the file as a bunch of strings with "|" separating them
            string _journalString = string.Join("| ", _currentJournal.Select(item => item._input));
            _writer.WriteLine(_journalString);
        }
    }

    // loads from a user specified file to the file manager
    public void Load()
    {
        _currentJournal.Clear();

        Console.Write("What file would you like to read from? ");
        _fileName = Console.ReadLine();

        using (StreamReader _reader = new StreamReader(_fileName))
        {
            // reads from the file, and splits the txt into an array
            string text = _reader.ReadToEnd();
            string[] _journals = text.Split('|', StringSplitOptions.RemoveEmptyEntries);

            foreach (string _p in _journals)
            {
            // iterates through the array and adds the journal entries to the _input attribute
            JournalEntry _addJournal = new JournalEntry();
            _addJournal._input = _p;

            _currentJournal.Add(_addJournal);
            }
        }
    }

    // displays all the journal entries from the file manager
    public void DisplayAllJournals()
    {
        Console.WriteLine();

        foreach (JournalEntry _x in _currentJournal)
        {
            Console.WriteLine(_x._input);
        }

        Console.WriteLine();
    }
    

}

// stores and shows goals at the beginning of the program
public class Goals
{
    public string _workingGoal;

    public string _goalFile = "goals.txt";

    //Saves the goal into a file
    public void SaveGoal()
    {
        File.WriteAllText(_goalFile, _workingGoal);
    }

    //Loads the goal from a file
    public void LoadGoal()
{
    if (File.Exists(_goalFile))
    {
        _workingGoal = File.ReadAllText(_goalFile);
    }
    else
    {
        _workingGoal = "[No goal set yet]";
    }
}

    // Sets the current working goal
    public void CurrentGoal()
    {
        Console.Write("What goal do you want to work on throughout this week? ");
        _workingGoal = Console.ReadLine();
    }

    // Displays the current working goal with a motivational quote added to it
    public void DisplayGoal()
    {
        List<string> _goalMotivation = new List<string>();

        _goalMotivation.Add("'The goal is not to be better than the other man, but your previous self.' —Dalai Lama");
        _goalMotivation.Add("'Obstacles are those frightful things you see when you take your eyes off your goal.' ―Henry Ford");
        _goalMotivation.Add("The Lord is proud of the effort you are making");
        _goalMotivation.Add("'If a goal is worth having, it's worth blocking out the time in your day-to-day life necessary to achieve it.' —Jill Koenig");
        _goalMotivation.Add("Our main goal is to become like Jesus. Remember, that He will send angels to aid you.");

        Random _random = new Random();
        int _randomNumber = _random.Next(0,5);

        Console.WriteLine(_goalMotivation[_randomNumber]);
        Console.WriteLine($"Goal: {_workingGoal}");
    }



}