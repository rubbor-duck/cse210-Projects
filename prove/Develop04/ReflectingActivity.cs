public class ReflectingActivity : Activity
{
    
    private List<string> _promptList = new List<string> {"Think of a time when someone stood up for you.", "Think of a time when you saw the Savior's hand in your life.", "Think of a time when you did something truly selfless."};
    private Prompt _prompt = new Prompt();
    private List<string> _questionList = new List<string>
    {"Why was this experience meaningful to you?", 
    "What is your favorite thing about this experience?", 
    "What could you learn from this experience that applies to other situations?", 
    "What did you learn about yourself through this experience?", 
    "How can you keep this experience in mind in the future?",
    "How did you feel when it was complete?",
    "Have you ever done or had anything like this done to you before?",
    "How can you thank the Lord for this experience"};
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