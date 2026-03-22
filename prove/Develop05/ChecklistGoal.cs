using System.Runtime.InteropServices;

public class ChecklistGoal : Goals
{
    private int _listLength;
    private int _completedPoints;
    private int _numberDone;

    public ChecklistGoal(string name, string description, int points, int listLength, int completedPoints) : base(name, description, points)
    {
        _numberDone = 0;
        _listLength = listLength;
        _completedPoints = completedPoints;
    }

    public ChecklistGoal(string name, string description, int points, bool completed, int listLength, int completedPoints, int numberDone) : base(name, description, points, completed)
    {
        _numberDone = numberDone;
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

     public override int GetPoints()
    {
        int total = _points * _numberDone;

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

    public override string GetStringRepresentation()
    {
        string stringrep = $"CheckListGoal:{GetName()}:{GetDescription()}:{_points}:{IsComplete()}:{_listLength}:{_completedPoints}:{_numberDone}";

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
        
        string details = $"Name: {GetName()}\nDescription: {GetDescription()}\n# of points worth: {GetPoints()}\nIs it complete: {checkbox}\n{_numberDone}/{_listLength} has been completed\nYou will get {_completedPoints} points when the goal is fully completed";

        return details;
    }
}