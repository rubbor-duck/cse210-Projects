using System.Threading.Tasks.Dataflow;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, string endingMessage)
    {
        base.SetAcivityName(name);
        base.SetDescription(description);
        base.SetDuration(0);
        base.SetEndingMessage(endingMessage);
    }

    public void StartBreathingActivity()
    {
        base.Start();

        Console.Clear();

        for (int i = GetDuration(); i>0; i-=10)
        {
            Console.WriteLine("Breathe in...");
            base.Timer(5, true);

            Console.Clear();
            Console.WriteLine("Breathe out...");
            base.Timer(5, true);

            Console.Clear();
        }

        Console.WriteLine(base.GetEndingMessage());
    }
}