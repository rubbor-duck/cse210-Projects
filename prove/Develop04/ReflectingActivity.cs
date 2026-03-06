public class ReflectingActivity : Activity
{
    
    private List<string> _promptList = new List<string> {"...", "...", "..."};
    private Prompt _prompt = new Prompt();
    private List<string> _questionList = new List<string>();
    private Prompt _questions = new Prompt();

    public ReflectingActivity(string name, string description, string endingMessage)
    {
        base.SetAcivityName(name);
        base.SetDescription(description);
        base.SetDuration(0);
        base.SetEndingMessage(endingMessage);
        _prompt.SetRandomPrompt(_promptList);
        _questions.SetRandomPrompt(_questionList);
    }

    public void StartReflectionAcivity()
    {
        base.Start();

        Console.WriteLine(_prompt.GetRandomPrompt());
        
        for (int i = GetDuration(); i>0; i-=10)
        {
            Console.WriteLine(_questions.GetRandomPrompt());
            base.Timer(10, false);
        }
        
        Console.WriteLine(base.GetEndingMessage());
    }
}