using System.Runtime.InteropServices;

public class ChecklistGoal : Goals
{
    private int _listLength;
    private int _completedPoints;
    private int _numberDone;

    // constructors
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

    // Updates the completeness of the goal
    public override void RecordEvent()
    {
        _numberDone += 1;
        
        // if the number of parts done is the same as the total number of parts in the goal, then update the _complete attribute
        if (_numberDone == _listLength)
        {
            _complete = true;
        }
    }

    // gets the total points earned from the goal so far
     public override int GetPoints()
    {
        // points for completing each part
        int total = _points * _numberDone;

        // extra points if the goal was fully completed
        if (_complete == true)
        {
            total += _completedPoints;
        }
        return total;
    }

    // Converts attributes into a single string for storing in a txt file
    public override string GetStringRepresentation()
    {
        string stringrep = $"CheckListGoal:{GetName()}:{GetDescription()}:{_points}:{IsComplete()}:{_listLength}:{_completedPoints}:{_numberDone}";

        return stringrep;
    }

    // converts the attributes into a nice format to be displayed to the user
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