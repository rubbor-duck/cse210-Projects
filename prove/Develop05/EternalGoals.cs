using System.Reflection.Metadata.Ecma335;

public class EternalGoals : Goals
{
    private int _timesCompleted;

    public EternalGoals(string name, string description, int points) : base(name, description, points)
    {
        _timesCompleted = 0;
        
    }

    public EternalGoals(string name, string description, int points, bool completed, int timesCompleted) : base(name, description, points, completed)
    {
        _timesCompleted = timesCompleted;
        
    }


    public override void RecordEvent()
    {
        _timesCompleted += 1;
    }

    public override int GetPoints()
    {
        int total = _points * _timesCompleted;
        return total;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"EternalGoals:{GetName()}:{GetDescription()}:{_points}:{_complete}:{_timesCompleted}";

        return stringrep;
    }

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