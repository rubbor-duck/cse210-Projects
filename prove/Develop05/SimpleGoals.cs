public class SimpleGoals : Goals
{
    public SimpleGoals(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        _complete = true;
    }

}