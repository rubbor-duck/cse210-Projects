using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private string _endingMessage;

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetAcivityName(string activityName)
    {
        _activityName = activityName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void SetEndingMessage(string endingMessage)
    {
        _endingMessage = endingMessage;
    }

    public void Timer(int duration, bool countdown)
    {
        if (countdown == true) // if the activity wants a countdown instead of an animation
        {
            Console.WriteLine();
             for (int i = duration; i > 0; i--) // counts down from the specified duration
            {
                Console.Write(i); // displays the time left
                
                Thread.Sleep(1000);

                Console.Write("\b \b"); // erases the last time
            }
        }

        else
        {
        for (int i = duration; i > 0; i--) // counts down from the specified duration
        {
            PauseAnimation(); // shows pause animation every second
        }
        }
    }
    
    public void PauseAnimation() // Pause Animation takes 1 second to cycle through
    {
        Console.Write("|");

        Thread.Sleep(250);

        Console.Write("\b \b"); // Erase the | character
        Console.Write("/"); // Replace with /

        Thread.Sleep(250);

        Console.Write("\b \b"); // Erase the / character
        Console.Write("-");// Replace with --

        Thread.Sleep(250);

        Console.Write("\b \b"); // Erase the -- character
        Console.Write("\\"); // Replace with \

        Thread.Sleep(250);

        Console.Write("\b \b");
    }

    public void Start()
    {
        // starting code for all activities. Shows the activty name, description, and asks for duration.
        Console.WriteLine($"{GetActivityName()}: {GetDescription()}");
        Console.Write("How long do you want to do this activity for (in seconds): ");
        SetDuration(int.Parse(Console.ReadLine()));
    }
}