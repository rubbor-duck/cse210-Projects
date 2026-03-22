public class SimpleGoals : Goals
{
    // constructors for a simple goal
    public SimpleGoals(string name, string description, int points) : base(name, description, points)
    {

    }

    public SimpleGoals(string name, string description, int points, bool completed) : base(name, description, points, completed)
    {

    }

    // changes the RecordEvent to update the _complete to true
    public override void RecordEvent()
    {
        _complete = true;
    }

    // Gets the points the goal is worth if the goal is completed
    public override int GetPoints()
    {
        if (_complete == true)
        {
            return _points;    
        }

        else
        {
            return 0;
        }
    }

    // converts the attributes into one string to be stored into a txt file
    public override string GetStringRepresentation()
    {
       string stringrep = $"SimpleGoals:{GetName()}:{GetDescription()}:{_points}:{_complete}";

        return stringrep;
    }

}