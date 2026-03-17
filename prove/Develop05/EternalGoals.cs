using System.Reflection.Metadata.Ecma335;

public class EternalGoals : Goals
{
    private int _timesCompleted;

    public EternalGoals(string name, string description, int points) : base(name, description, points)
    {
        _timesCompleted = 0;
        
    }

    public override void RecordEvent()
    {
        _timesCompleted += 1;
    }

    public int TotalPoints()
    {
        int total = GetPoints() * _timesCompleted;
        return total;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    

}