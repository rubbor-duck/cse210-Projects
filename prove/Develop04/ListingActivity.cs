using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {"What are your favorite things in life?", "What good things have happened to you today?", "What good did you do in the world today?", "What are some personal strengths of yours?"};
    private Prompt _randomPrompt = new Prompt();
    private List<string> _userList = new List<string>();

    public ListingActivity(string name, string description, string endingMessage)
    {
        base.SetAcivityName(name);
        base.SetDescription(description);
        base.SetDuration(0);
        base.SetEndingMessage(endingMessage);
        _randomPrompt.SetRandomPrompt(_prompts);
    }

    public void StartListingActivity()
    {
        base.Start();
        
        Console.WriteLine(_randomPrompt.GetRandomPrompt());
        base.Timer(5, true);

        Console.Write("List as many items as you can (press enter to submit an item): ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            _userList.Add(Console.ReadLine());
        }
        
        int total = _userList.Count();

        Console.WriteLine();
        Console.WriteLine($"You wrote {total} things for the prompt. Good Job!");
        Console.WriteLine();
        
        Console.WriteLine(base.GetEndingMessage());
    }
}