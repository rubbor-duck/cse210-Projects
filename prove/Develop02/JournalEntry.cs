public class JournalEntry()
{
    public string _input;

    



    public void NewEntry()
    {
        GetPrompt();
        _input = GetInput();
        

    }




    public string GetInput()
    {
        string x;
        string _date = GetDate();
        Console.Write($"{_date}: ");
        x = Console.ReadLine();
        return x;
    }

    public string GetPrompt()
    {
        string prompt;
        Console.WriteLine(prompt);

    }

    public string GetDate()
    {
        
    }
}