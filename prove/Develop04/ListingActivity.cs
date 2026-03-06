using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {"...", "...", "..."};
    private Prompt _randomPrompt = new Prompt();

    public ListingActivity(string name, string description, int duration, string endingMessage)
    {
        base.SetAcivityName(name);
        base.SetDescription(description);
        base.SetDuration(duration);
        base.SetEndingMessage(endingMessage);
        _randomPrompt.SetRandomPrompt(_prompts);
    }

    public void StartListingActivity()
    {
        base.Start();
        
        Console.WriteLine(_randomPrompt.GetRandomPrompt());
        base.Timer(10, true);

        Console.Write("List as many items as you can (press enter to submit an item): ");
        
        for (int i = GetDuration(); i>0; i-- )
        {
            // TODO
        }
        
        
        
        Console.WriteLine(base.GetEndingMessage());
    }
}