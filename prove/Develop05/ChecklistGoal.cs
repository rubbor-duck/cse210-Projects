public class ChecklistGoals : Goals
{
    private int _numberDone;
    private int _listLength;
    private int _completedPoints;
    
    public ChecklistGoals(string name, string description, int points, int listLength, int completedPoints) : base(name, description, points)
    {
        _numberDone = 0;
        _listLength = listLength;
        _completedPoints = completedPoints;
    }

    public override void RecordEvent()
    {
        _numberDone += 1;
        
        if (_numberDone == _listLength)
        {
            _complete = true;
        }
    }

     public int TotalPoints()
    {
        int total = GetPoints() * _numberDone;

        if (_complete == true)
        {
            total += _completedPoints;
        }
        return total;
    }

    public double GetPercentDone()
    {
        double percent = _numberDone/_listLength;
        return percent;
    }

}