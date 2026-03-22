using System.Reflection.Metadata.Ecma335;

public class EternalGoals : Goals
{
    private int _timesCompleted;

    // constructors
    public EternalGoals(string name, string description, int points) : base(name, description, points)
    {
        _timesCompleted = 0;
        
    }

    public EternalGoals(string name, string description, int points, bool completed, int timesCompleted) : base(name, description, points, completed)
    {
        _timesCompleted = timesCompleted;
        
    }

    // updates the number of times the goal has been completed
    public override void RecordEvent()
    {
        _timesCompleted += 1;
    }

    // multiplies the points by _timesCompleted
    public override int GetPoints()
    {
        int total = _points * _timesCompleted;
        return total;
    }

    // returns _timesCompleted
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    // converts the attributes to one string for storing in txt files
    public override string GetStringRepresentation()
    {
        string stringrep = $"EternalGoals:{GetName()}:{GetDescription()}:{_points}:{_complete}:{_timesCompleted}";

        return stringrep;
    }

    // converts the attributes into a nice format for displaying to the user
    public override string DisplayStringDetails()
    {
        string checkbox;

        if (IsComplete() == true)
        {
            checkbox = "[x]";
        }

        else
        {
            checkbox = "[_]";
        }

        string details = $"Name: {GetName()}\nDescription: {GetDescription()}\n# of points worth: {GetPoints()}\nHas been completed {_timesCompleted} times";

        return details;
    }
}