// goal entry file manager
using System.IO.Pipes;

public class GoalManager
{

    private string _fileName;

    

    // loads from a user specified file to the file manager
    // TODO
    public void Load(List<Goals> goals1)
    {
        goals1.Clear();

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

            _currentGoals.Add(_addJournal);
            }
        }
    }

    // displays all the journal entries from the file manager
    public void DisplayAllJournals()
    {
        Console.WriteLine();

        foreach (JournalEntry _x in _currentGoals)
        {
            Console.WriteLine(_x._input);
        }

        Console.WriteLine();
    }
    

}