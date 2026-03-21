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
        string stringrep = $"Goal:{GetName}:{GetDescription}:{_points}:{_complete}:{_timesCompleted}";

        return stringrep;
    }
}